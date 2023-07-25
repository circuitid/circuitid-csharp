/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.17
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
    ///  Class for testing Customers
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CustomersTests
    {
        // TODO uncomment below to declare an instance variable for Customers
        //private Customers instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Customers
            //instance = new Customers();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Customers
        /// </summary>
        [Test]
        public void CustomersInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Customers
            //Assert.IsInstanceOf(typeof(Customers), instance);
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
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'WebsiteUrl'
        /// </summary>
        [Test]
        public void WebsiteUrlTest()
        {
            // TODO unit test for the property 'WebsiteUrl'
        }
        /// <summary>
        /// Test the property 'Logo'
        /// </summary>
        [Test]
        public void LogoTest()
        {
            // TODO unit test for the property 'Logo'
        }
        /// <summary>
        /// Test the property 'Credit'
        /// </summary>
        [Test]
        public void CreditTest()
        {
            // TODO unit test for the property 'Credit'
        }
        /// <summary>
        /// Test the property 'AdminUserId'
        /// </summary>
        [Test]
        public void AdminUserIdTest()
        {
            // TODO unit test for the property 'AdminUserId'
        }
        /// <summary>
        /// Test the property 'BillingUserId'
        /// </summary>
        [Test]
        public void BillingUserIdTest()
        {
            // TODO unit test for the property 'BillingUserId'
        }
        /// <summary>
        /// Test the property 'CallRecordingUserId'
        /// </summary>
        [Test]
        public void CallRecordingUserIdTest()
        {
            // TODO unit test for the property 'CallRecordingUserId'
        }
        /// <summary>
        /// Test the property 'CallForwardingCallLimit'
        /// </summary>
        [Test]
        public void CallForwardingCallLimitTest()
        {
            // TODO unit test for the property 'CallForwardingCallLimit'
        }
        /// <summary>
        /// Test the property 'SupportUserId'
        /// </summary>
        [Test]
        public void SupportUserIdTest()
        {
            // TODO unit test for the property 'SupportUserId'
        }
        /// <summary>
        /// Test the property 'AutomaticRefillAmount'
        /// </summary>
        [Test]
        public void AutomaticRefillAmountTest()
        {
            // TODO unit test for the property 'AutomaticRefillAmount'
        }
        /// <summary>
        /// Test the property 'LowBalanceAlertAmount'
        /// </summary>
        [Test]
        public void LowBalanceAlertAmountTest()
        {
            // TODO unit test for the property 'LowBalanceAlertAmount'
        }
        /// <summary>
        /// Test the property 'LowBalanceAlertAt'
        /// </summary>
        [Test]
        public void LowBalanceAlertAtTest()
        {
            // TODO unit test for the property 'LowBalanceAlertAt'
        }
        /// <summary>
        /// Test the property 'LowBalanceAlertCount'
        /// </summary>
        [Test]
        public void LowBalanceAlertCountTest()
        {
            // TODO unit test for the property 'LowBalanceAlertCount'
        }
        /// <summary>
        /// Test the property 'LastAutomaticRefillInvoice'
        /// </summary>
        [Test]
        public void LastAutomaticRefillInvoiceTest()
        {
            // TODO unit test for the property 'LastAutomaticRefillInvoice'
        }
        /// <summary>
        /// Test the property 'InternationalCalling'
        /// </summary>
        [Test]
        public void InternationalCallingTest()
        {
            // TODO unit test for the property 'InternationalCalling'
        }
        /// <summary>
        /// Test the property 'CreatedByIP'
        /// </summary>
        [Test]
        public void CreatedByIPTest()
        {
            // TODO unit test for the property 'CreatedByIP'
        }
        /// <summary>
        /// Test the property 'CallDebug'
        /// </summary>
        [Test]
        public void CallDebugTest()
        {
            // TODO unit test for the property 'CallDebug'
        }
        /// <summary>
        /// Test the property 'MediaBypass'
        /// </summary>
        [Test]
        public void MediaBypassTest()
        {
            // TODO unit test for the property 'MediaBypass'
        }
        /// <summary>
        /// Test the property 'AccountLock'
        /// </summary>
        [Test]
        public void AccountLockTest()
        {
            // TODO unit test for the property 'AccountLock'
        }
        /// <summary>
        /// Test the property 'CallRecording'
        /// </summary>
        [Test]
        public void CallRecordingTest()
        {
            // TODO unit test for the property 'CallRecording'
        }
        /// <summary>
        /// Test the property 'CdrRetention'
        /// </summary>
        [Test]
        public void CdrRetentionTest()
        {
            // TODO unit test for the property 'CdrRetention'
        }
        /// <summary>
        /// Test the property 'CnamLookUps'
        /// </summary>
        [Test]
        public void CnamLookUpsTest()
        {
            // TODO unit test for the property 'CnamLookUps'
        }
        /// <summary>
        /// Test the property 'HoldMusic'
        /// </summary>
        [Test]
        public void HoldMusicTest()
        {
            // TODO unit test for the property 'HoldMusic'
        }
        /// <summary>
        /// Test the property 'TranscribeCalls'
        /// </summary>
        [Test]
        public void TranscribeCallsTest()
        {
            // TODO unit test for the property 'TranscribeCalls'
        }
        /// <summary>
        /// Test the property 'MaxOutboundCallRate'
        /// </summary>
        [Test]
        public void MaxOutboundCallRateTest()
        {
            // TODO unit test for the property 'MaxOutboundCallRate'
        }
        /// <summary>
        /// Test the property 'DefaultBillMethod'
        /// </summary>
        [Test]
        public void DefaultBillMethodTest()
        {
            // TODO unit test for the property 'DefaultBillMethod'
        }

    }

}
