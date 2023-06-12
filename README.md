<h1 align="center"> Domain-PaaS-SDK for CSharp </h1>
<div align="center">

[![NuGet version (DocumentManager)](https://img.shields.io/nuget/v/DHICN.PAAS.SDK.DocumentManager.svg?style=flat-square)](https://www.nuget.org/packages/DHICN.PAAS.SDK.DocumentManager/)
  
这是一个[DHI 中国 业务中台](https://online-products.dhichina.cn/) 的 Client SDK 开发辅助包，帮您快速通过我们的业务中台构建应用。

</div>

## 🔆 功能清单

- [x] identity-service 用户认证管理服务
- [x] scenario-manager-service 方案管理服务
- [x] message-service 消息服务
- [x] document-service 文档服务
- [x] scenario-compute-service 方案计算服务
- [x] model-driver-service 模型计算服务
- [x] result-analysis-service 结果分析服务
- [x] model-information-service 模型分析服务
- [x] model-configuration-service 模型计算服务
- [ ] text-search-service 全文搜索服务
- [ ] device-management-service 资产设备服务
- [ ] accident-management-service 事故管理服务
- [ ] digital-twin-service 模型映射服务
- [ ] iot-service IoT 服务
- [x] wwtp-domain-main-bus-service 污水业务中台基础服务
- [x] wwtp-domain-infrastructure-service 污水业务中台邻域服务
- [ ] wd-domain-service 供水业务中台领域服务

## 适用平台
* Mac、Windows和Linux

## Installation



## 使用

需要先联系我们获取的 [DHI 中国 业务中台](https://online-products.dhichina.cn/) 使用许可和认证信息。

### 基础使用

```
string Token = "";
string BasePath = "";
string tenantId = "";

wwtp_paas_main_bus_service.Client.Configuration configuration = new wwtp_paas_main_bus_service.Client.Configuration();
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
Console.WriteLine(response.data[0].ToJson());
Console.ReadLine();
```
