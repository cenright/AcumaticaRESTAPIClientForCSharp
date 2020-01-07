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
    /// InventoryItemUOMConversion
    /// </summary>
    [DataContract]
    public partial class InventoryItemUOMConversion : Entity,  IEquatable<InventoryItemUOMConversion>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryItemUOMConversion" /> class.
        /// </summary>
        /// <param name="conversionFactor">conversionFactor.</param>
        /// <param name="fromUOM">fromUOM.</param>
        /// <param name="multiplyOrDivide">multiplyOrDivide.</param>
        /// <param name="toUOM">toUOM.</param>
        public InventoryItemUOMConversion(DecimalValue conversionFactor = default(DecimalValue), StringValue fromUOM = default(StringValue), StringValue multiplyOrDivide = default(StringValue), StringValue toUOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ConversionFactor = conversionFactor;
            this.FromUOM = fromUOM;
            this.MultiplyOrDivide = multiplyOrDivide;
            this.ToUOM = toUOM;
        }
        
        /// <summary>
        /// Gets or Sets ConversionFactor
        /// </summary>
        [DataMember(Name="ConversionFactor", EmitDefaultValue=false)]
        public DecimalValue ConversionFactor { get; set; }

        /// <summary>
        /// Gets or Sets FromUOM
        /// </summary>
        [DataMember(Name="FromUOM", EmitDefaultValue=false)]
        public StringValue FromUOM { get; set; }

        /// <summary>
        /// Gets or Sets MultiplyOrDivide
        /// </summary>
        [DataMember(Name="MultiplyOrDivide", EmitDefaultValue=false)]
        public StringValue MultiplyOrDivide { get; set; }

        /// <summary>
        /// Gets or Sets ToUOM
        /// </summary>
        [DataMember(Name="ToUOM", EmitDefaultValue=false)]
        public StringValue ToUOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryItemUOMConversion {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ConversionFactor: ").Append(ConversionFactor).Append("\n");
            sb.Append("  FromUOM: ").Append(FromUOM).Append("\n");
            sb.Append("  MultiplyOrDivide: ").Append(MultiplyOrDivide).Append("\n");
            sb.Append("  ToUOM: ").Append(ToUOM).Append("\n");
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
            return this.Equals(input as InventoryItemUOMConversion);
        }

        /// <summary>
        /// Returns true if InventoryItemUOMConversion instances are equal
        /// </summary>
        /// <param name="input">Instance of InventoryItemUOMConversion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryItemUOMConversion input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ConversionFactor == input.ConversionFactor ||
                    (this.ConversionFactor != null &&
                    this.ConversionFactor.Equals(input.ConversionFactor))
                ) && base.Equals(input) && 
                (
                    this.FromUOM == input.FromUOM ||
                    (this.FromUOM != null &&
                    this.FromUOM.Equals(input.FromUOM))
                ) && base.Equals(input) && 
                (
                    this.MultiplyOrDivide == input.MultiplyOrDivide ||
                    (this.MultiplyOrDivide != null &&
                    this.MultiplyOrDivide.Equals(input.MultiplyOrDivide))
                ) && base.Equals(input) && 
                (
                    this.ToUOM == input.ToUOM ||
                    (this.ToUOM != null &&
                    this.ToUOM.Equals(input.ToUOM))
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
                if (this.ConversionFactor != null)
                    hashCode = hashCode * 59 + this.ConversionFactor.GetHashCode();
                if (this.FromUOM != null)
                    hashCode = hashCode * 59 + this.FromUOM.GetHashCode();
                if (this.MultiplyOrDivide != null)
                    hashCode = hashCode * 59 + this.MultiplyOrDivide.GetHashCode();
                if (this.ToUOM != null)
                    hashCode = hashCode * 59 + this.ToUOM.GetHashCode();
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
