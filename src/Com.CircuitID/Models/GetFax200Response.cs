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
    /// GetFax200Response
    /// </summary>
    [DataContract]
    public partial class GetFax200Response :  IEquatable<GetFax200Response>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 1,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 2,

            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 3

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Send for value: send
            /// </summary>
            [EnumMember(Value = "send")]
            Send = 1,

            /// <summary>
            /// Enum Receive for value: receive
            /// </summary>
            [EnumMember(Value = "receive")]
            Receive = 2

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFax200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFax200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFax200Response" /> class.
        /// </summary>
        /// <param name="attachments">attachments.</param>
        /// <param name="callerDestinations">callerDestinations (required).</param>
        /// <param name="callerIdNumber">callerIdNumber (required).</param>
        /// <param name="callerDestination">callerDestination (required).</param>
        /// <param name="pages">pages (default to 0).</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="transferedPages">transferedPages (default to 0).</param>
        /// <param name="status">status (required) (default to StatusEnum.Processing).</param>
        /// <param name="error">error.</param>
        /// <param name="type">type (required).</param>
        /// <param name="order">ObjectId (unique 12 bytes ID).</param>
        /// <param name="file">ObjectId (unique 12 bytes ID).</param>
        /// <param name="contact">ObjectId (unique 12 bytes ID).</param>
        /// <param name="number">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="faxAccount">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="retries">retries (default to 0).</param>
        /// <param name="invoice">ObjectId (unique 12 bytes ID).</param>
        /// <param name="senderEmail">senderEmail.</param>
        /// <param name="senderName">senderName.</param>
        /// <param name="id">ObjectId (unique 12 bytes ID).</param>
        /// <param name="createdByUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="updatedByUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public GetFax200Response(List<string> attachments = default(List<string>), List<string> callerDestinations = default(List<string>), string callerIdNumber = default(string), string callerDestination = default(string), int pages = 0, int statusCode = default(int), int transferedPages = 0, StatusEnum status = StatusEnum.Processing, string error = default(string), TypeEnum type = default(TypeEnum), string order = default(string), string file = default(string), string contact = default(string), string number = default(string), string faxAccount = default(string), int retries = 0, string invoice = default(string), string senderEmail = default(string), string senderName = default(string), string id = default(string), string createdByUserId = default(string), string updatedByUserId = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            // to ensure "callerDestinations" is required (not null)
            if (callerDestinations == null)
            {
                throw new InvalidDataException("callerDestinations is a required property for GetFax200Response and cannot be null");
            }
            else
            {
                this.CallerDestinations = callerDestinations;
            }

            // to ensure "callerIdNumber" is required (not null)
            if (callerIdNumber == null)
            {
                throw new InvalidDataException("callerIdNumber is a required property for GetFax200Response and cannot be null");
            }
            else
            {
                this.CallerIdNumber = callerIdNumber;
            }

            // to ensure "callerDestination" is required (not null)
            if (callerDestination == null)
            {
                throw new InvalidDataException("callerDestination is a required property for GetFax200Response and cannot be null");
            }
            else
            {
                this.CallerDestination = callerDestination;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for GetFax200Response and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for GetFax200Response and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new InvalidDataException("number is a required property for GetFax200Response and cannot be null");
            }
            else
            {
                this.Number = number;
            }

            // to ensure "faxAccount" is required (not null)
            if (faxAccount == null)
            {
                throw new InvalidDataException("faxAccount is a required property for GetFax200Response and cannot be null");
            }
            else
            {
                this.FaxAccount = faxAccount;
            }

            this.Attachments = attachments;
            // use default value if no "pages" provided
            if (pages == null)
            {
                this.Pages = 0;
            }
            else
            {
                this.Pages = pages;
            }
            this.StatusCode = statusCode;
            // use default value if no "transferedPages" provided
            if (transferedPages == null)
            {
                this.TransferedPages = 0;
            }
            else
            {
                this.TransferedPages = transferedPages;
            }
            this.Error = error;
            this.Order = order;
            this.File = file;
            this.Contact = contact;
            // use default value if no "retries" provided
            if (retries == null)
            {
                this.Retries = 0;
            }
            else
            {
                this.Retries = retries;
            }
            this.Invoice = invoice;
            this.SenderEmail = senderEmail;
            this.SenderName = senderName;
            this.Id = id;
            this.CreatedByUserId = createdByUserId;
            this.UpdatedByUserId = updatedByUserId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets CallerDestinations
        /// </summary>
        [DataMember(Name="callerDestinations", EmitDefaultValue=true)]
        public List<string> CallerDestinations { get; set; }

        /// <summary>
        /// Gets or Sets CallerIdNumber
        /// </summary>
        [DataMember(Name="callerIdNumber", EmitDefaultValue=true)]
        public string CallerIdNumber { get; set; }

        /// <summary>
        /// Gets or Sets CallerDestination
        /// </summary>
        [DataMember(Name="callerDestination", EmitDefaultValue=true)]
        public string CallerDestination { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name="pages", EmitDefaultValue=false)]
        public int Pages { get; set; }

        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or Sets TransferedPages
        /// </summary>
        [DataMember(Name="transferedPages", EmitDefaultValue=false)]
        public int TransferedPages { get; set; }


        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }


        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="number", EmitDefaultValue=true)]
        public string Number { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="faxAccount", EmitDefaultValue=true)]
        public string FaxAccount { get; set; }

        /// <summary>
        /// Gets or Sets Retries
        /// </summary>
        [DataMember(Name="retries", EmitDefaultValue=false)]
        public int Retries { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public string Invoice { get; set; }

        /// <summary>
        /// Gets or Sets SenderEmail
        /// </summary>
        [DataMember(Name="senderEmail", EmitDefaultValue=false)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Gets or Sets SenderName
        /// </summary>
        [DataMember(Name="senderName", EmitDefaultValue=false)]
        public string SenderName { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="_id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="createdByUserId", EmitDefaultValue=false)]
        public string CreatedByUserId { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="updatedByUserId", EmitDefaultValue=false)]
        public string UpdatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFax200Response {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  CallerDestinations: ").Append(CallerDestinations).Append("\n");
            sb.Append("  CallerIdNumber: ").Append(CallerIdNumber).Append("\n");
            sb.Append("  CallerDestination: ").Append(CallerDestination).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  TransferedPages: ").Append(TransferedPages).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  FaxAccount: ").Append(FaxAccount).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
            sb.Append("  UpdatedByUserId: ").Append(UpdatedByUserId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as GetFax200Response);
        }

        /// <summary>
        /// Returns true if GetFax200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFax200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFax200Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.CallerDestinations == input.CallerDestinations ||
                    this.CallerDestinations != null &&
                    input.CallerDestinations != null &&
                    this.CallerDestinations.SequenceEqual(input.CallerDestinations)
                ) && 
                (
                    this.CallerIdNumber == input.CallerIdNumber ||
                    (this.CallerIdNumber != null &&
                    this.CallerIdNumber.Equals(input.CallerIdNumber))
                ) && 
                (
                    this.CallerDestination == input.CallerDestination ||
                    (this.CallerDestination != null &&
                    this.CallerDestination.Equals(input.CallerDestination))
                ) && 
                (
                    this.Pages == input.Pages ||
                    (this.Pages != null &&
                    this.Pages.Equals(input.Pages))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.TransferedPages == input.TransferedPages ||
                    (this.TransferedPages != null &&
                    this.TransferedPages.Equals(input.TransferedPages))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.FaxAccount == input.FaxAccount ||
                    (this.FaxAccount != null &&
                    this.FaxAccount.Equals(input.FaxAccount))
                ) && 
                (
                    this.Retries == input.Retries ||
                    (this.Retries != null &&
                    this.Retries.Equals(input.Retries))
                ) && 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
                ) && 
                (
                    this.SenderEmail == input.SenderEmail ||
                    (this.SenderEmail != null &&
                    this.SenderEmail.Equals(input.SenderEmail))
                ) && 
                (
                    this.SenderName == input.SenderName ||
                    (this.SenderName != null &&
                    this.SenderName.Equals(input.SenderName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedByUserId == input.CreatedByUserId ||
                    (this.CreatedByUserId != null &&
                    this.CreatedByUserId.Equals(input.CreatedByUserId))
                ) && 
                (
                    this.UpdatedByUserId == input.UpdatedByUserId ||
                    (this.UpdatedByUserId != null &&
                    this.UpdatedByUserId.Equals(input.UpdatedByUserId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.CallerDestinations != null)
                    hashCode = hashCode * 59 + this.CallerDestinations.GetHashCode();
                if (this.CallerIdNumber != null)
                    hashCode = hashCode * 59 + this.CallerIdNumber.GetHashCode();
                if (this.CallerDestination != null)
                    hashCode = hashCode * 59 + this.CallerDestination.GetHashCode();
                if (this.Pages != null)
                    hashCode = hashCode * 59 + this.Pages.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.TransferedPages != null)
                    hashCode = hashCode * 59 + this.TransferedPages.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.File != null)
                    hashCode = hashCode * 59 + this.File.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.FaxAccount != null)
                    hashCode = hashCode * 59 + this.FaxAccount.GetHashCode();
                if (this.Retries != null)
                    hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
                if (this.SenderEmail != null)
                    hashCode = hashCode * 59 + this.SenderEmail.GetHashCode();
                if (this.SenderName != null)
                    hashCode = hashCode * 59 + this.SenderName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedByUserId != null)
                    hashCode = hashCode * 59 + this.CreatedByUserId.GetHashCode();
                if (this.UpdatedByUserId != null)
                    hashCode = hashCode * 59 + this.UpdatedByUserId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
            // CallerIdNumber (string) maxLength
            if(this.CallerIdNumber != null && this.CallerIdNumber.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallerIdNumber, length must be less than 45.", new [] { "CallerIdNumber" });
            }


            // CallerDestination (string) maxLength
            if(this.CallerDestination != null && this.CallerDestination.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallerDestination, length must be less than 45.", new [] { "CallerDestination" });
            }


            // Error (string) maxLength
            if(this.Error != null && this.Error.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Error, length must be less than 255.", new [] { "Error" });
            }


            // SenderEmail (string) maxLength
            if(this.SenderEmail != null && this.SenderEmail.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderEmail, length must be less than 45.", new [] { "SenderEmail" });
            }


            // SenderName (string) maxLength
            if(this.SenderName != null && this.SenderName.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderName, length must be less than 45.", new [] { "SenderName" });
            }


            yield break;
        }
    }

}
