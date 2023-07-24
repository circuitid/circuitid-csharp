/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.16
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
    ///  Class for testing GroupMembersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GroupMembersApiTests
    {
        private GroupMembersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupMembersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupMembersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GroupMembersApi
            //Assert.IsInstanceOf(typeof(GroupMembersApi), instance);
        }

        
        /// <summary>
        /// Test CreateGroupMember
        /// </summary>
        [Test]
        public void CreateGroupMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Groupmembers groupmembers = null;
            //var response = instance.CreateGroupMember(groupmembers);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test FindGroupMembers
        /// </summary>
        [Test]
        public void FindGroupMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object search = null;
            //Object limit = null;
            //Object skip = null;
            //Object sort = null;
            //Object select = null;
            //Object or = null;
            //Object and = null;
            //var response = instance.FindGroupMembers(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindGroupMembers200Response), response, "response is FindGroupMembers200Response");
        }
        
        /// <summary>
        /// Test GetGroupMember
        /// </summary>
        [Test]
        public void GetGroupMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.GetGroupMember(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test PatchGroupMember
        /// </summary>
        [Test]
        public void PatchGroupMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //Groupmembers groupmembers = null;
            //var response = instance.PatchGroupMember(id, groupmembers);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test RemoveGroupMember
        /// </summary>
        [Test]
        public void RemoveGroupMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.RemoveGroupMember(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
    }

}