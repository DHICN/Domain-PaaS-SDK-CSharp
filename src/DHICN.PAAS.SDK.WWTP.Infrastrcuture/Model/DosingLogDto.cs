/* 
 * wwtp-paas-infrastructure-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.WWTP.Infrastrcuture.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.WWTP.Infrastrcuture.Model
{
    /// <summary>
    /// DosingLogDto
    /// </summary>
    [DataContract]
    public partial class DosingLogDto :  IEquatable<DosingLogDto>, IValidatableObject
    {
        /// <summary>
        /// 药剂类型 chemical category
        /// </summary>
        /// <value>药剂类型 chemical category</value>
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4

        }

        /// <summary>
        /// 药剂类型 chemical category
        /// </summary>
        /// <value>药剂类型 chemical category</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// 加药类型：手动，自动 dosing type, including automatic and manual
        /// </summary>
        /// <value>加药类型：手动，自动 dosing type, including automatic and manual</value>
        public enum AdditionTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2

        }

        /// <summary>
        /// 加药类型：手动，自动 dosing type, including automatic and manual
        /// </summary>
        /// <value>加药类型：手动，自动 dosing type, including automatic and manual</value>
        [DataMember(Name="additionType", EmitDefaultValue=false)]
        public AdditionTypeEnum? AdditionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DosingLogDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="code">点位编码 point code.</param>
        /// <param name="category">药剂类型 chemical category.</param>
        /// <param name="additionType">加药类型：手动，自动 dosing type, including automatic and manual.</param>
        /// <param name="productLine">生产线 product line code.</param>
        /// <param name="calValue">计算值 calculate dosage value.</param>
        /// <param name="value">实际值 actual dosage value.</param>
        /// <param name="costValue">药耗值 actual dosage cost.</param>
        /// <param name="unit">单位 dosage unit.</param>
        /// <param name="time">时间 dosing time.</param>
        public DosingLogDto(Guid id = default(Guid), string code = default(string), CategoryEnum? category = default(CategoryEnum?), AdditionTypeEnum? additionType = default(AdditionTypeEnum?), string productLine = default(string), double calValue = default(double), double value = default(double), double costValue = default(double), string unit = default(string), DateTime time = default(DateTime))
        {
            this.Id = id;
            this.Code = code;
            this.Category = category;
            this.AdditionType = additionType;
            this.ProductLine = productLine;
            this.CalValue = calValue;
            this.Value = value;
            this.CostValue = costValue;
            this.Unit = unit;
            this.Time = time;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 点位编码 point code
        /// </summary>
        /// <value>点位编码 point code</value>
        [DataMember(Name="code", EmitDefaultValue=true)]
        public string Code { get; set; }

        /// <summary>
        /// 生产线 product line code
        /// </summary>
        /// <value>生产线 product line code</value>
        [DataMember(Name="productLine", EmitDefaultValue=true)]
        public string ProductLine { get; set; }

        /// <summary>
        /// 计算值 calculate dosage value
        /// </summary>
        /// <value>计算值 calculate dosage value</value>
        [DataMember(Name="calValue", EmitDefaultValue=false)]
        public double CalValue { get; set; }

        /// <summary>
        /// 实际值 actual dosage value
        /// </summary>
        /// <value>实际值 actual dosage value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double Value { get; set; }

        /// <summary>
        /// 药耗值 actual dosage cost
        /// </summary>
        /// <value>药耗值 actual dosage cost</value>
        [DataMember(Name="costValue", EmitDefaultValue=false)]
        public double CostValue { get; set; }

        /// <summary>
        /// 单位 dosage unit
        /// </summary>
        /// <value>单位 dosage unit</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// 时间 dosing time
        /// </summary>
        /// <value>时间 dosing time</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DosingLogDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  AdditionType: ").Append(AdditionType).Append("\n");
            sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
            sb.Append("  CalValue: ").Append(CalValue).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  CostValue: ").Append(CostValue).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as DosingLogDto);
        }

        /// <summary>
        /// Returns true if DosingLogDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DosingLogDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DosingLogDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.AdditionType == input.AdditionType ||
                    this.AdditionType.Equals(input.AdditionType)
                ) && 
                (
                    this.ProductLine == input.ProductLine ||
                    (this.ProductLine != null &&
                    this.ProductLine.Equals(input.ProductLine))
                ) && 
                (
                    this.CalValue == input.CalValue ||
                    this.CalValue.Equals(input.CalValue)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.CostValue == input.CostValue ||
                    this.CostValue.Equals(input.CostValue)
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                hashCode = hashCode * 59 + this.AdditionType.GetHashCode();
                if (this.ProductLine != null)
                    hashCode = hashCode * 59 + this.ProductLine.GetHashCode();
                hashCode = hashCode * 59 + this.CalValue.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.CostValue.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
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