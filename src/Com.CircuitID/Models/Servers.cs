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
    /// Servers
    /// </summary>
    [DataContract]
    public partial class Servers :  IEquatable<Servers>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sip for value: sip
            /// </summary>
            [EnumMember(Value = "sip")]
            Sip = 1,

            /// <summary>
            /// Enum Skype for value: skype
            /// </summary>
            [EnumMember(Value = "skype")]
            Skype = 2

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines NoInstantRingBack
        /// </summary>
        public enum NoInstantRingBackEnum
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
        /// Gets or Sets NoInstantRingBack
        /// </summary>
        [DataMember(Name="noInstantRingBack", EmitDefaultValue=false)]
        public NoInstantRingBackEnum? NoInstantRingBack { get; set; }
        /// <summary>
        /// Defines BypassMedia
        /// </summary>
        public enum BypassMediaEnum
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
        /// Gets or Sets BypassMedia
        /// </summary>
        [DataMember(Name="bypassMedia", EmitDefaultValue=false)]
        public BypassMediaEnum? BypassMedia { get; set; }
        /// <summary>
        /// Defines DisableRTPAutoAdjust
        /// </summary>
        public enum DisableRTPAutoAdjustEnum
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
        /// Gets or Sets DisableRTPAutoAdjust
        /// </summary>
        [DataMember(Name="disableRTPAutoAdjust", EmitDefaultValue=false)]
        public DisableRTPAutoAdjustEnum? DisableRTPAutoAdjust { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Servers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Servers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Servers" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="host">host (required).</param>
        /// <param name="port">port (required) (default to 5060).</param>
        /// <param name="callerId">callerId.</param>
        /// <param name="type">type (required).</param>
        /// <param name="domesticOutboundCallLimit">domesticOutboundCallLimit (required) (default to 10).</param>
        /// <param name="domesticInboundCallLimit">domesticInboundCallLimit (required) (default to 10).</param>
        /// <param name="internationalOutboundCallLimit">internationalOutboundCallLimit (required) (default to 10).</param>
        /// <param name="tollFreeChannelLimit">tollFreeChannelLimit (required) (default to 10).</param>
        /// <param name="inboundSipTrunkingOrder">ObjectId (unique 12 bytes ID).</param>
        /// <param name="outboundSipTrunkingOrder">ObjectId (unique 12 bytes ID).</param>
        /// <param name="noInstantRingBack">noInstantRingBack.</param>
        /// <param name="bypassMedia">bypassMedia (default to BypassMediaEnum.NUMBER_0).</param>
        /// <param name="disableRTPAutoAdjust">disableRTPAutoAdjust (default to DisableRTPAutoAdjustEnum.NUMBER_0).</param>
        public Servers(string name = default(string), string host = default(string), int port = 5060, string callerId = default(string), TypeEnum type = default(TypeEnum), int domesticOutboundCallLimit = 10, int domesticInboundCallLimit = 10, int internationalOutboundCallLimit = 10, int tollFreeChannelLimit = 10, string inboundSipTrunkingOrder = default(string), string outboundSipTrunkingOrder = default(string), NoInstantRingBackEnum? noInstantRingBack = default(NoInstantRingBackEnum?), BypassMediaEnum? bypassMedia = BypassMediaEnum.NUMBER_0, DisableRTPAutoAdjustEnum? disableRTPAutoAdjust = DisableRTPAutoAdjustEnum.NUMBER_0)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Servers and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "host" is required (not null)
            if (host == null)
            {
                throw new InvalidDataException("host is a required property for Servers and cannot be null");
            }
            else
            {
                this.Host = host;
            }

            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new InvalidDataException("port is a required property for Servers and cannot be null");
            }
            else
            {
                this.Port = port;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Servers and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "domesticOutboundCallLimit" is required (not null)
            if (domesticOutboundCallLimit == null)
            {
                throw new InvalidDataException("domesticOutboundCallLimit is a required property for Servers and cannot be null");
            }
            else
            {
                this.DomesticOutboundCallLimit = domesticOutboundCallLimit;
            }

            // to ensure "domesticInboundCallLimit" is required (not null)
            if (domesticInboundCallLimit == null)
            {
                throw new InvalidDataException("domesticInboundCallLimit is a required property for Servers and cannot be null");
            }
            else
            {
                this.DomesticInboundCallLimit = domesticInboundCallLimit;
            }

            // to ensure "internationalOutboundCallLimit" is required (not null)
            if (internationalOutboundCallLimit == null)
            {
                throw new InvalidDataException("internationalOutboundCallLimit is a required property for Servers and cannot be null");
            }
            else
            {
                this.InternationalOutboundCallLimit = internationalOutboundCallLimit;
            }

            // to ensure "tollFreeChannelLimit" is required (not null)
            if (tollFreeChannelLimit == null)
            {
                throw new InvalidDataException("tollFreeChannelLimit is a required property for Servers and cannot be null");
            }
            else
            {
                this.TollFreeChannelLimit = tollFreeChannelLimit;
            }

            this.CallerId = callerId;
            this.InboundSipTrunkingOrder = inboundSipTrunkingOrder;
            this.OutboundSipTrunkingOrder = outboundSipTrunkingOrder;
            this.NoInstantRingBack = noInstantRingBack;
            // use default value if no "bypassMedia" provided
            if (bypassMedia == null)
            {
                this.BypassMedia = BypassMediaEnum.NUMBER_0;
            }
            else
            {
                this.BypassMedia = bypassMedia;
            }
            // use default value if no "disableRTPAutoAdjust" provided
            if (disableRTPAutoAdjust == null)
            {
                this.DisableRTPAutoAdjust = DisableRTPAutoAdjustEnum.NUMBER_0;
            }
            else
            {
                this.DisableRTPAutoAdjust = disableRTPAutoAdjust;
            }
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=true)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=true)]
        public int Port { get; set; }

        /// <summary>
        /// Gets or Sets CallerId
        /// </summary>
        [DataMember(Name="callerId", EmitDefaultValue=false)]
        public string CallerId { get; set; }


        /// <summary>
        /// Gets or Sets DomesticOutboundCallLimit
        /// </summary>
        [DataMember(Name="domesticOutboundCallLimit", EmitDefaultValue=true)]
        public int DomesticOutboundCallLimit { get; set; }

        /// <summary>
        /// Gets or Sets DomesticInboundCallLimit
        /// </summary>
        [DataMember(Name="domesticInboundCallLimit", EmitDefaultValue=true)]
        public int DomesticInboundCallLimit { get; set; }

        /// <summary>
        /// Gets or Sets InternationalOutboundCallLimit
        /// </summary>
        [DataMember(Name="internationalOutboundCallLimit", EmitDefaultValue=true)]
        public int InternationalOutboundCallLimit { get; set; }

        /// <summary>
        /// Gets or Sets TollFreeChannelLimit
        /// </summary>
        [DataMember(Name="tollFreeChannelLimit", EmitDefaultValue=true)]
        public int TollFreeChannelLimit { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="inboundSipTrunkingOrder", EmitDefaultValue=false)]
        public string InboundSipTrunkingOrder { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="outboundSipTrunkingOrder", EmitDefaultValue=false)]
        public string OutboundSipTrunkingOrder { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Servers {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  CallerId: ").Append(CallerId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DomesticOutboundCallLimit: ").Append(DomesticOutboundCallLimit).Append("\n");
            sb.Append("  DomesticInboundCallLimit: ").Append(DomesticInboundCallLimit).Append("\n");
            sb.Append("  InternationalOutboundCallLimit: ").Append(InternationalOutboundCallLimit).Append("\n");
            sb.Append("  TollFreeChannelLimit: ").Append(TollFreeChannelLimit).Append("\n");
            sb.Append("  InboundSipTrunkingOrder: ").Append(InboundSipTrunkingOrder).Append("\n");
            sb.Append("  OutboundSipTrunkingOrder: ").Append(OutboundSipTrunkingOrder).Append("\n");
            sb.Append("  NoInstantRingBack: ").Append(NoInstantRingBack).Append("\n");
            sb.Append("  BypassMedia: ").Append(BypassMedia).Append("\n");
            sb.Append("  DisableRTPAutoAdjust: ").Append(DisableRTPAutoAdjust).Append("\n");
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
            return this.Equals(input as Servers);
        }

        /// <summary>
        /// Returns true if Servers instances are equal
        /// </summary>
        /// <param name="input">Instance of Servers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Servers input)
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
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.CallerId == input.CallerId ||
                    (this.CallerId != null &&
                    this.CallerId.Equals(input.CallerId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DomesticOutboundCallLimit == input.DomesticOutboundCallLimit ||
                    (this.DomesticOutboundCallLimit != null &&
                    this.DomesticOutboundCallLimit.Equals(input.DomesticOutboundCallLimit))
                ) && 
                (
                    this.DomesticInboundCallLimit == input.DomesticInboundCallLimit ||
                    (this.DomesticInboundCallLimit != null &&
                    this.DomesticInboundCallLimit.Equals(input.DomesticInboundCallLimit))
                ) && 
                (
                    this.InternationalOutboundCallLimit == input.InternationalOutboundCallLimit ||
                    (this.InternationalOutboundCallLimit != null &&
                    this.InternationalOutboundCallLimit.Equals(input.InternationalOutboundCallLimit))
                ) && 
                (
                    this.TollFreeChannelLimit == input.TollFreeChannelLimit ||
                    (this.TollFreeChannelLimit != null &&
                    this.TollFreeChannelLimit.Equals(input.TollFreeChannelLimit))
                ) && 
                (
                    this.InboundSipTrunkingOrder == input.InboundSipTrunkingOrder ||
                    (this.InboundSipTrunkingOrder != null &&
                    this.InboundSipTrunkingOrder.Equals(input.InboundSipTrunkingOrder))
                ) && 
                (
                    this.OutboundSipTrunkingOrder == input.OutboundSipTrunkingOrder ||
                    (this.OutboundSipTrunkingOrder != null &&
                    this.OutboundSipTrunkingOrder.Equals(input.OutboundSipTrunkingOrder))
                ) && 
                (
                    this.NoInstantRingBack == input.NoInstantRingBack ||
                    (this.NoInstantRingBack != null &&
                    this.NoInstantRingBack.Equals(input.NoInstantRingBack))
                ) && 
                (
                    this.BypassMedia == input.BypassMedia ||
                    (this.BypassMedia != null &&
                    this.BypassMedia.Equals(input.BypassMedia))
                ) && 
                (
                    this.DisableRTPAutoAdjust == input.DisableRTPAutoAdjust ||
                    (this.DisableRTPAutoAdjust != null &&
                    this.DisableRTPAutoAdjust.Equals(input.DisableRTPAutoAdjust))
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
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.CallerId != null)
                    hashCode = hashCode * 59 + this.CallerId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DomesticOutboundCallLimit != null)
                    hashCode = hashCode * 59 + this.DomesticOutboundCallLimit.GetHashCode();
                if (this.DomesticInboundCallLimit != null)
                    hashCode = hashCode * 59 + this.DomesticInboundCallLimit.GetHashCode();
                if (this.InternationalOutboundCallLimit != null)
                    hashCode = hashCode * 59 + this.InternationalOutboundCallLimit.GetHashCode();
                if (this.TollFreeChannelLimit != null)
                    hashCode = hashCode * 59 + this.TollFreeChannelLimit.GetHashCode();
                if (this.InboundSipTrunkingOrder != null)
                    hashCode = hashCode * 59 + this.InboundSipTrunkingOrder.GetHashCode();
                if (this.OutboundSipTrunkingOrder != null)
                    hashCode = hashCode * 59 + this.OutboundSipTrunkingOrder.GetHashCode();
                if (this.NoInstantRingBack != null)
                    hashCode = hashCode * 59 + this.NoInstantRingBack.GetHashCode();
                if (this.BypassMedia != null)
                    hashCode = hashCode * 59 + this.BypassMedia.GetHashCode();
                if (this.DisableRTPAutoAdjust != null)
                    hashCode = hashCode * 59 + this.DisableRTPAutoAdjust.GetHashCode();
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


            // Host (string) maxLength
            if(this.Host != null && this.Host.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Host, length must be less than 45.", new [] { "Host" });
            }

            // Host (string) minLength
            if(this.Host != null && this.Host.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Host, length must be greater than 5.", new [] { "Host" });
            }

            // CallerId (string) maxLength
            if(this.CallerId != null && this.CallerId.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallerId, length must be less than 45.", new [] { "CallerId" });
            }


            yield break;
        }
    }

}
