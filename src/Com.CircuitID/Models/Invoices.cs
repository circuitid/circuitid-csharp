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
    /// Invoices
    /// </summary>
    [DataContract]
    public partial class Invoices :  IEquatable<Invoices>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Closed for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            Closed = 2,

            /// <summary>
            /// Enum Collection for value: collection
            /// </summary>
            [EnumMember(Value = "collection")]
            Collection = 3,

            /// <summary>
            /// Enum OnHold for value: onHold
            /// </summary>
            [EnumMember(Value = "onHold")]
            OnHold = 4,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 5

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoices" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Invoices() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoices" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="subtotal">subtotal (required).</param>
        /// <param name="tax">tax.</param>
        /// <param name="setup">setup.</param>
        /// <param name="discount">discount.</param>
        /// <param name="closedAt">closedAt.</param>
        /// <param name="dueAt">dueAt (required).</param>
        /// <param name="status">status (required) (default to StatusEnum.Open).</param>
        /// <param name="error">error.</param>
        public Invoices(int amount = default(int), int subtotal = default(int), int tax = default(int), int setup = default(int), int discount = default(int), DateTime closedAt = default(DateTime), DateTime dueAt = default(DateTime), StatusEnum status = StatusEnum.Open, string error = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for Invoices and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "subtotal" is required (not null)
            if (subtotal == null)
            {
                throw new InvalidDataException("subtotal is a required property for Invoices and cannot be null");
            }
            else
            {
                this.Subtotal = subtotal;
            }

            // to ensure "dueAt" is required (not null)
            if (dueAt == null)
            {
                throw new InvalidDataException("dueAt is a required property for Invoices and cannot be null");
            }
            else
            {
                this.DueAt = dueAt;
            }

            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for Invoices and cannot be null");
            }
            else
            {
                this.Status = status;
            }

            this.Tax = tax;
            this.Setup = setup;
            this.Discount = discount;
            this.ClosedAt = closedAt;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=true)]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or Sets Subtotal
        /// </summary>
        [DataMember(Name="subtotal", EmitDefaultValue=true)]
        public int Subtotal { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public int Tax { get; set; }

        /// <summary>
        /// Gets or Sets Setup
        /// </summary>
        [DataMember(Name="setup", EmitDefaultValue=false)]
        public int Setup { get; set; }

        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public int Discount { get; set; }

        /// <summary>
        /// Gets or Sets ClosedAt
        /// </summary>
        [DataMember(Name="closedAt", EmitDefaultValue=false)]
        public DateTime ClosedAt { get; set; }

        /// <summary>
        /// Gets or Sets DueAt
        /// </summary>
        [DataMember(Name="dueAt", EmitDefaultValue=true)]
        public DateTime DueAt { get; set; }


        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Invoices {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Subtotal: ").Append(Subtotal).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Setup: ").Append(Setup).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  DueAt: ").Append(DueAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
            return this.Equals(input as Invoices);
        }

        /// <summary>
        /// Returns true if Invoices instances are equal
        /// </summary>
        /// <param name="input">Instance of Invoices to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoices input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Subtotal == input.Subtotal ||
                    (this.Subtotal != null &&
                    this.Subtotal.Equals(input.Subtotal))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.Setup == input.Setup ||
                    (this.Setup != null &&
                    this.Setup.Equals(input.Setup))
                ) && 
                (
                    this.Discount == input.Discount ||
                    (this.Discount != null &&
                    this.Discount.Equals(input.Discount))
                ) && 
                (
                    this.ClosedAt == input.ClosedAt ||
                    (this.ClosedAt != null &&
                    this.ClosedAt.Equals(input.ClosedAt))
                ) && 
                (
                    this.DueAt == input.DueAt ||
                    (this.DueAt != null &&
                    this.DueAt.Equals(input.DueAt))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Subtotal != null)
                    hashCode = hashCode * 59 + this.Subtotal.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.Setup != null)
                    hashCode = hashCode * 59 + this.Setup.GetHashCode();
                if (this.Discount != null)
                    hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.ClosedAt != null)
                    hashCode = hashCode * 59 + this.ClosedAt.GetHashCode();
                if (this.DueAt != null)
                    hashCode = hashCode * 59 + this.DueAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
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
