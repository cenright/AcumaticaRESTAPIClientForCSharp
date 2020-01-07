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
    /// BusinessAccountPaymentInstructionDetail
    /// </summary>
    [DataContract]
    public partial class BusinessAccountPaymentInstructionDetail : Entity,  IEquatable<BusinessAccountPaymentInstructionDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessAccountPaymentInstructionDetail" /> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="paymentInstructionsID">paymentInstructionsID.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="value">value.</param>
        public BusinessAccountPaymentInstructionDetail(StringValue description = default(StringValue), IntValue locationID = default(IntValue), StringValue paymentInstructionsID = default(StringValue), StringValue paymentMethod = default(StringValue), StringValue value = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Description = description;
            this.LocationID = locationID;
            this.PaymentInstructionsID = paymentInstructionsID;
            this.PaymentMethod = paymentMethod;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public IntValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets PaymentInstructionsID
        /// </summary>
        [DataMember(Name="PaymentInstructionsID", EmitDefaultValue=false)]
        public StringValue PaymentInstructionsID { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="PaymentMethod", EmitDefaultValue=false)]
        public StringValue PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public StringValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessAccountPaymentInstructionDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  PaymentInstructionsID: ").Append(PaymentInstructionsID).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as BusinessAccountPaymentInstructionDetail);
        }

        /// <summary>
        /// Returns true if BusinessAccountPaymentInstructionDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessAccountPaymentInstructionDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessAccountPaymentInstructionDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) && 
                (
                    this.PaymentInstructionsID == input.PaymentInstructionsID ||
                    (this.PaymentInstructionsID != null &&
                    this.PaymentInstructionsID.Equals(input.PaymentInstructionsID))
                ) && base.Equals(input) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.PaymentInstructionsID != null)
                    hashCode = hashCode * 59 + this.PaymentInstructionsID.GetHashCode();
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
