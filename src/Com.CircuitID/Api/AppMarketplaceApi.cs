/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.22
 * Contact: support@circuitid.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using Com.CircuitID.Client;
using Com.CircuitID.Models;

namespace Com.CircuitID.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAppMarketplaceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Find multiple objects
        /// </summary>
        /// <remarks>
        /// Search and retrieve multiple objects simultaneously. 
        /// </remarks>
        /// <exception cref="Com.CircuitID.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Filter results by the specified value. (optional)</param>
        /// <param name="limit">$limit will return only the number of results you specify. (optional)</param>
        /// <param name="skip">$skip will skip the specified number of results. (optional)</param>
        /// <param name="sort">$sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional)</param>
        /// <param name="select">$select allows to pick which fields to include in the result. (optional)</param>
        /// <param name="or">Find all records that match any of the given criteria. (optional)</param>
        /// <param name="and">Find all records that match all of the given criteria. (optional)</param>
        /// <returns>FindAppMarketplace200Response</returns>
        FindAppMarketplace200Response FindAppMarketplace (string search = default(string), int? limit = default(int?), int? skip = default(int?), Object sort = default(Object), List<string> select = default(List<string>), List<Object> or = default(List<Object>), List<Object> and = default(List<Object>));

        /// <summary>
        /// Find multiple objects
        /// </summary>
        /// <remarks>
        /// Search and retrieve multiple objects simultaneously. 
        /// </remarks>
        /// <exception cref="Com.CircuitID.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Filter results by the specified value. (optional)</param>
        /// <param name="limit">$limit will return only the number of results you specify. (optional)</param>
        /// <param name="skip">$skip will skip the specified number of results. (optional)</param>
        /// <param name="sort">$sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional)</param>
        /// <param name="select">$select allows to pick which fields to include in the result. (optional)</param>
        /// <param name="or">Find all records that match any of the given criteria. (optional)</param>
        /// <param name="and">Find all records that match all of the given criteria. (optional)</param>
        /// <returns>ApiResponse of FindAppMarketplace200Response</returns>
        ApiResponse<FindAppMarketplace200Response> FindAppMarketplaceWithHttpInfo (string search = default(string), int? limit = default(int?), int? skip = default(int?), Object sort = default(Object), List<string> select = default(List<string>), List<Object> or = default(List<Object>), List<Object> and = default(List<Object>));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Find multiple objects
        /// </summary>
        /// <remarks>
        /// Search and retrieve multiple objects simultaneously. 
        /// </remarks>
        /// <exception cref="Com.CircuitID.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Filter results by the specified value. (optional)</param>
        /// <param name="limit">$limit will return only the number of results you specify. (optional)</param>
        /// <param name="skip">$skip will skip the specified number of results. (optional)</param>
        /// <param name="sort">$sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional)</param>
        /// <param name="select">$select allows to pick which fields to include in the result. (optional)</param>
        /// <param name="or">Find all records that match any of the given criteria. (optional)</param>
        /// <param name="and">Find all records that match all of the given criteria. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FindAppMarketplace200Response</returns>
        System.Threading.Tasks.Task<FindAppMarketplace200Response> FindAppMarketplaceAsync (string search = default(string), int? limit = default(int?), int? skip = default(int?), Object sort = default(Object), List<string> select = default(List<string>), List<Object> or = default(List<Object>), List<Object> and = default(List<Object>), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Find multiple objects
        /// </summary>
        /// <remarks>
        /// Search and retrieve multiple objects simultaneously. 
        /// </remarks>
        /// <exception cref="Com.CircuitID.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Filter results by the specified value. (optional)</param>
        /// <param name="limit">$limit will return only the number of results you specify. (optional)</param>
        /// <param name="skip">$skip will skip the specified number of results. (optional)</param>
        /// <param name="sort">$sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional)</param>
        /// <param name="select">$select allows to pick which fields to include in the result. (optional)</param>
        /// <param name="or">Find all records that match any of the given criteria. (optional)</param>
        /// <param name="and">Find all records that match all of the given criteria. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FindAppMarketplace200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FindAppMarketplace200Response>> FindAppMarketplaceWithHttpInfoAsync (string search = default(string), int? limit = default(int?), int? skip = default(int?), Object sort = default(Object), List<string> select = default(List<string>), List<Object> or = default(List<Object>), List<Object> and = default(List<Object>), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AppMarketplaceApi : IAppMarketplaceApi
    {
        private Com.CircuitID.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AppMarketplaceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppMarketplaceApi(String basePath)
        {
            this.Configuration = new Com.CircuitID.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Com.CircuitID.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppMarketplaceApi"/> class
        /// </summary>
        /// <returns></returns>
        public AppMarketplaceApi()
        {
            this.Configuration = Com.CircuitID.Client.Configuration.Default;

            ExceptionFactory = Com.CircuitID.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppMarketplaceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AppMarketplaceApi(Com.CircuitID.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Com.CircuitID.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Com.CircuitID.Client.Configuration.DefaultExceptionFactory;
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
        public Com.CircuitID.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.CircuitID.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Find multiple objects Search and retrieve multiple objects simultaneously. 
        /// </summary>
        /// <exception cref="Com.CircuitID.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Filter results by the specified value. (optional)</param>
        /// <param name="limit">$limit will return only the number of results you specify. (optional)</param>
        /// <param name="skip">$skip will skip the specified number of results. (optional)</param>
        /// <param name="sort">$sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional)</param>
        /// <param name="select">$select allows to pick which fields to include in the result. (optional)</param>
        /// <param name="or">Find all records that match any of the given criteria. (optional)</param>
        /// <param name="and">Find all records that match all of the given criteria. (optional)</param>
        /// <returns>FindAppMarketplace200Response</returns>
        public FindAppMarketplace200Response FindAppMarketplace (string search = default(string), int? limit = default(int?), int? skip = default(int?), Object sort = default(Object), List<string> select = default(List<string>), List<Object> or = default(List<Object>), List<Object> and = default(List<Object>))
        {
             ApiResponse<FindAppMarketplace200Response> localVarResponse = FindAppMarketplaceWithHttpInfo(search, limit, skip, sort, select, or, and);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Find multiple objects Search and retrieve multiple objects simultaneously. 
        /// </summary>
        /// <exception cref="Com.CircuitID.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Filter results by the specified value. (optional)</param>
        /// <param name="limit">$limit will return only the number of results you specify. (optional)</param>
        /// <param name="skip">$skip will skip the specified number of results. (optional)</param>
        /// <param name="sort">$sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional)</param>
        /// <param name="select">$select allows to pick which fields to include in the result. (optional)</param>
        /// <param name="or">Find all records that match any of the given criteria. (optional)</param>
        /// <param name="and">Find all records that match all of the given criteria. (optional)</param>
        /// <returns>ApiResponse of FindAppMarketplace200Response</returns>
        public ApiResponse<FindAppMarketplace200Response> FindAppMarketplaceWithHttpInfo (string search = default(string), int? limit = default(int?), int? skip = default(int?), Object sort = default(Object), List<string> select = default(List<string>), List<Object> or = default(List<Object>), List<Object> and = default(List<Object>))
        {

            var localVarPath = "/appmarketplace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$search", search)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$limit", limit)); // query parameter
            if (skip != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$skip", skip)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$sort", sort)); // query parameter
            if (select != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "$select", select)); // query parameter
            if (or != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "$or", or)); // query parameter
            if (and != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "$and", and)); // query parameter

            // authentication (jwt) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindAppMarketplace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FindAppMarketplace200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FindAppMarketplace200Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FindAppMarketplace200Response)));
        }

        /// <summary>
        /// Find multiple objects Search and retrieve multiple objects simultaneously. 
        /// </summary>
        /// <exception cref="Com.CircuitID.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Filter results by the specified value. (optional)</param>
        /// <param name="limit">$limit will return only the number of results you specify. (optional)</param>
        /// <param name="skip">$skip will skip the specified number of results. (optional)</param>
        /// <param name="sort">$sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional)</param>
        /// <param name="select">$select allows to pick which fields to include in the result. (optional)</param>
        /// <param name="or">Find all records that match any of the given criteria. (optional)</param>
        /// <param name="and">Find all records that match all of the given criteria. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FindAppMarketplace200Response</returns>
        public async System.Threading.Tasks.Task<FindAppMarketplace200Response> FindAppMarketplaceAsync (string search = default(string), int? limit = default(int?), int? skip = default(int?), Object sort = default(Object), List<string> select = default(List<string>), List<Object> or = default(List<Object>), List<Object> and = default(List<Object>), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FindAppMarketplace200Response> localVarResponse = await FindAppMarketplaceWithHttpInfoAsync(search, limit, skip, sort, select, or, and, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Find multiple objects Search and retrieve multiple objects simultaneously. 
        /// </summary>
        /// <exception cref="Com.CircuitID.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Filter results by the specified value. (optional)</param>
        /// <param name="limit">$limit will return only the number of results you specify. (optional)</param>
        /// <param name="skip">$skip will skip the specified number of results. (optional)</param>
        /// <param name="sort">$sort will sort based on the object you provide. It can contain a list of properties by which to sort mapped to the order (1 ascending, -1 descending). (optional)</param>
        /// <param name="select">$select allows to pick which fields to include in the result. (optional)</param>
        /// <param name="or">Find all records that match any of the given criteria. (optional)</param>
        /// <param name="and">Find all records that match all of the given criteria. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FindAppMarketplace200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FindAppMarketplace200Response>> FindAppMarketplaceWithHttpInfoAsync (string search = default(string), int? limit = default(int?), int? skip = default(int?), Object sort = default(Object), List<string> select = default(List<string>), List<Object> or = default(List<Object>), List<Object> and = default(List<Object>), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/appmarketplace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (search != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$search", search)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$limit", limit)); // query parameter
            if (skip != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$skip", skip)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "$sort", sort)); // query parameter
            if (select != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "$select", select)); // query parameter
            if (or != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "$or", or)); // query parameter
            if (and != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "$and", and)); // query parameter

            // authentication (jwt) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindAppMarketplace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FindAppMarketplace200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FindAppMarketplace200Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FindAppMarketplace200Response)));
        }

    }
}
