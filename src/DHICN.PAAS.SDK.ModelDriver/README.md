## 污水业务服务

DHICN.PAAS.SDK.WWTP.MainBus是一个由DHI中国提供的专业的污水领域服务的.NET的Client SDK开发辅助包

### 使用示例
计算方案 run model
```csharp
using DHICN.PAAS.SDK.WWTP.MainBus.Api;
using DHICN.PAAS.SDK.WWTP.MainBus.Client;
using DHICN.PAAS.SDK.WWTP.MainBus.Model;

namespace Domain_PaaS_SDK_Examples_CSharp
{
    public class ModelDriverExample
    {
         /// <summary>
        /// 计算方案
        /// </summary>
        /// <returns></returns>
        public DHICN.PAAS.SDK.ModelDriver.Client.Result<ModelOperationResult> Example2()
        {
            #region 参数设置
            string Token = "xxxx";//如需试用，请联系DHI中国获取使用许可和认证信息
            string BasePath = "http://localhost";
            string tenantId = "xxxx-xxxx ";
            string group_id = "1082b4f3-a699-4bcd-a7c0-2525fef824dc";
            string new_scenario_name = "dotnet sdk测试新方案1";
            string parent_scenario_id = "171c59d2-d649-458e-9680-12001d9e49f0";
            string sub_type = "WWTPMLab";
            string description = "高氮负荷进水模拟方案";
            string startTime = "2023-05-10 16:56:00";
            string endTime = "2023-05-12 16:56:00";
            #endregion

            #region 参数构建
            DHICN.PAAS.SDK.ModelDriver.Client.Configuration configuration = new DHICN.PAAS.SDK.ModelDriver.Client.Configuration();
            configuration.AccessToken = Token;
            configuration.BasePath = BasePath;
            configuration.DefaultHeader.Add("tenantId", tenantId);
            configuration.DefaultHeader.Add("Authorization", Token);

            string scenarioId = "9fe4e1d0-d800-4946-9287-71e24630bda3";
            var modelInfoDic = new Dictionary<string, object>
            {
                { "scenarioId", scenarioId },
                { "tenantId", tenantId },
                { "type", 19 }
            };

            ScenarioModelMessageInput scenarioModelMessageInput = new ScenarioModelMessageInput();
            scenarioModelMessageInput.ProjectName = "bz";
            scenarioModelMessageInput.TenantId = Guid.Parse(tenantId);
            scenarioModelMessageInput.ScenarioId = Guid.Parse(scenarioId);
            scenarioModelMessageInput.ModelType = "WWTP";
            scenarioModelMessageInput.Priority = 0;
            scenarioModelMessageInput.ModelInfo = JsonConvert.SerializeObject(modelInfoDic);

            #endregion

            #region 服务调用
            ModelRunApi modelRunApi = new ModelRunApi(configuration);
            var response = modelRunApi.ModelRunRunModelPost(scenarioModelMessageInput);
            #endregion

            return response;
        }
    }
}
```
