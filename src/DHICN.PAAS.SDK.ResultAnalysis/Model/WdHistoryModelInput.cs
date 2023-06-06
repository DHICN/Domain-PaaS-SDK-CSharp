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
    /// WdHistoryModelInput
    /// </summary>
    [DataContract]
    public partial class WdHistoryModelInput :  IEquatable<WdHistoryModelInput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public SysWdDataTypeEnum? DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WdHistoryModelInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WdHistoryModelInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WdHistoryModelInput" /> class.
        /// </summary>
        /// <param name="modelIds">modelIds (required).</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="dataType">dataType.</param>
        public WdHistoryModelInput(List<string> modelIds = default(List<string>), DateTime startTime = default(DateTime), DateTime endTime = default(DateTime), int frequency = default(int), SysWdDataTypeEnum? dataType = default(SysWdDataTypeEnum?))
        {
            // to ensure "modelIds" is required (not null)
            this.ModelIds = modelIds ?? throw new ArgumentNullException("modelIds is a required property for WdHistoryModelInput and cannot be null");
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Frequency = frequency;
            this.DataType = dataType;
        }
        
        /// <summary>
        /// Gets or Sets ModelIds
        /// </summary>
        [DataMember(Name="modelIds", EmitDefaultValue=false)]
        public List<string> ModelIds { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public int Frequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WdHistoryModelInput {\n");
            sb.Append("  ModelIds: ").Append(ModelIds).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
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
            return this.Equals(input as WdHistoryModelInput);
        }

        /// <summary>
        /// Returns true if WdHistoryModelInput instances are equal
        /// </summary>
        /// <param name="input">Instance of WdHistoryModelInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WdHistoryModelInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ModelIds == input.ModelIds ||
                    this.ModelIds != null &&
                    input.ModelIds != null &&
                    this.ModelIds.SequenceEqual(input.ModelIds)
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
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
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
                if (this.ModelIds != null)
                    hashCode = hashCode * 59 + this.ModelIds.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                hashCode = hashCode * 59 + this.DataType.GetHashCode();
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