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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Sphereon.SDK.EIP.Client;
using Sphereon.SDK.EIP.Api;
using Sphereon.SDK.EIP.Model;

namespace Sphereon.SDK.EIP.Test
{
    /// <summary>
    ///  Class for testing IngestionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class IngestionApiTests
    {
        private IngestionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IngestionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IngestionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IngestionApi
            //Assert.IsInstanceOfType(typeof(IngestionApi), instance, "instance is a IngestionApi");
        }

        
        /// <summary>
        /// Test GetDocumentStatus
        /// </summary>
        [Test]
        public void GetDocumentStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string documentId = null;
            //var response = instance.GetDocumentStatus(documentId);
            //Assert.IsInstanceOf<IngestionResponse> (response, "response is IngestionResponse");
        }
        
        /// <summary>
        /// Test ReceiveDocument
        /// </summary>
        [Test]
        public void ReceiveDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string channelName = null;
            //DocumentPayload documentPayload = null;
            //string documentType = null;
            //var response = instance.ReceiveDocument(channelName, documentPayload, documentType);
            //Assert.IsInstanceOf<IngestionResponse> (response, "response is IngestionResponse");
        }
        
        /// <summary>
        /// Test UploadInputFile
        /// </summary>
        [Test]
        public void UploadInputFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream stream = null;
            //var response = instance.UploadInputFile(stream);
            //Assert.IsInstanceOf<DocumentPayload> (response, "response is DocumentPayload");
        }
        
    }

}
