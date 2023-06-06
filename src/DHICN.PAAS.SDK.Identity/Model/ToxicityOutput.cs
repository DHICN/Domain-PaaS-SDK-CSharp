/* 
 * identity-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.Identity.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.Identity.Model
{
    /// <summary>
    /// ToxicityOutput
    /// </summary>
    [DataContract]
    public partial class ToxicityOutput :  IEquatable<ToxicityOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToxicityOutput" /> class.
        /// </summary>
        /// <param name="colCodes">每一列对应的毒性指标 toxicity indicator of each column.</param>
        /// <param name="colNames">每一列对应的指标名称 toxicity indicator name of each column.</param>
        /// <param name="times">所有的时刻 all the time steps.</param>
        /// <param name="values">每一个时刻，对应每一个指标的数值  value of each indicator of each time step.</param>
        public ToxicityOutput(List<string> colCodes = default(List<string>), List<string> colNames = default(List<string>), List<DateTime> times = default(List<DateTime>), List<List<string>> values = default(List<List<string>>))
        {
            this.ColCodes = colCodes;
            this.ColNames = colNames;
            this.Times = times;
            this.Values = values;
        }
        
        /// <summary>
        /// 每一列对应的毒性指标 toxicity indicator of each column
        /// </summary>
        /// <value>每一列对应的毒性指标 toxicity indicator of each column</value>
        [DataMember(Name="colCodes", EmitDefaultValue=true)]
        public List<string> ColCodes { get; set; }

        /// <summary>
        /// 每一列对应的指标名称 toxicity indicator name of each column
        /// </summary>
        /// <value>每一列对应的指标名称 toxicity indicator name of each column</value>
        [DataMember(Name="colNames", EmitDefaultValue=true)]
        public List<string> ColNames { get; set; }

        /// <summary>
        /// 所有的时刻 all the time steps
        /// </summary>
        /// <value>所有的时刻 all the time steps</value>
        [DataMember(Name="times", EmitDefaultValue=true)]
        public List<DateTime> Times { get; set; }

        /// <summary>
        /// 每一个时刻，对应每一个指标的数值  value of each indicator of each time step
        /// </summary>
        /// <value>每一个时刻，对应每一个指标的数值  value of each indicator of each time step</value>
        [DataMember(Name="values", EmitDefaultValue=true)]
        public List<List<string>> Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToxicityOutput {\n");
            sb.Append("  ColCodes: ").Append(ColCodes).Append("\n");
            sb.Append("  ColNames: ").Append(ColNames).Append("\n");
            sb.Append("  Times: ").Append(Times).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as ToxicityOutput);
        }

        /// <summary>
        /// Returns true if ToxicityOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ToxicityOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ToxicityOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ColCodes == input.ColCodes ||
                    this.ColCodes != null &&
                    input.ColCodes != null &&
                    this.ColCodes.SequenceEqual(input.ColCodes)
                ) && 
                (
                    this.ColNames == input.ColNames ||
                    this.ColNames != null &&
                    input.ColNames != null &&
                    this.ColNames.SequenceEqual(input.ColNames)
                ) && 
                (
                    this.Times == input.Times ||
                    this.Times != null &&
                    input.Times != null &&
                    this.Times.SequenceEqual(input.Times)
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
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
                if (this.ColCodes != null)
                    hashCode = hashCode * 59 + this.ColCodes.GetHashCode();
                if (this.ColNames != null)
                    hashCode = hashCode * 59 + this.ColNames.GetHashCode();
                if (this.Times != null)
                    hashCode = hashCode * 59 + this.Times.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
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
