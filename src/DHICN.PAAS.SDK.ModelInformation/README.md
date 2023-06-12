## 污水业务服务

DHICN.PAAS.SDK.WWTP.MainBus是一个由DHI中国提供的专业的污水领域服务的.NET的Client SDK开发辅助包

### 使用示例
删除方案的初始水位信息 Delete initial water level by scenario id
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHICN.PAAS.SDK.ModelInformation.Api;
using DHICN.PAAS.SDK.ModelInformation.Client;
using DHICN.PAAS.SDK.ModelInformation.Model;

namespace Example
{
    public class ApiV1ModelInformationInitialDataDeletePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InitialDataApi(config);
            var scenarioId = scenarioId_example;  // string | 方案ID scenario id (optional) 

            try
            {
                // 删除方案的初始水位信息 Delete initial water level by scenario id
                Object result = apiInstance.ApiV1ModelInformationInitialDataDeletePost(scenarioId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InitialDataApi.ApiV1ModelInformationInitialDataDeletePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```
