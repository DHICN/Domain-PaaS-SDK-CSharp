# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.IntelligentDenitrificationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiIntelligentDenitrificationDownloadDosingLogGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationdownloaddosinglogget) | **GET** /api/IntelligentDenitrification/DownloadDosingLog | 指定时间段内加药报表文件导出 Export dosing logs of a certain period as an excel file
[**ApiIntelligentDenitrificationDownloadDosingStatisticDailyGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationdownloaddosingstatisticdailyget) | **GET** /api/IntelligentDenitrification/DownloadDosingStatisticDaily | 指定时间段内加药统计文件导出 Export dosing daily statistic results of a certain period as an excel file
[**ApiIntelligentDenitrificationGetABFTProcessStatusGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetabftprocessstatusget) | **GET** /api/IntelligentDenitrification/GetABFTProcessStatus | 获取生化池工艺运行状态 Get biochemical pool operation status
[**ApiIntelligentDenitrificationGetAnoxicNO3Get**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetanoxicno3get) | **GET** /api/IntelligentDenitrification/GetAnoxicNO3 | 获取缺氧区出水硝酸盐 Get anoxic zone effluent nitrate concentration
[**ApiIntelligentDenitrificationGetAssemblyConfigsGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetassemblyconfigsget) | **GET** /api/IntelligentDenitrification/GetAssemblyConfigs | 根据展示类别获取点位配置信息
[**ApiIntelligentDenitrificationGetCDAdditionRateGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetcdadditionrateget) | **GET** /api/IntelligentDenitrification/GetCDAdditionRate | 获取碳源投加速率 Get carbon source dosing rate data
[**ApiIntelligentDenitrificationGetDenitrificationRateGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetdenitrificationrateget) | **GET** /api/IntelligentDenitrification/GetDenitrificationRate | 获取反硝化速率 Get denitrification rate data
[**ApiIntelligentDenitrificationGetDosingLogGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetdosinglogget) | **GET** /api/IntelligentDenitrification/GetDosingLog | 获取指定时间段内的加药报表 Get dosing logs of a certain period
[**ApiIntelligentDenitrificationGetDosingParameterGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetdosingparameterget) | **GET** /api/IntelligentDenitrification/GetDosingParameter | 获取加药参数 Get dosing paramters
[**ApiIntelligentDenitrificationGetDosingStatisticDailysGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetdosingstatisticdailysget) | **GET** /api/IntelligentDenitrification/GetDosingStatisticDailys | 指定时间段内加药统计查询 Get dosing daily statistic results of a certain period
[**ApiIntelligentDenitrificationGetInletLoadGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetinletloadget) | **GET** /api/IntelligentDenitrification/GetInletLoad | 获取进水负荷 Get inlet water quality load data
[**ApiIntelligentDenitrificationGetOutletTNGet**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationgetoutlettnget) | **GET** /api/IntelligentDenitrification/GetOutletTN | 获取出水总氮 Get total effluent nitrogen concentration
[**ApiIntelligentDenitrificationSaveDosingParameterPost**](IntelligentDenitrificationApi.md#apiintelligentdenitrificationsavedosingparameterpost) | **POST** /api/IntelligentDenitrification/SaveDosingParameter | 保存加药参数 Save dosing parameters


<a name="apiintelligentdenitrificationdownloaddosinglogget"></a>
# **ApiIntelligentDenitrificationDownloadDosingLogGet**
> void ApiIntelligentDenitrificationDownloadDosingLogGet (int? category = null, string productionLine = null, string startTime = null, string endTime = null, string downloadKey = null)

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
    public class ApiIntelligentDenitrificationDownloadDosingLogGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var category = 56;  // int? | 加药类型 dosage type (optional) 
            var productionLine = productionLine_example;  // string | 产线代码 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var downloadKey = downloadKey_example;  // string | 下载key download key (optional) 

            try
            {
                // 指定时间段内加药报表文件导出 Export dosing logs of a certain period as an excel file
                apiInstance.ApiIntelligentDenitrificationDownloadDosingLogGet(category, productionLine, startTime, endTime, downloadKey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationDownloadDosingLogGet: " + e.Message );
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
 **category** | **int?**| 加药类型 dosage type | [optional] 
 **productionLine** | **string**| 产线代码 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 
 **downloadKey** | **string**| 下载key download key | [optional] 

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

<a name="apiintelligentdenitrificationdownloaddosingstatisticdailyget"></a>
# **ApiIntelligentDenitrificationDownloadDosingStatisticDailyGet**
> void ApiIntelligentDenitrificationDownloadDosingStatisticDailyGet (int? category = null, string startTime = null, string endTime = null, string downloadKey = null)

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
    public class ApiIntelligentDenitrificationDownloadDosingStatisticDailyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var category = 56;  // int? | 加药类型 dosage type (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 
            var downloadKey = downloadKey_example;  // string | 下载key download key (optional) 

            try
            {
                // 指定时间段内加药统计文件导出 Export dosing daily statistic results of a certain period as an excel file
                apiInstance.ApiIntelligentDenitrificationDownloadDosingStatisticDailyGet(category, startTime, endTime, downloadKey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationDownloadDosingStatisticDailyGet: " + e.Message );
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
 **category** | **int?**| 加药类型 dosage type | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 
 **downloadKey** | **string**| 下载key download key | [optional] 

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

<a name="apiintelligentdenitrificationgetabftprocessstatusget"></a>
# **ApiIntelligentDenitrificationGetABFTProcessStatusGet**
> List&lt;AbftProcessStatusOutput&gt; ApiIntelligentDenitrificationGetABFTProcessStatusGet (string productionLine = null, string startTime = null, string endTime = null)

获取生化池工艺运行状态 Get biochemical pool operation status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetABFTProcessStatusGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var productionLine = productionLine_example;  // string | 产线编号 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取生化池工艺运行状态 Get biochemical pool operation status
                List<AbftProcessStatusOutput> result = apiInstance.ApiIntelligentDenitrificationGetABFTProcessStatusGet(productionLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetABFTProcessStatusGet: " + e.Message );
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
 **productionLine** | **string**| 产线编号 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**List&lt;AbftProcessStatusOutput&gt;**](AbftProcessStatusOutput.md)

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

<a name="apiintelligentdenitrificationgetanoxicno3get"></a>
# **ApiIntelligentDenitrificationGetAnoxicNO3Get**
> SingleCodeDatasOutput ApiIntelligentDenitrificationGetAnoxicNO3Get (string productionLine = null, string startTime = null, string endTime = null)

获取缺氧区出水硝酸盐 Get anoxic zone effluent nitrate concentration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetAnoxicNO3GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var productionLine = productionLine_example;  // string | 产线编号 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取缺氧区出水硝酸盐 Get anoxic zone effluent nitrate concentration
                SingleCodeDatasOutput result = apiInstance.ApiIntelligentDenitrificationGetAnoxicNO3Get(productionLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetAnoxicNO3Get: " + e.Message );
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
 **productionLine** | **string**| 产线编号 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**SingleCodeDatasOutput**](SingleCodeDatasOutput.md)

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

<a name="apiintelligentdenitrificationgetassemblyconfigsget"></a>
# **ApiIntelligentDenitrificationGetAssemblyConfigsGet**
> List&lt;AssemblyConfigOutput&gt; ApiIntelligentDenitrificationGetAssemblyConfigsGet (int? displayTypeEnum = null, string productLine = null)

根据展示类别获取点位配置信息

根据展示类别获取点位配置信息

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetAssemblyConfigsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var displayTypeEnum = 56;  // int? | 展示枚举 (optional) 
            var productLine = productLine_example;  // string | 产线 (optional) 

            try
            {
                // 根据展示类别获取点位配置信息
                List<AssemblyConfigOutput> result = apiInstance.ApiIntelligentDenitrificationGetAssemblyConfigsGet(displayTypeEnum, productLine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetAssemblyConfigsGet: " + e.Message );
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
 **displayTypeEnum** | **int?**| 展示枚举 | [optional] 
 **productLine** | **string**| 产线 | [optional] 

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

<a name="apiintelligentdenitrificationgetcdadditionrateget"></a>
# **ApiIntelligentDenitrificationGetCDAdditionRateGet**
> CdAdditionRateOutput ApiIntelligentDenitrificationGetCDAdditionRateGet (string productionLine = null, string startTime = null, string endTime = null)

获取碳源投加速率 Get carbon source dosing rate data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetCDAdditionRateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var productionLine = productionLine_example;  // string | 产线编号 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取碳源投加速率 Get carbon source dosing rate data
                CdAdditionRateOutput result = apiInstance.ApiIntelligentDenitrificationGetCDAdditionRateGet(productionLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetCDAdditionRateGet: " + e.Message );
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
 **productionLine** | **string**| 产线编号 product line code | [optional] 
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

<a name="apiintelligentdenitrificationgetdenitrificationrateget"></a>
# **ApiIntelligentDenitrificationGetDenitrificationRateGet**
> SingleCodeDatasOutput ApiIntelligentDenitrificationGetDenitrificationRateGet (string productionLine = null, string startTime = null, string endTime = null)

获取反硝化速率 Get denitrification rate data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetDenitrificationRateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var productionLine = productionLine_example;  // string | 产线编号 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取反硝化速率 Get denitrification rate data
                SingleCodeDatasOutput result = apiInstance.ApiIntelligentDenitrificationGetDenitrificationRateGet(productionLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetDenitrificationRateGet: " + e.Message );
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
 **productionLine** | **string**| 产线编号 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**SingleCodeDatasOutput**](SingleCodeDatasOutput.md)

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

<a name="apiintelligentdenitrificationgetdosinglogget"></a>
# **ApiIntelligentDenitrificationGetDosingLogGet**
> DosingLogOutput ApiIntelligentDenitrificationGetDosingLogGet (int? category = null, string productionLine = null, string startTime = null, string endTime = null)

获取指定时间段内的加药报表 Get dosing logs of a certain period

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetDosingLogGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var category = 56;  // int? | 加药类型 dosage type (optional) 
            var productionLine = productionLine_example;  // string | 产线代码 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取指定时间段内的加药报表 Get dosing logs of a certain period
                DosingLogOutput result = apiInstance.ApiIntelligentDenitrificationGetDosingLogGet(category, productionLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetDosingLogGet: " + e.Message );
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
 **category** | **int?**| 加药类型 dosage type | [optional] 
 **productionLine** | **string**| 产线代码 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**DosingLogOutput**](DosingLogOutput.md)

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

<a name="apiintelligentdenitrificationgetdosingparameterget"></a>
# **ApiIntelligentDenitrificationGetDosingParameterGet**
> List&lt;DosingParameterOutput&gt; ApiIntelligentDenitrificationGetDosingParameterGet (int? category = null, string productionLineCode = null)

获取加药参数 Get dosing paramters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetDosingParameterGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var category = 56;  // int? | 加药类别 dosage type (optional) 
            var productionLineCode = productionLineCode_example;  // string | 产线编号 product line code (optional) 

            try
            {
                // 获取加药参数 Get dosing paramters
                List<DosingParameterOutput> result = apiInstance.ApiIntelligentDenitrificationGetDosingParameterGet(category, productionLineCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetDosingParameterGet: " + e.Message );
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
 **category** | **int?**| 加药类别 dosage type | [optional] 
 **productionLineCode** | **string**| 产线编号 product line code | [optional] 

### Return type

[**List&lt;DosingParameterOutput&gt;**](DosingParameterOutput.md)

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

<a name="apiintelligentdenitrificationgetdosingstatisticdailysget"></a>
# **ApiIntelligentDenitrificationGetDosingStatisticDailysGet**
> List&lt;DosingStatisticDailysOutput&gt; ApiIntelligentDenitrificationGetDosingStatisticDailysGet (int? category = null, string startTime = null, string endTime = null)

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
    public class ApiIntelligentDenitrificationGetDosingStatisticDailysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var category = 56;  // int? | 加药类型 dosage type (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 指定时间段内加药统计查询 Get dosing daily statistic results of a certain period
                List<DosingStatisticDailysOutput> result = apiInstance.ApiIntelligentDenitrificationGetDosingStatisticDailysGet(category, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetDosingStatisticDailysGet: " + e.Message );
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
 **category** | **int?**| 加药类型 dosage type | [optional] 
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

<a name="apiintelligentdenitrificationgetinletloadget"></a>
# **ApiIntelligentDenitrificationGetInletLoadGet**
> List&lt;InletLoadOutput&gt; ApiIntelligentDenitrificationGetInletLoadGet (string productionLine = null, string startTime = null, string endTime = null)

获取进水负荷 Get inlet water quality load data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetInletLoadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var productionLine = productionLine_example;  // string | 产线编号 product line code (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取进水负荷 Get inlet water quality load data
                List<InletLoadOutput> result = apiInstance.ApiIntelligentDenitrificationGetInletLoadGet(productionLine, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetInletLoadGet: " + e.Message );
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
 **productionLine** | **string**| 产线编号 product line code | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**List&lt;InletLoadOutput&gt;**](InletLoadOutput.md)

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

<a name="apiintelligentdenitrificationgetoutlettnget"></a>
# **ApiIntelligentDenitrificationGetOutletTNGet**
> OutletTnOutput ApiIntelligentDenitrificationGetOutletTNGet (string startTime = null, string endTime = null)

获取出水总氮 Get total effluent nitrogen concentration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationGetOutletTNGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 获取出水总氮 Get total effluent nitrogen concentration
                OutletTnOutput result = apiInstance.ApiIntelligentDenitrificationGetOutletTNGet(startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationGetOutletTNGet: " + e.Message );
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

[**OutletTnOutput**](OutletTnOutput.md)

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

<a name="apiintelligentdenitrificationsavedosingparameterpost"></a>
# **ApiIntelligentDenitrificationSaveDosingParameterPost**
> Object ApiIntelligentDenitrificationSaveDosingParameterPost (List<DosingParamSettingDto> dosingParamSettingDto = null)

保存加药参数 Save dosing parameters

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiIntelligentDenitrificationSaveDosingParameterPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new IntelligentDenitrificationApi(config);
            var dosingParamSettingDto = new List<DosingParamSettingDto>(); // List<DosingParamSettingDto> |  (optional) 

            try
            {
                // 保存加药参数 Save dosing parameters
                Object result = apiInstance.ApiIntelligentDenitrificationSaveDosingParameterPost(dosingParamSettingDto);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IntelligentDenitrificationApi.ApiIntelligentDenitrificationSaveDosingParameterPost: " + e.Message );
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

