/* 
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 * 
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
using OpenAPIDateConverter = Acumatica.RESTClient.Client.OpenAPIDateConverter;

namespace Acumatica.DefaultEndpoint_18_200_001.Model
{
    /// <summary>
    /// DuplicateDetail
    /// </summary>
    [DataContract]
    public partial class DuplicateDetail : Entity,  IEquatable<DuplicateDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateDetail" /> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="businessAccount">businessAccount.</param>
        /// <param name="businessAccountType">businessAccountType.</param>
        /// <param name="contactID">contactID.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="duplicate">duplicate.</param>
        /// <param name="duplicateContactID">duplicateContactID.</param>
        /// <param name="email">email.</param>
        /// <param name="entityType">entityType.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="type">type.</param>
        public DuplicateDetail(StringValue accountName = default(StringValue), StringValue businessAccount = default(StringValue), StringValue businessAccountType = default(StringValue), IntValue contactID = default(IntValue), StringValue displayName = default(StringValue), StringValue duplicate = default(StringValue), IntValue duplicateContactID = default(IntValue), StringValue email = default(StringValue), StringValue entityType = default(StringValue), DateTimeValue lastModifiedDate = default(DateTimeValue), StringValue type = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.AccountName = accountName;
            this.BusinessAccount = businessAccount;
            this.BusinessAccountType = businessAccountType;
            this.ContactID = contactID;
            this.DisplayName = displayName;
            this.Duplicate = duplicate;
            this.DuplicateContactID = duplicateContactID;
            this.Email = email;
            this.EntityType = entityType;
            this.LastModifiedDate = lastModifiedDate;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public StringValue AccountName { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAccount
        /// </summary>
        [DataMember(Name="BusinessAccount", EmitDefaultValue=false)]
        public StringValue BusinessAccount { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAccountType
        /// </summary>
        [DataMember(Name="BusinessAccountType", EmitDefaultValue=false)]
        public StringValue BusinessAccountType { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public IntValue ContactID { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public StringValue DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Duplicate
        /// </summary>
        [DataMember(Name="Duplicate", EmitDefaultValue=false)]
        public StringValue Duplicate { get; set; }

        /// <summary>
        /// Gets or Sets DuplicateContactID
        /// </summary>
        [DataMember(Name="DuplicateContactID", EmitDefaultValue=false)]
        public IntValue DuplicateContactID { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public StringValue Email { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="EntityType", EmitDefaultValue=false)]
        public StringValue EntityType { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDate
        /// </summary>
        [DataMember(Name="LastModifiedDate", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DuplicateDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  BusinessAccount: ").Append(BusinessAccount).Append("\n");
            sb.Append("  BusinessAccountType: ").Append(BusinessAccountType).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Duplicate: ").Append(Duplicate).Append("\n");
            sb.Append("  DuplicateContactID: ").Append(DuplicateContactID).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DuplicateDetail);
        }

        /// <summary>
        /// Returns true if DuplicateDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DuplicateDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DuplicateDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && base.Equals(input) && 
                (
                    this.BusinessAccount == input.BusinessAccount ||
                    (this.BusinessAccount != null &&
                    this.BusinessAccount.Equals(input.BusinessAccount))
                ) && base.Equals(input) && 
                (
                    this.BusinessAccountType == input.BusinessAccountType ||
                    (this.BusinessAccountType != null &&
                    this.BusinessAccountType.Equals(input.BusinessAccountType))
                ) && base.Equals(input) && 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && base.Equals(input) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && base.Equals(input) && 
                (
                    this.Duplicate == input.Duplicate ||
                    (this.Duplicate != null &&
                    this.Duplicate.Equals(input.Duplicate))
                ) && base.Equals(input) && 
                (
                    this.DuplicateContactID == input.DuplicateContactID ||
                    (this.DuplicateContactID != null &&
                    this.DuplicateContactID.Equals(input.DuplicateContactID))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                int hashCode = base.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.BusinessAccount != null)
                    hashCode = hashCode * 59 + this.BusinessAccount.GetHashCode();
                if (this.BusinessAccountType != null)
                    hashCode = hashCode * 59 + this.BusinessAccountType.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Duplicate != null)
                    hashCode = hashCode * 59 + this.Duplicate.GetHashCode();
                if (this.DuplicateContactID != null)
                    hashCode = hashCode * 59 + this.DuplicateContactID.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.LastModifiedDate != null)
                    hashCode = hashCode * 59 + this.LastModifiedDate.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
