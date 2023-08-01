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
    /// FindVirtualExtensions200Response
    /// </summary>
    [DataContract]
    public partial class FindVirtualExtensions200Response :  IEquatable<FindVirtualExtensions200Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindVirtualExtensions200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FindVirtualExtensions200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FindVirtualExtensions200Response" /> class.
        /// </summary>
        /// <param name="total">total (required).</param>
        /// <param name="limit">limit (required).</param>
        /// <param name="skip">skip (required).</param>
        /// <param name="data">data (required).</param>
        public FindVirtualExtensions200Response(int total = default(int), int limit = default(int), int skip = default(int), List<GetVirtualExtension200Response> data = default(List<GetVirtualExtension200Response>))
        {
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for FindVirtualExtensions200Response and cannot be null");
            }
            else
            {
                this.Total = total;
            }

            // to ensure "limit" is required (not null)
            if (limit == null)
            {
                throw new InvalidDataException("limit is a required property for FindVirtualExtensions200Response and cannot be null");
            }
            else
            {
                this.Limit = limit;
            }

            // to ensure "skip" is required (not null)
            if (skip == null)
            {
                throw new InvalidDataException("skip is a required property for FindVirtualExtensions200Response and cannot be null");
            }
            else
            {
                this.Skip = skip;
            }

            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for FindVirtualExtensions200Response and cannot be null");
            }
            else
            {
                this.Data = data;
            }

        }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=true)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Limit
        /// </summary>
        [DataMember(Name="limit", EmitDefaultValue=true)]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or Sets Skip
        /// </summary>
        [DataMember(Name="skip", EmitDefaultValue=true)]
        public int Skip { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public List<GetVirtualExtension200Response> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindVirtualExtensions200Response {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Skip: ").Append(Skip).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as FindVirtualExtensions200Response);
        }

        /// <summary>
        /// Returns true if FindVirtualExtensions200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of FindVirtualExtensions200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindVirtualExtensions200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Skip == input.Skip ||
                    (this.Skip != null &&
                    this.Skip.Equals(input.Skip))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Skip != null)
                    hashCode = hashCode * 59 + this.Skip.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
