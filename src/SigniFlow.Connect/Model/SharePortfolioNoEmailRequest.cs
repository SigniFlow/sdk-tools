/*
 * SigniFlow OpenAPI Spec v1
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
    /// #### The request sent when a user wants to share a portfolio but does not want an email to be sent.
    /// </summary>
    [DataContract]
    public partial class SharePortfolioNoEmailRequest :  IEquatable<SharePortfolioNoEmailRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePortfolioNoEmailRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SharePortfolioNoEmailRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SharePortfolioNoEmailRequest" /> class.
        /// </summary>
        /// <param name="accessLevelField">accessLevelField (required).</param>
        /// <param name="portfolioIDField">portfolioIDField (required).</param>
        /// <param name="shareOptionField">shareOptionField (required).</param>
        /// <param name="tokenField">tokenField (required).</param>
        /// <param name="uniqueIDField">uniqueIDField (required).</param>
        public SharePortfolioNoEmailRequest(decimal accessLevelField = default(decimal), string portfolioIDField = default(string), decimal shareOptionField = default(decimal), TokenField tokenField = default(TokenField), string uniqueIDField = default(string))
        {
            // to ensure "accessLevelField" is required (not null)
            if (accessLevelField == null)
            {
                throw new InvalidDataException("accessLevelField is a required property for SharePortfolioNoEmailRequest and cannot be null");
            }
            else
            {
                this.AccessLevelField = accessLevelField;
            }

            // to ensure "portfolioIDField" is required (not null)
            if (portfolioIDField == null)
            {
                throw new InvalidDataException("portfolioIDField is a required property for SharePortfolioNoEmailRequest and cannot be null");
            }
            else
            {
                this.PortfolioIDField = portfolioIDField;
            }

            // to ensure "shareOptionField" is required (not null)
            if (shareOptionField == null)
            {
                throw new InvalidDataException("shareOptionField is a required property for SharePortfolioNoEmailRequest and cannot be null");
            }
            else
            {
                this.ShareOptionField = shareOptionField;
            }

            // to ensure "tokenField" is required (not null)
            if (tokenField == null)
            {
                throw new InvalidDataException("tokenField is a required property for SharePortfolioNoEmailRequest and cannot be null");
            }
            else
            {
                this.TokenField = tokenField;
            }

            // to ensure "uniqueIDField" is required (not null)
            if (uniqueIDField == null)
            {
                throw new InvalidDataException("uniqueIDField is a required property for SharePortfolioNoEmailRequest and cannot be null");
            }
            else
            {
                this.UniqueIDField = uniqueIDField;
            }

        }

        /// <summary>
        /// Gets or Sets AccessLevelField
        /// </summary>
        [DataMember(Name="AccessLevelField", EmitDefaultValue=true)]
        public decimal AccessLevelField { get; set; }

        /// <summary>
        /// Gets or Sets PortfolioIDField
        /// </summary>
        [DataMember(Name="PortfolioIDField", EmitDefaultValue=true)]
        public string PortfolioIDField { get; set; }

        /// <summary>
        /// Gets or Sets ShareOptionField
        /// </summary>
        [DataMember(Name="ShareOptionField", EmitDefaultValue=true)]
        public decimal ShareOptionField { get; set; }

        /// <summary>
        /// Gets or Sets TokenField
        /// </summary>
        [DataMember(Name="TokenField", EmitDefaultValue=true)]
        public TokenField TokenField { get; set; }

        /// <summary>
        /// Gets or Sets UniqueIDField
        /// </summary>
        [DataMember(Name="UniqueIDField", EmitDefaultValue=true)]
        public string UniqueIDField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharePortfolioNoEmailRequest {\n");
            sb.Append("  AccessLevelField: ").Append(AccessLevelField).Append("\n");
            sb.Append("  PortfolioIDField: ").Append(PortfolioIDField).Append("\n");
            sb.Append("  ShareOptionField: ").Append(ShareOptionField).Append("\n");
            sb.Append("  TokenField: ").Append(TokenField).Append("\n");
            sb.Append("  UniqueIDField: ").Append(UniqueIDField).Append("\n");
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
            return this.Equals(input as SharePortfolioNoEmailRequest);
        }

        /// <summary>
        /// Returns true if SharePortfolioNoEmailRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SharePortfolioNoEmailRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharePortfolioNoEmailRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessLevelField == input.AccessLevelField ||
                    (this.AccessLevelField != null &&
                    this.AccessLevelField.Equals(input.AccessLevelField))
                ) && 
                (
                    this.PortfolioIDField == input.PortfolioIDField ||
                    (this.PortfolioIDField != null &&
                    this.PortfolioIDField.Equals(input.PortfolioIDField))
                ) && 
                (
                    this.ShareOptionField == input.ShareOptionField ||
                    (this.ShareOptionField != null &&
                    this.ShareOptionField.Equals(input.ShareOptionField))
                ) && 
                (
                    this.TokenField == input.TokenField ||
                    (this.TokenField != null &&
                    this.TokenField.Equals(input.TokenField))
                ) && 
                (
                    this.UniqueIDField == input.UniqueIDField ||
                    (this.UniqueIDField != null &&
                    this.UniqueIDField.Equals(input.UniqueIDField))
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
                if (this.AccessLevelField != null)
                    hashCode = hashCode * 59 + this.AccessLevelField.GetHashCode();
                if (this.PortfolioIDField != null)
                    hashCode = hashCode * 59 + this.PortfolioIDField.GetHashCode();
                if (this.ShareOptionField != null)
                    hashCode = hashCode * 59 + this.ShareOptionField.GetHashCode();
                if (this.TokenField != null)
                    hashCode = hashCode * 59 + this.TokenField.GetHashCode();
                if (this.UniqueIDField != null)
                    hashCode = hashCode * 59 + this.UniqueIDField.GetHashCode();
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

            // PortfolioIDField (string) minLength
            if(this.PortfolioIDField != null && this.PortfolioIDField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PortfolioIDField, length must be greater than 1.", new [] { "PortfolioIDField" });
            }
 

            // UniqueIDField (string) minLength
            if(this.UniqueIDField != null && this.UniqueIDField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UniqueIDField, length must be greater than 1.", new [] { "UniqueIDField" });
            }
 
            yield break;
        }
    }

}
