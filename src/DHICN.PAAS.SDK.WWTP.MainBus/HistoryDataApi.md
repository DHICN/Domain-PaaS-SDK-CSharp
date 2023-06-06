# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.HistoryDataApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2HistoryDataExportPost**](HistoryDataApi.md#apiv2historydataexportpost) | **POST** /api/v2/history-data/export | 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file
[**ApiV2HistoryDataGetByConditionPost**](HistoryDataApi.md#apiv2historydatagetbyconditionpost) | **POST** /api/v2/history-data/get-by-condition | 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes
[**ApiV2HistoryDataSelectItemsGet**](HistoryDataApi.md#apiv2historydataselectitemsget) | **GET** /api/v2/history-data/select-items | 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end


<a name="apiv2historydataexportpost"></a>
# **ApiV2HistoryDataExportPost**
> void ApiV2HistoryDataExportPost (QueryByConditionInput queryByConditionInput = null)

导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2HistoryDataExportPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new HistoryDataApi(config);
            var queryByConditionInput = new QueryByConditionInput(); // QueryByConditionInput |  (optional) 

            try
            {
                // 导出清洗后的在线数据，模拟结果数据 Export processed online data or model result data as an excel file
                apiInstance.ApiV2HistoryDataExportPost(queryByConditionInput);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryDataApi.ApiV2HistoryDataExportPost: " + e.Message );
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
 **queryByConditionInput** | [**QueryByConditionInput**](QueryByConditionInput.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
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

<a name="apiv2historydatagetbyconditionpost"></a>
# **ApiV2HistoryDataGetByConditionPost**
> List&lt;TsDataOutput&gt; ApiV2HistoryDataGetByConditionPost (QueryByConditionInput queryByConditionInput = null)

根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2HistoryDataGetByConditionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new HistoryDataApi(config);
            var queryByConditionInput = new QueryByConditionInput(); // QueryByConditionInput |  (optional) 

            try
            {
                // 根据时间段和点位代码查询清洗后的在线数据和模拟结果数据 Get processed online data or model result data by time and codes
                List<TsDataOutput> result = apiInstance.ApiV2HistoryDataGetByConditionPost(queryByConditionInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryDataApi.ApiV2HistoryDataGetByConditionPost: " + e.Message );
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
 **queryByConditionInput** | [**QueryByConditionInput**](QueryByConditionInput.md)|  | [optional] 

### Return type

[**List&lt;TsDataOutput&gt;**](TsDataOutput.md)

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

<a name="apiv2historydataselectitemsget"></a>
# **ApiV2HistoryDataSelectItemsGet**
> List&lt;SelectItemNode&gt; ApiV2HistoryDataSelectItemsGet (string modelName = null)

获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2HistoryDataSelectItemsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new HistoryDataApi(config);
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 

            try
            {
                // 获取指标查询的可选择项的具体信息 Get all the historical data indicators for selection on the front end
                List<SelectItemNode> result = apiInstance.ApiV2HistoryDataSelectItemsGet(modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HistoryDataApi.ApiV2HistoryDataSelectItemsGet: " + e.Message );
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
 **modelName** | **string**| 模板模型名称 template model name | [optional] 

### Return type

[**List&lt;SelectItemNode&gt;**](SelectItemNode.md)

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

