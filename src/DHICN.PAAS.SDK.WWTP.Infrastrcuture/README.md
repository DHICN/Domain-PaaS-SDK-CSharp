## 污水基础服务

DHICN.PAAS.SDK.WWTP.Infrastructure是一个由DHI中国提供的专业的污水基础服务的.NET的Client SDK开发辅助包

### 使用示例
添加报警配置信息 Add alarm config
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHI.DSS.WWTPPaasInfrastructureServiceSDK.Api;
using DHI.DSS.WWTPPaasInfrastructureServiceSDK.Client;
using DHI.DSS.WWTPPaasInfrastructureServiceSDK.Model;
namespace Example
{
    public class ApiAlarmAddAlarmConfigsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new AlarmApi(config);
            var alarmConfigInOut = new List<AlarmConfigInOut>(); // List<AlarmConfigInOut> |  (optional) 

            try
            {
                // 添加报警配置 Add alarm config
                Object result = apiInstance.ApiAlarmAddAlarmConfigsPost(alarmConfigInOut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlarmApi.ApiAlarmAddAlarmConfigsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}

```


