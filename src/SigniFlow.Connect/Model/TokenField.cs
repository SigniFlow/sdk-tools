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
    /// #### Authentication Token
    /// </summary>
    [DataContract]
    public partial class TokenField :  IEquatable<TokenField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenField" /> class.
        /// </summary>
        /// <param name="tokenExpiryField">Expiry date of Token (required).</param>
        /// <param name="tokenField">User API Token (required).</param>
        public TokenField(DateTime tokenExpiryField = default(DateTime), string tokenField = default(string))
        {
            // to ensure "tokenExpiryField" is required (not null)
            if (tokenExpiryField == null)
            {
                throw new InvalidDataException("tokenExpiryField is a required property for TokenField and cannot be null");
            }
            else
            {
                this.TokenExpiryField = tokenExpiryField;
            }

            // to ensure "tokenField" is required (not null)
            if (tokenField == null)
            {
                throw new InvalidDataException("tokenField is a required property for TokenField and cannot be null");
            }
            else
            {
                this._TokenField = tokenField;
            }

        }

        /// <summary>
        /// Expiry date of Token
        /// </summary>
        /// <value>Expiry date of Token</value>
        [DataMember(Name="TokenExpiryField", EmitDefaultValue=true)]        public DateTime TokenExpiryField { get; set; }

        /// <summary>
        /// User API Token
        /// </summary>
        /// <value>User API Token</value>
        [DataMember(Name="TokenField", EmitDefaultValue=true)]        public string _TokenField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenField {\n");
            sb.Append("  TokenExpiryField: ").Append(TokenExpiryField).Append("\n");
            sb.Append("  _TokenField: ").Append(_TokenField).Append("\n");
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
            return this.Equals(input as TokenField);
        }

        /// <summary>
        /// Returns true if TokenField instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TokenExpiryField == input.TokenExpiryField ||
                    (this.TokenExpiryField != null &&
                    this.TokenExpiryField.Equals(input.TokenExpiryField))
                ) && 
                (
                    this._TokenField == input._TokenField ||
                    (this._TokenField != null &&
                    this._TokenField.Equals(input._TokenField))
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
                if (this.TokenExpiryField != null)
                    hashCode = hashCode * 59 + this.TokenExpiryField.GetHashCode();
                if (this._TokenField != null)
                    hashCode = hashCode * 59 + this._TokenField.GetHashCode();
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
