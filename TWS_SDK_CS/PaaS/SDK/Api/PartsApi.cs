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
    public interface IPartsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Creates a new part
        /// </summary>
        /// <remarks>
        /// Creates a new part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part json to create a new part</param>
        /// <returns>Part</returns>
        Part CreatePart (CreatePartOptions jSONBody);
  
        /// <summary>
        /// Creates a new part
        /// </summary>
        /// <remarks>
        /// Creates a new part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part json to create a new part</param>
        /// <returns>ApiResponse of Part</returns>
        ApiResponse<Part> CreatePartWithHttpInfo (CreatePartOptions jSONBody);
        
        /// <summary>
        /// Deletes a part
        /// </summary>
        /// <remarks>
        /// Deletes a part. If a part is associated with LineItem, this will be denied.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID to delete</param>
        /// <returns></returns>
        void DeletePart (string partId);
  
        /// <summary>
        /// Deletes a part
        /// </summary>
        /// <remarks>
        /// Deletes a part. If a part is associated with LineItem, this will be denied.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePartWithHttpInfo (string partId);
        
        /// <summary>
        /// Get a part
        /// </summary>
        /// <remarks>
        /// Get a part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">part ID</param>
        /// <returns>Part</returns>
        Part GetPart (string partId);
  
        /// <summary>
        /// Get a part
        /// </summary>
        /// <remarks>
        /// Get a part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">part ID</param>
        /// <returns>ApiResponse of Part</returns>
        ApiResponse<Part> GetPartWithHttpInfo (string partId);
        
        /// <summary>
        /// Get parts
        /// </summary>
        /// <remarks>
        /// Get parts
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Returns parts belong to given quote_id. In this case, sort/order params will not be applied. (optional)</param>
        /// <param name="sort">Possible options: &#39;created_at&#39;(default), &#39;name&#39;, &#39;volume&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="notUsed">status filtering (default: true) (optional)</param>
        /// <param name="quoted">status filtering (default: true) (optional)</param>
        /// <param name="ordered">status filtering (default: true) (optional)</param>
        /// <param name="visible">filtering (default: empty or null) (optional)</param>
        /// <param name="keyword">searching keyword for part name or quote id (optional)</param>
        /// <param name="skipDuplicated">retrieve only unique files (optional)</param>
        /// <returns>Parts</returns>
        Parts GetParts (string quoteId = null, string sort = null, string order = null, int? page = null, int? perPage = null, bool? notUsed = null, bool? quoted = null, bool? ordered = null, bool? visible = null, string keyword = null, bool? skipDuplicated = null);
  
        /// <summary>
        /// Get parts
        /// </summary>
        /// <remarks>
        /// Get parts
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Returns parts belong to given quote_id. In this case, sort/order params will not be applied. (optional)</param>
        /// <param name="sort">Possible options: &#39;created_at&#39;(default), &#39;name&#39;, &#39;volume&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="notUsed">status filtering (default: true) (optional)</param>
        /// <param name="quoted">status filtering (default: true) (optional)</param>
        /// <param name="ordered">status filtering (default: true) (optional)</param>
        /// <param name="visible">filtering (default: empty or null) (optional)</param>
        /// <param name="keyword">searching keyword for part name or quote id (optional)</param>
        /// <param name="skipDuplicated">retrieve only unique files (optional)</param>
        /// <returns>ApiResponse of Parts</returns>
        ApiResponse<Parts> GetPartsWithHttpInfo (string quoteId = null, string sort = null, string order = null, int? page = null, int? perPage = null, bool? notUsed = null, bool? quoted = null, bool? ordered = null, bool? visible = null, string keyword = null, bool? skipDuplicated = null);
        
        /// <summary>
        /// Updates a part
        /// </summary>
        /// <remarks>
        /// Updates a part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID</param>
        /// <param name="jSONBody">Part json to update a part</param>
        /// <returns>Part</returns>
        Part UpdatePart (string partId, UpdatePartOptions jSONBody);
  
        /// <summary>
        /// Updates a part
        /// </summary>
        /// <remarks>
        /// Updates a part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID</param>
        /// <param name="jSONBody">Part json to update a part</param>
        /// <returns>ApiResponse of Part</returns>
        ApiResponse<Part> UpdatePartWithHttpInfo (string partId, UpdatePartOptions jSONBody);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Creates a new part
        /// </summary>
        /// <remarks>
        /// Creates a new part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part json to create a new part</param>
        /// <returns>Task of Part</returns>
        System.Threading.Tasks.Task<Part> CreatePartAsync (CreatePartOptions jSONBody);

        /// <summary>
        /// Creates a new part
        /// </summary>
        /// <remarks>
        /// Creates a new part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part json to create a new part</param>
        /// <returns>Task of ApiResponse (Part)</returns>
        System.Threading.Tasks.Task<ApiResponse<Part>> CreatePartAsyncWithHttpInfo (CreatePartOptions jSONBody);
        
        /// <summary>
        /// Deletes a part
        /// </summary>
        /// <remarks>
        /// Deletes a part. If a part is associated with LineItem, this will be denied.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePartAsync (string partId);

        /// <summary>
        /// Deletes a part
        /// </summary>
        /// <remarks>
        /// Deletes a part. If a part is associated with LineItem, this will be denied.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePartAsyncWithHttpInfo (string partId);
        
        /// <summary>
        /// Get a part
        /// </summary>
        /// <remarks>
        /// Get a part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">part ID</param>
        /// <returns>Task of Part</returns>
        System.Threading.Tasks.Task<Part> GetPartAsync (string partId);

        /// <summary>
        /// Get a part
        /// </summary>
        /// <remarks>
        /// Get a part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">part ID</param>
        /// <returns>Task of ApiResponse (Part)</returns>
        System.Threading.Tasks.Task<ApiResponse<Part>> GetPartAsyncWithHttpInfo (string partId);
        
        /// <summary>
        /// Get parts
        /// </summary>
        /// <remarks>
        /// Get parts
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Returns parts belong to given quote_id. In this case, sort/order params will not be applied. (optional)</param>
        /// <param name="sort">Possible options: &#39;created_at&#39;(default), &#39;name&#39;, &#39;volume&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="notUsed">status filtering (default: true) (optional)</param>
        /// <param name="quoted">status filtering (default: true) (optional)</param>
        /// <param name="ordered">status filtering (default: true) (optional)</param>
        /// <param name="visible">filtering (default: empty or null) (optional)</param>
        /// <param name="keyword">searching keyword for part name or quote id (optional)</param>
        /// <param name="skipDuplicated">retrieve only unique files (optional)</param>
        /// <returns>Task of Parts</returns>
        System.Threading.Tasks.Task<Parts> GetPartsAsync (string quoteId = null, string sort = null, string order = null, int? page = null, int? perPage = null, bool? notUsed = null, bool? quoted = null, bool? ordered = null, bool? visible = null, string keyword = null, bool? skipDuplicated = null);

        /// <summary>
        /// Get parts
        /// </summary>
        /// <remarks>
        /// Get parts
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Returns parts belong to given quote_id. In this case, sort/order params will not be applied. (optional)</param>
        /// <param name="sort">Possible options: &#39;created_at&#39;(default), &#39;name&#39;, &#39;volume&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="notUsed">status filtering (default: true) (optional)</param>
        /// <param name="quoted">status filtering (default: true) (optional)</param>
        /// <param name="ordered">status filtering (default: true) (optional)</param>
        /// <param name="visible">filtering (default: empty or null) (optional)</param>
        /// <param name="keyword">searching keyword for part name or quote id (optional)</param>
        /// <param name="skipDuplicated">retrieve only unique files (optional)</param>
        /// <returns>Task of ApiResponse (Parts)</returns>
        System.Threading.Tasks.Task<ApiResponse<Parts>> GetPartsAsyncWithHttpInfo (string quoteId = null, string sort = null, string order = null, int? page = null, int? perPage = null, bool? notUsed = null, bool? quoted = null, bool? ordered = null, bool? visible = null, string keyword = null, bool? skipDuplicated = null);
        
        /// <summary>
        /// Updates a part
        /// </summary>
        /// <remarks>
        /// Updates a part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID</param>
        /// <param name="jSONBody">Part json to update a part</param>
        /// <returns>Task of Part</returns>
        System.Threading.Tasks.Task<Part> UpdatePartAsync (string partId, UpdatePartOptions jSONBody);

        /// <summary>
        /// Updates a part
        /// </summary>
        /// <remarks>
        /// Updates a part
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID</param>
        /// <param name="jSONBody">Part json to update a part</param>
        /// <returns>Task of ApiResponse (Part)</returns>
        System.Threading.Tasks.Task<ApiResponse<Part>> UpdatePartAsyncWithHttpInfo (string partId, UpdatePartOptions jSONBody);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PartsApi : IPartsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PartsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PartsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PartsApi(Configuration configuration = null)
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
        /// Creates a new part Creates a new part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part json to create a new part</param> 
        /// <returns>Part</returns>
        public Part CreatePart (CreatePartOptions jSONBody)
        {
             ApiResponse<Part> localVarResponse = CreatePartWithHttpInfo(jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new part Creates a new part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part json to create a new part</param> 
        /// <returns>ApiResponse of Part</returns>
        public ApiResponse< Part > CreatePartWithHttpInfo (CreatePartOptions jSONBody)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling PartsApi->CreatePart");
            
    
            var localVarPath = "/parts";
    
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
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreatePart: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreatePart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Part>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Part) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Part)));
            
        }

        
        /// <summary>
        /// Creates a new part Creates a new part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part json to create a new part</param>
        /// <returns>Task of Part</returns>
        public async System.Threading.Tasks.Task<Part> CreatePartAsync (CreatePartOptions jSONBody)
        {
             ApiResponse<Part> localVarResponse = await CreatePartAsyncWithHttpInfo(jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new part Creates a new part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part json to create a new part</param>
        /// <returns>Task of ApiResponse (Part)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Part>> CreatePartAsyncWithHttpInfo (CreatePartOptions jSONBody)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling CreatePart");
            
    
            var localVarPath = "/parts";
    
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
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreatePart: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreatePart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Part>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Part) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Part)));
            
        }
        
        /// <summary>
        /// Deletes a part Deletes a part. If a part is associated with LineItem, this will be denied.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID to delete</param> 
        /// <returns></returns>
        public void DeletePart (string partId)
        {
             DeletePartWithHttpInfo(partId);
        }

        /// <summary>
        /// Deletes a part Deletes a part. If a part is associated with LineItem, this will be denied.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePartWithHttpInfo (string partId)
        {
            
            // verify the required parameter 'partId' is set
            if (partId == null)
                throw new ApiException(400, "Missing required parameter 'partId' when calling PartsApi->DeletePart");
            
    
            var localVarPath = "/parts/{part_id}";
    
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
            if (partId != null) localVarPathParams.Add("part_id", Configuration.ApiClient.ParameterToString(partId)); // path parameter
            
            
            
            
            

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletePart: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Deletes a part Deletes a part. If a part is associated with LineItem, this will be denied.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePartAsync (string partId)
        {
             await DeletePartAsyncWithHttpInfo(partId);

        }

        /// <summary>
        /// Deletes a part Deletes a part. If a part is associated with LineItem, this will be denied.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePartAsyncWithHttpInfo (string partId)
        {
            // verify the required parameter 'partId' is set
            if (partId == null) throw new ApiException(400, "Missing required parameter 'partId' when calling DeletePart");
            
    
            var localVarPath = "/parts/{part_id}";
    
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
            if (partId != null) localVarPathParams.Add("part_id", Configuration.ApiClient.ParameterToString(partId)); // path parameter
            
            
            
            
            

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeletePart: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeletePart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get a part Get a part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">part ID</param> 
        /// <returns>Part</returns>
        public Part GetPart (string partId)
        {
             ApiResponse<Part> localVarResponse = GetPartWithHttpInfo(partId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a part Get a part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">part ID</param> 
        /// <returns>ApiResponse of Part</returns>
        public ApiResponse< Part > GetPartWithHttpInfo (string partId)
        {
            
            // verify the required parameter 'partId' is set
            if (partId == null)
                throw new ApiException(400, "Missing required parameter 'partId' when calling PartsApi->GetPart");
            
    
            var localVarPath = "/parts/{part_id}";
    
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
            if (partId != null) localVarPathParams.Add("part_id", Configuration.ApiClient.ParameterToString(partId)); // path parameter
            
            
            
            
            

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
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
                throw new ApiException (localVarStatusCode, "Error calling GetPart: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Part>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Part) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Part)));
            
        }

        
        /// <summary>
        /// Get a part Get a part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">part ID</param>
        /// <returns>Task of Part</returns>
        public async System.Threading.Tasks.Task<Part> GetPartAsync (string partId)
        {
             ApiResponse<Part> localVarResponse = await GetPartAsyncWithHttpInfo(partId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a part Get a part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">part ID</param>
        /// <returns>Task of ApiResponse (Part)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Part>> GetPartAsyncWithHttpInfo (string partId)
        {
            // verify the required parameter 'partId' is set
            if (partId == null) throw new ApiException(400, "Missing required parameter 'partId' when calling GetPart");
            
    
            var localVarPath = "/parts/{part_id}";
    
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
            if (partId != null) localVarPathParams.Add("part_id", Configuration.ApiClient.ParameterToString(partId)); // path parameter
            
            
            
            
            

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
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
                throw new ApiException (localVarStatusCode, "Error calling GetPart: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Part>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Part) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Part)));
            
        }
        
        /// <summary>
        /// Get parts Get parts
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Returns parts belong to given quote_id. In this case, sort/order params will not be applied. (optional)</param> 
        /// <param name="sort">Possible options: &#39;created_at&#39;(default), &#39;name&#39;, &#39;volume&#39; (optional)</param> 
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param> 
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <param name="notUsed">status filtering (default: true) (optional)</param> 
        /// <param name="quoted">status filtering (default: true) (optional)</param> 
        /// <param name="ordered">status filtering (default: true) (optional)</param> 
        /// <param name="visible">filtering (default: empty or null) (optional)</param> 
        /// <param name="keyword">searching keyword for part name or quote id (optional)</param> 
        /// <param name="skipDuplicated">retrieve only unique files (optional)</param> 
        /// <returns>Parts</returns>
        public Parts GetParts (string quoteId = null, string sort = null, string order = null, int? page = null, int? perPage = null, bool? notUsed = null, bool? quoted = null, bool? ordered = null, bool? visible = null, string keyword = null, bool? skipDuplicated = null)
        {
             ApiResponse<Parts> localVarResponse = GetPartsWithHttpInfo(quoteId, sort, order, page, perPage, notUsed, quoted, ordered, visible, keyword, skipDuplicated);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get parts Get parts
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Returns parts belong to given quote_id. In this case, sort/order params will not be applied. (optional)</param> 
        /// <param name="sort">Possible options: &#39;created_at&#39;(default), &#39;name&#39;, &#39;volume&#39; (optional)</param> 
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param> 
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <param name="notUsed">status filtering (default: true) (optional)</param> 
        /// <param name="quoted">status filtering (default: true) (optional)</param> 
        /// <param name="ordered">status filtering (default: true) (optional)</param> 
        /// <param name="visible">filtering (default: empty or null) (optional)</param> 
        /// <param name="keyword">searching keyword for part name or quote id (optional)</param> 
        /// <param name="skipDuplicated">retrieve only unique files (optional)</param> 
        /// <returns>ApiResponse of Parts</returns>
        public ApiResponse< Parts > GetPartsWithHttpInfo (string quoteId = null, string sort = null, string order = null, int? page = null, int? perPage = null, bool? notUsed = null, bool? quoted = null, bool? ordered = null, bool? visible = null, string keyword = null, bool? skipDuplicated = null)
        {
            
    
            var localVarPath = "/parts";
    
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
            
            if (quoteId != null) localVarQueryParams.Add("quote_id", Configuration.ApiClient.ParameterToString(quoteId)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (notUsed != null) localVarQueryParams.Add("not_used", Configuration.ApiClient.ParameterToString(notUsed)); // query parameter
            if (quoted != null) localVarQueryParams.Add("quoted", Configuration.ApiClient.ParameterToString(quoted)); // query parameter
            if (ordered != null) localVarQueryParams.Add("ordered", Configuration.ApiClient.ParameterToString(ordered)); // query parameter
            if (visible != null) localVarQueryParams.Add("visible", Configuration.ApiClient.ParameterToString(visible)); // query parameter
            if (keyword != null) localVarQueryParams.Add("keyword", Configuration.ApiClient.ParameterToString(keyword)); // query parameter
            if (skipDuplicated != null) localVarQueryParams.Add("skip_duplicated", Configuration.ApiClient.ParameterToString(skipDuplicated)); // query parameter
            
            
            
            

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
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
                throw new ApiException (localVarStatusCode, "Error calling GetParts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Parts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Parts) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Parts)));
            
        }

        
        /// <summary>
        /// Get parts Get parts
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Returns parts belong to given quote_id. In this case, sort/order params will not be applied. (optional)</param>
        /// <param name="sort">Possible options: &#39;created_at&#39;(default), &#39;name&#39;, &#39;volume&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="notUsed">status filtering (default: true) (optional)</param>
        /// <param name="quoted">status filtering (default: true) (optional)</param>
        /// <param name="ordered">status filtering (default: true) (optional)</param>
        /// <param name="visible">filtering (default: empty or null) (optional)</param>
        /// <param name="keyword">searching keyword for part name or quote id (optional)</param>
        /// <param name="skipDuplicated">retrieve only unique files (optional)</param>
        /// <returns>Task of Parts</returns>
        public async System.Threading.Tasks.Task<Parts> GetPartsAsync (string quoteId = null, string sort = null, string order = null, int? page = null, int? perPage = null, bool? notUsed = null, bool? quoted = null, bool? ordered = null, bool? visible = null, string keyword = null, bool? skipDuplicated = null)
        {
             ApiResponse<Parts> localVarResponse = await GetPartsAsyncWithHttpInfo(quoteId, sort, order, page, perPage, notUsed, quoted, ordered, visible, keyword, skipDuplicated);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get parts Get parts
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Returns parts belong to given quote_id. In this case, sort/order params will not be applied. (optional)</param>
        /// <param name="sort">Possible options: &#39;created_at&#39;(default), &#39;name&#39;, &#39;volume&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="notUsed">status filtering (default: true) (optional)</param>
        /// <param name="quoted">status filtering (default: true) (optional)</param>
        /// <param name="ordered">status filtering (default: true) (optional)</param>
        /// <param name="visible">filtering (default: empty or null) (optional)</param>
        /// <param name="keyword">searching keyword for part name or quote id (optional)</param>
        /// <param name="skipDuplicated">retrieve only unique files (optional)</param>
        /// <returns>Task of ApiResponse (Parts)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Parts>> GetPartsAsyncWithHttpInfo (string quoteId = null, string sort = null, string order = null, int? page = null, int? perPage = null, bool? notUsed = null, bool? quoted = null, bool? ordered = null, bool? visible = null, string keyword = null, bool? skipDuplicated = null)
        {
            
    
            var localVarPath = "/parts";
    
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
            
            if (quoteId != null) localVarQueryParams.Add("quote_id", Configuration.ApiClient.ParameterToString(quoteId)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (notUsed != null) localVarQueryParams.Add("not_used", Configuration.ApiClient.ParameterToString(notUsed)); // query parameter
            if (quoted != null) localVarQueryParams.Add("quoted", Configuration.ApiClient.ParameterToString(quoted)); // query parameter
            if (ordered != null) localVarQueryParams.Add("ordered", Configuration.ApiClient.ParameterToString(ordered)); // query parameter
            if (visible != null) localVarQueryParams.Add("visible", Configuration.ApiClient.ParameterToString(visible)); // query parameter
            if (keyword != null) localVarQueryParams.Add("keyword", Configuration.ApiClient.ParameterToString(keyword)); // query parameter
            if (skipDuplicated != null) localVarQueryParams.Add("skip_duplicated", Configuration.ApiClient.ParameterToString(skipDuplicated)); // query parameter
            
            
            
            

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
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
                throw new ApiException (localVarStatusCode, "Error calling GetParts: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetParts: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Parts>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Parts) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Parts)));
            
        }
        
        /// <summary>
        /// Updates a part Updates a part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID</param> 
        /// <param name="jSONBody">Part json to update a part</param> 
        /// <returns>Part</returns>
        public Part UpdatePart (string partId, UpdatePartOptions jSONBody)
        {
             ApiResponse<Part> localVarResponse = UpdatePartWithHttpInfo(partId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates a part Updates a part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID</param> 
        /// <param name="jSONBody">Part json to update a part</param> 
        /// <returns>ApiResponse of Part</returns>
        public ApiResponse< Part > UpdatePartWithHttpInfo (string partId, UpdatePartOptions jSONBody)
        {
            
            // verify the required parameter 'partId' is set
            if (partId == null)
                throw new ApiException(400, "Missing required parameter 'partId' when calling PartsApi->UpdatePart");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling PartsApi->UpdatePart");
            
    
            var localVarPath = "/parts/{part_id}";
    
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
            if (partId != null) localVarPathParams.Add("part_id", Configuration.ApiClient.ParameterToString(partId)); // path parameter
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePart: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Part>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Part) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Part)));
            
        }

        
        /// <summary>
        /// Updates a part Updates a part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID</param>
        /// <param name="jSONBody">Part json to update a part</param>
        /// <returns>Task of Part</returns>
        public async System.Threading.Tasks.Task<Part> UpdatePartAsync (string partId, UpdatePartOptions jSONBody)
        {
             ApiResponse<Part> localVarResponse = await UpdatePartAsyncWithHttpInfo(partId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates a part Updates a part
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="partId">Part ID</param>
        /// <param name="jSONBody">Part json to update a part</param>
        /// <returns>Task of ApiResponse (Part)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Part>> UpdatePartAsyncWithHttpInfo (string partId, UpdatePartOptions jSONBody)
        {
            // verify the required parameter 'partId' is set
            if (partId == null) throw new ApiException(400, "Missing required parameter 'partId' when calling UpdatePart");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UpdatePart");
            
    
            var localVarPath = "/parts/{part_id}";
    
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
            if (partId != null) localVarPathParams.Add("part_id", Configuration.ApiClient.ParameterToString(partId)); // path parameter
            
            
            
            
            if (jSONBody.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jSONBody); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jSONBody; // byte array
            }

            
            // authentication (user_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("user_token")))
            {
                localVarQueryParams["user_token"] = Configuration.GetApiKeyWithPrefix("user_token");
            }
            
            // authentication (api_auth) required
            
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }
            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePart: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdatePart: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Part>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Part) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Part)));
            
        }
        
    }
    
}
