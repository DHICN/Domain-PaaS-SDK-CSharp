# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.CalculateDosageApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiCalculateDosageCalculateCarbonDosagePost**](CalculateDosageApi.md#apicalculatedosagecalculatecarbondosagepost) | **POST** /api/CalculateDosage/CalculateCarbonDosage | 计算指定产线的碳源加药量 calculate carbon&#39;s dosage by product line
[**ApiCalculateDosageCalculateDosageGet**](CalculateDosageApi.md#apicalculatedosagecalculatedosageget) | **GET** /api/CalculateDosage/CalculateDosage | 加药计算，包括碳源加药和MCCR加药计算 Execute dosage calculation, including carbon source dosage and MCCR dosage
[**ApiCalculateDosageDosageStatisticDailyGet**](CalculateDosageApi.md#apicalculatedosagedosagestatisticdailyget) | **GET** /api/CalculateDosage/DosageStatisticDaily | 加药量日/月统计，定期执行（半小时） Execute dosage daily and monthly statistics periodically (every half an hour)
[**ApiCalculateDosageExcutePLCGet**](CalculateDosageApi.md#apicalculatedosageexcuteplcget) | **GET** /api/CalculateDosage/ExcutePLC | 执行碳源加药plc控制，同时写入加药日志 Execute carbon source dosing plc control and write dosing logs
[**ApiCalculateDosageExecuteCarbonPLCByProductLinePost**](CalculateDosageApi.md#apicalculatedosageexecutecarbonplcbyproductlinepost) | **POST** /api/CalculateDosage/ExecuteCarbonPLCByProductLine | 执行指定产线的碳源加药plc控制，同时写入加药日志 Execute carbon source dosing plc control and write dosing logs by specify product line
[**ApiCalculateDosageJudgeDosagePost**](CalculateDosageApi.md#apicalculatedosagejudgedosagepost) | **POST** /api/CalculateDosage/JudgeDosage | 判断加药量，写入报警日志 Write dosage alarm logs based on dosage
[**ApiCalculateDosageUpdateComputerParametersByProductLineGet**](CalculateDosageApi.md#apicalculatedosageupdatecomputerparametersbyproductlineget) | **GET** /api/CalculateDosage/UpdateComputerParametersByProductLine | 更新计算参数-推送指定产线的数据（清洗数据） Push processed time-series data to dosage algorithm for one product line
[**ApiCalculateDosageUpdateComputerParametersGet**](CalculateDosageApi.md#apicalculatedosageupdatecomputerparametersget) | **GET** /api/CalculateDosage/UpdateComputerParameters | 更新计算参数-推送数据（清洗数据） Push processed time-series data to dosage algorithm
[**ApiCalculateDosageUpdateComputerParametersSourceDataGet**](CalculateDosageApi.md#apicalculatedosageupdatecomputerparameterssourcedataget) | **GET** /api/CalculateDosage/UpdateComputerParametersSourceData | 更新计算参数-推送数据（mccr相关点位推送原表数据） Push source time-series data to dosage algorithm


<a name="apicalculatedosagecalculatecarbondosagepost"></a>
# **ApiCalculateDosageCalculateCarbonDosagePost**
> Object ApiCalculateDosageCalculateCarbonDosagePost (List<DosingParamSettingDto> dosingParamSettingDto = null)

计算指定产线的碳源加药量 calculate carbon's dosage by product line

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageCalculateCarbonDosagePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);
            var dosingParamSettingDto = new List<DosingParamSettingDto>(); // List<DosingParamSettingDto> |  (optional) 

            try
            {
                // 计算指定产线的碳源加药量 calculate carbon's dosage by product line
                Object result = apiInstance.ApiCalculateDosageCalculateCarbonDosagePost(dosingParamSettingDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageCalculateCarbonDosagePost: " + e.Message );
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
 **dosingParamSettingDto** | [**List&lt;DosingParamSettingDto&gt;**](DosingParamSettingDto.md)|  | [optional] 

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

<a name="apicalculatedosagecalculatedosageget"></a>
# **ApiCalculateDosageCalculateDosageGet**
> Object ApiCalculateDosageCalculateDosageGet (string tenantId = null)

加药计算，包括碳源加药和MCCR加药计算 Execute dosage calculation, including carbon source dosage and MCCR dosage

此接口由计算服务在完成每个时刻的滚动计算之后调用 This API is called by compute service each hour after automatic simulation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageCalculateDosageGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);
            var tenantId = tenantId_example;  // string |  (optional) 

            try
            {
                // 加药计算，包括碳源加药和MCCR加药计算 Execute dosage calculation, including carbon source dosage and MCCR dosage
                Object result = apiInstance.ApiCalculateDosageCalculateDosageGet(tenantId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageCalculateDosageGet: " + e.Message );
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
 **tenantId** | **string**|  | [optional] 

### Return type

**Object**

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

<a name="apicalculatedosagedosagestatisticdailyget"></a>
# **ApiCalculateDosageDosageStatisticDailyGet**
> Object ApiCalculateDosageDosageStatisticDailyGet (string currentTime = null)

加药量日/月统计，定期执行（半小时） Execute dosage daily and monthly statistics periodically (every half an hour)

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageDosageStatisticDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);
            var currentTime = currentTime_example;  // string | 当前时间 current time (optional) 

            try
            {
                // 加药量日/月统计，定期执行（半小时） Execute dosage daily and monthly statistics periodically (every half an hour)
                Object result = apiInstance.ApiCalculateDosageDosageStatisticDailyGet(currentTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageDosageStatisticDailyGet: " + e.Message );
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
 **currentTime** | **string**| 当前时间 current time | [optional] 

### Return type

**Object**

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

<a name="apicalculatedosageexcuteplcget"></a>
# **ApiCalculateDosageExcutePLCGet**
> Object ApiCalculateDosageExcutePLCGet (string currentTime = null)

执行碳源加药plc控制，同时写入加药日志 Execute carbon source dosing plc control and write dosing logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageExcutePLCGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);
            var currentTime = currentTime_example;  // string | 当前时间 current time (optional) 

            try
            {
                // 执行碳源加药plc控制，同时写入加药日志 Execute carbon source dosing plc control and write dosing logs
                Object result = apiInstance.ApiCalculateDosageExcutePLCGet(currentTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageExcutePLCGet: " + e.Message );
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
 **currentTime** | **string**| 当前时间 current time | [optional] 

### Return type

**Object**

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

<a name="apicalculatedosageexecutecarbonplcbyproductlinepost"></a>
# **ApiCalculateDosageExecuteCarbonPLCByProductLinePost**
> Object ApiCalculateDosageExecuteCarbonPLCByProductLinePost (ExecutePlcInput executePlcInput = null)

执行指定产线的碳源加药plc控制，同时写入加药日志 Execute carbon source dosing plc control and write dosing logs by specify product line

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageExecuteCarbonPLCByProductLinePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);
            var executePlcInput = new ExecutePlcInput(); // ExecutePlcInput |  (optional) 

            try
            {
                // 执行指定产线的碳源加药plc控制，同时写入加药日志 Execute carbon source dosing plc control and write dosing logs by specify product line
                Object result = apiInstance.ApiCalculateDosageExecuteCarbonPLCByProductLinePost(executePlcInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageExecuteCarbonPLCByProductLinePost: " + e.Message );
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
 **executePlcInput** | [**ExecutePlcInput**](ExecutePlcInput.md)|  | [optional] 

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

<a name="apicalculatedosagejudgedosagepost"></a>
# **ApiCalculateDosageJudgeDosagePost**
> Object ApiCalculateDosageJudgeDosagePost ()

判断加药量，写入报警日志 Write dosage alarm logs based on dosage

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageJudgeDosagePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);

            try
            {
                // 判断加药量，写入报警日志 Write dosage alarm logs based on dosage
                Object result = apiInstance.ApiCalculateDosageJudgeDosagePost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageJudgeDosagePost: " + e.Message );
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

**Object**

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

<a name="apicalculatedosageupdatecomputerparametersbyproductlineget"></a>
# **ApiCalculateDosageUpdateComputerParametersByProductLineGet**
> Object ApiCalculateDosageUpdateComputerParametersByProductLineGet (string scenarioId = null, string productLine = null)

更新计算参数-推送指定产线的数据（清洗数据） Push processed time-series data to dosage algorithm for one product line

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageUpdateComputerParametersByProductLineGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 
            var productLine = productLine_example;  // string | 产线 product line (optional) 

            try
            {
                // 更新计算参数-推送指定产线的数据（清洗数据） Push processed time-series data to dosage algorithm for one product line
                Object result = apiInstance.ApiCalculateDosageUpdateComputerParametersByProductLineGet(scenarioId, productLine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageUpdateComputerParametersByProductLineGet: " + e.Message );
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
 **scenarioId** | **string**| 方案ID scenario id | [optional] 
 **productLine** | **string**| 产线 product line | [optional] 

### Return type

**Object**

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

<a name="apicalculatedosageupdatecomputerparametersget"></a>
# **ApiCalculateDosageUpdateComputerParametersGet**
> Object ApiCalculateDosageUpdateComputerParametersGet (string tenantId = null, string scenarioId = null)

更新计算参数-推送数据（清洗数据） Push processed time-series data to dosage algorithm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageUpdateComputerParametersGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);
            var tenantId = tenantId_example;  // string | 租户ID tenant id (optional) 
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 

            try
            {
                // 更新计算参数-推送数据（清洗数据） Push processed time-series data to dosage algorithm
                Object result = apiInstance.ApiCalculateDosageUpdateComputerParametersGet(tenantId, scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageUpdateComputerParametersGet: " + e.Message );
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
 **tenantId** | **string**| 租户ID tenant id | [optional] 
 **scenarioId** | **string**| 方案ID scenario id | [optional] 

### Return type

**Object**

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

<a name="apicalculatedosageupdatecomputerparameterssourcedataget"></a>
# **ApiCalculateDosageUpdateComputerParametersSourceDataGet**
> Object ApiCalculateDosageUpdateComputerParametersSourceDataGet (string tenantId = null, string scenarioId = null)

更新计算参数-推送数据（mccr相关点位推送原表数据） Push source time-series data to dosage algorithm

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiCalculateDosageUpdateComputerParametersSourceDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new CalculateDosageApi(config);
            var tenantId = tenantId_example;  // string | 租户ID tenant id (optional) 
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 

            try
            {
                // 更新计算参数-推送数据（mccr相关点位推送原表数据） Push source time-series data to dosage algorithm
                Object result = apiInstance.ApiCalculateDosageUpdateComputerParametersSourceDataGet(tenantId, scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CalculateDosageApi.ApiCalculateDosageUpdateComputerParametersSourceDataGet: " + e.Message );
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
 **tenantId** | **string**| 租户ID tenant id | [optional] 
 **scenarioId** | **string**| 方案ID scenario id | [optional] 

### Return type

**Object**

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

