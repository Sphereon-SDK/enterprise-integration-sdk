# EnterpriseIntegrationApi.AllApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/enterprise-integration/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getDocumentStatus**](AllApi.md#getDocumentStatus) | **GET** /ingestion/documents/{documentId}/status | Get the status of the given document id
[**receiveDocument**](AllApi.md#receiveDocument) | **PUT** /ingestion/channels/{channelName} | Push document to the ingestion queue
[**resendDocument**](AllApi.md#resendDocument) | **PUT** /ingestion/documents/{documentId}/resend | Resend document with the given document id
[**uploadInputFile**](AllApi.md#uploadInputFile) | **POST** /ingestion/streams | Upload a file


<a name="getDocumentStatus"></a>
# **getDocumentStatus**
> IngestionResponse getDocumentStatus(documentId)

Get the status of the given document id

### Example
```javascript
var EnterpriseIntegrationApi = require('enterprise_integration_api');
var defaultClient = EnterpriseIntegrationApi.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

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

[oauth2schema](../README.md#oauth2schema)

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
var defaultClient = EnterpriseIntegrationApi.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

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

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="resendDocument"></a>
# **resendDocument**
> IngestionResponse resendDocument(documentId)

Resend document with the given document id

### Example
```javascript
var EnterpriseIntegrationApi = require('enterprise_integration_api');
var defaultClient = EnterpriseIntegrationApi.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new EnterpriseIntegrationApi.AllApi();

var documentId = "documentId_example"; // String | documentId


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.resendDocument(documentId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **documentId** | **String**| documentId | 

### Return type

[**IngestionResponse**](IngestionResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

<a name="uploadInputFile"></a>
# **uploadInputFile**
> DocumentPayload uploadInputFile(stream)

Upload a file

Upload an input image. Classification will not be started yet.

### Example
```javascript
var EnterpriseIntegrationApi = require('enterprise_integration_api');
var defaultClient = EnterpriseIntegrationApi.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

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

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json;charset=UTF-8

