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
    /// DataBoardFullOut
    /// </summary>
    [DataContract]
    public partial class DataBoardFullOut :  IEquatable<DataBoardFullOut>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBoardFullOut" /> class.
        /// </summary>
        /// <param name="dataGroup">数据看板分组 statistic data group.</param>
        /// <param name="data">分组下的数据 statistic data.</param>
        public DataBoardFullOut(string dataGroup = default(string), List<GroupData> data = default(List<GroupData>))
        {
            this.DataGroup = dataGroup;
            this.Data = data;
        }
        
        /// <summary>
        /// 数据看板分组 statistic data group
        /// </summary>
        /// <value>数据看板分组 statistic data group</value>
        [DataMember(Name="dataGroup", EmitDefaultValue=true)]
        public string DataGroup { get; set; }

        /// <summary>
        /// 分组下的数据 statistic data
        /// </summary>
        /// <value>分组下的数据 statistic data</value>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public List<GroupData> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataBoardFullOut {\n");
            sb.Append("  DataGroup: ").Append(DataGroup).Append("\n");
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
            return this.Equals(input as DataBoardFullOut);
        }

        /// <summary>
        /// Returns true if DataBoardFullOut instances are equal
        /// </summary>
        /// <param name="input">Instance of DataBoardFullOut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataBoardFullOut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataGroup == input.DataGroup ||
                    (this.DataGroup != null &&
                    this.DataGroup.Equals(input.DataGroup))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.DataGroup != null)
                    hashCode = hashCode * 59 + this.DataGroup.GetHashCode();
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
