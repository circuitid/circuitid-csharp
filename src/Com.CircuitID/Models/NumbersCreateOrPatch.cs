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
    /// NumbersCreateOrPatch
    /// </summary>
    [DataContract]
    public partial class NumbersCreateOrPatch :  IEquatable<NumbersCreateOrPatch>, IValidatableObject
    {
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
        /// Initializes a new instance of the <see cref="NumbersCreateOrPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NumbersCreateOrPatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NumbersCreateOrPatch" /> class.
        /// </summary>
        /// <param name="directoryListing">ObjectId (unique 12 bytes ID).</param>
        /// <param name="callerName">callerName.</param>
        /// <param name="e911">ObjectId (unique 12 bytes ID).</param>
        /// <param name="messageCampaign">ObjectId (unique 12 bytes ID).</param>
        /// <param name="destinationType">destinationType (required) (default to DestinationTypeEnum.Park).</param>
        /// <param name="destination">ObjectId (unique 12 bytes ID).</param>
        /// <param name="callForwardingDestination">callForwardingDestination.</param>
        public NumbersCreateOrPatch(string directoryListing = default(string), string callerName = default(string), string e911 = default(string), string messageCampaign = default(string), DestinationTypeEnum destinationType = DestinationTypeEnum.Park, string destination = default(string), string callForwardingDestination = default(string))
        {
            // to ensure "destinationType" is required (not null)
            if (destinationType == null)
            {
                throw new InvalidDataException("destinationType is a required property for NumbersCreateOrPatch and cannot be null");
            }
            else
            {
                this.DestinationType = destinationType;
            }

            this.DirectoryListing = directoryListing;
            this.CallerName = callerName;
            this.E911 = e911;
            this.MessageCampaign = messageCampaign;
            this.Destination = destination;
            this.CallForwardingDestination = callForwardingDestination;
        }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="directoryListing", EmitDefaultValue=false)]
        public string DirectoryListing { get; set; }

        /// <summary>
        /// Gets or Sets CallerName
        /// </summary>
        [DataMember(Name="callerName", EmitDefaultValue=false)]
        public string CallerName { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="e911", EmitDefaultValue=false)]
        public string E911 { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="messageCampaign", EmitDefaultValue=false)]
        public string MessageCampaign { get; set; }


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
            sb.Append("class NumbersCreateOrPatch {\n");
            sb.Append("  DirectoryListing: ").Append(DirectoryListing).Append("\n");
            sb.Append("  CallerName: ").Append(CallerName).Append("\n");
            sb.Append("  E911: ").Append(E911).Append("\n");
            sb.Append("  MessageCampaign: ").Append(MessageCampaign).Append("\n");
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
            return this.Equals(input as NumbersCreateOrPatch);
        }

        /// <summary>
        /// Returns true if NumbersCreateOrPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of NumbersCreateOrPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumbersCreateOrPatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DirectoryListing == input.DirectoryListing ||
                    (this.DirectoryListing != null &&
                    this.DirectoryListing.Equals(input.DirectoryListing))
                ) && 
                (
                    this.CallerName == input.CallerName ||
                    (this.CallerName != null &&
                    this.CallerName.Equals(input.CallerName))
                ) && 
                (
                    this.E911 == input.E911 ||
                    (this.E911 != null &&
                    this.E911.Equals(input.E911))
                ) && 
                (
                    this.MessageCampaign == input.MessageCampaign ||
                    (this.MessageCampaign != null &&
                    this.MessageCampaign.Equals(input.MessageCampaign))
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
                if (this.DirectoryListing != null)
                    hashCode = hashCode * 59 + this.DirectoryListing.GetHashCode();
                if (this.CallerName != null)
                    hashCode = hashCode * 59 + this.CallerName.GetHashCode();
                if (this.E911 != null)
                    hashCode = hashCode * 59 + this.E911.GetHashCode();
                if (this.MessageCampaign != null)
                    hashCode = hashCode * 59 + this.MessageCampaign.GetHashCode();
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
            // CallerName (string) maxLength
            if(this.CallerName != null && this.CallerName.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallerName, length must be less than 45.", new [] { "CallerName" });
            }


            // MessageCampaign (string) maxLength
            if(this.MessageCampaign != null && this.MessageCampaign.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MessageCampaign, length must be less than 45.", new [] { "MessageCampaign" });
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
