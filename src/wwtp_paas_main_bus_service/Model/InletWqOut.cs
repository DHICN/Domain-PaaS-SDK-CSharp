/* 
 * wwtp-paas-main-bus-service
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
using OpenAPIDateConverter = wwtp_paas_main_bus_service.Client.OpenAPIDateConverter;

namespace wwtp_paas_main_bus_service.Model
{
    /// <summary>
    /// InletWqOut
    /// </summary>
    [DataContract]
    public partial class InletWqOut :  IEquatable<InletWqOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InletWqOut" /> class.
        /// </summary>
        /// <param name="code">指标 indicator code.</param>
        /// <param name="sourceDatas">清洗前数据 raw data.</param>
        /// <param name="processDatas">清洗后数据 processed data.</param>
        /// <param name="unit">单位 unit.</param>
        public InletWqOut(string code = default(string), List<TsPair1> sourceDatas = default(List<TsPair1>), List<TsPair1> processDatas = default(List<TsPair1>), string unit = default(string))
        {
            this.Code = code;
            this.SourceDatas = sourceDatas;
            this.ProcessDatas = processDatas;
            this.Unit = unit;
        }
        
        /// <summary>
        /// 指标 indicator code
        /// </summary>
        /// <value>指标 indicator code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 清洗前数据 raw data
        /// </summary>
        /// <value>清洗前数据 raw data</value>
        [DataMember(Name="sourceDatas", EmitDefaultValue=true)]
        public List<TsPair1> SourceDatas { get; set; }

        /// <summary>
        /// 清洗后数据 processed data
        /// </summary>
        /// <value>清洗后数据 processed data</value>
        [DataMember(Name="processDatas", EmitDefaultValue=true)]
        public List<TsPair1> ProcessDatas { get; set; }

        /// <summary>
        /// 单位 unit
        /// </summary>
        /// <value>单位 unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InletWqOut {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  SourceDatas: ").Append(SourceDatas).Append("\n");
            sb.Append("  ProcessDatas: ").Append(ProcessDatas).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as InletWqOut);
        }

        /// <summary>
        /// Returns true if InletWqOut instances are equal
        /// </summary>
        /// <param name="input">Instance of InletWqOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InletWqOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.SourceDatas == input.SourceDatas ||
                    this.SourceDatas != null &&
                    input.SourceDatas != null &&
                    this.SourceDatas.SequenceEqual(input.SourceDatas)
                ) && 
                (
                    this.ProcessDatas == input.ProcessDatas ||
                    this.ProcessDatas != null &&
                    input.ProcessDatas != null &&
                    this.ProcessDatas.SequenceEqual(input.ProcessDatas)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.SourceDatas != null)
                    hashCode = hashCode * 59 + this.SourceDatas.GetHashCode();
                if (this.ProcessDatas != null)
                    hashCode = hashCode * 59 + this.ProcessDatas.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
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
