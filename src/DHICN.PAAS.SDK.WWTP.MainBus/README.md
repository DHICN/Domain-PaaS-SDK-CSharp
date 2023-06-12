## 污水业务服务

DHICN.PAAS.SDK.WWTP.MainBus是一个由DHI中国提供的专业的污水领域服务的.NET的Client SDK开发辅助包

### 使用示例
获取全流程水质数据
```csharp
using DHICN.PAAS.SDK.WWTP.MainBus.Api;
using DHICN.PAAS.SDK.WWTP.MainBus.Client;
using DHICN.PAAS.SDK.WWTP.MainBus.Model;

namespace Domain_PaaS_SDK_Examples_CSharp
{
    public class GeneralDataExample
    {
        /// <summary>
        /// 获取全流程水质数据
        /// </summary>
        /// <returns></returns>
        public Result<List<EntireProcessWqOut>> GetEntireProcessTsByProductline()
        {
            string Token = "xxxx";//如需试用，请联系DHI中国获取使用许可和认证信息
            string BasePath = "http://localhost";
            string tenantId = "xxxx-xxxx ";

            Configuration configuration = new Configuration();
            configuration.AccessToken = Token;
            configuration.BasePath = BasePath;
            configuration.DefaultHeader.Add("tenantId", tenantId);
            configuration.DefaultHeader.Add("Authorization", Token);
            GeneralDataApi instance = new GeneralDataApi(configuration);
            string productLine = "1A";
            string startTime = "2023-05-10 16:56:00";
            string endTime = "2023-05-12 16:56:00";
            string modelName = "在线滚动模型";

            var response = instance.ApiV2OutputEntireProcessTsByProductlineGet(productLine, startTime, endTime, modelName);

            return response;
        }
    }
}
```
