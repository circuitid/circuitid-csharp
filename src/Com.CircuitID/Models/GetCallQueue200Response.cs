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
    /// GetCallQueue200Response
    /// </summary>
    [DataContract]
    public partial class GetCallQueue200Response :  IEquatable<GetCallQueue200Response>, IValidatableObject
    {
        /// <summary>
        /// Defines Strategy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StrategyEnum
        {
            /// <summary>
            /// Enum RingAll for value: ring-all
            /// </summary>
            [EnumMember(Value = "ring-all")]
            RingAll = 1,

            /// <summary>
            /// Enum LongestIdleAgent for value: longest-idle-agent
            /// </summary>
            [EnumMember(Value = "longest-idle-agent")]
            LongestIdleAgent = 2,

            /// <summary>
            /// Enum RoundRobin for value: round-robin
            /// </summary>
            [EnumMember(Value = "round-robin")]
            RoundRobin = 3,

            /// <summary>
            /// Enum TopDown for value: top-down
            /// </summary>
            [EnumMember(Value = "top-down")]
            TopDown = 4,

            /// <summary>
            /// Enum AgentWithLeastTalkTime for value: agent-with-least-talk-time
            /// </summary>
            [EnumMember(Value = "agent-with-least-talk-time")]
            AgentWithLeastTalkTime = 5,

            /// <summary>
            /// Enum AgentWithFewestCalls for value: agent-with-fewest-calls
            /// </summary>
            [EnumMember(Value = "agent-with-fewest-calls")]
            AgentWithFewestCalls = 6,

            /// <summary>
            /// Enum SequentiallyByAgentOrder for value: sequentially-by-agent-order
            /// </summary>
            [EnumMember(Value = "sequentially-by-agent-order")]
            SequentiallyByAgentOrder = 7,

            /// <summary>
            /// Enum Random for value: random
            /// </summary>
            [EnumMember(Value = "random")]
            Random = 8

        }

        /// <summary>
        /// Gets or Sets Strategy
        /// </summary>
        [DataMember(Name="strategy", EmitDefaultValue=true)]
        public StrategyEnum Strategy { get; set; }
        /// <summary>
        /// Defines TimeBasedScore
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TimeBasedScoreEnum
        {
            /// <summary>
            /// Enum Queue for value: queue
            /// </summary>
            [EnumMember(Value = "queue")]
            Queue = 1,

            /// <summary>
            /// Enum System for value: system
            /// </summary>
            [EnumMember(Value = "system")]
            System = 2

        }

        /// <summary>
        /// Gets or Sets TimeBasedScore
        /// </summary>
        [DataMember(Name="timeBasedScore", EmitDefaultValue=true)]
        public TimeBasedScoreEnum TimeBasedScore { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCallQueue200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCallQueue200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCallQueue200Response" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="strategy">strategy (required).</param>
        /// <param name="announcePosition">announcePosition.</param>
        /// <param name="moh">moh (required) (default to &quot;deafult&quot;).</param>
        /// <param name="callerResumeTimeout">callerResumeTimeout (required) (default to 3600).</param>
        /// <param name="maxWaitTime">maxWaitTime (required) (default to 300).</param>
        /// <param name="maxWaitTimeNoAgent">maxWaitTimeNoAgent (required) (default to 300).</param>
        /// <param name="maxNoAnswer">maxNoAnswer (required) (default to 1000000).</param>
        /// <param name="noAnswerDelayTimeout">noAnswerDelayTimeout (default to 60).</param>
        /// <param name="rejectTimeout">rejectTimeout (default to 60).</param>
        /// <param name="busyTimeout">busyTimeout (default to 60).</param>
        /// <param name="wrapUpTimeout">wrapUpTimeout (default to 10).</param>
        /// <param name="timeBasedScore">timeBasedScore (required) (default to TimeBasedScoreEnum.Queue).</param>
        /// <param name="tierRulesApply">tierRulesApply (required) (default to false).</param>
        /// <param name="tierRuleNoAgentNoWait">tierRuleNoAgentNoWait (required) (default to true).</param>
        /// <param name="tierRuleWaitSecond">tierRuleWaitSecond (default to 300).</param>
        /// <param name="tierRuleWaitMultiplyLevel">tierRuleWaitMultiplyLevel (required) (default to true).</param>
        /// <param name="abandonedResumeAllowed">abandonedResumeAllowed (required) (default to true).</param>
        /// <param name="discardAbandonedAfter">discardAbandonedAfter (default to 14400).</param>
        /// <param name="maxWaitTimeNoAgentTimeReached">maxWaitTimeNoAgentTimeReached (required) (default to 5).</param>
        /// <param name="id">ObjectId (unique 12 bytes ID).</param>
        /// <param name="createdByUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="updatedByUserId">ObjectId (unique 12 bytes ID).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public GetCallQueue200Response(string name = default(string), StrategyEnum strategy = default(StrategyEnum), int announcePosition = default(int), string moh = "deafult", int callerResumeTimeout = 3600, int maxWaitTime = 300, int maxWaitTimeNoAgent = 300, int maxNoAnswer = 1000000, int noAnswerDelayTimeout = 60, int rejectTimeout = 60, int busyTimeout = 60, int wrapUpTimeout = 10, TimeBasedScoreEnum timeBasedScore = TimeBasedScoreEnum.Queue, bool tierRulesApply = false, bool tierRuleNoAgentNoWait = true, int tierRuleWaitSecond = 300, bool tierRuleWaitMultiplyLevel = true, bool abandonedResumeAllowed = true, int discardAbandonedAfter = 14400, int maxWaitTimeNoAgentTimeReached = 5, string id = default(string), string createdByUserId = default(string), string updatedByUserId = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "strategy" is required (not null)
            if (strategy == null)
            {
                throw new InvalidDataException("strategy is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.Strategy = strategy;
            }

            // to ensure "moh" is required (not null)
            if (moh == null)
            {
                throw new InvalidDataException("moh is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.Moh = moh;
            }

            // to ensure "callerResumeTimeout" is required (not null)
            if (callerResumeTimeout == null)
            {
                throw new InvalidDataException("callerResumeTimeout is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.CallerResumeTimeout = callerResumeTimeout;
            }

            // to ensure "maxWaitTime" is required (not null)
            if (maxWaitTime == null)
            {
                throw new InvalidDataException("maxWaitTime is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.MaxWaitTime = maxWaitTime;
            }

            // to ensure "maxWaitTimeNoAgent" is required (not null)
            if (maxWaitTimeNoAgent == null)
            {
                throw new InvalidDataException("maxWaitTimeNoAgent is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.MaxWaitTimeNoAgent = maxWaitTimeNoAgent;
            }

            // to ensure "maxNoAnswer" is required (not null)
            if (maxNoAnswer == null)
            {
                throw new InvalidDataException("maxNoAnswer is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.MaxNoAnswer = maxNoAnswer;
            }

            // to ensure "timeBasedScore" is required (not null)
            if (timeBasedScore == null)
            {
                throw new InvalidDataException("timeBasedScore is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.TimeBasedScore = timeBasedScore;
            }

            // to ensure "tierRulesApply" is required (not null)
            if (tierRulesApply == null)
            {
                throw new InvalidDataException("tierRulesApply is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.TierRulesApply = tierRulesApply;
            }

            // to ensure "tierRuleNoAgentNoWait" is required (not null)
            if (tierRuleNoAgentNoWait == null)
            {
                throw new InvalidDataException("tierRuleNoAgentNoWait is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.TierRuleNoAgentNoWait = tierRuleNoAgentNoWait;
            }

            // to ensure "tierRuleWaitMultiplyLevel" is required (not null)
            if (tierRuleWaitMultiplyLevel == null)
            {
                throw new InvalidDataException("tierRuleWaitMultiplyLevel is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.TierRuleWaitMultiplyLevel = tierRuleWaitMultiplyLevel;
            }

            // to ensure "abandonedResumeAllowed" is required (not null)
            if (abandonedResumeAllowed == null)
            {
                throw new InvalidDataException("abandonedResumeAllowed is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.AbandonedResumeAllowed = abandonedResumeAllowed;
            }

            // to ensure "maxWaitTimeNoAgentTimeReached" is required (not null)
            if (maxWaitTimeNoAgentTimeReached == null)
            {
                throw new InvalidDataException("maxWaitTimeNoAgentTimeReached is a required property for GetCallQueue200Response and cannot be null");
            }
            else
            {
                this.MaxWaitTimeNoAgentTimeReached = maxWaitTimeNoAgentTimeReached;
            }

            this.AnnouncePosition = announcePosition;
            // use default value if no "noAnswerDelayTimeout" provided
            if (noAnswerDelayTimeout == null)
            {
                this.NoAnswerDelayTimeout = 60;
            }
            else
            {
                this.NoAnswerDelayTimeout = noAnswerDelayTimeout;
            }
            // use default value if no "rejectTimeout" provided
            if (rejectTimeout == null)
            {
                this.RejectTimeout = 60;
            }
            else
            {
                this.RejectTimeout = rejectTimeout;
            }
            // use default value if no "busyTimeout" provided
            if (busyTimeout == null)
            {
                this.BusyTimeout = 60;
            }
            else
            {
                this.BusyTimeout = busyTimeout;
            }
            // use default value if no "wrapUpTimeout" provided
            if (wrapUpTimeout == null)
            {
                this.WrapUpTimeout = 10;
            }
            else
            {
                this.WrapUpTimeout = wrapUpTimeout;
            }
            // use default value if no "tierRuleWaitSecond" provided
            if (tierRuleWaitSecond == null)
            {
                this.TierRuleWaitSecond = 300;
            }
            else
            {
                this.TierRuleWaitSecond = tierRuleWaitSecond;
            }
            // use default value if no "discardAbandonedAfter" provided
            if (discardAbandonedAfter == null)
            {
                this.DiscardAbandonedAfter = 14400;
            }
            else
            {
                this.DiscardAbandonedAfter = discardAbandonedAfter;
            }
            this.Id = id;
            this.CreatedByUserId = createdByUserId;
            this.UpdatedByUserId = updatedByUserId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets AnnouncePosition
        /// </summary>
        [DataMember(Name="announcePosition", EmitDefaultValue=false)]
        public int AnnouncePosition { get; set; }

        /// <summary>
        /// Gets or Sets Moh
        /// </summary>
        [DataMember(Name="moh", EmitDefaultValue=true)]
        public string Moh { get; set; }

        /// <summary>
        /// Gets or Sets CallerResumeTimeout
        /// </summary>
        [DataMember(Name="callerResumeTimeout", EmitDefaultValue=true)]
        public int CallerResumeTimeout { get; set; }

        /// <summary>
        /// Gets or Sets MaxWaitTime
        /// </summary>
        [DataMember(Name="maxWaitTime", EmitDefaultValue=true)]
        public int MaxWaitTime { get; set; }

        /// <summary>
        /// Gets or Sets MaxWaitTimeNoAgent
        /// </summary>
        [DataMember(Name="maxWaitTimeNoAgent", EmitDefaultValue=true)]
        public int MaxWaitTimeNoAgent { get; set; }

        /// <summary>
        /// Gets or Sets MaxNoAnswer
        /// </summary>
        [DataMember(Name="maxNoAnswer", EmitDefaultValue=true)]
        public int MaxNoAnswer { get; set; }

        /// <summary>
        /// Gets or Sets NoAnswerDelayTimeout
        /// </summary>
        [DataMember(Name="noAnswerDelayTimeout", EmitDefaultValue=false)]
        public int NoAnswerDelayTimeout { get; set; }

        /// <summary>
        /// Gets or Sets RejectTimeout
        /// </summary>
        [DataMember(Name="rejectTimeout", EmitDefaultValue=false)]
        public int RejectTimeout { get; set; }

        /// <summary>
        /// Gets or Sets BusyTimeout
        /// </summary>
        [DataMember(Name="busyTimeout", EmitDefaultValue=false)]
        public int BusyTimeout { get; set; }

        /// <summary>
        /// Gets or Sets WrapUpTimeout
        /// </summary>
        [DataMember(Name="wrapUpTimeout", EmitDefaultValue=false)]
        public int WrapUpTimeout { get; set; }


        /// <summary>
        /// Gets or Sets TierRulesApply
        /// </summary>
        [DataMember(Name="tierRulesApply", EmitDefaultValue=true)]
        public bool TierRulesApply { get; set; }

        /// <summary>
        /// Gets or Sets TierRuleNoAgentNoWait
        /// </summary>
        [DataMember(Name="tierRuleNoAgentNoWait", EmitDefaultValue=true)]
        public bool TierRuleNoAgentNoWait { get; set; }

        /// <summary>
        /// Gets or Sets TierRuleWaitSecond
        /// </summary>
        [DataMember(Name="tierRuleWaitSecond", EmitDefaultValue=false)]
        public int TierRuleWaitSecond { get; set; }

        /// <summary>
        /// Gets or Sets TierRuleWaitMultiplyLevel
        /// </summary>
        [DataMember(Name="tierRuleWaitMultiplyLevel", EmitDefaultValue=true)]
        public bool TierRuleWaitMultiplyLevel { get; set; }

        /// <summary>
        /// Gets or Sets AbandonedResumeAllowed
        /// </summary>
        [DataMember(Name="abandonedResumeAllowed", EmitDefaultValue=true)]
        public bool AbandonedResumeAllowed { get; set; }

        /// <summary>
        /// Gets or Sets DiscardAbandonedAfter
        /// </summary>
        [DataMember(Name="discardAbandonedAfter", EmitDefaultValue=false)]
        public int DiscardAbandonedAfter { get; set; }

        /// <summary>
        /// Gets or Sets MaxWaitTimeNoAgentTimeReached
        /// </summary>
        [DataMember(Name="maxWaitTimeNoAgentTimeReached", EmitDefaultValue=true)]
        public int MaxWaitTimeNoAgentTimeReached { get; set; }

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
            sb.Append("class GetCallQueue200Response {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Strategy: ").Append(Strategy).Append("\n");
            sb.Append("  AnnouncePosition: ").Append(AnnouncePosition).Append("\n");
            sb.Append("  Moh: ").Append(Moh).Append("\n");
            sb.Append("  CallerResumeTimeout: ").Append(CallerResumeTimeout).Append("\n");
            sb.Append("  MaxWaitTime: ").Append(MaxWaitTime).Append("\n");
            sb.Append("  MaxWaitTimeNoAgent: ").Append(MaxWaitTimeNoAgent).Append("\n");
            sb.Append("  MaxNoAnswer: ").Append(MaxNoAnswer).Append("\n");
            sb.Append("  NoAnswerDelayTimeout: ").Append(NoAnswerDelayTimeout).Append("\n");
            sb.Append("  RejectTimeout: ").Append(RejectTimeout).Append("\n");
            sb.Append("  BusyTimeout: ").Append(BusyTimeout).Append("\n");
            sb.Append("  WrapUpTimeout: ").Append(WrapUpTimeout).Append("\n");
            sb.Append("  TimeBasedScore: ").Append(TimeBasedScore).Append("\n");
            sb.Append("  TierRulesApply: ").Append(TierRulesApply).Append("\n");
            sb.Append("  TierRuleNoAgentNoWait: ").Append(TierRuleNoAgentNoWait).Append("\n");
            sb.Append("  TierRuleWaitSecond: ").Append(TierRuleWaitSecond).Append("\n");
            sb.Append("  TierRuleWaitMultiplyLevel: ").Append(TierRuleWaitMultiplyLevel).Append("\n");
            sb.Append("  AbandonedResumeAllowed: ").Append(AbandonedResumeAllowed).Append("\n");
            sb.Append("  DiscardAbandonedAfter: ").Append(DiscardAbandonedAfter).Append("\n");
            sb.Append("  MaxWaitTimeNoAgentTimeReached: ").Append(MaxWaitTimeNoAgentTimeReached).Append("\n");
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
            return this.Equals(input as GetCallQueue200Response);
        }

        /// <summary>
        /// Returns true if GetCallQueue200Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCallQueue200Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCallQueue200Response input)
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
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
                ) && 
                (
                    this.AnnouncePosition == input.AnnouncePosition ||
                    (this.AnnouncePosition != null &&
                    this.AnnouncePosition.Equals(input.AnnouncePosition))
                ) && 
                (
                    this.Moh == input.Moh ||
                    (this.Moh != null &&
                    this.Moh.Equals(input.Moh))
                ) && 
                (
                    this.CallerResumeTimeout == input.CallerResumeTimeout ||
                    (this.CallerResumeTimeout != null &&
                    this.CallerResumeTimeout.Equals(input.CallerResumeTimeout))
                ) && 
                (
                    this.MaxWaitTime == input.MaxWaitTime ||
                    (this.MaxWaitTime != null &&
                    this.MaxWaitTime.Equals(input.MaxWaitTime))
                ) && 
                (
                    this.MaxWaitTimeNoAgent == input.MaxWaitTimeNoAgent ||
                    (this.MaxWaitTimeNoAgent != null &&
                    this.MaxWaitTimeNoAgent.Equals(input.MaxWaitTimeNoAgent))
                ) && 
                (
                    this.MaxNoAnswer == input.MaxNoAnswer ||
                    (this.MaxNoAnswer != null &&
                    this.MaxNoAnswer.Equals(input.MaxNoAnswer))
                ) && 
                (
                    this.NoAnswerDelayTimeout == input.NoAnswerDelayTimeout ||
                    (this.NoAnswerDelayTimeout != null &&
                    this.NoAnswerDelayTimeout.Equals(input.NoAnswerDelayTimeout))
                ) && 
                (
                    this.RejectTimeout == input.RejectTimeout ||
                    (this.RejectTimeout != null &&
                    this.RejectTimeout.Equals(input.RejectTimeout))
                ) && 
                (
                    this.BusyTimeout == input.BusyTimeout ||
                    (this.BusyTimeout != null &&
                    this.BusyTimeout.Equals(input.BusyTimeout))
                ) && 
                (
                    this.WrapUpTimeout == input.WrapUpTimeout ||
                    (this.WrapUpTimeout != null &&
                    this.WrapUpTimeout.Equals(input.WrapUpTimeout))
                ) && 
                (
                    this.TimeBasedScore == input.TimeBasedScore ||
                    (this.TimeBasedScore != null &&
                    this.TimeBasedScore.Equals(input.TimeBasedScore))
                ) && 
                (
                    this.TierRulesApply == input.TierRulesApply ||
                    (this.TierRulesApply != null &&
                    this.TierRulesApply.Equals(input.TierRulesApply))
                ) && 
                (
                    this.TierRuleNoAgentNoWait == input.TierRuleNoAgentNoWait ||
                    (this.TierRuleNoAgentNoWait != null &&
                    this.TierRuleNoAgentNoWait.Equals(input.TierRuleNoAgentNoWait))
                ) && 
                (
                    this.TierRuleWaitSecond == input.TierRuleWaitSecond ||
                    (this.TierRuleWaitSecond != null &&
                    this.TierRuleWaitSecond.Equals(input.TierRuleWaitSecond))
                ) && 
                (
                    this.TierRuleWaitMultiplyLevel == input.TierRuleWaitMultiplyLevel ||
                    (this.TierRuleWaitMultiplyLevel != null &&
                    this.TierRuleWaitMultiplyLevel.Equals(input.TierRuleWaitMultiplyLevel))
                ) && 
                (
                    this.AbandonedResumeAllowed == input.AbandonedResumeAllowed ||
                    (this.AbandonedResumeAllowed != null &&
                    this.AbandonedResumeAllowed.Equals(input.AbandonedResumeAllowed))
                ) && 
                (
                    this.DiscardAbandonedAfter == input.DiscardAbandonedAfter ||
                    (this.DiscardAbandonedAfter != null &&
                    this.DiscardAbandonedAfter.Equals(input.DiscardAbandonedAfter))
                ) && 
                (
                    this.MaxWaitTimeNoAgentTimeReached == input.MaxWaitTimeNoAgentTimeReached ||
                    (this.MaxWaitTimeNoAgentTimeReached != null &&
                    this.MaxWaitTimeNoAgentTimeReached.Equals(input.MaxWaitTimeNoAgentTimeReached))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Strategy != null)
                    hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.AnnouncePosition != null)
                    hashCode = hashCode * 59 + this.AnnouncePosition.GetHashCode();
                if (this.Moh != null)
                    hashCode = hashCode * 59 + this.Moh.GetHashCode();
                if (this.CallerResumeTimeout != null)
                    hashCode = hashCode * 59 + this.CallerResumeTimeout.GetHashCode();
                if (this.MaxWaitTime != null)
                    hashCode = hashCode * 59 + this.MaxWaitTime.GetHashCode();
                if (this.MaxWaitTimeNoAgent != null)
                    hashCode = hashCode * 59 + this.MaxWaitTimeNoAgent.GetHashCode();
                if (this.MaxNoAnswer != null)
                    hashCode = hashCode * 59 + this.MaxNoAnswer.GetHashCode();
                if (this.NoAnswerDelayTimeout != null)
                    hashCode = hashCode * 59 + this.NoAnswerDelayTimeout.GetHashCode();
                if (this.RejectTimeout != null)
                    hashCode = hashCode * 59 + this.RejectTimeout.GetHashCode();
                if (this.BusyTimeout != null)
                    hashCode = hashCode * 59 + this.BusyTimeout.GetHashCode();
                if (this.WrapUpTimeout != null)
                    hashCode = hashCode * 59 + this.WrapUpTimeout.GetHashCode();
                if (this.TimeBasedScore != null)
                    hashCode = hashCode * 59 + this.TimeBasedScore.GetHashCode();
                if (this.TierRulesApply != null)
                    hashCode = hashCode * 59 + this.TierRulesApply.GetHashCode();
                if (this.TierRuleNoAgentNoWait != null)
                    hashCode = hashCode * 59 + this.TierRuleNoAgentNoWait.GetHashCode();
                if (this.TierRuleWaitSecond != null)
                    hashCode = hashCode * 59 + this.TierRuleWaitSecond.GetHashCode();
                if (this.TierRuleWaitMultiplyLevel != null)
                    hashCode = hashCode * 59 + this.TierRuleWaitMultiplyLevel.GetHashCode();
                if (this.AbandonedResumeAllowed != null)
                    hashCode = hashCode * 59 + this.AbandonedResumeAllowed.GetHashCode();
                if (this.DiscardAbandonedAfter != null)
                    hashCode = hashCode * 59 + this.DiscardAbandonedAfter.GetHashCode();
                if (this.MaxWaitTimeNoAgentTimeReached != null)
                    hashCode = hashCode * 59 + this.MaxWaitTimeNoAgentTimeReached.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 45.", new [] { "Name" });
            }


            // Moh (string) maxLength
            if(this.Moh != null && this.Moh.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Moh, length must be less than 255.", new [] { "Moh" });
            }


            yield break;
        }
    }

}
