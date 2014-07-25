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
        public TWS_CMR(string key, string secret, string api_version = null, string stom_host = null, string stor_host = null, string stid_host = null) : base(key, secret, api_version, stom_host, stor_host, stid_host)
        {
        }

        static private Dictionary<string, string> m_links = new Dictionary<string,string>();
        static private string CHUNK_EXTENSION = ".tws";
        
        private bool putURL(Json.JObject jobj)
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
            if (!m_links.TryGetValue(stor_id, out link))
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
                    m_links.Add(stor_id, link);
            }

            if (link != null)
                jobj.Add("url", new Json.JValue(link));
            
            return true;
        }

        private void traverseCMR(Json.JObject jobj, Func<Json.JObject, bool> callback)
        {
            if (jobj == null)
                return;

            callback(jobj);

            foreach (var prop in jobj)
            {
                if (prop.Value is Json.JArray)
                {
                    foreach (var child in prop.Value)
                    {
                        if (child is Json.JObject)
                            traverseCMR((Json.JObject)child, callback);
                    }
                }
                else if (prop.Value is Json.JObject)
                    traverseCMR((Json.JObject)prop.Value, callback);
            }
        }
 
        public string getCMR(string id)
        {
            Hashtable m = getModel(id);

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
                traverseCMR(cmr, putURL);
                result = cmr.ToString(Newtonsoft.Json.Formatting.None);
            }
            catch (Exception e) {
                return ""; 
            }

            return result;
        }
    }
}
