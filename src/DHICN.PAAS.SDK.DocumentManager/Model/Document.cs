/* 
 * document-manager-service
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
using OpenAPIDateConverter = DHICN.PAAS.SDK.DocumentManager.Client.OpenAPIDateConverter;

namespace DHICN.PAAS.SDK.DocumentManager.Model
{
    /// <summary>
    /// Document
    /// </summary>
    [DataContract]
    public partial class Document :  IEquatable<Document>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Document() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="author">author (required).</param>
        /// <param name="summary">summary.</param>
        /// <param name="description">description.</param>
        /// <param name="language">language.</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="dataId">dataId.</param>
        /// <param name="format">format (required).</param>
        /// <param name="modifiedTime">modifiedTime (required).</param>
        /// <param name="dataStorage">dataStorage.</param>
        /// <param name="version">version.</param>
        /// <param name="tenantId">tenantId.</param>
        public Document(Guid id = default(Guid), string title = default(string), string author = default(string), string summary = default(string), string description = default(string), string language = default(string), string keywords = default(string), Guid? dataId = default(Guid?), string format = default(string), DateTime modifiedTime = default(DateTime), string dataStorage = default(string), Guid version = default(Guid), string tenantId = default(string))
        {
            this.Id = id;
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for Document and cannot be null");
            // to ensure "author" is required (not null)
            this.Author = author ?? throw new ArgumentNullException("author is a required property for Document and cannot be null");
            // to ensure "format" is required (not null)
            this.Format = format ?? throw new ArgumentNullException("format is a required property for Document and cannot be null");
            this.ModifiedTime = modifiedTime;
            this.Summary = summary;
            this.Description = description;
            this.Language = language;
            this.Keywords = keywords;
            this.DataId = dataId;
            this.DataStorage = dataStorage;
            this.Version = version;
            this.TenantId = tenantId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=true)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=true)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or Sets DataId
        /// </summary>
        [DataMember(Name="dataId", EmitDefaultValue=true)]
        public Guid? DataId { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets ModifiedTime
        /// </summary>
        [DataMember(Name="modifiedTime", EmitDefaultValue=false)]
        public DateTime ModifiedTime { get; set; }

        /// <summary>
        /// Gets or Sets DataStorage
        /// </summary>
        [DataMember(Name="dataStorage", EmitDefaultValue=true)]
        public string DataStorage { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Guid Version { get; set; }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name="tenantId", EmitDefaultValue=true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  DataId: ").Append(DataId).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  ModifiedTime: ").Append(ModifiedTime).Append("\n");
            sb.Append("  DataStorage: ").Append(DataStorage).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="input">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document input)
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
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    (this.Keywords != null &&
                    this.Keywords.Equals(input.Keywords))
                ) && 
                (
                    this.DataId == input.DataId ||
                    (this.DataId != null &&
                    this.DataId.Equals(input.DataId))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.ModifiedTime == input.ModifiedTime ||
                    (this.ModifiedTime != null &&
                    this.ModifiedTime.Equals(input.ModifiedTime))
                ) && 
                (
                    this.DataStorage == input.DataStorage ||
                    (this.DataStorage != null &&
                    this.DataStorage.Equals(input.DataStorage))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.DataId != null)
                    hashCode = hashCode * 59 + this.DataId.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.ModifiedTime != null)
                    hashCode = hashCode * 59 + this.ModifiedTime.GetHashCode();
                if (this.DataStorage != null)
                    hashCode = hashCode * 59 + this.DataStorage.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
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
            // Title (string) maxLength
            if(this.Title != null && this.Title.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 255.", new [] { "Title" });
            }

            // Title (string) minLength
            if(this.Title != null && this.Title.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 0.", new [] { "Title" });
            }

  
            // Author (string) maxLength
            if(this.Author != null && this.Author.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Author, length must be less than 255.", new [] { "Author" });
            }

            // Author (string) minLength
            if(this.Author != null && this.Author.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Author, length must be greater than 0.", new [] { "Author" });
            }

  
            // Summary (string) maxLength
            if(this.Summary != null && this.Summary.Length > 8000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Summary, length must be less than 8000.", new [] { "Summary" });
            }

            // Summary (string) minLength
            if(this.Summary != null && this.Summary.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Summary, length must be greater than 0.", new [] { "Summary" });
            }

  
            // Description (string) maxLength
            if(this.Description != null && this.Description.Length > 8000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 8000.", new [] { "Description" });
            }

            // Description (string) minLength
            if(this.Description != null && this.Description.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 0.", new [] { "Description" });
            }

  
            // Language (string) maxLength
            if(this.Language != null && this.Language.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, length must be less than 50.", new [] { "Language" });
            }

            // Language (string) minLength
            if(this.Language != null && this.Language.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, length must be greater than 0.", new [] { "Language" });
            }

  
            // Keywords (string) maxLength
            if(this.Keywords != null && this.Keywords.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Keywords, length must be less than 1024.", new [] { "Keywords" });
            }

            // Keywords (string) minLength
            if(this.Keywords != null && this.Keywords.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Keywords, length must be greater than 0.", new [] { "Keywords" });
            }

  
            // Format (string) maxLength
            if(this.Format != null && this.Format.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Format, length must be less than 50.", new [] { "Format" });
            }

            // Format (string) minLength
            if(this.Format != null && this.Format.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Format, length must be greater than 0.", new [] { "Format" });
            }

  
            yield break;
        }
    }

}