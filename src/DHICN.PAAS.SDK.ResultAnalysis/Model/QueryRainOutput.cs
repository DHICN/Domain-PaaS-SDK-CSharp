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
    /// QueryRainOutput
    /// </summary>
    [DataContract]
    public partial class QueryRainOutput :  IEquatable<QueryRainOutput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public RainfallStatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRainOutput" /> class.
        /// </summary>
        /// <param name="rainId">降雨记录的ID rain id.</param>
        /// <param name="startTime">降雨记录的开始时间 rainfall start time.</param>
        /// <param name="endTime">降雨记录的结束时间 rainfall end time.</param>
        /// <param name="measureRainfall">实测总降雨量 measured total rainfall.</param>
        /// <param name="forecastRainfall">预报总降雨量 forecast total rainfall.</param>
        /// <param name="status">status.</param>
        /// <param name="scenarios">与降雨记录关联的方案ID列表 scenarios associated with this rainfall.</param>
        public QueryRainOutput(Guid rainId = default(Guid), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), double measureRainfall = default(double), double forecastRainfall = default(double), RainfallStatusEnum? status = default(RainfallStatusEnum?), List<Guid> scenarios = default(List<Guid>))
        {
            this.RainId = rainId;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.MeasureRainfall = measureRainfall;
            this.ForecastRainfall = forecastRainfall;
            this.Status = status;
            this.Scenarios = scenarios;
        }
        
        /// <summary>
        /// 降雨记录的ID rain id
        /// </summary>
        /// <value>降雨记录的ID rain id</value>
        [DataMember(Name="rainId", EmitDefaultValue=false)]
        public Guid RainId { get; set; }

        /// <summary>
        /// 降雨记录的开始时间 rainfall start time
        /// </summary>
        /// <value>降雨记录的开始时间 rainfall start time</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 降雨记录的结束时间 rainfall end time
        /// </summary>
        /// <value>降雨记录的结束时间 rainfall end time</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 实测总降雨量 measured total rainfall
        /// </summary>
        /// <value>实测总降雨量 measured total rainfall</value>
        [DataMember(Name="measureRainfall", EmitDefaultValue=false)]
        public double MeasureRainfall { get; set; }

        /// <summary>
        /// 预报总降雨量 forecast total rainfall
        /// </summary>
        /// <value>预报总降雨量 forecast total rainfall</value>
        [DataMember(Name="forecastRainfall", EmitDefaultValue=false)]
        public double ForecastRainfall { get; set; }

        /// <summary>
        /// 与降雨记录关联的方案ID列表 scenarios associated with this rainfall
        /// </summary>
        /// <value>与降雨记录关联的方案ID列表 scenarios associated with this rainfall</value>
        [DataMember(Name="scenarios", EmitDefaultValue=true)]
        public List<Guid> Scenarios { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRainOutput {\n");
            sb.Append("  RainId: ").Append(RainId).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  MeasureRainfall: ").Append(MeasureRainfall).Append("\n");
            sb.Append("  ForecastRainfall: ").Append(ForecastRainfall).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Scenarios: ").Append(Scenarios).Append("\n");
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
            return this.Equals(input as QueryRainOutput);
        }

        /// <summary>
        /// Returns true if QueryRainOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryRainOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryRainOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RainId == input.RainId ||
                    (this.RainId != null &&
                    this.RainId.Equals(input.RainId))
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
                    this.MeasureRainfall == input.MeasureRainfall ||
                    this.MeasureRainfall.Equals(input.MeasureRainfall)
                ) && 
                (
                    this.ForecastRainfall == input.ForecastRainfall ||
                    this.ForecastRainfall.Equals(input.ForecastRainfall)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Scenarios == input.Scenarios ||
                    this.Scenarios != null &&
                    input.Scenarios != null &&
                    this.Scenarios.SequenceEqual(input.Scenarios)
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
                if (this.RainId != null)
                    hashCode = hashCode * 59 + this.RainId.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.MeasureRainfall.GetHashCode();
                hashCode = hashCode * 59 + this.ForecastRainfall.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Scenarios != null)
                    hashCode = hashCode * 59 + this.Scenarios.GetHashCode();
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