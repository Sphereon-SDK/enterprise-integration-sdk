# EnterpriseIntegrationApi.AllApi

All URIs are relative to *https://gw.api.cloud.sphereon.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getDocumentStatus**](AllApi.md#getDocumentStatus) | **GET** /integration/0.1/ingestion/{documentId} | Get the status of the given document id
[**receiveDocument**](AllApi.md#receiveDocument) | **PUT** /integration/0.1/ingestion/{channelName} | Push document to the ingestion queue
[**uploadInputFile**](AllApi.md#uploadInputFile) | **POST** /integration/0.1/ingestion/ | Upload a file


<a name="getDocumentStatus"></a>
# **getDocumentStatus**
> IngestionResponse getDocumentStatus(documentId)

Get the status of the given document id

### Example
```javascript
var EnterpriseIntegrationApi = require('enterprise_integration_api');

var apiInstance = new EnterpriseIntegrationApi.AllApi();

var documentId = "documentId_example"; // String | documentId


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDocumentStatus(documentId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **String**| documentId | 

### Return type

[**IngestionResponse**](IngestionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

<a name="receiveDocument"></a>
# **receiveDocument**
> IngestionResponse receiveDocument(channelName, documentPayload, opts)

Push document to the ingestion queue

### Example
```javascript
var EnterpriseIntegrationApi = require('enterprise_integration_api');

var apiInstance = new EnterpriseIntegrationApi.AllApi();

var channelName = "channelName_example"; // String | channelName

var documentPayload = new EnterpriseIntegrationApi.DocumentPayload(); // DocumentPayload | documentPayload

var opts = { 
  'documentType': "documentType_example" // String | documentType
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.receiveDocument(channelName, documentPayload, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **channelName** | **String**| channelName | 
 **documentPayload** | [**DocumentPayload**](DocumentPayload.md)| documentPayload | 
 **documentType** | **String**| documentType | [optional] 

### Return type

[**IngestionResponse**](IngestionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="uploadInputFile"></a>
# **uploadInputFile**
> DocumentPayload uploadInputFile(stream)

Upload a file

Upload an input image. Classification will not be started yet.

### Example
```javascript
var EnterpriseIntegrationApi = require('enterprise_integration_api');

var apiInstance = new EnterpriseIntegrationApi.AllApi();

var stream = "/path/to/file.txt"; // File | The document data to be ingested


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.uploadInputFile(stream, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **stream** | **File**| The document data to be ingested | 

### Return type

[**DocumentPayload**](DocumentPayload.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json;charset=UTF-8

