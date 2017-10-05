# eip-sdk-java8

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>com.sphereon.sdk</groupId>
    <artifactId>eip-sdk-java8</artifactId>
    <version>0.1.0</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "com.sphereon.sdk:eip-sdk-java8:0.1.0"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/eip-sdk-java8-0.1.0.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import com.sphereon.sdk.eip.handler.*;
import com.sphereon.sdk.eip.handler.auth.*;
import com.sphereon.sdk.eip.model.*;
import com.sphereon.sdk.eip.api.AllApi;

import java.io.File;
import java.util.*;

public class AllApiExample {

    public static void main(String[] args) {
        
        AllApi apiInstance = new AllApi();
        String documentId = "documentId_example"; // String | documentId
        try {
            IngestionResponse result = apiInstance.getDocumentStatus(documentId);
            System.out.println(result);
        } catch (ApiException e) {
            System.err.println("Exception when calling AllApi#getDocumentStatus");
            e.printStackTrace();
        }
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://gw.api.cloud.sphereon.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AllApi* | [**getDocumentStatus**](docs/AllApi.md#getDocumentStatus) | **GET** /integration/0.1/ingestion/{documentId} | Get the status of the given document id
*AllApi* | [**receiveDocument**](docs/AllApi.md#receiveDocument) | **PUT** /integration/0.1/ingestion/{channelName} | Push document to the ingestion queue
*AllApi* | [**uploadInputFile**](docs/AllApi.md#uploadInputFile) | **POST** /integration/0.1/ingestion/ | Upload a file
*IngestionApi* | [**getDocumentStatus**](docs/IngestionApi.md#getDocumentStatus) | **GET** /integration/0.1/ingestion/{documentId} | Get the status of the given document id
*IngestionApi* | [**receiveDocument**](docs/IngestionApi.md#receiveDocument) | **PUT** /integration/0.1/ingestion/{channelName} | Push document to the ingestion queue
*IngestionApi* | [**uploadInputFile**](docs/IngestionApi.md#uploadInputFile) | **POST** /integration/0.1/ingestion/ | Upload a file


## Documentation for Models

 - [DocumentDetails](docs/DocumentDetails.md)
 - [DocumentPayload](docs/DocumentPayload.md)
 - [Error](docs/Error.md)
 - [ErrorResponse](docs/ErrorResponse.md)
 - [IngestionResponse](docs/IngestionResponse.md)
 - [StreamLocation](docs/StreamLocation.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### oauth2schema

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - global: accessEverything


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

dev@sphereon.com

