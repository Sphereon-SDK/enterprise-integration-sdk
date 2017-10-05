/* 
 * Enterprise Integration API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Sphereon.SDK.EIP.Client;
using Sphereon.SDK.EIP.Model;

namespace Sphereon.SDK.EIP.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAllApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the status of the given document id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">documentId</param>
        /// <returns>IngestionResponse</returns>
        IngestionResponse GetDocumentStatus (string documentId);

        /// <summary>
        /// Get the status of the given document id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">documentId</param>
        /// <returns>ApiResponse of IngestionResponse</returns>
        ApiResponse<IngestionResponse> GetDocumentStatusWithHttpInfo (string documentId);
        /// <summary>
        /// Push document to the ingestion queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelName">channelName</param>
        /// <param name="documentPayload">documentPayload</param>
        /// <param name="documentType">documentType (optional)</param>
        /// <returns>IngestionResponse</returns>
        IngestionResponse ReceiveDocument (string channelName, DocumentPayload documentPayload, string documentType = null);

        /// <summary>
        /// Push document to the ingestion queue
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelName">channelName</param>
        /// <param name="documentPayload">documentPayload</param>
        /// <param name="documentType">documentType (optional)</param>
        /// <returns>ApiResponse of IngestionResponse</returns>
        ApiResponse<IngestionResponse> ReceiveDocumentWithHttpInfo (string channelName, DocumentPayload documentPayload, string documentType = null);
        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Upload an input image. Classification will not be started yet.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stream">The document data to be ingested</param>
        /// <returns>DocumentPayload</returns>
        DocumentPayload UploadInputFile (System.IO.Stream stream);

        /// <summary>
        /// Upload a file
        /// </summary>
        /// <remarks>
        /// Upload an input image. Classification will not be started yet.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stream">The document data to be ingested</param>
        /// <returns>ApiResponse of DocumentPayload</returns>
        ApiResponse<DocumentPayload> UploadInputFileWithHttpInfo (System.IO.Stream stream);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AllApi : IAllApi
    {
        private Sphereon.SDK.EIP.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AllApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AllApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Sphereon.SDK.EIP.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AllApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Sphereon.SDK.EIP.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Sphereon.SDK.EIP.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get the status of the given document id 
        /// </summary>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">documentId</param>
        /// <returns>IngestionResponse</returns>
        public IngestionResponse GetDocumentStatus (string documentId)
        {
             ApiResponse<IngestionResponse> localVarResponse = GetDocumentStatusWithHttpInfo(documentId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the status of the given document id 
        /// </summary>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="documentId">documentId</param>
        /// <returns>ApiResponse of IngestionResponse</returns>
        public ApiResponse< IngestionResponse > GetDocumentStatusWithHttpInfo (string documentId)
        {
            // verify the required parameter 'documentId' is set
            if (documentId == null)
                throw new ApiException(400, "Missing required parameter 'documentId' when calling AllApi->GetDocumentStatus");

            var localVarPath = "/integration/0.1/ingestion/{documentId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (documentId != null) localVarPathParams.Add("documentId", Configuration.ApiClient.ParameterToString(documentId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentStatus", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IngestionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IngestionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IngestionResponse)));
        }

        /// <summary>
        /// Push document to the ingestion queue 
        /// </summary>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelName">channelName</param>
        /// <param name="documentPayload">documentPayload</param>
        /// <param name="documentType">documentType (optional)</param>
        /// <returns>IngestionResponse</returns>
        public IngestionResponse ReceiveDocument (string channelName, DocumentPayload documentPayload, string documentType = null)
        {
             ApiResponse<IngestionResponse> localVarResponse = ReceiveDocumentWithHttpInfo(channelName, documentPayload, documentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Push document to the ingestion queue 
        /// </summary>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelName">channelName</param>
        /// <param name="documentPayload">documentPayload</param>
        /// <param name="documentType">documentType (optional)</param>
        /// <returns>ApiResponse of IngestionResponse</returns>
        public ApiResponse< IngestionResponse > ReceiveDocumentWithHttpInfo (string channelName, DocumentPayload documentPayload, string documentType = null)
        {
            // verify the required parameter 'channelName' is set
            if (channelName == null)
                throw new ApiException(400, "Missing required parameter 'channelName' when calling AllApi->ReceiveDocument");
            // verify the required parameter 'documentPayload' is set
            if (documentPayload == null)
                throw new ApiException(400, "Missing required parameter 'documentPayload' when calling AllApi->ReceiveDocument");

            var localVarPath = "/integration/0.1/ingestion/{channelName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (channelName != null) localVarPathParams.Add("channelName", Configuration.ApiClient.ParameterToString(channelName)); // path parameter
            if (documentType != null) localVarQueryParams.Add("documentType", Configuration.ApiClient.ParameterToString(documentType)); // query parameter
            if (documentPayload != null && documentPayload.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(documentPayload); // http body (model) parameter
            }
            else
            {
                localVarPostBody = documentPayload; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReceiveDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<IngestionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IngestionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IngestionResponse)));
        }

        /// <summary>
        /// Upload a file Upload an input image. Classification will not be started yet.
        /// </summary>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stream">The document data to be ingested</param>
        /// <returns>DocumentPayload</returns>
        public DocumentPayload UploadInputFile (System.IO.Stream stream)
        {
             ApiResponse<DocumentPayload> localVarResponse = UploadInputFileWithHttpInfo(stream);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upload a file Upload an input image. Classification will not be started yet.
        /// </summary>
        /// <exception cref="Sphereon.SDK.EIP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stream">The document data to be ingested</param>
        /// <returns>ApiResponse of DocumentPayload</returns>
        public ApiResponse< DocumentPayload > UploadInputFileWithHttpInfo (System.IO.Stream stream)
        {
            // verify the required parameter 'stream' is set
            if (stream == null)
                throw new ApiException(400, "Missing required parameter 'stream' when calling AllApi->UploadInputFile");

            var localVarPath = "/integration/0.1/ingestion/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (stream != null) localVarFileParams.Add("stream", Configuration.ApiClient.ParameterToFile("stream", stream));


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UploadInputFile", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPayload>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPayload) Configuration.ApiClient.Deserialize(localVarResponse, typeof(DocumentPayload)));
        }

    }
}
