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
    /// TrialBalanceDetail
    /// </summary>
    [DataContract]
    public partial class TrialBalanceDetail : Entity,  IEquatable<TrialBalanceDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialBalanceDetail" /> class.
        /// </summary>
        /// <param name="currencyYTDBalance">currencyYTDBalance.</param>
        /// <param name="description">description.</param>
        /// <param name="importedAccount">importedAccount.</param>
        /// <param name="importedSubaccount">importedSubaccount.</param>
        /// <param name="line">line.</param>
        /// <param name="mapNbr">mapNbr.</param>
        /// <param name="mappedAccount">mappedAccount.</param>
        /// <param name="mappedSubaccount">mappedSubaccount.</param>
        /// <param name="selected">selected.</param>
        /// <param name="status">status.</param>
        /// <param name="type">type.</param>
        /// <param name="yTDBalance">yTDBalance.</param>
        public TrialBalanceDetail(DecimalValue currencyYTDBalance = default(DecimalValue), StringValue description = default(StringValue), StringValue importedAccount = default(StringValue), StringValue importedSubaccount = default(StringValue), IntValue line = default(IntValue), StringValue mapNbr = default(StringValue), StringValue mappedAccount = default(StringValue), StringValue mappedSubaccount = default(StringValue), BooleanValue selected = default(BooleanValue), StringValue status = default(StringValue), StringValue type = default(StringValue), DecimalValue yTDBalance = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CurrencyYTDBalance = currencyYTDBalance;
            this.Description = description;
            this.ImportedAccount = importedAccount;
            this.ImportedSubaccount = importedSubaccount;
            this.Line = line;
            this.MapNbr = mapNbr;
            this.MappedAccount = mappedAccount;
            this.MappedSubaccount = mappedSubaccount;
            this.Selected = selected;
            this.Status = status;
            this.Type = type;
            this.YTDBalance = yTDBalance;
        }
        
        /// <summary>
        /// Gets or Sets CurrencyYTDBalance
        /// </summary>
        [DataMember(Name="CurrencyYTDBalance", EmitDefaultValue=false)]
        public DecimalValue CurrencyYTDBalance { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ImportedAccount
        /// </summary>
        [DataMember(Name="ImportedAccount", EmitDefaultValue=false)]
        public StringValue ImportedAccount { get; set; }

        /// <summary>
        /// Gets or Sets ImportedSubaccount
        /// </summary>
        [DataMember(Name="ImportedSubaccount", EmitDefaultValue=false)]
        public StringValue ImportedSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name="Line", EmitDefaultValue=false)]
        public IntValue Line { get; set; }

        /// <summary>
        /// Gets or Sets MapNbr
        /// </summary>
        [DataMember(Name="MapNbr", EmitDefaultValue=false)]
        public StringValue MapNbr { get; set; }

        /// <summary>
        /// Gets or Sets MappedAccount
        /// </summary>
        [DataMember(Name="MappedAccount", EmitDefaultValue=false)]
        public StringValue MappedAccount { get; set; }

        /// <summary>
        /// Gets or Sets MappedSubaccount
        /// </summary>
        [DataMember(Name="MappedSubaccount", EmitDefaultValue=false)]
        public StringValue MappedSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets Selected
        /// </summary>
        [DataMember(Name="Selected", EmitDefaultValue=false)]
        public BooleanValue Selected { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Gets or Sets YTDBalance
        /// </summary>
        [DataMember(Name="YTDBalance", EmitDefaultValue=false)]
        public DecimalValue YTDBalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrialBalanceDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CurrencyYTDBalance: ").Append(CurrencyYTDBalance).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImportedAccount: ").Append(ImportedAccount).Append("\n");
            sb.Append("  ImportedSubaccount: ").Append(ImportedSubaccount).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
            sb.Append("  MapNbr: ").Append(MapNbr).Append("\n");
            sb.Append("  MappedAccount: ").Append(MappedAccount).Append("\n");
            sb.Append("  MappedSubaccount: ").Append(MappedSubaccount).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  YTDBalance: ").Append(YTDBalance).Append("\n");
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
            return this.Equals(input as TrialBalanceDetail);
        }

        /// <summary>
        /// Returns true if TrialBalanceDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TrialBalanceDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrialBalanceDetail input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CurrencyYTDBalance == input.CurrencyYTDBalance ||
                    (this.CurrencyYTDBalance != null &&
                    this.CurrencyYTDBalance.Equals(input.CurrencyYTDBalance))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ImportedAccount == input.ImportedAccount ||
                    (this.ImportedAccount != null &&
                    this.ImportedAccount.Equals(input.ImportedAccount))
                ) && base.Equals(input) && 
                (
                    this.ImportedSubaccount == input.ImportedSubaccount ||
                    (this.ImportedSubaccount != null &&
                    this.ImportedSubaccount.Equals(input.ImportedSubaccount))
                ) && base.Equals(input) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
                ) && base.Equals(input) && 
                (
                    this.MapNbr == input.MapNbr ||
                    (this.MapNbr != null &&
                    this.MapNbr.Equals(input.MapNbr))
                ) && base.Equals(input) && 
                (
                    this.MappedAccount == input.MappedAccount ||
                    (this.MappedAccount != null &&
                    this.MappedAccount.Equals(input.MappedAccount))
                ) && base.Equals(input) && 
                (
                    this.MappedSubaccount == input.MappedSubaccount ||
                    (this.MappedSubaccount != null &&
                    this.MappedSubaccount.Equals(input.MappedSubaccount))
                ) && base.Equals(input) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.YTDBalance == input.YTDBalance ||
                    (this.YTDBalance != null &&
                    this.YTDBalance.Equals(input.YTDBalance))
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
                if (this.CurrencyYTDBalance != null)
                    hashCode = hashCode * 59 + this.CurrencyYTDBalance.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ImportedAccount != null)
                    hashCode = hashCode * 59 + this.ImportedAccount.GetHashCode();
                if (this.ImportedSubaccount != null)
                    hashCode = hashCode * 59 + this.ImportedSubaccount.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
                if (this.MapNbr != null)
                    hashCode = hashCode * 59 + this.MapNbr.GetHashCode();
                if (this.MappedAccount != null)
                    hashCode = hashCode * 59 + this.MappedAccount.GetHashCode();
                if (this.MappedSubaccount != null)
                    hashCode = hashCode * 59 + this.MappedSubaccount.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.YTDBalance != null)
                    hashCode = hashCode * 59 + this.YTDBalance.GetHashCode();
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
