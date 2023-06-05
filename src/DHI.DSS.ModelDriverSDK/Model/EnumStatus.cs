/* 
 * model-driver-service
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
using OpenAPIDateConverter = DHI.DSS.ModelDriverSDK.Client.OpenAPIDateConverter;

namespace DHI.DSS.ModelDriverSDK.Model
{
    /// <summary>
    /// 0-Computed 1-Waiting 2-Computing 3-UnCompute -3-Cancelling -2-Canceled -1-Failed 
    /// </summary>
    /// <value>0-Computed 1-Waiting 2-Computing 3-UnCompute -3-Cancelling -2-Canceled -1-Failed </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EnumStatus
    {
        /// <summary>
        /// Enum NUMBER_0 for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        NUMBER_0 = 1,

        /// <summary>
        /// Enum NUMBER_1 for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        NUMBER_1 = 2,

        /// <summary>
        /// Enum NUMBER_2 for value: 2
        /// </summary>
        [EnumMember(Value = "2")]
        NUMBER_2 = 3,

        /// <summary>
        /// Enum NUMBER_3 for value: 3
        /// </summary>
        [EnumMember(Value = "3")]
        NUMBER_3 = 4,

        /// <summary>
        /// Enum NUMBER_MINUS_3 for value: -3
        /// </summary>
        [EnumMember(Value = "-3")]
        NUMBER_MINUS_3 = 5,

        /// <summary>
        /// Enum NUMBER_MINUS_2 for value: -2
        /// </summary>
        [EnumMember(Value = "-2")]
        NUMBER_MINUS_2 = 6,

        /// <summary>
        /// Enum NUMBER_MINUS_1 for value: -1
        /// </summary>
        [EnumMember(Value = "-1")]
        NUMBER_MINUS_1 = 7

    }

}