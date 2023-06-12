## 污水业务服务

DHICN.PAAS.SDK.WWTP.MainBus是一个由DHI中国提供的专业的污水领域服务的.NET的Client SDK开发辅助包

### 使用示例
发送消息 send message
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHICN.PAAS.SDK.Message.Center.Api;
using DHICN.PAAS.SDK.Message.Center.Client;
using DHICN.PAAS.SDK.Message.Center.Model;

namespace Example
{
    public class ApiV1MessageTypeSendMessagePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new UserMessageCenterApi(config);
            var addUserMsg = new List<AddUserMsg>(); // List<AddUserMsg> |  (optional) 

            try
            {
                // 发送消息 send message
                Object result = apiInstance.ApiV1MessageTypeSendMessagePost(addUserMsg);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserMessageCenterApi.ApiV1MessageTypeSendMessagePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```
