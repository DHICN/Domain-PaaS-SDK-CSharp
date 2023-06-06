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
    /// HttpResponseMessage
    /// </summary>
    [DataContract]
    public partial class HttpResponseMessage :  IEquatable<HttpResponseMessage>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets StatusCode
        /// </summary>
        [DataMember(Name="statusCode", EmitDefaultValue=false)]
        public HttpStatusCode? StatusCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpResponseMessage" /> class.
        /// </summary>
        /// <param name="version">version.</param>
        /// <param name="content">content.</param>
        /// <param name="statusCode">statusCode.</param>
        /// <param name="reasonPhrase">reasonPhrase.</param>
        /// <param name="requestMessage">requestMessage.</param>
        public HttpResponseMessage(Version version = default(Version), HttpContent content = default(HttpContent), HttpStatusCode? statusCode = default(HttpStatusCode?), string reasonPhrase = default(string), HttpRequestMessage requestMessage = default(HttpRequestMessage))
        {
            this.Version = version;
            this.Content = content;
            this.StatusCode = statusCode;
            this.ReasonPhrase = reasonPhrase;
            this.RequestMessage = requestMessage;
        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public Version Version { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public HttpContent Content { get; set; }

        /// <summary>
        /// Gets or Sets ReasonPhrase
        /// </summary>
        [DataMember(Name="reasonPhrase", EmitDefaultValue=true)]
        public string ReasonPhrase { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="headers", EmitDefaultValue=true)]
        public List<StringStringIEnumerableKeyValuePair> Headers { get; private set; }

        /// <summary>
        /// Gets or Sets TrailingHeaders
        /// </summary>
        [DataMember(Name="trailingHeaders", EmitDefaultValue=true)]
        public List<StringStringIEnumerableKeyValuePair> TrailingHeaders { get; private set; }

        /// <summary>
        /// Gets or Sets RequestMessage
        /// </summary>
        [DataMember(Name="requestMessage", EmitDefaultValue=false)]
        public HttpRequestMessage RequestMessage { get; set; }

        /// <summary>
        /// Gets or Sets IsSuccessStatusCode
        /// </summary>
        [DataMember(Name="isSuccessStatusCode", EmitDefaultValue=false)]
        public bool IsSuccessStatusCode { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpResponseMessage {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  ReasonPhrase: ").Append(ReasonPhrase).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  TrailingHeaders: ").Append(TrailingHeaders).Append("\n");
            sb.Append("  RequestMessage: ").Append(RequestMessage).Append("\n");
            sb.Append("  IsSuccessStatusCode: ").Append(IsSuccessStatusCode).Append("\n");
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
            return this.Equals(input as HttpResponseMessage);
        }

        /// <summary>
        /// Returns true if HttpResponseMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpResponseMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpResponseMessage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    this.StatusCode.Equals(input.StatusCode)
                ) && 
                (
                    this.ReasonPhrase == input.ReasonPhrase ||
                    (this.ReasonPhrase != null &&
                    this.ReasonPhrase.Equals(input.ReasonPhrase))
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.TrailingHeaders == input.TrailingHeaders ||
                    this.TrailingHeaders != null &&
                    input.TrailingHeaders != null &&
                    this.TrailingHeaders.SequenceEqual(input.TrailingHeaders)
                ) && 
                (
                    this.RequestMessage == input.RequestMessage ||
                    (this.RequestMessage != null &&
                    this.RequestMessage.Equals(input.RequestMessage))
                ) && 
                (
                    this.IsSuccessStatusCode == input.IsSuccessStatusCode ||
                    this.IsSuccessStatusCode.Equals(input.IsSuccessStatusCode)
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.ReasonPhrase != null)
                    hashCode = hashCode * 59 + this.ReasonPhrase.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.TrailingHeaders != null)
                    hashCode = hashCode * 59 + this.TrailingHeaders.GetHashCode();
                if (this.RequestMessage != null)
                    hashCode = hashCode * 59 + this.RequestMessage.GetHashCode();
                hashCode = hashCode * 59 + this.IsSuccessStatusCode.GetHashCode();
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