using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaaS.SDK.Client;
using PaaS.SDK.Api;
using PaaS.SDK.Model;

namespace PaaSExample
{
    class Program
    {
        static void Main(string[] args)
        {
            UploadPartAndCreateQuoteForAnonymousUserExample();
        }

        static void UploadPartAndCreateQuoteExample()
        {
            string api_host = "https://paas-working.dddws.com/api/v1";
            // development: https://paas-working.dddws.com/api/v1
            // staging: https://paas-staging.dddws.com/api/v1
            // production: https://paas.dddws.com/api/v1
            string fronend_url = "http://qpe-working.herokuapp.com";
            string api_token = "your api token";
            string user_email = "end user email";
            string password = "end user password";
            string filepath = @"M:\work\test\PaaSSDK\sample\Datapart O.stl";

            ApiClient client = new ApiClient(api_host);
            Configuration configuration = new PaaS.SDK.Client.Configuration(client, null, null, null, null,
                new Dictionary<string, string>() { { "api_token", api_token } }
            );
            UsersApi user_api = new UsersApi(configuration);
            AuthenticateUserOptions autho_input = new AuthenticateUserOptions(user_email, password);
            UserAuthenticated auth_res = user_api.AuthenticateUser(autho_input);
            if (auth_res != null)
            {
                configuration.ApiKey["user_token"] = auth_res.UserToken;
            }

            UploadsApi upload_api = new UploadsApi(configuration);
            QuotesApi quote_api = new QuotesApi(configuration);
            LineItemsApi lineitem_api = new LineItemsApi(configuration);
            PartsApi part_api = new PartsApi(configuration);

            Presign presign = upload_api.PresignUploads();
            string stor_id = presign.UploadId;
            FileInfo finfo = new FileInfo(filepath);

            if (upload_api.UploadFile(presign, filepath))
            {
                Part part = part_api.CreatePart(new CreatePartOptions(stor_id, finfo.Name, (int)finfo.Length));
                // create empty quote
                Quote quote = quote_api.CreateQuote();
                CreateLineItemOptions default_li = new CreateLineItemOptions(part.PartId, 1, null, new BuildSpec(56));
                LineItem li = lineitem_api.CreateLineitem(quote.QuoteId.ToString(), default_li);
                Console.WriteLine(string.Format("{0}/quotations/{1}/detail", fronend_url, quote.QuoteId));
            }
        }

        static void UploadPartAndCreateQuoteForAnonymousUserExample()
        {
            string api_host = "https://paas-working.dddws.com/api/v1";
            // development: https://paas-working.dddws.com/api/v1
            // staging: https://paas-staging.dddws.com/api/v1
            // production: https://paas.dddws.com/api/v1
            string fronend_url = "http://qpe-working.herokuapp.com";
            string api_token = "your api token";
            string filepath = @"M:\work\test\PaaSSDK\sample\Datapart O.stl";

            ApiClient client = new ApiClient(api_host);
            // set configuration with 'none' for user_token
            Configuration configuration = new PaaS.SDK.Client.Configuration(client, null, null, null, null,
                new Dictionary<string, string>() { { "api_token", api_token }, { "user_token", "none" } }
            );
        
            UploadsApi upload_api = new UploadsApi(configuration);
            PartsApi part_api = new PartsApi(configuration);
            QuotesApi quote_api = new QuotesApi(configuration);
            LineItemsApi lineitem_api = new LineItemsApi(configuration);

            Presign presign = upload_api.PresignUploads();
            string stor_id = presign.UploadId;
            FileInfo finfo = new FileInfo(filepath);

            if (upload_api.UploadFile(presign, filepath))
            {
                Part part = part_api.CreatePart(new CreatePartOptions(stor_id, finfo.Name, (int)finfo.Length));
                // create empty quote
                Quote quote = quote_api.CreateQuote();
                
                // get temporary user token and make new configuration with it.
                configuration.ApiKey["user_token"] = quote.TemporaryUserToken;
            
                CreateLineItemOptions default_li = new CreateLineItemOptions(part.PartId, 1, null, new BuildSpec(56));
                LineItem li = lineitem_api.CreateLineitem(quote.QuoteId.ToString(), default_li);
                Console.WriteLine(string.Format("{0}/quotations/{1}/detail?temporary_user_token={2}", fronend_url, quote.QuoteId, quote.TemporaryUserToken));
            }
        }
    }
}
