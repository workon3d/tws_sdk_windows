using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Web.Script.Serialization;
using System.Collections;
using System.IO;

using RestSharp;


namespace TWS_SDK
{
    public class TWS
    {
        static private string m_api_key;
        static private string m_api_secret;
        static private string m_stom_host = "https://stom.dddws.com";
        static private string m_stor_host = "https://stor.dddws.com";
        static private string m_stid_host = "https://stid.dddws.com";
        static private string m_api_version = "1";
        static private long m_expire_seconds = 3600;

        public TWS(string key, string secret, string api_version = null, string stom_host = null, string stor_host = null, string stid_host = null)
        {
            try
            {
                m_api_key = key;
                m_api_secret = secret;
                if (api_version != null) m_api_version = api_version;
                if (stom_host != null) m_stom_host = stom_host;
                if (stor_host != null) m_stor_host = stor_host;
                if (stid_host != null) m_stid_host = stid_host;

                checkParams();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable authenticate()
        {
            try
            {
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("POST\n\n" + t + "\n/api/v" + m_api_version + "/authenticate");
                var client = new RestClient(m_stid_host);
                var request = new RestRequest("api/v" + m_api_version + "/authenticate", Method.POST);
                request.AddParameter("key", m_api_key);
                request.AddParameter("signature", sig);
                request.AddParameter("method", "POST");
                request.AddParameter("url", "/api/v1/authenticate");
                request.AddParameter("expire", t);

                IRestResponse response = client.Execute(request);
                var serializer = new JavaScriptSerializer();
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable createModel(Dictionary<string, object> meta = null, string upload_id = null)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("POST\n\n" + t + "\n/api/v" + m_api_version + "/models");
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stor_host);
                var request = new RestRequest("api/v" + m_api_version + "/models?expire=" + t, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { meta = meta, upload_id = upload_id });
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable getModel(string id = null)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("GET\n\n" + t + "\n/api/v" + m_api_version + "/models/" + id);
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stor_host);
                var request = new RestRequest("api/v" + m_api_version + "/models/" + id + "?expire=" + t, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Hashtable> getModels(Dictionary<string, string> query_params = null)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("GET\n\n" + t + "\n/api/v" + m_api_version + "/models");
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stor_host);
                var request = new RestRequest("api/v" + m_api_version + "/models?expire=" + t, Method.GET);
                request.RequestFormat = DataFormat.Json;
                if (query_params != null)
                {
                    foreach (var query in query_params)
                    {
                        request.AddParameter(query.Key, query.Value);
                    }
                }
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                List<Hashtable> result = serializer.Deserialize<List<Hashtable>>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable updateModel(string id, Dictionary<string, object> meta = null)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("PUT\n\n" + t + "\n/api/v" + m_api_version + "/models/" + id);
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stor_host);
                var request = new RestRequest("api/v" + m_api_version + "/models/" + id + "?expire=" + t, Method.PUT);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { meta = meta });
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable deleteModel(string id)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("DELETE\n\n" + t + "\n/api/v" + m_api_version + "/models/" + id);
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stor_host);
                var request = new RestRequest("api/v" + m_api_version + "/models/" + id + "?expire=" + t, Method.DELETE);
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable presignedUploadForm(Dictionary<string, string> starts_with_hash = null, string ip_str = null)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("POST\n\n" + t + "\n/api/v" + m_api_version + "/models/presign");
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stor_host);
                var request = new RestRequest("api/v" + m_api_version + "/models/presign?expire=" + t, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { ip = ip_str, starts_with = starts_with_hash });
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable uploadModel(string path, Dictionary<string, object> opts = null, string ip_str = null)
        {
            try
            {
                /* upload to pre-signed s3 url*/
                Dictionary<string, string> starts_with = null;
                try
                {
                    starts_with = (Dictionary<string, string>)opts["starts_with"];
                }
                catch(Exception e){}

                Hashtable presign = presignedUploadForm(starts_with, ip_str);
                var client = new RestClient((String)presign["form_action"]);
                var upload_request = new RestRequest(Method.POST);
                upload_request.RequestFormat = DataFormat.Json;
                Dictionary<string, object> form_field = (Dictionary<string, object>)presign["form_fields"];
                foreach (var field in form_field)
                {
                    upload_request.AddParameter(field.Key, field.Value);
                }
                upload_request.AddFile("file", path);
                IRestResponse response = client.Execute(upload_request);

                /* Create model in STOR */
                 Dictionary<string, object> meta = null;
                try
                {
                    meta =(Dictionary<string, object>)opts["meta"];
                }catch(Exception e){}

                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("POST\n\n" + t + "\n/api/v" + m_api_version + "/models");
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var create_client = new RestClient(m_stor_host);
                var create_request = new RestRequest("api/v" + m_api_version + "/models?expire=" + t, Method.POST);
                create_request.RequestFormat = DataFormat.Json;
                create_request.AddBody(new { meta = meta, upload_id = presign["upload_id"] });
                create_request.AddHeader("Authorization", auth_header);

                var serializer = new JavaScriptSerializer();
                response = create_client.Execute(create_request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string getLink(string id, string filename = null)
        {
            try
            {
                long expire_t = expire();
                string t = expire_t.ToString();
                if (filename == null)
                {
                    string sig = signature("GET\n\n" + t + "\n/api/v" + m_api_version + "/models/" + id + "/download");
                    return m_stor_host + "/api/v" + m_api_version + "/models/" + id + "/download?expire=" + t + "&key=" + m_api_key + "&signature=" + sig;
                }
                else
                {
                    string sig = signature("GET\n\n" + t + "\n/api/v" + m_api_version + "/models/" + id + "/" + System.Uri.EscapeDataString(filename));
                    return m_stor_host + "/api/v" + m_api_version + "/models/" + id + "/" + System.Uri.EscapeDataString(filename) + "?expire=" + t + "&key=" + m_api_key + "&signature=" + sig;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable requestTPTX(Dictionary<string, string> opts = null)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                var client = new RestClient("https://cloud3d.herokuapp.com");
                var request = new RestRequest("api/v1/jobs", Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new
                {
                    auth_token = "HRJ7PsKqAVzwYbV5ENaK",
                    input_url = opts["input_url"],
                    input_type = opts["input_type"],
                    include_thumbnail = opts["include_thumbnail"]
                });

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable poleTPTX(string job_id)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                var client = new RestClient("https://cloud3d.herokuapp.com");
                var request = new RestRequest("api/v1/jobs/" + job_id + "?auth_token=HRJ7PsKqAVzwYbV5ENaK", Method.GET);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Hashtable> getSessions(Dictionary<string, string> query_params = null)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("GET\n\n" + t + "\n/api/v" + m_api_version + "/sessions");
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stom_host);
                var request = new RestRequest("api/v" + m_api_version + "/sessions?expire=" + t , Method.GET);
                request.RequestFormat = DataFormat.Json;
                foreach (var query in query_params)
                {
                    request.AddParameter(query.Key, query.Value);
                }
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                List<Hashtable> result = serializer.Deserialize<List<Hashtable>>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable getSession(string id)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("GET\n\n" + t + "\n/api/v" + m_api_version + "/sessions/" + id);
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stom_host);
                var request = new RestRequest("api/v" + m_api_version + "/sessions/" + id + "?expire=" + t, Method.GET);
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable createSession(string timeout="60", string engine_ver="20140424")
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("POST\n\n" + t + "\n/api/v" + m_api_version + "/sessions");
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stom_host);
                var request = new RestRequest("api/v" + m_api_version + "/sessions?expire=" + t, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { timeout = timeout, engine_version = engine_ver });
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable closeSession(string id)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("DELETE\n\n" + t + "\n/api/v" + m_api_version + "/sessions/" + id);
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stom_host);
                var request = new RestRequest("api/v" + m_api_version + "/sessions/" + id + "?expire=" + t, Method.DELETE);
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable createRun(string id, string platform, string code)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("POST\n\n" + t + "\n/api/v" + m_api_version + "/sessions/" + id + "/runs");
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stom_host);
                var request = new RestRequest("api/v" + m_api_version + "/sessions/" + id + "/runs?expire=" + t, Method.POST);
                request.RequestFormat = DataFormat.Json;
                request.AddBody(new { platform = platform, code = code });
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Hashtable> getRuns(string id, string platform = null)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("GET\n\n" + t + "\n/api/v" + m_api_version + "/sessions/" + id + "/runs");
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stom_host);
                var request = new RestRequest("api/v" + m_api_version + "/sessions/" + id + "/runs?expire=" + t + "&platform=" + platform, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                List<Hashtable> result = serializer.Deserialize<List<Hashtable>>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Hashtable getRun(string session_id, string run_id)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                long expire_t = expire();
                string t = expire_t.ToString();
                string sig = signature("GET\n\n" + t + "\n/api/v" + m_api_version + "/sessions/" + session_id + "/runs/" + run_id);
                string auth_header = "3WS " + m_api_key + ":" + sig;
                var client = new RestClient(m_stom_host);
                var request = new RestRequest("api/v" + m_api_version + "/sessions/" + session_id + "/runs/" + run_id + "?expire=" + t, Method.GET);
                request.RequestFormat = DataFormat.Json;
                request.AddHeader("Authorization", auth_header);

                IRestResponse response = client.Execute(request);
                Hashtable result = serializer.Deserialize<Hashtable>(response.Content);
                return result;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /* private methods */
        private void checkParams()
        {
            if (m_api_key == null || m_api_secret == null ||
               m_api_version == null ||
               m_stom_host == null ||
               m_stor_host == null ||
               m_stid_host == null
            ) throw new System.ArgumentException("Parameter cannot be null", "original");
        }
        private string signature(string string_to_sign)
        {
            try
            {
                var enc = Encoding.ASCII;
                HMACSHA1 hmac = new HMACSHA1(enc.GetBytes(m_api_secret));
                hmac.Initialize();
                byte[] buffer = enc.GetBytes(string_to_sign);
                return System.Uri.EscapeDataString(System.Convert.ToBase64String(hmac.ComputeHash(buffer)));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private long expire()
        {
            TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            long now = (long)t.TotalSeconds;
            return now + m_expire_seconds;
        }

    }
}
