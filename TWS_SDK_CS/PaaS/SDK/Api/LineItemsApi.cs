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
    public interface ILineItemsApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Copy line item
        /// </summary>
        /// <remarks>
        /// Copy an existing line item creating new one
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>LineItem</returns>
        LineItem CopyLineitem (string quoteId, string lineItemId);
  
        /// <summary>
        /// Copy line item
        /// </summary>
        /// <remarks>
        /// Copy an existing line item creating new one
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>ApiResponse of LineItem</returns>
        ApiResponse<LineItem> CopyLineitemWithHttpInfo (string quoteId, string lineItemId);
        
        /// <summary>
        /// Creates a new line item
        /// </summary>
        /// <remarks>
        /// Creates a new line item in a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to create a line item for</param>
        /// <param name="jSONBody">line item info to create a new line item</param>
        /// <returns>LineItem</returns>
        LineItem CreateLineitem (string quoteId, CreateLineItemOptions jSONBody);
  
        /// <summary>
        /// Creates a new line item
        /// </summary>
        /// <remarks>
        /// Creates a new line item in a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to create a line item for</param>
        /// <param name="jSONBody">line item info to create a new line item</param>
        /// <returns>ApiResponse of LineItem</returns>
        ApiResponse<LineItem> CreateLineitemWithHttpInfo (string quoteId, CreateLineItemOptions jSONBody);
        
        /// <summary>
        /// Delete a line item
        /// </summary>
        /// <remarks>
        /// Delete a line item
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns></returns>
        void DeleteLineitem (string quoteId, string lineItemId);
  
        /// <summary>
        /// Delete a line item
        /// </summary>
        /// <remarks>
        /// Delete a line item
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteLineitemWithHttpInfo (string quoteId, string lineItemId);
        
        /// <summary>
        /// Update a line item info
        /// </summary>
        /// <remarks>
        /// Update a line item info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <param name="jSONBody">Line Item info json</param>
        /// <returns>LineItem</returns>
        LineItem UpdateLineitem (string quoteId, string lineItemId, UpdateLineItemOptions jSONBody);
  
        /// <summary>
        /// Update a line item info
        /// </summary>
        /// <remarks>
        /// Update a line item info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <param name="jSONBody">Line Item info json</param>
        /// <returns>ApiResponse of LineItem</returns>
        ApiResponse<LineItem> UpdateLineitemWithHttpInfo (string quoteId, string lineItemId, UpdateLineItemOptions jSONBody);
        
        /// <summary>
        /// Update multiple line items in a quote at once
        /// </summary>
        /// <remarks>
        /// Update multiple line items in a quote at once
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id including line items to update</param>
        /// <param name="jSONBody">line items info to update. You can fill selectively what needs to be updated.</param>
        /// <returns></returns>
        void UpdateLineitems (string quoteId, UpdateLineItemsOptions jSONBody);
  
        /// <summary>
        /// Update multiple line items in a quote at once
        /// </summary>
        /// <remarks>
        /// Update multiple line items in a quote at once
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id including line items to update</param>
        /// <param name="jSONBody">line items info to update. You can fill selectively what needs to be updated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateLineitemsWithHttpInfo (string quoteId, UpdateLineItemsOptions jSONBody);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Copy line item
        /// </summary>
        /// <remarks>
        /// Copy an existing line item creating new one
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>Task of LineItem</returns>
        System.Threading.Tasks.Task<LineItem> CopyLineitemAsync (string quoteId, string lineItemId);

        /// <summary>
        /// Copy line item
        /// </summary>
        /// <remarks>
        /// Copy an existing line item creating new one
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>Task of ApiResponse (LineItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineItem>> CopyLineitemAsyncWithHttpInfo (string quoteId, string lineItemId);
        
        /// <summary>
        /// Creates a new line item
        /// </summary>
        /// <remarks>
        /// Creates a new line item in a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to create a line item for</param>
        /// <param name="jSONBody">line item info to create a new line item</param>
        /// <returns>Task of LineItem</returns>
        System.Threading.Tasks.Task<LineItem> CreateLineitemAsync (string quoteId, CreateLineItemOptions jSONBody);

        /// <summary>
        /// Creates a new line item
        /// </summary>
        /// <remarks>
        /// Creates a new line item in a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to create a line item for</param>
        /// <param name="jSONBody">line item info to create a new line item</param>
        /// <returns>Task of ApiResponse (LineItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineItem>> CreateLineitemAsyncWithHttpInfo (string quoteId, CreateLineItemOptions jSONBody);
        
        /// <summary>
        /// Delete a line item
        /// </summary>
        /// <remarks>
        /// Delete a line item
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteLineitemAsync (string quoteId, string lineItemId);

        /// <summary>
        /// Delete a line item
        /// </summary>
        /// <remarks>
        /// Delete a line item
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLineitemAsyncWithHttpInfo (string quoteId, string lineItemId);
        
        /// <summary>
        /// Update a line item info
        /// </summary>
        /// <remarks>
        /// Update a line item info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <param name="jSONBody">Line Item info json</param>
        /// <returns>Task of LineItem</returns>
        System.Threading.Tasks.Task<LineItem> UpdateLineitemAsync (string quoteId, string lineItemId, UpdateLineItemOptions jSONBody);

        /// <summary>
        /// Update a line item info
        /// </summary>
        /// <remarks>
        /// Update a line item info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <param name="jSONBody">Line Item info json</param>
        /// <returns>Task of ApiResponse (LineItem)</returns>
        System.Threading.Tasks.Task<ApiResponse<LineItem>> UpdateLineitemAsyncWithHttpInfo (string quoteId, string lineItemId, UpdateLineItemOptions jSONBody);
        
        /// <summary>
        /// Update multiple line items in a quote at once
        /// </summary>
        /// <remarks>
        /// Update multiple line items in a quote at once
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id including line items to update</param>
        /// <param name="jSONBody">line items info to update. You can fill selectively what needs to be updated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateLineitemsAsync (string quoteId, UpdateLineItemsOptions jSONBody);

        /// <summary>
        /// Update multiple line items in a quote at once
        /// </summary>
        /// <remarks>
        /// Update multiple line items in a quote at once
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id including line items to update</param>
        /// <param name="jSONBody">line items info to update. You can fill selectively what needs to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLineitemsAsyncWithHttpInfo (string quoteId, UpdateLineItemsOptions jSONBody);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LineItemsApi : ILineItemsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LineItemsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LineItemsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LineItemsApi(Configuration configuration = null)
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
        /// Copy line item Copy an existing line item creating new one
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <param name="lineItemId">Line Item ID</param> 
        /// <returns>LineItem</returns>
        public LineItem CopyLineitem (string quoteId, string lineItemId)
        {
             ApiResponse<LineItem> localVarResponse = CopyLineitemWithHttpInfo(quoteId, lineItemId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Copy line item Copy an existing line item creating new one
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <param name="lineItemId">Line Item ID</param> 
        /// <returns>ApiResponse of LineItem</returns>
        public ApiResponse< LineItem > CopyLineitemWithHttpInfo (string quoteId, string lineItemId)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling LineItemsApi->CopyLineitem");
            
            // verify the required parameter 'lineItemId' is set
            if (lineItemId == null)
                throw new ApiException(400, "Missing required parameter 'lineItemId' when calling LineItemsApi->CopyLineitem");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems/{line_item_id}/copy";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CopyLineitem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CopyLineitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LineItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineItem)));
            
        }

        
        /// <summary>
        /// Copy line item Copy an existing line item creating new one
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>Task of LineItem</returns>
        public async System.Threading.Tasks.Task<LineItem> CopyLineitemAsync (string quoteId, string lineItemId)
        {
             ApiResponse<LineItem> localVarResponse = await CopyLineitemAsyncWithHttpInfo(quoteId, lineItemId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Copy line item Copy an existing line item creating new one
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>Task of ApiResponse (LineItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineItem>> CopyLineitemAsyncWithHttpInfo (string quoteId, string lineItemId)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling CopyLineitem");
            // verify the required parameter 'lineItemId' is set
            if (lineItemId == null) throw new ApiException(400, "Missing required parameter 'lineItemId' when calling CopyLineitem");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems/{line_item_id}/copy";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CopyLineitem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CopyLineitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineItem)));
            
        }
        
        /// <summary>
        /// Creates a new line item Creates a new line item in a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to create a line item for</param> 
        /// <param name="jSONBody">line item info to create a new line item</param> 
        /// <returns>LineItem</returns>
        public LineItem CreateLineitem (string quoteId, CreateLineItemOptions jSONBody)
        {
             ApiResponse<LineItem> localVarResponse = CreateLineitemWithHttpInfo(quoteId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new line item Creates a new line item in a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to create a line item for</param> 
        /// <param name="jSONBody">line item info to create a new line item</param> 
        /// <returns>ApiResponse of LineItem</returns>
        public ApiResponse< LineItem > CreateLineitemWithHttpInfo (string quoteId, CreateLineItemOptions jSONBody)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling LineItemsApi->CreateLineitem");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling LineItemsApi->CreateLineitem");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateLineitem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateLineitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LineItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineItem)));
            
        }

        
        /// <summary>
        /// Creates a new line item Creates a new line item in a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to create a line item for</param>
        /// <param name="jSONBody">line item info to create a new line item</param>
        /// <returns>Task of LineItem</returns>
        public async System.Threading.Tasks.Task<LineItem> CreateLineitemAsync (string quoteId, CreateLineItemOptions jSONBody)
        {
             ApiResponse<LineItem> localVarResponse = await CreateLineitemAsyncWithHttpInfo(quoteId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new line item Creates a new line item in a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to create a line item for</param>
        /// <param name="jSONBody">line item info to create a new line item</param>
        /// <returns>Task of ApiResponse (LineItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineItem>> CreateLineitemAsyncWithHttpInfo (string quoteId, CreateLineItemOptions jSONBody)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling CreateLineitem");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling CreateLineitem");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateLineitem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateLineitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineItem)));
            
        }
        
        /// <summary>
        /// Delete a line item Delete a line item
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <param name="lineItemId">Line Item ID</param> 
        /// <returns></returns>
        public void DeleteLineitem (string quoteId, string lineItemId)
        {
             DeleteLineitemWithHttpInfo(quoteId, lineItemId);
        }

        /// <summary>
        /// Delete a line item Delete a line item
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <param name="lineItemId">Line Item ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteLineitemWithHttpInfo (string quoteId, string lineItemId)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling LineItemsApi->DeleteLineitem");
            
            // verify the required parameter 'lineItemId' is set
            if (lineItemId == null)
                throw new ApiException(400, "Missing required parameter 'lineItemId' when calling LineItemsApi->DeleteLineitem");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems/{line_item_id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLineitem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLineitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Delete a line item Delete a line item
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteLineitemAsync (string quoteId, string lineItemId)
        {
             await DeleteLineitemAsyncWithHttpInfo(quoteId, lineItemId);

        }

        /// <summary>
        /// Delete a line item Delete a line item
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteLineitemAsyncWithHttpInfo (string quoteId, string lineItemId)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling DeleteLineitem");
            // verify the required parameter 'lineItemId' is set
            if (lineItemId == null) throw new ApiException(400, "Missing required parameter 'lineItemId' when calling DeleteLineitem");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems/{line_item_id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteLineitem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteLineitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Update a line item info Update a line item info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <param name="lineItemId">Line Item ID</param> 
        /// <param name="jSONBody">Line Item info json</param> 
        /// <returns>LineItem</returns>
        public LineItem UpdateLineitem (string quoteId, string lineItemId, UpdateLineItemOptions jSONBody)
        {
             ApiResponse<LineItem> localVarResponse = UpdateLineitemWithHttpInfo(quoteId, lineItemId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a line item info Update a line item info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <param name="lineItemId">Line Item ID</param> 
        /// <param name="jSONBody">Line Item info json</param> 
        /// <returns>ApiResponse of LineItem</returns>
        public ApiResponse< LineItem > UpdateLineitemWithHttpInfo (string quoteId, string lineItemId, UpdateLineItemOptions jSONBody)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling LineItemsApi->UpdateLineitem");
            
            // verify the required parameter 'lineItemId' is set
            if (lineItemId == null)
                throw new ApiException(400, "Missing required parameter 'lineItemId' when calling LineItemsApi->UpdateLineitem");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling LineItemsApi->UpdateLineitem");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems/{line_item_id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLineitem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLineitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<LineItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineItem)));
            
        }

        
        /// <summary>
        /// Update a line item info Update a line item info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <param name="jSONBody">Line Item info json</param>
        /// <returns>Task of LineItem</returns>
        public async System.Threading.Tasks.Task<LineItem> UpdateLineitemAsync (string quoteId, string lineItemId, UpdateLineItemOptions jSONBody)
        {
             ApiResponse<LineItem> localVarResponse = await UpdateLineitemAsyncWithHttpInfo(quoteId, lineItemId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a line item info Update a line item info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="lineItemId">Line Item ID</param>
        /// <param name="jSONBody">Line Item info json</param>
        /// <returns>Task of ApiResponse (LineItem)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LineItem>> UpdateLineitemAsyncWithHttpInfo (string quoteId, string lineItemId, UpdateLineItemOptions jSONBody)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling UpdateLineitem");
            // verify the required parameter 'lineItemId' is set
            if (lineItemId == null) throw new ApiException(400, "Missing required parameter 'lineItemId' when calling UpdateLineitem");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UpdateLineitem");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems/{line_item_id}";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLineitem: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLineitem: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LineItem>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LineItem) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LineItem)));
            
        }
        
        /// <summary>
        /// Update multiple line items in a quote at once Update multiple line items in a quote at once
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id including line items to update</param> 
        /// <param name="jSONBody">line items info to update. You can fill selectively what needs to be updated.</param> 
        /// <returns></returns>
        public void UpdateLineitems (string quoteId, UpdateLineItemsOptions jSONBody)
        {
             UpdateLineitemsWithHttpInfo(quoteId, jSONBody);
        }

        /// <summary>
        /// Update multiple line items in a quote at once Update multiple line items in a quote at once
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id including line items to update</param> 
        /// <param name="jSONBody">line items info to update. You can fill selectively what needs to be updated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateLineitemsWithHttpInfo (string quoteId, UpdateLineItemsOptions jSONBody)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling LineItemsApi->UpdateLineitems");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling LineItemsApi->UpdateLineitems");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLineitems: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLineitems: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        
        /// <summary>
        /// Update multiple line items in a quote at once Update multiple line items in a quote at once
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id including line items to update</param>
        /// <param name="jSONBody">line items info to update. You can fill selectively what needs to be updated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateLineitemsAsync (string quoteId, UpdateLineItemsOptions jSONBody)
        {
             await UpdateLineitemsAsyncWithHttpInfo(quoteId, jSONBody);

        }

        /// <summary>
        /// Update multiple line items in a quote at once Update multiple line items in a quote at once
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id including line items to update</param>
        /// <param name="jSONBody">line items info to update. You can fill selectively what needs to be updated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateLineitemsAsyncWithHttpInfo (string quoteId, UpdateLineItemsOptions jSONBody)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling UpdateLineitems");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UpdateLineitems");
            
    
            var localVarPath = "/quotes/{quote_id}/lineitems";
    
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLineitems: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateLineitems: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
    }
    
}
