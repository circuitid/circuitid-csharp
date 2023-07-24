/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.15
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
    /// Firewall
    /// </summary>
    [DataContract]
    public partial class Firewall :  IEquatable<Firewall>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Allow for value: allow
            /// </summary>
            Allow = allow,

            /// <summary>
            /// Enum Deny for value: deny
            /// </summary>
            Deny = deny

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines Target
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TargetEnum
        {
            /// <summary>
            /// Enum Numbers for value: numbers
            /// </summary>
            Numbers = numbers,

            /// <summary>
            /// Enum Ipaddresses for value: ipaddresses
            /// </summary>
            Ipaddresses = ipaddresses,

            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            Sms = sms

        }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=true)]
        public TargetEnum Target { get; set; }
        /// <summary>
        /// Defines Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Enum Inbound for value: inbound
            /// </summary>
            Inbound = inbound,

            /// <summary>
            /// Enum Outbound for value: outbound
            /// </summary>
            Outbound = outbound,

            /// <summary>
            /// Enum Both for value: both
            /// </summary>
            Both = both

        }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=true)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// Defines Ai
        /// </summary>
        public enum AiEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            _0 = 0,

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            _1 = 1

        }

        /// <summary>
        /// Gets or Sets Ai
        /// </summary>
        [DataMember(Name="ai", EmitDefaultValue=true)]
        public AiEnum? Ai { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            _0 = 0,

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            _1 = 1

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Firewall" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Firewall() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Firewall" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="priority">priority (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="target">target (required).</param>
        /// <param name="direction">direction.</param>
        /// <param name="param">param (required).</param>
        /// <param name="hits">hits.</param>
        /// <param name="ai">ai.</param>
        /// <param name="status">status.</param>
        /// <param name="notificationHits">notificationHits.</param>
        public Firewall(Object name = default(Object), Object description = default(Object), Object priority = default(Object), TypeEnum type = default(TypeEnum), TargetEnum target = default(TargetEnum), DirectionEnum? direction = default(DirectionEnum?), Object param = default(Object), Object hits = default(Object), AiEnum? ai = default(AiEnum?), StatusEnum? status = default(StatusEnum?), Object notificationHits = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Firewall and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Name = name;
            this.Description = description;
            // to ensure "priority" is required (not null)
            if (priority == null)
            {
                throw new InvalidDataException("priority is a required property for Firewall and cannot be null");
            }
            else
            {
                this.Priority = priority;
            }

            this.Priority = priority;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Firewall and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            this.Type = type;
            // to ensure "target" is required (not null)
            if (target == null)
            {
                throw new InvalidDataException("target is a required property for Firewall and cannot be null");
            }
            else
            {
                this.Target = target;
            }

            this.Target = target;
            this.Direction = direction;
            // to ensure "param" is required (not null)
            if (param == null)
            {
                throw new InvalidDataException("param is a required property for Firewall and cannot be null");
            }
            else
            {
                this.Param = param;
            }

            this.Param = param;
            this.Hits = hits;
            this.Ai = ai;
            this.Status = status;
            this.NotificationHits = notificationHits;
            this.Description = description;
            this.Direction = direction;
            this.Hits = hits;
            this.Ai = ai;
            this.Status = status;
            this.NotificationHits = notificationHits;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Object Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public Object Description { get; set; }

        /// <summary>
        /// Gets or Sets Priority
        /// </summary>
        [DataMember(Name="priority", EmitDefaultValue=true)]
        public Object Priority { get; set; }




        /// <summary>
        /// Gets or Sets Param
        /// </summary>
        [DataMember(Name="param", EmitDefaultValue=true)]
        public Object Param { get; set; }

        /// <summary>
        /// Gets or Sets Hits
        /// </summary>
        [DataMember(Name="hits", EmitDefaultValue=true)]
        public Object Hits { get; set; }



        /// <summary>
        /// Gets or Sets NotificationHits
        /// </summary>
        [DataMember(Name="notificationHits", EmitDefaultValue=true)]
        public Object NotificationHits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Firewall {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Param: ").Append(Param).Append("\n");
            sb.Append("  Hits: ").Append(Hits).Append("\n");
            sb.Append("  Ai: ").Append(Ai).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  NotificationHits: ").Append(NotificationHits).Append("\n");
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
            return this.Equals(input as Firewall);
        }

        /// <summary>
        /// Returns true if Firewall instances are equal
        /// </summary>
        /// <param name="input">Instance of Firewall to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Firewall input)
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
                    this.Priority == input.Priority ||
                    (this.Priority != null &&
                    this.Priority.Equals(input.Priority))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Param == input.Param ||
                    (this.Param != null &&
                    this.Param.Equals(input.Param))
                ) && 
                (
                    this.Hits == input.Hits ||
                    (this.Hits != null &&
                    this.Hits.Equals(input.Hits))
                ) && 
                (
                    this.Ai == input.Ai ||
                    (this.Ai != null &&
                    this.Ai.Equals(input.Ai))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.NotificationHits == input.NotificationHits ||
                    (this.NotificationHits != null &&
                    this.NotificationHits.Equals(input.NotificationHits))
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
                if (this.Priority != null)
                    hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Param != null)
                    hashCode = hashCode * 59 + this.Param.GetHashCode();
                if (this.Hits != null)
                    hashCode = hashCode * 59 + this.Hits.GetHashCode();
                if (this.Ai != null)
                    hashCode = hashCode * 59 + this.Ai.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.NotificationHits != null)
                    hashCode = hashCode * 59 + this.NotificationHits.GetHashCode();
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


            // Description (Object) maxLength
            if(this.Description != null && this.Description.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 255.", new [] { "Description" });
            }


            // Param (Object) maxLength
            if(this.Param != null && this.Param.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Param, length must be less than 45.", new [] { "Param" });
            }

            // Param (Object) minLength
            if(this.Param != null && this.Param.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Param, length must be greater than 1.", new [] { "Param" });
            }

            yield break;
        }
    }

}
