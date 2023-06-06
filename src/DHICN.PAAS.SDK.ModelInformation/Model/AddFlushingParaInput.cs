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
    /// AddFlushingParaInput
    /// </summary>
    [DataContract]
    public partial class AddFlushingParaInput :  IEquatable<AddFlushingParaInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFlushingParaInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddFlushingParaInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddFlushingParaInput" /> class.
        /// </summary>
        /// <param name="scenarioId">方案Id scenario id (required).</param>
        /// <param name="data">data (required).</param>
        public AddFlushingParaInput(string scenarioId = default(string), AddFlushingParaDto data = default(AddFlushingParaDto))
        {
            // to ensure "scenarioId" is required (not null)
            this.ScenarioId = scenarioId ?? throw new ArgumentNullException("scenarioId is a required property for AddFlushingParaInput and cannot be null");
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for AddFlushingParaInput and cannot be null");
        }
        
        /// <summary>
        /// 方案Id scenario id
        /// </summary>
        /// <value>方案Id scenario id</value>
        [DataMember(Name="scenarioId", EmitDefaultValue=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public AddFlushingParaDto Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddFlushingParaInput {\n");
            sb.Append("  ScenarioId: ").Append(ScenarioId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as AddFlushingParaInput);
        }

        /// <summary>
        /// Returns true if AddFlushingParaInput instances are equal
        /// </summary>
        /// <param name="input">Instance of AddFlushingParaInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddFlushingParaInput input)
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
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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