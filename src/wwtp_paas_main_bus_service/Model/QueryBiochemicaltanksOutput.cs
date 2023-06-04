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
    /// QueryBiochemicaltanksOutput
    /// </summary>
    [DataContract]
    public partial class QueryBiochemicaltanksOutput :  IEquatable<QueryBiochemicaltanksOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBiochemicaltanksOutput" /> class.
        /// </summary>
        /// <param name="tankNo">生化池序号 biochemical pool index.</param>
        /// <param name="tankName">生化池名称 biochemical pool name.</param>
        public QueryBiochemicaltanksOutput(string tankNo = default(string), string tankName = default(string))
        {
            this.TankNo = tankNo;
            this.TankName = tankName;
        }
        
        /// <summary>
        /// 生化池序号 biochemical pool index
        /// </summary>
        /// <value>生化池序号 biochemical pool index</value>
        [DataMember(Name="tankNo", EmitDefaultValue=true)]
        public string TankNo { get; set; }

        /// <summary>
        /// 生化池名称 biochemical pool name
        /// </summary>
        /// <value>生化池名称 biochemical pool name</value>
        [DataMember(Name="tankName", EmitDefaultValue=true)]
        public string TankName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryBiochemicaltanksOutput {\n");
            sb.Append("  TankNo: ").Append(TankNo).Append("\n");
            sb.Append("  TankName: ").Append(TankName).Append("\n");
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
            return this.Equals(input as QueryBiochemicaltanksOutput);
        }

        /// <summary>
        /// Returns true if QueryBiochemicaltanksOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryBiochemicaltanksOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryBiochemicaltanksOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TankNo == input.TankNo ||
                    (this.TankNo != null &&
                    this.TankNo.Equals(input.TankNo))
                ) && 
                (
                    this.TankName == input.TankName ||
                    (this.TankName != null &&
                    this.TankName.Equals(input.TankName))
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
                if (this.TankNo != null)
                    hashCode = hashCode * 59 + this.TankNo.GetHashCode();
                if (this.TankName != null)
                    hashCode = hashCode * 59 + this.TankName.GetHashCode();
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
