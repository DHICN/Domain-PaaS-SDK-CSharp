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
using OpenAPIDateConverter = DHI.DSS.IdentityServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.IdentityServiceSDK.Model
{
    /// <summary>
    /// CostData
    /// </summary>
    [DataContract]
    public partial class CostData :  IEquatable<CostData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CostData" /> class.
        /// </summary>
        /// <param name="time">时间 time.</param>
        /// <param name="value">药耗值 dosage cost per ton water.</param>
        public CostData(DateTime time = default(DateTime), double value = default(double))
        {
            this.Time = time;
            this.Value = value;
        }
        
        /// <summary>
        /// 时间 time
        /// </summary>
        /// <value>时间 time</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// 药耗值 dosage cost per ton water
        /// </summary>
        /// <value>药耗值 dosage cost per ton water</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CostData {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as CostData);
        }

        /// <summary>
        /// Returns true if CostData instances are equal
        /// </summary>
        /// <param name="input">Instance of CostData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CostData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
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