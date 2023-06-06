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
    /// AuthResultOutput
    /// </summary>
    [DataContract]
    public partial class AuthResultOutput :  IEquatable<AuthResultOutput>, IValidatableObject
    {
        /// <summary>
        /// 0-Ready 1-Authorizing 2-Success 3-Error 
        /// </summary>
        /// <value>0-Ready 1-Authorizing 2-Success 3-Error </value>
        public enum StateEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

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
            NUMBER_3 = 3

        }

        /// <summary>
        /// 0-Ready 1-Authorizing 2-Success 3-Error 
        /// </summary>
        /// <value>0-Ready 1-Authorizing 2-Success 3-Error </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthResultOutput" /> class.
        /// </summary>
        /// <param name="tokenInfo">tokenInfo.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="userId">userId.</param>
        /// <param name="state">0-Ready 1-Authorizing 2-Success 3-Error .</param>
        /// <param name="errMsg">errMsg.</param>
        public AuthResultOutput(TokenModel tokenInfo = default(TokenModel), string tenantId = default(string), string userId = default(string), StateEnum? state = default(StateEnum?), string errMsg = default(string))
        {
            this.TokenInfo = tokenInfo;
            this.TenantId = tenantId;
            this.UserId = userId;
            this.State = state;
            this.ErrMsg = errMsg;
        }
        
        /// <summary>
        /// Gets or Sets TokenInfo
        /// </summary>
        [DataMember(Name="tokenInfo", EmitDefaultValue=false)]
        public TokenModel TokenInfo { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets ErrMsg
        /// </summary>
        [DataMember(Name="errMsg", EmitDefaultValue=true)]
        public string ErrMsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthResultOutput {\n");
            sb.Append("  TokenInfo: ").Append(TokenInfo).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ErrMsg: ").Append(ErrMsg).Append("\n");
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
            return this.Equals(input as AuthResultOutput);
        }

        /// <summary>
        /// Returns true if AuthResultOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthResultOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthResultOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenInfo == input.TokenInfo ||
                    (this.TokenInfo != null &&
                    this.TokenInfo.Equals(input.TokenInfo))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.ErrMsg == input.ErrMsg ||
                    (this.ErrMsg != null &&
                    this.ErrMsg.Equals(input.ErrMsg))
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
                if (this.TokenInfo != null)
                    hashCode = hashCode * 59 + this.TokenInfo.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ErrMsg != null)
                    hashCode = hashCode * 59 + this.ErrMsg.GetHashCode();
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
