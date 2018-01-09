# AllApi

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
```java
// Import classes:
//import com.sphereon.sdk.eip.handler.ApiClient;
//import com.sphereon.sdk.eip.handler.ApiException;
//import com.sphereon.sdk.eip.handler.Configuration;
//import com.sphereon.sdk.eip.handler.auth.*;
//import com.sphereon.sdk.eip.api.AllApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

AllApi apiInstance = new AllApi();
String documentId = "documentId_example"; // String | documentId
try {
    IngestionResponse result = apiInstance.getDocumentStatus(documentId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AllApi#getDocumentStatus");
    e.printStackTrace();
}
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
> IngestionResponse receiveDocument(channelName, documentPayload, documentType)

Push document to the ingestion queue

### Example
```java
// Import classes:
//import com.sphereon.sdk.eip.handler.ApiClient;
//import com.sphereon.sdk.eip.handler.ApiException;
//import com.sphereon.sdk.eip.handler.Configuration;
//import com.sphereon.sdk.eip.handler.auth.*;
//import com.sphereon.sdk.eip.api.AllApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

AllApi apiInstance = new AllApi();
String channelName = "channelName_example"; // String | channelName
DocumentPayload documentPayload = new DocumentPayload(); // DocumentPayload | documentPayload
String documentType = "documentType_example"; // String | documentType
try {
    IngestionResponse result = apiInstance.receiveDocument(channelName, documentPayload, documentType);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AllApi#receiveDocument");
    e.printStackTrace();
}
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
```java
// Import classes:
//import com.sphereon.sdk.eip.handler.ApiClient;
//import com.sphereon.sdk.eip.handler.ApiException;
//import com.sphereon.sdk.eip.handler.Configuration;
//import com.sphereon.sdk.eip.handler.auth.*;
//import com.sphereon.sdk.eip.api.AllApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

AllApi apiInstance = new AllApi();
String documentId = "documentId_example"; // String | documentId
try {
    IngestionResponse result = apiInstance.resendDocument(documentId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AllApi#resendDocument");
    e.printStackTrace();
}
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
```java
// Import classes:
//import com.sphereon.sdk.eip.handler.ApiClient;
//import com.sphereon.sdk.eip.handler.ApiException;
//import com.sphereon.sdk.eip.handler.Configuration;
//import com.sphereon.sdk.eip.handler.auth.*;
//import com.sphereon.sdk.eip.api.AllApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

AllApi apiInstance = new AllApi();
File stream = new File("/path/to/file.txt"); // File | The document data to be ingested
try {
    DocumentPayload result = apiInstance.uploadInputFile(stream);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AllApi#uploadInputFile");
    e.printStackTrace();
}
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

