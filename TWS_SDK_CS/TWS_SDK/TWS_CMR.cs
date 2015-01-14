using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Net;
using System.Collections;
using System.Threading;
using Json = Newtonsoft.Json.Linq;

namespace TWS_SDK
{
    public class TWS_CMR : TWS
    {
        static private string CHUNK_EXTENSION = ".tws";

        public TWS_CMR(string key, string secret, string api_version = null, string stom_host = null, string stor_host = null, string stid_host = null)
            : base(key, secret, api_version, stom_host, stor_host, stid_host)
        {
        }

        private bool putURL(Json.JObject jobj, object _mapLinks)
        {
            Dictionary<string, string> mapLinks = _mapLinks as Dictionary<string, string>;
            if (!(jobj is Json.JObject))
                return false;
            if (jobj["class_type"] == null || (string)jobj["class_type"] != "StovChunk")
                return false;
            long expire_seconds = 0;
            string expire_seconds_str = null;
            if (mapLinks.TryGetValue("expire_seconds", out expire_seconds_str))
                expire_seconds = Int32.Parse(expire_seconds_str);

            //if (jobj["id"] == null || jobj["stor_id"] == null)
            //    return;
            string stov_id = (string)jobj["id"];
            string stor_id = (string)jobj["stor_id"];

            if (stov_id == null || stor_id == null)
                return false;

            string link;
            if (!mapLinks.TryGetValue(stor_id, out link))
            {
                string filename = stov_id + CHUNK_EXTENSION;

                if (jobj["filename"] != null && ((string)jobj["filename"]).Length > 0)
                {
                    filename = (string)jobj["filename"];
                }
                else
                {
                    filename = stov_id + CHUNK_EXTENSION;
                }
                link = getLink(stor_id, filename, expire_seconds);
                
                if (link != null)
                    mapLinks.Add(stor_id, link);
            }

            if (link != null)
                jobj.Add("url", new Json.JValue(link));
            
            return true;
        }

        private bool convertURL2Local(Json.JObject jobj, object _mapLinks)
        {
            Dictionary<string, string> mapLinks = _mapLinks as Dictionary<string, string>;
            string base_dir;
            if (!mapLinks.TryGetValue("base_directory", out base_dir))
                return false;

            if (!(jobj is Json.JObject))
                return false;
            if (jobj["class_type"] == null || (string)jobj["class_type"] != "StovChunk")
                return false;

            string stov_id = (string)jobj["id"];
            string stor_id = (string)jobj["stor_id"];

            if (stov_id == null || stor_id == null)
                return false;

            string link;
            if (!mapLinks.TryGetValue(stor_id, out link))
            {
                if (jobj["url"] != null)
                {
                    string filename;
                    if (jobj["filename"] != null)
                    {
                        filename = base_dir + "/" + (string)jobj["filename"];
                    }
                    else {
                        filename = base_dir + "/" + stov_id + CHUNK_EXTENSION;
                    }

                    using (System.Net.WebClient myWebClient = new System.Net.WebClient())
                    {
                        try {
                            myWebClient.DownloadFile((string)jobj["url"], filename);
                            link = filename;
                        }
                        catch
                        {
                        }
                    }
                }
                
                if (link != null)
                    mapLinks.Add(stor_id, link);
            }

            if (link != null)
            {
                if (jobj["filename"] != null)
                    jobj["filename"] = link;
                else
                    jobj.Add("filename", new Json.JValue(link));
            }   

            return true;
        }

        private void traverseCMR(Json.JObject jobj, object cache, Func<Json.JObject, object, bool> callback)
        {
            if (jobj == null)
                return;

            callback(jobj, cache);

            foreach (var prop in jobj)
            {
                if (prop.Value is Json.JArray)
                {
                    foreach (var child in prop.Value)
                    {
                        if (child is Json.JObject)
                            traverseCMR((Json.JObject)child, cache, callback);
                    }
                }
                else if (prop.Value is Json.JObject)
                    traverseCMR((Json.JObject)prop.Value, cache, callback);
            }
        }

