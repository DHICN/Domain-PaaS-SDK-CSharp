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
using OpenAPIDateConverter = DHI.DSS.WWTPPaasInfrastructureServiceSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.WWTPPaasInfrastructureServiceSDK.Model
{
    /// <summary>
    /// MappingConfigInputOutput
    /// </summary>
    [DataContract]
    public partial class MappingConfigInputOutput :  IEquatable<MappingConfigInputOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingConfigInputOutput" /> class.
        /// </summary>
        /// <param name="id">点位ID mapping id.</param>
        /// <param name="pointCode">系统点位编码 online point code.</param>
        /// <param name="modelNodeCode">模型点位编码 model node code.</param>
        /// <param name="sysId">系统点位ID system point id.</param>
        /// <param name="reserve">保留字段 reserved field.</param>
        /// <param name="modelName">模板模型名称（即模板方案名称） template model name.</param>
        public MappingConfigInputOutput(Guid id = default(Guid), string pointCode = default(string), string modelNodeCode = default(string), Guid sysId = default(Guid), string reserve = default(string), string modelName = default(string))
        {
            this.Id = id;
            this.PointCode = pointCode;
            this.ModelNodeCode = modelNodeCode;
            this.SysId = sysId;
            this.Reserve = reserve;
            this.ModelName = modelName;
        }
        
        /// <summary>
        /// 点位ID mapping id
        /// </summary>
        /// <value>点位ID mapping id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 系统点位编码 online point code
        /// </summary>
        /// <value>系统点位编码 online point code</value>
        [DataMember(Name="pointCode", EmitDefaultValue=true)]
        public string PointCode { get; set; }

        /// <summary>
        /// 模型点位编码 model node code
        /// </summary>
        /// <value>模型点位编码 model node code</value>
        [DataMember(Name="modelNodeCode", EmitDefaultValue=true)]
        public string ModelNodeCode { get; set; }

        /// <summary>
        /// 系统点位ID system point id
        /// </summary>
        /// <value>系统点位ID system point id</value>
        [DataMember(Name="sysId", EmitDefaultValue=false)]
        public Guid SysId { get; set; }

        /// <summary>
        /// 保留字段 reserved field
        /// </summary>
        /// <value>保留字段 reserved field</value>
        [DataMember(Name="reserve", EmitDefaultValue=true)]
        public string Reserve { get; set; }

        /// <summary>
        /// 模板模型名称（即模板方案名称） template model name
        /// </summary>
        /// <value>模板模型名称（即模板方案名称） template model name</value>
        [DataMember(Name="modelName", EmitDefaultValue=true)]
        public string ModelName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MappingConfigInputOutput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PointCode: ").Append(PointCode).Append("\n");
            sb.Append("  ModelNodeCode: ").Append(ModelNodeCode).Append("\n");
            sb.Append("  SysId: ").Append(SysId).Append("\n");
            sb.Append("  Reserve: ").Append(Reserve).Append("\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
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
            return this.Equals(input as MappingConfigInputOutput);
        }

        /// <summary>
        /// Returns true if MappingConfigInputOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of MappingConfigInputOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MappingConfigInputOutput input)
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
                    this.PointCode == input.PointCode ||
                    (this.PointCode != null &&
                    this.PointCode.Equals(input.PointCode))
                ) && 
                (
                    this.ModelNodeCode == input.ModelNodeCode ||
                    (this.ModelNodeCode != null &&
                    this.ModelNodeCode.Equals(input.ModelNodeCode))
                ) && 
                (
                    this.SysId == input.SysId ||
                    (this.SysId != null &&
                    this.SysId.Equals(input.SysId))
                ) && 
                (
                    this.Reserve == input.Reserve ||
                    (this.Reserve != null &&
                    this.Reserve.Equals(input.Reserve))
                ) && 
                (
                    this.ModelName == input.ModelName ||
                    (this.ModelName != null &&
                    this.ModelName.Equals(input.ModelName))
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
                if (this.PointCode != null)
                    hashCode = hashCode * 59 + this.PointCode.GetHashCode();
                if (this.ModelNodeCode != null)
                    hashCode = hashCode * 59 + this.ModelNodeCode.GetHashCode();
                if (this.SysId != null)
                    hashCode = hashCode * 59 + this.SysId.GetHashCode();
                if (this.Reserve != null)
                    hashCode = hashCode * 59 + this.Reserve.GetHashCode();
                if (this.ModelName != null)
                    hashCode = hashCode * 59 + this.ModelName.GetHashCode();
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