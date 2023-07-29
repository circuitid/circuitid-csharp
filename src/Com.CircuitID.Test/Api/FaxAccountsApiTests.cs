/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.19
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
    ///  Class for testing FaxAccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FaxAccountsApiTests
    {
        private FaxAccountsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaxAccountsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FaxAccountsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' FaxAccountsApi
            //Assert.IsInstanceOf(typeof(FaxAccountsApi), instance);
        }

        
        /// <summary>
        /// Test CreateFaxAccount
        /// </summary>
        [Test]
        public void CreateFaxAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Faxaccounts faxaccounts = null;
            //var response = instance.CreateFaxAccount(faxaccounts);
            //Assert.IsInstanceOf(typeof(GetFaxAccount200Response), response, "response is GetFaxAccount200Response");
        }
        
        /// <summary>
        /// Test FindFaxAccounts
        /// </summary>
        [Test]
        public void FindFaxAccountsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //int? limit = null;
            //int? skip = null;
            //Object sort = null;
            //List<string> select = null;
            //List<Object> or = null;
            //List<Object> and = null;
            //var response = instance.FindFaxAccounts(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindFaxAccounts200Response), response, "response is FindFaxAccounts200Response");
        }
        
        /// <summary>
        /// Test GetFaxAccount
        /// </summary>
        [Test]
        public void GetFaxAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetFaxAccount(id);
            //Assert.IsInstanceOf(typeof(GetFaxAccount200Response), response, "response is GetFaxAccount200Response");
        }
        
        /// <summary>
        /// Test PatchFaxAccount
        /// </summary>
        [Test]
        public void PatchFaxAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Faxaccounts faxaccounts = null;
            //var response = instance.PatchFaxAccount(id, faxaccounts);
            //Assert.IsInstanceOf(typeof(GetFaxAccount200Response), response, "response is GetFaxAccount200Response");
        }
        
        /// <summary>
        /// Test RemoveFaxAccount
        /// </summary>
        [Test]
        public void RemoveFaxAccountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.RemoveFaxAccount(id);
            //Assert.IsInstanceOf(typeof(GetFaxAccount200Response), response, "response is GetFaxAccount200Response");
        }
        
    }

}
