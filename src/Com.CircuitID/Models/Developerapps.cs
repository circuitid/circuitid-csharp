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
    /// Developerapps
    /// </summary>
    [DataContract]
    public partial class Developerapps :  IEquatable<Developerapps>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Events for value: events
            /// </summary>
            [EnumMember(Value = "events")]
            Events = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Defines Visibility
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Enum Private for value: private
            /// </summary>
            [EnumMember(Value = "private")]
            Private = 1,

            /// <summary>
            /// Enum Public for value: public
            /// </summary>
            [EnumMember(Value = "public")]
            Public = 2

        }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name="visibility", EmitDefaultValue=true)]
        public VisibilityEnum Visibility { get; set; }
        /// <summary>
        /// Defines RequireId
        /// </summary>
        public enum RequireIdEnum
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
        /// Gets or Sets RequireId
        /// </summary>
        [DataMember(Name="requireId", EmitDefaultValue=false)]
        public RequireIdEnum? RequireId { get; set; }
        /// <summary>
        /// Defines IsFree
        /// </summary>
        public enum IsFreeEnum
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
        /// Gets or Sets IsFree
        /// </summary>
        [DataMember(Name="isFree", EmitDefaultValue=false)]
        public IsFreeEnum? IsFree { get; set; }
        /// <summary>
        /// Defines IntegrationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntegrationTypeEnum
        {
            /// <summary>
            /// Enum Webhook for value: webhook
            /// </summary>
            [EnumMember(Value = "webhook")]
            Webhook = 1,

            /// <summary>
            /// Enum Client for value: client
            /// </summary>
            [EnumMember(Value = "client")]
            Client = 2

        }

        /// <summary>
        /// Gets or Sets IntegrationType
        /// </summary>
        [DataMember(Name="integrationType", EmitDefaultValue=true)]
        public IntegrationTypeEnum IntegrationType { get; set; }
        /// <summary>
        /// Defines Services
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServicesEnum
        {
            /// <summary>
            /// Enum Calendarevents for value: calendarevents
            /// </summary>
            [EnumMember(Value = "calendarevents")]
            Calendarevents = 1,

            /// <summary>
            /// Enum Callqueues for value: callqueues
            /// </summary>
            [EnumMember(Value = "callqueues")]
            Callqueues = 2,

            /// <summary>
            /// Enum Cdrs for value: cdrs
            /// </summary>
            [EnumMember(Value = "cdrs")]
            Cdrs = 3,

            /// <summary>
            /// Enum Chatmessages for value: chatmessages
            /// </summary>
            [EnumMember(Value = "chatmessages")]
            Chatmessages = 4,

            /// <summary>
            /// Enum Contacts for value: contacts
            /// </summary>
            [EnumMember(Value = "contacts")]
            Contacts = 5,

            /// <summary>
            /// Enum Conversationmessages for value: conversationmessages
            /// </summary>
            [EnumMember(Value = "conversationmessages")]
            Conversationmessages = 6,

            /// <summary>
            /// Enum Faxes for value: faxes
            /// </summary>
            [EnumMember(Value = "faxes")]
            Faxes = 7,

            /// <summary>
            /// Enum Firewall for value: firewall
            /// </summary>
            [EnumMember(Value = "firewall")]
            Firewall = 8,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            [EnumMember(Value = "users")]
            Users = 9,

            /// <summary>
            /// Enum Voicemail for value: voicemail
            /// </summary>
            [EnumMember(Value = "voicemail")]
            Voicemail = 10

        }

        /// <summary>
        /// Defines Events
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventsEnum
        {
            /// <summary>
            /// Enum Create for value: create
            /// </summary>
            [EnumMember(Value = "create")]
            Create = 1,

            /// <summary>
            /// Enum Patch for value: patch
            /// </summary>
            [EnumMember(Value = "patch")]
            Patch = 2,

            /// <summary>
            /// Enum Removed for value: removed
            /// </summary>
            [EnumMember(Value = "removed")]
            Removed = 3

        }

        /// <summary>
        /// Defines WebhookAuthType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WebhookAuthTypeEnum
        {
            /// <summary>
            /// Enum Header for value: header
            /// </summary>
            [EnumMember(Value = "header")]
            Header = 1,

            /// <summary>
            /// Enum UsernameAndPassword for value: usernameAndPassword
            /// </summary>
            [EnumMember(Value = "usernameAndPassword")]
            UsernameAndPassword = 2

        }

        /// <summary>
        /// Gets or Sets WebhookAuthType
        /// </summary>
        [DataMember(Name="webhookAuthType", EmitDefaultValue=false)]
        public WebhookAuthTypeEnum? WebhookAuthType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Developerapps" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Developerapps() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Developerapps" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="type">type (required).</param>
        /// <param name="visibility">visibility (required).</param>
        /// <param name="requireId">requireId (default to RequireIdEnum.NUMBER_0).</param>
        /// <param name="isFree">isFree (default to IsFreeEnum.NUMBER_1).</param>
        /// <param name="feeDescription">feeDescription.</param>
        /// <param name="integrationType">integrationType (required).</param>
        /// <param name="services">services (required).</param>
        /// <param name="events">events.</param>
        /// <param name="user">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="webhookUrl">webhookUrl.</param>
        /// <param name="termsOfServiceUrl">termsOfServiceUrl.</param>
        /// <param name="privacyPolicyUrl">privacyPolicyUrl.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="webhookAuthType">webhookAuthType.</param>
        /// <param name="webhookUsername">webhookUsername.</param>
        /// <param name="webhookPassword">webhookPassword.</param>
        /// <param name="webhookTokenName">webhookTokenName.</param>
        /// <param name="webhookToken">webhookToken.</param>
        public Developerapps(string name = default(string), string description = default(string), TypeEnum type = default(TypeEnum), VisibilityEnum visibility = default(VisibilityEnum), RequireIdEnum? requireId = RequireIdEnum.NUMBER_0, IsFreeEnum? isFree = IsFreeEnum.NUMBER_1, string feeDescription = default(string), IntegrationTypeEnum integrationType = default(IntegrationTypeEnum), List<ServicesEnum> services = default(List<ServicesEnum>), List<EventsEnum> events = default(List<EventsEnum>), string user = default(string), string webhookUrl = default(string), string termsOfServiceUrl = default(string), string privacyPolicyUrl = default(string), Object permissions = default(Object), WebhookAuthTypeEnum? webhookAuthType = default(WebhookAuthTypeEnum?), string webhookUsername = default(string), string webhookPassword = default(string), string webhookTokenName = default(string), string webhookToken = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Developerapps and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Developerapps and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "visibility" is required (not null)
            if (visibility == null)
            {
                throw new InvalidDataException("visibility is a required property for Developerapps and cannot be null");
            }
            else
            {
                this.Visibility = visibility;
            }

            // to ensure "integrationType" is required (not null)
            if (integrationType == null)
            {
                throw new InvalidDataException("integrationType is a required property for Developerapps and cannot be null");
            }
            else
            {
                this.IntegrationType = integrationType;
            }

            // to ensure "services" is required (not null)
            if (services == null)
            {
                throw new InvalidDataException("services is a required property for Developerapps and cannot be null");
            }
            else
            {
                this.Services = services;
            }

            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new InvalidDataException("user is a required property for Developerapps and cannot be null");
            }
            else
            {
                this.User = user;
            }

            this.Description = description;
            // use default value if no "requireId" provided
            if (requireId == null)
            {
                this.RequireId = RequireIdEnum.NUMBER_0;
            }
            else
            {
                this.RequireId = requireId;
            }
            // use default value if no "isFree" provided
            if (isFree == null)
            {
                this.IsFree = IsFreeEnum.NUMBER_1;
            }
            else
            {
                this.IsFree = isFree;
            }
            this.FeeDescription = feeDescription;
            this.Events = events;
            this.WebhookUrl = webhookUrl;
            this.TermsOfServiceUrl = termsOfServiceUrl;
            this.PrivacyPolicyUrl = privacyPolicyUrl;
            this.Permissions = permissions;
            this.WebhookAuthType = webhookAuthType;
            this.WebhookUsername = webhookUsername;
            this.WebhookPassword = webhookPassword;
            this.WebhookTokenName = webhookTokenName;
            this.WebhookToken = webhookToken;
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
        /// Gets or Sets FeeDescription
        /// </summary>
        [DataMember(Name="feeDescription", EmitDefaultValue=false)]
        public string FeeDescription { get; set; }


        /// <summary>
        /// Gets or Sets Services
        /// </summary>
        [DataMember(Name="services", EmitDefaultValue=true)]
        public List<Developerapps.ServicesEnum> Services { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<Developerapps.EventsEnum> Events { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="user", EmitDefaultValue=true)]
        public string User { get; set; }

        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name="webhookUrl", EmitDefaultValue=false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets TermsOfServiceUrl
        /// </summary>
        [DataMember(Name="termsOfServiceUrl", EmitDefaultValue=false)]
        public string TermsOfServiceUrl { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyPolicyUrl
        /// </summary>
        [DataMember(Name="privacyPolicyUrl", EmitDefaultValue=false)]
        public string PrivacyPolicyUrl { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public Object Permissions { get; set; }


        /// <summary>
        /// Gets or Sets WebhookUsername
        /// </summary>
        [DataMember(Name="webhookUsername", EmitDefaultValue=false)]
        public string WebhookUsername { get; set; }

        /// <summary>
        /// Gets or Sets WebhookPassword
        /// </summary>
        [DataMember(Name="webhookPassword", EmitDefaultValue=false)]
        public string WebhookPassword { get; set; }

        /// <summary>
        /// Gets or Sets WebhookTokenName
        /// </summary>
        [DataMember(Name="webhookTokenName", EmitDefaultValue=false)]
        public string WebhookTokenName { get; set; }

        /// <summary>
        /// Gets or Sets WebhookToken
        /// </summary>
        [DataMember(Name="webhookToken", EmitDefaultValue=false)]
        public string WebhookToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Developerapps {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  RequireId: ").Append(RequireId).Append("\n");
            sb.Append("  IsFree: ").Append(IsFree).Append("\n");
            sb.Append("  FeeDescription: ").Append(FeeDescription).Append("\n");
            sb.Append("  IntegrationType: ").Append(IntegrationType).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  TermsOfServiceUrl: ").Append(TermsOfServiceUrl).Append("\n");
            sb.Append("  PrivacyPolicyUrl: ").Append(PrivacyPolicyUrl).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  WebhookAuthType: ").Append(WebhookAuthType).Append("\n");
            sb.Append("  WebhookUsername: ").Append(WebhookUsername).Append("\n");
            sb.Append("  WebhookPassword: ").Append(WebhookPassword).Append("\n");
            sb.Append("  WebhookTokenName: ").Append(WebhookTokenName).Append("\n");
            sb.Append("  WebhookToken: ").Append(WebhookToken).Append("\n");
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
            return this.Equals(input as Developerapps);
        }

        /// <summary>
        /// Returns true if Developerapps instances are equal
        /// </summary>
        /// <param name="input">Instance of Developerapps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Developerapps input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.RequireId == input.RequireId ||
                    (this.RequireId != null &&
                    this.RequireId.Equals(input.RequireId))
                ) && 
                (
                    this.IsFree == input.IsFree ||
                    (this.IsFree != null &&
                    this.IsFree.Equals(input.IsFree))
                ) && 
                (
                    this.FeeDescription == input.FeeDescription ||
                    (this.FeeDescription != null &&
                    this.FeeDescription.Equals(input.FeeDescription))
                ) && 
                (
                    this.IntegrationType == input.IntegrationType ||
                    (this.IntegrationType != null &&
                    this.IntegrationType.Equals(input.IntegrationType))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    input.Services != null &&
                    this.Services.SequenceEqual(input.Services)
                ) && 
                (
                    this.Events == input.Events ||
                    this.Events != null &&
                    input.Events != null &&
                    this.Events.SequenceEqual(input.Events)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.WebhookUrl == input.WebhookUrl ||
                    (this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(input.WebhookUrl))
                ) && 
                (
                    this.TermsOfServiceUrl == input.TermsOfServiceUrl ||
                    (this.TermsOfServiceUrl != null &&
                    this.TermsOfServiceUrl.Equals(input.TermsOfServiceUrl))
                ) && 
                (
                    this.PrivacyPolicyUrl == input.PrivacyPolicyUrl ||
                    (this.PrivacyPolicyUrl != null &&
                    this.PrivacyPolicyUrl.Equals(input.PrivacyPolicyUrl))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    (this.Permissions != null &&
                    this.Permissions.Equals(input.Permissions))
                ) && 
                (
                    this.WebhookAuthType == input.WebhookAuthType ||
                    (this.WebhookAuthType != null &&
                    this.WebhookAuthType.Equals(input.WebhookAuthType))
                ) && 
                (
                    this.WebhookUsername == input.WebhookUsername ||
                    (this.WebhookUsername != null &&
                    this.WebhookUsername.Equals(input.WebhookUsername))
                ) && 
                (
                    this.WebhookPassword == input.WebhookPassword ||
                    (this.WebhookPassword != null &&
                    this.WebhookPassword.Equals(input.WebhookPassword))
                ) && 
                (
                    this.WebhookTokenName == input.WebhookTokenName ||
                    (this.WebhookTokenName != null &&
                    this.WebhookTokenName.Equals(input.WebhookTokenName))
                ) && 
                (
                    this.WebhookToken == input.WebhookToken ||
                    (this.WebhookToken != null &&
                    this.WebhookToken.Equals(input.WebhookToken))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.RequireId != null)
                    hashCode = hashCode * 59 + this.RequireId.GetHashCode();
                if (this.IsFree != null)
                    hashCode = hashCode * 59 + this.IsFree.GetHashCode();
                if (this.FeeDescription != null)
                    hashCode = hashCode * 59 + this.FeeDescription.GetHashCode();
                if (this.IntegrationType != null)
                    hashCode = hashCode * 59 + this.IntegrationType.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.WebhookUrl != null)
                    hashCode = hashCode * 59 + this.WebhookUrl.GetHashCode();
                if (this.TermsOfServiceUrl != null)
                    hashCode = hashCode * 59 + this.TermsOfServiceUrl.GetHashCode();
                if (this.PrivacyPolicyUrl != null)
                    hashCode = hashCode * 59 + this.PrivacyPolicyUrl.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                if (this.WebhookAuthType != null)
                    hashCode = hashCode * 59 + this.WebhookAuthType.GetHashCode();
                if (this.WebhookUsername != null)
                    hashCode = hashCode * 59 + this.WebhookUsername.GetHashCode();
                if (this.WebhookPassword != null)
                    hashCode = hashCode * 59 + this.WebhookPassword.GetHashCode();
                if (this.WebhookTokenName != null)
                    hashCode = hashCode * 59 + this.WebhookTokenName.GetHashCode();
                if (this.WebhookToken != null)
                    hashCode = hashCode * 59 + this.WebhookToken.GetHashCode();
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
            if(this.Description != null && this.Description.Length > 4096)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 4096.", new [] { "Description" });
            }


            // FeeDescription (string) maxLength
            if(this.FeeDescription != null && this.FeeDescription.Length > 4096)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeeDescription, length must be less than 4096.", new [] { "FeeDescription" });
            }


            // WebhookUrl (string) maxLength
            if(this.WebhookUrl != null && this.WebhookUrl.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebhookUrl, length must be less than 1024.", new [] { "WebhookUrl" });
            }


            // TermsOfServiceUrl (string) maxLength
            if(this.TermsOfServiceUrl != null && this.TermsOfServiceUrl.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TermsOfServiceUrl, length must be less than 1024.", new [] { "TermsOfServiceUrl" });
            }


            // PrivacyPolicyUrl (string) maxLength
            if(this.PrivacyPolicyUrl != null && this.PrivacyPolicyUrl.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PrivacyPolicyUrl, length must be less than 1024.", new [] { "PrivacyPolicyUrl" });
            }


            // WebhookUsername (string) maxLength
            if(this.WebhookUsername != null && this.WebhookUsername.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebhookUsername, length must be less than 255.", new [] { "WebhookUsername" });
            }


            // WebhookPassword (string) maxLength
            if(this.WebhookPassword != null && this.WebhookPassword.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebhookPassword, length must be less than 255.", new [] { "WebhookPassword" });
            }


            // WebhookTokenName (string) maxLength
            if(this.WebhookTokenName != null && this.WebhookTokenName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebhookTokenName, length must be less than 255.", new [] { "WebhookTokenName" });
            }


            // WebhookToken (string) maxLength
            if(this.WebhookToken != null && this.WebhookToken.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebhookToken, length must be less than 255.", new [] { "WebhookToken" });
            }


            yield break;
        }
    }

}
