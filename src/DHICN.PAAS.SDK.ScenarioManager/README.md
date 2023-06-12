## 污水业务服务

DHICN.PAAS.SDK.WWTP.MainBus是一个由DHI中国提供的专业的污水领域服务的.NET的Client SDK开发辅助包

### 使用示例
创建方案 create new scenario
```csharp
using DHICN.PAAS.SDK.ScenarioManager.Api;
using DHICN.PAAS.SDK.ScenarioManager.Client;
using DHICN.PAAS.SDK.ScenarioManager.Model;

namespace Domain_PaaS_SDK_Examples_CSharp
{
    public class ScenarioExample
    {
        /// <summary>
        /// 创建方案
        /// </summary>
        /// <returns></returns>
        public Result<DHICN.PAAS.SDK.ScenarioManager.Model.Scenario> Example1()
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
            Configuration configuration = new Configuration();
            configuration.AccessToken = Token;
            configuration.BasePath = BasePath;
            configuration.DefaultHeader.Add("tenantId", tenantId);
            configuration.DefaultHeader.Add("Authorization", Token);

            CreateScenarioByGroupPara2 param = new CreateScenarioByGroupPara2();
            param.Description = description;
            param.StartTime = DateTime.Parse(startTime);
            param.EndTime = DateTime.Parse(endTime);
            param.GroupId = group_id;
            param.NewScenarioName = new_scenario_name;
            param.ParentScenarioId = parent_scenario_id;
            param.SubType = sub_type;

            #endregion

            #region 服务调用
            ScenarioManagerApi scenarioManagerApi = new ScenarioManagerApi(configuration);
            var response = scenarioManagerApi.ApiV2ScenarioManagerScenarioDfsCreateByGroupPost("V2", param);
            #endregion

            return response;
        }
    }
}

```
