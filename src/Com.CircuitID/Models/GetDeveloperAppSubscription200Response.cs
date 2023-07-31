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
    /// GetDeveloperAppSubscription200Response
    /// </summary>
    [DataContract]
    public partial class GetDeveloperAppSubscription200Response :  IEquatable<GetDeveloperAppSubscription200Response>, IValidatableObject
    {
        /// <summary>
        /// Defines RequireId
        /// </summary>
        public enum RequireIdEnum
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
        /// Gets or Sets RequireId
        /// </summary>
        [DataMember(Name="requireId", EmitDefaultValue=false)]
        public RequireIdEnum? RequireId { get; set; }
        /// <summary>
        /// Defines Services
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServicesEnum
        {
            /// <summary>
            /// Enum Calendarevents for value: calendarevents
            /// </summary>
            [EnumMember(Value = "calendarevents")]
            Calendarevents = 1,

            /// <summary>
            /// Enum Callqueues for value: callqueues
            /// </summary>
            [EnumMember(Value = "callqueues")]
            Callqueues = 2,

            /// <summary>
            /// Enum Cdrs for value: cdrs
            /// </summary>
            [EnumMember(Value = "cdrs")]
            Cdrs = 3,

            /// <summary>
            /// Enum Chatmessages for value: chatmessages
            /// </summary>
            [EnumMember(Value = "chatmessages")]
            Chatmessages = 4,

            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            [EnumMember(Value = "contacts")]
            Contacts = 5,

            /// <summary>
            /// Enum Conversationmessages for value: conversationmessages
            /// </summary>
            [EnumMember(Value = "conversationmessages")]
            Conversationmessages = 6,

            /// <summary>
            /// Enum Faxes for value: faxes
            /// </summary>
            [EnumMember(Value = "faxes")]
            Faxes = 7,

            /// <summary>
            /// Enum Firewall for value: firewall
            /// </summary>
            [EnumMember(Value = "firewall")]
            Firewall = 8,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 9,

            /// <summary>
            /// Enum Voicemail for value: voicemail
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail = 10

        }

        /// <summary>
        /// Defines Events
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventsEnum
        {
            /// <summary>
            /// Enum Create for value: create
            /// </summary>
            [EnumMember(Value = "create")]
            Create = 1,

            /// <summary>
            /// Enum Patch for value: patch
            /// </summary>
            [EnumMember(Value = "patch")]
            Patch = 2,

            /// <summary>
            /// Enum Removed for value: removed
            /// </summary>
            [EnumMember(Value = "removed")]
            Removed = 3

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeveloperAppSubscription200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDeveloperAppSubscription200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeveloperAppSubscription200Response" /> class.
        /// </summary>
        /// <param name="developerApp">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="_object">ObjectId (unique 12 bytes ID).</param>
        /// <param name="_ref">_ref.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="requireId">requireId (default to RequireIdEnum.NUMBER_0).</param>
        /// <param name="services">services (required).</param>
        /// <param name="events">events.</param>
        /// <param name="id">ObjectId (unique 12 bytes ID).</param>
        /// <param name="createdByUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="updatedByUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public GetDeveloperAppSubscription200Response(string developerApp = default(string), string _object = default(string), string _ref = default(string), Object permissions = default(Object), RequireIdEnum? requireId = RequireIdEnum.NUMBER_0, List<ServicesEnum> services = default(List<ServicesEnum>), List<EventsEnum> events = default(List<EventsEnum>), string id = default(string), string createdByUserId = default(string), string updatedByUserId = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            // to ensure "developerApp" is required (not null)
            if (developerApp == null)
            {
                throw new InvalidDataException("developerApp is a required property for GetDeveloperAppSubscription200Response and cannot be null");
            }
            else
            {
                this.DeveloperApp = developerApp;
            }

            // to ensure "services" is required (not null)
            if (services == null)
            {
                throw new InvalidDataException("services is a required property for GetDeveloperAppSubscription200Response and cannot be null");
            }
            else
            {
                this.Services = services;
            }

            this.Object = _object;
            this.Ref = _ref;
            this.Permissions = permissions;
            // use default value if no "requireId" provided
            if (requireId == null)
            {
                this.RequireId = RequireIdEnum.NUMBER_0;
            }
            else
            {
                this.RequireId = requireId;
            }
            this.Events = events;
            this.Id = id;
            this.CreatedByUserId = createdByUserId;
            this.UpdatedByUserId = updatedByUserId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="developerApp", EmitDefaultValue=true)]
        public string DeveloperApp { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="object", EmitDefaultValue=false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string Ref { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public Object Permissions { get; set; }


        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="services", EmitDefaultValue=true)]
        public List<GetDeveloperAppSubscription200Response.ServicesEnum> Services { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<GetDeveloperAppSubscription200Response.EventsEnum> Events { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public string CreatedByUserId { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="updatedByUserId", EmitDefaultValue=false)]
        public string UpdatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDeveloperAppSubscription200Response {\n");
            sb.Append("  DeveloperApp: ").Append(DeveloperApp).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  RequireId: ").Append(RequireId).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  UpdatedByUserId: ").Append(UpdatedByUserId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as GetDeveloperAppSubscription200Response);
        }

        /// <summary>
        /// Returns true if GetDeveloperAppSubscription200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDeveloperAppSubscription200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDeveloperAppSubscription200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeveloperApp == input.DeveloperApp ||
                    (this.DeveloperApp != null &&
                    this.DeveloperApp.Equals(input.DeveloperApp))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.RequireId == input.RequireId ||
                    (this.RequireId != null &&
                    this.RequireId.Equals(input.RequireId))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.UpdatedByUserId == input.UpdatedByUserId ||
                    (this.UpdatedByUserId != null &&
                    this.UpdatedByUserId.Equals(input.UpdatedByUserId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.DeveloperApp != null)
                    hashCode = hashCode * 59 + this.DeveloperApp.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.RequireId != null)
                    hashCode = hashCode * 59 + this.RequireId.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.UpdatedByUserId != null)
                    hashCode = hashCode * 59 + this.UpdatedByUserId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
            // Ref (string) maxLength
            if(this.Ref != null && this.Ref.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ref, length must be less than 45.", new [] { "Ref" });
            }


            yield break;
        }
    }

}
