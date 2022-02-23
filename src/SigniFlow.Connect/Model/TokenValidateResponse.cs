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
    /// #### This is the response returned when a session token is validated.
    /// </summary>
    [DataContract]
    public partial class TokenValidateResponse :  IEquatable<TokenValidateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenValidateResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenValidateResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenValidateResponse" /> class.
        /// </summary>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        public TokenValidateResponse(string resultField = default(string), TokenField tokenField = default(TokenField))
        {
            // to ensure "resultField" is required (not null)
            if (resultField == null)
            {
                throw new InvalidDataException("resultField is a required property for TokenValidateResponse and cannot be null");
            }
            else
            {
                this.ResultField = resultField;
            }

            // to ensure "tokenField" is required (not null)
            if (tokenField == null)
            {
                throw new InvalidDataException("tokenField is a required property for TokenValidateResponse and cannot be null");
            }
            else
            {
                this.TokenField = tokenField;
            }

        }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name="ResultField", EmitDefaultValue=true)]        public string ResultField { get; set; }

        /// <summary>
        /// Gets or Sets TokenField
        /// </summary>
        [DataMember(Name="TokenField", EmitDefaultValue=true)]        public TokenField TokenField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenValidateResponse {\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
            sb.Append("  TokenField: ").Append(TokenField).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TokenValidateResponse);
        }

        /// <summary>
        /// Returns true if TokenValidateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenValidateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenValidateResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
                ) && 
                (
                    this.TokenField == input.TokenField ||
                    (this.TokenField != null &&
                    this.TokenField.Equals(input.TokenField))
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
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
                if (this.TokenField != null)
                    hashCode = hashCode * 59 + this.TokenField.GetHashCode();
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

            // ResultField (string) minLength
            if(this.ResultField != null && this.ResultField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultField, length must be greater than 1.", new [] { "ResultField" });
            }
 
            yield break;
        }
    }

}
