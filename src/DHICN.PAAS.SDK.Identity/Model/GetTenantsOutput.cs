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
    /// GetTenantsOutput
    /// </summary>
    [DataContract]
    public partial class GetTenantsOutput :  IEquatable<GetTenantsOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTenantsOutput" /> class.
        /// </summary>
        /// <param name="id">租户ID tenant id.</param>
        /// <param name="systemId">系统ID system id.</param>
        /// <param name="systemName">系统名称 system name.</param>
        /// <param name="name">租户名称 tenant name.</param>
        /// <param name="creationTime">租户创建时间 tenant create time.</param>
        /// <param name="tenantAdmin">租户管理员账户信息 tenant administrators.</param>
        public GetTenantsOutput(Guid id = default(Guid), Guid systemId = default(Guid), string systemName = default(string), string name = default(string), DateTime creationTime = default(DateTime), List<TenantAdminDto> tenantAdmin = default(List<TenantAdminDto>))
        {
            this.Id = id;
            this.SystemId = systemId;
            this.SystemName = systemName;
            this.Name = name;
            this.CreationTime = creationTime;
            this.TenantAdmin = tenantAdmin;
        }
        
        /// <summary>
        /// 租户ID tenant id
        /// </summary>
        /// <value>租户ID tenant id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 系统ID system id
        /// </summary>
        /// <value>系统ID system id</value>
        [DataMember(Name="systemId", EmitDefaultValue=false)]
        public Guid SystemId { get; set; }

        /// <summary>
        /// 系统名称 system name
        /// </summary>
        /// <value>系统名称 system name</value>
        [DataMember(Name="systemName", EmitDefaultValue=true)]
        public string SystemName { get; set; }

        /// <summary>
        /// 租户名称 tenant name
        /// </summary>
        /// <value>租户名称 tenant name</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// 租户创建时间 tenant create time
        /// </summary>
        /// <value>租户创建时间 tenant create time</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime CreationTime { get; set; }

        /// <summary>
        /// 租户管理员账户信息 tenant administrators
        /// </summary>
        /// <value>租户管理员账户信息 tenant administrators</value>
        [DataMember(Name="tenantAdmin", EmitDefaultValue=true)]
        public List<TenantAdminDto> TenantAdmin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTenantsOutput {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  SystemName: ").Append(SystemName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  TenantAdmin: ").Append(TenantAdmin).Append("\n");
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
            return this.Equals(input as GetTenantsOutput);
        }

        /// <summary>
        /// Returns true if GetTenantsOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTenantsOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTenantsOutput input)
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
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.SystemName == input.SystemName ||
                    (this.SystemName != null &&
                    this.SystemName.Equals(input.SystemName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreationTime == input.CreationTime ||
                    (this.CreationTime != null &&
                    this.CreationTime.Equals(input.CreationTime))
                ) && 
                (
                    this.TenantAdmin == input.TenantAdmin ||
                    this.TenantAdmin != null &&
                    input.TenantAdmin != null &&
                    this.TenantAdmin.SequenceEqual(input.TenantAdmin)
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
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.SystemName != null)
                    hashCode = hashCode * 59 + this.SystemName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreationTime != null)
                    hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.TenantAdmin != null)
                    hashCode = hashCode * 59 + this.TenantAdmin.GetHashCode();
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