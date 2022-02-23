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
    /// GetDocumentAuditResponseActivityField
    /// </summary>
    [DataContract]
    public partial class GetDocumentAuditResponseActivityField :  IEquatable<GetDocumentAuditResponseActivityField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentAuditResponseActivityField" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDocumentAuditResponseActivityField() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentAuditResponseActivityField" /> class.
        /// </summary>
        /// <param name="actionOrderField">The order in which action will be taken. (required).</param>
        /// <param name="additionalField">Returns the additional information about the audit (i.e. IP Address and browser that was used/ Reason for rejection or expiration)..</param>
        /// <param name="docIDField">Document ID (required).</param>
        /// <param name="emailField">The user&#39;s email address. (required).</param>
        /// <param name="eventDateField">The date of the event. (required).</param>
        /// <param name="eventField">The type of the event that took place. (required).</param>
        /// <param name="eventStatusField">Status of the event (required).</param>
        /// <param name="locationField">GPS location (required).</param>
        /// <param name="orderDateField">The date when the event took place. (required).</param>
        /// <param name="pageField">What page of the document an event took place on - this is not always populated as some events don&#39;t take place on the document. (required).</param>
        /// <param name="userFullNameField">User&#39;s full name. (required).</param>
        public GetDocumentAuditResponseActivityField(string actionOrderField = default(string), string additionalField = default(string), string docIDField = default(string), string emailField = default(string), string eventDateField = default(string), string eventField = default(string), string eventStatusField = default(string), string locationField = default(string), string orderDateField = default(string), string pageField = default(string), string userFullNameField = default(string))
        {
            // to ensure "actionOrderField" is required (not null)
            if (actionOrderField == null)
            {
                throw new InvalidDataException("actionOrderField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.ActionOrderField = actionOrderField;
            }

            // to ensure "docIDField" is required (not null)
            if (docIDField == null)
            {
                throw new InvalidDataException("docIDField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.DocIDField = docIDField;
            }

            // to ensure "emailField" is required (not null)
            if (emailField == null)
            {
                throw new InvalidDataException("emailField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.EmailField = emailField;
            }

            // to ensure "eventDateField" is required (not null)
            if (eventDateField == null)
            {
                throw new InvalidDataException("eventDateField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.EventDateField = eventDateField;
            }

            // to ensure "eventField" is required (not null)
            if (eventField == null)
            {
                throw new InvalidDataException("eventField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.EventField = eventField;
            }

            // to ensure "eventStatusField" is required (not null)
            if (eventStatusField == null)
            {
                throw new InvalidDataException("eventStatusField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.EventStatusField = eventStatusField;
            }

            // to ensure "locationField" is required (not null)
            if (locationField == null)
            {
                throw new InvalidDataException("locationField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.LocationField = locationField;
            }

            // to ensure "orderDateField" is required (not null)
            if (orderDateField == null)
            {
                throw new InvalidDataException("orderDateField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.OrderDateField = orderDateField;
            }

            // to ensure "pageField" is required (not null)
            if (pageField == null)
            {
                throw new InvalidDataException("pageField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.PageField = pageField;
            }

            // to ensure "userFullNameField" is required (not null)
            if (userFullNameField == null)
            {
                throw new InvalidDataException("userFullNameField is a required property for GetDocumentAuditResponseActivityField and cannot be null");
            }
            else
            {
                this.UserFullNameField = userFullNameField;
            }

            this.AdditionalField = additionalField;
        }

        /// <summary>
        /// The order in which action will be taken.
        /// </summary>
        /// <value>The order in which action will be taken.</value>
        [DataMember(Name="ActionOrderField", EmitDefaultValue=true)]        public string ActionOrderField { get; set; }

        /// <summary>
        /// Returns the additional information about the audit (i.e. IP Address and browser that was used/ Reason for rejection or expiration).
        /// </summary>
        /// <value>Returns the additional information about the audit (i.e. IP Address and browser that was used/ Reason for rejection or expiration).</value>
        [DataMember(Name="AdditionalField", EmitDefaultValue=false)]        public string AdditionalField { get; set; }

        /// <summary>
        /// Document ID
        /// </summary>
        /// <value>Document ID</value>
        [DataMember(Name="DocIDField", EmitDefaultValue=true)]        public string DocIDField { get; set; }

        /// <summary>
        /// The user&#39;s email address.
        /// </summary>
        /// <value>The user&#39;s email address.</value>
        [DataMember(Name="EmailField", EmitDefaultValue=true)]        public string EmailField { get; set; }

        /// <summary>
        /// The date of the event.
        /// </summary>
        /// <value>The date of the event.</value>
        [DataMember(Name="EventDateField", EmitDefaultValue=true)]        public string EventDateField { get; set; }

        /// <summary>
        /// The type of the event that took place.
        /// </summary>
        /// <value>The type of the event that took place.</value>
        [DataMember(Name="EventField", EmitDefaultValue=true)]        public string EventField { get; set; }

        /// <summary>
        /// Status of the event
        /// </summary>
        /// <value>Status of the event</value>
        [DataMember(Name="EventStatusField", EmitDefaultValue=true)]        public string EventStatusField { get; set; }

        /// <summary>
        /// GPS location
        /// </summary>
        /// <value>GPS location</value>
        [DataMember(Name="LocationField", EmitDefaultValue=true)]        public string LocationField { get; set; }

        /// <summary>
        /// The date when the event took place.
        /// </summary>
        /// <value>The date when the event took place.</value>
        [DataMember(Name="OrderDateField", EmitDefaultValue=true)]        public string OrderDateField { get; set; }

        /// <summary>
        /// What page of the document an event took place on - this is not always populated as some events don&#39;t take place on the document.
        /// </summary>
        /// <value>What page of the document an event took place on - this is not always populated as some events don&#39;t take place on the document.</value>
        [DataMember(Name="PageField", EmitDefaultValue=true)]        public string PageField { get; set; }

        /// <summary>
        /// User&#39;s full name.
        /// </summary>
        /// <value>User&#39;s full name.</value>
        [DataMember(Name="UserFullNameField", EmitDefaultValue=true)]        public string UserFullNameField { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocumentAuditResponseActivityField {\n");
            sb.Append("  ActionOrderField: ").Append(ActionOrderField).Append("\n");
            sb.Append("  AdditionalField: ").Append(AdditionalField).Append("\n");
            sb.Append("  DocIDField: ").Append(DocIDField).Append("\n");
            sb.Append("  EmailField: ").Append(EmailField).Append("\n");
            sb.Append("  EventDateField: ").Append(EventDateField).Append("\n");
            sb.Append("  EventField: ").Append(EventField).Append("\n");
            sb.Append("  EventStatusField: ").Append(EventStatusField).Append("\n");
            sb.Append("  LocationField: ").Append(LocationField).Append("\n");
            sb.Append("  OrderDateField: ").Append(OrderDateField).Append("\n");
            sb.Append("  PageField: ").Append(PageField).Append("\n");
            sb.Append("  UserFullNameField: ").Append(UserFullNameField).Append("\n");
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
            return this.Equals(input as GetDocumentAuditResponseActivityField);
        }

        /// <summary>
        /// Returns true if GetDocumentAuditResponseActivityField instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocumentAuditResponseActivityField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocumentAuditResponseActivityField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionOrderField == input.ActionOrderField ||
                    (this.ActionOrderField != null &&
                    this.ActionOrderField.Equals(input.ActionOrderField))
                ) && 
                (
                    this.AdditionalField == input.AdditionalField ||
                    (this.AdditionalField != null &&
                    this.AdditionalField.Equals(input.AdditionalField))
                ) && 
                (
                    this.DocIDField == input.DocIDField ||
                    (this.DocIDField != null &&
                    this.DocIDField.Equals(input.DocIDField))
                ) && 
                (
                    this.EmailField == input.EmailField ||
                    (this.EmailField != null &&
                    this.EmailField.Equals(input.EmailField))
                ) && 
                (
                    this.EventDateField == input.EventDateField ||
                    (this.EventDateField != null &&
                    this.EventDateField.Equals(input.EventDateField))
                ) && 
                (
                    this.EventField == input.EventField ||
                    (this.EventField != null &&
                    this.EventField.Equals(input.EventField))
                ) && 
                (
                    this.EventStatusField == input.EventStatusField ||
                    (this.EventStatusField != null &&
                    this.EventStatusField.Equals(input.EventStatusField))
                ) && 
                (
                    this.LocationField == input.LocationField ||
                    (this.LocationField != null &&
                    this.LocationField.Equals(input.LocationField))
                ) && 
                (
                    this.OrderDateField == input.OrderDateField ||
                    (this.OrderDateField != null &&
                    this.OrderDateField.Equals(input.OrderDateField))
                ) && 
                (
                    this.PageField == input.PageField ||
                    (this.PageField != null &&
                    this.PageField.Equals(input.PageField))
                ) && 
                (
                    this.UserFullNameField == input.UserFullNameField ||
                    (this.UserFullNameField != null &&
                    this.UserFullNameField.Equals(input.UserFullNameField))
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
                if (this.ActionOrderField != null)
                    hashCode = hashCode * 59 + this.ActionOrderField.GetHashCode();
                if (this.AdditionalField != null)
                    hashCode = hashCode * 59 + this.AdditionalField.GetHashCode();
                if (this.DocIDField != null)
                    hashCode = hashCode * 59 + this.DocIDField.GetHashCode();
                if (this.EmailField != null)
                    hashCode = hashCode * 59 + this.EmailField.GetHashCode();
                if (this.EventDateField != null)
                    hashCode = hashCode * 59 + this.EventDateField.GetHashCode();
                if (this.EventField != null)
                    hashCode = hashCode * 59 + this.EventField.GetHashCode();
                if (this.EventStatusField != null)
                    hashCode = hashCode * 59 + this.EventStatusField.GetHashCode();
                if (this.LocationField != null)
                    hashCode = hashCode * 59 + this.LocationField.GetHashCode();
                if (this.OrderDateField != null)
                    hashCode = hashCode * 59 + this.OrderDateField.GetHashCode();
                if (this.PageField != null)
                    hashCode = hashCode * 59 + this.PageField.GetHashCode();
                if (this.UserFullNameField != null)
                    hashCode = hashCode * 59 + this.UserFullNameField.GetHashCode();
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

            // ActionOrderField (string) minLength
            if(this.ActionOrderField != null && this.ActionOrderField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ActionOrderField, length must be greater than 1.", new [] { "ActionOrderField" });
            }
 

            // AdditionalField (string) minLength
            if(this.AdditionalField != null && this.AdditionalField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AdditionalField, length must be greater than 1.", new [] { "AdditionalField" });
            }
 

            // DocIDField (string) minLength
            if(this.DocIDField != null && this.DocIDField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocIDField, length must be greater than 1.", new [] { "DocIDField" });
            }
 

            // EmailField (string) minLength
            if(this.EmailField != null && this.EmailField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailField, length must be greater than 1.", new [] { "EmailField" });
            }
 

            // EventDateField (string) minLength
            if(this.EventDateField != null && this.EventDateField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventDateField, length must be greater than 1.", new [] { "EventDateField" });
            }
 

            // EventField (string) minLength
            if(this.EventField != null && this.EventField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventField, length must be greater than 1.", new [] { "EventField" });
            }
 

            // EventStatusField (string) minLength
            if(this.EventStatusField != null && this.EventStatusField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EventStatusField, length must be greater than 1.", new [] { "EventStatusField" });
            }
 

            // LocationField (string) minLength
            if(this.LocationField != null && this.LocationField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocationField, length must be greater than 1.", new [] { "LocationField" });
            }
 

            // OrderDateField (string) minLength
            if(this.OrderDateField != null && this.OrderDateField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderDateField, length must be greater than 1.", new [] { "OrderDateField" });
            }
 

            // PageField (string) minLength
            if(this.PageField != null && this.PageField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageField, length must be greater than 1.", new [] { "PageField" });
            }
 

            // UserFullNameField (string) minLength
            if(this.UserFullNameField != null && this.UserFullNameField.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserFullNameField, length must be greater than 1.", new [] { "UserFullNameField" });
            }
 
            yield break;
        }
    }

}
