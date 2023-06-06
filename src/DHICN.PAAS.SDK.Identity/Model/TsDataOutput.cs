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
    /// TsDataOutput
    /// </summary>
    [DataContract]
    public partial class TsDataOutput :  IEquatable<TsDataOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TsDataOutput" /> class.
        /// </summary>
        /// <param name="time">time.</param>
        /// <param name="pointCode">点位编码 point code.</param>
        /// <param name="value">值 value.</param>
        /// <param name="tag">标记 data clean tag.</param>
        public TsDataOutput(DateTime time = default(DateTime), string pointCode = default(string), double value = default(double), string tag = default(string))
        {
            this.Time = time;
            this.PointCode = pointCode;
            this.Value = value;
            this.Tag = tag;
        }
        
        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// 点位编码 point code
        /// </summary>
        /// <value>点位编码 point code</value>
        [DataMember(Name="pointCode", EmitDefaultValue=true)]
        public string PointCode { get; set; }

        /// <summary>
        /// 值 value
        /// </summary>
        /// <value>值 value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// 标记 data clean tag
        /// </summary>
        /// <value>标记 data clean tag</value>
        [DataMember(Name="tag", EmitDefaultValue=true)]
        public string Tag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TsDataOutput {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  PointCode: ").Append(PointCode).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
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
            return this.Equals(input as TsDataOutput);
        }

        /// <summary>
        /// Returns true if TsDataOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of TsDataOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TsDataOutput input)
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
                    this.PointCode == input.PointCode ||
                    (this.PointCode != null &&
                    this.PointCode.Equals(input.PointCode))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
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
                if (this.PointCode != null)
                    hashCode = hashCode * 59 + this.PointCode.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
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
