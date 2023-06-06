/* 
 * result-analysis-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.ResultAnalysis.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.ResultAnalysis.Model
{
    /// <summary>
    /// TraceWqClosePipe
    /// </summary>
    [DataContract]
    public partial class TraceWqClosePipe :  IEquatable<TraceWqClosePipe>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TraceWqClosePipe" /> class.
        /// </summary>
        /// <param name="muid">管道id.</param>
        /// <param name="traceWQValveInfos">管道上的阀门信息.</param>
        public TraceWqClosePipe(string muid = default(string), List<TraceWqValveInfo> traceWQValveInfos = default(List<TraceWqValveInfo>))
        {
            this.Muid = muid;
            this.TraceWQValveInfos = traceWQValveInfos;
        }
        
        /// <summary>
        /// 管道id
        /// </summary>
        /// <value>管道id</value>
        [DataMember(Name="muid", EmitDefaultValue=true)]
        public string Muid { get; set; }

        /// <summary>
        /// 管道上的阀门信息
        /// </summary>
        /// <value>管道上的阀门信息</value>
        [DataMember(Name="traceWQValveInfos", EmitDefaultValue=true)]
        public List<TraceWqValveInfo> TraceWQValveInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TraceWqClosePipe {\n");
            sb.Append("  Muid: ").Append(Muid).Append("\n");
            sb.Append("  TraceWQValveInfos: ").Append(TraceWQValveInfos).Append("\n");
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
            return this.Equals(input as TraceWqClosePipe);
        }

        /// <summary>
        /// Returns true if TraceWqClosePipe instances are equal
        /// </summary>
        /// <param name="input">Instance of TraceWqClosePipe to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TraceWqClosePipe input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Muid == input.Muid ||
                    (this.Muid != null &&
                    this.Muid.Equals(input.Muid))
                ) && 
                (
                    this.TraceWQValveInfos == input.TraceWQValveInfos ||
                    this.TraceWQValveInfos != null &&
                    input.TraceWQValveInfos != null &&
                    this.TraceWQValveInfos.SequenceEqual(input.TraceWQValveInfos)
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
                if (this.Muid != null)
                    hashCode = hashCode * 59 + this.Muid.GetHashCode();
                if (this.TraceWQValveInfos != null)
                    hashCode = hashCode * 59 + this.TraceWQValveInfos.GetHashCode();
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