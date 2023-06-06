# DHI.DSS.WWTPPaasMainBusServiceSDK.Api.ProNumSimLabApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiProNumSimLabSimResultsGet**](ProNumSimLabApi.md#apipronumsimlabsimresultsget) | **GET** /api/ProNumSimLab/SimResults | 获取方案的出水水质结果数据 Get outlet water quality time-series result of a scenario
[**ApiV2ConfigBiochemicaltanksGet**](ProNumSimLabApi.md#apiv2configbiochemicaltanksget) | **GET** /api/v2/config/biochemicaltanks | 生化池查询 Get biochemical pool config data
[**ApiV2SimulationLabCompareControlParamPost**](ProNumSimLabApi.md#apiv2simulationlabcomparecontrolparampost) | **POST** /api/v2/simulation-lab/compare/control-param | 多方案控制参数对比 Get several scenarios&#39; control paramters for comparison
[**ApiV2SimulationLabResultIndicatorStatisticGet**](ProNumSimLabApi.md#apiv2simulationlabresultindicatorstatisticget) | **GET** /api/v2/simulation-lab/result/indicator-statistic | 单个工艺线单个生化池指标统计查询 Get scenario&#39;s statistic result of all the indicators on a certain biochemical pool of a specified product line
[**ApiV2SimulationLabResultTsByProductlineGet**](ProNumSimLabApi.md#apiv2simulationlabresulttsbyproductlineget) | **GET** /api/v2/simulation-lab/result/ts-by-productline | 单个工艺线水质全流程查询 Get scenario&#39;s water quality entire process result data of a certain product line
[**ApiV2SimulationLabScenarioDeletePost**](ProNumSimLabApi.md#apiv2simulationlabscenariodeletepost) | **POST** /api/v2/simulation-lab/scenario/delete | 根据ID删除方案，同时删除方案相关的设置数据 Delete scenario as well as its corresponding setting data by scenario ids
[**ApiV2SimulationLabScenarioInletDataGet**](ProNumSimLabApi.md#apiv2simulationlabscenarioinletdataget) | **GET** /api/v2/simulation-lab/scenario/inlet-data | 查询方案进水数据 Get scenario&#39;s inlet time-series data
[**ApiV2SimulationLabScenarioInletDataSavePost**](ProNumSimLabApi.md#apiv2simulationlabscenarioinletdatasavepost) | **POST** /api/v2/simulation-lab/scenario/inlet-data/save | 保存进水数据到方案（入数据库） Save inlet time-series data of a scenario in database
[**ApiV2SimulationLabScenarioInletDataTemplateDownloadPost**](ProNumSimLabApi.md#apiv2simulationlabscenarioinletdatatemplatedownloadpost) | **POST** /api/v2/simulation-lab/scenario/inlet-data-template/download | 进水点文件模板下载 Download the inlet time-series data excel file template.
[**ApiV2SimulationLabScenarioInletDataTemplateUploadPost**](ProNumSimLabApi.md#apiv2simulationlabscenarioinletdatatemplateuploadpost) | **POST** /api/v2/simulation-lab/scenario/inlet-data-template/upload | 进水点数据文件excel上传 Upload inlet time-series data in an excel file
[**ApiV2SimulationLabScenarioInletScadaGet**](ProNumSimLabApi.md#apiv2simulationlabscenarioinletscadaget) | **GET** /api/v2/simulation-lab/scenario/inlet/scada | 查询SCADA数据 Get inlet time-series data from SCADA
[**ApiV2SimulationLabScenarioParamGet**](ProNumSimLabApi.md#apiv2simulationlabscenarioparamget) | **GET** /api/v2/simulation-lab/scenario/param | 查询方案参数设置 Get scenario&#39;s parameter setting data
[**ApiV2SimulationLabScenarioParamSavePost**](ProNumSimLabApi.md#apiv2simulationlabscenarioparamsavepost) | **POST** /api/v2/simulation-lab/scenario/param/save | 保存方案参数设置 Save scenario&#39;s parameter setting data
[**ApiV2SimulationLabScenarioResultSettingGet**](ProNumSimLabApi.md#apiv2simulationlabscenarioresultsettingget) | **GET** /api/v2/simulation-lab/scenario/result-setting | 查询方案结果配置 Get scenario&#39;s result setting data
[**ApiV2SimulationLabScenarioResultSettingSavePost**](ProNumSimLabApi.md#apiv2simulationlabscenarioresultsettingsavepost) | **POST** /api/v2/simulation-lab/scenario/result-setting/save | 保存方案结果配置 Save scenario&#39;s result setting data
[**ApiV2SimulationLabScenarioScenariosForCompareGet**](ProNumSimLabApi.md#apiv2simulationlabscenarioscenariosforcompareget) | **GET** /api/v2/simulation-lab/scenario/scenarios-for-compare | 查询与指定方案的结果配置一样的方案列表 Get scenarios which can be compared with the specified scenario


<a name="apipronumsimlabsimresultsget"></a>
# **ApiProNumSimLabSimResultsGet**
> List&lt;SimResultsOutupt&gt; ApiProNumSimLabSimResultsGet (string scenarioId = null)

获取方案的出水水质结果数据 Get outlet water quality time-series result of a scenario

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiProNumSimLabSimResultsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 

            try
            {
                // 获取方案的出水水质结果数据 Get outlet water quality time-series result of a scenario
                List<SimResultsOutupt> result = apiInstance.ApiProNumSimLabSimResultsGet(scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiProNumSimLabSimResultsGet: " + e.Message );
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

### Return type

[**List&lt;SimResultsOutupt&gt;**](SimResultsOutupt.md)

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

<a name="apiv2configbiochemicaltanksget"></a>
# **ApiV2ConfigBiochemicaltanksGet**
> List&lt;QueryBiochemicaltanksOutput&gt; ApiV2ConfigBiochemicaltanksGet (string productLine = null, string modelName = null)

生化池查询 Get biochemical pool config data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2ConfigBiochemicaltanksGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var productLine = productLine_example;  // string | 工艺线代码 product line code (optional) 
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 

            try
            {
                // 生化池查询 Get biochemical pool config data
                List<QueryBiochemicaltanksOutput> result = apiInstance.ApiV2ConfigBiochemicaltanksGet(productLine, modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2ConfigBiochemicaltanksGet: " + e.Message );
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
 **modelName** | **string**| 模板模型名称 template model name | [optional] 

### Return type

[**List&lt;QueryBiochemicaltanksOutput&gt;**](QueryBiochemicaltanksOutput.md)

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

<a name="apiv2simulationlabcomparecontrolparampost"></a>
# **ApiV2SimulationLabCompareControlParamPost**
> List&lt;QueryControlParamCompareOutput&gt; ApiV2SimulationLabCompareControlParamPost (QueryControlParamCompareInput queryControlParamCompareInput = null)

多方案控制参数对比 Get several scenarios' control paramters for comparison

只有多个方案之间设置不同的参数才会返回 Only parameters with difference setting values among the scenarios will be returned

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabCompareControlParamPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var queryControlParamCompareInput = new QueryControlParamCompareInput(); // QueryControlParamCompareInput |  (optional) 

            try
            {
                // 多方案控制参数对比 Get several scenarios' control paramters for comparison
                List<QueryControlParamCompareOutput> result = apiInstance.ApiV2SimulationLabCompareControlParamPost(queryControlParamCompareInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabCompareControlParamPost: " + e.Message );
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
 **queryControlParamCompareInput** | [**QueryControlParamCompareInput**](QueryControlParamCompareInput.md)|  | [optional] 

### Return type

[**List&lt;QueryControlParamCompareOutput&gt;**](QueryControlParamCompareOutput.md)

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

<a name="apiv2simulationlabresultindicatorstatisticget"></a>
# **ApiV2SimulationLabResultIndicatorStatisticGet**
> List&lt;QueryIndicatorStatisticOutput&gt; ApiV2SimulationLabResultIndicatorStatisticGet (string scenarioId = null, string productLine = null, string tankNo = null, string modelName = null)

单个工艺线单个生化池指标统计查询 Get scenario's statistic result of all the indicators on a certain biochemical pool of a specified product line

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabResultIndicatorStatisticGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 
            var productLine = productLine_example;  // string | 工艺线代码 product line code (optional) 
            var tankNo = tankNo_example;  // string | 生化池序号 biochemical pool index (optional) 
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 

            try
            {
                // 单个工艺线单个生化池指标统计查询 Get scenario's statistic result of all the indicators on a certain biochemical pool of a specified product line
                List<QueryIndicatorStatisticOutput> result = apiInstance.ApiV2SimulationLabResultIndicatorStatisticGet(scenarioId, productLine, tankNo, modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabResultIndicatorStatisticGet: " + e.Message );
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
 **productLine** | **string**| 工艺线代码 product line code | [optional] 
 **tankNo** | **string**| 生化池序号 biochemical pool index | [optional] 
 **modelName** | **string**| 模板模型名称 template model name | [optional] 

### Return type

[**List&lt;QueryIndicatorStatisticOutput&gt;**](QueryIndicatorStatisticOutput.md)

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

<a name="apiv2simulationlabresulttsbyproductlineget"></a>
# **ApiV2SimulationLabResultTsByProductlineGet**
> List&lt;EntireProcessWqOut&gt; ApiV2SimulationLabResultTsByProductlineGet (string scenarioId = null, string productLine = null, string modelName = null)

单个工艺线水质全流程查询 Get scenario's water quality entire process result data of a certain product line

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabResultTsByProductlineGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 
            var productLine = productLine_example;  // string | 工艺线代码 product line code (optional) 
            var modelName = modelName_example;  // string | 模板模型名称 template model name (optional) 

            try
            {
                // 单个工艺线水质全流程查询 Get scenario's water quality entire process result data of a certain product line
                List<EntireProcessWqOut> result = apiInstance.ApiV2SimulationLabResultTsByProductlineGet(scenarioId, productLine, modelName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabResultTsByProductlineGet: " + e.Message );
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
 **productLine** | **string**| 工艺线代码 product line code | [optional] 
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

<a name="apiv2simulationlabscenariodeletepost"></a>
# **ApiV2SimulationLabScenarioDeletePost**
> Object ApiV2SimulationLabScenarioDeletePost (DeleteScenarioInput deleteScenarioInput = null)

根据ID删除方案，同时删除方案相关的设置数据 Delete scenario as well as its corresponding setting data by scenario ids

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioDeletePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var deleteScenarioInput = new DeleteScenarioInput(); // DeleteScenarioInput |  (optional) 

            try
            {
                // 根据ID删除方案，同时删除方案相关的设置数据 Delete scenario as well as its corresponding setting data by scenario ids
                Object result = apiInstance.ApiV2SimulationLabScenarioDeletePost(deleteScenarioInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioDeletePost: " + e.Message );
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
 **deleteScenarioInput** | [**DeleteScenarioInput**](DeleteScenarioInput.md)|  | [optional] 

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

<a name="apiv2simulationlabscenarioinletdataget"></a>
# **ApiV2SimulationLabScenarioInletDataGet**
> QueryInletDataOutput ApiV2SimulationLabScenarioInletDataGet (string scenarioId = null, string inlet = null)

查询方案进水数据 Get scenario's inlet time-series data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioInletDataGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 
            var inlet = inlet_example;  // string | 进水点 inlet (optional) 

            try
            {
                // 查询方案进水数据 Get scenario's inlet time-series data
                QueryInletDataOutput result = apiInstance.ApiV2SimulationLabScenarioInletDataGet(scenarioId, inlet);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioInletDataGet: " + e.Message );
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
 **inlet** | **string**| 进水点 inlet | [optional] 

### Return type

[**QueryInletDataOutput**](QueryInletDataOutput.md)

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

<a name="apiv2simulationlabscenarioinletdatasavepost"></a>
# **ApiV2SimulationLabScenarioInletDataSavePost**
> Object ApiV2SimulationLabScenarioInletDataSavePost (List<SaveInletDataInput> saveInletDataInput = null)

保存进水数据到方案（入数据库） Save inlet time-series data of a scenario in database

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioInletDataSavePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var saveInletDataInput = new List<SaveInletDataInput>(); // List<SaveInletDataInput> |  (optional) 

            try
            {
                // 保存进水数据到方案（入数据库） Save inlet time-series data of a scenario in database
                Object result = apiInstance.ApiV2SimulationLabScenarioInletDataSavePost(saveInletDataInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioInletDataSavePost: " + e.Message );
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
 **saveInletDataInput** | [**List&lt;SaveInletDataInput&gt;**](SaveInletDataInput.md)|  | [optional] 

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

<a name="apiv2simulationlabscenarioinletdatatemplatedownloadpost"></a>
# **ApiV2SimulationLabScenarioInletDataTemplateDownloadPost**
> void ApiV2SimulationLabScenarioInletDataTemplateDownloadPost ()

进水点文件模板下载 Download the inlet time-series data excel file template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioInletDataTemplateDownloadPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);

            try
            {
                // 进水点文件模板下载 Download the inlet time-series data excel file template.
                apiInstance.ApiV2SimulationLabScenarioInletDataTemplateDownloadPost();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioInletDataTemplateDownloadPost: " + e.Message );
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

<a name="apiv2simulationlabscenarioinletdatatemplateuploadpost"></a>
# **ApiV2SimulationLabScenarioInletDataTemplateUploadPost**
> List&lt;SaveInletDataInput&gt; ApiV2SimulationLabScenarioInletDataTemplateUploadPost (System.IO.Stream excel = null)

进水点数据文件excel上传 Upload inlet time-series data in an excel file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioInletDataTemplateUploadPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var excel = BINARY_DATA_HERE;  // System.IO.Stream |  (optional) 

            try
            {
                // 进水点数据文件excel上传 Upload inlet time-series data in an excel file
                List<SaveInletDataInput> result = apiInstance.ApiV2SimulationLabScenarioInletDataTemplateUploadPost(excel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioInletDataTemplateUploadPost: " + e.Message );
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
 **excel** | **System.IO.Stream****System.IO.Stream**|  | [optional] 

### Return type

[**List&lt;SaveInletDataInput&gt;**](SaveInletDataInput.md)

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

<a name="apiv2simulationlabscenarioinletscadaget"></a>
# **ApiV2SimulationLabScenarioInletScadaGet**
> QueryInletDataOutput ApiV2SimulationLabScenarioInletScadaGet (string inlet = null, string startTime = null, string endTime = null)

查询SCADA数据 Get inlet time-series data from SCADA

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioInletScadaGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var inlet = inlet_example;  // string | 进水点 inlet (optional) 
            var startTime = startTime_example;  // string | 开始时间 start time (optional) 
            var endTime = endTime_example;  // string | 结束时间 end time (optional) 

            try
            {
                // 查询SCADA数据 Get inlet time-series data from SCADA
                QueryInletDataOutput result = apiInstance.ApiV2SimulationLabScenarioInletScadaGet(inlet, startTime, endTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioInletScadaGet: " + e.Message );
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
 **inlet** | **string**| 进水点 inlet | [optional] 
 **startTime** | **string**| 开始时间 start time | [optional] 
 **endTime** | **string**| 结束时间 end time | [optional] 

### Return type

[**QueryInletDataOutput**](QueryInletDataOutput.md)

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

<a name="apiv2simulationlabscenarioparamget"></a>
# **ApiV2SimulationLabScenarioParamGet**
> List&lt;ModelParam&gt; ApiV2SimulationLabScenarioParamGet (string scenarioId = null, string productLine = null)

查询方案参数设置 Get scenario's parameter setting data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioParamGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 
            var productLine = productLine_example;  // string | 工艺线代码 product line code (optional) 

            try
            {
                // 查询方案参数设置 Get scenario's parameter setting data
                List<ModelParam> result = apiInstance.ApiV2SimulationLabScenarioParamGet(scenarioId, productLine);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioParamGet: " + e.Message );
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
 **productLine** | **string**| 工艺线代码 product line code | [optional] 

### Return type

[**List&lt;ModelParam&gt;**](ModelParam.md)

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

<a name="apiv2simulationlabscenarioparamsavepost"></a>
# **ApiV2SimulationLabScenarioParamSavePost**
> Object ApiV2SimulationLabScenarioParamSavePost (List<SaveParamInput> saveParamInput = null)

保存方案参数设置 Save scenario's parameter setting data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioParamSavePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var saveParamInput = new List<SaveParamInput>(); // List<SaveParamInput> |  (optional) 

            try
            {
                // 保存方案参数设置 Save scenario's parameter setting data
                Object result = apiInstance.ApiV2SimulationLabScenarioParamSavePost(saveParamInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioParamSavePost: " + e.Message );
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
 **saveParamInput** | [**List&lt;SaveParamInput&gt;**](SaveParamInput.md)|  | [optional] 

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

<a name="apiv2simulationlabscenarioresultsettingget"></a>
# **ApiV2SimulationLabScenarioResultSettingGet**
> ResultParam ApiV2SimulationLabScenarioResultSettingGet (string scenarioId = null)

查询方案结果配置 Get scenario's result setting data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioResultSettingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 

            try
            {
                // 查询方案结果配置 Get scenario's result setting data
                ResultParam result = apiInstance.ApiV2SimulationLabScenarioResultSettingGet(scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioResultSettingGet: " + e.Message );
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

### Return type

[**ResultParam**](ResultParam.md)

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

<a name="apiv2simulationlabscenarioresultsettingsavepost"></a>
# **ApiV2SimulationLabScenarioResultSettingSavePost**
> Object ApiV2SimulationLabScenarioResultSettingSavePost (ResultParam resultParam = null)

保存方案结果配置 Save scenario's result setting data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioResultSettingSavePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var resultParam = new ResultParam(); // ResultParam |  (optional) 

            try
            {
                // 保存方案结果配置 Save scenario's result setting data
                Object result = apiInstance.ApiV2SimulationLabScenarioResultSettingSavePost(resultParam);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioResultSettingSavePost: " + e.Message );
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
 **resultParam** | [**ResultParam**](ResultParam.md)|  | [optional] 

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

<a name="apiv2simulationlabscenarioscenariosforcompareget"></a>
# **ApiV2SimulationLabScenarioScenariosForCompareGet**
> List&lt;Guid&gt; ApiV2SimulationLabScenarioScenariosForCompareGet (string scenarioId = null)

查询与指定方案的结果配置一样的方案列表 Get scenarios which can be compared with the specified scenario

能够进行对比的方案需满足两个条件，分别是时间范围一致和结果配置一致 scenarios that can be compared must have consistent time period and result setting

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Api;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Client;
using DHI.DSS.WWTPPaasMainBusServiceSDK.Model;

namespace Example
{
    public class ApiV2SimulationLabScenarioScenariosForCompareGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ProNumSimLabApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 

            try
            {
                // 查询与指定方案的结果配置一样的方案列表 Get scenarios which can be compared with the specified scenario
                List<Guid> result = apiInstance.ApiV2SimulationLabScenarioScenariosForCompareGet(scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProNumSimLabApi.ApiV2SimulationLabScenarioScenariosForCompareGet: " + e.Message );
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

### Return type

**List<Guid>**

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

