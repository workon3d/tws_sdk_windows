using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using Json = Newtonsoft.Json.Linq;

namespace TWS_SDK
{
    public class TWS_CMR : TWS
    {
        static private string CHUNK_EXTENSION = ".tws";
        static private string STOM_ENGINE_VERSION = "20140724";

        public TWS_CMR(string key, string secret, string api_version = null, string stom_host = null, string stor_host = null, string stid_host = null)
            : base(key, secret, api_version, stom_host, stor_host, stid_host)
        {
        }

        private bool putURL(Json.JObject jobj, Dictionary<string, string> mapLinks)
        {
            if (!(jobj is Json.JObject))
                return false;
            if (jobj["class_type"] == null || (string)jobj["class_type"] != "StovChunk")
                return false;
            //if (jobj["id"] == null || jobj["stor_id"] == null)
            //    return;
            string stov_id = (string)jobj["id"];
            string stor_id = (string)jobj["stor_id"];

            if (stov_id == null || stor_id == null)
                return false;

            string link;
            if (!mapLinks.TryGetValue(stor_id, out link))
            {
                
                if (jobj["filename"] != null)
                {
                    string filename = stov_id + (string)jobj["filename"] + CHUNK_EXTENSION;
                    link = getLink(stor_id, filename);
                }
                else
                {
                    link = getLink(stor_id);
                }
                
                if (link != null)
                    mapLinks.Add(stor_id, link);
            }

            if (link != null)
                jobj.Add("url", new Json.JValue(link));
            
            return true;
        }

        private void traverseCMR(Json.JObject jobj, Dictionary<string, string> cache, Func<Json.JObject, Dictionary<string, string>, bool> callback)
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

        public Hashtable createCMR(string stor_id, bool preserve_downloaded_file = false, bool mesh_heal = false, bool clustering = false)
        {
            Hashtable session = createSession("3600", STOM_ENGINE_VERSION);
            if (session == null)
                return null;

            try
            {
                string session_id = (string)session["id"];

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

                return createRun(session_id, "blender", code);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string getCMR(string stor_id)
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
                traverseCMR(cmr, mapLinks, putURL);
                result = cmr.ToString(Newtonsoft.Json.Formatting.None);
            }
            catch (Exception e) {
                return ""; 
            }

            return result;
        }
    }
}
