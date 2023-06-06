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
    /// LogSimulationItem
    /// </summary>
    [DataContract]
    public partial class LogSimulationItem :  IEquatable<LogSimulationItem>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ModelState
        /// </summary>
        [DataMember(Name="modelState", EmitDefaultValue=false)]
        public ModelStateEnum? ModelState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogSimulationItem" /> class.
        /// </summary>
        /// <param name="time">日志记录时间 log time.</param>
        /// <param name="progress">计算进度 calculation progress.</param>
        /// <param name="message">消息 remark message.</param>
        /// <param name="modelState">modelState.</param>
        /// <param name="errorMsg">错误信息 error message.</param>
        public LogSimulationItem(string time = default(string), double progress = default(double), string message = default(string), ModelStateEnum? modelState = default(ModelStateEnum?), string errorMsg = default(string))
        {
            this.Time = time;
            this.Progress = progress;
            this.Message = message;
            this.ModelState = modelState;
            this.ErrorMsg = errorMsg;
        }
        
        /// <summary>
        /// 日志记录时间 log time
        /// </summary>
        /// <value>日志记录时间 log time</value>
        [DataMember(Name="time", EmitDefaultValue=true)]
        public string Time { get; set; }

        /// <summary>
        /// 计算进度 calculation progress
        /// </summary>
        /// <value>计算进度 calculation progress</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public double Progress { get; set; }

        /// <summary>
        /// 消息 remark message
        /// </summary>
        /// <value>消息 remark message</value>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// 错误信息 error message
        /// </summary>
        /// <value>错误信息 error message</value>
        [DataMember(Name="errorMsg", EmitDefaultValue=true)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogSimulationItem {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ModelState: ").Append(ModelState).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
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
            return this.Equals(input as LogSimulationItem);
        }

        /// <summary>
        /// Returns true if LogSimulationItem instances are equal
        /// </summary>
        /// <param name="input">Instance of LogSimulationItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogSimulationItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Progress == input.Progress ||
                    this.Progress.Equals(input.Progress)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.ModelState == input.ModelState ||
                    this.ModelState.Equals(input.ModelState)
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.ModelState.GetHashCode();
                if (this.ErrorMsg != null)
                    hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
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