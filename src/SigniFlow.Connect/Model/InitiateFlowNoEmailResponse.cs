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
    /// #### The response returned when a workflow is requested without any email.
    /// </summary>
    [DataContract]
    public partial class InitiateFlowNoEmailResponse :  IEquatable<InitiateFlowNoEmailResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateFlowNoEmailResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InitiateFlowNoEmailResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiateFlowNoEmailResponse" /> class.
        /// </summary>
        /// <param name="docIDField">Document ID. (required).</param>
        /// <param name="resultField">Displays the result of the call. (required).</param>
        public InitiateFlowNoEmailResponse(decimal docIDField = default(decimal), string resultField = default(string))
        {
            // to ensure "docIDField" is required (not null)
            if (docIDField == null)
            {
                throw new InvalidDataException("docIDField is a required property for InitiateFlowNoEmailResponse and cannot be null");
            }
            else
            {
                this.DocIDField = docIDField;
            }

            // to ensure "resultField" is required (not null)
            if (resultField == null)
            {
                throw new InvalidDataException("resultField is a required property for InitiateFlowNoEmailResponse and cannot be null");
            }
            else
            {
                this.ResultField = resultField;
            }

        }

        /// <summary>
        /// Document ID.
        /// </summary>
        /// <value>Document ID.</value>
        [DataMember(Name="DocIDField", EmitDefaultValue=true)]        public decimal DocIDField { get; set; }

        /// <summary>
        /// Displays the result of the call.
        /// </summary>
        /// <value>Displays the result of the call.</value>
        [DataMember(Name="ResultField", EmitDefaultValue=true)]        public string ResultField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitiateFlowNoEmailResponse {\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
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
            return this.Equals(input as InitiateFlowNoEmailResponse);
        }

        /// <summary>
        /// Returns true if InitiateFlowNoEmailResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiateFlowNoEmailResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiateFlowNoEmailResponse input)
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
                    this.ResultField == input.ResultField ||
                    (this.ResultField != null &&
                    this.ResultField.Equals(input.ResultField))
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
                if (this.ResultField != null)
                    hashCode = hashCode * 59 + this.ResultField.GetHashCode();
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
