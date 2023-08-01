/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.22
 * Contact: support@circuitid.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Com.CircuitID.Client;
using Com.CircuitID.Api;
using Com.CircuitID.Models;

namespace Com.CircuitID.Test
{
    /// <summary>
    ///  Class for testing DirectoriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DirectoriesApiTests
    {
        private DirectoriesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DirectoriesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DirectoriesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' DirectoriesApi
            //Assert.IsInstanceOf(typeof(DirectoriesApi), instance);
        }

        
        /// <summary>
        /// Test Createdirectory
        /// </summary>
        [Test]
        public void CreatedirectoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DirectoriesCreateOrPatch directoriesCreateOrPatch = null;
            //var response = instance.Createdirectory(directoriesCreateOrPatch);
            //Assert.IsInstanceOf(typeof(Getdirectory200Response), response, "response is Getdirectory200Response");
        }
        
        /// <summary>
        /// Test FindDirectories
        /// </summary>
        [Test]
        public void FindDirectoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //int? limit = null;
            //int? skip = null;
            //Object sort = null;
            //List<string> select = null;
            //List<Object> or = null;
            //List<Object> and = null;
            //var response = instance.FindDirectories(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindDirectories200Response), response, "response is FindDirectories200Response");
        }
        
        /// <summary>
        /// Test Getdirectory
        /// </summary>
        [Test]
        public void GetdirectoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.Getdirectory(id);
            //Assert.IsInstanceOf(typeof(Getdirectory200Response), response, "response is Getdirectory200Response");
        }
        
        /// <summary>
        /// Test Patchdirectory
        /// </summary>
        [Test]
        public void PatchdirectoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //DirectoriesCreateOrPatch directoriesCreateOrPatch = null;
            //var response = instance.Patchdirectory(id, directoriesCreateOrPatch);
            //Assert.IsInstanceOf(typeof(Getdirectory200Response), response, "response is Getdirectory200Response");
        }
        
        /// <summary>
        /// Test Removedirectory
        /// </summary>
        [Test]
        public void RemovedirectoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.Removedirectory(id);
            //Assert.IsInstanceOf(typeof(Getdirectory200Response), response, "response is Getdirectory200Response");
        }
        
    }

}
