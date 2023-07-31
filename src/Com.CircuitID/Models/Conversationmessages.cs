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
    /// Conversationmessages
    /// </summary>
    [DataContract]
    public partial class Conversationmessages :  IEquatable<Conversationmessages>, IValidatableObject
    {
        /// <summary>
        /// Defines Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Inbound for value: inbound
            /// </summary>
            [EnumMember(Value = "inbound")]
            Inbound = 1,

            /// <summary>
            /// Enum Outbound for value: outbound
            /// </summary>
            [EnumMember(Value = "outbound")]
            Outbound = 2

        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=true)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversationmessages" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Conversationmessages() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversationmessages" /> class.
        /// </summary>
        /// <param name="conversation">ObjectId (unique 12 bytes ID).</param>
        /// <param name="from">from (required).</param>
        /// <param name="fromNumber">fromNumber (required).</param>
        /// <param name="to">to (required).</param>
        /// <param name="text">text.</param>
        /// <param name="direction">direction (required).</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="referenceId">referenceId.</param>
        public Conversationmessages(string conversation = default(string), Object from = default(Object), string fromNumber = default(string), List<Object> to = default(List<Object>), string text = default(string), DirectionEnum direction = default(DirectionEnum), List<Object> attachments = default(List<Object>), string referenceId = default(string))
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for Conversationmessages and cannot be null");
            }
            else
            {
                this.From = from;
            }

            // to ensure "fromNumber" is required (not null)
            if (fromNumber == null)
            {
                throw new InvalidDataException("fromNumber is a required property for Conversationmessages and cannot be null");
            }
            else
            {
                this.FromNumber = fromNumber;
            }

            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for Conversationmessages and cannot be null");
            }
            else
            {
                this.To = to;
            }

            // to ensure "direction" is required (not null)
            if (direction == null)
            {
                throw new InvalidDataException("direction is a required property for Conversationmessages and cannot be null");
            }
            else
            {
                this.Direction = direction;
            }

            this.Conversation = conversation;
            this.Text = text;
            this.Attachments = attachments;
            this.ReferenceId = referenceId;
        }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="conversation", EmitDefaultValue=false)]
        public string Conversation { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name="from", EmitDefaultValue=true)]
        public Object From { get; set; }

        /// <summary>
        /// Gets or Sets FromNumber
        /// </summary>
        [DataMember(Name="fromNumber", EmitDefaultValue=true)]
        public string FromNumber { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name="to", EmitDefaultValue=true)]
        public List<Object> To { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }


        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<Object> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name="referenceId", EmitDefaultValue=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conversationmessages {\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromNumber: ").Append(FromNumber).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            return this.Equals(input as Conversationmessages);
        }

        /// <summary>
        /// Returns true if Conversationmessages instances are equal
        /// </summary>
        /// <param name="input">Instance of Conversationmessages to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conversationmessages input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Conversation == input.Conversation ||
                    (this.Conversation != null &&
                    this.Conversation.Equals(input.Conversation))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.FromNumber == input.FromNumber ||
                    (this.FromNumber != null &&
                    this.FromNumber.Equals(input.FromNumber))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
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
                if (this.Conversation != null)
                    hashCode = hashCode * 59 + this.Conversation.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.FromNumber != null)
                    hashCode = hashCode * 59 + this.FromNumber.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.ReferenceId != null)
                    hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
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
            // FromNumber (string) maxLength
            if(this.FromNumber != null && this.FromNumber.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FromNumber, length must be less than 40.", new [] { "FromNumber" });
            }


            // Text (string) maxLength
            if(this.Text != null && this.Text.Length > 2048)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be less than 2048.", new [] { "Text" });
            }


            // ReferenceId (string) maxLength
            if(this.ReferenceId != null && this.ReferenceId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReferenceId, length must be less than 255.", new [] { "ReferenceId" });
            }


            yield break;
        }
    }

}
