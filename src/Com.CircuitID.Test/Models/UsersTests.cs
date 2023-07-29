/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.19
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
    ///  Class for testing Users
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class UsersTests
    {
        // TODO uncomment below to declare an instance variable for Users
        //private Users instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Users
            //instance = new Users();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Users
        /// </summary>
        [Test]
        public void UsersInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Users
            //Assert.IsInstanceOf(typeof(Users), instance);
        }


        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'SipPassword'
        /// </summary>
        [Test]
        public void SipPasswordTest()
        {
            // TODO unit test for the property 'SipPassword'
        }
        /// <summary>
        /// Test the property 'TurnPassword'
        /// </summary>
        [Test]
        public void TurnPasswordTest()
        {
            // TODO unit test for the property 'TurnPassword'
        }
        /// <summary>
        /// Test the property 'First'
        /// </summary>
        [Test]
        public void FirstTest()
        {
            // TODO unit test for the property 'First'
        }
        /// <summary>
        /// Test the property 'Last'
        /// </summary>
        [Test]
        public void LastTest()
        {
            // TODO unit test for the property 'Last'
        }
        /// <summary>
        /// Test the property 'MobilePhone'
        /// </summary>
        [Test]
        public void MobilePhoneTest()
        {
            // TODO unit test for the property 'MobilePhone'
        }
        /// <summary>
        /// Test the property 'BusinessPhone'
        /// </summary>
        [Test]
        public void BusinessPhoneTest()
        {
            // TODO unit test for the property 'BusinessPhone'
        }
        /// <summary>
        /// Test the property 'Extension'
        /// </summary>
        [Test]
        public void ExtensionTest()
        {
            // TODO unit test for the property 'Extension'
        }
        /// <summary>
        /// Test the property 'CustomCallerId'
        /// </summary>
        [Test]
        public void CustomCallerIdTest()
        {
            // TODO unit test for the property 'CustomCallerId'
        }
        /// <summary>
        /// Test the property 'JobTitle'
        /// </summary>
        [Test]
        public void JobTitleTest()
        {
            // TODO unit test for the property 'JobTitle'
        }
        /// <summary>
        /// Test the property 'Department'
        /// </summary>
        [Test]
        public void DepartmentTest()
        {
            // TODO unit test for the property 'Department'
        }
        /// <summary>
        /// Test the property 'Office'
        /// </summary>
        [Test]
        public void OfficeTest()
        {
            // TODO unit test for the property 'Office'
        }
        /// <summary>
        /// Test the property 'Avatar'
        /// </summary>
        [Test]
        public void AvatarTest()
        {
            // TODO unit test for the property 'Avatar'
        }
        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO unit test for the property 'Language'
        }
        /// <summary>
        /// Test the property 'IsPrimary'
        /// </summary>
        [Test]
        public void IsPrimaryTest()
        {
            // TODO unit test for the property 'IsPrimary'
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
        /// Test the property 'VmGreetingType'
        /// </summary>
        [Test]
        public void VmGreetingTypeTest()
        {
            // TODO unit test for the property 'VmGreetingType'
        }
        /// <summary>
        /// Test the property 'VmTimeout'
        /// </summary>
        [Test]
        public void VmTimeoutTest()
        {
            // TODO unit test for the property 'VmTimeout'
        }
        /// <summary>
        /// Test the property 'VmFile'
        /// </summary>
        [Test]
        public void VmFileTest()
        {
            // TODO unit test for the property 'VmFile'
        }
        /// <summary>
        /// Test the property 'VmPlaybackNumber'
        /// </summary>
        [Test]
        public void VmPlaybackNumberTest()
        {
            // TODO unit test for the property 'VmPlaybackNumber'
        }
        /// <summary>
        /// Test the property 'Pin'
        /// </summary>
        [Test]
        public void PinTest()
        {
            // TODO unit test for the property 'Pin'
        }
        /// <summary>
        /// Test the property 'Number'
        /// </summary>
        [Test]
        public void NumberTest()
        {
            // TODO unit test for the property 'Number'
        }
        /// <summary>
        /// Test the property 'Region'
        /// </summary>
        [Test]
        public void RegionTest()
        {
            // TODO unit test for the property 'Region'
        }
        /// <summary>
        /// Test the property 'CallerIdNumber'
        /// </summary>
        [Test]
        public void CallerIdNumberTest()
        {
            // TODO unit test for the property 'CallerIdNumber'
        }
        /// <summary>
        /// Test the property 'AdminPermission'
        /// </summary>
        [Test]
        public void AdminPermissionTest()
        {
            // TODO unit test for the property 'AdminPermission'
        }
        /// <summary>
        /// Test the property 'BillingPermission'
        /// </summary>
        [Test]
        public void BillingPermissionTest()
        {
            // TODO unit test for the property 'BillingPermission'
        }
        /// <summary>
        /// Test the property 'PhonePermission'
        /// </summary>
        [Test]
        public void PhonePermissionTest()
        {
            // TODO unit test for the property 'PhonePermission'
        }
        /// <summary>
        /// Test the property 'AgilePermission'
        /// </summary>
        [Test]
        public void AgilePermissionTest()
        {
            // TODO unit test for the property 'AgilePermission'
        }
        /// <summary>
        /// Test the property 'JobServerPermission'
        /// </summary>
        [Test]
        public void JobServerPermissionTest()
        {
            // TODO unit test for the property 'JobServerPermission'
        }
        /// <summary>
        /// Test the property 'MediaServerPermission'
        /// </summary>
        [Test]
        public void MediaServerPermissionTest()
        {
            // TODO unit test for the property 'MediaServerPermission'
        }
        /// <summary>
        /// Test the property 'MailServerPermission'
        /// </summary>
        [Test]
        public void MailServerPermissionTest()
        {
            // TODO unit test for the property 'MailServerPermission'
        }
        /// <summary>
        /// Test the property 'SuperAdminPermission'
        /// </summary>
        [Test]
        public void SuperAdminPermissionTest()
        {
            // TODO unit test for the property 'SuperAdminPermission'
        }
        /// <summary>
        /// Test the property 'Timezone'
        /// </summary>
        [Test]
        public void TimezoneTest()
        {
            // TODO unit test for the property 'Timezone'
        }
        /// <summary>
        /// Test the property 'VmTranscription'
        /// </summary>
        [Test]
        public void VmTranscriptionTest()
        {
            // TODO unit test for the property 'VmTranscription'
        }
        /// <summary>
        /// Test the property 'Communication'
        /// </summary>
        [Test]
        public void CommunicationTest()
        {
            // TODO unit test for the property 'Communication'
        }

    }

}
