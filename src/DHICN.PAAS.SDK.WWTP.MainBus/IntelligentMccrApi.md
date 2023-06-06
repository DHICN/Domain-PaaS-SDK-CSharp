# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.IntelligentMccrApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2IntelligentMccrAddRatesGet**](IntelligentMccrApi.md#apiv2intelligentmccraddratesget) | **GET** /api/v2/intelligent-mccr/add-rates | 获取铁催化剂加药，或者双氧水加药的实际投加速率与计算投加速率 Get actual and calculated dosing rate data of iron catalysts or hydrogen peroxide
[**ApiV2IntelligentMccrCalculateMccrDosagePost**](IntelligentMccrApi.md#apiv2intelligentmccrcalculatemccrdosagepost) | **POST** /api/v2/intelligent-mccr/calculate-mccr-dosage | 计算指定产线的MCCR加药量 calculate MCCR&#39;s dosage by product line
[**ApiV2IntelligentMccrCatalysisBeforeAfterGet**](IntelligentMccrApi.md#apiv2intelligentmccrcatalysisbeforeafterget) | **GET** /api/v2/intelligent-mccr/catalysis-before-after | 获取催化反应前后的浊度、电导 Get online turbidity and conductivity data before and after catalysis
[**ApiV2IntelligentMccrCatalysisTankDataGet**](IntelligentMccrApi.md#apiv2intelligentmccrcatalysistankdataget) | **GET** /api/v2/intelligent-mccr/catalysis-tank-data | 获取催化池的进水量、pH、ORP数据 Get online inflow, pH, ORP data in the catalysis pool
[**ApiV2IntelligentMccrDailyStatisticsExportGet**](IntelligentMccrApi.md#apiv2intelligentmccrdailystatisticsexportget) | **GET** /api/v2/intelligent-mccr/daily-statistics/export | 指定时间段内加药统计文件导出 Export dosing daily statistic results of a certain period as an excel file
[**ApiV2IntelligentMccrDailyStatisticsGet**](IntelligentMccrApi.md#apiv2intelligentmccrdailystatisticsget) | **GET** /api/v2/intelligent-mccr/daily-statistics | 指定时间段内加药统计查询 Get dosing daily statistic results of a certain period
[**ApiV2IntelligentMccrDosingLogExportGet**](IntelligentMccrApi.md#apiv2intelligentmccrdosinglogexportget) | **GET** /api/v2/intelligent-mccr/dosing-log/export | 指定时间段内加药报表文件导出 Export dosing logs of a certain period as an excel file
[**ApiV2IntelligentMccrPlcControlByProductLinePost**](IntelligentMccrApi.md#apiv2intelligentmccrplccontrolbyproductlinepost) | **POST** /api/v2/intelligent-mccr/plc-control-by-product-line | 执行指定产线的MCCR加药plc控制，同时写入加药日志 Execute MCCR dosing plc control and write dosing logs for one product line
[**ApiV2IntelligentMccrPlcControlGet**](IntelligentMccrApi.md#apiv2intelligentmccrplccontrolget) | **GET** /api/v2/intelligent-mccr/plc-control | 执行MCCR加药plc控制，同时写入加药日志 Execute MCCR dosing plc control and write dosing logs


<a name="apiv2intelligentmccraddratesget"></a>
# **ApiV2IntelligentMccrAddRatesGet**
> CdAdditionRateOutput ApiV2IntelligentMccrAddRatesGet (string productionLine = null, int? category = null, string startTime = null, string endTime = null)

获取铁催化剂加药，或者双氧水加药的实际投加速率与计算投加速率 Get actual and calculated dosing rate data of iron catalysts or hydrogen peroxide

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrAddRatesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var productionLine = productionLine_example;  // string | 工艺线代码 product line code (optional) 
            var category = 56;  // int? | 药剂类型 dosage type (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取铁催化剂加药，或者双氧水加药的实际投加速率与计算投加速率 Get actual and calculated dosing rate data of iron catalysts or hydrogen peroxide
                CdAdditionRateOutput result = apiInstance.ApiV2IntelligentMccrAddRatesGet(productionLine, category, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrAddRatesGet: " + e.Message );
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
 **productionLine** | **string**| 工艺线代码 product line code | [optional] 
 **category** | **int?**| 药剂类型 dosage type | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**CdAdditionRateOutput**](CdAdditionRateOutput.md)

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

<a name="apiv2intelligentmccrcalculatemccrdosagepost"></a>
# **ApiV2IntelligentMccrCalculateMccrDosagePost**
> Object ApiV2IntelligentMccrCalculateMccrDosagePost (List<DosingParamSettingDto> dosingParamSettingDto = null)

计算指定产线的MCCR加药量 calculate MCCR's dosage by product line

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrCalculateMccrDosagePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var dosingParamSettingDto = new List<DosingParamSettingDto>(); // List<DosingParamSettingDto> |  (optional) 

            try
            {
                // 计算指定产线的MCCR加药量 calculate MCCR's dosage by product line
                Object result = apiInstance.ApiV2IntelligentMccrCalculateMccrDosagePost(dosingParamSettingDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrCalculateMccrDosagePost: " + e.Message );
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

<a name="apiv2intelligentmccrcatalysisbeforeafterget"></a>
# **ApiV2IntelligentMccrCatalysisBeforeAfterGet**
> List&lt;CatalysisBfOutput&gt; ApiV2IntelligentMccrCatalysisBeforeAfterGet (string productLine = null, string startTime = null, string endTime = null)

获取催化反应前后的浊度、电导 Get online turbidity and conductivity data before and after catalysis

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrCatalysisBeforeAfterGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var productLine = productLine_example;  // string |  (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取催化反应前后的浊度、电导 Get online turbidity and conductivity data before and after catalysis
                List<CatalysisBfOutput> result = apiInstance.ApiV2IntelligentMccrCatalysisBeforeAfterGet(productLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrCatalysisBeforeAfterGet: " + e.Message );
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
 **productLine** | **string**|  | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**List&lt;CatalysisBfOutput&gt;**](CatalysisBfOutput.md)

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

<a name="apiv2intelligentmccrcatalysistankdataget"></a>
# **ApiV2IntelligentMccrCatalysisTankDataGet**
> List&lt;CatalysisTankOutput&gt; ApiV2IntelligentMccrCatalysisTankDataGet (string productLine = null, string startTime = null, string endTime = null)

获取催化池的进水量、pH、ORP数据 Get online inflow, pH, ORP data in the catalysis pool

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrCatalysisTankDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var productLine = productLine_example;  // string |  (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取催化池的进水量、pH、ORP数据 Get online inflow, pH, ORP data in the catalysis pool
                List<CatalysisTankOutput> result = apiInstance.ApiV2IntelligentMccrCatalysisTankDataGet(productLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrCatalysisTankDataGet: " + e.Message );
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
 **productLine** | **string**|  | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**List&lt;CatalysisTankOutput&gt;**](CatalysisTankOutput.md)

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

<a name="apiv2intelligentmccrdailystatisticsexportget"></a>
# **ApiV2IntelligentMccrDailyStatisticsExportGet**
> void ApiV2IntelligentMccrDailyStatisticsExportGet (string productionLine = null, string startTime = null, string endTime = null)

指定时间段内加药统计文件导出 Export dosing daily statistic results of a certain period as an excel file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrDailyStatisticsExportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var productionLine = productionLine_example;  // string | 工艺线代码 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 指定时间段内加药统计文件导出 Export dosing daily statistic results of a certain period as an excel file
                apiInstance.ApiV2IntelligentMccrDailyStatisticsExportGet(productionLine, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrDailyStatisticsExportGet: " + e.Message );
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
 **productionLine** | **string**| 工艺线代码 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2intelligentmccrdailystatisticsget"></a>
# **ApiV2IntelligentMccrDailyStatisticsGet**
> List&lt;DosingStatisticDailysOutput&gt; ApiV2IntelligentMccrDailyStatisticsGet (string productionLine = null, string startTime = null, string endTime = null)

指定时间段内加药统计查询 Get dosing daily statistic results of a certain period

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrDailyStatisticsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var productionLine = productionLine_example;  // string | 工艺线代码 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 指定时间段内加药统计查询 Get dosing daily statistic results of a certain period
                List<DosingStatisticDailysOutput> result = apiInstance.ApiV2IntelligentMccrDailyStatisticsGet(productionLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrDailyStatisticsGet: " + e.Message );
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
 **productionLine** | **string**| 工艺线代码 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**List&lt;DosingStatisticDailysOutput&gt;**](DosingStatisticDailysOutput.md)

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

<a name="apiv2intelligentmccrdosinglogexportget"></a>
# **ApiV2IntelligentMccrDosingLogExportGet**
> void ApiV2IntelligentMccrDosingLogExportGet (string productionLine = null, string startTime = null, string endTime = null)

指定时间段内加药报表文件导出 Export dosing logs of a certain period as an excel file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrDosingLogExportGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var productionLine = productionLine_example;  // string | 工艺线代码 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 指定时间段内加药报表文件导出 Export dosing logs of a certain period as an excel file
                apiInstance.ApiV2IntelligentMccrDosingLogExportGet(productionLine, startTime, endTime);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrDosingLogExportGet: " + e.Message );
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
 **productionLine** | **string**| 工艺线代码 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **500** | Server Error |  -  |
| **501** | Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiv2intelligentmccrplccontrolbyproductlinepost"></a>
# **ApiV2IntelligentMccrPlcControlByProductLinePost**
> Object ApiV2IntelligentMccrPlcControlByProductLinePost (ExecutePlcInput executePlcInput = null)

执行指定产线的MCCR加药plc控制，同时写入加药日志 Execute MCCR dosing plc control and write dosing logs for one product line

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrPlcControlByProductLinePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var executePlcInput = new ExecutePlcInput(); // ExecutePlcInput |  (optional) 

            try
            {
                // 执行指定产线的MCCR加药plc控制，同时写入加药日志 Execute MCCR dosing plc control and write dosing logs for one product line
                Object result = apiInstance.ApiV2IntelligentMccrPlcControlByProductLinePost(executePlcInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrPlcControlByProductLinePost: " + e.Message );
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

<a name="apiv2intelligentmccrplccontrolget"></a>
# **ApiV2IntelligentMccrPlcControlGet**
> Object ApiV2IntelligentMccrPlcControlGet (string currentTime = null)

执行MCCR加药plc控制，同时写入加药日志 Execute MCCR dosing plc control and write dosing logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2IntelligentMccrPlcControlGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentMccrApi(config);
            var currentTime = currentTime_example;  // string | 当前时刻 current time (optional) 

            try
            {
                // 执行MCCR加药plc控制，同时写入加药日志 Execute MCCR dosing plc control and write dosing logs
                Object result = apiInstance.ApiV2IntelligentMccrPlcControlGet(currentTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentMccrApi.ApiV2IntelligentMccrPlcControlGet: " + e.Message );
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
 **currentTime** | **string**| 当前时刻 current time | [optional] 

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

