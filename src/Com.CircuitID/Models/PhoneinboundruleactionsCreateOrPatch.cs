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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.CircuitID.Client.OpenAPIDateConverter;

namespace Com.CircuitID.Models
{
    /// <summary>
    /// PhoneinboundruleactionsCreateOrPatch
    /// </summary>
    [DataContract]
    public partial class PhoneinboundruleactionsCreateOrPatch :  IEquatable<PhoneinboundruleactionsCreateOrPatch>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Defines DestinationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DestinationTypeEnum
        {
            /// <summary>
            /// Enum Announcements for value: announcements
            /// </summary>
            [EnumMember(Value = "announcements")]
            Announcements = 1,

            /// <summary>
            /// Enum Directories for value: directories
            /// </summary>
            [EnumMember(Value = "directories")]
            Directories = 2,

            /// <summary>
            /// Enum Park for value: park
            /// </summary>
            [EnumMember(Value = "park")]
            Park = 3,

            /// <summary>
            /// Enum Numbers for value: numbers
            /// </summary>
            [EnumMember(Value = "numbers")]
            Numbers = 4,

            /// <summary>
            /// Enum Menus for value: menus
            /// </summary>
            [EnumMember(Value = "menus")]
            Menus = 5,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 6,

            /// <summary>
            /// Enum Servers for value: servers
            /// </summary>
            [EnumMember(Value = "servers")]
            Servers = 7,

            /// <summary>
            /// Enum Inboundrules for value: inboundrules
            /// </summary>
            [EnumMember(Value = "inboundrules")]
            Inboundrules = 8,

            /// <summary>
            /// Enum Callqueues for value: callqueues
            /// </summary>
            [EnumMember(Value = "callqueues")]
            Callqueues = 9,

            /// <summary>
            /// Enum Faxaccounts for value: faxaccounts
            /// </summary>
            [EnumMember(Value = "faxaccounts")]
            Faxaccounts = 10,

            /// <summary>
            /// Enum Callforwarding for value: callforwarding
            /// </summary>
            [EnumMember(Value = "callforwarding")]
            Callforwarding = 11,

            /// <summary>
            /// Enum Hangup for value: hangup
            /// </summary>
            [EnumMember(Value = "hangup")]
            Hangup = 12,

            /// <summary>
            /// Enum Phoneinboundrules for value: phoneinboundrules
            /// </summary>
            [EnumMember(Value = "phoneinboundrules")]
            Phoneinboundrules = 13,

            /// <summary>
            /// Enum Voicemailaccounts for value: voicemailaccounts
            /// </summary>
            [EnumMember(Value = "voicemailaccounts")]
            Voicemailaccounts = 14

        }

        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name="destinationType", EmitDefaultValue=true)]
        public DestinationTypeEnum DestinationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneinboundruleactionsCreateOrPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneinboundruleactionsCreateOrPatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneinboundruleactionsCreateOrPatch" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="phoneinboundrule">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="timeschedule">ObjectId (unique 12 bytes ID).</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="status">status (default to StatusEnum.NUMBER_1).</param>
        /// <param name="priority">priority (required) (default to 1).</param>
        /// <param name="destinationType">destinationType (required).</param>
        /// <param name="destination">ObjectId (unique 12 bytes ID).</param>
        /// <param name="callForwardingDestination">callForwardingDestination.</param>
        public PhoneinboundruleactionsCreateOrPatch(string name = default(string), string phoneinboundrule = default(string), string timeschedule = default(string), int timeout = default(int), StatusEnum? status = StatusEnum.NUMBER_1, int priority = 1, DestinationTypeEnum destinationType = default(DestinationTypeEnum), string destination = default(string), string callForwardingDestination = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PhoneinboundruleactionsCreateOrPatch and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "phoneinboundrule" is required (not null)
            if (phoneinboundrule == null)
            {
                throw new InvalidDataException("phoneinboundrule is a required property for PhoneinboundruleactionsCreateOrPatch and cannot be null");
            }
            else
            {
                this.Phoneinboundrule = phoneinboundrule;
            }

            // to ensure "priority" is required (not null)
            if (priority == null)
            {
                throw new InvalidDataException("priority is a required property for PhoneinboundruleactionsCreateOrPatch and cannot be null");
            }
            else
            {
                this.Priority = priority;
            }

            // to ensure "destinationType" is required (not null)
            if (destinationType == null)
            {
                throw new InvalidDataException("destinationType is a required property for PhoneinboundruleactionsCreateOrPatch and cannot be null");
            }
            else
            {
                this.DestinationType = destinationType;
            }

            this.Timeschedule = timeschedule;
            this.Timeout = timeout;
            // use default value if no "status" provided
            if (status == null)
            {
                this.Status = StatusEnum.NUMBER_1;
            }
            else
            {
                this.Status = status;
            }
            this.Destination = destination;
            this.CallForwardingDestination = callForwardingDestination;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="phoneinboundrule", EmitDefaultValue=true)]
        public string Phoneinboundrule { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="timeschedule", EmitDefaultValue=false)]
        public string Timeschedule { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int Timeout { get; set; }


        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=true)]
        public int Priority { get; set; }


        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets CallForwardingDestination
        /// </summary>
        [DataMember(Name="callForwardingDestination", EmitDefaultValue=false)]
        public string CallForwardingDestination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneinboundruleactionsCreateOrPatch {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phoneinboundrule: ").Append(Phoneinboundrule).Append("\n");
            sb.Append("  Timeschedule: ").Append(Timeschedule).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  CallForwardingDestination: ").Append(CallForwardingDestination).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PhoneinboundruleactionsCreateOrPatch);
        }

        /// <summary>
        /// Returns true if PhoneinboundruleactionsCreateOrPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneinboundruleactionsCreateOrPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneinboundruleactionsCreateOrPatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Phoneinboundrule == input.Phoneinboundrule ||
                    (this.Phoneinboundrule != null &&
                    this.Phoneinboundrule.Equals(input.Phoneinboundrule))
                ) && 
                (
                    this.Timeschedule == input.Timeschedule ||
                    (this.Timeschedule != null &&
                    this.Timeschedule.Equals(input.Timeschedule))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.CallForwardingDestination == input.CallForwardingDestination ||
                    (this.CallForwardingDestination != null &&
                    this.CallForwardingDestination.Equals(input.CallForwardingDestination))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Phoneinboundrule != null)
                    hashCode = hashCode * 59 + this.Phoneinboundrule.GetHashCode();
                if (this.Timeschedule != null)
                    hashCode = hashCode * 59 + this.Timeschedule.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.CallForwardingDestination != null)
                    hashCode = hashCode * 59 + this.CallForwardingDestination.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 45.", new [] { "Name" });
            }


            // CallForwardingDestination (string) maxLength
            if(this.CallForwardingDestination != null && this.CallForwardingDestination.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallForwardingDestination, length must be less than 45.", new [] { "CallForwardingDestination" });
            }

            // CallForwardingDestination (string) minLength
            if(this.CallForwardingDestination != null && this.CallForwardingDestination.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallForwardingDestination, length must be greater than 10.", new [] { "CallForwardingDestination" });
            }

            yield break;
        }
    }

}
