## 污水业务服务

DHICN.PAAS.SDK.WWTP.MainBus是一个由DHI中国提供的专业的污水领域服务的.NET的Client SDK开发辅助包

### 使用示例
增加组织机构  add organization
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.IdentityServiceSDK.Api;
using DHI.DSS.IdentityServiceSDK.Client;
using DHI.DSS.IdentityServiceSDK.Model;

namespace Example
{
    public class ApiV1OrganizationAddPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new OrganizationManangerApi(config);
            var addOrganizationInput = new AddOrganizationInput(); // AddOrganizationInput |  (optional) 

            try
            {
                // 增加组织机构 | add organization
                OrganizationEntity result = apiInstance.ApiV1OrganizationAddPost(addOrganizationInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationManangerApi.ApiV1OrganizationAddPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```
