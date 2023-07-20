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
using OpenAPIDateConverter = circuitid-csharp.Client.OpenAPIDateConverter;

namespace circuitid-csharp.CircuitID
{
    /// <summary>
    /// Holidays
    /// </summary>
    [DataContract]
    public partial class Holidays :  IEquatable<Holidays>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            _1 = 1,

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            _0 = 0

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
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
            Announcements = announcements,

            /// <summary>
            /// Enum Directories for value: directories
            /// </summary>
            Directories = directories,

            /// <summary>
            /// Enum Park for value: park
            /// </summary>
            Park = park,

            /// <summary>
            /// Enum Numbers for value: numbers
            /// </summary>
            Numbers = numbers,

            /// <summary>
            /// Enum Menus for value: menus
            /// </summary>
            Menus = menus,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            Users = users,

            /// <summary>
            /// Enum Servers for value: servers
            /// </summary>
            Servers = servers,

            /// <summary>
            /// Enum Inboundrules for value: inboundrules
            /// </summary>
            Inboundrules = inboundrules,

            /// <summary>
            /// Enum Callqueues for value: callqueues
            /// </summary>
            Callqueues = callqueues,

            /// <summary>
            /// Enum Faxaccounts for value: faxaccounts
            /// </summary>
            Faxaccounts = faxaccounts,

            /// <summary>
            /// Enum Callforwarding for value: callforwarding
            /// </summary>
            Callforwarding = callforwarding,

            /// <summary>
            /// Enum Hangup for value: hangup
            /// </summary>
            Hangup = hangup,

            /// <summary>
            /// Enum Phoneinboundrules for value: phoneinboundrules
            /// </summary>
            Phoneinboundrules = phoneinboundrules,

            /// <summary>
            /// Enum Voicemailaccounts for value: voicemailaccounts
            /// </summary>
            Voicemailaccounts = voicemailaccounts

        }

        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name="destinationType", EmitDefaultValue=true)]
        public DestinationTypeEnum DestinationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Holidays" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Holidays() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Holidays" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="_object">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="objectRef">objectRef (required).</param>
        /// <param name="dateTimeRanges">dateTimeRanges (required).</param>
        /// <param name="status">status.</param>
        /// <param name="destinationType">destinationType (required).</param>
        /// <param name="destination">ObjectId (unique 12 bytes ID).</param>
        /// <param name="_ref">_ref.</param>
        /// <param name="callForwardingDestination">callForwardingDestination.</param>
        public Holidays(Object name = default(Object), Object _object = default(Object), Object objectRef = default(Object), Object dateTimeRanges = default(Object), StatusEnum? status = default(StatusEnum?), DestinationTypeEnum destinationType = default(DestinationTypeEnum), Object destination = default(Object), Object _ref = default(Object), Object callForwardingDestination = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Holidays and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Name = name;
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for Holidays and cannot be null");
            }
            else
            {
                this.Object = _object;
            }

            this.Object = _object;
            // to ensure "objectRef" is required (not null)
            if (objectRef == null)
            {
                throw new InvalidDataException("objectRef is a required property for Holidays and cannot be null");
            }
            else
            {
                this.ObjectRef = objectRef;
            }

            this.ObjectRef = objectRef;
            // to ensure "dateTimeRanges" is required (not null)
            if (dateTimeRanges == null)
            {
                throw new InvalidDataException("dateTimeRanges is a required property for Holidays and cannot be null");
            }
            else
            {
                this.DateTimeRanges = dateTimeRanges;
            }

            this.DateTimeRanges = dateTimeRanges;
            this.Status = status;
            // to ensure "destinationType" is required (not null)
            if (destinationType == null)
            {
                throw new InvalidDataException("destinationType is a required property for Holidays and cannot be null");
            }
            else
            {
                this.DestinationType = destinationType;
            }

            this.DestinationType = destinationType;
            this.Destination = destination;
            this.Ref = _ref;
            this.CallForwardingDestination = callForwardingDestination;
            this.Status = status;
            this.Destination = destination;
            this.Ref = _ref;
            this.CallForwardingDestination = callForwardingDestination;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Object Name { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="object", EmitDefaultValue=true)]
        public Object Object { get; set; }

        /// <summary>
        /// Gets or Sets ObjectRef
        /// </summary>
        [DataMember(Name="objectRef", EmitDefaultValue=true)]
        public Object ObjectRef { get; set; }

        /// <summary>
        /// Gets or Sets DateTimeRanges
        /// </summary>
        [DataMember(Name="dateTimeRanges", EmitDefaultValue=true)]
        public Object DateTimeRanges { get; set; }



        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="destination", EmitDefaultValue=true)]
        public Object Destination { get; set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=true)]
        public Object Ref { get; set; }

        /// <summary>
        /// Gets or Sets CallForwardingDestination
        /// </summary>
        [DataMember(Name="callForwardingDestination", EmitDefaultValue=true)]
        public Object CallForwardingDestination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Holidays {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ObjectRef: ").Append(ObjectRef).Append("\n");
            sb.Append("  DateTimeRanges: ").Append(DateTimeRanges).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
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
            return this.Equals(input as Holidays);
        }

        /// <summary>
        /// Returns true if Holidays instances are equal
        /// </summary>
        /// <param name="input">Instance of Holidays to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Holidays input)
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
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.ObjectRef == input.ObjectRef ||
                    (this.ObjectRef != null &&
                    this.ObjectRef.Equals(input.ObjectRef))
                ) && 
                (
                    this.DateTimeRanges == input.DateTimeRanges ||
                    (this.DateTimeRanges != null &&
                    this.DateTimeRanges.Equals(input.DateTimeRanges))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
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
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.ObjectRef != null)
                    hashCode = hashCode * 59 + this.ObjectRef.GetHashCode();
                if (this.DateTimeRanges != null)
                    hashCode = hashCode * 59 + this.DateTimeRanges.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
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
            // Name (Object) maxLength
            if(this.Name != null && this.Name.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 45.", new [] { "Name" });
            }


            // ObjectRef (Object) maxLength
            if(this.ObjectRef != null && this.ObjectRef.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ObjectRef, length must be less than 45.", new [] { "ObjectRef" });
            }

            // ObjectRef (Object) minLength
            if(this.ObjectRef != null && this.ObjectRef.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ObjectRef, length must be greater than 2.", new [] { "ObjectRef" });
            }

            // Ref (Object) maxLength
            if(this.Ref != null && this.Ref.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ref, length must be less than 100.", new [] { "Ref" });
            }

            // Ref (Object) minLength
            if(this.Ref != null && this.Ref.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ref, length must be greater than 5.", new [] { "Ref" });
            }

            // CallForwardingDestination (Object) maxLength
            if(this.CallForwardingDestination != null && this.CallForwardingDestination.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallForwardingDestination, length must be less than 45.", new [] { "CallForwardingDestination" });
            }

            // CallForwardingDestination (Object) minLength
            if(this.CallForwardingDestination != null && this.CallForwardingDestination.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallForwardingDestination, length must be greater than 10.", new [] { "CallForwardingDestination" });
            }

            yield break;
        }
    }

}
