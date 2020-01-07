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
    /// AccountByPeriodInquiry
    /// </summary>
    [DataContract]
    public partial class AccountByPeriodInquiry : Entity,  IEquatable<AccountByPeriodInquiry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountByPeriodInquiry" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="branchID">branchID.</param>
        /// <param name="financialYear">financialYear.</param>
        /// <param name="ledger">ledger.</param>
        /// <param name="results">results.</param>
        /// <param name="subaccount">subaccount.</param>
        public AccountByPeriodInquiry(StringValue account = default(StringValue), StringValue branchID = default(StringValue), StringValue financialYear = default(StringValue), StringValue ledger = default(StringValue), List<AccountByPeriodRow> results = default(List<AccountByPeriodRow>), StringValue subaccount = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.BranchID = branchID;
            this.FinancialYear = financialYear;
            this.Ledger = ledger;
            this.Results = results;
            this.Subaccount = subaccount;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets BranchID
        /// </summary>
        [DataMember(Name="BranchID", EmitDefaultValue=false)]
        public StringValue BranchID { get; set; }

        /// <summary>
        /// Gets or Sets FinancialYear
        /// </summary>
        [DataMember(Name="FinancialYear", EmitDefaultValue=false)]
        public StringValue FinancialYear { get; set; }

        /// <summary>
        /// Gets or Sets Ledger
        /// </summary>
        [DataMember(Name="Ledger", EmitDefaultValue=false)]
        public StringValue Ledger { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="Results", EmitDefaultValue=false)]
        public List<AccountByPeriodRow> Results { get; set; }

        /// <summary>
        /// Gets or Sets Subaccount
        /// </summary>
        [DataMember(Name="Subaccount", EmitDefaultValue=false)]
        public StringValue Subaccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountByPeriodInquiry {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  BranchID: ").Append(BranchID).Append("\n");
            sb.Append("  FinancialYear: ").Append(FinancialYear).Append("\n");
            sb.Append("  Ledger: ").Append(Ledger).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Subaccount: ").Append(Subaccount).Append("\n");
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
            return this.Equals(input as AccountByPeriodInquiry);
        }

        /// <summary>
        /// Returns true if AccountByPeriodInquiry instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountByPeriodInquiry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountByPeriodInquiry input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && base.Equals(input) && 
                (
                    this.BranchID == input.BranchID ||
                    (this.BranchID != null &&
                    this.BranchID.Equals(input.BranchID))
                ) && base.Equals(input) && 
                (
                    this.FinancialYear == input.FinancialYear ||
                    (this.FinancialYear != null &&
                    this.FinancialYear.Equals(input.FinancialYear))
                ) && base.Equals(input) && 
                (
                    this.Ledger == input.Ledger ||
                    (this.Ledger != null &&
                    this.Ledger.Equals(input.Ledger))
                ) && base.Equals(input) && 
                (
                    this.Results == input.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(input.Results)
                ) && base.Equals(input) && 
                (
                    this.Subaccount == input.Subaccount ||
                    (this.Subaccount != null &&
                    this.Subaccount.Equals(input.Subaccount))
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
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.BranchID != null)
                    hashCode = hashCode * 59 + this.BranchID.GetHashCode();
                if (this.FinancialYear != null)
                    hashCode = hashCode * 59 + this.FinancialYear.GetHashCode();
                if (this.Ledger != null)
                    hashCode = hashCode * 59 + this.Ledger.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Subaccount != null)
                    hashCode = hashCode * 59 + this.Subaccount.GetHashCode();
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
