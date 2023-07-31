/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.21
 * Contact: support@circuitid.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Com.CircuitID.Api;
using Com.CircuitID.Models;
using Com.CircuitID.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Com.CircuitID.Test
{
    /// <summary>
    ///  Class for testing GetNumber200Response
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GetNumber200ResponseTests
    {
        // TODO uncomment below to declare an instance variable for GetNumber200Response
        //private GetNumber200Response instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GetNumber200Response
            //instance = new GetNumber200Response();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GetNumber200Response
        /// </summary>
        [Test]
        public void GetNumber200ResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" GetNumber200Response
            //Assert.IsInstanceOf(typeof(GetNumber200Response), instance);
        }


        /// <summary>
        /// Test the property 'InUse'
        /// </summary>
        [Test]
        public void InUseTest()
        {
            // TODO unit test for the property 'InUse'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'CountryCode'
        /// </summary>
        [Test]
        public void CountryCodeTest()
        {
            // TODO unit test for the property 'CountryCode'
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Test]
        public void AmountTest()
        {
            // TODO unit test for the property 'Amount'
        }
        /// <summary>
        /// Test the property 'PerMinuteRate'
        /// </summary>
        [Test]
        public void PerMinuteRateTest()
        {
            // TODO unit test for the property 'PerMinuteRate'
        }
        /// <summary>
        /// Test the property 'Fax'
        /// </summary>
        [Test]
        public void FaxTest()
        {
            // TODO unit test for the property 'Fax'
        }
        /// <summary>
        /// Test the property 'Voice'
        /// </summary>
        [Test]
        public void VoiceTest()
        {
            // TODO unit test for the property 'Voice'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Sms'
        /// </summary>
        [Test]
        public void SmsTest()
        {
            // TODO unit test for the property 'Sms'
        }
        /// <summary>
        /// Test the property 'Mms'
        /// </summary>
        [Test]
        public void MmsTest()
        {
            // TODO unit test for the property 'Mms'
        }
        /// <summary>
        /// Test the property 'DirectoryListing'
        /// </summary>
        [Test]
        public void DirectoryListingTest()
        {
            // TODO unit test for the property 'DirectoryListing'
        }
        /// <summary>
        /// Test the property 'CallerName'
        /// </summary>
        [Test]
        public void CallerNameTest()
        {
            // TODO unit test for the property 'CallerName'
        }
        /// <summary>
        /// Test the property 'E911'
        /// </summary>
        [Test]
        public void E911Test()
        {
            // TODO unit test for the property 'E911'
        }
        /// <summary>
        /// Test the property 'MessageCampaign'
        /// </summary>
        [Test]
        public void MessageCampaignTest()
        {
            // TODO unit test for the property 'MessageCampaign'
        }
        /// <summary>
        /// Test the property 'MessageClass'
        /// </summary>
        [Test]
        public void MessageClassTest()
        {
            // TODO unit test for the property 'MessageClass'
        }
        /// <summary>
        /// Test the property 'MessageType'
        /// </summary>
        [Test]
        public void MessageTypeTest()
        {
            // TODO unit test for the property 'MessageType'
        }
        /// <summary>
        /// Test the property 'E911Supported'
        /// </summary>
        [Test]
        public void E911SupportedTest()
        {
            // TODO unit test for the property 'E911Supported'
        }
        /// <summary>
        /// Test the property 'CallerNameSupported'
        /// </summary>
        [Test]
        public void CallerNameSupportedTest()
        {
            // TODO unit test for the property 'CallerNameSupported'
        }
        /// <summary>
        /// Test the property 'DirectoryListingSupported'
        /// </summary>
        [Test]
        public void DirectoryListingSupportedTest()
        {
            // TODO unit test for the property 'DirectoryListingSupported'
        }
        /// <summary>
        /// Test the property 'MessagingSupported'
        /// </summary>
        [Test]
        public void MessagingSupportedTest()
        {
            // TODO unit test for the property 'MessagingSupported'
        }
        /// <summary>
        /// Test the property 'DestinationType'
        /// </summary>
        [Test]
        public void DestinationTypeTest()
        {
            // TODO unit test for the property 'DestinationType'
        }
        /// <summary>
        /// Test the property 'Destination'
        /// </summary>
        [Test]
        public void DestinationTest()
        {
            // TODO unit test for the property 'Destination'
        }
        /// <summary>
        /// Test the property 'Ref'
        /// </summary>
        [Test]
        public void RefTest()
        {
            // TODO unit test for the property 'Ref'
        }
        /// <summary>
        /// Test the property 'CallForwardingDestination'
        /// </summary>
        [Test]
        public void CallForwardingDestinationTest()
        {
            // TODO unit test for the property 'CallForwardingDestination'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'CreatedByUserId'
        /// </summary>
        [Test]
        public void CreatedByUserIdTest()
        {
            // TODO unit test for the property 'CreatedByUserId'
        }
        /// <summary>
        /// Test the property 'UpdatedByUserId'
        /// </summary>
        [Test]
        public void UpdatedByUserIdTest()
        {
            // TODO unit test for the property 'UpdatedByUserId'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }

    }

}