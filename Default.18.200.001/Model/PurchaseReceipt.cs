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
    /// PurchaseReceipt
    /// </summary>
    [DataContract]
    public partial class PurchaseReceipt : Entity,  IEquatable<PurchaseReceipt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseReceipt" /> class.
        /// </summary>
        /// <param name="billDate">billDate.</param>
        /// <param name="branch">branch.</param>
        /// <param name="controlAmount">controlAmount.</param>
        /// <param name="controlQty">controlQty.</param>
        /// <param name="createBill">createBill.</param>
        /// <param name="currencyID">currencyID.</param>
        /// <param name="date">date.</param>
        /// <param name="details">details.</param>
        /// <param name="hold">hold.</param>
        /// <param name="postPeriod">postPeriod.</param>
        /// <param name="receiptNbr">receiptNbr.</param>
        /// <param name="status">status.</param>
        /// <param name="totalAmount">totalAmount.</param>
        /// <param name="totalQty">totalQty.</param>
        /// <param name="type">type.</param>
        /// <param name="unbilledQuantity">unbilledQuantity.</param>
        /// <param name="vendorID">vendorID.</param>
        /// <param name="vendorRef">vendorRef.</param>
        /// <param name="warehouse">warehouse.</param>
        public PurchaseReceipt(DateTimeValue billDate = default(DateTimeValue), StringValue branch = default(StringValue), DecimalValue controlAmount = default(DecimalValue), DecimalValue controlQty = default(DecimalValue), BooleanValue createBill = default(BooleanValue), StringValue currencyID = default(StringValue), DateTimeValue date = default(DateTimeValue), List<PurchaseReceiptDetail> details = default(List<PurchaseReceiptDetail>), BooleanValue hold = default(BooleanValue), StringValue postPeriod = default(StringValue), StringValue receiptNbr = default(StringValue), StringValue status = default(StringValue), DecimalValue totalAmount = default(DecimalValue), DecimalValue totalQty = default(DecimalValue), StringValue type = default(StringValue), DecimalValue unbilledQuantity = default(DecimalValue), StringValue vendorID = default(StringValue), StringValue vendorRef = default(StringValue), StringValue warehouse = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.BillDate = billDate;
            this.Branch = branch;
            this.ControlAmount = controlAmount;
            this.ControlQty = controlQty;
            this.CreateBill = createBill;
            this.CurrencyID = currencyID;
            this.Date = date;
            this.Details = details;
            this.Hold = hold;
            this.PostPeriod = postPeriod;
            this.ReceiptNbr = receiptNbr;
            this.Status = status;
            this.TotalAmount = totalAmount;
            this.TotalQty = totalQty;
            this.Type = type;
            this.UnbilledQuantity = unbilledQuantity;
            this.VendorID = vendorID;
            this.VendorRef = vendorRef;
            this.Warehouse = warehouse;
        }
        
        /// <summary>
        /// Gets or Sets BillDate
        /// </summary>
        [DataMember(Name="BillDate", EmitDefaultValue=false)]
        public DateTimeValue BillDate { get; set; }

        /// <summary>
        /// Gets or Sets Branch
        /// </summary>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public StringValue Branch { get; set; }

        /// <summary>
        /// Gets or Sets ControlAmount
        /// </summary>
        [DataMember(Name="ControlAmount", EmitDefaultValue=false)]
        public DecimalValue ControlAmount { get; set; }

        /// <summary>
        /// Gets or Sets ControlQty
        /// </summary>
        [DataMember(Name="ControlQty", EmitDefaultValue=false)]
        public DecimalValue ControlQty { get; set; }

        /// <summary>
        /// Gets or Sets CreateBill
        /// </summary>
        [DataMember(Name="CreateBill", EmitDefaultValue=false)]
        public BooleanValue CreateBill { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyID
        /// </summary>
        [DataMember(Name="CurrencyID", EmitDefaultValue=false)]
        public StringValue CurrencyID { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTimeValue Date { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public List<PurchaseReceiptDetail> Details { get; set; }

        /// <summary>
        /// Gets or Sets Hold
        /// </summary>
        [DataMember(Name="Hold", EmitDefaultValue=false)]
        public BooleanValue Hold { get; set; }

        /// <summary>
        /// Gets or Sets PostPeriod
        /// </summary>
        [DataMember(Name="PostPeriod", EmitDefaultValue=false)]
        public StringValue PostPeriod { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptNbr
        /// </summary>
        [DataMember(Name="ReceiptNbr", EmitDefaultValue=false)]
        public StringValue ReceiptNbr { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name="TotalAmount", EmitDefaultValue=false)]
        public DecimalValue TotalAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalQty
        /// </summary>
        [DataMember(Name="TotalQty", EmitDefaultValue=false)]
        public DecimalValue TotalQty { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public StringValue Type { get; set; }

        /// <summary>
        /// Gets or Sets UnbilledQuantity
        /// </summary>
        [DataMember(Name="UnbilledQuantity", EmitDefaultValue=false)]
        public DecimalValue UnbilledQuantity { get; set; }

        /// <summary>
        /// Gets or Sets VendorID
        /// </summary>
        [DataMember(Name="VendorID", EmitDefaultValue=false)]
        public StringValue VendorID { get; set; }

        /// <summary>
        /// Gets or Sets VendorRef
        /// </summary>
        [DataMember(Name="VendorRef", EmitDefaultValue=false)]
        public StringValue VendorRef { get; set; }

        /// <summary>
        /// Gets or Sets Warehouse
        /// </summary>
        [DataMember(Name="Warehouse", EmitDefaultValue=false)]
        public StringValue Warehouse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseReceipt {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  BillDate: ").Append(BillDate).Append("\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
            sb.Append("  ControlAmount: ").Append(ControlAmount).Append("\n");
            sb.Append("  ControlQty: ").Append(ControlQty).Append("\n");
            sb.Append("  CreateBill: ").Append(CreateBill).Append("\n");
            sb.Append("  CurrencyID: ").Append(CurrencyID).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  PostPeriod: ").Append(PostPeriod).Append("\n");
            sb.Append("  ReceiptNbr: ").Append(ReceiptNbr).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TotalQty: ").Append(TotalQty).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UnbilledQuantity: ").Append(UnbilledQuantity).Append("\n");
            sb.Append("  VendorID: ").Append(VendorID).Append("\n");
            sb.Append("  VendorRef: ").Append(VendorRef).Append("\n");
            sb.Append("  Warehouse: ").Append(Warehouse).Append("\n");
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
            return this.Equals(input as PurchaseReceipt);
        }

        /// <summary>
        /// Returns true if PurchaseReceipt instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseReceipt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseReceipt input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.BillDate == input.BillDate ||
                    (this.BillDate != null &&
                    this.BillDate.Equals(input.BillDate))
                ) && base.Equals(input) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && base.Equals(input) && 
                (
                    this.ControlAmount == input.ControlAmount ||
                    (this.ControlAmount != null &&
                    this.ControlAmount.Equals(input.ControlAmount))
                ) && base.Equals(input) && 
                (
                    this.ControlQty == input.ControlQty ||
                    (this.ControlQty != null &&
                    this.ControlQty.Equals(input.ControlQty))
                ) && base.Equals(input) && 
                (
                    this.CreateBill == input.CreateBill ||
                    (this.CreateBill != null &&
                    this.CreateBill.Equals(input.CreateBill))
                ) && base.Equals(input) && 
                (
                    this.CurrencyID == input.CurrencyID ||
                    (this.CurrencyID != null &&
                    this.CurrencyID.Equals(input.CurrencyID))
                ) && base.Equals(input) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && base.Equals(input) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && base.Equals(input) && 
                (
                    this.Hold == input.Hold ||
                    (this.Hold != null &&
                    this.Hold.Equals(input.Hold))
                ) && base.Equals(input) && 
                (
                    this.PostPeriod == input.PostPeriod ||
                    (this.PostPeriod != null &&
                    this.PostPeriod.Equals(input.PostPeriod))
                ) && base.Equals(input) && 
                (
                    this.ReceiptNbr == input.ReceiptNbr ||
                    (this.ReceiptNbr != null &&
                    this.ReceiptNbr.Equals(input.ReceiptNbr))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && base.Equals(input) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && base.Equals(input) && 
                (
                    this.TotalQty == input.TotalQty ||
                    (this.TotalQty != null &&
                    this.TotalQty.Equals(input.TotalQty))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.UnbilledQuantity == input.UnbilledQuantity ||
                    (this.UnbilledQuantity != null &&
                    this.UnbilledQuantity.Equals(input.UnbilledQuantity))
                ) && base.Equals(input) && 
                (
                    this.VendorID == input.VendorID ||
                    (this.VendorID != null &&
                    this.VendorID.Equals(input.VendorID))
                ) && base.Equals(input) && 
                (
                    this.VendorRef == input.VendorRef ||
                    (this.VendorRef != null &&
                    this.VendorRef.Equals(input.VendorRef))
                ) && base.Equals(input) && 
                (
                    this.Warehouse == input.Warehouse ||
                    (this.Warehouse != null &&
                    this.Warehouse.Equals(input.Warehouse))
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
                if (this.BillDate != null)
                    hashCode = hashCode * 59 + this.BillDate.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.ControlAmount != null)
                    hashCode = hashCode * 59 + this.ControlAmount.GetHashCode();
                if (this.ControlQty != null)
                    hashCode = hashCode * 59 + this.ControlQty.GetHashCode();
                if (this.CreateBill != null)
                    hashCode = hashCode * 59 + this.CreateBill.GetHashCode();
                if (this.CurrencyID != null)
                    hashCode = hashCode * 59 + this.CurrencyID.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Hold != null)
                    hashCode = hashCode * 59 + this.Hold.GetHashCode();
                if (this.PostPeriod != null)
                    hashCode = hashCode * 59 + this.PostPeriod.GetHashCode();
                if (this.ReceiptNbr != null)
                    hashCode = hashCode * 59 + this.ReceiptNbr.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.TotalQty != null)
                    hashCode = hashCode * 59 + this.TotalQty.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UnbilledQuantity != null)
                    hashCode = hashCode * 59 + this.UnbilledQuantity.GetHashCode();
                if (this.VendorID != null)
                    hashCode = hashCode * 59 + this.VendorID.GetHashCode();
                if (this.VendorRef != null)
                    hashCode = hashCode * 59 + this.VendorRef.GetHashCode();
                if (this.Warehouse != null)
                    hashCode = hashCode * 59 + this.Warehouse.GetHashCode();
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
