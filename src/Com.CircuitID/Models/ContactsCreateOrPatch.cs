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
    /// ContactsCreateOrPatch
    /// </summary>
    [DataContract]
    public partial class ContactsCreateOrPatch :  IEquatable<ContactsCreateOrPatch>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsCreateOrPatch" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactsCreateOrPatch() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsCreateOrPatch" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="first">first (required).</param>
        /// <param name="last">last.</param>
        /// <param name="mobilePhone">mobilePhone.</param>
        /// <param name="businessPhone">businessPhone.</param>
        /// <param name="faxPhone">faxPhone.</param>
        /// <param name="extension">extension.</param>
        /// <param name="jobTitle">jobTitle.</param>
        /// <param name="department">department.</param>
        /// <param name="avatar">avatar.</param>
        public ContactsCreateOrPatch(string email = default(string), string first = default(string), string last = default(string), string mobilePhone = default(string), string businessPhone = default(string), string faxPhone = default(string), int extension = default(int), string jobTitle = default(string), string department = default(string), string avatar = default(string))
        {
            // to ensure "first" is required (not null)
            if (first == null)
            {
                throw new InvalidDataException("first is a required property for ContactsCreateOrPatch and cannot be null");
            }
            else
            {
                this.First = first;
            }

            this.Email = email;
            this.Last = last;
            this.MobilePhone = mobilePhone;
            this.BusinessPhone = businessPhone;
            this.FaxPhone = faxPhone;
            this.Extension = extension;
            this.JobTitle = jobTitle;
            this.Department = department;
            this.Avatar = avatar;
        }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=true)]
        public string First { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public string Last { get; set; }

        /// <summary>
        /// Gets or Sets MobilePhone
        /// </summary>
        [DataMember(Name="mobilePhone", EmitDefaultValue=false)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or Sets BusinessPhone
        /// </summary>
        [DataMember(Name="businessPhone", EmitDefaultValue=false)]
        public string BusinessPhone { get; set; }

        /// <summary>
        /// Gets or Sets FaxPhone
        /// </summary>
        [DataMember(Name="faxPhone", EmitDefaultValue=false)]
        public string FaxPhone { get; set; }

        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public int Extension { get; set; }

        /// <summary>
        /// Gets or Sets JobTitle
        /// </summary>
        [DataMember(Name="jobTitle", EmitDefaultValue=false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Gets or Sets Department
        /// </summary>
        [DataMember(Name="department", EmitDefaultValue=false)]
        public string Department { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactsCreateOrPatch {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  MobilePhone: ").Append(MobilePhone).Append("\n");
            sb.Append("  BusinessPhone: ").Append(BusinessPhone).Append("\n");
            sb.Append("  FaxPhone: ").Append(FaxPhone).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Department: ").Append(Department).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
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
            return this.Equals(input as ContactsCreateOrPatch);
        }

        /// <summary>
        /// Returns true if ContactsCreateOrPatch instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactsCreateOrPatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactsCreateOrPatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.MobilePhone == input.MobilePhone ||
                    (this.MobilePhone != null &&
                    this.MobilePhone.Equals(input.MobilePhone))
                ) && 
                (
                    this.BusinessPhone == input.BusinessPhone ||
                    (this.BusinessPhone != null &&
                    this.BusinessPhone.Equals(input.BusinessPhone))
                ) && 
                (
                    this.FaxPhone == input.FaxPhone ||
                    (this.FaxPhone != null &&
                    this.FaxPhone.Equals(input.FaxPhone))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.Department == input.Department ||
                    (this.Department != null &&
                    this.Department.Equals(input.Department))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.MobilePhone != null)
                    hashCode = hashCode * 59 + this.MobilePhone.GetHashCode();
                if (this.BusinessPhone != null)
                    hashCode = hashCode * 59 + this.BusinessPhone.GetHashCode();
                if (this.FaxPhone != null)
                    hashCode = hashCode * 59 + this.FaxPhone.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.Department != null)
                    hashCode = hashCode * 59 + this.Department.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
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
            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 45.", new [] { "Email" });
            }


            // First (string) maxLength
            if(this.First != null && this.First.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for First, length must be less than 45.", new [] { "First" });
            }


            // Last (string) maxLength
            if(this.Last != null && this.Last.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Last, length must be less than 45.", new [] { "Last" });
            }


            // MobilePhone (string) maxLength
            if(this.MobilePhone != null && this.MobilePhone.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MobilePhone, length must be less than 20.", new [] { "MobilePhone" });
            }


            // BusinessPhone (string) maxLength
            if(this.BusinessPhone != null && this.BusinessPhone.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BusinessPhone, length must be less than 20.", new [] { "BusinessPhone" });
            }


            // FaxPhone (string) maxLength
            if(this.FaxPhone != null && this.FaxPhone.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FaxPhone, length must be less than 20.", new [] { "FaxPhone" });
            }


            // JobTitle (string) maxLength
            if(this.JobTitle != null && this.JobTitle.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for JobTitle, length must be less than 45.", new [] { "JobTitle" });
            }


            // Department (string) maxLength
            if(this.Department != null && this.Department.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Department, length must be less than 45.", new [] { "Department" });
            }


            // Avatar (string) maxLength
            if(this.Avatar != null && this.Avatar.Length > 512)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Avatar, length must be less than 512.", new [] { "Avatar" });
            }


            yield break;
        }
    }

}
