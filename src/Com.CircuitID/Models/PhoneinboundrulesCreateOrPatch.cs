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
    /// PhoneinboundrulesCreateOrPatch
    /// </summary>
    [DataContract]
    public partial class PhoneinboundrulesCreateOrPatch :  IEquatable<PhoneinboundrulesCreateOrPatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneinboundrulesCreateOrPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneinboundrulesCreateOrPatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneinboundrulesCreateOrPatch" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="outboundCallerId">outboundCallerId.</param>
        public PhoneinboundrulesCreateOrPatch(string name = default(string), string description = default(string), string outboundCallerId = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for PhoneinboundrulesCreateOrPatch and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Description = description;
            this.OutboundCallerId = outboundCallerId;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets OutboundCallerId
        /// </summary>
        [DataMember(Name="outboundCallerId", EmitDefaultValue=false)]
        public string OutboundCallerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneinboundrulesCreateOrPatch {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  OutboundCallerId: ").Append(OutboundCallerId).Append("\n");
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
            return this.Equals(input as PhoneinboundrulesCreateOrPatch);
        }

        /// <summary>
        /// Returns true if PhoneinboundrulesCreateOrPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneinboundrulesCreateOrPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneinboundrulesCreateOrPatch input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.OutboundCallerId == input.OutboundCallerId ||
                    (this.OutboundCallerId != null &&
                    this.OutboundCallerId.Equals(input.OutboundCallerId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OutboundCallerId != null)
                    hashCode = hashCode * 59 + this.OutboundCallerId.GetHashCode();
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


            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }


            // OutboundCallerId (string) maxLength
            if(this.OutboundCallerId != null && this.OutboundCallerId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OutboundCallerId, length must be less than 255.", new [] { "OutboundCallerId" });
            }

            // OutboundCallerId (string) minLength
            if(this.OutboundCallerId != null && this.OutboundCallerId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OutboundCallerId, length must be greater than 1.", new [] { "OutboundCallerId" });
            }

            yield break;
        }
    }

}
