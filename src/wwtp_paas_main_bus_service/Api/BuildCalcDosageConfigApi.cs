/* 
 * wwtp-paas-main-bus-service
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
using wwtp_paas_main_bus_service.Client;
using wwtp_paas_main_bus_service.Model;

namespace wwtp_paas_main_bus_service.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBuildCalcDosageConfigApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 添加加药配置信息 Add dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Object</returns>
        Result<Object> ApiDosingSysIdConfigAddDosingSysIdConfigsPost (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>));

        /// <summary>
        /// 添加加药配置信息 Add dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Result<Object>> ApiDosingSysIdConfigAddDosingSysIdConfigsPostWithHttpInfo (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>));
        /// <summary>
        /// 根据ID删除加药配置信息 Delete dosing algorithm parameters config data by ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Object</returns>
        Result<Object> ApiDosingSysIdConfigDeleteDosingSysIdConfigsPost (List<Guid> requestBody = default(List<Guid>));

        /// <summary>
        /// 根据ID删除加药配置信息 Delete dosing algorithm parameters config data by ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Result<Object>> ApiDosingSysIdConfigDeleteDosingSysIdConfigsPostWithHttpInfo (List<Guid> requestBody = default(List<Guid>));
        /// <summary>
        /// 获取所有加药配置 Get all the dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;BuildCalcDosageConfigInOut&gt;</returns>
        Result<List<BuildCalcDosageConfigInOut>> ApiDosingSysIdConfigGetAllDosingSysIdConfigsGet ();

        /// <summary>
        /// 获取所有加药配置 Get all the dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;BuildCalcDosageConfigInOut&gt;</returns>
        ApiResponse<Result<List<BuildCalcDosageConfigInOut>>> ApiDosingSysIdConfigGetAllDosingSysIdConfigsGetWithHttpInfo ();
        /// <summary>
        /// 更新加药配置信息 Update dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Object</returns>
        Result<Object> ApiDosingSysIdConfigUpdateDosingSysIdConfigsPost (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>));

        /// <summary>
        /// 更新加药配置信息 Update dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Result<Object>> ApiDosingSysIdConfigUpdateDosingSysIdConfigsPostWithHttpInfo (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBuildCalcDosageConfigApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 添加加药配置信息 Add dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Result<Object>> ApiDosingSysIdConfigAddDosingSysIdConfigsPostAsync (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>));

        /// <summary>
        /// 添加加药配置信息 Add dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<Object>>> ApiDosingSysIdConfigAddDosingSysIdConfigsPostAsyncWithHttpInfo (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>));
        /// <summary>
        /// 根据ID删除加药配置信息 Delete dosing algorithm parameters config data by ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Result<Object>> ApiDosingSysIdConfigDeleteDosingSysIdConfigsPostAsync (List<Guid> requestBody = default(List<Guid>));

        /// <summary>
        /// 根据ID删除加药配置信息 Delete dosing algorithm parameters config data by ids
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<Object>>> ApiDosingSysIdConfigDeleteDosingSysIdConfigsPostAsyncWithHttpInfo (List<Guid> requestBody = default(List<Guid>));
        /// <summary>
        /// 获取所有加药配置 Get all the dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;BuildCalcDosageConfigInOut&gt;</returns>
        System.Threading.Tasks.Task<Result<List<BuildCalcDosageConfigInOut>>> ApiDosingSysIdConfigGetAllDosingSysIdConfigsGetAsync ();

        /// <summary>
        /// 获取所有加药配置 Get all the dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;BuildCalcDosageConfigInOut&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<List<BuildCalcDosageConfigInOut>>>> ApiDosingSysIdConfigGetAllDosingSysIdConfigsGetAsyncWithHttpInfo ();
        /// <summary>
        /// 更新加药配置信息 Update dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Result<Object>> ApiDosingSysIdConfigUpdateDosingSysIdConfigsPostAsync (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>));

        /// <summary>
        /// 更新加药配置信息 Update dosing algorithm parameters config data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Result<Object>>> ApiDosingSysIdConfigUpdateDosingSysIdConfigsPostAsyncWithHttpInfo (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBuildCalcDosageConfigApi : IBuildCalcDosageConfigApiSync, IBuildCalcDosageConfigApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BuildCalcDosageConfigApi : IBuildCalcDosageConfigApi
    {
        private wwtp_paas_main_bus_service.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCalcDosageConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BuildCalcDosageConfigApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCalcDosageConfigApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BuildCalcDosageConfigApi(String basePath)
        {
            this.Configuration = wwtp_paas_main_bus_service.Client.Configuration.MergeConfigurations(
                wwtp_paas_main_bus_service.Client.GlobalConfiguration.Instance,
                new wwtp_paas_main_bus_service.Client.Configuration { BasePath = basePath }
            );
            this.Client = new wwtp_paas_main_bus_service.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new wwtp_paas_main_bus_service.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = wwtp_paas_main_bus_service.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCalcDosageConfigApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BuildCalcDosageConfigApi(wwtp_paas_main_bus_service.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = wwtp_paas_main_bus_service.Client.Configuration.MergeConfigurations(
                wwtp_paas_main_bus_service.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new wwtp_paas_main_bus_service.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new wwtp_paas_main_bus_service.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = wwtp_paas_main_bus_service.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildCalcDosageConfigApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public BuildCalcDosageConfigApi(wwtp_paas_main_bus_service.Client.ISynchronousClient client,wwtp_paas_main_bus_service.Client.IAsynchronousClient asyncClient, wwtp_paas_main_bus_service.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = wwtp_paas_main_bus_service.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public wwtp_paas_main_bus_service.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public wwtp_paas_main_bus_service.Client.ISynchronousClient Client { get; set; }

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
        public wwtp_paas_main_bus_service.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public wwtp_paas_main_bus_service.Client.ExceptionFactory ExceptionFactory
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
        /// 添加加药配置信息 Add dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Object</returns>
        public Result<Object> ApiDosingSysIdConfigAddDosingSysIdConfigsPost (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>> localVarResponse = ApiDosingSysIdConfigAddDosingSysIdConfigsPostWithHttpInfo(buildCalcDosageConfigInOut);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 添加加药配置信息 Add dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public wwtp_paas_main_bus_service.Client.ApiResponse<Result< Object >> ApiDosingSysIdConfigAddDosingSysIdConfigsPostWithHttpInfo (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>))
        {
            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = buildCalcDosageConfigInOut;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< Object >>("/api/DosingSysIdConfig/AddDosingSysIdConfigs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiDosingSysIdConfigAddDosingSysIdConfigsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 添加加药配置信息 Add dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Result<Object>> ApiDosingSysIdConfigAddDosingSysIdConfigsPostAsync (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>> localVarResponse = await ApiDosingSysIdConfigAddDosingSysIdConfigsPostAsyncWithHttpInfo(buildCalcDosageConfigInOut);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 添加加药配置信息 Add dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>>> ApiDosingSysIdConfigAddDosingSysIdConfigsPostAsyncWithHttpInfo (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>))
        {

            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = buildCalcDosageConfigInOut;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<Object>>("/api/DosingSysIdConfig/AddDosingSysIdConfigs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiDosingSysIdConfigAddDosingSysIdConfigsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 根据ID删除加药配置信息 Delete dosing algorithm parameters config data by ids 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Object</returns>
        public Result<Object> ApiDosingSysIdConfigDeleteDosingSysIdConfigsPost (List<Guid> requestBody = default(List<Guid>))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>> localVarResponse = ApiDosingSysIdConfigDeleteDosingSysIdConfigsPostWithHttpInfo(requestBody);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 根据ID删除加药配置信息 Delete dosing algorithm parameters config data by ids 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public wwtp_paas_main_bus_service.Client.ApiResponse<Result< Object >> ApiDosingSysIdConfigDeleteDosingSysIdConfigsPostWithHttpInfo (List<Guid> requestBody = default(List<Guid>))
        {
            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = requestBody;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< Object >>("/api/DosingSysIdConfig/DeleteDosingSysIdConfigs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiDosingSysIdConfigDeleteDosingSysIdConfigsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 根据ID删除加药配置信息 Delete dosing algorithm parameters config data by ids 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Result<Object>> ApiDosingSysIdConfigDeleteDosingSysIdConfigsPostAsync (List<Guid> requestBody = default(List<Guid>))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>> localVarResponse = await ApiDosingSysIdConfigDeleteDosingSysIdConfigsPostAsyncWithHttpInfo(requestBody);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 根据ID删除加药配置信息 Delete dosing algorithm parameters config data by ids 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestBody"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>>> ApiDosingSysIdConfigDeleteDosingSysIdConfigsPostAsyncWithHttpInfo (List<Guid> requestBody = default(List<Guid>))
        {

            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = requestBody;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<Object>>("/api/DosingSysIdConfig/DeleteDosingSysIdConfigs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiDosingSysIdConfigDeleteDosingSysIdConfigsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 获取所有加药配置 Get all the dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>List&lt;BuildCalcDosageConfigInOut&gt;</returns>
        public Result<List<BuildCalcDosageConfigInOut>> ApiDosingSysIdConfigGetAllDosingSysIdConfigsGet ()
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<BuildCalcDosageConfigInOut>>> localVarResponse = ApiDosingSysIdConfigGetAllDosingSysIdConfigsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// 获取所有加药配置 Get all the dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of List&lt;BuildCalcDosageConfigInOut&gt;</returns>
        public wwtp_paas_main_bus_service.Client.ApiResponse<Result< List<BuildCalcDosageConfigInOut> >> ApiDosingSysIdConfigGetAllDosingSysIdConfigsGetWithHttpInfo ()
        {
            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);



            // make the HTTP request
            var localVarResponse = this.Client.Get<Result< List<BuildCalcDosageConfigInOut> >>("/api/DosingSysIdConfig/GetAllDosingSysIdConfigs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiDosingSysIdConfigGetAllDosingSysIdConfigsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 获取所有加药配置 Get all the dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of List&lt;BuildCalcDosageConfigInOut&gt;</returns>
        public async System.Threading.Tasks.Task<Result<List<BuildCalcDosageConfigInOut>>> ApiDosingSysIdConfigGetAllDosingSysIdConfigsGetAsync ()
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<BuildCalcDosageConfigInOut>>> localVarResponse = await ApiDosingSysIdConfigGetAllDosingSysIdConfigsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// 获取所有加药配置 Get all the dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (List&lt;BuildCalcDosageConfigInOut&gt;)</returns>
        public async System.Threading.Tasks.Task<wwtp_paas_main_bus_service.Client.ApiResponse<Result<List<BuildCalcDosageConfigInOut>>>> ApiDosingSysIdConfigGetAllDosingSysIdConfigsGetAsyncWithHttpInfo ()
        {

            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

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

            var localVarResponse = await this.AsynchronousClient.GetAsync<Result<List<BuildCalcDosageConfigInOut>>>("/api/DosingSysIdConfig/GetAllDosingSysIdConfigs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiDosingSysIdConfigGetAllDosingSysIdConfigsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 更新加药配置信息 Update dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Object</returns>
        public Result<Object> ApiDosingSysIdConfigUpdateDosingSysIdConfigsPost (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>> localVarResponse = ApiDosingSysIdConfigUpdateDosingSysIdConfigsPostWithHttpInfo(buildCalcDosageConfigInOut);
             return localVarResponse.Data;
        }

        /// <summary>
        /// 更新加药配置信息 Update dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>ApiResponse of Object</returns>
        public wwtp_paas_main_bus_service.Client.ApiResponse<Result< Object >> ApiDosingSysIdConfigUpdateDosingSysIdConfigsPostWithHttpInfo (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>))
        {
            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = wwtp_paas_main_bus_service.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = buildCalcDosageConfigInOut;


            // make the HTTP request
            var localVarResponse = this.Client.Post<Result< Object >>("/api/DosingSysIdConfig/UpdateDosingSysIdConfigs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiDosingSysIdConfigUpdateDosingSysIdConfigsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// 更新加药配置信息 Update dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Result<Object>> ApiDosingSysIdConfigUpdateDosingSysIdConfigsPostAsync (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>))
        {
             wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>> localVarResponse = await ApiDosingSysIdConfigUpdateDosingSysIdConfigsPostAsyncWithHttpInfo(buildCalcDosageConfigInOut);
             return localVarResponse.Data;

        }

        /// <summary>
        /// 更新加药配置信息 Update dosing algorithm parameters config data 
        /// </summary>
        /// <exception cref="wwtp_paas_main_bus_service.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildCalcDosageConfigInOut"> (optional)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<wwtp_paas_main_bus_service.Client.ApiResponse<Result<Object>>> ApiDosingSysIdConfigUpdateDosingSysIdConfigsPostAsyncWithHttpInfo (List<BuildCalcDosageConfigInOut> buildCalcDosageConfigInOut = default(List<BuildCalcDosageConfigInOut>))
        {

            wwtp_paas_main_bus_service.Client.RequestOptions localVarRequestOptions = new wwtp_paas_main_bus_service.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            localVarRequestOptions.Data = buildCalcDosageConfigInOut;


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Result<Object>>("/api/DosingSysIdConfig/UpdateDosingSysIdConfigs", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiDosingSysIdConfigUpdateDosingSysIdConfigsPost", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
