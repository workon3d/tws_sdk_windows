using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

using RestSharp;
using System.Security.Cryptography;
using TWS_SDK;

namespace GSExample
{
    class Program
    {
        static void Main(string[] args)
        {
              string your_api_key = "";
            string your_api_secret = "";
            string filepath = @"C:\Users\Administrator\Downloads\DatapartA.stl";

            // Upload Example
            TWS_SDK.TWS tws = new TWS_SDK.TWS(your_api_key, your_api_secret);
            Dictionary<string, object> meta = new Dictionary<string, object>();
            meta["filename"] = Path.GetFileName(filepath);
            Dictionary<string, object> opts = new Dictionary<string, object>();
            opts["meta"] = meta;
            Hashtable result = tws.uploadModel(filepath, opts);
            Console.WriteLine(result["id"]);

            // ES Authentication example
            string es_host = "https://ses-staging.herokuapp.com";
            string key_in_request_params = "";
            string signture_in_request_params = "";
            long expire_in_request_params = 0;

            var client = new RestClient(es_host);
            var request = new RestRequest("api/v1/authenticate", Method.POST);
            request.AddParameter("key", key_in_request_params);
            request.AddParameter("signature", signture_in_request_params);
            request.AddParameter("expire", expire_in_request_params);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                Console.WriteLine("Authentication success");
        }
    }
}
