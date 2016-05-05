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
    public interface IAttachmentsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Create an attachment to a line item
        /// </summary>
        /// <remarks>
        /// Create an attachment to a line item
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="lineItemId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Attachment</returns>
        Attachment LineitemAttachment (string quoteId, string lineItemId, Attachment jSONBody);
  
        /// <summary>
        /// Create an attachment to a line item
        /// </summary>
        /// <remarks>
        /// Create an attachment to a line item
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="lineItemId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>ApiResponse of Attachment</returns>
        ApiResponse<Attachment> LineitemAttachmentWithHttpInfo (string quoteId, string lineItemId, Attachment jSONBody);
        
        /// <summary>
        /// Create an attachment to a quote
        /// </summary>
        /// <remarks>
        /// Create an attachment to a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Attachment</returns>
        Attachment QuoteAttachment (string quoteId, Attachment jSONBody);
  
        /// <summary>
        /// Create an attachment to a quote
        /// </summary>
        /// <remarks>
        /// Create an attachment to a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>ApiResponse of Attachment</returns>
        ApiResponse<Attachment> QuoteAttachmentWithHttpInfo (string quoteId, Attachment jSONBody);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Create an attachment to a line item
        /// </summary>
        /// <remarks>
        /// Create an attachment to a line item
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="lineItemId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Task of Attachment</returns>
        System.Threading.Tasks.Task<Attachment> LineitemAttachmentAsync (string quoteId, string lineItemId, Attachment jSONBody);

        /// <summary>
        /// Create an attachment to a line item
        /// </summary>
        /// <remarks>
        /// Create an attachment to a line item
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="lineItemId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Task of ApiResponse (Attachment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Attachment>> LineitemAttachmentAsyncWithHttpInfo (string quoteId, string lineItemId, Attachment jSONBody);
        
        /// <summary>
        /// Create an attachment to a quote
        /// </summary>
        /// <remarks>
        /// Create an attachment to a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Task of Attachment</returns>
        System.Threading.Tasks.Task<Attachment> QuoteAttachmentAsync (string quoteId, Attachment jSONBody);

        /// <summary>
        /// Create an attachment to a quote
        /// </summary>
        /// <remarks>
        /// Create an attachment to a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Task of ApiResponse (Attachment)</returns>
        System.Threading.Tasks.Task<ApiResponse<Attachment>> QuoteAttachmentAsyncWithHttpInfo (string quoteId, Attachment jSONBody);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AttachmentsApi : IAttachmentsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AttachmentsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AttachmentsApi(Configuration configuration = null)
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
        /// Create an attachment to a line item Create an attachment to a line item
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param> 
        /// <param name="lineItemId"></param> 
        /// <param name="jSONBody"></param> 
        /// <returns>Attachment</returns>
        public Attachment LineitemAttachment (string quoteId, string lineItemId, Attachment jSONBody)
        {
             ApiResponse<Attachment> localVarResponse = LineitemAttachmentWithHttpInfo(quoteId, lineItemId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an attachment to a line item Create an attachment to a line item
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param> 
        /// <param name="lineItemId"></param> 
        /// <param name="jSONBody"></param> 
        /// <returns>ApiResponse of Attachment</returns>
        public ApiResponse< Attachment > LineitemAttachmentWithHttpInfo (string quoteId, string lineItemId, Attachment jSONBody)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling AttachmentsApi->LineitemAttachment");
            
            // verify the required parameter 'lineItemId' is set
            if (lineItemId == null)
                throw new ApiException(400, "Missing required parameter 'lineItemId' when calling AttachmentsApi->LineitemAttachment");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling AttachmentsApi->LineitemAttachment");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems/{line_item_id}/attachments";
    
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
            if (quoteId != null) localVarPathParams.Add("quote_id", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            if (lineItemId != null) localVarPathParams.Add("line_item_id", Configuration.ApiClient.ParameterToString(lineItemId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling LineitemAttachment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LineitemAttachment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Attachment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attachment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Attachment)));
            
        }

        
        /// <summary>
        /// Create an attachment to a line item Create an attachment to a line item
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="lineItemId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Task of Attachment</returns>
        public async System.Threading.Tasks.Task<Attachment> LineitemAttachmentAsync (string quoteId, string lineItemId, Attachment jSONBody)
        {
             ApiResponse<Attachment> localVarResponse = await LineitemAttachmentAsyncWithHttpInfo(quoteId, lineItemId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an attachment to a line item Create an attachment to a line item
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="lineItemId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Task of ApiResponse (Attachment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Attachment>> LineitemAttachmentAsyncWithHttpInfo (string quoteId, string lineItemId, Attachment jSONBody)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling LineitemAttachment");
            // verify the required parameter 'lineItemId' is set
            if (lineItemId == null) throw new ApiException(400, "Missing required parameter 'lineItemId' when calling LineitemAttachment");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling LineitemAttachment");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems/{line_item_id}/attachments";
    
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
            if (quoteId != null) localVarPathParams.Add("quote_id", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            if (lineItemId != null) localVarPathParams.Add("line_item_id", Configuration.ApiClient.ParameterToString(lineItemId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling LineitemAttachment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling LineitemAttachment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Attachment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attachment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Attachment)));
            
        }
        
        /// <summary>
        /// Create an attachment to a quote Create an attachment to a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param> 
        /// <param name="jSONBody"></param> 
        /// <returns>Attachment</returns>
        public Attachment QuoteAttachment (string quoteId, Attachment jSONBody)
        {
             ApiResponse<Attachment> localVarResponse = QuoteAttachmentWithHttpInfo(quoteId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an attachment to a quote Create an attachment to a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param> 
        /// <param name="jSONBody"></param> 
        /// <returns>ApiResponse of Attachment</returns>
        public ApiResponse< Attachment > QuoteAttachmentWithHttpInfo (string quoteId, Attachment jSONBody)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling AttachmentsApi->QuoteAttachment");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling AttachmentsApi->QuoteAttachment");
            
    
            var localVarPath = "/quotes/{quote_id}/attachments";
    
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
            if (quoteId != null) localVarPathParams.Add("quote_id", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling QuoteAttachment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QuoteAttachment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Attachment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attachment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Attachment)));
            
        }

        
        /// <summary>
        /// Create an attachment to a quote Create an attachment to a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Task of Attachment</returns>
        public async System.Threading.Tasks.Task<Attachment> QuoteAttachmentAsync (string quoteId, Attachment jSONBody)
        {
             ApiResponse<Attachment> localVarResponse = await QuoteAttachmentAsyncWithHttpInfo(quoteId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an attachment to a quote Create an attachment to a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId"></param>
        /// <param name="jSONBody"></param>
        /// <returns>Task of ApiResponse (Attachment)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Attachment>> QuoteAttachmentAsyncWithHttpInfo (string quoteId, Attachment jSONBody)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling QuoteAttachment");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling QuoteAttachment");
            
    
            var localVarPath = "/quotes/{quote_id}/attachments";
    
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
            if (quoteId != null) localVarPathParams.Add("quote_id", Configuration.ApiClient.ParameterToString(quoteId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling QuoteAttachment: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QuoteAttachment: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Attachment>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Attachment) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Attachment)));
            
        }
        
    }
    
}
