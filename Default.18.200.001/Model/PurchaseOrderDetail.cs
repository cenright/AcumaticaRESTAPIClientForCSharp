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
    /// PurchaseOrderDetail
    /// </summary>
    [DataContract]
    public partial class PurchaseOrderDetail : Entity,  IEquatable<PurchaseOrderDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderDetail" /> class.
        /// </summary>
        /// <param name="account">account.</param>
        /// <param name="alternateID">alternateID.</param>
        /// <param name="branchID">branchID.</param>
        /// <param name="calculateDiscountsOnImport">calculateDiscountsOnImport.</param>
        /// <param name="cancelled">cancelled.</param>
        /// <param name="completed">completed.</param>
        /// <param name="completeOn">completeOn.</param>
        /// <param name="costCode">costCode.</param>
        /// <param name="description">description.</param>
        /// <param name="extendedCost">extendedCost.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="lineDescription">lineDescription.</param>
        /// <param name="lineNbr">lineNbr.</param>
        /// <param name="lineType">lineType.</param>
        /// <param name="maxReceiptPercent">maxReceiptPercent.</param>
        /// <param name="minReceiptPercent">minReceiptPercent.</param>
        /// <param name="orderNbr">orderNbr.</param>
        /// <param name="orderQty">orderQty.</param>
        /// <param name="orderType">orderType.</param>
        /// <param name="origPONbr">origPONbr.</param>
        /// <param name="origPOType">origPOType.</param>
        /// <param name="project">project.</param>
        /// <param name="projectTask">projectTask.</param>
        /// <param name="promised">promised.</param>
        /// <param name="qtyOnReceipts">qtyOnReceipts.</param>
        /// <param name="receiptAction">receiptAction.</param>
        /// <param name="receivedAmount">receivedAmount.</param>
        /// <param name="requested">requested.</param>
        /// <param name="subaccount">subaccount.</param>
        /// <param name="subitem">subitem.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="uOM">uOM.</param>
        /// <param name="warehouseID">warehouseID.</param>
        public PurchaseOrderDetail(StringValue account = default(StringValue), StringValue alternateID = default(StringValue), StringValue branchID = default(StringValue), BooleanValue calculateDiscountsOnImport = default(BooleanValue), BooleanValue cancelled = default(BooleanValue), BooleanValue completed = default(BooleanValue), DecimalValue completeOn = default(DecimalValue), StringValue costCode = default(StringValue), StringValue description = default(StringValue), DecimalValue extendedCost = default(DecimalValue), StringValue inventoryID = default(StringValue), StringValue lineDescription = default(StringValue), IntValue lineNbr = default(IntValue), StringValue lineType = default(StringValue), DecimalValue maxReceiptPercent = default(DecimalValue), DecimalValue minReceiptPercent = default(DecimalValue), StringValue orderNbr = default(StringValue), DecimalValue orderQty = default(DecimalValue), StringValue orderType = default(StringValue), StringValue origPONbr = default(StringValue), StringValue origPOType = default(StringValue), StringValue project = default(StringValue), StringValue projectTask = default(StringValue), DateTimeValue promised = default(DateTimeValue), DecimalValue qtyOnReceipts = default(DecimalValue), StringValue receiptAction = default(StringValue), DecimalValue receivedAmount = default(DecimalValue), DateTimeValue requested = default(DateTimeValue), StringValue subaccount = default(StringValue), StringValue subitem = default(StringValue), StringValue taxCategory = default(StringValue), DecimalValue unitCost = default(DecimalValue), StringValue uOM = default(StringValue), StringValue warehouseID = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Account = account;
            this.AlternateID = alternateID;
            this.BranchID = branchID;
            this.CalculateDiscountsOnImport = calculateDiscountsOnImport;
            this.Cancelled = cancelled;
            this.Completed = completed;
            this.CompleteOn = completeOn;
            this.CostCode = costCode;
            this.Description = description;
            this.ExtendedCost = extendedCost;
            this.InventoryID = inventoryID;
            this.LineDescription = lineDescription;
            this.LineNbr = lineNbr;
            this.LineType = lineType;
            this.MaxReceiptPercent = maxReceiptPercent;
            this.MinReceiptPercent = minReceiptPercent;
            this.OrderNbr = orderNbr;
            this.OrderQty = orderQty;
            this.OrderType = orderType;
            this.OrigPONbr = origPONbr;
            this.OrigPOType = origPOType;
            this.Project = project;
            this.ProjectTask = projectTask;
            this.Promised = promised;
            this.QtyOnReceipts = qtyOnReceipts;
            this.ReceiptAction = receiptAction;
            this.ReceivedAmount = receivedAmount;
            this.Requested = requested;
            this.Subaccount = subaccount;
            this.Subitem = subitem;
            this.TaxCategory = taxCategory;
            this.UnitCost = unitCost;
            this.UOM = uOM;
            this.WarehouseID = warehouseID;
        }
        
        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public StringValue Account { get; set; }

        /// <summary>
        /// Gets or Sets AlternateID
        /// </summary>
        [DataMember(Name="AlternateID", EmitDefaultValue=false)]
        public StringValue AlternateID { get; set; }

        /// <summary>
        /// Gets or Sets BranchID
        /// </summary>
        [DataMember(Name="BranchID", EmitDefaultValue=false)]
        public StringValue BranchID { get; set; }

        /// <summary>
        /// Gets or Sets CalculateDiscountsOnImport
        /// </summary>
        [DataMember(Name="CalculateDiscountsOnImport", EmitDefaultValue=false)]
        public BooleanValue CalculateDiscountsOnImport { get; set; }

        /// <summary>
        /// Gets or Sets Cancelled
        /// </summary>
        [DataMember(Name="Cancelled", EmitDefaultValue=false)]
        public BooleanValue Cancelled { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="Completed", EmitDefaultValue=false)]
        public BooleanValue Completed { get; set; }

        /// <summary>
        /// Gets or Sets CompleteOn
        /// </summary>
        [DataMember(Name="CompleteOn", EmitDefaultValue=false)]
        public DecimalValue CompleteOn { get; set; }

        /// <summary>
        /// Gets or Sets CostCode
        /// </summary>
        [DataMember(Name="CostCode", EmitDefaultValue=false)]
        public StringValue CostCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedCost
        /// </summary>
        [DataMember(Name="ExtendedCost", EmitDefaultValue=false)]
        public DecimalValue ExtendedCost { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets LineDescription
        /// </summary>
        [DataMember(Name="LineDescription", EmitDefaultValue=false)]
        public StringValue LineDescription { get; set; }

        /// <summary>
        /// Gets or Sets LineNbr
        /// </summary>
        [DataMember(Name="LineNbr", EmitDefaultValue=false)]
        public IntValue LineNbr { get; set; }

        /// <summary>
        /// Gets or Sets LineType
        /// </summary>
        [DataMember(Name="LineType", EmitDefaultValue=false)]
        public StringValue LineType { get; set; }

        /// <summary>
        /// Gets or Sets MaxReceiptPercent
        /// </summary>
        [DataMember(Name="MaxReceiptPercent", EmitDefaultValue=false)]
        public DecimalValue MaxReceiptPercent { get; set; }

        /// <summary>
        /// Gets or Sets MinReceiptPercent
        /// </summary>
        [DataMember(Name="MinReceiptPercent", EmitDefaultValue=false)]
        public DecimalValue MinReceiptPercent { get; set; }

        /// <summary>
        /// Gets or Sets OrderNbr
        /// </summary>
        [DataMember(Name="OrderNbr", EmitDefaultValue=false)]
        public StringValue OrderNbr { get; set; }

        /// <summary>
        /// Gets or Sets OrderQty
        /// </summary>
        [DataMember(Name="OrderQty", EmitDefaultValue=false)]
        public DecimalValue OrderQty { get; set; }

        /// <summary>
        /// Gets or Sets OrderType
        /// </summary>
        [DataMember(Name="OrderType", EmitDefaultValue=false)]
        public StringValue OrderType { get; set; }

        /// <summary>
        /// Gets or Sets OrigPONbr
        /// </summary>
        [DataMember(Name="OrigPONbr", EmitDefaultValue=false)]
        public StringValue OrigPONbr { get; set; }

        /// <summary>
        /// Gets or Sets OrigPOType
        /// </summary>
        [DataMember(Name="OrigPOType", EmitDefaultValue=false)]
        public StringValue OrigPOType { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name="Project", EmitDefaultValue=false)]
        public StringValue Project { get; set; }

        /// <summary>
        /// Gets or Sets ProjectTask
        /// </summary>
        [DataMember(Name="ProjectTask", EmitDefaultValue=false)]
        public StringValue ProjectTask { get; set; }

        /// <summary>
        /// Gets or Sets Promised
        /// </summary>
        [DataMember(Name="Promised", EmitDefaultValue=false)]
        public DateTimeValue Promised { get; set; }

        /// <summary>
        /// Gets or Sets QtyOnReceipts
        /// </summary>
        [DataMember(Name="QtyOnReceipts", EmitDefaultValue=false)]
        public DecimalValue QtyOnReceipts { get; set; }

        /// <summary>
        /// Gets or Sets ReceiptAction
        /// </summary>
        [DataMember(Name="ReceiptAction", EmitDefaultValue=false)]
        public StringValue ReceiptAction { get; set; }

        /// <summary>
        /// Gets or Sets ReceivedAmount
        /// </summary>
        [DataMember(Name="ReceivedAmount", EmitDefaultValue=false)]
        public DecimalValue ReceivedAmount { get; set; }

        /// <summary>
        /// Gets or Sets Requested
        /// </summary>
        [DataMember(Name="Requested", EmitDefaultValue=false)]
        public DateTimeValue Requested { get; set; }

        /// <summary>
        /// Gets or Sets Subaccount
        /// </summary>
        [DataMember(Name="Subaccount", EmitDefaultValue=false)]
        public StringValue Subaccount { get; set; }

        /// <summary>
        /// Gets or Sets Subitem
        /// </summary>
        [DataMember(Name="Subitem", EmitDefaultValue=false)]
        public StringValue Subitem { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

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
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public StringValue WarehouseID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseOrderDetail {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AlternateID: ").Append(AlternateID).Append("\n");
            sb.Append("  BranchID: ").Append(BranchID).Append("\n");
            sb.Append("  CalculateDiscountsOnImport: ").Append(CalculateDiscountsOnImport).Append("\n");
            sb.Append("  Cancelled: ").Append(Cancelled).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  CompleteOn: ").Append(CompleteOn).Append("\n");
            sb.Append("  CostCode: ").Append(CostCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExtendedCost: ").Append(ExtendedCost).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  LineDescription: ").Append(LineDescription).Append("\n");
            sb.Append("  LineNbr: ").Append(LineNbr).Append("\n");
            sb.Append("  LineType: ").Append(LineType).Append("\n");
            sb.Append("  MaxReceiptPercent: ").Append(MaxReceiptPercent).Append("\n");
            sb.Append("  MinReceiptPercent: ").Append(MinReceiptPercent).Append("\n");
            sb.Append("  OrderNbr: ").Append(OrderNbr).Append("\n");
            sb.Append("  OrderQty: ").Append(OrderQty).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  OrigPONbr: ").Append(OrigPONbr).Append("\n");
            sb.Append("  OrigPOType: ").Append(OrigPOType).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
            sb.Append("  ProjectTask: ").Append(ProjectTask).Append("\n");
            sb.Append("  Promised: ").Append(Promised).Append("\n");
            sb.Append("  QtyOnReceipts: ").Append(QtyOnReceipts).Append("\n");
            sb.Append("  ReceiptAction: ").Append(ReceiptAction).Append("\n");
            sb.Append("  ReceivedAmount: ").Append(ReceivedAmount).Append("\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  Subaccount: ").Append(Subaccount).Append("\n");
            sb.Append("  Subitem: ").Append(Subitem).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  UnitCost: ").Append(UnitCost).Append("\n");
            sb.Append("  UOM: ").Append(UOM).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
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
            return this.Equals(input as PurchaseOrderDetail);
        }

        /// <summary>
        /// Returns true if PurchaseOrderDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrderDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrderDetail input)
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
                    this.AlternateID == input.AlternateID ||
                    (this.AlternateID != null &&
                    this.AlternateID.Equals(input.AlternateID))
                ) && base.Equals(input) && 
                (
                    this.BranchID == input.BranchID ||
                    (this.BranchID != null &&
                    this.BranchID.Equals(input.BranchID))
                ) && base.Equals(input) && 
                (
                    this.CalculateDiscountsOnImport == input.CalculateDiscountsOnImport ||
                    (this.CalculateDiscountsOnImport != null &&
                    this.CalculateDiscountsOnImport.Equals(input.CalculateDiscountsOnImport))
                ) && base.Equals(input) && 
                (
                    this.Cancelled == input.Cancelled ||
                    (this.Cancelled != null &&
                    this.Cancelled.Equals(input.Cancelled))
                ) && base.Equals(input) && 
                (
                    this.Completed == input.Completed ||
                    (this.Completed != null &&
                    this.Completed.Equals(input.Completed))
                ) && base.Equals(input) && 
                (
                    this.CompleteOn == input.CompleteOn ||
                    (this.CompleteOn != null &&
                    this.CompleteOn.Equals(input.CompleteOn))
                ) && base.Equals(input) && 
                (
                    this.CostCode == input.CostCode ||
                    (this.CostCode != null &&
                    this.CostCode.Equals(input.CostCode))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.ExtendedCost == input.ExtendedCost ||
                    (this.ExtendedCost != null &&
                    this.ExtendedCost.Equals(input.ExtendedCost))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.LineDescription == input.LineDescription ||
                    (this.LineDescription != null &&
                    this.LineDescription.Equals(input.LineDescription))
                ) && base.Equals(input) && 
                (
                    this.LineNbr == input.LineNbr ||
                    (this.LineNbr != null &&
                    this.LineNbr.Equals(input.LineNbr))
                ) && base.Equals(input) && 
                (
                    this.LineType == input.LineType ||
                    (this.LineType != null &&
                    this.LineType.Equals(input.LineType))
                ) && base.Equals(input) && 
                (
                    this.MaxReceiptPercent == input.MaxReceiptPercent ||
                    (this.MaxReceiptPercent != null &&
                    this.MaxReceiptPercent.Equals(input.MaxReceiptPercent))
                ) && base.Equals(input) && 
                (
                    this.MinReceiptPercent == input.MinReceiptPercent ||
                    (this.MinReceiptPercent != null &&
                    this.MinReceiptPercent.Equals(input.MinReceiptPercent))
                ) && base.Equals(input) && 
                (
                    this.OrderNbr == input.OrderNbr ||
                    (this.OrderNbr != null &&
                    this.OrderNbr.Equals(input.OrderNbr))
                ) && base.Equals(input) && 
                (
                    this.OrderQty == input.OrderQty ||
                    (this.OrderQty != null &&
                    this.OrderQty.Equals(input.OrderQty))
                ) && base.Equals(input) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && base.Equals(input) && 
                (
                    this.OrigPONbr == input.OrigPONbr ||
                    (this.OrigPONbr != null &&
                    this.OrigPONbr.Equals(input.OrigPONbr))
                ) && base.Equals(input) && 
                (
                    this.OrigPOType == input.OrigPOType ||
                    (this.OrigPOType != null &&
                    this.OrigPOType.Equals(input.OrigPOType))
                ) && base.Equals(input) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && base.Equals(input) && 
                (
                    this.ProjectTask == input.ProjectTask ||
                    (this.ProjectTask != null &&
                    this.ProjectTask.Equals(input.ProjectTask))
                ) && base.Equals(input) && 
                (
                    this.Promised == input.Promised ||
                    (this.Promised != null &&
                    this.Promised.Equals(input.Promised))
                ) && base.Equals(input) && 
                (
                    this.QtyOnReceipts == input.QtyOnReceipts ||
                    (this.QtyOnReceipts != null &&
                    this.QtyOnReceipts.Equals(input.QtyOnReceipts))
                ) && base.Equals(input) && 
                (
                    this.ReceiptAction == input.ReceiptAction ||
                    (this.ReceiptAction != null &&
                    this.ReceiptAction.Equals(input.ReceiptAction))
                ) && base.Equals(input) && 
                (
                    this.ReceivedAmount == input.ReceivedAmount ||
                    (this.ReceivedAmount != null &&
                    this.ReceivedAmount.Equals(input.ReceivedAmount))
                ) && base.Equals(input) && 
                (
                    this.Requested == input.Requested ||
                    (this.Requested != null &&
                    this.Requested.Equals(input.Requested))
                ) && base.Equals(input) && 
                (
                    this.Subaccount == input.Subaccount ||
                    (this.Subaccount != null &&
                    this.Subaccount.Equals(input.Subaccount))
                ) && base.Equals(input) && 
                (
                    this.Subitem == input.Subitem ||
                    (this.Subitem != null &&
                    this.Subitem.Equals(input.Subitem))
                ) && base.Equals(input) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
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
                ) && base.Equals(input) && 
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
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
                if (this.AlternateID != null)
                    hashCode = hashCode * 59 + this.AlternateID.GetHashCode();
                if (this.BranchID != null)
                    hashCode = hashCode * 59 + this.BranchID.GetHashCode();
                if (this.CalculateDiscountsOnImport != null)
                    hashCode = hashCode * 59 + this.CalculateDiscountsOnImport.GetHashCode();
                if (this.Cancelled != null)
                    hashCode = hashCode * 59 + this.Cancelled.GetHashCode();
                if (this.Completed != null)
                    hashCode = hashCode * 59 + this.Completed.GetHashCode();
                if (this.CompleteOn != null)
                    hashCode = hashCode * 59 + this.CompleteOn.GetHashCode();
                if (this.CostCode != null)
                    hashCode = hashCode * 59 + this.CostCode.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExtendedCost != null)
                    hashCode = hashCode * 59 + this.ExtendedCost.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.LineDescription != null)
                    hashCode = hashCode * 59 + this.LineDescription.GetHashCode();
                if (this.LineNbr != null)
                    hashCode = hashCode * 59 + this.LineNbr.GetHashCode();
                if (this.LineType != null)
                    hashCode = hashCode * 59 + this.LineType.GetHashCode();
                if (this.MaxReceiptPercent != null)
                    hashCode = hashCode * 59 + this.MaxReceiptPercent.GetHashCode();
                if (this.MinReceiptPercent != null)
                    hashCode = hashCode * 59 + this.MinReceiptPercent.GetHashCode();
                if (this.OrderNbr != null)
                    hashCode = hashCode * 59 + this.OrderNbr.GetHashCode();
                if (this.OrderQty != null)
                    hashCode = hashCode * 59 + this.OrderQty.GetHashCode();
                if (this.OrderType != null)
                    hashCode = hashCode * 59 + this.OrderType.GetHashCode();
                if (this.OrigPONbr != null)
                    hashCode = hashCode * 59 + this.OrigPONbr.GetHashCode();
                if (this.OrigPOType != null)
                    hashCode = hashCode * 59 + this.OrigPOType.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.ProjectTask != null)
                    hashCode = hashCode * 59 + this.ProjectTask.GetHashCode();
                if (this.Promised != null)
                    hashCode = hashCode * 59 + this.Promised.GetHashCode();
                if (this.QtyOnReceipts != null)
                    hashCode = hashCode * 59 + this.QtyOnReceipts.GetHashCode();
                if (this.ReceiptAction != null)
                    hashCode = hashCode * 59 + this.ReceiptAction.GetHashCode();
                if (this.ReceivedAmount != null)
                    hashCode = hashCode * 59 + this.ReceivedAmount.GetHashCode();
                if (this.Requested != null)
                    hashCode = hashCode * 59 + this.Requested.GetHashCode();
                if (this.Subaccount != null)
                    hashCode = hashCode * 59 + this.Subaccount.GetHashCode();
                if (this.Subitem != null)
                    hashCode = hashCode * 59 + this.Subitem.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.UnitCost != null)
                    hashCode = hashCode * 59 + this.UnitCost.GetHashCode();
                if (this.UOM != null)
                    hashCode = hashCode * 59 + this.UOM.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
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
