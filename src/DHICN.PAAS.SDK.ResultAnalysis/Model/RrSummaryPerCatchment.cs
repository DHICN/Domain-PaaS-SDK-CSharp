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
    /// RrSummaryPerCatchment
    /// </summary>
    [DataContract]
    public partial class RrSummaryPerCatchment :  IEquatable<RrSummaryPerCatchment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RrSummaryPerCatchment" /> class.
        /// </summary>
        /// <param name="catchmentID">汇水区ID catchment muid.</param>
        /// <param name="startVolume">初始水量 start volume of the catchment.</param>
        /// <param name="totalInflow">总入流量 total inflow of the catchment.</param>
        /// <param name="totalLosses">总流失量 total losses of the catchment.</param>
        /// <param name="totalRunoff">总径流量 total runoff discharge of the catchment.</param>
        /// <param name="endVolume">终止水量 end volume of the catchment.</param>
        /// <param name="totalInflowPercent">占总入流量的百分比 total inflow percent of the catchment.</param>
        public RrSummaryPerCatchment(string catchmentID = default(string), double startVolume = default(double), double totalInflow = default(double), double totalLosses = default(double), double totalRunoff = default(double), double endVolume = default(double), double totalInflowPercent = default(double))
        {
            this.CatchmentID = catchmentID;
            this.StartVolume = startVolume;
            this.TotalInflow = totalInflow;
            this.TotalLosses = totalLosses;
            this.TotalRunoff = totalRunoff;
            this.EndVolume = endVolume;
            this.TotalInflowPercent = totalInflowPercent;
        }
        
        /// <summary>
        /// 汇水区ID catchment muid
        /// </summary>
        /// <value>汇水区ID catchment muid</value>
        [DataMember(Name="catchmentID", EmitDefaultValue=true)]
        public string CatchmentID { get; set; }

        /// <summary>
        /// 初始水量 start volume of the catchment
        /// </summary>
        /// <value>初始水量 start volume of the catchment</value>
        [DataMember(Name="startVolume", EmitDefaultValue=false)]
        public double StartVolume { get; set; }

        /// <summary>
        /// 总入流量 total inflow of the catchment
        /// </summary>
        /// <value>总入流量 total inflow of the catchment</value>
        [DataMember(Name="totalInflow", EmitDefaultValue=false)]
        public double TotalInflow { get; set; }

        /// <summary>
        /// 总流失量 total losses of the catchment
        /// </summary>
        /// <value>总流失量 total losses of the catchment</value>
        [DataMember(Name="totalLosses", EmitDefaultValue=false)]
        public double TotalLosses { get; set; }

        /// <summary>
        /// 总径流量 total runoff discharge of the catchment
        /// </summary>
        /// <value>总径流量 total runoff discharge of the catchment</value>
        [DataMember(Name="totalRunoff", EmitDefaultValue=false)]
        public double TotalRunoff { get; set; }

        /// <summary>
        /// 终止水量 end volume of the catchment
        /// </summary>
        /// <value>终止水量 end volume of the catchment</value>
        [DataMember(Name="endVolume", EmitDefaultValue=false)]
        public double EndVolume { get; set; }

        /// <summary>
        /// 占总入流量的百分比 total inflow percent of the catchment
        /// </summary>
        /// <value>占总入流量的百分比 total inflow percent of the catchment</value>
        [DataMember(Name="totalInflowPercent", EmitDefaultValue=false)]
        public double TotalInflowPercent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RrSummaryPerCatchment {\n");
            sb.Append("  CatchmentID: ").Append(CatchmentID).Append("\n");
            sb.Append("  StartVolume: ").Append(StartVolume).Append("\n");
            sb.Append("  TotalInflow: ").Append(TotalInflow).Append("\n");
            sb.Append("  TotalLosses: ").Append(TotalLosses).Append("\n");
            sb.Append("  TotalRunoff: ").Append(TotalRunoff).Append("\n");
            sb.Append("  EndVolume: ").Append(EndVolume).Append("\n");
            sb.Append("  TotalInflowPercent: ").Append(TotalInflowPercent).Append("\n");
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
            return this.Equals(input as RrSummaryPerCatchment);
        }

        /// <summary>
        /// Returns true if RrSummaryPerCatchment instances are equal
        /// </summary>
        /// <param name="input">Instance of RrSummaryPerCatchment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RrSummaryPerCatchment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CatchmentID == input.CatchmentID ||
                    (this.CatchmentID != null &&
                    this.CatchmentID.Equals(input.CatchmentID))
                ) && 
                (
                    this.StartVolume == input.StartVolume ||
                    this.StartVolume.Equals(input.StartVolume)
                ) && 
                (
                    this.TotalInflow == input.TotalInflow ||
                    this.TotalInflow.Equals(input.TotalInflow)
                ) && 
                (
                    this.TotalLosses == input.TotalLosses ||
                    this.TotalLosses.Equals(input.TotalLosses)
                ) && 
                (
                    this.TotalRunoff == input.TotalRunoff ||
                    this.TotalRunoff.Equals(input.TotalRunoff)
                ) && 
                (
                    this.EndVolume == input.EndVolume ||
                    this.EndVolume.Equals(input.EndVolume)
                ) && 
                (
                    this.TotalInflowPercent == input.TotalInflowPercent ||
                    this.TotalInflowPercent.Equals(input.TotalInflowPercent)
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
                if (this.CatchmentID != null)
                    hashCode = hashCode * 59 + this.CatchmentID.GetHashCode();
                hashCode = hashCode * 59 + this.StartVolume.GetHashCode();
                hashCode = hashCode * 59 + this.TotalInflow.GetHashCode();
                hashCode = hashCode * 59 + this.TotalLosses.GetHashCode();
                hashCode = hashCode * 59 + this.TotalRunoff.GetHashCode();
                hashCode = hashCode * 59 + this.EndVolume.GetHashCode();
                hashCode = hashCode * 59 + this.TotalInflowPercent.GetHashCode();
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