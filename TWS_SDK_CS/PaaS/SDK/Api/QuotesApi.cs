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
    public interface IQuotesApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Creates a new quote
        /// </summary>
        /// <remarks>
        /// Creates a new empty quote that will be a placeholder to add LineItems
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Quote</returns>
        Quote CreateQuote ();
  
        /// <summary>
        /// Creates a new quote
        /// </summary>
        /// <remarks>
        /// Creates a new empty quote that will be a placeholder to add LineItems
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Quote</returns>
        ApiResponse<Quote> CreateQuoteWithHttpInfo ();
        
        /// <summary>
        /// Get a price instantly
        /// </summary>
        /// <remarks>
        /// Get a price of given part info and build spec without creating actual quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part info and build spec json</param>
        /// <returns>Price</returns>
        Price GetPrice (GetPriceOptions jSONBody);
  
        /// <summary>
        /// Get a price instantly
        /// </summary>
        /// <remarks>
        /// Get a price of given part info and build spec without creating actual quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part info and build spec json</param>
        /// <returns>ApiResponse of Price</returns>
        ApiResponse<Price> GetPriceWithHttpInfo (GetPriceOptions jSONBody);
        
        /// <summary>
        /// Get a quote info
        /// </summary>
        /// <remarks>
        /// Get a quote info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <returns>Quote</returns>
        Quote GetQuote (string quoteId);
  
        /// <summary>
        /// Get a quote info
        /// </summary>
        /// <remarks>
        /// Get a quote info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <returns>ApiResponse of Quote</returns>
        ApiResponse<Quote> GetQuoteWithHttpInfo (string quoteId);
        
        /// <summary>
        /// Get quotes
        /// </summary>
        /// <remarks>
        /// Get quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;created_at&#39;, &#39;updated_at&#39;(default), &#39;status&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="incomplete">filtering options - quote status (default: true) (optional)</param>
        /// <param name="valid">filtering options - quote status (default: true) (optional)</param>
        /// <param name="expired">filtering options - quote status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: false) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: false) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="start">filtering options - quote create_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - quote updated_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Quotes</returns>
        Quotes GetQuotes (string sort = null, string order = null, int? page = null, int? perPage = null, bool? isInstant = null, bool? incomplete = null, bool? valid = null, bool? expired = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, string start = null, string end = null, string keyword = null);
  
        /// <summary>
        /// Get quotes
        /// </summary>
        /// <remarks>
        /// Get quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;created_at&#39;, &#39;updated_at&#39;(default), &#39;status&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="incomplete">filtering options - quote status (default: true) (optional)</param>
        /// <param name="valid">filtering options - quote status (default: true) (optional)</param>
        /// <param name="expired">filtering options - quote status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: false) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: false) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="start">filtering options - quote create_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - quote updated_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>ApiResponse of Quotes</returns>
        ApiResponse<Quotes> GetQuotesWithHttpInfo (string sort = null, string order = null, int? page = null, int? perPage = null, bool? isInstant = null, bool? incomplete = null, bool? valid = null, bool? expired = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, string start = null, string end = null, string keyword = null);
        
        /// <summary>
        /// Request off-line quote
        /// </summary>
        /// <remarks>
        /// Request off-line quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to request off-line quote</param>
        /// <returns>Quote</returns>
        Quote OfflineQuote (string quoteId);
  
        /// <summary>
        /// Request off-line quote
        /// </summary>
        /// <remarks>
        /// Request off-line quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to request off-line quote</param>
        /// <returns>ApiResponse of Quote</returns>
        ApiResponse<Quote> OfflineQuoteWithHttpInfo (string quoteId);
        
        /// <summary>
        /// Get options to create quote
        /// </summary>
        /// <remarks>
        /// Get options to create quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isInstant">true: get only online processes, false: get only offline processes, otherwise: both of online and offline processes (optional)</param>
        /// <returns>QuoteOptions</returns>
        QuoteOptions OptionsQuote (bool? isInstant = null);
  
        /// <summary>
        /// Get options to create quote
        /// </summary>
        /// <remarks>
        /// Get options to create quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isInstant">true: get only online processes, false: get only offline processes, otherwise: both of online and offline processes (optional)</param>
        /// <returns>ApiResponse of QuoteOptions</returns>
        ApiResponse<QuoteOptions> OptionsQuoteWithHttpInfo (bool? isInstant = null);
        
        /// <summary>
        /// Update a quote info
        /// </summary>
        /// <remarks>
        /// Update a quote info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="jSONBody">Quote info json</param>
        /// <returns>Quote</returns>
        Quote UpdateQuote (string quoteId, UpdateQuote jSONBody);
  
        /// <summary>
        /// Update a quote info
        /// </summary>
        /// <remarks>
        /// Update a quote info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="jSONBody">Quote info json</param>
        /// <returns>ApiResponse of Quote</returns>
        ApiResponse<Quote> UpdateQuoteWithHttpInfo (string quoteId, UpdateQuote jSONBody);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Creates a new quote
        /// </summary>
        /// <remarks>
        /// Creates a new empty quote that will be a placeholder to add LineItems
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Quote</returns>
        System.Threading.Tasks.Task<Quote> CreateQuoteAsync ();

        /// <summary>
        /// Creates a new quote
        /// </summary>
        /// <remarks>
        /// Creates a new empty quote that will be a placeholder to add LineItems
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Quote)</returns>
        System.Threading.Tasks.Task<ApiResponse<Quote>> CreateQuoteAsyncWithHttpInfo ();
        
        /// <summary>
        /// Get a price instantly
        /// </summary>
        /// <remarks>
        /// Get a price of given part info and build spec without creating actual quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part info and build spec json</param>
        /// <returns>Task of Price</returns>
        System.Threading.Tasks.Task<Price> GetPriceAsync (GetPriceOptions jSONBody);

        /// <summary>
        /// Get a price instantly
        /// </summary>
        /// <remarks>
        /// Get a price of given part info and build spec without creating actual quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part info and build spec json</param>
        /// <returns>Task of ApiResponse (Price)</returns>
        System.Threading.Tasks.Task<ApiResponse<Price>> GetPriceAsyncWithHttpInfo (GetPriceOptions jSONBody);
        
        /// <summary>
        /// Get a quote info
        /// </summary>
        /// <remarks>
        /// Get a quote info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <returns>Task of Quote</returns>
        System.Threading.Tasks.Task<Quote> GetQuoteAsync (string quoteId);

        /// <summary>
        /// Get a quote info
        /// </summary>
        /// <remarks>
        /// Get a quote info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        System.Threading.Tasks.Task<ApiResponse<Quote>> GetQuoteAsyncWithHttpInfo (string quoteId);
        
        /// <summary>
        /// Get quotes
        /// </summary>
        /// <remarks>
        /// Get quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;created_at&#39;, &#39;updated_at&#39;(default), &#39;status&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="incomplete">filtering options - quote status (default: true) (optional)</param>
        /// <param name="valid">filtering options - quote status (default: true) (optional)</param>
        /// <param name="expired">filtering options - quote status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: false) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: false) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="start">filtering options - quote create_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - quote updated_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Task of Quotes</returns>
        System.Threading.Tasks.Task<Quotes> GetQuotesAsync (string sort = null, string order = null, int? page = null, int? perPage = null, bool? isInstant = null, bool? incomplete = null, bool? valid = null, bool? expired = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, string start = null, string end = null, string keyword = null);

        /// <summary>
        /// Get quotes
        /// </summary>
        /// <remarks>
        /// Get quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;created_at&#39;, &#39;updated_at&#39;(default), &#39;status&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="incomplete">filtering options - quote status (default: true) (optional)</param>
        /// <param name="valid">filtering options - quote status (default: true) (optional)</param>
        /// <param name="expired">filtering options - quote status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: false) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: false) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="start">filtering options - quote create_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - quote updated_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Task of ApiResponse (Quotes)</returns>
        System.Threading.Tasks.Task<ApiResponse<Quotes>> GetQuotesAsyncWithHttpInfo (string sort = null, string order = null, int? page = null, int? perPage = null, bool? isInstant = null, bool? incomplete = null, bool? valid = null, bool? expired = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, string start = null, string end = null, string keyword = null);
        
        /// <summary>
        /// Request off-line quote
        /// </summary>
        /// <remarks>
        /// Request off-line quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to request off-line quote</param>
        /// <returns>Task of Quote</returns>
        System.Threading.Tasks.Task<Quote> OfflineQuoteAsync (string quoteId);

        /// <summary>
        /// Request off-line quote
        /// </summary>
        /// <remarks>
        /// Request off-line quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to request off-line quote</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        System.Threading.Tasks.Task<ApiResponse<Quote>> OfflineQuoteAsyncWithHttpInfo (string quoteId);
        
        /// <summary>
        /// Get options to create quote
        /// </summary>
        /// <remarks>
        /// Get options to create quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isInstant">true: get only online processes, false: get only offline processes, otherwise: both of online and offline processes (optional)</param>
        /// <returns>Task of QuoteOptions</returns>
        System.Threading.Tasks.Task<QuoteOptions> OptionsQuoteAsync (bool? isInstant = null);

        /// <summary>
        /// Get options to create quote
        /// </summary>
        /// <remarks>
        /// Get options to create quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isInstant">true: get only online processes, false: get only offline processes, otherwise: both of online and offline processes (optional)</param>
        /// <returns>Task of ApiResponse (QuoteOptions)</returns>
        System.Threading.Tasks.Task<ApiResponse<QuoteOptions>> OptionsQuoteAsyncWithHttpInfo (bool? isInstant = null);
        
        /// <summary>
        /// Update a quote info
        /// </summary>
        /// <remarks>
        /// Update a quote info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="jSONBody">Quote info json</param>
        /// <returns>Task of Quote</returns>
        System.Threading.Tasks.Task<Quote> UpdateQuoteAsync (string quoteId, UpdateQuote jSONBody);

        /// <summary>
        /// Update a quote info
        /// </summary>
        /// <remarks>
        /// Update a quote info
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="jSONBody">Quote info json</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        System.Threading.Tasks.Task<ApiResponse<Quote>> UpdateQuoteAsyncWithHttpInfo (string quoteId, UpdateQuote jSONBody);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QuotesApi : IQuotesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QuotesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QuotesApi(Configuration configuration = null)
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
        /// Creates a new quote Creates a new empty quote that will be a placeholder to add LineItems
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Quote</returns>
        public Quote CreateQuote ()
        {
             ApiResponse<Quote> localVarResponse = CreateQuoteWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a new quote Creates a new empty quote that will be a placeholder to add LineItems
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Quote</returns>
        public ApiResponse< Quote > CreateQuoteWithHttpInfo ()
        {
            
    
            var localVarPath = "/quotes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Quote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quote)));
            
        }

        
        /// <summary>
        /// Creates a new quote Creates a new empty quote that will be a placeholder to add LineItems
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Quote</returns>
        public async System.Threading.Tasks.Task<Quote> CreateQuoteAsync ()
        {
             ApiResponse<Quote> localVarResponse = await CreateQuoteAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a new quote Creates a new empty quote that will be a placeholder to add LineItems
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Quote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Quote>> CreateQuoteAsyncWithHttpInfo ()
        {
            
    
            var localVarPath = "/quotes";
    
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
                throw new ApiException (localVarStatusCode, "Error calling CreateQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Quote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quote)));
            
        }
        
        /// <summary>
        /// Get a price instantly Get a price of given part info and build spec without creating actual quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part info and build spec json</param> 
        /// <returns>Price</returns>
        public Price GetPrice (GetPriceOptions jSONBody)
        {
             ApiResponse<Price> localVarResponse = GetPriceWithHttpInfo(jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a price instantly Get a price of given part info and build spec without creating actual quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part info and build spec json</param> 
        /// <returns>ApiResponse of Price</returns>
        public ApiResponse< Price > GetPriceWithHttpInfo (GetPriceOptions jSONBody)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling QuotesApi->GetPrice");
            
    
            var localVarPath = "/quotes/price";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPrice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPrice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Price>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Price) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Price)));
            
        }

        
        /// <summary>
        /// Get a price instantly Get a price of given part info and build spec without creating actual quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part info and build spec json</param>
        /// <returns>Task of Price</returns>
        public async System.Threading.Tasks.Task<Price> GetPriceAsync (GetPriceOptions jSONBody)
        {
             ApiResponse<Price> localVarResponse = await GetPriceAsyncWithHttpInfo(jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a price instantly Get a price of given part info and build spec without creating actual quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Part info and build spec json</param>
        /// <returns>Task of ApiResponse (Price)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Price>> GetPriceAsyncWithHttpInfo (GetPriceOptions jSONBody)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling GetPrice");
            
    
            var localVarPath = "/quotes/price";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetPrice: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPrice: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Price>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Price) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Price)));
            
        }
        
        /// <summary>
        /// Get a quote info Get a quote info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <returns>Quote</returns>
        public Quote GetQuote (string quoteId)
        {
             ApiResponse<Quote> localVarResponse = GetQuoteWithHttpInfo(quoteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a quote info Get a quote info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <returns>ApiResponse of Quote</returns>
        public ApiResponse< Quote > GetQuoteWithHttpInfo (string quoteId)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling QuotesApi->GetQuote");
            
    
            var localVarPath = "/quotes/{quote_id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Quote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quote)));
            
        }

        
        /// <summary>
        /// Get a quote info Get a quote info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <returns>Task of Quote</returns>
        public async System.Threading.Tasks.Task<Quote> GetQuoteAsync (string quoteId)
        {
             ApiResponse<Quote> localVarResponse = await GetQuoteAsyncWithHttpInfo(quoteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a quote info Get a quote info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Quote>> GetQuoteAsyncWithHttpInfo (string quoteId)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling GetQuote");
            
    
            var localVarPath = "/quotes/{quote_id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Quote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quote)));
            
        }
        
        /// <summary>
        /// Get quotes Get quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;created_at&#39;, &#39;updated_at&#39;(default), &#39;status&#39; (optional)</param> 
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param> 
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param> 
        /// <param name="incomplete">filtering options - quote status (default: true) (optional)</param> 
        /// <param name="valid">filtering options - quote status (default: true) (optional)</param> 
        /// <param name="expired">filtering options - quote status (default: false) (optional)</param> 
        /// <param name="pending">filtering options - order status (default: false) (optional)</param> 
        /// <param name="inProduction">filtering options - order status (default: false) (optional)</param> 
        /// <param name="partialShipped">filtering options - order status (default: false) (optional)</param> 
        /// <param name="shipped">filtering options - order status (default: false) (optional)</param> 
        /// <param name="start">filtering options - quote create_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param> 
        /// <param name="end">filtering options - quote updated_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param> 
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param> 
        /// <returns>Quotes</returns>
        public Quotes GetQuotes (string sort = null, string order = null, int? page = null, int? perPage = null, bool? isInstant = null, bool? incomplete = null, bool? valid = null, bool? expired = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, string start = null, string end = null, string keyword = null)
        {
             ApiResponse<Quotes> localVarResponse = GetQuotesWithHttpInfo(sort, order, page, perPage, isInstant, incomplete, valid, expired, pending, inProduction, partialShipped, shipped, start, end, keyword);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get quotes Get quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;created_at&#39;, &#39;updated_at&#39;(default), &#39;status&#39; (optional)</param> 
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param> 
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param> 
        /// <param name="incomplete">filtering options - quote status (default: true) (optional)</param> 
        /// <param name="valid">filtering options - quote status (default: true) (optional)</param> 
        /// <param name="expired">filtering options - quote status (default: false) (optional)</param> 
        /// <param name="pending">filtering options - order status (default: false) (optional)</param> 
        /// <param name="inProduction">filtering options - order status (default: false) (optional)</param> 
        /// <param name="partialShipped">filtering options - order status (default: false) (optional)</param> 
        /// <param name="shipped">filtering options - order status (default: false) (optional)</param> 
        /// <param name="start">filtering options - quote create_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param> 
        /// <param name="end">filtering options - quote updated_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param> 
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param> 
        /// <returns>ApiResponse of Quotes</returns>
        public ApiResponse< Quotes > GetQuotesWithHttpInfo (string sort = null, string order = null, int? page = null, int? perPage = null, bool? isInstant = null, bool? incomplete = null, bool? valid = null, bool? expired = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, string start = null, string end = null, string keyword = null)
        {
            
    
            var localVarPath = "/quotes";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (isInstant != null) localVarQueryParams.Add("is_instant", Configuration.ApiClient.ParameterToString(isInstant)); // query parameter
            if (incomplete != null) localVarQueryParams.Add("incomplete", Configuration.ApiClient.ParameterToString(incomplete)); // query parameter
            if (valid != null) localVarQueryParams.Add("valid", Configuration.ApiClient.ParameterToString(valid)); // query parameter
            if (expired != null) localVarQueryParams.Add("expired", Configuration.ApiClient.ParameterToString(expired)); // query parameter
            if (pending != null) localVarQueryParams.Add("pending", Configuration.ApiClient.ParameterToString(pending)); // query parameter
            if (inProduction != null) localVarQueryParams.Add("in_production", Configuration.ApiClient.ParameterToString(inProduction)); // query parameter
            if (partialShipped != null) localVarQueryParams.Add("partial_shipped", Configuration.ApiClient.ParameterToString(partialShipped)); // query parameter
            if (shipped != null) localVarQueryParams.Add("shipped", Configuration.ApiClient.ParameterToString(shipped)); // query parameter
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (end != null) localVarQueryParams.Add("end", Configuration.ApiClient.ParameterToString(end)); // query parameter
            if (keyword != null) localVarQueryParams.Add("keyword", Configuration.ApiClient.ParameterToString(keyword)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetQuotes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Quotes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quotes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quotes)));
            
        }

        
        /// <summary>
        /// Get quotes Get quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;created_at&#39;, &#39;updated_at&#39;(default), &#39;status&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="incomplete">filtering options - quote status (default: true) (optional)</param>
        /// <param name="valid">filtering options - quote status (default: true) (optional)</param>
        /// <param name="expired">filtering options - quote status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: false) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: false) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="start">filtering options - quote create_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - quote updated_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Task of Quotes</returns>
        public async System.Threading.Tasks.Task<Quotes> GetQuotesAsync (string sort = null, string order = null, int? page = null, int? perPage = null, bool? isInstant = null, bool? incomplete = null, bool? valid = null, bool? expired = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, string start = null, string end = null, string keyword = null)
        {
             ApiResponse<Quotes> localVarResponse = await GetQuotesAsyncWithHttpInfo(sort, order, page, perPage, isInstant, incomplete, valid, expired, pending, inProduction, partialShipped, shipped, start, end, keyword);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get quotes Get quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;created_at&#39;, &#39;updated_at&#39;(default), &#39;status&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="incomplete">filtering options - quote status (default: true) (optional)</param>
        /// <param name="valid">filtering options - quote status (default: true) (optional)</param>
        /// <param name="expired">filtering options - quote status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: false) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: false) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: false) (optional)</param>
        /// <param name="start">filtering options - quote create_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - quote updated_at or ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Task of ApiResponse (Quotes)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Quotes>> GetQuotesAsyncWithHttpInfo (string sort = null, string order = null, int? page = null, int? perPage = null, bool? isInstant = null, bool? incomplete = null, bool? valid = null, bool? expired = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, string start = null, string end = null, string keyword = null)
        {
            
    
            var localVarPath = "/quotes";
    
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
            
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (order != null) localVarQueryParams.Add("order", Configuration.ApiClient.ParameterToString(order)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (isInstant != null) localVarQueryParams.Add("is_instant", Configuration.ApiClient.ParameterToString(isInstant)); // query parameter
            if (incomplete != null) localVarQueryParams.Add("incomplete", Configuration.ApiClient.ParameterToString(incomplete)); // query parameter
            if (valid != null) localVarQueryParams.Add("valid", Configuration.ApiClient.ParameterToString(valid)); // query parameter
            if (expired != null) localVarQueryParams.Add("expired", Configuration.ApiClient.ParameterToString(expired)); // query parameter
            if (pending != null) localVarQueryParams.Add("pending", Configuration.ApiClient.ParameterToString(pending)); // query parameter
            if (inProduction != null) localVarQueryParams.Add("in_production", Configuration.ApiClient.ParameterToString(inProduction)); // query parameter
            if (partialShipped != null) localVarQueryParams.Add("partial_shipped", Configuration.ApiClient.ParameterToString(partialShipped)); // query parameter
            if (shipped != null) localVarQueryParams.Add("shipped", Configuration.ApiClient.ParameterToString(shipped)); // query parameter
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (end != null) localVarQueryParams.Add("end", Configuration.ApiClient.ParameterToString(end)); // query parameter
            if (keyword != null) localVarQueryParams.Add("keyword", Configuration.ApiClient.ParameterToString(keyword)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetQuotes: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetQuotes: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Quotes>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quotes) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quotes)));
            
        }
        
        /// <summary>
        /// Request off-line quote Request off-line quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to request off-line quote</param> 
        /// <returns>Quote</returns>
        public Quote OfflineQuote (string quoteId)
        {
             ApiResponse<Quote> localVarResponse = OfflineQuoteWithHttpInfo(quoteId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Request off-line quote Request off-line quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to request off-line quote</param> 
        /// <returns>ApiResponse of Quote</returns>
        public ApiResponse< Quote > OfflineQuoteWithHttpInfo (string quoteId)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling QuotesApi->OfflineQuote");
            
    
            var localVarPath = "/quotes/{quote_id}/offline";
    
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
                throw new ApiException (localVarStatusCode, "Error calling OfflineQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OfflineQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Quote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quote)));
            
        }

        
        /// <summary>
        /// Request off-line quote Request off-line quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to request off-line quote</param>
        /// <returns>Task of Quote</returns>
        public async System.Threading.Tasks.Task<Quote> OfflineQuoteAsync (string quoteId)
        {
             ApiResponse<Quote> localVarResponse = await OfflineQuoteAsyncWithHttpInfo(quoteId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Request off-line quote Request off-line quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id to request off-line quote</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Quote>> OfflineQuoteAsyncWithHttpInfo (string quoteId)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling OfflineQuote");
            
    
            var localVarPath = "/quotes/{quote_id}/offline";
    
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
                throw new ApiException (localVarStatusCode, "Error calling OfflineQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OfflineQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Quote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quote)));
            
        }
        
        /// <summary>
        /// Get options to create quote Get options to create quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isInstant">true: get only online processes, false: get only offline processes, otherwise: both of online and offline processes (optional)</param> 
        /// <returns>QuoteOptions</returns>
        public QuoteOptions OptionsQuote (bool? isInstant = null)
        {
             ApiResponse<QuoteOptions> localVarResponse = OptionsQuoteWithHttpInfo(isInstant);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get options to create quote Get options to create quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isInstant">true: get only online processes, false: get only offline processes, otherwise: both of online and offline processes (optional)</param> 
        /// <returns>ApiResponse of QuoteOptions</returns>
        public ApiResponse< QuoteOptions > OptionsQuoteWithHttpInfo (bool? isInstant = null)
        {
            
    
            var localVarPath = "/quotes/options";
    
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
            
            if (isInstant != null) localVarQueryParams.Add("is_instant", Configuration.ApiClient.ParameterToString(isInstant)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling OptionsQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OptionsQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<QuoteOptions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuoteOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuoteOptions)));
            
        }

        
        /// <summary>
        /// Get options to create quote Get options to create quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isInstant">true: get only online processes, false: get only offline processes, otherwise: both of online and offline processes (optional)</param>
        /// <returns>Task of QuoteOptions</returns>
        public async System.Threading.Tasks.Task<QuoteOptions> OptionsQuoteAsync (bool? isInstant = null)
        {
             ApiResponse<QuoteOptions> localVarResponse = await OptionsQuoteAsyncWithHttpInfo(isInstant);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get options to create quote Get options to create quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="isInstant">true: get only online processes, false: get only offline processes, otherwise: both of online and offline processes (optional)</param>
        /// <returns>Task of ApiResponse (QuoteOptions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QuoteOptions>> OptionsQuoteAsyncWithHttpInfo (bool? isInstant = null)
        {
            
    
            var localVarPath = "/quotes/options";
    
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
            
            if (isInstant != null) localVarQueryParams.Add("is_instant", Configuration.ApiClient.ParameterToString(isInstant)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling OptionsQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OptionsQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QuoteOptions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QuoteOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QuoteOptions)));
            
        }
        
        /// <summary>
        /// Update a quote info Update a quote info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <param name="jSONBody">Quote info json</param> 
        /// <returns>Quote</returns>
        public Quote UpdateQuote (string quoteId, UpdateQuote jSONBody)
        {
             ApiResponse<Quote> localVarResponse = UpdateQuoteWithHttpInfo(quoteId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a quote info Update a quote info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param> 
        /// <param name="jSONBody">Quote info json</param> 
        /// <returns>ApiResponse of Quote</returns>
        public ApiResponse< Quote > UpdateQuoteWithHttpInfo (string quoteId, UpdateQuote jSONBody)
        {
            
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling QuotesApi->UpdateQuote");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling QuotesApi->UpdateQuote");
            
    
            var localVarPath = "/quotes/{quote_id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Quote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quote)));
            
        }

        
        /// <summary>
        /// Update a quote info Update a quote info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="jSONBody">Quote info json</param>
        /// <returns>Task of Quote</returns>
        public async System.Threading.Tasks.Task<Quote> UpdateQuoteAsync (string quoteId, UpdateQuote jSONBody)
        {
             ApiResponse<Quote> localVarResponse = await UpdateQuoteAsyncWithHttpInfo(quoteId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a quote info Update a quote info
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">Quote ID</param>
        /// <param name="jSONBody">Quote info json</param>
        /// <returns>Task of ApiResponse (Quote)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Quote>> UpdateQuoteAsyncWithHttpInfo (string quoteId, UpdateQuote jSONBody)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null) throw new ApiException(400, "Missing required parameter 'quoteId' when calling UpdateQuote");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UpdateQuote");
            
    
            var localVarPath = "/quotes/{quote_id}";
    
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Quote>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Quote) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Quote)));
            
        }

        /// <summary>
        /// Creates a quote thumbnail
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Quote</returns>
        public AppsResponse CreateQuoteThumbnail(string quoteId, string storId = null)
        {
            ApiResponse<AppsResponse> localVarResponse = CreateQuoteThumbnailWithHttpInfo(quoteId, storId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a quote thumbnail
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Quote</returns>
        public ApiResponse<AppsResponse> CreateQuoteThumbnailWithHttpInfo(string quoteId, string storId = null)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling QuotesApi->CreateQuoteThumbnail");

            var localVarPath = "/quotes/{quote_id}/thumbnail";

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

            if (!String.IsNullOrEmpty(storId))
            {
                localVarQueryParams["stor_id"] = storId;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException(localVarStatusCode, "Error calling CreateQuote: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException(localVarStatusCode, "Error calling CreateQuote: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));

        }
        
    }
    
}
