/*
 * Circuit ID REST API
 *
 * # Introduction Circuit ID&reg; is an innovative cloud communications platform that redefines your connectivity experience. Our cutting-edge AI-powered solution seamlessly integrates calling, meetings, messaging, voicemail, fax, SIP Trunking, mobile broadband, and mobile phone services, accessible wherever you and your devices go.                  Whether you are a beginner getting started with our API or an experienced developer looking for advanced features, this documentation site will serve as your comprehensive guide.   We are excited to have you on board and are confident that this documentation site will empower you to leverage the full potential of our REST API.  If you have any questions or require further assistance, please don't hesitate to reach out to our support team.                  Happy coding!
 *
 * The version of the OpenAPI document: 0.47.17
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
    /// Numberports
    /// </summary>
    [DataContract]
    public partial class Numberports :  IEquatable<Numberports>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Numberports" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Numberports() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Numberports" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="typeOfService">typeOfService (required).</param>
        /// <param name="authorizedPerson">authorizedPerson (required).</param>
        /// <param name="desiredDueDate">desiredDueDate (required).</param>
        /// <param name="accountNumber">accountNumber (required).</param>
        /// <param name="accountPhoneNumber">accountPhoneNumber (required).</param>
        /// <param name="office">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="e911">e911.</param>
        /// <param name="invoice">ObjectId (unique 12 bytes ID) (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="destinationType">destinationType (required).</param>
        /// <param name="destination">ObjectId (unique 12 bytes ID).</param>
        /// <param name="_ref">_ref.</param>
        /// <param name="callForwardingDestination">callForwardingDestination.</param>
        public Numberports(Object name = default(Object), Object type = default(Object), Object typeOfService = default(Object), Object authorizedPerson = default(Object), Object desiredDueDate = default(Object), Object accountNumber = default(Object), Object accountPhoneNumber = default(Object), Object office = default(Object), Object e911 = default(Object), Object invoice = default(Object), Object status = default(Object), Object destinationType = default(Object), Object destination = default(Object), Object _ref = default(Object), Object callForwardingDestination = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Numberports and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Name = name;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Numberports and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            this.Type = type;
            // to ensure "typeOfService" is required (not null)
            if (typeOfService == null)
            {
                throw new InvalidDataException("typeOfService is a required property for Numberports and cannot be null");
            }
            else
            {
                this.TypeOfService = typeOfService;
            }

            this.TypeOfService = typeOfService;
            // to ensure "authorizedPerson" is required (not null)
            if (authorizedPerson == null)
            {
                throw new InvalidDataException("authorizedPerson is a required property for Numberports and cannot be null");
            }
            else
            {
                this.AuthorizedPerson = authorizedPerson;
            }

            this.AuthorizedPerson = authorizedPerson;
            // to ensure "desiredDueDate" is required (not null)
            if (desiredDueDate == null)
            {
                throw new InvalidDataException("desiredDueDate is a required property for Numberports and cannot be null");
            }
            else
            {
                this.DesiredDueDate = desiredDueDate;
            }

            this.DesiredDueDate = desiredDueDate;
            // to ensure "accountNumber" is required (not null)
            if (accountNumber == null)
            {
                throw new InvalidDataException("accountNumber is a required property for Numberports and cannot be null");
            }
            else
            {
                this.AccountNumber = accountNumber;
            }

            this.AccountNumber = accountNumber;
            // to ensure "accountPhoneNumber" is required (not null)
            if (accountPhoneNumber == null)
            {
                throw new InvalidDataException("accountPhoneNumber is a required property for Numberports and cannot be null");
            }
            else
            {
                this.AccountPhoneNumber = accountPhoneNumber;
            }

            this.AccountPhoneNumber = accountPhoneNumber;
            // to ensure "office" is required (not null)
            if (office == null)
            {
                throw new InvalidDataException("office is a required property for Numberports and cannot be null");
            }
            else
            {
                this.Office = office;
            }

            this.Office = office;
            this.E911 = e911;
            // to ensure "invoice" is required (not null)
            if (invoice == null)
            {
                throw new InvalidDataException("invoice is a required property for Numberports and cannot be null");
            }
            else
            {
                this.Invoice = invoice;
            }

            this.Invoice = invoice;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Numberports and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            this.Status = status;
            // to ensure "destinationType" is required (not null)
            if (destinationType == null)
            {
                throw new InvalidDataException("destinationType is a required property for Numberports and cannot be null");
            }
            else
            {
                this.DestinationType = destinationType;
            }

            this.DestinationType = destinationType;
            this.Destination = destination;
            this.Ref = _ref;
            this.CallForwardingDestination = callForwardingDestination;
            this.E911 = e911;
            this.Destination = destination;
            this.Ref = _ref;
            this.CallForwardingDestination = callForwardingDestination;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public Object Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public Object Type { get; set; }

        /// <summary>
        /// Gets or Sets TypeOfService
        /// </summary>
        [DataMember(Name="typeOfService", EmitDefaultValue=true)]
        public Object TypeOfService { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizedPerson
        /// </summary>
        [DataMember(Name="authorizedPerson", EmitDefaultValue=true)]
        public Object AuthorizedPerson { get; set; }

        /// <summary>
        /// Gets or Sets DesiredDueDate
        /// </summary>
        [DataMember(Name="desiredDueDate", EmitDefaultValue=true)]
        public Object DesiredDueDate { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=true)]
        public Object AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountPhoneNumber
        /// </summary>
        [DataMember(Name="accountPhoneNumber", EmitDefaultValue=true)]
        public Object AccountPhoneNumber { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="office", EmitDefaultValue=true)]
        public Object Office { get; set; }

        /// <summary>
        /// Gets or Sets E911
        /// </summary>
        [DataMember(Name="e911", EmitDefaultValue=true)]
        public Object E911 { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="invoice", EmitDefaultValue=true)]
        public Object Invoice { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public Object Status { get; set; }

        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name="destinationType", EmitDefaultValue=true)]
        public Object DestinationType { get; set; }

        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="destination", EmitDefaultValue=true)]
        public Object Destination { get; set; }

        /// <summary>
        /// Gets or Sets Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=true)]
        public Object Ref { get; set; }

        /// <summary>
        /// Gets or Sets CallForwardingDestination
        /// </summary>
        [DataMember(Name="callForwardingDestination", EmitDefaultValue=true)]
        public Object CallForwardingDestination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Numberports {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TypeOfService: ").Append(TypeOfService).Append("\n");
            sb.Append("  AuthorizedPerson: ").Append(AuthorizedPerson).Append("\n");
            sb.Append("  DesiredDueDate: ").Append(DesiredDueDate).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  AccountPhoneNumber: ").Append(AccountPhoneNumber).Append("\n");
            sb.Append("  Office: ").Append(Office).Append("\n");
            sb.Append("  E911: ").Append(E911).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DestinationType: ").Append(DestinationType).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Ref: ").Append(Ref).Append("\n");
            sb.Append("  CallForwardingDestination: ").Append(CallForwardingDestination).Append("\n");
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
            return this.Equals(input as Numberports);
        }

        /// <summary>
        /// Returns true if Numberports instances are equal
        /// </summary>
        /// <param name="input">Instance of Numberports to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Numberports input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TypeOfService == input.TypeOfService ||
                    (this.TypeOfService != null &&
                    this.TypeOfService.Equals(input.TypeOfService))
                ) && 
                (
                    this.AuthorizedPerson == input.AuthorizedPerson ||
                    (this.AuthorizedPerson != null &&
                    this.AuthorizedPerson.Equals(input.AuthorizedPerson))
                ) && 
                (
                    this.DesiredDueDate == input.DesiredDueDate ||
                    (this.DesiredDueDate != null &&
                    this.DesiredDueDate.Equals(input.DesiredDueDate))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.AccountPhoneNumber == input.AccountPhoneNumber ||
                    (this.AccountPhoneNumber != null &&
                    this.AccountPhoneNumber.Equals(input.AccountPhoneNumber))
                ) && 
                (
                    this.Office == input.Office ||
                    (this.Office != null &&
                    this.Office.Equals(input.Office))
                ) && 
                (
                    this.E911 == input.E911 ||
                    (this.E911 != null &&
                    this.E911.Equals(input.E911))
                ) && 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DestinationType == input.DestinationType ||
                    (this.DestinationType != null &&
                    this.DestinationType.Equals(input.DestinationType))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Ref == input.Ref ||
                    (this.Ref != null &&
                    this.Ref.Equals(input.Ref))
                ) && 
                (
                    this.CallForwardingDestination == input.CallForwardingDestination ||
                    (this.CallForwardingDestination != null &&
                    this.CallForwardingDestination.Equals(input.CallForwardingDestination))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeOfService != null)
                    hashCode = hashCode * 59 + this.TypeOfService.GetHashCode();
                if (this.AuthorizedPerson != null)
                    hashCode = hashCode * 59 + this.AuthorizedPerson.GetHashCode();
                if (this.DesiredDueDate != null)
                    hashCode = hashCode * 59 + this.DesiredDueDate.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                if (this.AccountPhoneNumber != null)
                    hashCode = hashCode * 59 + this.AccountPhoneNumber.GetHashCode();
                if (this.Office != null)
                    hashCode = hashCode * 59 + this.Office.GetHashCode();
                if (this.E911 != null)
                    hashCode = hashCode * 59 + this.E911.GetHashCode();
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DestinationType != null)
                    hashCode = hashCode * 59 + this.DestinationType.GetHashCode();
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Ref != null)
                    hashCode = hashCode * 59 + this.Ref.GetHashCode();
                if (this.CallForwardingDestination != null)
                    hashCode = hashCode * 59 + this.CallForwardingDestination.GetHashCode();
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


            // AuthorizedPerson (Object) maxLength
            if(this.AuthorizedPerson != null && this.AuthorizedPerson.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AuthorizedPerson, length must be less than 45.", new [] { "AuthorizedPerson" });
            }


            // AccountNumber (Object) maxLength
            if(this.AccountNumber != null && this.AccountNumber.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 45.", new [] { "AccountNumber" });
            }


            // AccountPhoneNumber (Object) maxLength
            if(this.AccountPhoneNumber != null && this.AccountPhoneNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountPhoneNumber, length must be less than 20.", new [] { "AccountPhoneNumber" });
            }

            // AccountPhoneNumber (Object) minLength
            if(this.AccountPhoneNumber != null && this.AccountPhoneNumber.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountPhoneNumber, length must be greater than 10.", new [] { "AccountPhoneNumber" });
            }

            // Ref (Object) maxLength
            if(this.Ref != null && this.Ref.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ref, length must be less than 100.", new [] { "Ref" });
            }

            // Ref (Object) minLength
            if(this.Ref != null && this.Ref.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ref, length must be greater than 5.", new [] { "Ref" });
            }

            // CallForwardingDestination (Object) maxLength
            if(this.CallForwardingDestination != null && this.CallForwardingDestination.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallForwardingDestination, length must be less than 45.", new [] { "CallForwardingDestination" });
            }

            // CallForwardingDestination (Object) minLength
            if(this.CallForwardingDestination != null && this.CallForwardingDestination.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CallForwardingDestination, length must be greater than 10.", new [] { "CallForwardingDestination" });
            }

            yield break;
        }
    }

}
