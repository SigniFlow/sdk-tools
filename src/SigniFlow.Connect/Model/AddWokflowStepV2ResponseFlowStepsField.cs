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
    /// AddWokflowStepV2ResponseFlowStepsField
    /// </summary>
    [DataContract]
    public partial class AddWokflowStepV2ResponseFlowStepsField :  IEquatable<AddWokflowStepV2ResponseFlowStepsField>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ActionField
        /// </summary>
        [DataMember(Name="ActionField", EmitDefaultValue=true)]
        public ActionField ActionField { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWokflowStepV2ResponseFlowStepsField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddWokflowStepV2ResponseFlowStepsField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddWokflowStepV2ResponseFlowStepsField" /> class.
        /// </summary>
        /// <param name="actionField">actionField (required).</param>
        /// <param name="emailField">Participant email address field. (required).</param>
        /// <param name="flowIDField">Document Flow ID field. (required).</param>
        public AddWokflowStepV2ResponseFlowStepsField(ActionField actionField = default(ActionField), string emailField = default(string), decimal flowIDField = default(decimal))
        {
            // to ensure "actionField" is required (not null)
            if (actionField == null)
            {
                throw new InvalidDataException("actionField is a required property for AddWokflowStepV2ResponseFlowStepsField and cannot be null");
            }
            else
            {
                this.ActionField = actionField;
            }

            // to ensure "emailField" is required (not null)
            if (emailField == null)
            {
                throw new InvalidDataException("emailField is a required property for AddWokflowStepV2ResponseFlowStepsField and cannot be null");
            }
            else
            {
                this.EmailField = emailField;
            }

            // to ensure "flowIDField" is required (not null)
            if (flowIDField == null)
            {
                throw new InvalidDataException("flowIDField is a required property for AddWokflowStepV2ResponseFlowStepsField and cannot be null");
            }
            else
            {
                this.FlowIDField = flowIDField;
            }

        }


        /// <summary>
        /// Participant email address field.
        /// </summary>
        /// <value>Participant email address field.</value>
        [DataMember(Name="EmailField", EmitDefaultValue=true)]        public string EmailField { get; set; }

        /// <summary>
        /// Document Flow ID field.
        /// </summary>
        /// <value>Document Flow ID field.</value>
        [DataMember(Name="FlowIDField", EmitDefaultValue=true)]        public decimal FlowIDField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddWokflowStepV2ResponseFlowStepsField {\n");
            sb.Append("  ActionField: ").Append(ActionField).Append("\n");
            sb.Append("  EmailField: ").Append(EmailField).Append("\n");
            sb.Append("  FlowIDField: ").Append(FlowIDField).Append("\n");
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
            return this.Equals(input as AddWokflowStepV2ResponseFlowStepsField);
        }

        /// <summary>
        /// Returns true if AddWokflowStepV2ResponseFlowStepsField instances are equal
        /// </summary>
        /// <param name="input">Instance of AddWokflowStepV2ResponseFlowStepsField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddWokflowStepV2ResponseFlowStepsField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionField == input.ActionField ||
                    (this.ActionField != null &&
                    this.ActionField.Equals(input.ActionField))
                ) && 
                (
                    this.EmailField == input.EmailField ||
                    (this.EmailField != null &&
                    this.EmailField.Equals(input.EmailField))
                ) && 
                (
                    this.FlowIDField == input.FlowIDField ||
                    (this.FlowIDField != null &&
                    this.FlowIDField.Equals(input.FlowIDField))
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
                if (this.ActionField != null)
                    hashCode = hashCode * 59 + this.ActionField.GetHashCode();
                if (this.EmailField != null)
                    hashCode = hashCode * 59 + this.EmailField.GetHashCode();
                if (this.FlowIDField != null)
                    hashCode = hashCode * 59 + this.FlowIDField.GetHashCode();
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

            // EmailField (string) minLength
            if(this.EmailField != null && this.EmailField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailField, length must be greater than 1.", new [] { "EmailField" });
            }
 
            yield break;
        }
    }

}
