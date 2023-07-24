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
    /// Menus
    /// </summary>
    [DataContract]
    public partial class Menus :  IEquatable<Menus>, IValidatableObject
    {
        /// <summary>
        /// Defines SpeechRecognition
        /// </summary>
        public enum SpeechRecognitionEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            _1 = 1,

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            _0 = 0

        }

        /// <summary>
        /// Gets or Sets SpeechRecognition
        /// </summary>
        [DataMember(Name="speechRecognition", EmitDefaultValue=true)]
        public SpeechRecognitionEnum? SpeechRecognition { get; set; }
        /// <summary>
        /// Defines GreetingType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GreetingTypeEnum
        {
            /// <summary>
            /// Enum Tts for value: tts
            /// </summary>
            Tts = tts,

            /// <summary>
            /// Enum Mp3 for value: mp3
            /// </summary>
            Mp3 = mp3

        }

        /// <summary>
        /// Gets or Sets GreetingType
        /// </summary>
        [DataMember(Name="greetingType", EmitDefaultValue=true)]
        public GreetingTypeEnum GreetingType { get; set; }
        /// <summary>
        /// Defines ExitSound
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExitSoundEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            Default = default,

            /// <summary>
            /// Enum Mp3 for value: mp3
            /// </summary>
            Mp3 = mp3

        }

        /// <summary>
        /// Gets or Sets ExitSound
        /// </summary>
        [DataMember(Name="exitSound", EmitDefaultValue=true)]
        public ExitSoundEnum? ExitSound { get; set; }
        /// <summary>
        /// Defines TransferAnnouncement
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferAnnouncementEnum
        {
            /// <summary>
            /// Enum Default for value: default
            /// </summary>
            Default = default,

            /// <summary>
            /// Enum Mp3 for value: mp3
            /// </summary>
            Mp3 = mp3,

            /// <summary>
            /// Enum None for value: none
            /// </summary>
            None = none

        }

        /// <summary>
        /// Gets or Sets TransferAnnouncement
        /// </summary>
        [DataMember(Name="transferAnnouncement", EmitDefaultValue=true)]
        public TransferAnnouncementEnum? TransferAnnouncement { get; set; }
        /// <summary>
        /// Defines TouchToneTerminators
        /// </summary>
        public enum TouchToneTerminatorsEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            _1 = 1,

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            _0 = 0

        }

        /// <summary>
        /// Gets or Sets TouchToneTerminators
        /// </summary>
        [DataMember(Name="touchToneTerminators", EmitDefaultValue=true)]
        public TouchToneTerminatorsEnum? TouchToneTerminators { get; set; }
        /// <summary>
        /// Defines DestinationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DestinationTypeEnum
        {
            /// <summary>
            /// Enum Announcements for value: announcements
            /// </summary>
            Announcements = announcements,

            /// <summary>
            /// Enum Directories for value: directories
            /// </summary>
            Directories = directories,

            /// <summary>
            /// Enum Park for value: park
            /// </summary>
            Park = park,

            /// <summary>
            /// Enum Numbers for value: numbers
            /// </summary>
            Numbers = numbers,

            /// <summary>
            /// Enum Menus for value: menus
            /// </summary>
            Menus = menus,

            /// <summary>
            /// Enum Users for value: users
            /// </summary>
            Users = users,

            /// <summary>
            /// Enum Servers for value: servers
            /// </summary>
            Servers = servers,

            /// <summary>
            /// Enum Inboundrules for value: inboundrules
            /// </summary>
            Inboundrules = inboundrules,

            /// <summary>
            /// Enum Callqueues for value: callqueues
            /// </summary>
            Callqueues = callqueues,

            /// <summary>
            /// Enum Faxaccounts for value: faxaccounts
            /// </summary>
            Faxaccounts = faxaccounts,

            /// <summary>
            /// Enum Callforwarding for value: callforwarding
            /// </summary>
            Callforwarding = callforwarding,

            /// <summary>
            /// Enum Hangup for value: hangup
            /// </summary>
            Hangup = hangup,

            /// <summary>
            /// Enum Phoneinboundrules for value: phoneinboundrules
            /// </summary>
            Phoneinboundrules = phoneinboundrules,

            /// <summary>
            /// Enum Voicemailaccounts for value: voicemailaccounts
            /// </summary>
            Voicemailaccounts = voicemailaccounts

        }

        /// <summary>
        /// Gets or Sets DestinationType
        /// </summary>
        [DataMember(Name="destinationType", EmitDefaultValue=true)]
        public DestinationTypeEnum? DestinationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Menus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Menus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Menus" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="maxExtensionLength">maxExtensionLength (required).</param>
        /// <param name="speechRecognition">speechRecognition.</param>
        /// <param name="directory">ObjectId (unique 12 bytes ID).</param>
        /// <param name="greetingType">greetingType (required).</param>
        /// <param name="greetingTTS">greetingTTS.</param>
        /// <param name="menuVoice">menuVoice.</param>
        /// <param name="exitSound">exitSound.</param>
        /// <param name="transferAnnouncement">transferAnnouncement.</param>
        /// <param name="maxFailures">maxFailures.</param>
        /// <param name="maxTimeouts">maxTimeouts.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="touchToneTerminators">touchToneTerminators.</param>
        /// <param name="timeschedule">ObjectId (unique 12 bytes ID).</param>
        /// <param name="destinationType">destinationType.</param>
        /// <param name="destination">ObjectId (unique 12 bytes ID).</param>
        /// <param name="_ref">_ref.</param>
        /// <param name="callForwardingDestination">callForwardingDestination.</param>
        public Menus(Object name = default(Object), Object maxExtensionLength = default(Object), SpeechRecognitionEnum? speechRecognition = default(SpeechRecognitionEnum?), Object directory = default(Object), GreetingTypeEnum greetingType = default(GreetingTypeEnum), Object greetingTTS = default(Object), Object menuVoice = default(Object), ExitSoundEnum? exitSound = default(ExitSoundEnum?), TransferAnnouncementEnum? transferAnnouncement = default(TransferAnnouncementEnum?), Object maxFailures = default(Object), Object maxTimeouts = default(Object), Object timeout = default(Object), TouchToneTerminatorsEnum? touchToneTerminators = default(TouchToneTerminatorsEnum?), Object timeschedule = default(Object), DestinationTypeEnum? destinationType = default(DestinationTypeEnum?), Object destination = default(Object), Object _ref = default(Object), Object callForwardingDestination = default(Object))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Menus and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            this.Name = name;
            // to ensure "maxExtensionLength" is required (not null)
            if (maxExtensionLength == null)
            {
                throw new InvalidDataException("maxExtensionLength is a required property for Menus and cannot be null");
            }
            else
            {
                this.MaxExtensionLength = maxExtensionLength;
            }

            this.MaxExtensionLength = maxExtensionLength;
            this.SpeechRecognition = speechRecognition;
            this.Directory = directory;
            // to ensure "greetingType" is required (not null)
            if (greetingType == null)
            {
                throw new InvalidDataException("greetingType is a required property for Menus and cannot be null");
            }
            else
            {
                this.GreetingType = greetingType;
            }

            this.GreetingType = greetingType;
            this.GreetingTTS = greetingTTS;
            this.MenuVoice = menuVoice;
            this.ExitSound = exitSound;
            this.TransferAnnouncement = transferAnnouncement;
            this.MaxFailures = maxFailures;
            this.MaxTimeouts = maxTimeouts;
            this.Timeout = timeout;
            this.TouchToneTerminators = touchToneTerminators;
            this.Timeschedule = timeschedule;
            this.DestinationType = destinationType;
            this.Destination = destination;
            this.Ref = _ref;
            this.CallForwardingDestination = callForwardingDestination;
            this.SpeechRecognition = speechRecognition;
            this.Directory = directory;
            this.GreetingTTS = greetingTTS;
            this.MenuVoice = menuVoice;
            this.ExitSound = exitSound;
            this.TransferAnnouncement = transferAnnouncement;
            this.MaxFailures = maxFailures;
            this.MaxTimeouts = maxTimeouts;
            this.Timeout = timeout;
            this.TouchToneTerminators = touchToneTerminators;
            this.Timeschedule = timeschedule;
            this.DestinationType = destinationType;
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
        /// Gets or Sets MaxExtensionLength
        /// </summary>
        [DataMember(Name="maxExtensionLength", EmitDefaultValue=true)]
        public Object MaxExtensionLength { get; set; }


        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="directory", EmitDefaultValue=true)]
        public Object Directory { get; set; }


        /// <summary>
        /// Gets or Sets GreetingTTS
        /// </summary>
        [DataMember(Name="greetingTTS", EmitDefaultValue=true)]
        public Object GreetingTTS { get; set; }

        /// <summary>
        /// Gets or Sets MenuVoice
        /// </summary>
        [DataMember(Name="menuVoice", EmitDefaultValue=true)]
        public Object MenuVoice { get; set; }



        /// <summary>
        /// Gets or Sets MaxFailures
        /// </summary>
        [DataMember(Name="maxFailures", EmitDefaultValue=true)]
        public Object MaxFailures { get; set; }

        /// <summary>
        /// Gets or Sets MaxTimeouts
        /// </summary>
        [DataMember(Name="maxTimeouts", EmitDefaultValue=true)]
        public Object MaxTimeouts { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name="timeout", EmitDefaultValue=true)]
        public Object Timeout { get; set; }


        /// <summary>
        /// ObjectId (unique 12 bytes ID)
        /// </summary>
        /// <value>ObjectId (unique 12 bytes ID)</value>
        [DataMember(Name="timeschedule", EmitDefaultValue=true)]
        public Object Timeschedule { get; set; }


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
            sb.Append("class Menus {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MaxExtensionLength: ").Append(MaxExtensionLength).Append("\n");
            sb.Append("  SpeechRecognition: ").Append(SpeechRecognition).Append("\n");
            sb.Append("  Directory: ").Append(Directory).Append("\n");
            sb.Append("  GreetingType: ").Append(GreetingType).Append("\n");
            sb.Append("  GreetingTTS: ").Append(GreetingTTS).Append("\n");
            sb.Append("  MenuVoice: ").Append(MenuVoice).Append("\n");
            sb.Append("  ExitSound: ").Append(ExitSound).Append("\n");
            sb.Append("  TransferAnnouncement: ").Append(TransferAnnouncement).Append("\n");
            sb.Append("  MaxFailures: ").Append(MaxFailures).Append("\n");
            sb.Append("  MaxTimeouts: ").Append(MaxTimeouts).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  TouchToneTerminators: ").Append(TouchToneTerminators).Append("\n");
            sb.Append("  Timeschedule: ").Append(Timeschedule).Append("\n");
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
            return this.Equals(input as Menus);
        }

        /// <summary>
        /// Returns true if Menus instances are equal
        /// </summary>
        /// <param name="input">Instance of Menus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Menus input)
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
                    this.MaxExtensionLength == input.MaxExtensionLength ||
                    (this.MaxExtensionLength != null &&
                    this.MaxExtensionLength.Equals(input.MaxExtensionLength))
                ) && 
                (
                    this.SpeechRecognition == input.SpeechRecognition ||
                    (this.SpeechRecognition != null &&
                    this.SpeechRecognition.Equals(input.SpeechRecognition))
                ) && 
                (
                    this.Directory == input.Directory ||
                    (this.Directory != null &&
                    this.Directory.Equals(input.Directory))
                ) && 
                (
                    this.GreetingType == input.GreetingType ||
                    (this.GreetingType != null &&
                    this.GreetingType.Equals(input.GreetingType))
                ) && 
                (
                    this.GreetingTTS == input.GreetingTTS ||
                    (this.GreetingTTS != null &&
                    this.GreetingTTS.Equals(input.GreetingTTS))
                ) && 
                (
                    this.MenuVoice == input.MenuVoice ||
                    (this.MenuVoice != null &&
                    this.MenuVoice.Equals(input.MenuVoice))
                ) && 
                (
                    this.ExitSound == input.ExitSound ||
                    (this.ExitSound != null &&
                    this.ExitSound.Equals(input.ExitSound))
                ) && 
                (
                    this.TransferAnnouncement == input.TransferAnnouncement ||
                    (this.TransferAnnouncement != null &&
                    this.TransferAnnouncement.Equals(input.TransferAnnouncement))
                ) && 
                (
                    this.MaxFailures == input.MaxFailures ||
                    (this.MaxFailures != null &&
                    this.MaxFailures.Equals(input.MaxFailures))
                ) && 
                (
                    this.MaxTimeouts == input.MaxTimeouts ||
                    (this.MaxTimeouts != null &&
                    this.MaxTimeouts.Equals(input.MaxTimeouts))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.TouchToneTerminators == input.TouchToneTerminators ||
                    (this.TouchToneTerminators != null &&
                    this.TouchToneTerminators.Equals(input.TouchToneTerminators))
                ) && 
                (
                    this.Timeschedule == input.Timeschedule ||
                    (this.Timeschedule != null &&
                    this.Timeschedule.Equals(input.Timeschedule))
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
                if (this.MaxExtensionLength != null)
                    hashCode = hashCode * 59 + this.MaxExtensionLength.GetHashCode();
                if (this.SpeechRecognition != null)
                    hashCode = hashCode * 59 + this.SpeechRecognition.GetHashCode();
                if (this.Directory != null)
                    hashCode = hashCode * 59 + this.Directory.GetHashCode();
                if (this.GreetingType != null)
                    hashCode = hashCode * 59 + this.GreetingType.GetHashCode();
                if (this.GreetingTTS != null)
                    hashCode = hashCode * 59 + this.GreetingTTS.GetHashCode();
                if (this.MenuVoice != null)
                    hashCode = hashCode * 59 + this.MenuVoice.GetHashCode();
                if (this.ExitSound != null)
                    hashCode = hashCode * 59 + this.ExitSound.GetHashCode();
                if (this.TransferAnnouncement != null)
                    hashCode = hashCode * 59 + this.TransferAnnouncement.GetHashCode();
                if (this.MaxFailures != null)
                    hashCode = hashCode * 59 + this.MaxFailures.GetHashCode();
                if (this.MaxTimeouts != null)
                    hashCode = hashCode * 59 + this.MaxTimeouts.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.TouchToneTerminators != null)
                    hashCode = hashCode * 59 + this.TouchToneTerminators.GetHashCode();
                if (this.Timeschedule != null)
                    hashCode = hashCode * 59 + this.Timeschedule.GetHashCode();
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
