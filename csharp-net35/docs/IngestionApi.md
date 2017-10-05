# Sphereon.SDK.EIP.Api.IngestionApi

All URIs are relative to *https://gw.api.cloud.sphereon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDocumentStatus**](IngestionApi.md#getdocumentstatus) | **GET** /integration/0.1/ingestion/{documentId} | Get the status of the given document id
[**ReceiveDocument**](IngestionApi.md#receivedocument) | **PUT** /integration/0.1/ingestion/{channelName} | Push document to the ingestion queue
[**UploadInputFile**](IngestionApi.md#uploadinputfile) | **POST** /integration/0.1/ingestion/ | Upload a file


<a name="getdocumentstatus"></a>
# **GetDocumentStatus**
> IngestionResponse GetDocumentStatus (string documentId)

Get the status of the given document id

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.EIP.Api;
using Sphereon.SDK.EIP.Client;
using Sphereon.SDK.EIP.Model;

namespace Example
{
    public class GetDocumentStatusExample
    {
        public void main()
        {
            var apiInstance = new IngestionApi();
            var documentId = documentId_example;  // string | documentId

            try
            {
                // Get the status of the given document id
                IngestionResponse result = apiInstance.GetDocumentStatus(documentId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IngestionApi.GetDocumentStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **string**| documentId | 

### Return type

[**IngestionResponse**](IngestionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="receivedocument"></a>
# **ReceiveDocument**
> IngestionResponse ReceiveDocument (string channelName, DocumentPayload documentPayload, string documentType = null)

Push document to the ingestion queue

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.EIP.Api;
using Sphereon.SDK.EIP.Client;
using Sphereon.SDK.EIP.Model;

namespace Example
{
    public class ReceiveDocumentExample
    {
        public void main()
        {
            var apiInstance = new IngestionApi();
            var channelName = channelName_example;  // string | channelName
            var documentPayload = new DocumentPayload(); // DocumentPayload | documentPayload
            var documentType = documentType_example;  // string | documentType (optional) 

            try
            {
                // Push document to the ingestion queue
                IngestionResponse result = apiInstance.ReceiveDocument(channelName, documentPayload, documentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IngestionApi.ReceiveDocument: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelName** | **string**| channelName | 
 **documentPayload** | [**DocumentPayload**](DocumentPayload.md)| documentPayload | 
 **documentType** | **string**| documentType | [optional] 

### Return type

[**IngestionResponse**](IngestionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadinputfile"></a>
# **UploadInputFile**
> DocumentPayload UploadInputFile (System.IO.Stream stream)

Upload a file

Upload an input image. Classification will not be started yet.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.EIP.Api;
using Sphereon.SDK.EIP.Client;
using Sphereon.SDK.EIP.Model;

namespace Example
{
    public class UploadInputFileExample
    {
        public void main()
        {
            var apiInstance = new IngestionApi();
            var stream = new System.IO.Stream(); // System.IO.Stream | The document data to be ingested

            try
            {
                // Upload a file
                DocumentPayload result = apiInstance.UploadInputFile(stream);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IngestionApi.UploadInputFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stream** | **System.IO.Stream**| The document data to be ingested | 

### Return type

[**DocumentPayload**](DocumentPayload.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

