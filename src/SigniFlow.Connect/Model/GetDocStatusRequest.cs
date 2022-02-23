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
    /// #### This is the request used to get the document status.
    /// </summary>
    [DataContract]
    public partial class GetDocStatusRequest :  IEquatable<GetDocStatusRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocStatusRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDocStatusRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocStatusRequest" /> class.
        /// </summary>
        /// <param name="docIDField">Document ID (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        public GetDocStatusRequest(decimal docIDField = default(decimal), TokenField tokenField = default(TokenField))
        {
            // to ensure "docIDField" is required (not null)
            if (docIDField == null)
            {
                throw new InvalidDataException("docIDField is a required property for GetDocStatusRequest and cannot be null");
            }
            else
            {
                this.DocIDField = docIDField;
            }

            // to ensure "tokenField" is required (not null)
            if (tokenField == null)
            {
                throw new InvalidDataException("tokenField is a required property for GetDocStatusRequest and cannot be null");
            }
            else
            {
                this.TokenField = tokenField;
            }

        }

        /// <summary>
        /// Document ID
        /// </summary>
        /// <value>Document ID</value>
        [DataMember(Name="DocIDField", EmitDefaultValue=true)]        public decimal DocIDField { get; set; }

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
            sb.Append("class GetDocStatusRequest {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
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
            return this.Equals(input as GetDocStatusRequest);
        }

        /// <summary>
        /// Returns true if GetDocStatusRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocStatusRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocStatusRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DocIDField == input.DocIDField ||
                    (this.DocIDField != null &&
                    this.DocIDField.Equals(input.DocIDField))
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
                if (this.DocIDField != null)
                    hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
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
            yield break;
        }
    }

}
