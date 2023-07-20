/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.8
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

using circuitid-csharp.Client;
using circuitid-csharp.CircuitID;
using circuitid-csharp.CircuitID;

namespace circuitid-csharp.Test
{
    /// <summary>
    ///  Class for testing TimeSchedulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TimeSchedulesApiTests
    {
        private TimeSchedulesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeSchedulesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TimeSchedulesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TimeSchedulesApi
            //Assert.IsInstanceOf(typeof(TimeSchedulesApi), instance);
        }

        
        /// <summary>
        /// Test CreateTimeSchedule
        /// </summary>
        [Test]
        public void CreateTimeScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Timeschedules timeschedules = null;
            //var response = instance.CreateTimeSchedule(timeschedules);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test FindTimeSchedules
        /// </summary>
        [Test]
        public void FindTimeSchedulesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object search = null;
            //Object limit = null;
            //Object skip = null;
            //Object sort = null;
            //Object select = null;
            //Object or = null;
            //Object and = null;
            //var response = instance.FindTimeSchedules(search, limit, skip, sort, select, or, and);
            //Assert.IsInstanceOf(typeof(FindTimeSchedules200Response), response, "response is FindTimeSchedules200Response");
        }
        
        /// <summary>
        /// Test GetTimeSchedule
        /// </summary>
        [Test]
        public void GetTimeScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.GetTimeSchedule(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test PatchTimeSchedule
        /// </summary>
        [Test]
        public void PatchTimeScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //Timeschedules timeschedules = null;
            //var response = instance.PatchTimeSchedule(id, timeschedules);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test RemoveTimeSchedule
        /// </summary>
        [Test]
        public void RemoveTimeScheduleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object id = null;
            //var response = instance.RemoveTimeSchedule(id);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
    }

}
