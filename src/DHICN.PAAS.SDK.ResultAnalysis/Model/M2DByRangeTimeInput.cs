/* 
 * result-analysis-service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ResultAnalysis.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ResultAnalysis.Model
{
    /// <summary>
    /// M2DByRangeTimeInput
    /// </summary>
    [DataContract]
    public partial class M2DByRangeTimeInput :  IEquatable<M2DByRangeTimeInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M2DByRangeTimeInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected M2DByRangeTimeInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="M2DByRangeTimeInput" /> class.
        /// </summary>
        /// <param name="scenarioId">方案的ID scenario’s ID (required).</param>
        /// <param name="frequency">查询结果的时间频率 time frequency used to get result (required).</param>
        /// <param name="startTime">查询结果的开始时刻 start time used to get result (required).</param>
        /// <param name="endTime">查询结果的结束时刻 end time used to get result (required).</param>
        /// <param name="elementIds">搜索的网格编号列表，查询上限1000个 search ids, max input: 1000 elements (required).</param>
        public M2DByRangeTimeInput(string scenarioId = default(string), int frequency = default(int), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), List<string> elementIds = default(List<string>))
        {
            // to ensure "scenarioId" is required (not null)
            this.ScenarioId = scenarioId ?? throw new ArgumentNullException("scenarioId is a required property for M2DByRangeTimeInput and cannot be null");
            this.Frequency = frequency;
            this.StartTime = startTime;
            this.EndTime = endTime;
            // to ensure "elementIds" is required (not null)
            this.ElementIds = elementIds ?? throw new ArgumentNullException("elementIds is a required property for M2DByRangeTimeInput and cannot be null");
        }
        
        /// <summary>
        /// 方案的ID scenario’s ID
        /// </summary>
        /// <value>方案的ID scenario’s ID</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// 查询结果的时间频率 time frequency used to get result
        /// </summary>
        /// <value>查询结果的时间频率 time frequency used to get result</value>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public int Frequency { get; set; }

        /// <summary>
        /// 查询结果的开始时刻 start time used to get result
        /// </summary>
        /// <value>查询结果的开始时刻 start time used to get result</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 查询结果的结束时刻 end time used to get result
        /// </summary>
        /// <value>查询结果的结束时刻 end time used to get result</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 搜索的网格编号列表，查询上限1000个 search ids, max input: 1000 elements
        /// </summary>
        /// <value>搜索的网格编号列表，查询上限1000个 search ids, max input: 1000 elements</value>
        [DataMember(Name="elementIds", EmitDefaultValue=false)]
        public List<string> ElementIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class M2DByRangeTimeInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ElementIds: ").Append(ElementIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as M2DByRangeTimeInput);
        }

        /// <summary>
        /// Returns true if M2DByRangeTimeInput instances are equal
        /// </summary>
        /// <param name="input">Instance of M2DByRangeTimeInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(M2DByRangeTimeInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScenarioId == input.ScenarioId ||
                    (this.ScenarioId != null &&
                    this.ScenarioId.Equals(input.ScenarioId))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ElementIds == input.ElementIds ||
                    this.ElementIds != null &&
                    input.ElementIds != null &&
                    this.ElementIds.SequenceEqual(input.ElementIds)
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
                if (this.ScenarioId != null)
                    hashCode = hashCode * 59 + this.ScenarioId.GetHashCode();
                hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ElementIds != null)
                    hashCode = hashCode * 59 + this.ElementIds.GetHashCode();
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