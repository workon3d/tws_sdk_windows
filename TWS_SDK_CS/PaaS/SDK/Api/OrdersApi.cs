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
    public interface IOrdersApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Order Confirmation
        /// </summary>
        /// <remarks>
        /// Confirm an order
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Order</returns>
        Order ConfirmOrder (string orderId);
  
        /// <summary>
        /// Order Confirmation
        /// </summary>
        /// <remarks>
        /// Confirm an order
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>ApiResponse of Order</returns>
        ApiResponse<Order> ConfirmOrderWithHttpInfo (string orderId);
        
        /// <summary>
        /// Create a new order
        /// </summary>
        /// <remarks>
        /// Creates a new order from a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Order information</param>
        /// <param name="confirm">Confirm the order immediately (default: true) (optional)</param>
        /// <param name="allLineitems">Order for all valid LineItems (default: true). Otherwise LineItems need to be activated individually before creating an order. (optional)</param>
        /// <returns>Order</returns>
        Order CreateOrder (CreateOrderOptions jSONBody, bool? confirm = null, bool? allLineitems = null);
  
        /// <summary>
        /// Create a new order
        /// </summary>
        /// <remarks>
        /// Creates a new order from a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Order information</param>
        /// <param name="confirm">Confirm the order immediately (default: true) (optional)</param>
        /// <param name="allLineitems">Order for all valid LineItems (default: true). Otherwise LineItems need to be activated individually before creating an order. (optional)</param>
        /// <returns>ApiResponse of Order</returns>
        ApiResponse<Order> CreateOrderWithHttpInfo (CreateOrderOptions jSONBody, bool? confirm = null, bool? allLineitems = null);
        
        /// <summary>
        /// Get an order
        /// </summary>
        /// <remarks>
        /// Get an order by order_id
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Order</returns>
        Order GetOrder (string orderId);
  
        /// <summary>
        /// Get an order
        /// </summary>
        /// <remarks>
        /// Get an order by order_id
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>ApiResponse of Order</returns>
        ApiResponse<Order> GetOrderWithHttpInfo (string orderId);
        
        /// <summary>
        /// Get all orders which belong to an user
        /// </summary>
        /// <remarks>
        /// Get all orders which belong to an user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;ordered_at&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="unconfirmed">filtering options - order status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: true) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: true) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="start">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Orders</returns>
        Orders GetOrders (string sort = null, string order = null, int? page = null, int? perPage = null, bool? unconfirmed = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, bool? isInstant = null, string start = null, string end = null, string keyword = null);
  
        /// <summary>
        /// Get all orders which belong to an user
        /// </summary>
        /// <remarks>
        /// Get all orders which belong to an user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;ordered_at&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="unconfirmed">filtering options - order status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: true) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: true) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="start">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>ApiResponse of Orders</returns>
        ApiResponse<Orders> GetOrdersWithHttpInfo (string sort = null, string order = null, int? page = null, int? perPage = null, bool? unconfirmed = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, bool? isInstant = null, string start = null, string end = null, string keyword = null);
        
        /// <summary>
        /// Order options
        /// </summary>
        /// <remarks>
        /// Get options to create an order
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id for shipping price (optional)</param>
        /// <param name="addressId">address_id for shipping destination (optional)</param>
        /// <returns>OrderOptions</returns>
        OrderOptions OptionsOrder (int? quoteId = null, int? addressId = null);
  
        /// <summary>
        /// Order options
        /// </summary>
        /// <remarks>
        /// Get options to create an order
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id for shipping price (optional)</param>
        /// <param name="addressId">address_id for shipping destination (optional)</param>
        /// <returns>ApiResponse of OrderOptions</returns>
        ApiResponse<OrderOptions> OptionsOrderWithHttpInfo (int? quoteId = null, int? addressId = null);
        
        /// <summary>
        /// Update an order information
        /// </summary>
        /// <remarks>
        /// Update an order information
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <param name="jSONBody">Order information</param>
        /// <returns>Order</returns>
        Order UpdateOrder (string orderId, CreateOrderOptions jSONBody);
  
        /// <summary>
        /// Update an order information
        /// </summary>
        /// <remarks>
        /// Update an order information
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <param name="jSONBody">Order information</param>
        /// <returns>ApiResponse of Order</returns>
        ApiResponse<Order> UpdateOrderWithHttpInfo (string orderId, CreateOrderOptions jSONBody);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Order Confirmation
        /// </summary>
        /// <remarks>
        /// Confirm an order
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Task of Order</returns>
        System.Threading.Tasks.Task<Order> ConfirmOrderAsync (string orderId);

        /// <summary>
        /// Order Confirmation
        /// </summary>
        /// <remarks>
        /// Confirm an order
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        System.Threading.Tasks.Task<ApiResponse<Order>> ConfirmOrderAsyncWithHttpInfo (string orderId);
        
        /// <summary>
        /// Create a new order
        /// </summary>
        /// <remarks>
        /// Creates a new order from a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Order information</param>
        /// <param name="confirm">Confirm the order immediately (default: true) (optional)</param>
        /// <param name="allLineitems">Order for all valid LineItems (default: true). Otherwise LineItems need to be activated individually before creating an order. (optional)</param>
        /// <returns>Task of Order</returns>
        System.Threading.Tasks.Task<Order> CreateOrderAsync (CreateOrderOptions jSONBody, bool? confirm = null, bool? allLineitems = null);

        /// <summary>
        /// Create a new order
        /// </summary>
        /// <remarks>
        /// Creates a new order from a quote
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Order information</param>
        /// <param name="confirm">Confirm the order immediately (default: true) (optional)</param>
        /// <param name="allLineitems">Order for all valid LineItems (default: true). Otherwise LineItems need to be activated individually before creating an order. (optional)</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        System.Threading.Tasks.Task<ApiResponse<Order>> CreateOrderAsyncWithHttpInfo (CreateOrderOptions jSONBody, bool? confirm = null, bool? allLineitems = null);
        
        /// <summary>
        /// Get an order
        /// </summary>
        /// <remarks>
        /// Get an order by order_id
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Task of Order</returns>
        System.Threading.Tasks.Task<Order> GetOrderAsync (string orderId);

        /// <summary>
        /// Get an order
        /// </summary>
        /// <remarks>
        /// Get an order by order_id
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        System.Threading.Tasks.Task<ApiResponse<Order>> GetOrderAsyncWithHttpInfo (string orderId);
        
        /// <summary>
        /// Get all orders which belong to an user
        /// </summary>
        /// <remarks>
        /// Get all orders which belong to an user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;ordered_at&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="unconfirmed">filtering options - order status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: true) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: true) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="start">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Task of Orders</returns>
        System.Threading.Tasks.Task<Orders> GetOrdersAsync (string sort = null, string order = null, int? page = null, int? perPage = null, bool? unconfirmed = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, bool? isInstant = null, string start = null, string end = null, string keyword = null);

        /// <summary>
        /// Get all orders which belong to an user
        /// </summary>
        /// <remarks>
        /// Get all orders which belong to an user
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;ordered_at&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="unconfirmed">filtering options - order status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: true) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: true) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="start">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Task of ApiResponse (Orders)</returns>
        System.Threading.Tasks.Task<ApiResponse<Orders>> GetOrdersAsyncWithHttpInfo (string sort = null, string order = null, int? page = null, int? perPage = null, bool? unconfirmed = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, bool? isInstant = null, string start = null, string end = null, string keyword = null);
        
        /// <summary>
        /// Order options
        /// </summary>
        /// <remarks>
        /// Get options to create an order
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id for shipping price (optional)</param>
        /// <param name="addressId">address_id for shipping destination (optional)</param>
        /// <returns>Task of OrderOptions</returns>
        System.Threading.Tasks.Task<OrderOptions> OptionsOrderAsync (int? quoteId = null, int? addressId = null);

        /// <summary>
        /// Order options
        /// </summary>
        /// <remarks>
        /// Get options to create an order
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id for shipping price (optional)</param>
        /// <param name="addressId">address_id for shipping destination (optional)</param>
        /// <returns>Task of ApiResponse (OrderOptions)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrderOptions>> OptionsOrderAsyncWithHttpInfo (int? quoteId = null, int? addressId = null);
        
        /// <summary>
        /// Update an order information
        /// </summary>
        /// <remarks>
        /// Update an order information
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <param name="jSONBody">Order information</param>
        /// <returns>Task of Order</returns>
        System.Threading.Tasks.Task<Order> UpdateOrderAsync (string orderId, CreateOrderOptions jSONBody);

        /// <summary>
        /// Update an order information
        /// </summary>
        /// <remarks>
        /// Update an order information
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <param name="jSONBody">Order information</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        System.Threading.Tasks.Task<ApiResponse<Order>> UpdateOrderAsyncWithHttpInfo (string orderId, CreateOrderOptions jSONBody);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OrdersApi : IOrdersApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrdersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OrdersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrdersApi(Configuration configuration = null)
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
        /// Order Confirmation Confirm an order
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param> 
        /// <returns>Order</returns>
        public Order ConfirmOrder (string orderId)
        {
             ApiResponse<Order> localVarResponse = ConfirmOrderWithHttpInfo(orderId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Order Confirmation Confirm an order
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param> 
        /// <returns>ApiResponse of Order</returns>
        public ApiResponse< Order > ConfirmOrderWithHttpInfo (string orderId)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling OrdersApi->ConfirmOrder");
            
    
            var localVarPath = "/orders/{order_id}/confirm";
    
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
            if (orderId != null) localVarPathParams.Add("order_id", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling ConfirmOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Order>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Order)));
            
        }

        
        /// <summary>
        /// Order Confirmation Confirm an order
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Task of Order</returns>
        public async System.Threading.Tasks.Task<Order> ConfirmOrderAsync (string orderId)
        {
             ApiResponse<Order> localVarResponse = await ConfirmOrderAsyncWithHttpInfo(orderId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Order Confirmation Confirm an order
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Order>> ConfirmOrderAsyncWithHttpInfo (string orderId)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling ConfirmOrder");
            
    
            var localVarPath = "/orders/{order_id}/confirm";
    
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
            if (orderId != null) localVarPathParams.Add("order_id", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling ConfirmOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConfirmOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Order>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Order)));
            
        }
        
        /// <summary>
        /// Create a new order Creates a new order from a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Order information</param> 
        /// <param name="confirm">Confirm the order immediately (default: true) (optional)</param> 
        /// <param name="allLineitems">Order for all valid LineItems (default: true). Otherwise LineItems need to be activated individually before creating an order. (optional)</param> 
        /// <returns>Order</returns>
        public Order CreateOrder (CreateOrderOptions jSONBody, bool? confirm = null, bool? allLineitems = null)
        {
             ApiResponse<Order> localVarResponse = CreateOrderWithHttpInfo(jSONBody, confirm, allLineitems);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new order Creates a new order from a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Order information</param> 
        /// <param name="confirm">Confirm the order immediately (default: true) (optional)</param> 
        /// <param name="allLineitems">Order for all valid LineItems (default: true). Otherwise LineItems need to be activated individually before creating an order. (optional)</param> 
        /// <returns>ApiResponse of Order</returns>
        public ApiResponse< Order > CreateOrderWithHttpInfo (CreateOrderOptions jSONBody, bool? confirm = null, bool? allLineitems = null)
        {
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling OrdersApi->CreateOrder");
            
    
            var localVarPath = "/orders";
    
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
            
            if (confirm != null) localVarQueryParams.Add("confirm", Configuration.ApiClient.ParameterToString(confirm)); // query parameter
            if (allLineitems != null) localVarQueryParams.Add("all_lineitems", Configuration.ApiClient.ParameterToString(allLineitems)); // query parameter
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling CreateOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Order>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Order)));
            
        }

        
        /// <summary>
        /// Create a new order Creates a new order from a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Order information</param>
        /// <param name="confirm">Confirm the order immediately (default: true) (optional)</param>
        /// <param name="allLineitems">Order for all valid LineItems (default: true). Otherwise LineItems need to be activated individually before creating an order. (optional)</param>
        /// <returns>Task of Order</returns>
        public async System.Threading.Tasks.Task<Order> CreateOrderAsync (CreateOrderOptions jSONBody, bool? confirm = null, bool? allLineitems = null)
        {
             ApiResponse<Order> localVarResponse = await CreateOrderAsyncWithHttpInfo(jSONBody, confirm, allLineitems);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new order Creates a new order from a quote
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jSONBody">Order information</param>
        /// <param name="confirm">Confirm the order immediately (default: true) (optional)</param>
        /// <param name="allLineitems">Order for all valid LineItems (default: true). Otherwise LineItems need to be activated individually before creating an order. (optional)</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Order>> CreateOrderAsyncWithHttpInfo (CreateOrderOptions jSONBody, bool? confirm = null, bool? allLineitems = null)
        {
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling CreateOrder");
            
    
            var localVarPath = "/orders";
    
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
            
            if (confirm != null) localVarQueryParams.Add("confirm", Configuration.ApiClient.ParameterToString(confirm)); // query parameter
            if (allLineitems != null) localVarQueryParams.Add("all_lineitems", Configuration.ApiClient.ParameterToString(allLineitems)); // query parameter
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling CreateOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Order>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Order)));
            
        }
        
        /// <summary>
        /// Get an order Get an order by order_id
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param> 
        /// <returns>Order</returns>
        public Order GetOrder (string orderId)
        {
             ApiResponse<Order> localVarResponse = GetOrderWithHttpInfo(orderId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an order Get an order by order_id
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param> 
        /// <returns>ApiResponse of Order</returns>
        public ApiResponse< Order > GetOrderWithHttpInfo (string orderId)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling OrdersApi->GetOrder");
            
    
            var localVarPath = "/orders/{order_id}";
    
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
            if (orderId != null) localVarPathParams.Add("order_id", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Order>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Order)));
            
        }

        
        /// <summary>
        /// Get an order Get an order by order_id
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Task of Order</returns>
        public async System.Threading.Tasks.Task<Order> GetOrderAsync (string orderId)
        {
             ApiResponse<Order> localVarResponse = await GetOrderAsyncWithHttpInfo(orderId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an order Get an order by order_id
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Order>> GetOrderAsyncWithHttpInfo (string orderId)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling GetOrder");
            
    
            var localVarPath = "/orders/{order_id}";
    
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
            if (orderId != null) localVarPathParams.Add("order_id", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Order>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Order)));
            
        }
        
        /// <summary>
        /// Get all orders which belong to an user Get all orders which belong to an user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;ordered_at&#39; (optional)</param> 
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param> 
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <param name="unconfirmed">filtering options - order status (default: false) (optional)</param> 
        /// <param name="pending">filtering options - order status (default: true) (optional)</param> 
        /// <param name="inProduction">filtering options - order status (default: true) (optional)</param> 
        /// <param name="partialShipped">filtering options - order status (default: true) (optional)</param> 
        /// <param name="shipped">filtering options - order status (default: true) (optional)</param> 
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param> 
        /// <param name="start">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param> 
        /// <param name="end">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param> 
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param> 
        /// <returns>Orders</returns>
        public Orders GetOrders (string sort = null, string order = null, int? page = null, int? perPage = null, bool? unconfirmed = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, bool? isInstant = null, string start = null, string end = null, string keyword = null)
        {
             ApiResponse<Orders> localVarResponse = GetOrdersWithHttpInfo(sort, order, page, perPage, unconfirmed, pending, inProduction, partialShipped, shipped, isInstant, start, end, keyword);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all orders which belong to an user Get all orders which belong to an user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;ordered_at&#39; (optional)</param> 
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param> 
        /// <param name="page">zero based index for current page (default: 0) (optional)</param> 
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param> 
        /// <param name="unconfirmed">filtering options - order status (default: false) (optional)</param> 
        /// <param name="pending">filtering options - order status (default: true) (optional)</param> 
        /// <param name="inProduction">filtering options - order status (default: true) (optional)</param> 
        /// <param name="partialShipped">filtering options - order status (default: true) (optional)</param> 
        /// <param name="shipped">filtering options - order status (default: true) (optional)</param> 
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param> 
        /// <param name="start">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param> 
        /// <param name="end">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param> 
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param> 
        /// <returns>ApiResponse of Orders</returns>
        public ApiResponse< Orders > GetOrdersWithHttpInfo (string sort = null, string order = null, int? page = null, int? perPage = null, bool? unconfirmed = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, bool? isInstant = null, string start = null, string end = null, string keyword = null)
        {
            
    
            var localVarPath = "/orders";
    
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
            if (unconfirmed != null) localVarQueryParams.Add("unconfirmed", Configuration.ApiClient.ParameterToString(unconfirmed)); // query parameter
            if (pending != null) localVarQueryParams.Add("pending", Configuration.ApiClient.ParameterToString(pending)); // query parameter
            if (inProduction != null) localVarQueryParams.Add("in_production", Configuration.ApiClient.ParameterToString(inProduction)); // query parameter
            if (partialShipped != null) localVarQueryParams.Add("partial_shipped", Configuration.ApiClient.ParameterToString(partialShipped)); // query parameter
            if (shipped != null) localVarQueryParams.Add("shipped", Configuration.ApiClient.ParameterToString(shipped)); // query parameter
            if (isInstant != null) localVarQueryParams.Add("is_instant", Configuration.ApiClient.ParameterToString(isInstant)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrders: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Orders>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Orders) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Orders)));
            
        }

        
        /// <summary>
        /// Get all orders which belong to an user Get all orders which belong to an user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;ordered_at&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="unconfirmed">filtering options - order status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: true) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: true) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="start">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Task of Orders</returns>
        public async System.Threading.Tasks.Task<Orders> GetOrdersAsync (string sort = null, string order = null, int? page = null, int? perPage = null, bool? unconfirmed = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, bool? isInstant = null, string start = null, string end = null, string keyword = null)
        {
             ApiResponse<Orders> localVarResponse = await GetOrdersAsyncWithHttpInfo(sort, order, page, perPage, unconfirmed, pending, inProduction, partialShipped, shipped, isInstant, start, end, keyword);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all orders which belong to an user Get all orders which belong to an user
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Possible options: &#39;quote_id&#39;, &#39;price&#39;, &#39;ordered_at&#39; (optional)</param>
        /// <param name="order">Possible options: &#39;asc&#39;, &#39;desc&#39;(default) (optional)</param>
        /// <param name="page">zero based index for current page (default: 0) (optional)</param>
        /// <param name="perPage">the number of contents in a page (default: 30) (optional)</param>
        /// <param name="unconfirmed">filtering options - order status (default: false) (optional)</param>
        /// <param name="pending">filtering options - order status (default: true) (optional)</param>
        /// <param name="inProduction">filtering options - order status (default: true) (optional)</param>
        /// <param name="partialShipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="shipped">filtering options - order status (default: true) (optional)</param>
        /// <param name="isInstant">filtering options - instant quote(true), manual quote(false) or both(empty) (optional)</param>
        /// <param name="start">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="end">filtering options - ordered_at (default: null). URL encoded string from ISO8601 format (optional)</param>
        /// <param name="keyword">search keyword for part name or quote_id (optional)</param>
        /// <returns>Task of ApiResponse (Orders)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Orders>> GetOrdersAsyncWithHttpInfo (string sort = null, string order = null, int? page = null, int? perPage = null, bool? unconfirmed = null, bool? pending = null, bool? inProduction = null, bool? partialShipped = null, bool? shipped = null, bool? isInstant = null, string start = null, string end = null, string keyword = null)
        {
            
    
            var localVarPath = "/orders";
    
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
            if (unconfirmed != null) localVarQueryParams.Add("unconfirmed", Configuration.ApiClient.ParameterToString(unconfirmed)); // query parameter
            if (pending != null) localVarQueryParams.Add("pending", Configuration.ApiClient.ParameterToString(pending)); // query parameter
            if (inProduction != null) localVarQueryParams.Add("in_production", Configuration.ApiClient.ParameterToString(inProduction)); // query parameter
            if (partialShipped != null) localVarQueryParams.Add("partial_shipped", Configuration.ApiClient.ParameterToString(partialShipped)); // query parameter
            if (shipped != null) localVarQueryParams.Add("shipped", Configuration.ApiClient.ParameterToString(shipped)); // query parameter
            if (isInstant != null) localVarQueryParams.Add("is_instant", Configuration.ApiClient.ParameterToString(isInstant)); // query parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrders: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrders: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Orders>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Orders) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Orders)));
            
        }
        
        /// <summary>
        /// Order options Get options to create an order
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id for shipping price (optional)</param> 
        /// <param name="addressId">address_id for shipping destination (optional)</param> 
        /// <returns>OrderOptions</returns>
        public OrderOptions OptionsOrder (int? quoteId = null, int? addressId = null)
        {
             ApiResponse<OrderOptions> localVarResponse = OptionsOrderWithHttpInfo(quoteId, addressId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Order options Get options to create an order
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id for shipping price (optional)</param> 
        /// <param name="addressId">address_id for shipping destination (optional)</param> 
        /// <returns>ApiResponse of OrderOptions</returns>
        public ApiResponse< OrderOptions > OptionsOrderWithHttpInfo (int? quoteId = null, int? addressId = null)
        {
            
    
            var localVarPath = "/orders/options";
    
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
            if (addressId != null) localVarQueryParams.Add("address_id", Configuration.ApiClient.ParameterToString(addressId)); // query parameter
            
            
            
            

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
                throw new ApiException (localVarStatusCode, "Error calling OptionsOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OptionsOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<OrderOptions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderOptions)));
            
        }

        
        /// <summary>
        /// Order options Get options to create an order
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id for shipping price (optional)</param>
        /// <param name="addressId">address_id for shipping destination (optional)</param>
        /// <returns>Task of OrderOptions</returns>
        public async System.Threading.Tasks.Task<OrderOptions> OptionsOrderAsync (int? quoteId = null, int? addressId = null)
        {
             ApiResponse<OrderOptions> localVarResponse = await OptionsOrderAsyncWithHttpInfo(quoteId, addressId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Order options Get options to create an order
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote_id for shipping price (optional)</param>
        /// <param name="addressId">address_id for shipping destination (optional)</param>
        /// <returns>Task of ApiResponse (OrderOptions)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrderOptions>> OptionsOrderAsyncWithHttpInfo (int? quoteId = null, int? addressId = null)
        {
            
    
            var localVarPath = "/orders/options";
    
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
            if (addressId != null) localVarQueryParams.Add("address_id", Configuration.ApiClient.ParameterToString(addressId)); // query parameter
            
            
            
            

            
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
                throw new ApiException (localVarStatusCode, "Error calling OptionsOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling OptionsOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrderOptions>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrderOptions) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrderOptions)));
            
        }
        
        /// <summary>
        /// Update an order information Update an order information
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param> 
        /// <param name="jSONBody">Order information</param> 
        /// <returns>Order</returns>
        public Order UpdateOrder (string orderId, CreateOrderOptions jSONBody)
        {
             ApiResponse<Order> localVarResponse = UpdateOrderWithHttpInfo(orderId, jSONBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an order information Update an order information
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param> 
        /// <param name="jSONBody">Order information</param> 
        /// <returns>ApiResponse of Order</returns>
        public ApiResponse< Order > UpdateOrderWithHttpInfo (string orderId, CreateOrderOptions jSONBody)
        {
            
            // verify the required parameter 'orderId' is set
            if (orderId == null)
                throw new ApiException(400, "Missing required parameter 'orderId' when calling OrdersApi->UpdateOrder");
            
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null)
                throw new ApiException(400, "Missing required parameter 'jSONBody' when calling OrdersApi->UpdateOrder");
            
    
            var localVarPath = "/orders/{order_id}";
    
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
            if (orderId != null) localVarPathParams.Add("order_id", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Order>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Order)));
            
        }

        
        /// <summary>
        /// Update an order information Update an order information
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <param name="jSONBody">Order information</param>
        /// <returns>Task of Order</returns>
        public async System.Threading.Tasks.Task<Order> UpdateOrderAsync (string orderId, CreateOrderOptions jSONBody)
        {
             ApiResponse<Order> localVarResponse = await UpdateOrderAsyncWithHttpInfo(orderId, jSONBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an order information Update an order information
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">order_id is same with quote_id</param>
        /// <param name="jSONBody">Order information</param>
        /// <returns>Task of ApiResponse (Order)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Order>> UpdateOrderAsyncWithHttpInfo (string orderId, CreateOrderOptions jSONBody)
        {
            // verify the required parameter 'orderId' is set
            if (orderId == null) throw new ApiException(400, "Missing required parameter 'orderId' when calling UpdateOrder");
            // verify the required parameter 'jSONBody' is set
            if (jSONBody == null) throw new ApiException(400, "Missing required parameter 'jSONBody' when calling UpdateOrder");
            
    
            var localVarPath = "/orders/{order_id}";
    
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
            if (orderId != null) localVarPathParams.Add("order_id", Configuration.ApiClient.ParameterToString(orderId)); // path parameter
            
            
            
            
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
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrder: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling UpdateOrder: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Order>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Order) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Order)));
            
        }
        
    }
    
}
