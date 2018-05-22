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
    public interface IAppsApi
    {
        #region Synchronous Operations
        /// <summary>
        /// Get URL for account creation
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display account creation
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>AppsResponse</returns>
        AppsResponse AppAccountCreate(string locale = null);

        /// <summary>
        /// Get URL for account creation
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display account creation
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>ApiResponse of AppsResponse</returns>
        ApiResponse<AppsResponse> AppAccountCreateWithHttpInfo(string locale = null);
        /// <summary>
        /// Get URL for quote detail
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display quote detail page. User may need to login first.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote id to edit</param>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>AppsResponse</returns>
        AppsResponse AppQuoteDetail(int? quoteId, string locale = null);

        /// <summary>
        /// Get URL for quote detail
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display quote detail page. User may need to login first.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote id to edit</param>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>ApiResponse of AppsResponse</returns>
        ApiResponse<AppsResponse> AppQuoteDetailWithHttpInfo(int? quoteId, string locale = null);
        /// <summary>
        /// Get URL for quotes list
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display quotes list. User may need to login first.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>AppsResponse</returns>
        AppsResponse AppQuotesList(string locale = null);

        /// <summary>
        /// Get URL for quotes list
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display quotes list. User may need to login first.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>ApiResponse of AppsResponse</returns>
        ApiResponse<AppsResponse> AppQuotesListWithHttpInfo(string locale = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get URL for account creation
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display account creation
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of AppsResponse</returns>
        System.Threading.Tasks.Task<AppsResponse> AppAccountCreateAsync(string locale = null);

        /// <summary>
        /// Get URL for account creation
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display account creation
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of ApiResponse (AppsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppsResponse>> AppAccountCreateAsyncWithHttpInfo(string locale = null);
        /// <summary>
        /// Get URL for quote detail
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display quote detail page. User may need to login first.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote id to edit</param>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of AppsResponse</returns>
        System.Threading.Tasks.Task<AppsResponse> AppQuoteDetailAsync(int? quoteId, string locale = null);

        /// <summary>
        /// Get URL for quote detail
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display quote detail page. User may need to login first.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote id to edit</param>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of ApiResponse (AppsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppsResponse>> AppQuoteDetailAsyncWithHttpInfo(int? quoteId, string locale = null);
        /// <summary>
        /// Get URL for quotes list
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display quotes list. User may need to login first.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of AppsResponse</returns>
        System.Threading.Tasks.Task<AppsResponse> AppQuotesListAsync(string locale = null);

        /// <summary>
        /// Get URL for quotes list
        /// </summary>
        /// <remarks>
        /// Get front-end URL to display quotes list. User may need to login first.
        /// </remarks>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of ApiResponse (AppsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AppsResponse>> AppQuotesListAsyncWithHttpInfo(string locale = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AppsApi : IAppsApi
    {
        private PaaS.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = PaaS.SDK.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AppsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = PaaS.SDK.Client.Configuration.DefaultExceptionFactory;

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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PaaS.SDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

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
        /// Get URL for account creation Get front-end URL to display account creation
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>AppsResponse</returns>
        public AppsResponse AppAccountCreate(string locale = null)
        {
            ApiResponse<AppsResponse> localVarResponse = AppAccountCreateWithHttpInfo(locale);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get URL for account creation Get front-end URL to display account creation
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>ApiResponse of AppsResponse</returns>
        public ApiResponse<AppsResponse> AppAccountCreateWithHttpInfo(string locale = null)
        {

            var localVarPath = "/apps/account_create";
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

            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter

            // authentication (api_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppAccountCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));
        }

        /// <summary>
        /// Get URL for account creation Get front-end URL to display account creation
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of AppsResponse</returns>
        public async System.Threading.Tasks.Task<AppsResponse> AppAccountCreateAsync(string locale = null)
        {
            ApiResponse<AppsResponse> localVarResponse = await AppAccountCreateAsyncWithHttpInfo(locale);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get URL for account creation Get front-end URL to display account creation
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of ApiResponse (AppsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AppsResponse>> AppAccountCreateAsyncWithHttpInfo(string locale = null)
        {

            var localVarPath = "/apps/account_create";
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

            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter

            // authentication (api_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppAccountCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));
        }

        /// <summary>
        /// Get URL for account creation Get front-end URL to display sign-in page
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>AppsResponse</returns>
        public AppsResponse AppLogin(string locale = null)
        {
            ApiResponse<AppsResponse> localVarResponse = AppLoginWithHttpInfo(locale);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get URL for account creation Get front-end URL to display sign-in page
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>ApiResponse of AppsResponse</returns>
        public ApiResponse<AppsResponse> AppLoginWithHttpInfo(string locale = null)
        {

            var localVarPath = "/apps/login";
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

            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter

            // authentication (api_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));
        }

        /// <summary>
        /// Get URL for account creation Get front-end URL to display sign-in page
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of AppsResponse</returns>
        public async System.Threading.Tasks.Task<AppsResponse> AppLoginAsync(string locale = null)
        {
            ApiResponse<AppsResponse> localVarResponse = await AppLoginAsyncWithHttpInfo(locale);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get URL for account creation Get front-end URL to display sign-in page
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of ApiResponse (AppsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AppsResponse>> AppLoginAsyncWithHttpInfo(string locale = null)
        {

            var localVarPath = "/apps/login";
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

            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter

            // authentication (api_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));
        }

        /// <summary>
        /// Get URL for quote detail Get front-end URL to display quote detail page. User may need to login first.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote id to edit</param>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>AppsResponse</returns>
        public AppsResponse AppQuoteDetail(int? quoteId, string locale = null)
        {
            ApiResponse<AppsResponse> localVarResponse = AppQuoteDetailWithHttpInfo(quoteId, locale);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get URL for quote detail Get front-end URL to display quote detail page. User may need to login first.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote id to edit</param>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>ApiResponse of AppsResponse</returns>
        public ApiResponse<AppsResponse> AppQuoteDetailWithHttpInfo(int? quoteId, string locale = null)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling AppsApi->AppQuoteDetail");

            var localVarPath = "/apps/quote_detail";
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

            if (quoteId != null) localVarQueryParams.Add("quote_id", Configuration.ApiClient.ParameterToString(quoteId)); // query parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter

            // authentication (api_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppQuoteDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));
        }

        /// <summary>
        /// Get URL for quote detail Get front-end URL to display quote detail page. User may need to login first.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote id to edit</param>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of AppsResponse</returns>
        public async System.Threading.Tasks.Task<AppsResponse> AppQuoteDetailAsync(int? quoteId, string locale = null)
        {
            ApiResponse<AppsResponse> localVarResponse = await AppQuoteDetailAsyncWithHttpInfo(quoteId, locale);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get URL for quote detail Get front-end URL to display quote detail page. User may need to login first.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="quoteId">quote id to edit</param>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of ApiResponse (AppsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AppsResponse>> AppQuoteDetailAsyncWithHttpInfo(int? quoteId, string locale = null)
        {
            // verify the required parameter 'quoteId' is set
            if (quoteId == null)
                throw new ApiException(400, "Missing required parameter 'quoteId' when calling AppsApi->AppQuoteDetail");

            var localVarPath = "/apps/quote_detail";
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

            if (quoteId != null) localVarQueryParams.Add("quote_id", Configuration.ApiClient.ParameterToString(quoteId)); // query parameter
            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter

            // authentication (api_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppQuoteDetail", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));
        }

        /// <summary>
        /// Get URL for quotes list Get front-end URL to display quotes list. User may need to login first.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>AppsResponse</returns>
        public AppsResponse AppQuotesList(string locale = null)
        {
            ApiResponse<AppsResponse> localVarResponse = AppQuotesListWithHttpInfo(locale);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get URL for quotes list Get front-end URL to display quotes list. User may need to login first.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>ApiResponse of AppsResponse</returns>
        public ApiResponse<AppsResponse> AppQuotesListWithHttpInfo(string locale = null)
        {

            var localVarPath = "/apps/quotes_list";
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

            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter

            // authentication (api_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppQuotesList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));
        }

        /// <summary>
        /// Get URL for quotes list Get front-end URL to display quotes list. User may need to login first.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of AppsResponse</returns>
        public async System.Threading.Tasks.Task<AppsResponse> AppQuotesListAsync(string locale = null)
        {
            ApiResponse<AppsResponse> localVarResponse = await AppQuotesListAsyncWithHttpInfo(locale);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get URL for quotes list Get front-end URL to display quotes list. User may need to login first.
        /// </summary>
        /// <exception cref="PaaS.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locale">locale code such as en-US (optional)</param>
        /// <returns>Task of ApiResponse (AppsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AppsResponse>> AppQuotesListAsyncWithHttpInfo(string locale = null)
        {

            var localVarPath = "/apps/quotes_list";
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

            if (locale != null) localVarQueryParams.Add("locale", Configuration.ApiClient.ParameterToString(locale)); // query parameter

            // authentication (api_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("api_token")))
            {
                localVarQueryParams["api_token"] = Configuration.GetApiKeyWithPrefix("api_token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AppQuotesList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AppsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AppsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(AppsResponse)));
        }

    }
}
