# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.ToxicityMonitorApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2OutputToxicAlarmsGet**](ToxicityMonitorApi.md#apiv2outputtoxicalarmsget) | **GET** /api/v2/output/toxic-alarms | 首页预警信息 Get toxicity alarm data
[**ApiV2ToxicityMonitorAlarmHistoryPost**](ToxicityMonitorApi.md#apiv2toxicitymonitoralarmhistorypost) | **POST** /api/v2/toxicity-monitor/alarm-history | 获取预警记录 Get historical toxicity alarm records
[**ApiV2ToxicityMonitorControlHistoryPost**](ToxicityMonitorApi.md#apiv2toxicitymonitorcontrolhistorypost) | **POST** /api/v2/toxicity-monitor/control-history | 获取质控记录 Get historical quality control records
[**ApiV2ToxicityMonitorMonitorHistoryPost**](ToxicityMonitorApi.md#apiv2toxicitymonitormonitorhistorypost) | **POST** /api/v2/toxicity-monitor/monitor-history | 获取毒性监测记录 Get historical toxicity monitoring records
[**ApiV2ToxicityMonitorRealTimeGet**](ToxicityMonitorApi.md#apiv2toxicitymonitorrealtimeget) | **GET** /api/v2/toxicity-monitor/real-time | 实时水质毒性和实时生物抑制率 Get real time water toxicity and biological inhibition rate


<a name="apiv2outputtoxicalarmsget"></a>
# **ApiV2OutputToxicAlarmsGet**
> List&lt;ToxicAlarmsOutput&gt; ApiV2OutputToxicAlarmsGet (string startTime = null, string endTime = null)

首页预警信息 Get toxicity alarm data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2OutputToxicAlarmsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ToxicityMonitorApi(config);
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 首页预警信息 Get toxicity alarm data
                List<ToxicAlarmsOutput> result = apiInstance.ApiV2OutputToxicAlarmsGet(startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToxicityMonitorApi.ApiV2OutputToxicAlarmsGet: " + e.Message );
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

[**List&lt;ToxicAlarmsOutput&gt;**](ToxicAlarmsOutput.md)

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

<a name="apiv2toxicitymonitoralarmhistorypost"></a>
# **ApiV2ToxicityMonitorAlarmHistoryPost**
> ToxicityOutput ApiV2ToxicityMonitorAlarmHistoryPost (ToxicityInput toxicityInput = null)

获取预警记录 Get historical toxicity alarm records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2ToxicityMonitorAlarmHistoryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ToxicityMonitorApi(config);
            var toxicityInput = new ToxicityInput(); // ToxicityInput |  (optional) 

            try
            {
                // 获取预警记录 Get historical toxicity alarm records
                ToxicityOutput result = apiInstance.ApiV2ToxicityMonitorAlarmHistoryPost(toxicityInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToxicityMonitorApi.ApiV2ToxicityMonitorAlarmHistoryPost: " + e.Message );
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
 **toxicityInput** | [**ToxicityInput**](ToxicityInput.md)|  | [optional] 

### Return type

[**ToxicityOutput**](ToxicityOutput.md)

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

<a name="apiv2toxicitymonitorcontrolhistorypost"></a>
# **ApiV2ToxicityMonitorControlHistoryPost**
> ToxicityOutput ApiV2ToxicityMonitorControlHistoryPost (ToxicityInput toxicityInput = null)

获取质控记录 Get historical quality control records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2ToxicityMonitorControlHistoryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ToxicityMonitorApi(config);
            var toxicityInput = new ToxicityInput(); // ToxicityInput |  (optional) 

            try
            {
                // 获取质控记录 Get historical quality control records
                ToxicityOutput result = apiInstance.ApiV2ToxicityMonitorControlHistoryPost(toxicityInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToxicityMonitorApi.ApiV2ToxicityMonitorControlHistoryPost: " + e.Message );
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
 **toxicityInput** | [**ToxicityInput**](ToxicityInput.md)|  | [optional] 

### Return type

[**ToxicityOutput**](ToxicityOutput.md)

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

<a name="apiv2toxicitymonitormonitorhistorypost"></a>
# **ApiV2ToxicityMonitorMonitorHistoryPost**
> ToxicityOutput ApiV2ToxicityMonitorMonitorHistoryPost (ToxicityInput toxicityInput = null)

获取毒性监测记录 Get historical toxicity monitoring records

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2ToxicityMonitorMonitorHistoryPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ToxicityMonitorApi(config);
            var toxicityInput = new ToxicityInput(); // ToxicityInput |  (optional) 

            try
            {
                // 获取毒性监测记录 Get historical toxicity monitoring records
                ToxicityOutput result = apiInstance.ApiV2ToxicityMonitorMonitorHistoryPost(toxicityInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToxicityMonitorApi.ApiV2ToxicityMonitorMonitorHistoryPost: " + e.Message );
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
 **toxicityInput** | [**ToxicityInput**](ToxicityInput.md)|  | [optional] 

### Return type

[**ToxicityOutput**](ToxicityOutput.md)

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

<a name="apiv2toxicitymonitorrealtimeget"></a>
# **ApiV2ToxicityMonitorRealTimeGet**
> List&lt;RealTimeOutput&gt; ApiV2ToxicityMonitorRealTimeGet ()

实时水质毒性和实时生物抑制率 Get real time water toxicity and biological inhibition rate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2ToxicityMonitorRealTimeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ToxicityMonitorApi(config);

            try
            {
                // 实时水质毒性和实时生物抑制率 Get real time water toxicity and biological inhibition rate
                List<RealTimeOutput> result = apiInstance.ApiV2ToxicityMonitorRealTimeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ToxicityMonitorApi.ApiV2ToxicityMonitorRealTimeGet: " + e.Message );
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

[**List&lt;RealTimeOutput&gt;**](RealTimeOutput.md)

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

