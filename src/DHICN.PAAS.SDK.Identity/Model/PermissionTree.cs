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
    /// PermissionTree
    /// </summary>
    [DataContract]
    public partial class PermissionTree :  IEquatable<PermissionTree>, IValidatableObject
    {
        /// <summary>
        /// 0-menu(menu) 1-button(button) 
        /// </summary>
        /// <value>0-menu(menu) 1-button(button) </value>
        public enum MenuTypeEnum
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
        /// 0-menu(menu) 1-button(button) 
        /// </summary>
        /// <value>0-menu(menu) 1-button(button) </value>
        [DataMember(Name="menuType", EmitDefaultValue=false)]
        public MenuTypeEnum? MenuType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionTree" /> class.
        /// </summary>
        /// <param name="id">菜单Id menu id.</param>
        /// <param name="label">菜单名称 menu label.</param>
        /// <param name="isCheck">是否选中状态 if it is checked.</param>
        /// <param name="menuRouter">路由.</param>
        /// <param name="regular">正则.</param>
        /// <param name="menuType">0-menu(menu) 1-button(button) .</param>
        /// <param name="children">子菜单 sub menus.</param>
        public PermissionTree(Guid id = default(Guid), string label = default(string), bool isCheck = default(bool), string menuRouter = default(string), string regular = default(string), MenuTypeEnum? menuType = default(MenuTypeEnum?), List<PermissionTree> children = default(List<PermissionTree>))
        {
            this.Id = id;
            this.Label = label;
            this.IsCheck = isCheck;
            this.MenuRouter = menuRouter;
            this.Regular = regular;
            this.MenuType = menuType;
            this.Children = children;
        }
        
        /// <summary>
        /// 菜单Id menu id
        /// </summary>
        /// <value>菜单Id menu id</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// 菜单名称 menu label
        /// </summary>
        /// <value>菜单名称 menu label</value>
        [DataMember(Name="label", EmitDefaultValue=true)]
        public string Label { get; set; }

        /// <summary>
        /// 是否选中状态 if it is checked
        /// </summary>
        /// <value>是否选中状态 if it is checked</value>
        [DataMember(Name="isCheck", EmitDefaultValue=false)]
        public bool IsCheck { get; set; }

        /// <summary>
        /// 路由
        /// </summary>
        /// <value>路由</value>
        [DataMember(Name="menuRouter", EmitDefaultValue=true)]
        public string MenuRouter { get; set; }

        /// <summary>
        /// 正则
        /// </summary>
        /// <value>正则</value>
        [DataMember(Name="regular", EmitDefaultValue=true)]
        public string Regular { get; set; }

        /// <summary>
        /// 子菜单 sub menus
        /// </summary>
        /// <value>子菜单 sub menus</value>
        [DataMember(Name="children", EmitDefaultValue=true)]
        public List<PermissionTree> Children { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionTree {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  IsCheck: ").Append(IsCheck).Append("\n");
            sb.Append("  MenuRouter: ").Append(MenuRouter).Append("\n");
            sb.Append("  Regular: ").Append(Regular).Append("\n");
            sb.Append("  MenuType: ").Append(MenuType).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
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
            return this.Equals(input as PermissionTree);
        }

        /// <summary>
        /// Returns true if PermissionTree instances are equal
        /// </summary>
        /// <param name="input">Instance of PermissionTree to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionTree input)
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
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.IsCheck == input.IsCheck ||
                    this.IsCheck.Equals(input.IsCheck)
                ) && 
                (
                    this.MenuRouter == input.MenuRouter ||
                    (this.MenuRouter != null &&
                    this.MenuRouter.Equals(input.MenuRouter))
                ) && 
                (
                    this.Regular == input.Regular ||
                    (this.Regular != null &&
                    this.Regular.Equals(input.Regular))
                ) && 
                (
                    this.MenuType == input.MenuType ||
                    this.MenuType.Equals(input.MenuType)
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                hashCode = hashCode * 59 + this.IsCheck.GetHashCode();
                if (this.MenuRouter != null)
                    hashCode = hashCode * 59 + this.MenuRouter.GetHashCode();
                if (this.Regular != null)
                    hashCode = hashCode * 59 + this.Regular.GetHashCode();
                hashCode = hashCode * 59 + this.MenuType.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
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
