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
    /// TenantPersonalizedInfoDto
    /// </summary>
    [DataContract]
    public partial class TenantPersonalizedInfoDto :  IEquatable<TenantPersonalizedInfoDto>, IValidatableObject
    {
        /// <summary>
        /// 封面类型 cover type
        /// </summary>
        /// <value>封面类型 cover type</value>
        public enum CoverTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1

        }

        /// <summary>
        /// 封面类型 cover type
        /// </summary>
        /// <value>封面类型 cover type</value>
        [DataMember(Name="coverType", EmitDefaultValue=true)]
        public CoverTypeEnum? CoverType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantPersonalizedInfoDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TenantPersonalizedInfoDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantPersonalizedInfoDto" /> class.
        /// </summary>
        /// <param name="title">页面标题 page title (required).</param>
        /// <param name="icon">租户浏览器图标/客户端软件小图标 browser / client application icon (required).</param>
        /// <param name="logo">租户系统Logo tenant system logo (required).</param>
        /// <param name="coverType">封面类型 cover type.</param>
        /// <param name="cover">封面文件相对路径 cover relative path.</param>
        public TenantPersonalizedInfoDto(string title = default(string), string icon = default(string), string logo = default(string), CoverTypeEnum? coverType = default(CoverTypeEnum?), string cover = default(string))
        {
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for TenantPersonalizedInfoDto and cannot be null");
            // to ensure "icon" is required (not null)
            this.Icon = icon ?? throw new ArgumentNullException("icon is a required property for TenantPersonalizedInfoDto and cannot be null");
            // to ensure "logo" is required (not null)
            this.Logo = logo ?? throw new ArgumentNullException("logo is a required property for TenantPersonalizedInfoDto and cannot be null");
            this.CoverType = coverType;
            this.Cover = cover;
        }
        
        /// <summary>
        /// 页面标题 page title
        /// </summary>
        /// <value>页面标题 page title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// 租户浏览器图标/客户端软件小图标 browser / client application icon
        /// </summary>
        /// <value>租户浏览器图标/客户端软件小图标 browser / client application icon</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// 租户系统Logo tenant system logo
        /// </summary>
        /// <value>租户系统Logo tenant system logo</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// 封面文件相对路径 cover relative path
        /// </summary>
        /// <value>封面文件相对路径 cover relative path</value>
        [DataMember(Name="cover", EmitDefaultValue=true)]
        public string Cover { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantPersonalizedInfoDto {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  CoverType: ").Append(CoverType).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
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
            return this.Equals(input as TenantPersonalizedInfoDto);
        }

        /// <summary>
        /// Returns true if TenantPersonalizedInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantPersonalizedInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantPersonalizedInfoDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.CoverType == input.CoverType ||
                    this.CoverType.Equals(input.CoverType)
                ) && 
                (
                    this.Cover == input.Cover ||
                    (this.Cover != null &&
                    this.Cover.Equals(input.Cover))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                hashCode = hashCode * 59 + this.CoverType.GetHashCode();
                if (this.Cover != null)
                    hashCode = hashCode * 59 + this.Cover.GetHashCode();
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
