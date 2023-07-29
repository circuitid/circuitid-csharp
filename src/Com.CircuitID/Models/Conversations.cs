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
    /// Conversations
    /// </summary>
    [DataContract]
    public partial class Conversations :  IEquatable<Conversations>, IValidatableObject
    {
        /// <summary>
        /// Defines Channel
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 2,

            /// <summary>
            /// Enum Phone for value: phone
            /// </summary>
            [EnumMember(Value = "phone")]
            Phone = 3

        }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=true)]
        public ChannelEnum Channel { get; set; }
        /// <summary>
        /// Defines Ref
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefEnum
        {
            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            [EnumMember(Value = "contacts")]
            Contacts = 1,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 2

        }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=true)]
        public RefEnum Ref { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Resolved for value: resolved
            /// </summary>
            [EnumMember(Value = "resolved")]
            Resolved = 2

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Conversations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversations" /> class.
        /// </summary>
        /// <param name="contacts">contacts.</param>
        /// <param name="number">ObjectId (unique 12 bytes ID).</param>
        /// <param name="channel">channel (required).</param>
        /// <param name="_ref">_ref (required).</param>
        /// <param name="_object">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="status">status (required) (default to StatusEnum.Open).</param>
        public Conversations(List<Object> contacts = default(List<Object>), string number = default(string), ChannelEnum channel = default(ChannelEnum), RefEnum _ref = default(RefEnum), string _object = default(string), StatusEnum status = StatusEnum.Open)
        {
            // to ensure "channel" is required (not null)
            if (channel == null)
            {
                throw new InvalidDataException("channel is a required property for Conversations and cannot be null");
            }
            else
            {
                this.Channel = channel;
            }

            // to ensure "_ref" is required (not null)
            if (_ref == null)
            {
                throw new InvalidDataException("_ref is a required property for Conversations and cannot be null");
            }
            else
            {
                this.Ref = _ref;
            }

            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new InvalidDataException("_object is a required property for Conversations and cannot be null");
            }
            else
            {
                this.Object = _object;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Conversations and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            this.Contacts = contacts;
            this.Number = number;
        }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<Object> Contacts { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }



        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="object", EmitDefaultValue=true)]
        public string Object { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conversations {\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as Conversations);
        }

        /// <summary>
        /// Returns true if Conversations instances are equal
        /// </summary>
        /// <param name="input">Instance of Conversations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conversations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.Object != null)
                    hashCode = hashCode * 59 + this.Object.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
