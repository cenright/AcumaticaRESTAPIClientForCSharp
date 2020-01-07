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
    /// ExpenseReceiptDetails
    /// </summary>
    [DataContract]
    public partial class ExpenseReceiptDetails : Entity,  IEquatable<ExpenseReceiptDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseReceiptDetails" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="baseCurrencyID">baseCurrencyID.</param>
        /// <param name="billable">billable.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="currancyRateTypeID">currancyRateTypeID.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="currencyRate">currencyRate.</param>
        /// <param name="customerID">customerID.</param>
        /// <param name="description">description.</param>
        /// <param name="employeePart">employeePart.</param>
        /// <param name="expenseAccount">expenseAccount.</param>
        /// <param name="expenseClaimID">expenseClaimID.</param>
        /// <param name="expenseClaimStatus">expenseClaimStatus.</param>
        /// <param name="expenseSubaccount">expenseSubaccount.</param>
        /// <param name="locationID">locationID.</param>
        /// <param name="projectID">projectID.</param>
        /// <param name="projectTaskID">projectTaskID.</param>
        /// <param name="qty">qty.</param>
        /// <param name="reciprocalRate">reciprocalRate.</param>
        /// <param name="refNbr">refNbr.</param>
        /// <param name="salesAccount">salesAccount.</param>
        /// <param name="salesSubaccount">salesSubaccount.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="taxZone">taxZone.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="uOM">uOM.</param>
        public ExpenseReceiptDetails(DecimalValue amount = default(DecimalValue), StringValue baseCurrencyID = default(StringValue), BooleanValue billable = default(BooleanValue), StringValue costCode = default(StringValue), StringValue currancyRateTypeID = default(StringValue), StringValue currencyID = default(StringValue), DecimalValue currencyRate = default(DecimalValue), StringValue customerID = default(StringValue), StringValue description = default(StringValue), DecimalValue employeePart = default(DecimalValue), StringValue expenseAccount = default(StringValue), StringValue expenseClaimID = default(StringValue), StringValue expenseClaimStatus = default(StringValue), StringValue expenseSubaccount = default(StringValue), StringValue locationID = default(StringValue), StringValue projectID = default(StringValue), StringValue projectTaskID = default(StringValue), DecimalValue qty = default(DecimalValue), DecimalValue reciprocalRate = default(DecimalValue), StringValue refNbr = default(StringValue), StringValue salesAccount = default(StringValue), StringValue salesSubaccount = default(StringValue), StringValue taxCategory = default(StringValue), StringValue taxZone = default(StringValue), DecimalValue unitCost = default(DecimalValue), StringValue uOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Amount = amount;
            this.BaseCurrencyID = baseCurrencyID;
            this.Billable = billable;
            this.CostCode = costCode;
            this.CurrancyRateTypeID = currancyRateTypeID;
            this.CurrencyID = currencyID;
            this.CurrencyRate = currencyRate;
            this.CustomerID = customerID;
            this.Description = description;
            this.EmployeePart = employeePart;
            this.ExpenseAccount = expenseAccount;
            this.ExpenseClaimID = expenseClaimID;
            this.ExpenseClaimStatus = expenseClaimStatus;
            this.ExpenseSubaccount = expenseSubaccount;
            this.LocationID = locationID;
            this.ProjectID = projectID;
            this.ProjectTaskID = projectTaskID;
            this.Qty = qty;
            this.ReciprocalRate = reciprocalRate;
            this.RefNbr = refNbr;
            this.SalesAccount = salesAccount;
            this.SalesSubaccount = salesSubaccount;
            this.TaxCategory = taxCategory;
            this.TaxZone = taxZone;
            this.UnitCost = unitCost;
            this.UOM = uOM;
        }
        
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public DecimalValue Amount { get; set; }

        /// <summary>
        /// Gets or Sets BaseCurrencyID
        /// </summary>
        [DataMember(Name="BaseCurrencyID", EmitDefaultValue=false)]
        public StringValue BaseCurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets Billable
        /// </summary>
        [DataMember(Name="Billable", EmitDefaultValue=false)]
        public BooleanValue Billable { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrancyRateTypeID
        /// </summary>
        [DataMember(Name="CurrancyRateTypeID", EmitDefaultValue=false)]
        public StringValue CurrancyRateTypeID { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyRate
        /// </summary>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public DecimalValue CurrencyRate { get; set; }

        /// <summary>
        /// Gets or Sets CustomerID
        /// </summary>
        [DataMember(Name="CustomerID", EmitDefaultValue=false)]
        public StringValue CustomerID { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets EmployeePart
        /// </summary>
        [DataMember(Name="EmployeePart", EmitDefaultValue=false)]
        public DecimalValue EmployeePart { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAccount
        /// </summary>
        [DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
        public StringValue ExpenseAccount { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseClaimID
        /// </summary>
        [DataMember(Name="ExpenseClaimID", EmitDefaultValue=false)]
        public StringValue ExpenseClaimID { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseClaimStatus
        /// </summary>
        [DataMember(Name="ExpenseClaimStatus", EmitDefaultValue=false)]
        public StringValue ExpenseClaimStatus { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseSubaccount
        /// </summary>
        [DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
        public StringValue ExpenseSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets LocationID
        /// </summary>
        [DataMember(Name="LocationID", EmitDefaultValue=false)]
        public StringValue LocationID { get; set; }

        /// <summary>
        /// Gets or Sets ProjectID
        /// </summary>
        [DataMember(Name="ProjectID", EmitDefaultValue=false)]
        public StringValue ProjectID { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTaskID
        /// </summary>
        [DataMember(Name="ProjectTaskID", EmitDefaultValue=false)]
        public StringValue ProjectTaskID { get; set; }

        /// <summary>
        /// Gets or Sets Qty
        /// </summary>
        [DataMember(Name="Qty", EmitDefaultValue=false)]
        public DecimalValue Qty { get; set; }

        /// <summary>
        /// Gets or Sets ReciprocalRate
        /// </summary>
        [DataMember(Name="ReciprocalRate", EmitDefaultValue=false)]
        public DecimalValue ReciprocalRate { get; set; }

        /// <summary>
        /// Gets or Sets RefNbr
        /// </summary>
        [DataMember(Name="RefNbr", EmitDefaultValue=false)]
        public StringValue RefNbr { get; set; }

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
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets TaxZone
        /// </summary>
        [DataMember(Name="TaxZone", EmitDefaultValue=false)]
        public StringValue TaxZone { get; set; }

        /// <summary>
        /// Gets or Sets UnitCost
        /// </summary>
        [DataMember(Name="UnitCost", EmitDefaultValue=false)]
        public DecimalValue UnitCost { get; set; }

        /// <summary>
        /// Gets or Sets UOM
        /// </summary>
        [DataMember(Name="UOM", EmitDefaultValue=false)]
        public StringValue UOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseReceiptDetails {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BaseCurrencyID: ").Append(BaseCurrencyID).Append("\n");
            sb.Append("  Billable: ").Append(Billable).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  CurrancyRateTypeID: ").Append(CurrancyRateTypeID).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  CustomerID: ").Append(CustomerID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EmployeePart: ").Append(EmployeePart).Append("\n");
            sb.Append("  ExpenseAccount: ").Append(ExpenseAccount).Append("\n");
            sb.Append("  ExpenseClaimID: ").Append(ExpenseClaimID).Append("\n");
            sb.Append("  ExpenseClaimStatus: ").Append(ExpenseClaimStatus).Append("\n");
            sb.Append("  ExpenseSubaccount: ").Append(ExpenseSubaccount).Append("\n");
            sb.Append("  LocationID: ").Append(LocationID).Append("\n");
            sb.Append("  ProjectID: ").Append(ProjectID).Append("\n");
            sb.Append("  ProjectTaskID: ").Append(ProjectTaskID).Append("\n");
            sb.Append("  Qty: ").Append(Qty).Append("\n");
            sb.Append("  ReciprocalRate: ").Append(ReciprocalRate).Append("\n");
            sb.Append("  RefNbr: ").Append(RefNbr).Append("\n");
            sb.Append("  SalesAccount: ").Append(SalesAccount).Append("\n");
            sb.Append("  SalesSubaccount: ").Append(SalesSubaccount).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  TaxZone: ").Append(TaxZone).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
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
            return this.Equals(input as ExpenseReceiptDetails);
        }

        /// <summary>
        /// Returns true if ExpenseReceiptDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseReceiptDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseReceiptDetails input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && base.Equals(input) && 
                (
                    this.BaseCurrencyID == input.BaseCurrencyID ||
                    (this.BaseCurrencyID != null &&
                    this.BaseCurrencyID.Equals(input.BaseCurrencyID))
                ) && base.Equals(input) && 
                (
                    this.Billable == input.Billable ||
                    (this.Billable != null &&
                    this.Billable.Equals(input.Billable))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.CurrancyRateTypeID == input.CurrancyRateTypeID ||
                    (this.CurrancyRateTypeID != null &&
                    this.CurrancyRateTypeID.Equals(input.CurrancyRateTypeID))
                ) && base.Equals(input) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    (this.CurrencyRate != null &&
                    this.CurrencyRate.Equals(input.CurrencyRate))
                ) && base.Equals(input) && 
                (
                    this.CustomerID == input.CustomerID ||
                    (this.CustomerID != null &&
                    this.CustomerID.Equals(input.CustomerID))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.EmployeePart == input.EmployeePart ||
                    (this.EmployeePart != null &&
                    this.EmployeePart.Equals(input.EmployeePart))
                ) && base.Equals(input) && 
                (
                    this.ExpenseAccount == input.ExpenseAccount ||
                    (this.ExpenseAccount != null &&
                    this.ExpenseAccount.Equals(input.ExpenseAccount))
                ) && base.Equals(input) && 
                (
                    this.ExpenseClaimID == input.ExpenseClaimID ||
                    (this.ExpenseClaimID != null &&
                    this.ExpenseClaimID.Equals(input.ExpenseClaimID))
                ) && base.Equals(input) && 
                (
                    this.ExpenseClaimStatus == input.ExpenseClaimStatus ||
                    (this.ExpenseClaimStatus != null &&
                    this.ExpenseClaimStatus.Equals(input.ExpenseClaimStatus))
                ) && base.Equals(input) && 
                (
                    this.ExpenseSubaccount == input.ExpenseSubaccount ||
                    (this.ExpenseSubaccount != null &&
                    this.ExpenseSubaccount.Equals(input.ExpenseSubaccount))
                ) && base.Equals(input) && 
                (
                    this.LocationID == input.LocationID ||
                    (this.LocationID != null &&
                    this.LocationID.Equals(input.LocationID))
                ) && base.Equals(input) && 
                (
                    this.ProjectID == input.ProjectID ||
                    (this.ProjectID != null &&
                    this.ProjectID.Equals(input.ProjectID))
                ) && base.Equals(input) && 
                (
                    this.ProjectTaskID == input.ProjectTaskID ||
                    (this.ProjectTaskID != null &&
                    this.ProjectTaskID.Equals(input.ProjectTaskID))
                ) && base.Equals(input) && 
                (
                    this.Qty == input.Qty ||
                    (this.Qty != null &&
                    this.Qty.Equals(input.Qty))
                ) && base.Equals(input) && 
                (
                    this.ReciprocalRate == input.ReciprocalRate ||
                    (this.ReciprocalRate != null &&
                    this.ReciprocalRate.Equals(input.ReciprocalRate))
                ) && base.Equals(input) && 
                (
                    this.RefNbr == input.RefNbr ||
                    (this.RefNbr != null &&
                    this.RefNbr.Equals(input.RefNbr))
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
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
                ) && base.Equals(input) && 
                (
                    this.TaxZone == input.TaxZone ||
                    (this.TaxZone != null &&
                    this.TaxZone.Equals(input.TaxZone))
                ) && base.Equals(input) && 
                (
                    this.UnitCost == input.UnitCost ||
                    (this.UnitCost != null &&
                    this.UnitCost.Equals(input.UnitCost))
                ) && base.Equals(input) && 
                (
                    this.UOM == input.UOM ||
                    (this.UOM != null &&
                    this.UOM.Equals(input.UOM))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BaseCurrencyID != null)
                    hashCode = hashCode * 59 + this.BaseCurrencyID.GetHashCode();
                if (this.Billable != null)
                    hashCode = hashCode * 59 + this.Billable.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.CurrancyRateTypeID != null)
                    hashCode = hashCode * 59 + this.CurrancyRateTypeID.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.CurrencyRate != null)
                    hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                if (this.CustomerID != null)
                    hashCode = hashCode * 59 + this.CustomerID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EmployeePart != null)
                    hashCode = hashCode * 59 + this.EmployeePart.GetHashCode();
                if (this.ExpenseAccount != null)
                    hashCode = hashCode * 59 + this.ExpenseAccount.GetHashCode();
                if (this.ExpenseClaimID != null)
                    hashCode = hashCode * 59 + this.ExpenseClaimID.GetHashCode();
                if (this.ExpenseClaimStatus != null)
                    hashCode = hashCode * 59 + this.ExpenseClaimStatus.GetHashCode();
                if (this.ExpenseSubaccount != null)
                    hashCode = hashCode * 59 + this.ExpenseSubaccount.GetHashCode();
                if (this.LocationID != null)
                    hashCode = hashCode * 59 + this.LocationID.GetHashCode();
                if (this.ProjectID != null)
                    hashCode = hashCode * 59 + this.ProjectID.GetHashCode();
                if (this.ProjectTaskID != null)
                    hashCode = hashCode * 59 + this.ProjectTaskID.GetHashCode();
                if (this.Qty != null)
                    hashCode = hashCode * 59 + this.Qty.GetHashCode();
                if (this.ReciprocalRate != null)
                    hashCode = hashCode * 59 + this.ReciprocalRate.GetHashCode();
                if (this.RefNbr != null)
                    hashCode = hashCode * 59 + this.RefNbr.GetHashCode();
                if (this.SalesAccount != null)
                    hashCode = hashCode * 59 + this.SalesAccount.GetHashCode();
                if (this.SalesSubaccount != null)
                    hashCode = hashCode * 59 + this.SalesSubaccount.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.TaxZone != null)
                    hashCode = hashCode * 59 + this.TaxZone.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
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
