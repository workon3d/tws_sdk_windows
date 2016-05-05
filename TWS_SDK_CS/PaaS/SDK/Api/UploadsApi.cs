using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PaaS.SDK.Client;
using PaaS.SDK.Model;

namespace PaaS.SDK.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUploadsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Get presigned file upload parameters
        /// </summary>
        /// <remarks>
        /// File uploading is consisted of three steps. 1) Before uploading a file, API user needs to get presigned upload parameters including upload_id. 2) Upload a file using the parameters to AWS S3 bucket. curl example is included in the response. 3) Use the upload_id to create a resources like part or attachment&#39;
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverSide">Set to true for any server side file upload (optional, default to true)</param>
        /// <returns>Presign</returns>
        Presign PresignUploads (bool? serverSide = null);
  
        /// <summary>
        /// Get presigned file upload parameters
        /// </summary>
        /// <remarks>
        /// File uploading is consisted of three steps. 1) Before uploading a file, API user needs to get presigned upload parameters including upload_id. 2) Upload a file using the parameters to AWS S3 bucket. curl example is included in the response. 3) Use the upload_id to create a resources like part or attachment&#39;
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverSide">Set to true for any server side file upload (optional, default to true)</param>
        /// <returns>ApiResponse of Presign</returns>
        ApiResponse<Presign> PresignUploadsWithHttpInfo (bool? serverSide = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Get presigned file upload parameters
        /// </summary>
        /// <remarks>
        /// File uploading is consisted of three steps. 1) Before uploading a file, API user needs to get presigned upload parameters including upload_id. 2) Upload a file using the parameters to AWS S3 bucket. curl example is included in the response. 3) Use the upload_id to create a resources like part or attachment&#39;
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverSide">Set to true for any server side file upload (optional, default to true)</param>
        /// <returns>Task of Presign</returns>
        System.Threading.Tasks.Task<Presign> PresignUploadsAsync (bool? serverSide = null);

        /// <summary>
        /// Get presigned file upload parameters
        /// </summary>
        /// <remarks>
        /// File uploading is consisted of three steps. 1) Before uploading a file, API user needs to get presigned upload parameters including upload_id. 2) Upload a file using the parameters to AWS S3 bucket. curl example is included in the response. 3) Use the upload_id to create a resources like part or attachment&#39;
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverSide">Set to true for any server side file upload (optional, default to true)</param>
        /// <returns>Task of ApiResponse (Presign)</returns>
        System.Threading.Tasks.Task<ApiResponse<Presign>> PresignUploadsAsyncWithHttpInfo (bool? serverSide = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class UploadsApi : IUploadsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UploadsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UploadsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Get presigned file upload parameters File uploading is consisted of three steps. 1) Before uploading a file, API user needs to get presigned upload parameters including upload_id. 2) Upload a file using the parameters to AWS S3 bucket. curl example is included in the response. 3) Use the upload_id to create a resources like part or attachment&#39;
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverSide">Set to true for any server side file upload (optional, default to true)</param> 
        /// <returns>Presign</returns>
        public Presign PresignUploads (bool? serverSide = null)
        {
             ApiResponse<Presign> localVarResponse = PresignUploadsWithHttpInfo(serverSide);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get presigned file upload parameters File uploading is consisted of three steps. 1) Before uploading a file, API user needs to get presigned upload parameters including upload_id. 2) Upload a file using the parameters to AWS S3 bucket. curl example is included in the response. 3) Use the upload_id to create a resources like part or attachment&#39;
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverSide">Set to true for any server side file upload (optional, default to true)</param> 
        /// <returns>ApiResponse of Presign</returns>
        public ApiResponse< Presign > PresignUploadsWithHttpInfo (bool? serverSide = null)
        {
            
    
            var localVarPath = "/uploads/presign";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (serverSide != null) localVarQueryParams.Add("server_side", Configuration.ApiClient.ParameterToString(serverSide)); // query parameter
            
            
            
            

            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresignUploads: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresignUploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Presign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Presign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Presign)));
            
        }

        
        /// <summary>
        /// Get presigned file upload parameters File uploading is consisted of three steps. 1) Before uploading a file, API user needs to get presigned upload parameters including upload_id. 2) Upload a file using the parameters to AWS S3 bucket. curl example is included in the response. 3) Use the upload_id to create a resources like part or attachment&#39;
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverSide">Set to true for any server side file upload (optional, default to true)</param>
        /// <returns>Task of Presign</returns>
        public async System.Threading.Tasks.Task<Presign> PresignUploadsAsync (bool? serverSide = null)
        {
             ApiResponse<Presign> localVarResponse = await PresignUploadsAsyncWithHttpInfo(serverSide);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get presigned file upload parameters File uploading is consisted of three steps. 1) Before uploading a file, API user needs to get presigned upload parameters including upload_id. 2) Upload a file using the parameters to AWS S3 bucket. curl example is included in the response. 3) Use the upload_id to create a resources like part or attachment&#39;
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="serverSide">Set to true for any server side file upload (optional, default to true)</param>
        /// <returns>Task of ApiResponse (Presign)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Presign>> PresignUploadsAsyncWithHttpInfo (bool? serverSide = null)
        {
            
    
            var localVarPath = "/uploads/presign";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (serverSide != null) localVarQueryParams.Add("server_side", Configuration.ApiClient.ParameterToString(serverSide)); // query parameter
            
            
            
            

            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PresignUploads: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PresignUploads: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Presign>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Presign) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Presign)));
            
        }

        public bool UploadFile(Presign presign, string file_path)
        {
            try
            {
                var client = new RestClient(presign.FormAction);
                var upload_request = new RestRequest(Method.POST);
                upload_request.RequestFormat = DataFormat.Json;
                upload_request.AddParameter("AWSAccessKeyId", presign.FormFields.AWSAccessKeyId);
                upload_request.AddParameter("Key", presign.FormFields.Key);
                upload_request.AddParameter("Policy", presign.FormFields.Policy);
                upload_request.AddParameter("Secure", presign.FormFields.Secure);
                upload_request.AddParameter("Signature", presign.FormFields.Signature);
                upload_request.AddParameter("name", "");
                upload_request.AddParameter("Filename", new FileInfo(file_path).Name);
                upload_request.AddFile("file", file_path);
                IRestResponse response = client.Execute(upload_request);

                if (response.ResponseStatus != ResponseStatus.Completed || response.StatusCode != System.Net.HttpStatusCode.NoContent)
                {
                    throw new ApiException((int)response.StatusCode, string.Format("file({0}) upload failed. Response Code: {1}", presign.UploadId));
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
    
}
