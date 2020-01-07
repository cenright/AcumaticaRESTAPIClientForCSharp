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
    /// ProgressBilling
    /// </summary>
    [DataContract]
    public partial class ProgressBilling : Entity,  IEquatable<ProgressBilling>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressBilling" /> class.
        /// </summary>
        /// <param name="actualAmount">actualAmount.</param>
        /// <param name="amount">amount.</param>
        /// <param name="amountToInvoice">amountToInvoice.</param>
        /// <param name="branch">branch.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="currentInvoiced">currentInvoiced.</param>
        /// <param name="deferralCode">deferralCode.</param>
        /// <param name="description">description.</param>
        /// <param name="draftInvoicesAmount">draftInvoicesAmount.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="previouslyInvoiced">previouslyInvoiced.</param>
        /// <param name="projectTaskID">projectTaskID.</param>
        /// <param name="retainage">retainage.</param>
        /// <param name="retainageAmount">retainageAmount.</param>
        /// <param name="revisedBudgetedAmount">revisedBudgetedAmount.</param>
        /// <param name="salesAccount">salesAccount.</param>
        /// <param name="salesSubaccount">salesSubaccount.</param>
        /// <param name="storedMaterial">storedMaterial.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="totalCompleted">totalCompleted.</param>
        public ProgressBilling(DecimalValue actualAmount = default(DecimalValue), DecimalValue amount = default(DecimalValue), DecimalValue amountToInvoice = default(DecimalValue), StringValue branch = default(StringValue), StringValue costCode = default(StringValue), DecimalValue currentInvoiced = default(DecimalValue), StringValue deferralCode = default(StringValue), StringValue description = default(StringValue), DecimalValue draftInvoicesAmount = default(DecimalValue), StringValue inventoryID = default(StringValue), DecimalValue previouslyInvoiced = default(DecimalValue), StringValue projectTaskID = default(StringValue), DecimalValue retainage = default(DecimalValue), DecimalValue retainageAmount = default(DecimalValue), DecimalValue revisedBudgetedAmount = default(DecimalValue), StringValue salesAccount = default(StringValue), StringValue salesSubaccount = default(StringValue), DecimalValue storedMaterial = default(DecimalValue), StringValue taxCategory = default(StringValue), DecimalValue totalCompleted = default(DecimalValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.ActualAmount = actualAmount;
            this.Amount = amount;
            this.AmountToInvoice = amountToInvoice;
            this.Branch = branch;
            this.CostCode = costCode;
            this.CurrentInvoiced = currentInvoiced;
            this.DeferralCode = deferralCode;
            this.Description = description;
            this.DraftInvoicesAmount = draftInvoicesAmount;
            this.InventoryID = inventoryID;
            this.PreviouslyInvoiced = previouslyInvoiced;
            this.ProjectTaskID = projectTaskID;
            this.Retainage = retainage;
            this.RetainageAmount = retainageAmount;
            this.RevisedBudgetedAmount = revisedBudgetedAmount;
            this.SalesAccount = salesAccount;
            this.SalesSubaccount = salesSubaccount;
            this.StoredMaterial = storedMaterial;
            this.TaxCategory = taxCategory;
            this.TotalCompleted = totalCompleted;
        }
        
        /// <summary>
        /// Gets or Sets ActualAmount
        /// </summary>
        [DataMember(Name="ActualAmount", EmitDefaultValue=false)]
        public DecimalValue ActualAmount { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets AmountToInvoice
        /// </summary>
        [DataMember(Name="AmountToInvoice", EmitDefaultValue=false)]
        public DecimalValue AmountToInvoice { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrentInvoiced
        /// </summary>
        [DataMember(Name="CurrentInvoiced", EmitDefaultValue=false)]
        public DecimalValue CurrentInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets DeferralCode
        /// </summary>
        [DataMember(Name="DeferralCode", EmitDefaultValue=false)]
        public StringValue DeferralCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets DraftInvoicesAmount
        /// </summary>
        [DataMember(Name="DraftInvoicesAmount", EmitDefaultValue=false)]
        public DecimalValue DraftInvoicesAmount { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets PreviouslyInvoiced
        /// </summary>
        [DataMember(Name="PreviouslyInvoiced", EmitDefaultValue=false)]
        public DecimalValue PreviouslyInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTaskID
        /// </summary>
        [DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
        public StringValue ProjectTaskID { get; set; }

        /// <summary>
        /// Gets or Sets Retainage
        /// </summary>
        [DataMember(Name="Retainage", EmitDefaultValue=false)]
        public DecimalValue Retainage { get; set; }

        /// <summary>
        /// Gets or Sets RetainageAmount
        /// </summary>
        [DataMember(Name="RetainageAmount", EmitDefaultValue=false)]
        public DecimalValue RetainageAmount { get; set; }

        /// <summary>
        /// Gets or Sets RevisedBudgetedAmount
        /// </summary>
        [DataMember(Name="RevisedBudgetedAmount", EmitDefaultValue=false)]
        public DecimalValue RevisedBudgetedAmount { get; set; }

        /// <summary>
        /// Gets or Sets SalesAccount
        /// </summary>
        [DataMember(Name="SalesAccount", EmitDefaultValue=false)]
        public StringValue SalesAccount { get; set; }

        /// <summary>
        /// Gets or Sets SalesSubaccount
        /// </summary>
        [DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
        public StringValue SalesSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets StoredMaterial
        /// </summary>
        [DataMember(Name="StoredMaterial", EmitDefaultValue=false)]
        public DecimalValue StoredMaterial { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets TotalCompleted
        /// </summary>
        [DataMember(Name="TotalCompleted", EmitDefaultValue=false)]
        public DecimalValue TotalCompleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProgressBilling {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActualAmount: ").Append(ActualAmount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AmountToInvoice: ").Append(AmountToInvoice).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  CurrentInvoiced: ").Append(CurrentInvoiced).Append("\n");
            sb.Append("  DeferralCode: ").Append(DeferralCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DraftInvoicesAmount: ").Append(DraftInvoicesAmount).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  PreviouslyInvoiced: ").Append(PreviouslyInvoiced).Append("\n");
            sb.Append("  ProjectTaskID: ").Append(ProjectTaskID).Append("\n");
            sb.Append("  Retainage: ").Append(Retainage).Append("\n");
            sb.Append("  RetainageAmount: ").Append(RetainageAmount).Append("\n");
            sb.Append("  RevisedBudgetedAmount: ").Append(RevisedBudgetedAmount).Append("\n");
            sb.Append("  SalesAccount: ").Append(SalesAccount).Append("\n");
            sb.Append("  SalesSubaccount: ").Append(SalesSubaccount).Append("\n");
            sb.Append("  StoredMaterial: ").Append(StoredMaterial).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  TotalCompleted: ").Append(TotalCompleted).Append("\n");
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
            return this.Equals(input as ProgressBilling);
        }

        /// <summary>
        /// Returns true if ProgressBilling instances are equal
        /// </summary>
        /// <param name="input">Instance of ProgressBilling to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgressBilling input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.ActualAmount == input.ActualAmount ||
                    (this.ActualAmount != null &&
                    this.ActualAmount.Equals(input.ActualAmount))
                ) && base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.AmountToInvoice == input.AmountToInvoice ||
                    (this.AmountToInvoice != null &&
                    this.AmountToInvoice.Equals(input.AmountToInvoice))
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.CurrentInvoiced == input.CurrentInvoiced ||
                    (this.CurrentInvoiced != null &&
                    this.CurrentInvoiced.Equals(input.CurrentInvoiced))
                ) && base.Equals(input) && 
                (
                    this.DeferralCode == input.DeferralCode ||
                    (this.DeferralCode != null &&
                    this.DeferralCode.Equals(input.DeferralCode))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.DraftInvoicesAmount == input.DraftInvoicesAmount ||
                    (this.DraftInvoicesAmount != null &&
                    this.DraftInvoicesAmount.Equals(input.DraftInvoicesAmount))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.PreviouslyInvoiced == input.PreviouslyInvoiced ||
                    (this.PreviouslyInvoiced != null &&
                    this.PreviouslyInvoiced.Equals(input.PreviouslyInvoiced))
                ) && base.Equals(input) && 
                (
                    this.ProjectTaskID == input.ProjectTaskID ||
                    (this.ProjectTaskID != null &&
                    this.ProjectTaskID.Equals(input.ProjectTaskID))
                ) && base.Equals(input) && 
                (
                    this.Retainage == input.Retainage ||
                    (this.Retainage != null &&
                    this.Retainage.Equals(input.Retainage))
                ) && base.Equals(input) && 
                (
                    this.RetainageAmount == input.RetainageAmount ||
                    (this.RetainageAmount != null &&
                    this.RetainageAmount.Equals(input.RetainageAmount))
                ) && base.Equals(input) && 
                (
                    this.RevisedBudgetedAmount == input.RevisedBudgetedAmount ||
                    (this.RevisedBudgetedAmount != null &&
                    this.RevisedBudgetedAmount.Equals(input.RevisedBudgetedAmount))
                ) && base.Equals(input) && 
                (
                    this.SalesAccount == input.SalesAccount ||
                    (this.SalesAccount != null &&
                    this.SalesAccount.Equals(input.SalesAccount))
                ) && base.Equals(input) && 
                (
                    this.SalesSubaccount == input.SalesSubaccount ||
                    (this.SalesSubaccount != null &&
                    this.SalesSubaccount.Equals(input.SalesSubaccount))
                ) && base.Equals(input) && 
                (
                    this.StoredMaterial == input.StoredMaterial ||
                    (this.StoredMaterial != null &&
                    this.StoredMaterial.Equals(input.StoredMaterial))
                ) && base.Equals(input) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
                ) && base.Equals(input) && 
                (
                    this.TotalCompleted == input.TotalCompleted ||
                    (this.TotalCompleted != null &&
                    this.TotalCompleted.Equals(input.TotalCompleted))
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
                if (this.ActualAmount != null)
                    hashCode = hashCode * 59 + this.ActualAmount.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.AmountToInvoice != null)
                    hashCode = hashCode * 59 + this.AmountToInvoice.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.CurrentInvoiced != null)
                    hashCode = hashCode * 59 + this.CurrentInvoiced.GetHashCode();
                if (this.DeferralCode != null)
                    hashCode = hashCode * 59 + this.DeferralCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DraftInvoicesAmount != null)
                    hashCode = hashCode * 59 + this.DraftInvoicesAmount.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.PreviouslyInvoiced != null)
                    hashCode = hashCode * 59 + this.PreviouslyInvoiced.GetHashCode();
                if (this.ProjectTaskID != null)
                    hashCode = hashCode * 59 + this.ProjectTaskID.GetHashCode();
                if (this.Retainage != null)
                    hashCode = hashCode * 59 + this.Retainage.GetHashCode();
                if (this.RetainageAmount != null)
                    hashCode = hashCode * 59 + this.RetainageAmount.GetHashCode();
                if (this.RevisedBudgetedAmount != null)
                    hashCode = hashCode * 59 + this.RevisedBudgetedAmount.GetHashCode();
                if (this.SalesAccount != null)
                    hashCode = hashCode * 59 + this.SalesAccount.GetHashCode();
                if (this.SalesSubaccount != null)
                    hashCode = hashCode * 59 + this.SalesSubaccount.GetHashCode();
                if (this.StoredMaterial != null)
                    hashCode = hashCode * 59 + this.StoredMaterial.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.TotalCompleted != null)
                    hashCode = hashCode * 59 + this.TotalCompleted.GetHashCode();
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
