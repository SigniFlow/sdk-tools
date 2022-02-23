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
    /// SigningCeremonyV2RequestInitialFieldsListField
    /// </summary>
    [DataContract]
    public partial class SigningCeremonyV2RequestInitialFieldsListField :  IEquatable<SigningCeremonyV2RequestInitialFieldsListField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyV2RequestInitialFieldsListField" /> class.
        /// </summary>
        /// <param name="initialHField">Initial field height..</param>
        /// <param name="initialImageField">Initial field image..</param>
        /// <param name="initialImageTypeField">Initial field image type..</param>
        /// <param name="initialPageField">The page on which the initial field is located..</param>
        /// <param name="initialWField">Initial field width..</param>
        /// <param name="initialXField">Initial field x-coordinates..</param>
        /// <param name="initialYField">Initial field y-coordinates..</param>
        public SigningCeremonyV2RequestInitialFieldsListField(decimal initialHField = default(decimal), string initialImageField = default(string), decimal initialImageTypeField = default(decimal), decimal initialPageField = default(decimal), decimal initialWField = default(decimal), decimal initialXField = default(decimal), decimal initialYField = default(decimal))
        {
            this.InitialHField = initialHField;
            this.InitialImageField = initialImageField;
            this.InitialImageTypeField = initialImageTypeField;
            this.InitialPageField = initialPageField;
            this.InitialWField = initialWField;
            this.InitialXField = initialXField;
            this.InitialYField = initialYField;
        }

        /// <summary>
        /// Initial field height.
        /// </summary>
        /// <value>Initial field height.</value>
        [DataMember(Name="InitialHField", EmitDefaultValue=false)]        public decimal InitialHField { get; set; }

        /// <summary>
        /// Initial field image.
        /// </summary>
        /// <value>Initial field image.</value>
        [DataMember(Name="InitialImageField", EmitDefaultValue=false)]        public string InitialImageField { get; set; }

        /// <summary>
        /// Initial field image type.
        /// </summary>
        /// <value>Initial field image type.</value>
        [DataMember(Name="InitialImageTypeField", EmitDefaultValue=false)]        public decimal InitialImageTypeField { get; set; }

        /// <summary>
        /// The page on which the initial field is located.
        /// </summary>
        /// <value>The page on which the initial field is located.</value>
        [DataMember(Name="InitialPageField", EmitDefaultValue=false)]        public decimal InitialPageField { get; set; }

        /// <summary>
        /// Initial field width.
        /// </summary>
        /// <value>Initial field width.</value>
        [DataMember(Name="InitialWField", EmitDefaultValue=false)]        public decimal InitialWField { get; set; }

        /// <summary>
        /// Initial field x-coordinates.
        /// </summary>
        /// <value>Initial field x-coordinates.</value>
        [DataMember(Name="InitialXField", EmitDefaultValue=false)]        public decimal InitialXField { get; set; }

        /// <summary>
        /// Initial field y-coordinates.
        /// </summary>
        /// <value>Initial field y-coordinates.</value>
        [DataMember(Name="InitialYField", EmitDefaultValue=false)]        public decimal InitialYField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigningCeremonyV2RequestInitialFieldsListField {\n");
            sb.Append("  InitialHField: ").Append(InitialHField).Append("\n");
            sb.Append("  InitialImageField: ").Append(InitialImageField).Append("\n");
            sb.Append("  InitialImageTypeField: ").Append(InitialImageTypeField).Append("\n");
            sb.Append("  InitialPageField: ").Append(InitialPageField).Append("\n");
            sb.Append("  InitialWField: ").Append(InitialWField).Append("\n");
            sb.Append("  InitialXField: ").Append(InitialXField).Append("\n");
            sb.Append("  InitialYField: ").Append(InitialYField).Append("\n");
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
            return this.Equals(input as SigningCeremonyV2RequestInitialFieldsListField);
        }

        /// <summary>
        /// Returns true if SigningCeremonyV2RequestInitialFieldsListField instances are equal
        /// </summary>
        /// <param name="input">Instance of SigningCeremonyV2RequestInitialFieldsListField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigningCeremonyV2RequestInitialFieldsListField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InitialHField == input.InitialHField ||
                    (this.InitialHField != null &&
                    this.InitialHField.Equals(input.InitialHField))
                ) && 
                (
                    this.InitialImageField == input.InitialImageField ||
                    (this.InitialImageField != null &&
                    this.InitialImageField.Equals(input.InitialImageField))
                ) && 
                (
                    this.InitialImageTypeField == input.InitialImageTypeField ||
                    (this.InitialImageTypeField != null &&
                    this.InitialImageTypeField.Equals(input.InitialImageTypeField))
                ) && 
                (
                    this.InitialPageField == input.InitialPageField ||
                    (this.InitialPageField != null &&
                    this.InitialPageField.Equals(input.InitialPageField))
                ) && 
                (
                    this.InitialWField == input.InitialWField ||
                    (this.InitialWField != null &&
                    this.InitialWField.Equals(input.InitialWField))
                ) && 
                (
                    this.InitialXField == input.InitialXField ||
                    (this.InitialXField != null &&
                    this.InitialXField.Equals(input.InitialXField))
                ) && 
                (
                    this.InitialYField == input.InitialYField ||
                    (this.InitialYField != null &&
                    this.InitialYField.Equals(input.InitialYField))
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
                if (this.InitialHField != null)
                    hashCode = hashCode * 59 + this.InitialHField.GetHashCode();
                if (this.InitialImageField != null)
                    hashCode = hashCode * 59 + this.InitialImageField.GetHashCode();
                if (this.InitialImageTypeField != null)
                    hashCode = hashCode * 59 + this.InitialImageTypeField.GetHashCode();
                if (this.InitialPageField != null)
                    hashCode = hashCode * 59 + this.InitialPageField.GetHashCode();
                if (this.InitialWField != null)
                    hashCode = hashCode * 59 + this.InitialWField.GetHashCode();
                if (this.InitialXField != null)
                    hashCode = hashCode * 59 + this.InitialXField.GetHashCode();
                if (this.InitialYField != null)
                    hashCode = hashCode * 59 + this.InitialYField.GetHashCode();
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

            // InitialImageField (string) minLength
            if(this.InitialImageField != null && this.InitialImageField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InitialImageField, length must be greater than 1.", new [] { "InitialImageField" });
            }
 
            yield break;
        }
    }

}