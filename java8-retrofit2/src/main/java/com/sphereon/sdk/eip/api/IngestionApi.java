package com.sphereon.sdk.eip.api;

import com.sphereon.sdk.eip.handler.CollectionFormats.*;



import retrofit2.Call;
import retrofit2.http.*;

import okhttp3.RequestBody;

import com.sphereon.sdk.eip.model.DocumentPayload;
import com.sphereon.sdk.eip.model.ErrorResponse;
import java.io.File;
import com.sphereon.sdk.eip.model.IngestionResponse;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


public interface IngestionApi {
  /**
   * Get the status of the given document id
   * 
   * @param documentId documentId (required)
   * @return Call&lt;IngestionResponse&gt;
   */
  @Headers({
    "Content-Type:application/json"
  })
  @GET("integration/0.1/ingestion/{documentId}")
  Call<IngestionResponse> getDocumentStatus(
    @retrofit2.http.Path("documentId") String documentId
  );

  /**
   * Push document to the ingestion queue
   * 
   * @param channelName channelName (required)
   * @param documentPayload documentPayload (required)
   * @param documentType documentType (optional)
   * @return Call&lt;IngestionResponse&gt;
   */
  @Headers({
    "Content-Type:application/json;charset&#x3D;UTF-8"
  })
  @PUT("integration/0.1/ingestion/{channelName}")
  Call<IngestionResponse> receiveDocument(
    @retrofit2.http.Path("channelName") String channelName, @retrofit2.http.Body DocumentPayload documentPayload, @retrofit2.http.Query("documentType") String documentType
  );

  /**
   * Upload a file
   * Upload an input image. Classification will not be started yet.
   * @param stream The document data to be ingested (required)
   * @return Call&lt;DocumentPayload&gt;
   */
  @retrofit2.http.Multipart
  @POST("integration/0.1/ingestion/")
  Call<DocumentPayload> uploadInputFile(
    @retrofit2.http.Part("stream\"; filename=\"stream") RequestBody stream
  );

}
