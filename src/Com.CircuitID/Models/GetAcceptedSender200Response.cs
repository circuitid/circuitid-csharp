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
    /// GetAcceptedSender200Response
    /// </summary>
    [DataContract]
    public partial class GetAcceptedSender200Response :  IEquatable<GetAcceptedSender200Response>, IValidatableObject
    {
        /// <summary>
        /// Defines Ref
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefEnum
        {
            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 1,

            /// <summary>
            /// Enum Domains for value: domains
            /// </summary>
            [EnumMember(Value = "domains")]
            Domains = 2,

            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            [EnumMember(Value = "contacts")]
            Contacts = 3

        }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=true)]
        public RefEnum Ref { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAcceptedSender200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAcceptedSender200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAcceptedSender200Response" /> class.
        /// </summary>
        /// <param name="_object">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="service">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="serviceRef">serviceRef (required).</param>
        /// <param name="_ref">_ref (required).</param>
        /// <param name="id">ObjectId (unique 12 bytes ID).</param>
        /// <param name="createdByUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="updatedByUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public GetAcceptedSender200Response(string _object = default(string), string service = default(string), string serviceRef = default(string), RefEnum _ref = default(RefEnum), string id = default(string), string createdByUserId = default(string), string updatedByUserId = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for GetAcceptedSender200Response and cannot be null");
            }
            else
            {
                this.Object = _object;
            }

            // to ensure "service" is required (not null)
            if (service == null)
            {
                throw new InvalidDataException("service is a required property for GetAcceptedSender200Response and cannot be null");
            }
            else
            {
                this.Service = service;
            }

            // to ensure "serviceRef" is required (not null)
            if (serviceRef == null)
            {
                throw new InvalidDataException("serviceRef is a required property for GetAcceptedSender200Response and cannot be null");
            }
            else
            {
                this.ServiceRef = serviceRef;
            }

            // to ensure "_ref" is required (not null)
            if (_ref == null)
            {
                throw new InvalidDataException("_ref is a required property for GetAcceptedSender200Response and cannot be null");
            }
            else
            {
                this.Ref = _ref;
            }

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
        [DataMember(Name="object", EmitDefaultValue=true)]
        public string Object { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="service", EmitDefaultValue=true)]
        public string Service { get; set; }

        /// <summary>
        /// Gets or Sets ServiceRef
        /// </summary>
        [DataMember(Name="serviceRef", EmitDefaultValue=true)]
        public string ServiceRef { get; set; }


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
            sb.Append("class GetAcceptedSender200Response {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  ServiceRef: ").Append(ServiceRef).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
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
            return this.Equals(input as GetAcceptedSender200Response);
        }

        /// <summary>
        /// Returns true if GetAcceptedSender200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAcceptedSender200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAcceptedSender200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.Service == input.Service ||
                    (this.Service != null &&
                    this.Service.Equals(input.Service))
                ) && 
                (
                    this.ServiceRef == input.ServiceRef ||
                    (this.ServiceRef != null &&
                    this.ServiceRef.Equals(input.ServiceRef))
                ) && 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
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
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.Service != null)
                    hashCode = hashCode * 59 + this.Service.GetHashCode();
                if (this.ServiceRef != null)
                    hashCode = hashCode * 59 + this.ServiceRef.GetHashCode();
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
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
            yield break;
        }
    }

}