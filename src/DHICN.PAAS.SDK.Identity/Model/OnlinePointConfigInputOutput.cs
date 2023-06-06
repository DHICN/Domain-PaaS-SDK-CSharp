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
    /// OnlinePointConfigInputOutput
    /// </summary>
    [DataContract]
    public partial class OnlinePointConfigInputOutput :  IEquatable<OnlinePointConfigInputOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlinePointConfigInputOutput" /> class.
        /// </summary>
        /// <param name="pointCode">点位编码.</param>
        /// <param name="pointName">点位名称.</param>
        /// <param name="position">位置.</param>
        /// <param name="stationCode">站点编码.</param>
        /// <param name="unit">单位.</param>
        /// <param name="isKeyPoint">是否为关键点位.</param>
        /// <param name="isInput">是否是输入数据.</param>
        /// <param name="isUse">是否启用该点位.</param>
        /// <param name="defaultValue">默认值.</param>
        public OnlinePointConfigInputOutput(string pointCode = default(string), string pointName = default(string), string position = default(string), string stationCode = default(string), string unit = default(string), bool isKeyPoint = default(bool), bool isInput = default(bool), bool isUse = default(bool), double defaultValue = default(double))
        {
            this.PointCode = pointCode;
            this.PointName = pointName;
            this.Position = position;
            this.StationCode = stationCode;
            this.Unit = unit;
            this.IsKeyPoint = isKeyPoint;
            this.IsInput = isInput;
            this.IsUse = isUse;
            this.DefaultValue = defaultValue;
        }
        
        /// <summary>
        /// 点位编码
        /// </summary>
        /// <value>点位编码</value>
        [DataMember(Name="pointCode", EmitDefaultValue=true)]
        public string PointCode { get; set; }

        /// <summary>
        /// 点位名称
        /// </summary>
        /// <value>点位名称</value>
        [DataMember(Name="pointName", EmitDefaultValue=true)]
        public string PointName { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        /// <value>位置</value>
        [DataMember(Name="position", EmitDefaultValue=true)]
        public string Position { get; set; }

        /// <summary>
        /// 站点编码
        /// </summary>
        /// <value>站点编码</value>
        [DataMember(Name="stationCode", EmitDefaultValue=true)]
        public string StationCode { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        /// <value>单位</value>
        [DataMember(Name="unit", EmitDefaultValue=true)]
        public string Unit { get; set; }

        /// <summary>
        /// 是否为关键点位
        /// </summary>
        /// <value>是否为关键点位</value>
        [DataMember(Name="isKeyPoint", EmitDefaultValue=false)]
        public bool IsKeyPoint { get; set; }

        /// <summary>
        /// 是否是输入数据
        /// </summary>
        /// <value>是否是输入数据</value>
        [DataMember(Name="isInput", EmitDefaultValue=false)]
        public bool IsInput { get; set; }

        /// <summary>
        /// 是否启用该点位
        /// </summary>
        /// <value>是否启用该点位</value>
        [DataMember(Name="isUse", EmitDefaultValue=false)]
        public bool IsUse { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        /// <value>默认值</value>
        [DataMember(Name="defaultValue", EmitDefaultValue=false)]
        public double DefaultValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlinePointConfigInputOutput {\n");
            sb.Append("  PointCode: ").Append(PointCode).Append("\n");
            sb.Append("  PointName: ").Append(PointName).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  StationCode: ").Append(StationCode).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  IsKeyPoint: ").Append(IsKeyPoint).Append("\n");
            sb.Append("  IsInput: ").Append(IsInput).Append("\n");
            sb.Append("  IsUse: ").Append(IsUse).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
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
            return this.Equals(input as OnlinePointConfigInputOutput);
        }

        /// <summary>
        /// Returns true if OnlinePointConfigInputOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of OnlinePointConfigInputOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnlinePointConfigInputOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PointCode == input.PointCode ||
                    (this.PointCode != null &&
                    this.PointCode.Equals(input.PointCode))
                ) && 
                (
                    this.PointName == input.PointName ||
                    (this.PointName != null &&
                    this.PointName.Equals(input.PointName))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.StationCode == input.StationCode ||
                    (this.StationCode != null &&
                    this.StationCode.Equals(input.StationCode))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.IsKeyPoint == input.IsKeyPoint ||
                    this.IsKeyPoint.Equals(input.IsKeyPoint)
                ) && 
                (
                    this.IsInput == input.IsInput ||
                    this.IsInput.Equals(input.IsInput)
                ) && 
                (
                    this.IsUse == input.IsUse ||
                    this.IsUse.Equals(input.IsUse)
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    this.DefaultValue.Equals(input.DefaultValue)
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
                if (this.PointCode != null)
                    hashCode = hashCode * 59 + this.PointCode.GetHashCode();
                if (this.PointName != null)
                    hashCode = hashCode * 59 + this.PointName.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.StationCode != null)
                    hashCode = hashCode * 59 + this.StationCode.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                hashCode = hashCode * 59 + this.IsKeyPoint.GetHashCode();
                hashCode = hashCode * 59 + this.IsInput.GetHashCode();
                hashCode = hashCode * 59 + this.IsUse.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
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
