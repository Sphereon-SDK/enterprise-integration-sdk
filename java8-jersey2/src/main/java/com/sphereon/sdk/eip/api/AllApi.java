package com.sphereon.sdk.eip.api;

import com.sphereon.sdk.eip.handler.ApiException;
import com.sphereon.sdk.eip.handler.ApiClient;
import com.sphereon.sdk.eip.handler.Configuration;
import com.sphereon.sdk.eip.handler.Pair;

import javax.ws.rs.core.GenericType;

import com.sphereon.sdk.eip.model.DocumentPayload;
import com.sphereon.sdk.eip.model.ErrorResponse;
import java.io.File;
import com.sphereon.sdk.eip.model.IngestionResponse;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-10-05T11:35:42.383+02:00")
public class AllApi {
  private ApiClient apiClient;

  public AllApi() {
    this(Configuration.getDefaultApiClient());
  }

  public AllApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  /**
   * Get the status of the given document id
   * 
   * @param documentId documentId (required)
   * @return IngestionResponse
   * @throws ApiException if fails to make API call
   */
  public IngestionResponse getDocumentStatus(String documentId) throws ApiException {
    Object localVarPostBody = null;
    
    // verify the required parameter 'documentId' is set
    if (documentId == null) {
      throw new ApiException(400, "Missing the required parameter 'documentId' when calling getDocumentStatus");
    }
    
    // create path and map variables
    String localVarPath = "/integration/0.1/ingestion/{documentId}"
      .replaceAll("\\{" + "documentId" + "\\}", apiClient.escapeString(documentId.toString()));

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    
    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    GenericType<IngestionResponse> localVarReturnType = new GenericType<IngestionResponse>() {};
    return apiClient.invokeAPI(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
  /**
   * Push document to the ingestion queue
   * 
   * @param channelName channelName (required)
   * @param documentPayload documentPayload (required)
   * @param documentType documentType (optional)
   * @return IngestionResponse
   * @throws ApiException if fails to make API call
   */
  public IngestionResponse receiveDocument(String channelName, DocumentPayload documentPayload, String documentType) throws ApiException {
    Object localVarPostBody = documentPayload;
    
    // verify the required parameter 'channelName' is set
    if (channelName == null) {
      throw new ApiException(400, "Missing the required parameter 'channelName' when calling receiveDocument");
    }
    
    // verify the required parameter 'documentPayload' is set
    if (documentPayload == null) {
      throw new ApiException(400, "Missing the required parameter 'documentPayload' when calling receiveDocument");
    }
    
    // create path and map variables
    String localVarPath = "/integration/0.1/ingestion/{channelName}"
      .replaceAll("\\{" + "channelName" + "\\}", apiClient.escapeString(channelName.toString()));

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();

    localVarQueryParams.addAll(apiClient.parameterToPairs("", "documentType", documentType));

    
    
    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json;charset=UTF-8"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    GenericType<IngestionResponse> localVarReturnType = new GenericType<IngestionResponse>() {};
    return apiClient.invokeAPI(localVarPath, "PUT", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
  /**
   * Upload a file
   * Upload an input image. Classification will not be started yet.
   * @param stream The document data to be ingested (required)
   * @return DocumentPayload
   * @throws ApiException if fails to make API call
   */
  public DocumentPayload uploadInputFile(File stream) throws ApiException {
    Object localVarPostBody = null;
    
    // verify the required parameter 'stream' is set
    if (stream == null) {
      throw new ApiException(400, "Missing the required parameter 'stream' when calling uploadInputFile");
    }
    
    // create path and map variables
    String localVarPath = "/integration/0.1/ingestion/";

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    if (stream != null)
      localVarFormParams.put("stream", stream);

    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "multipart/form-data"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] {  };

    GenericType<DocumentPayload> localVarReturnType = new GenericType<DocumentPayload>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
}
