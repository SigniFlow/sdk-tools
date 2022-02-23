/*
 * WorkFlow API
 *
 * ## SigniFlow API used to automate esignature workflow creation and management. 
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@signiflow.com
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
using OpenAPIDateConverter = SigniFlow.Connect.Client.OpenAPIDateConverter;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    /// #### Determines whether or not the signer can nominate someone else to signon their behalf.  &#x60;0 &#x3D; No 1 &#x3D; Yes&#x60;
    /// </summary>
    /// <value>#### Determines whether or not the signer can nominate someone else to signon their behalf.  &#x60;0 &#x3D; No 1 &#x3D; Yes&#x60;</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ProxyAllowedField
    {
        /// <summary>
        /// Enum No for value: 0
        /// </summary>
        [EnumMember(Value = "0")]
        No = 1,

        /// <summary>
        /// Enum Yes for value: 1
        /// </summary>
        [EnumMember(Value = "1")]
        Yes = 2

    }

}
