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
    ///  Class for testing ConferenceRoomsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConferenceRoomsApiTests
    {
        private ConferenceRoomsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConferenceRoomsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConferenceRoomsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ConferenceRoomsApi
            //Assert.IsInstanceOf(typeof(ConferenceRoomsApi), instance);
        }

        
        /// <summary>
        /// Test CreateConferenceRoom
        /// </summary>
        [Test]
        public void CreateConferenceRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Conferencerooms conferencerooms = null;
            //var response = instance.CreateConferenceRoom(conferencerooms);
            //Assert.IsInstanceOf(typeof(GetConferenceRoom200Response), response, "response is GetConferenceRoom200Response");
        }
        
        /// <summary>
        /// Test FindConferenceRooms
        /// </summary>
        [Test]
        public void FindConferenceRoomsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string search = null;
            //int? limit = null;
            //int? skip = null;
            //Object sort = null;
            //List<string> select = null;
            //List<Object> or = null;
            //List<Object> and = null;
            //var response = instance.FindConferenceRooms(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindConferenceRooms200Response), response, "response is FindConferenceRooms200Response");
        }
        
        /// <summary>
        /// Test GetConferenceRoom
        /// </summary>
        [Test]
        public void GetConferenceRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetConferenceRoom(id);
            //Assert.IsInstanceOf(typeof(GetConferenceRoom200Response), response, "response is GetConferenceRoom200Response");
        }
        
        /// <summary>
        /// Test PatchConferenceRoom
        /// </summary>
        [Test]
        public void PatchConferenceRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Conferencerooms conferencerooms = null;
            //var response = instance.PatchConferenceRoom(id, conferencerooms);
            //Assert.IsInstanceOf(typeof(GetConferenceRoom200Response), response, "response is GetConferenceRoom200Response");
        }
        
        /// <summary>
        /// Test RemoveConferenceRoom
        /// </summary>
        [Test]
        public void RemoveConferenceRoomTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.RemoveConferenceRoom(id);
            //Assert.IsInstanceOf(typeof(GetConferenceRoom200Response), response, "response is GetConferenceRoom200Response");
        }
        
    }

}
