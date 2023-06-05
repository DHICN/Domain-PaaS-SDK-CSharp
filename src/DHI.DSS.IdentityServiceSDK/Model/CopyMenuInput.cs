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
    /// CopyMenuInput
    /// </summary>
    [DataContract]
    public partial class CopyMenuInput :  IEquatable<CopyMenuInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyMenuInput" /> class.
        /// </summary>
        /// <param name="sourceSystem">源系统.</param>
        /// <param name="targetSystem">目标系统.</param>
        public CopyMenuInput(Guid sourceSystem = default(Guid), Guid targetSystem = default(Guid))
        {
            this.SourceSystem = sourceSystem;
            this.TargetSystem = targetSystem;
        }
        
        /// <summary>
        /// 源系统
        /// </summary>
        /// <value>源系统</value>
        [DataMember(Name="sourceSystem", EmitDefaultValue=false)]
        public Guid SourceSystem { get; set; }

        /// <summary>
        /// 目标系统
        /// </summary>
        /// <value>目标系统</value>
        [DataMember(Name="targetSystem", EmitDefaultValue=false)]
        public Guid TargetSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CopyMenuInput {\n");
            sb.Append("  SourceSystem: ").Append(SourceSystem).Append("\n");
            sb.Append("  TargetSystem: ").Append(TargetSystem).Append("\n");
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
            return this.Equals(input as CopyMenuInput);
        }

        /// <summary>
        /// Returns true if CopyMenuInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CopyMenuInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CopyMenuInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceSystem == input.SourceSystem ||
                    (this.SourceSystem != null &&
                    this.SourceSystem.Equals(input.SourceSystem))
                ) && 
                (
                    this.TargetSystem == input.TargetSystem ||
                    (this.TargetSystem != null &&
                    this.TargetSystem.Equals(input.TargetSystem))
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
                if (this.SourceSystem != null)
                    hashCode = hashCode * 59 + this.SourceSystem.GetHashCode();
                if (this.TargetSystem != null)
                    hashCode = hashCode * 59 + this.TargetSystem.GetHashCode();
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