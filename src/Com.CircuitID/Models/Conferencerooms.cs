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
    /// Conferencerooms
    /// </summary>
    [DataContract]
    public partial class Conferencerooms :  IEquatable<Conferencerooms>, IValidatableObject
    {
        /// <summary>
        /// Defines Lobby
        /// </summary>
        public enum LobbyEnum
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
        /// Gets or Sets Lobby
        /// </summary>
        [DataMember(Name="lobby", EmitDefaultValue=false)]
        public LobbyEnum? Lobby { get; set; }
        /// <summary>
        /// Defines RequirePasscode
        /// </summary>
        public enum RequirePasscodeEnum
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
        /// Gets or Sets RequirePasscode
        /// </summary>
        [DataMember(Name="requirePasscode", EmitDefaultValue=false)]
        public RequirePasscodeEnum? RequirePasscode { get; set; }
        /// <summary>
        /// Defines Share
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShareEnum
        {
            /// <summary>
            /// Enum Groups for value: groups
            /// </summary>
            [EnumMember(Value = "groups")]
            Groups = 1,

            /// <summary>
            /// Enum Customers for value: customers
            /// </summary>
            [EnumMember(Value = "customers")]
            Customers = 2

        }

        /// <summary>
        /// Gets or Sets Share
        /// </summary>
        [DataMember(Name="share", EmitDefaultValue=false)]
        public ShareEnum? Share { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conferencerooms" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Conferencerooms() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Conferencerooms" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="passcode">passcode.</param>
        /// <param name="dialInPin">dialInPin.</param>
        /// <param name="isUserRoom">isUserRoom.</param>
        /// <param name="isChatRoom">isChatRoom.</param>
        /// <param name="lobby">lobby (default to LobbyEnum.NUMBER_0).</param>
        /// <param name="requirePasscode">requirePasscode (default to RequirePasscodeEnum.NUMBER_0).</param>
        /// <param name="share">share.</param>
        /// <param name="chatroom">ObjectId (unique 12 bytes ID).</param>
        public Conferencerooms(string name = default(string), string passcode = default(string), int dialInPin = default(int), bool isUserRoom = default(bool), bool isChatRoom = default(bool), LobbyEnum? lobby = LobbyEnum.NUMBER_0, RequirePasscodeEnum? requirePasscode = RequirePasscodeEnum.NUMBER_0, ShareEnum? share = default(ShareEnum?), string chatroom = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Conferencerooms and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Passcode = passcode;
            this.DialInPin = dialInPin;
            this.IsUserRoom = isUserRoom;
            this.IsChatRoom = isChatRoom;
            // use default value if no "lobby" provided
            if (lobby == null)
            {
                this.Lobby = LobbyEnum.NUMBER_0;
            }
            else
            {
                this.Lobby = lobby;
            }
            // use default value if no "requirePasscode" provided
            if (requirePasscode == null)
            {
                this.RequirePasscode = RequirePasscodeEnum.NUMBER_0;
            }
            else
            {
                this.RequirePasscode = requirePasscode;
            }
            this.Share = share;
            this.Chatroom = chatroom;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Passcode
        /// </summary>
        [DataMember(Name="passcode", EmitDefaultValue=false)]
        public string Passcode { get; set; }

        /// <summary>
        /// Gets or Sets DialInPin
        /// </summary>
        [DataMember(Name="dialInPin", EmitDefaultValue=false)]
        public int DialInPin { get; set; }

        /// <summary>
        /// Gets or Sets IsUserRoom
        /// </summary>
        [DataMember(Name="isUserRoom", EmitDefaultValue=false)]
        public bool IsUserRoom { get; set; }

        /// <summary>
        /// Gets or Sets IsChatRoom
        /// </summary>
        [DataMember(Name="isChatRoom", EmitDefaultValue=false)]
        public bool IsChatRoom { get; set; }




        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="chatroom", EmitDefaultValue=false)]
        public string Chatroom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Conferencerooms {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Passcode: ").Append(Passcode).Append("\n");
            sb.Append("  DialInPin: ").Append(DialInPin).Append("\n");
            sb.Append("  IsUserRoom: ").Append(IsUserRoom).Append("\n");
            sb.Append("  IsChatRoom: ").Append(IsChatRoom).Append("\n");
            sb.Append("  Lobby: ").Append(Lobby).Append("\n");
            sb.Append("  RequirePasscode: ").Append(RequirePasscode).Append("\n");
            sb.Append("  Share: ").Append(Share).Append("\n");
            sb.Append("  Chatroom: ").Append(Chatroom).Append("\n");
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
            return this.Equals(input as Conferencerooms);
        }

        /// <summary>
        /// Returns true if Conferencerooms instances are equal
        /// </summary>
        /// <param name="input">Instance of Conferencerooms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conferencerooms input)
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
                    this.Passcode == input.Passcode ||
                    (this.Passcode != null &&
                    this.Passcode.Equals(input.Passcode))
                ) && 
                (
                    this.DialInPin == input.DialInPin ||
                    (this.DialInPin != null &&
                    this.DialInPin.Equals(input.DialInPin))
                ) && 
                (
                    this.IsUserRoom == input.IsUserRoom ||
                    (this.IsUserRoom != null &&
                    this.IsUserRoom.Equals(input.IsUserRoom))
                ) && 
                (
                    this.IsChatRoom == input.IsChatRoom ||
                    (this.IsChatRoom != null &&
                    this.IsChatRoom.Equals(input.IsChatRoom))
                ) && 
                (
                    this.Lobby == input.Lobby ||
                    (this.Lobby != null &&
                    this.Lobby.Equals(input.Lobby))
                ) && 
                (
                    this.RequirePasscode == input.RequirePasscode ||
                    (this.RequirePasscode != null &&
                    this.RequirePasscode.Equals(input.RequirePasscode))
                ) && 
                (
                    this.Share == input.Share ||
                    (this.Share != null &&
                    this.Share.Equals(input.Share))
                ) && 
                (
                    this.Chatroom == input.Chatroom ||
                    (this.Chatroom != null &&
                    this.Chatroom.Equals(input.Chatroom))
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
                if (this.Passcode != null)
                    hashCode = hashCode * 59 + this.Passcode.GetHashCode();
                if (this.DialInPin != null)
                    hashCode = hashCode * 59 + this.DialInPin.GetHashCode();
                if (this.IsUserRoom != null)
                    hashCode = hashCode * 59 + this.IsUserRoom.GetHashCode();
                if (this.IsChatRoom != null)
                    hashCode = hashCode * 59 + this.IsChatRoom.GetHashCode();
                if (this.Lobby != null)
                    hashCode = hashCode * 59 + this.Lobby.GetHashCode();
                if (this.RequirePasscode != null)
                    hashCode = hashCode * 59 + this.RequirePasscode.GetHashCode();
                if (this.Share != null)
                    hashCode = hashCode * 59 + this.Share.GetHashCode();
                if (this.Chatroom != null)
                    hashCode = hashCode * 59 + this.Chatroom.GetHashCode();
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


            // Passcode (string) maxLength
            if(this.Passcode != null && this.Passcode.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Passcode, length must be less than 20.", new [] { "Passcode" });
            }

            // Passcode (string) minLength
            if(this.Passcode != null && this.Passcode.Length < 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Passcode, length must be greater than 6.", new [] { "Passcode" });
            }

            yield break;
        }
    }

}
