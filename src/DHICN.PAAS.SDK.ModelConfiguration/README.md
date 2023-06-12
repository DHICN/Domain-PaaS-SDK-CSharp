## 污水业务服务

DHICN.PAAS.SDK.WWTP.MainBus是一个由DHI中国提供的专业的污水领域服务的.NET的Client SDK开发辅助包

### 使用示例
创建一个新项目 Create a new project
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHICN.PAAS.SDK.ModelConfiguration.Api;
using DHICN.PAAS.SDK.ModelConfiguration.Client;
using DHICN.PAAS.SDK.ModelConfiguration.Model;

namespace Example
{
    public class ApiV2ModelConfigurationInitCreateProjectPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new InitProjectApi(config);
            var createProjectGenericInput = new CreateProjectGenericInput(); // CreateProjectGenericInput |  (optional) 

            try
            {
                // 创建一个新项目 Create a new project
                CreateProjectOutput result = apiInstance.ApiV2ModelConfigurationInitCreateProjectPost(createProjectGenericInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InitProjectApi.ApiV2ModelConfigurationInitCreateProjectPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```
