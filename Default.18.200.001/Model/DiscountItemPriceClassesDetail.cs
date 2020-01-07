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
    /// DiscountItemPriceClassesDetail
    /// </summary>
    [DataContract]
    public partial class DiscountItemPriceClassesDetail : Entity,  IEquatable<DiscountItemPriceClassesDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountItemPriceClassesDetail" /> class.
        /// </summary>
        /// <param name="priceClassID">priceClassID.</param>
        public DiscountItemPriceClassesDetail(StringValue priceClassID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.PriceClassID = priceClassID;
        }
        
        /// <summary>
        /// Gets or Sets PriceClassID
        /// </summary>
        [DataMember(Name="PriceClassID", EmitDefaultValue=false)]
        public StringValue PriceClassID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountItemPriceClassesDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  PriceClassID: ").Append(PriceClassID).Append("\n");
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
            return this.Equals(input as DiscountItemPriceClassesDetail);
        }

        /// <summary>
        /// Returns true if DiscountItemPriceClassesDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountItemPriceClassesDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountItemPriceClassesDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.PriceClassID == input.PriceClassID ||
                    (this.PriceClassID != null &&
                    this.PriceClassID.Equals(input.PriceClassID))
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
                if (this.PriceClassID != null)
                    hashCode = hashCode * 59 + this.PriceClassID.GetHashCode();
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