        public Hashtable createCMR(string stor_id, string engine_version = "latest", bool preserve_downloaded_file = false, bool mesh_heal = false, bool clustering = false, bool wait_to_complete = false, bool check_existing = false)
        {
            Hashtable m = getModel(stor_id);
            if (m == null)
            {
                throw new Exception(string.Format("Invalid stor_id: {0}", stor_id));
            }
            Dictionary<string, object> meta = m["meta"] as Dictionary<string, object>;
            object cmr_status = null;
            if (meta != null)
                meta.TryGetValue("cmr_status", out cmr_status);

            if (check_existing && cmr_status != null)
            {
                switch (cmr_status as string)
                {
                    case "processing":
                    case "complete":
                    case "error":
                        Hashtable status = new Hashtable();
                        status.Add("cmr_status", cmr_status);
                        return status;
                }
            }
            
            Hashtable session = createSession("3600", engine_version);
            if (session == null)
                return null;

            try
            {
                string session_id = (string)session["id"];

                if (meta != null && wait_to_complete)
                {
                    if (cmr_status != null)
                        meta["cmr_status"] = "processing";
                    else
                        meta.Add("cmr_status", "processing");
                    updateModel(stor_id, meta);
                }

                string code = string.Format(
@"
from cmr import Cmr
c = Cmr(api_key='{0}', api_secret='{1}', keep_downloaded_files={2}, mesh_heal={3}, max_regions={4}, max_triangles=0)
conv_result = c.convert('{5}')
print(json.dumps(conv_result))"
                    , m_api_key, m_api_secret,
                    preserve_downloaded_file ? "True" : "False",
                    mesh_heal ? "True" : "False",
                    clustering ? "200" : "1",
                    stor_id);

                Hashtable run = createRun(session_id, "blender", code);
                if (wait_to_complete)
                {
                    string run_id = Convert.ToString(run["id"]);

                    int iRet = 0;
                    while (run["state"] as string != "complete" && run["state"] as string != "error" && iRet < 3600)
                    {
                        Thread.Sleep(1000);
                        run = getRun(session_id, run_id);
                        iRet++;
                    }
                    if (meta != null)
                    {
                        m = getModel(stor_id);
                        meta = m["meta"] as Dictionary<string, object>;
                        if (meta != null && meta.TryGetValue("cmr_status", out cmr_status))
                        {
                            try
                            {
                                Json.JObject result = Json.JObject.Parse(run["result"] as string);
                                if (result["CMR"] != null && result["CMR"][stor_id] != null)
                                    meta["cmr_status"] = "complete";
                                else
                                    meta["cmr_status"] = "error";
                            }
                            catch
                            {
                                meta["cmr_status"] = "error";
                            }
                            
                            updateModel(stor_id, meta);
                        }
                    }
                    closeSession(session_id);
                    return run;
                }
                return run;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string getCMR(string stor_id, long expire_seconds = 0)
        {
            Hashtable m = getModel(stor_id);

            Json.JObject cmr = null;
            try
            {
                Dictionary<string, object> meta = (Dictionary<string, object>)m["meta"];
                string strCMR = (string)meta["stov_cmr"];
                if (strCMR.Length == 0)
                    return "";
                cmr = Json.JObject.Parse(strCMR);
            }
            catch (Exception e)
            {
                return "";
            }

            if (cmr == null)
                return "";

            string result = "";  
            try
            {
                Dictionary<string, string> mapLinks = new Dictionary<string, string>();
                if (expire_seconds != 0)
                    mapLinks["expire_seconds"] = expire_seconds.ToString();
                traverseCMR(cmr, mapLinks, putURL);
                result = cmr.ToString(Newtonsoft.Json.Formatting.None);
            }
            catch (Exception e) {
                return ""; 
            }

            return result;
        }

        public string convertToLocalCMR(string cmr_json_string, string base_directory)
        {
            Json.JObject cmr = Json.JObject.Parse(cmr_json_string);

            Dictionary<string, string> mapLinks = new Dictionary<string, string>();
            mapLinks.Add("base_directory", base_directory);
            traverseCMR(cmr, mapLinks, convertURL2Local);

            string result = "";
            result = cmr.ToString(Newtonsoft.Json.Formatting.None);

            return result;
        }
    }
}
