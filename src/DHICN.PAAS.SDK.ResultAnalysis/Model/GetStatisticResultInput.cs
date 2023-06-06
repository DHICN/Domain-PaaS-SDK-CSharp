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
    /// GetStatisticResultInput
    /// </summary>
    [DataContract]
    public partial class GetStatisticResultInput :  IEquatable<GetStatisticResultInput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets SysWDDataType
        /// </summary>
        [DataMember(Name="sysWDDataType", EmitDefaultValue=false)]
        public SysWdDataTypeEnum? SysWDDataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetStatisticResultInput" /> class.
        /// </summary>
        /// <param name="scenarioId">scenarioId.</param>
        /// <param name="sysWDDataType">sysWDDataType.</param>
        public GetStatisticResultInput(string scenarioId = default(string), SysWdDataTypeEnum? sysWDDataType = default(SysWdDataTypeEnum?))
        {
            this.ScenarioId = scenarioId;
            this.SysWDDataType = sysWDDataType;
        }
        
        /// <summary>
        /// Gets or Sets ScenarioId
        /// </summary>
        [DataMember(Name="scenarioId", EmitDefaultValue=true)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetStatisticResultInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  SysWDDataType: ").Append(SysWDDataType).Append("\n");
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
            return this.Equals(input as GetStatisticResultInput);
        }

        /// <summary>
        /// Returns true if GetStatisticResultInput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetStatisticResultInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetStatisticResultInput input)
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
                    this.SysWDDataType == input.SysWDDataType ||
                    this.SysWDDataType.Equals(input.SysWDDataType)
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
                hashCode = hashCode * 59 + this.SysWDDataType.GetHashCode();
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