## 文档管理服务

DHICN.PAAS.SDK.DocumentManager 是一个由DHI中国提供的专业的文档管理服务的.NET的Client SDK开发辅助包

### 使用示例
添加文档 Add Document
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DHICN.PAAS.SDK.DocumentManager.Api;
using DHICN.PAAS.SDK.DocumentManager.Client;
using DHICN.PAAS.SDK.DocumentManager.Model;

namespace Example
{
    public class ApiGenericDocumentAddDocumentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DocumentApi(config);
            var addDocumentModel = new AddDocumentModel(); // AddDocumentModel |  (optional) 

            try
            {
                // /api/Generic/Document/AddDocument
                string result = apiInstance.ApiGenericDocumentAddDocumentPost(addDocumentModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DocumentApi.ApiGenericDocumentAddDocumentPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```
