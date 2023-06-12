## 结果分析服务

DHICN.PAAS.SDK.ResultAnalysis 是一个由DHI中国提供的专业的结果分析服务的.NET的Client SDK开发辅助包

### 使用示例
获取时间段内的二维动态结果 Get 2D dynamic results for a specified time range
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHICN.PAAS.SDK.ResultAnalysis.Api;
using DHICN.PAAS.SDK.ResultAnalysis.Client;
using DHICN.PAAS.SDK.ResultAnalysis.Model;

namespace Example
{
    public class ApiV1Result2dByRangeTimePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new M2DApi(config);
            var m2DByRangeTimeInput = new M2DByRangeTimeInput(); // M2DByRangeTimeInput |  (optional) 

            try
            {
                // 获取时间段内的二维动态结果 Get 2D dynamic results for a specified time range
                BaseDynamicOutput result = apiInstance.ApiV1Result2dByRangeTimePost(m2DByRangeTimeInput);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling M2DApi.ApiV1Result2dByRangeTimePost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```
