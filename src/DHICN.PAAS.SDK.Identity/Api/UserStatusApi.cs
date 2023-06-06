/* 
 * identity-service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using DHICN.PAAS.SDK.Identity.Client;
using DHICN.PAAS.SDK.Identity.Model;

namespace DHICN.PAAS.SDK.Identity.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserStatusApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// /api/app/usersMnanger/status/get-all
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;OrganizationWithUserStatusInfo&gt;</returns>
        Result<List<OrganizationWithUserStatusInfo>> ApiAppUsersMnangerStatusGetAllGet ();

        /// <summary>
        /// /api/app/usersMnanger/status/get-all
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;OrganizationWithUserStatusInfo&gt;</returns>
        ApiResponse<Result<List<OrganizationWithUserStatusInfo>>> ApiAppUsersMnangerStatusGetAllGetWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserStatusApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// /api/app/usersMnanger/status/get-all
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;OrganizationWithUserStatusInfo&gt;</returns>
        System.Threading.Tasks.Task<Result<List<OrganizationWithUserStatusInfo>>> ApiAppUsersMnangerStatusGetAllGetAsync ();

        /// <summary>
        /// /api/app/usersMnanger/status/get-all
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;OrganizationWithUserStatusInfo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<List<OrganizationWithUserStatusInfo>>>> ApiAppUsersMnangerStatusGetAllGetAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserStatusApi : IUserStatusApiSync, IUserStatusApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserStatusApi : IUserStatusApi
    {
        private DHICN.PAAS.SDK.Identity.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserStatusApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserStatusApi(String basePath)
        {
            this.Configuration = DHICN.PAAS.SDK.Identity.Client.Configuration.MergeConfigurations(
                DHICN.PAAS.SDK.Identity.Client.GlobalConfiguration.Instance,
                new DHICN.PAAS.SDK.Identity.Client.Configuration { BasePath = basePath }
            );
            this.Client = new DHICN.PAAS.SDK.Identity.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DHICN.PAAS.SDK.Identity.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = DHICN.PAAS.SDK.Identity.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserStatusApi(DHICN.PAAS.SDK.Identity.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = DHICN.PAAS.SDK.Identity.Client.Configuration.MergeConfigurations(
                DHICN.PAAS.SDK.Identity.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new DHICN.PAAS.SDK.Identity.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new DHICN.PAAS.SDK.Identity.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = DHICN.PAAS.SDK.Identity.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStatusApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UserStatusApi(DHICN.PAAS.SDK.Identity.Client.ISynchronousClient client,DHICN.PAAS.SDK.Identity.Client.IAsynchronousClient asyncClient, DHICN.PAAS.SDK.Identity.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = DHICN.PAAS.SDK.Identity.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public DHICN.PAAS.SDK.Identity.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public DHICN.PAAS.SDK.Identity.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public DHICN.PAAS.SDK.Identity.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DHICN.PAAS.SDK.Identity.Client.ExceptionFactory ExceptionFactory
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
        /// /api/app/usersMnanger/status/get-all 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;OrganizationWithUserStatusInfo&gt;</returns>
        public Result<List<OrganizationWithUserStatusInfo>> ApiAppUsersMnangerStatusGetAllGet ()
        {
             DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<List<OrganizationWithUserStatusInfo>>> localVarResponse = ApiAppUsersMnangerStatusGetAllGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// /api/app/usersMnanger/status/get-all 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;OrganizationWithUserStatusInfo&gt;</returns>
        public DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result< List<OrganizationWithUserStatusInfo> >> ApiAppUsersMnangerStatusGetAllGetWithHttpInfo ()
        {
            DHICN.PAAS.SDK.Identity.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Identity.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = DHICN.PAAS.SDK.Identity.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = DHICN.PAAS.SDK.Identity.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<Result< List<OrganizationWithUserStatusInfo> >>("/api/app/usersMnanger/status/get-all", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiAppUsersMnangerStatusGetAllGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// /api/app/usersMnanger/status/get-all 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;OrganizationWithUserStatusInfo&gt;</returns>
        public async System.Threading.Tasks.Task<Result<List<OrganizationWithUserStatusInfo>>> ApiAppUsersMnangerStatusGetAllGetAsync ()
        {
             DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<List<OrganizationWithUserStatusInfo>>> localVarResponse = await ApiAppUsersMnangerStatusGetAllGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// /api/app/usersMnanger/status/get-all 
        /// </summary>
        /// <exception cref="DHICN.PAAS.SDK.Identity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;OrganizationWithUserStatusInfo&gt;)</returns>
        public async System.Threading.Tasks.Task<DHICN.PAAS.SDK.Identity.Client.ApiResponse<Result<List<OrganizationWithUserStatusInfo>>>> ApiAppUsersMnangerStatusGetAllGetAsyncWithHttpInfo ()
        {

            DHICN.PAAS.SDK.Identity.Client.RequestOptions localVarRequestOptions = new DHICN.PAAS.SDK.Identity.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Result<List<OrganizationWithUserStatusInfo>>>("/api/app/usersMnanger/status/get-all", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiAppUsersMnangerStatusGetAllGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}