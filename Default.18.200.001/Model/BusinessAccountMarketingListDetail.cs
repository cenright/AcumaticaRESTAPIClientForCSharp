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
    /// BusinessAccountMarketingListDetail
    /// </summary>
    [DataContract]
    public partial class BusinessAccountMarketingListDetail : Entity,  IEquatable<BusinessAccountMarketingListDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccountMarketingListDetail" /> class.
        /// </summary>
        /// <param name="contactID">contactID.</param>
        /// <param name="dynamicList">dynamicList.</param>
        /// <param name="email">email.</param>
        /// <param name="format">format.</param>
        /// <param name="listName">listName.</param>
        /// <param name="marketingListID">marketingListID.</param>
        /// <param name="memberName">memberName.</param>
        /// <param name="phone1">phone1.</param>
        /// <param name="subscribed">subscribed.</param>
        public BusinessAccountMarketingListDetail(IntValue contactID = default(IntValue), BooleanValue dynamicList = default(BooleanValue), StringValue email = default(StringValue), StringValue format = default(StringValue), StringValue listName = default(StringValue), IntValue marketingListID = default(IntValue), StringValue memberName = default(StringValue), StringValue phone1 = default(StringValue), BooleanValue subscribed = default(BooleanValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ContactID = contactID;
            this.DynamicList = dynamicList;
            this.Email = email;
            this.Format = format;
            this.ListName = listName;
            this.MarketingListID = marketingListID;
            this.MemberName = memberName;
            this.Phone1 = phone1;
            this.Subscribed = subscribed;
        }
        
        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public IntValue ContactID { get; set; }

        /// <summary>
        /// Gets or Sets DynamicList
        /// </summary>
        [DataMember(Name="DynamicList", EmitDefaultValue=false)]
        public BooleanValue DynamicList { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public StringValue Email { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name="Format", EmitDefaultValue=false)]
        public StringValue Format { get; set; }

        /// <summary>
        /// Gets or Sets ListName
        /// </summary>
        [DataMember(Name="ListName", EmitDefaultValue=false)]
        public StringValue ListName { get; set; }

        /// <summary>
        /// Gets or Sets MarketingListID
        /// </summary>
        [DataMember(Name="MarketingListID", EmitDefaultValue=false)]
        public IntValue MarketingListID { get; set; }

        /// <summary>
        /// Gets or Sets MemberName
        /// </summary>
        [DataMember(Name="MemberName", EmitDefaultValue=false)]
        public StringValue MemberName { get; set; }

        /// <summary>
        /// Gets or Sets Phone1
        /// </summary>
        [DataMember(Name="Phone1", EmitDefaultValue=false)]
        public StringValue Phone1 { get; set; }

        /// <summary>
        /// Gets or Sets Subscribed
        /// </summary>
        [DataMember(Name="Subscribed", EmitDefaultValue=false)]
        public BooleanValue Subscribed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccountMarketingListDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  DynamicList: ").Append(DynamicList).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  ListName: ").Append(ListName).Append("\n");
            sb.Append("  MarketingListID: ").Append(MarketingListID).Append("\n");
            sb.Append("  MemberName: ").Append(MemberName).Append("\n");
            sb.Append("  Phone1: ").Append(Phone1).Append("\n");
            sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
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
            return this.Equals(input as BusinessAccountMarketingListDetail);
        }

        /// <summary>
        /// Returns true if BusinessAccountMarketingListDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAccountMarketingListDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountMarketingListDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && base.Equals(input) && 
                (
                    this.DynamicList == input.DynamicList ||
                    (this.DynamicList != null &&
                    this.DynamicList.Equals(input.DynamicList))
                ) && base.Equals(input) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && base.Equals(input) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && base.Equals(input) && 
                (
                    this.ListName == input.ListName ||
                    (this.ListName != null &&
                    this.ListName.Equals(input.ListName))
                ) && base.Equals(input) && 
                (
                    this.MarketingListID == input.MarketingListID ||
                    (this.MarketingListID != null &&
                    this.MarketingListID.Equals(input.MarketingListID))
                ) && base.Equals(input) && 
                (
                    this.MemberName == input.MemberName ||
                    (this.MemberName != null &&
                    this.MemberName.Equals(input.MemberName))
                ) && base.Equals(input) && 
                (
                    this.Phone1 == input.Phone1 ||
                    (this.Phone1 != null &&
                    this.Phone1.Equals(input.Phone1))
                ) && base.Equals(input) && 
                (
                    this.Subscribed == input.Subscribed ||
                    (this.Subscribed != null &&
                    this.Subscribed.Equals(input.Subscribed))
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
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.DynamicList != null)
                    hashCode = hashCode * 59 + this.DynamicList.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.ListName != null)
                    hashCode = hashCode * 59 + this.ListName.GetHashCode();
                if (this.MarketingListID != null)
                    hashCode = hashCode * 59 + this.MarketingListID.GetHashCode();
                if (this.MemberName != null)
                    hashCode = hashCode * 59 + this.MemberName.GetHashCode();
                if (this.Phone1 != null)
                    hashCode = hashCode * 59 + this.Phone1.GetHashCode();
                if (this.Subscribed != null)
                    hashCode = hashCode * 59 + this.Subscribed.GetHashCode();
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
