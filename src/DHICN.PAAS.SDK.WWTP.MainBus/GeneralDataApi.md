# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.GeneralDataApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiGeneralDataGetAssemblyConfigsGet**](GeneralDataApi.md#apigeneraldatagetassemblyconfigsget) | **GET** /api/GeneralData/GetAssemblyConfigs | 根据展示类型获取点位配置信息
[**ApiGeneralDataGetInletWQGet**](GeneralDataApi.md#apigeneraldatagetinletwqget) | **GET** /api/GeneralData/GetInletWQ | 获取进水水质数据，包括原始数据和清洗后数据 Get inlet water quality data, including source data and processed data
[**ApiGeneralDataGetModelPrecisionGet**](GeneralDataApi.md#apigeneraldatagetmodelprecisionget) | **GET** /api/GeneralData/GetModelPrecision | 获取指定时间段内的模型精度统计数据 Get model precison statistic data of a certain period
[**ApiGeneralDataGetOptimOutDataGet**](GeneralDataApi.md#apigeneraldatagetoptimoutdataget) | **GET** /api/GeneralData/GetOptimOutData | 获取优化建议 Get optimization recommendation data
[**ApiGeneralDataGetOutletWQGet**](GeneralDataApi.md#apigeneraldatagetoutletwqget) | **GET** /api/GeneralData/GetOutletWQ | 获取出水水质数据，包括在线数据和模拟结果数据 Get effluent water quality data, including online processed data and model result data
[**ApiGeneralDataGetPredictAlarmGet**](GeneralDataApi.md#apigeneraldatagetpredictalarmget) | **GET** /api/GeneralData/GetPredictAlarm | 获取进出水水质预警信息 Get alarm data for inlet and outlet water quality
[**ApiV2OutputChemicalCostGet**](GeneralDataApi.md#apiv2outputchemicalcostget) | **GET** /api/v2/output/chemical-cost | 根据实际投药量，获取吨水药耗统计信息 Get dosage cost per ton of inflow water statistic result based on actual dosage
[**ApiV2OutputDataBoardsGet**](GeneralDataApi.md#apiv2outputdataboardsget) | **GET** /api/v2/output/data-boards | 获取数据看板统计数据 Get statistic data for data board
[**ApiV2OutputDeviceMaintenanceGet**](GeneralDataApi.md#apiv2outputdevicemaintenanceget) | **GET** /api/v2/output/device/maintenance | 查询关键设备维护预警信息 Get key device maintenance warning information
[**ApiV2OutputEntireProcessTsByProductlineGet**](GeneralDataApi.md#apiv2outputentireprocesstsbyproductlineget) | **GET** /api/v2/output/entire-process/ts-by-productline | 通过生产线获取全流程水质 Get water quality entire process data by product line
[**ApiV2OutputRefreshDataBoardsGet**](GeneralDataApi.md#apiv2outputrefreshdataboardsget) | **GET** /api/v2/output/refresh-data-boards | 定时统计看板数据


<a name="apigeneraldatagetassemblyconfigsget"></a>
# **ApiGeneralDataGetAssemblyConfigsGet**
> List&lt;AssemblyConfigOutput&gt; ApiGeneralDataGetAssemblyConfigsGet (int? displayTypeEnum = null, string modelName = null, string productLine = null)

根据展示类型获取点位配置信息

根据展示类型获取点位配置信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiGeneralDataGetAssemblyConfigsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var displayTypeEnum = 56;  // int? | 展示类型 (optional) 
            var modelName = modelName_example;  // string | 模型名称 (optional) 
            var productLine = productLine_example;  // string | 工艺线 (optional) 

            try
            {
                // 根据展示类型获取点位配置信息
                List<AssemblyConfigOutput> result = apiInstance.ApiGeneralDataGetAssemblyConfigsGet(displayTypeEnum, modelName, productLine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiGeneralDataGetAssemblyConfigsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **displayTypeEnum** | **int?**| 展示类型 | [optional] 
 **modelName** | **string**| 模型名称 | [optional] 
 **productLine** | **string**| 工艺线 | [optional] 

### Return type

[**List&lt;AssemblyConfigOutput&gt;**](AssemblyConfigOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apigeneraldatagetinletwqget"></a>
# **ApiGeneralDataGetInletWQGet**
> List&lt;InletWqOut&gt; ApiGeneralDataGetInletWQGet (string startTime = null, string endTime = null, string modelName = null, string productLine = null)

获取进水水质数据，包括原始数据和清洗后数据 Get inlet water quality data, including source data and processed data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiGeneralDataGetInletWQGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 
            var productLine = productLine_example;  // string | 工艺线代码 product line code (optional) 

            try
            {
                // 获取进水水质数据，包括原始数据和清洗后数据 Get inlet water quality data, including source data and processed data
                List<InletWqOut> result = apiInstance.ApiGeneralDataGetInletWQGet(startTime, endTime, modelName, productLine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiGeneralDataGetInletWQGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 
 **modelName** | **string**| 模板模型名称 template model name | [optional] 
 **productLine** | **string**| 工艺线代码 product line code | [optional] 

### Return type

[**List&lt;InletWqOut&gt;**](InletWqOut.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apigeneraldatagetmodelprecisionget"></a>
# **ApiGeneralDataGetModelPrecisionGet**
> List&lt;ModelPrecision&gt; ApiGeneralDataGetModelPrecisionGet (string startTime = null, string endTime = null, string modelName = null)

获取指定时间段内的模型精度统计数据 Get model precison statistic data of a certain period

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiGeneralDataGetModelPrecisionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 

            try
            {
                // 获取指定时间段内的模型精度统计数据 Get model precison statistic data of a certain period
                List<ModelPrecision> result = apiInstance.ApiGeneralDataGetModelPrecisionGet(startTime, endTime, modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiGeneralDataGetModelPrecisionGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 
 **modelName** | **string**| 模板模型名称 template model name | [optional] 

### Return type

[**List&lt;ModelPrecision&gt;**](ModelPrecision.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apigeneraldatagetoptimoutdataget"></a>
# **ApiGeneralDataGetOptimOutDataGet**
> ModelOptimDto ApiGeneralDataGetOptimOutDataGet (string startTime = null, string endTime = null, string productLine = null, string modelName = null)

获取优化建议 Get optimization recommendation data

返回包括优化二沉池出水水质，优化控制建议 Secondary sedimentation tank effluent water quality statistic data and optimized control recommendation data will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiGeneralDataGetOptimOutDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var productLine = productLine_example;  // string | 工艺线代码 product line code (optional) 
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 

            try
            {
                // 获取优化建议 Get optimization recommendation data
                ModelOptimDto result = apiInstance.ApiGeneralDataGetOptimOutDataGet(startTime, endTime, productLine, modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiGeneralDataGetOptimOutDataGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 
 **productLine** | **string**| 工艺线代码 product line code | [optional] 
 **modelName** | **string**| 模板模型名称 template model name | [optional] 

### Return type

[**ModelOptimDto**](ModelOptimDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apigeneraldatagetoutletwqget"></a>
# **ApiGeneralDataGetOutletWQGet**
> List&lt;OutletWqOut&gt; ApiGeneralDataGetOutletWQGet (string startTime = null, string endTime = null, string modelName = null)

获取出水水质数据，包括在线数据和模拟结果数据 Get effluent water quality data, including online processed data and model result data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiGeneralDataGetOutletWQGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 

            try
            {
                // 获取出水水质数据，包括在线数据和模拟结果数据 Get effluent water quality data, including online processed data and model result data
                List<OutletWqOut> result = apiInstance.ApiGeneralDataGetOutletWQGet(startTime, endTime, modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiGeneralDataGetOutletWQGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 
 **modelName** | **string**| 模板模型名称 template model name | [optional] 

### Return type

[**List&lt;OutletWqOut&gt;**](OutletWqOut.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apigeneraldatagetpredictalarmget"></a>
# **ApiGeneralDataGetPredictAlarmGet**
> List&lt;PredictAlarmOut&gt; ApiGeneralDataGetPredictAlarmGet (string startTime = null, string endTime = null, List<string> alarmTypes = null, string isNationalStandard = null)

获取进出水水质预警信息 Get alarm data for inlet and outlet water quality

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiGeneralDataGetPredictAlarmGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var alarmTypes = new List<string>(); // List<string> | 消息类型 alarm types (optional) 
            var isNationalStandard = isNationalStandard_example;  // string | 是否获取国标 true indicates grade=1, and false indicates grade!=1 (optional) 

            try
            {
                // 获取进出水水质预警信息 Get alarm data for inlet and outlet water quality
                List<PredictAlarmOut> result = apiInstance.ApiGeneralDataGetPredictAlarmGet(startTime, endTime, alarmTypes, isNationalStandard);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiGeneralDataGetPredictAlarmGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 
 **alarmTypes** | [**List&lt;string&gt;**](string.md)| 消息类型 alarm types | [optional] 
 **isNationalStandard** | **string**| 是否获取国标 true indicates grade&#x3D;1, and false indicates grade!&#x3D;1 | [optional] 

### Return type

[**List&lt;PredictAlarmOut&gt;**](PredictAlarmOut.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2outputchemicalcostget"></a>
# **ApiV2OutputChemicalCostGet**
> List&lt;ChemicalCostPerFlowOutput&gt; ApiV2OutputChemicalCostGet (string modelName = null)

根据实际投药量，获取吨水药耗统计信息 Get dosage cost per ton of inflow water statistic result based on actual dosage

返回过去七天，每天每条工艺线上的碳源加药吨水药耗和MCCR加药吨水药耗 Carbon source doage cost per ton of water and MCCR dosage cost per ton of water of each product line and each day in the past seven days will be returned.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2OutputChemicalCostGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var modelName = modelName_example;  // string | 模型名称 template model name (optional) 

            try
            {
                // 根据实际投药量，获取吨水药耗统计信息 Get dosage cost per ton of inflow water statistic result based on actual dosage
                List<ChemicalCostPerFlowOutput> result = apiInstance.ApiV2OutputChemicalCostGet(modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiV2OutputChemicalCostGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **modelName** | **string**| 模型名称 template model name | [optional] 

### Return type

[**List&lt;ChemicalCostPerFlowOutput&gt;**](ChemicalCostPerFlowOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2outputdataboardsget"></a>
# **ApiV2OutputDataBoardsGet**
> List&lt;DataBoardFullOut&gt; ApiV2OutputDataBoardsGet ()

获取数据看板统计数据 Get statistic data for data board

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2OutputDataBoardsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);

            try
            {
                // 获取数据看板统计数据 Get statistic data for data board
                List<DataBoardFullOut> result = apiInstance.ApiV2OutputDataBoardsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiV2OutputDataBoardsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;DataBoardFullOut&gt;**](DataBoardFullOut.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2outputdevicemaintenanceget"></a>
# **ApiV2OutputDeviceMaintenanceGet**
> List&lt;DeviceMaintenanceOutput&gt; ApiV2OutputDeviceMaintenanceGet (string startTime = null, string endTime = null)

查询关键设备维护预警信息 Get key device maintenance warning information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2OutputDeviceMaintenanceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 查询关键设备维护预警信息 Get key device maintenance warning information
                List<DeviceMaintenanceOutput> result = apiInstance.ApiV2OutputDeviceMaintenanceGet(startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiV2OutputDeviceMaintenanceGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**List&lt;DeviceMaintenanceOutput&gt;**](DeviceMaintenanceOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2outputentireprocesstsbyproductlineget"></a>
# **ApiV2OutputEntireProcessTsByProductlineGet**
> List&lt;EntireProcessWqOut&gt; ApiV2OutputEntireProcessTsByProductlineGet (string productLine = null, string startTime = null, string endTime = null, string modelName = null)

通过生产线获取全流程水质 Get water quality entire process data by product line

查询指定时间段内，所有指标在每一个工艺单元上的时间序列结果数据，包括进水、各个生化池、出水 Get time-series result data of all the indicators on each process unit including inlet, biochemical pools and outlet of a certain period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2OutputEntireProcessTsByProductlineGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);
            var productLine = productLine_example;  // string | 工艺线代码 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 

            try
            {
                // 通过生产线获取全流程水质 Get water quality entire process data by product line
                List<EntireProcessWqOut> result = apiInstance.ApiV2OutputEntireProcessTsByProductlineGet(productLine, startTime, endTime, modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiV2OutputEntireProcessTsByProductlineGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productLine** | **string**| 工艺线代码 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 
 **modelName** | **string**| 模板模型名称 template model name | [optional] 

### Return type

[**List&lt;EntireProcessWqOut&gt;**](EntireProcessWqOut.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2outputrefreshdataboardsget"></a>
# **ApiV2OutputRefreshDataBoardsGet**
> StatisDataBoardsView ApiV2OutputRefreshDataBoardsGet ()

定时统计看板数据

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2OutputRefreshDataBoardsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new GeneralDataApi(config);

            try
            {
                // 定时统计看板数据
                StatisDataBoardsView result = apiInstance.ApiV2OutputRefreshDataBoardsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GeneralDataApi.ApiV2OutputRefreshDataBoardsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**StatisDataBoardsView**](StatisDataBoardsView.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

