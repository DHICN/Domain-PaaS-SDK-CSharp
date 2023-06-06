# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.WQAnalysisApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2WqAnalysisControlOnlinePointsGet**](WQAnalysisApi.md#apiv2wqanalysiscontrolonlinepointsget) | **GET** /api/v2/wq-analysis/control-online-points | 查询特定工艺线下的工艺运行输入点位 Get online control points detailed information on a certain product line
[**ApiV2WqAnalysisEntireProcessGet**](WQAnalysisApi.md#apiv2wqanalysisentireprocessget) | **GET** /api/v2/wq-analysis/entire-process | 查询水质全流程统计数据 Get water quality entire process statistic data
[**ApiV2WqAnalysisWqOnlineDataPost**](WQAnalysisApi.md#apiv2wqanalysiswqonlinedatapost) | **POST** /api/v2/wq-analysis/wq-online-data | 查询在线点位时间序列数据 Get online water quality or control data
[**ApiV2WqAnalysisWqOnlinePointsGet**](WQAnalysisApi.md#apiv2wqanalysiswqonlinepointsget) | **GET** /api/v2/wq-analysis/wq-online-points | 查询水质输入点位信息 Get online water quality points detailed information
[**ApiWQAnalysisUpdateWQInputDataPost**](WQAnalysisApi.md#apiwqanalysisupdatewqinputdatapost) | **POST** /api/WQAnalysis/UpdateWQInputData | 更新在线水质或控制点数据 Update online water quality or control data
[**V2WqAnalysisMicroOrganismGet**](WQAnalysisApi.md#v2wqanalysismicroorganismget) | **GET** /v2/wq-analysis/micro-organism | 获取微生物生长模拟结果 Get microbial growth simulation results


<a name="apiv2wqanalysiscontrolonlinepointsget"></a>
# **ApiV2WqAnalysisControlOnlinePointsGet**
> ControlOnlinePointOutput ApiV2WqAnalysisControlOnlinePointsGet (string modelName = null, string productLine = null)

查询特定工艺线下的工艺运行输入点位 Get online control points detailed information on a certain product line

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2WqAnalysisControlOnlinePointsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WQAnalysisApi(config);
            var modelName = modelName_example;  // string | 模型名称 template model name (optional) 
            var productLine = productLine_example;  // string | 工艺线 product line code (optional) 

            try
            {
                // 查询特定工艺线下的工艺运行输入点位 Get online control points detailed information on a certain product line
                ControlOnlinePointOutput result = apiInstance.ApiV2WqAnalysisControlOnlinePointsGet(modelName, productLine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WQAnalysisApi.ApiV2WqAnalysisControlOnlinePointsGet: " + e.Message );
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
 **productLine** | **string**| 工艺线 product line code | [optional] 

### Return type

[**ControlOnlinePointOutput**](ControlOnlinePointOutput.md)

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

<a name="apiv2wqanalysisentireprocessget"></a>
# **ApiV2WqAnalysisEntireProcessGet**
> List&lt;WqStatisticOutput&gt; ApiV2WqAnalysisEntireProcessGet (string startTime = null, string endTime = null, string modelName = null, string productLine = null)

查询水质全流程统计数据 Get water quality entire process statistic data

查询指定时间段内，单条工艺线上每个生化池的各个水质指标统计结果，包括最大值，最小值，平均值，以及实测值 Get water quality indicators' statistic results including maximum, minimum, average value and online value of each biochemical pool on a certain product line of a specified time period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2WqAnalysisEntireProcessGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WQAnalysisApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var modelName = modelName_example;  // string | 模型名称 template model name (optional) 
            var productLine = productLine_example;  // string | 工艺线 product line code (optional) 

            try
            {
                // 查询水质全流程统计数据 Get water quality entire process statistic data
                List<WqStatisticOutput> result = apiInstance.ApiV2WqAnalysisEntireProcessGet(startTime, endTime, modelName, productLine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WQAnalysisApi.ApiV2WqAnalysisEntireProcessGet: " + e.Message );
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
 **modelName** | **string**| 模型名称 template model name | [optional] 
 **productLine** | **string**| 工艺线 product line code | [optional] 

### Return type

[**List&lt;WqStatisticOutput&gt;**](WqStatisticOutput.md)

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

<a name="apiv2wqanalysiswqonlinedatapost"></a>
# **ApiV2WqAnalysisWqOnlineDataPost**
> List&lt;WqOnlineDataOutput&gt; ApiV2WqAnalysisWqOnlineDataPost (WqOnlineDataInput wqOnlineDataInput = null)

查询在线点位时间序列数据 Get online water quality or control data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2WqAnalysisWqOnlineDataPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WQAnalysisApi(config);
            var wqOnlineDataInput = new WqOnlineDataInput(); // WqOnlineDataInput |  (optional) 

            try
            {
                // 查询在线点位时间序列数据 Get online water quality or control data
                List<WqOnlineDataOutput> result = apiInstance.ApiV2WqAnalysisWqOnlineDataPost(wqOnlineDataInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WQAnalysisApi.ApiV2WqAnalysisWqOnlineDataPost: " + e.Message );
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
 **wqOnlineDataInput** | [**WqOnlineDataInput**](WqOnlineDataInput.md)|  | [optional] 

### Return type

[**List&lt;WqOnlineDataOutput&gt;**](WqOnlineDataOutput.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="apiv2wqanalysiswqonlinepointsget"></a>
# **ApiV2WqAnalysisWqOnlinePointsGet**
> List&lt;WqOnlinePointOutput&gt; ApiV2WqAnalysisWqOnlinePointsGet (string modelName = null)

查询水质输入点位信息 Get online water quality points detailed information

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2WqAnalysisWqOnlinePointsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WQAnalysisApi(config);
            var modelName = modelName_example;  // string | 模型名称 template model name (optional) 

            try
            {
                // 查询水质输入点位信息 Get online water quality points detailed information
                List<WqOnlinePointOutput> result = apiInstance.ApiV2WqAnalysisWqOnlinePointsGet(modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WQAnalysisApi.ApiV2WqAnalysisWqOnlinePointsGet: " + e.Message );
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

[**List&lt;WqOnlinePointOutput&gt;**](WqOnlinePointOutput.md)

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

<a name="apiwqanalysisupdatewqinputdatapost"></a>
# **ApiWQAnalysisUpdateWQInputDataPost**
> Object ApiWQAnalysisUpdateWQInputDataPost (List<UpdateWqInputDataInput> updateWqInputDataInput = null)

更新在线水质或控制点数据 Update online water quality or control data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiWQAnalysisUpdateWQInputDataPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WQAnalysisApi(config);
            var updateWqInputDataInput = new List<UpdateWqInputDataInput>(); // List<UpdateWqInputDataInput> |  (optional) 

            try
            {
                // 更新在线水质或控制点数据 Update online water quality or control data
                Object result = apiInstance.ApiWQAnalysisUpdateWQInputDataPost(updateWqInputDataInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WQAnalysisApi.ApiWQAnalysisUpdateWQInputDataPost: " + e.Message );
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
 **updateWqInputDataInput** | [**List&lt;UpdateWqInputDataInput&gt;**](UpdateWqInputDataInput.md)|  | [optional] 

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="v2wqanalysismicroorganismget"></a>
# **V2WqAnalysisMicroOrganismGet**
> List&lt;MicroOrganismOutput&gt; V2WqAnalysisMicroOrganismGet (string startTime = null, string endTime = null, string modelName = null, string productLine = null)

获取微生物生长模拟结果 Get microbial growth simulation results

获取指定时间段内，单条工艺线上的微生物生长模拟结果 Get microbial growth simulation results on a certain product line of a specified time period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class V2WqAnalysisMicroOrganismGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new WQAnalysisApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var modelName = modelName_example;  // string | 模型名称 template model name (optional) 
            var productLine = productLine_example;  // string | 工艺线 product line code (optional) 

            try
            {
                // 获取微生物生长模拟结果 Get microbial growth simulation results
                List<MicroOrganismOutput> result = apiInstance.V2WqAnalysisMicroOrganismGet(startTime, endTime, modelName, productLine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WQAnalysisApi.V2WqAnalysisMicroOrganismGet: " + e.Message );
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
 **modelName** | **string**| 模型名称 template model name | [optional] 
 **productLine** | **string**| 工艺线 product line code | [optional] 

### Return type

[**List&lt;MicroOrganismOutput&gt;**](MicroOrganismOutput.md)

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

