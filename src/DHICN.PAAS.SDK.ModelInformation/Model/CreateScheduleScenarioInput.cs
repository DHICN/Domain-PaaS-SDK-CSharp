/* 
 * model-information-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ModelInformation.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ModelInformation.Model
{
    /// <summary>
    /// CreateScheduleScenarioInput
    /// </summary>
    [DataContract]
    public partial class CreateScheduleScenarioInput :  IEquatable<CreateScheduleScenarioInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScheduleScenarioInput" /> class.
        /// </summary>
        /// <param name="parentScenarioId">父方案（预报方案）ID parent scenario (forecast scenario) id.</param>
        /// <param name="newScenarioName">方案名称 scenario name.</param>
        /// <param name="description">方案描述 scenario description.</param>
        public CreateScheduleScenarioInput(Guid parentScenarioId = default(Guid), string newScenarioName = default(string), string description = default(string))
        {
            this.ParentScenarioId = parentScenarioId;
            this.NewScenarioName = newScenarioName;
            this.Description = description;
        }
        
        /// <summary>
        /// 父方案（预报方案）ID parent scenario (forecast scenario) id
        /// </summary>
        /// <value>父方案（预报方案）ID parent scenario (forecast scenario) id</value>
        [DataMember(Name="parentScenarioId", EmitDefaultValue=false)]
        public Guid ParentScenarioId { get; set; }

        /// <summary>
        /// 方案名称 scenario name
        /// </summary>
        /// <value>方案名称 scenario name</value>
        [DataMember(Name="newScenarioName", EmitDefaultValue=true)]
        public string NewScenarioName { get; set; }

        /// <summary>
        /// 方案描述 scenario description
        /// </summary>
        /// <value>方案描述 scenario description</value>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateScheduleScenarioInput {\n");
            sb.Append("  ParentScenarioId: ").Append(ParentScenarioId).Append("\n");
            sb.Append("  NewScenarioName: ").Append(NewScenarioName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CreateScheduleScenarioInput);
        }

        /// <summary>
        /// Returns true if CreateScheduleScenarioInput instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateScheduleScenarioInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateScheduleScenarioInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentScenarioId == input.ParentScenarioId ||
                    (this.ParentScenarioId != null &&
                    this.ParentScenarioId.Equals(input.ParentScenarioId))
                ) && 
                (
                    this.NewScenarioName == input.NewScenarioName ||
                    (this.NewScenarioName != null &&
                    this.NewScenarioName.Equals(input.NewScenarioName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.ParentScenarioId != null)
                    hashCode = hashCode * 59 + this.ParentScenarioId.GetHashCode();
                if (this.NewScenarioName != null)
                    hashCode = hashCode * 59 + this.NewScenarioName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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