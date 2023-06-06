# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.ImportExportApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiV2ConfigImportConfigExcelPost**](ImportExportApi.md#apiv2configimportconfigexcelpost) | **POST** /api/v2/config/import-config-excel | 导入业务服务配置文件Excel / Import config Excel


<a name="apiv2configimportconfigexcelpost"></a>
# **ApiV2ConfigImportConfigExcelPost**
> StringListResult ApiV2ConfigImportConfigExcelPost (System.IO.Stream excelFile = null)

导入业务服务配置文件Excel / Import config Excel

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2ConfigImportConfigExcelPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ImportExportApi(config);
            var excelFile = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // 导入业务服务配置文件Excel / Import config Excel
                StringListResult result = apiInstance.ApiV2ConfigImportConfigExcelPost(excelFile);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImportExportApi.ApiV2ConfigImportConfigExcelPost: " + e.Message );
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
 **excelFile** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**StringListResult**](StringListResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
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

