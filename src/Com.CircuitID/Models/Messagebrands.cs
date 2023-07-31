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
    /// Messagebrands
    /// </summary>
    [DataContract]
    public partial class Messagebrands :  IEquatable<Messagebrands>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Verified for value: verified
            /// </summary>
            [EnumMember(Value = "verified")]
            Verified = 1,

            /// <summary>
            /// Enum Unverified for value: unverified
            /// </summary>
            [EnumMember(Value = "unverified")]
            Unverified = 2

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Messagebrands" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Messagebrands() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Messagebrands" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="brandId">brandId.</param>
        /// <param name="ein">ein (required).</param>
        /// <param name="user">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="order">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="status">status.</param>
        /// <param name="brandRelationship">brandRelationship.</param>
        /// <param name="vertical">vertical.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="cspId">cspId.</param>
        /// <param name="einIssuingCountry">einIssuingCountry.</param>
        /// <param name="universalEin">universalEin.</param>
        public Messagebrands(string name = default(string), string brandId = default(string), string ein = default(string), string user = default(string), string order = default(string), StatusEnum? status = default(StatusEnum?), string brandRelationship = default(string), string vertical = default(string), string entityType = default(string), string cspId = default(string), string einIssuingCountry = default(string), string universalEin = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Messagebrands and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "ein" is required (not null)
            if (ein == null)
            {
                throw new InvalidDataException("ein is a required property for Messagebrands and cannot be null");
            }
            else
            {
                this.Ein = ein;
            }

            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for Messagebrands and cannot be null");
            }
            else
            {
                this.User = user;
            }

            // to ensure "order" is required (not null)
            if (order == null)
            {
                throw new InvalidDataException("order is a required property for Messagebrands and cannot be null");
            }
            else
            {
                this.Order = order;
            }

            this.BrandId = brandId;
            this.Status = status;
            this.BrandRelationship = brandRelationship;
            this.Vertical = vertical;
            this.EntityType = entityType;
            this.CspId = cspId;
            this.EinIssuingCountry = einIssuingCountry;
            this.UniversalEin = universalEin;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets BrandId
        /// </summary>
        [DataMember(Name="brandId", EmitDefaultValue=false)]
        public string BrandId { get; set; }

        /// <summary>
        /// Gets or Sets Ein
        /// </summary>
        [DataMember(Name="ein", EmitDefaultValue=true)]
        public string Ein { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="order", EmitDefaultValue=true)]
        public string Order { get; set; }


        /// <summary>
        /// Gets or Sets BrandRelationship
        /// </summary>
        [DataMember(Name="brandRelationship", EmitDefaultValue=false)]
        public string BrandRelationship { get; set; }

        /// <summary>
        /// Gets or Sets Vertical
        /// </summary>
        [DataMember(Name="vertical", EmitDefaultValue=false)]
        public string Vertical { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or Sets CspId
        /// </summary>
        [DataMember(Name="cspId", EmitDefaultValue=false)]
        public string CspId { get; set; }

        /// <summary>
        /// Gets or Sets EinIssuingCountry
        /// </summary>
        [DataMember(Name="einIssuingCountry", EmitDefaultValue=false)]
        public string EinIssuingCountry { get; set; }

        /// <summary>
        /// Gets or Sets UniversalEin
        /// </summary>
        [DataMember(Name="universalEin", EmitDefaultValue=false)]
        public string UniversalEin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Messagebrands {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BrandId: ").Append(BrandId).Append("\n");
            sb.Append("  Ein: ").Append(Ein).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  BrandRelationship: ").Append(BrandRelationship).Append("\n");
            sb.Append("  Vertical: ").Append(Vertical).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  CspId: ").Append(CspId).Append("\n");
            sb.Append("  EinIssuingCountry: ").Append(EinIssuingCountry).Append("\n");
            sb.Append("  UniversalEin: ").Append(UniversalEin).Append("\n");
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
            return this.Equals(input as Messagebrands);
        }

        /// <summary>
        /// Returns true if Messagebrands instances are equal
        /// </summary>
        /// <param name="input">Instance of Messagebrands to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Messagebrands input)
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
                    this.BrandId == input.BrandId ||
                    (this.BrandId != null &&
                    this.BrandId.Equals(input.BrandId))
                ) && 
                (
                    this.Ein == input.Ein ||
                    (this.Ein != null &&
                    this.Ein.Equals(input.Ein))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.BrandRelationship == input.BrandRelationship ||
                    (this.BrandRelationship != null &&
                    this.BrandRelationship.Equals(input.BrandRelationship))
                ) && 
                (
                    this.Vertical == input.Vertical ||
                    (this.Vertical != null &&
                    this.Vertical.Equals(input.Vertical))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.CspId == input.CspId ||
                    (this.CspId != null &&
                    this.CspId.Equals(input.CspId))
                ) && 
                (
                    this.EinIssuingCountry == input.EinIssuingCountry ||
                    (this.EinIssuingCountry != null &&
                    this.EinIssuingCountry.Equals(input.EinIssuingCountry))
                ) && 
                (
                    this.UniversalEin == input.UniversalEin ||
                    (this.UniversalEin != null &&
                    this.UniversalEin.Equals(input.UniversalEin))
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
                if (this.BrandId != null)
                    hashCode = hashCode * 59 + this.BrandId.GetHashCode();
                if (this.Ein != null)
                    hashCode = hashCode * 59 + this.Ein.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BrandRelationship != null)
                    hashCode = hashCode * 59 + this.BrandRelationship.GetHashCode();
                if (this.Vertical != null)
                    hashCode = hashCode * 59 + this.Vertical.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.CspId != null)
                    hashCode = hashCode * 59 + this.CspId.GetHashCode();
                if (this.EinIssuingCountry != null)
                    hashCode = hashCode * 59 + this.EinIssuingCountry.GetHashCode();
                if (this.UniversalEin != null)
                    hashCode = hashCode * 59 + this.UniversalEin.GetHashCode();
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


            // BrandId (string) maxLength
            if(this.BrandId != null && this.BrandId.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BrandId, length must be less than 45.", new [] { "BrandId" });
            }


            // Ein (string) maxLength
            if(this.Ein != null && this.Ein.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ein, length must be less than 20.", new [] { "Ein" });
            }


            // BrandRelationship (string) maxLength
            if(this.BrandRelationship != null && this.BrandRelationship.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BrandRelationship, length must be less than 45.", new [] { "BrandRelationship" });
            }


            // Vertical (string) maxLength
            if(this.Vertical != null && this.Vertical.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Vertical, length must be less than 45.", new [] { "Vertical" });
            }


            // EntityType (string) maxLength
            if(this.EntityType != null && this.EntityType.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EntityType, length must be less than 45.", new [] { "EntityType" });
            }


            // CspId (string) maxLength
            if(this.CspId != null && this.CspId.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CspId, length must be less than 45.", new [] { "CspId" });
            }


            // EinIssuingCountry (string) maxLength
            if(this.EinIssuingCountry != null && this.EinIssuingCountry.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EinIssuingCountry, length must be less than 2.", new [] { "EinIssuingCountry" });
            }


            // UniversalEin (string) maxLength
            if(this.UniversalEin != null && this.UniversalEin.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UniversalEin, length must be less than 45.", new [] { "UniversalEin" });
            }


            yield break;
        }
    }

}
