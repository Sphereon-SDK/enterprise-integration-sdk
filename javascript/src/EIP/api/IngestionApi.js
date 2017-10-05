/**
 * Enterprise Integration API
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.2.3
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['EIP/ApiClient', 'EIP/model/DocumentPayload', 'EIP/model/ErrorResponse', 'EIP/model/IngestionResponse'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/DocumentPayload'), require('../model/ErrorResponse'), require('../model/IngestionResponse'));
  } else {
    // Browser globals (root is window)
    if (!root.EnterpriseIntegrationApi) {
      root.EnterpriseIntegrationApi = {};
    }
    root.EnterpriseIntegrationApi.IngestionApi = factory(root.EnterpriseIntegrationApi.ApiClient, root.EnterpriseIntegrationApi.DocumentPayload, root.EnterpriseIntegrationApi.ErrorResponse, root.EnterpriseIntegrationApi.IngestionResponse);
  }
}(this, function(ApiClient, DocumentPayload, ErrorResponse, IngestionResponse) {
  'use strict';

  /**
   * Ingestion service.
   * @module EIP/api/IngestionApi
   * @version 0.1
   */

  /**
   * Constructs a new IngestionApi. 
   * @alias module:EIP/api/IngestionApi
   * @class
   * @param {module:EIP/ApiClient} apiClient Optional API client implementation to use,
   * default to {@link module:EIP/ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the getDocumentStatus operation.
     * @callback module:EIP/api/IngestionApi~getDocumentStatusCallback
     * @param {String} error Error message, if any.
     * @param {module:EIP/model/IngestionResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get the status of the given document id
     * @param {String} documentId documentId
     * @param {module:EIP/api/IngestionApi~getDocumentStatusCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:EIP/model/IngestionResponse}
     */
    this.getDocumentStatus = function(documentId, callback) {
      var postBody = null;

      // verify the required parameter 'documentId' is set
      if (documentId === undefined || documentId === null) {
        throw new Error("Missing the required parameter 'documentId' when calling getDocumentStatus");
      }


      var pathParams = {
        'documentId': documentId
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = IngestionResponse;

      return this.apiClient.callApi(
        '/integration/0.1/ingestion/{documentId}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the receiveDocument operation.
     * @callback module:EIP/api/IngestionApi~receiveDocumentCallback
     * @param {String} error Error message, if any.
     * @param {module:EIP/model/IngestionResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Push document to the ingestion queue
     * @param {String} channelName channelName
     * @param {module:EIP/model/DocumentPayload} documentPayload documentPayload
     * @param {Object} opts Optional parameters
     * @param {String} opts.documentType documentType
     * @param {module:EIP/api/IngestionApi~receiveDocumentCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:EIP/model/IngestionResponse}
     */
    this.receiveDocument = function(channelName, documentPayload, opts, callback) {
      opts = opts || {};
      var postBody = documentPayload;

      // verify the required parameter 'channelName' is set
      if (channelName === undefined || channelName === null) {
        throw new Error("Missing the required parameter 'channelName' when calling receiveDocument");
      }

      // verify the required parameter 'documentPayload' is set
      if (documentPayload === undefined || documentPayload === null) {
        throw new Error("Missing the required parameter 'documentPayload' when calling receiveDocument");
      }


      var pathParams = {
        'channelName': channelName
      };
      var queryParams = {
        'documentType': opts['documentType']
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json;charset=UTF-8'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = IngestionResponse;

      return this.apiClient.callApi(
        '/integration/0.1/ingestion/{channelName}', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the uploadInputFile operation.
     * @callback module:EIP/api/IngestionApi~uploadInputFileCallback
     * @param {String} error Error message, if any.
     * @param {module:EIP/model/DocumentPayload} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Upload a file
     * Upload an input image. Classification will not be started yet.
     * @param {File} stream The document data to be ingested
     * @param {module:EIP/api/IngestionApi~uploadInputFileCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:EIP/model/DocumentPayload}
     */
    this.uploadInputFile = function(stream, callback) {
      var postBody = null;

      // verify the required parameter 'stream' is set
      if (stream === undefined || stream === null) {
        throw new Error("Missing the required parameter 'stream' when calling uploadInputFile");
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
        'stream': stream
      };

      var authNames = [];
      var contentTypes = ['multipart/form-data'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = DocumentPayload;

      return this.apiClient.callApi(
        '/integration/0.1/ingestion/', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
