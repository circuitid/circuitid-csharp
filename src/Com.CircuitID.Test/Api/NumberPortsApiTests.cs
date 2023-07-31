/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.21
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
    ///  Class for testing NumberPortsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class NumberPortsApiTests
    {
        private NumberPortsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NumberPortsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NumberPortsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' NumberPortsApi
            //Assert.IsInstanceOf(typeof(NumberPortsApi), instance);
        }

        
        /// <summary>
        /// Test CreateNumberPort
        /// </summary>
        [Test]
        public void CreateNumberPortTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //NumberportsCreateOrPatch numberportsCreateOrPatch = null;
            //var response = instance.CreateNumberPort(numberportsCreateOrPatch);
            //Assert.IsInstanceOf(typeof(GetNumberPort200Response), response, "response is GetNumberPort200Response");
        }
        
        /// <summary>
        /// Test FindNumberPorts
        /// </summary>
        [Test]
        public void FindNumberPortsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //int? limit = null;
            //int? skip = null;
            //Object sort = null;
            //List<string> select = null;
            //List<Object> or = null;
            //List<Object> and = null;
            //var response = instance.FindNumberPorts(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindNumberPorts200Response), response, "response is FindNumberPorts200Response");
        }
        
        /// <summary>
        /// Test GetNumberPort
        /// </summary>
        [Test]
        public void GetNumberPortTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetNumberPort(id);
            //Assert.IsInstanceOf(typeof(GetNumberPort200Response), response, "response is GetNumberPort200Response");
        }
        
    }

}
