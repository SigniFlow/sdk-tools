/*
 * SigniFlow API
 *
 * API for signing ceremonies
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = SigniFlow.Connect.Client.OpenAPIDateConverter;

namespace SigniFlow.Connect.Model
{
    /// <summary>
    /// SigningCeremonyWithTokenResponse
    /// </summary>
    [DataContract(Name = "SigningCeremonyWithTokenResponse")]
    public partial class SigningCeremonyWithTokenResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyWithTokenResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SigningCeremonyWithTokenResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SigningCeremonyWithTokenResponse" /> class.
        /// </summary>
        /// <param name="ceremonyIDField">Unique ID of the signing ceremony (required).</param>
        /// <param name="resultField">Result of the signing process (required).</param>
        /// <param name="signedDocumentField">The signed document in base64 encoded format (required).</param>
        public SigningCeremonyWithTokenResponse(int ceremonyIDField = default(int), string resultField = default(string), string signedDocumentField = default(string))
        {
            this.CeremonyIDField = ceremonyIDField;
            // to ensure "resultField" is required (not null)
            if (resultField == null)
            {
                throw new ArgumentNullException("resultField is a required property for SigningCeremonyWithTokenResponse and cannot be null");
            }
            this.ResultField = resultField;
            // to ensure "signedDocumentField" is required (not null)
            if (signedDocumentField == null)
            {
                throw new ArgumentNullException("signedDocumentField is a required property for SigningCeremonyWithTokenResponse and cannot be null");
            }
            this.SignedDocumentField = signedDocumentField;
        }

        /// <summary>
        /// Unique ID of the signing ceremony
        /// </summary>
        /// <value>Unique ID of the signing ceremony</value>
        [DataMember(Name = "CeremonyIDField", IsRequired = true, EmitDefaultValue = true)]
        public int CeremonyIDField { get; set; }

        /// <summary>
        /// Result of the signing process
        /// </summary>
        /// <value>Result of the signing process</value>
        [DataMember(Name = "ResultField", IsRequired = true, EmitDefaultValue = true)]
        public string ResultField { get; set; }

        /// <summary>
        /// The signed document in base64 encoded format
        /// </summary>
        /// <value>The signed document in base64 encoded format</value>
        [DataMember(Name = "SignedDocumentField", IsRequired = true, EmitDefaultValue = true)]
        public string SignedDocumentField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SigningCeremonyWithTokenResponse {\n");
            sb.Append("  CeremonyIDField: ").Append(CeremonyIDField).Append("\n");
            sb.Append("  ResultField: ").Append(ResultField).Append("\n");
            sb.Append("  SignedDocumentField: ").Append(SignedDocumentField).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
