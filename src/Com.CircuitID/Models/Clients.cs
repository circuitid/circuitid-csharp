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
    /// Clients
    /// </summary>
    [DataContract]
    public partial class Clients :  IEquatable<Clients>, IValidatableObject
    {
        /// <summary>
        /// Defines Manufacture
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ManufactureEnum
        {
            /// <summary>
            /// Enum Cisco for value: cisco
            /// </summary>
            [EnumMember(Value = "cisco")]
            Cisco = 1,

            /// <summary>
            /// Enum Grandstream for value: grandstream
            /// </summary>
            [EnumMember(Value = "grandstream")]
            Grandstream = 2,

            /// <summary>
            /// Enum Polycom for value: polycom
            /// </summary>
            [EnumMember(Value = "polycom")]
            Polycom = 3

        }

        /// <summary>
        /// Gets or Sets Manufacture
        /// </summary>
        [DataMember(Name="manufacture", EmitDefaultValue=false)]
        public ManufactureEnum? Manufacture { get; set; }
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
        /// Initializes a new instance of the <see cref="Clients" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Clients() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Clients" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="user">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="mac">mac (required).</param>
        /// <param name="httpUserAgent">httpUserAgent.</param>
        /// <param name="manufacture">manufacture.</param>
        /// <param name="status">status (default to StatusEnum.NUMBER_1).</param>
        public Clients(string name = default(string), string user = default(string), string mac = default(string), string httpUserAgent = default(string), ManufactureEnum? manufacture = default(ManufactureEnum?), StatusEnum? status = StatusEnum.NUMBER_1)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Clients and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for Clients and cannot be null");
            }
            else
            {
                this.User = user;
            }

            // to ensure "mac" is required (not null)
            if (mac == null)
            {
                throw new InvalidDataException("mac is a required property for Clients and cannot be null");
            }
            else
            {
                this.Mac = mac;
            }

            this.HttpUserAgent = httpUserAgent;
            this.Manufacture = manufacture;
            // use default value if no "status" provided
            if (status == null)
            {
                this.Status = StatusEnum.NUMBER_1;
            }
            else
            {
                this.Status = status;
            }
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
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets Mac
        /// </summary>
        [DataMember(Name="mac", EmitDefaultValue=true)]
        public string Mac { get; set; }

        /// <summary>
        /// Gets or Sets HttpUserAgent
        /// </summary>
        [DataMember(Name="httpUserAgent", EmitDefaultValue=false)]
        public string HttpUserAgent { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Clients {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Mac: ").Append(Mac).Append("\n");
            sb.Append("  HttpUserAgent: ").Append(HttpUserAgent).Append("\n");
            sb.Append("  Manufacture: ").Append(Manufacture).Append("\n");
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
            return this.Equals(input as Clients);
        }

        /// <summary>
        /// Returns true if Clients instances are equal
        /// </summary>
        /// <param name="input">Instance of Clients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Clients input)
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
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Mac == input.Mac ||
                    (this.Mac != null &&
                    this.Mac.Equals(input.Mac))
                ) && 
                (
                    this.HttpUserAgent == input.HttpUserAgent ||
                    (this.HttpUserAgent != null &&
                    this.HttpUserAgent.Equals(input.HttpUserAgent))
                ) && 
                (
                    this.Manufacture == input.Manufacture ||
                    (this.Manufacture != null &&
                    this.Manufacture.Equals(input.Manufacture))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Mac != null)
                    hashCode = hashCode * 59 + this.Mac.GetHashCode();
                if (this.HttpUserAgent != null)
                    hashCode = hashCode * 59 + this.HttpUserAgent.GetHashCode();
                if (this.Manufacture != null)
                    hashCode = hashCode * 59 + this.Manufacture.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 45.", new [] { "Name" });
            }


            // Mac (string) maxLength
            if(this.Mac != null && this.Mac.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Mac, length must be less than 45.", new [] { "Mac" });
            }

            // Mac (string) minLength
            if(this.Mac != null && this.Mac.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Mac, length must be greater than 5.", new [] { "Mac" });
            }

            // HttpUserAgent (string) maxLength
            if(this.HttpUserAgent != null && this.HttpUserAgent.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpUserAgent, length must be less than 45.", new [] { "HttpUserAgent" });
            }

            // HttpUserAgent (string) minLength
            if(this.HttpUserAgent != null && this.HttpUserAgent.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpUserAgent, length must be greater than 1.", new [] { "HttpUserAgent" });
            }

            // Manufacture (string) maxLength
            if(this.Manufacture != null && this.Manufacture.ToString().Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Manufacture, length must be less than 20.", new [] { "Manufacture" });
            }

            // Manufacture (string) minLength
            if(this.Manufacture != null && this.Manufacture.ToString().Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Manufacture, length must be greater than 4.", new [] { "Manufacture" });
            }

            yield break;
        }
    }

}
