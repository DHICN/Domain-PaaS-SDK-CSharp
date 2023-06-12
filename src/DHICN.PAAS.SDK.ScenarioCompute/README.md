## 污水业务服务

DHICN.PAAS.SDK.WWTP.MainBus是一个由DHI中国提供的专业的污水领域服务的.NET的Client SDK开发辅助包

### 使用示例
获取租户配置的预报数据
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHICN.PAAS.SDK.ScenarioCompute.Api;
using DHICN.PAAS.SDK.ScenarioCompute.Client;
using DHICN.PAAS.SDK.ScenarioCompute.Model;

namespace Example
{
    public class ApiAppConfigAutoForecastInfosGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new ConfigApi(config);
            var tenantIds = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 获取租户配置的预报数据
                List<DhiDssScenarioComputeDaprServicesDtosAutoForecastInfo> result = apiInstance.ApiAppConfigAutoForecastInfosGet(tenantIds);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ConfigApi.ApiAppConfigAutoForecastInfosGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```
