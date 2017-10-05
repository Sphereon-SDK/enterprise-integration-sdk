package com.sphereon.sdk.eip.api;

import com.sphereon.sdk.eip.handler.ApiClient;
import com.sphereon.sdk.eip.model.DocumentPayload;
import com.sphereon.sdk.eip.model.ErrorResponse;
import java.io.File;
import com.sphereon.sdk.eip.model.IngestionResponse;
import org.junit.Before;
import org.junit.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for AllApi
 */
public class AllApiTest {

    private AllApi api;

    @Before
    public void setup() {
        api = new ApiClient().createService(AllApi.class);
    }

    
    /**
     * Get the status of the given document id
     *
     * 
     */
    @Test
    public void getDocumentStatusTest() {
        String documentId = null;
        // IngestionResponse response = api.getDocumentStatus(documentId);

        // TODO: test validations
    }
    
    /**
     * Push document to the ingestion queue
     *
     * 
     */
    @Test
    public void receiveDocumentTest() {
        String channelName = null;
        DocumentPayload documentPayload = null;
        String documentType = null;
        // IngestionResponse response = api.receiveDocument(channelName, documentPayload, documentType);

        // TODO: test validations
    }
    
    /**
     * Upload a file
     *
     * Upload an input image. Classification will not be started yet.
     */
    @Test
    public void uploadInputFileTest() {
        File stream = null;
        // DocumentPayload response = api.uploadInputFile(stream);

        // TODO: test validations
    }
    
}
