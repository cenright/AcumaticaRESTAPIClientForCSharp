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
    /// NonStockItem
    /// </summary>
    [DataContract]
    public partial class NonStockItem : Entity,  IEquatable<NonStockItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NonStockItem" /> class.
        /// </summary>
        /// <param name="attributes">attributes.</param>
        /// <param name="baseUnit">baseUnit.</param>
        /// <param name="crossReferences">crossReferences.</param>
        /// <param name="currentCost">currentCost.</param>
        /// <param name="defaultPrice">defaultPrice.</param>
        /// <param name="deferralAccount">deferralAccount.</param>
        /// <param name="deferralSubaccount">deferralSubaccount.</param>
        /// <param name="description">description.</param>
        /// <param name="effectiveDate">effectiveDate.</param>
        /// <param name="expenseAccount">expenseAccount.</param>
        /// <param name="expenseAccrualAccount">expenseAccrualAccount.</param>
        /// <param name="expenseAccrualSubaccount">expenseAccrualSubaccount.</param>
        /// <param name="expenseSubaccount">expenseSubaccount.</param>
        /// <param name="inventoryID">inventoryID.</param>
        /// <param name="isKit">isKit.</param>
        /// <param name="itemClass">itemClass.</param>
        /// <param name="itemStatus">itemStatus.</param>
        /// <param name="itemType">itemType.</param>
        /// <param name="lastCost">lastCost.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="pendingCost">pendingCost.</param>
        /// <param name="pendingCostDate">pendingCostDate.</param>
        /// <param name="pOAccrualAccount">pOAccrualAccount.</param>
        /// <param name="pOAccrualSubaccount">pOAccrualSubaccount.</param>
        /// <param name="postingClass">postingClass.</param>
        /// <param name="priceClass">priceClass.</param>
        /// <param name="purchasePriceVarianceAccount">purchasePriceVarianceAccount.</param>
        /// <param name="purchasePriceVarianceSubaccount">purchasePriceVarianceSubaccount.</param>
        /// <param name="purchaseUnit">purchaseUnit.</param>
        /// <param name="reasonCodeSubaccount">reasonCodeSubaccount.</param>
        /// <param name="requireReceipt">requireReceipt.</param>
        /// <param name="requireShipment">requireShipment.</param>
        /// <param name="salesAccount">salesAccount.</param>
        /// <param name="salesCategories">salesCategories.</param>
        /// <param name="salesSubaccount">salesSubaccount.</param>
        /// <param name="salesUnit">salesUnit.</param>
        /// <param name="taxCategory">taxCategory.</param>
        /// <param name="vendorDetails">vendorDetails.</param>
        /// <param name="volume">volume.</param>
        /// <param name="volumeUOM">volumeUOM.</param>
        /// <param name="weight">weight.</param>
        /// <param name="weightUOM">weightUOM.</param>
        public NonStockItem(List<NonStockItemAttribute> attributes = default(List<NonStockItemAttribute>), StringValue baseUnit = default(StringValue), List<InventoryItemCrossReference> crossReferences = default(List<InventoryItemCrossReference>), DecimalValue currentCost = default(DecimalValue), DecimalValue defaultPrice = default(DecimalValue), StringValue deferralAccount = default(StringValue), StringValue deferralSubaccount = default(StringValue), StringValue description = default(StringValue), DateTimeValue effectiveDate = default(DateTimeValue), StringValue expenseAccount = default(StringValue), StringValue expenseAccrualAccount = default(StringValue), StringValue expenseAccrualSubaccount = default(StringValue), StringValue expenseSubaccount = default(StringValue), StringValue inventoryID = default(StringValue), BooleanValue isKit = default(BooleanValue), StringValue itemClass = default(StringValue), StringValue itemStatus = default(StringValue), StringValue itemType = default(StringValue), DecimalValue lastCost = default(DecimalValue), DateTimeValue lastModifiedDateTime = default(DateTimeValue), DecimalValue pendingCost = default(DecimalValue), DateTimeValue pendingCostDate = default(DateTimeValue), StringValue pOAccrualAccount = default(StringValue), StringValue pOAccrualSubaccount = default(StringValue), StringValue postingClass = default(StringValue), StringValue priceClass = default(StringValue), StringValue purchasePriceVarianceAccount = default(StringValue), StringValue purchasePriceVarianceSubaccount = default(StringValue), StringValue purchaseUnit = default(StringValue), StringValue reasonCodeSubaccount = default(StringValue), BooleanValue requireReceipt = default(BooleanValue), BooleanValue requireShipment = default(BooleanValue), StringValue salesAccount = default(StringValue), List<NonStockItemSalesCategory> salesCategories = default(List<NonStockItemSalesCategory>), StringValue salesSubaccount = default(StringValue), StringValue salesUnit = default(StringValue), StringValue taxCategory = default(StringValue), List<NonStockItemVendorDetail> vendorDetails = default(List<NonStockItemVendorDetail>), DecimalValue volume = default(DecimalValue), StringValue volumeUOM = default(StringValue), DecimalValue weight = default(DecimalValue), StringValue weightUOM = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.Attributes = attributes;
            this.BaseUnit = baseUnit;
            this.CrossReferences = crossReferences;
            this.CurrentCost = currentCost;
            this.DefaultPrice = defaultPrice;
            this.DeferralAccount = deferralAccount;
            this.DeferralSubaccount = deferralSubaccount;
            this.Description = description;
            this.EffectiveDate = effectiveDate;
            this.ExpenseAccount = expenseAccount;
            this.ExpenseAccrualAccount = expenseAccrualAccount;
            this.ExpenseAccrualSubaccount = expenseAccrualSubaccount;
            this.ExpenseSubaccount = expenseSubaccount;
            this.InventoryID = inventoryID;
            this.IsKit = isKit;
            this.ItemClass = itemClass;
            this.ItemStatus = itemStatus;
            this.ItemType = itemType;
            this.LastCost = lastCost;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.PendingCost = pendingCost;
            this.PendingCostDate = pendingCostDate;
            this.POAccrualAccount = pOAccrualAccount;
            this.POAccrualSubaccount = pOAccrualSubaccount;
            this.PostingClass = postingClass;
            this.PriceClass = priceClass;
            this.PurchasePriceVarianceAccount = purchasePriceVarianceAccount;
            this.PurchasePriceVarianceSubaccount = purchasePriceVarianceSubaccount;
            this.PurchaseUnit = purchaseUnit;
            this.ReasonCodeSubaccount = reasonCodeSubaccount;
            this.RequireReceipt = requireReceipt;
            this.RequireShipment = requireShipment;
            this.SalesAccount = salesAccount;
            this.SalesCategories = salesCategories;
            this.SalesSubaccount = salesSubaccount;
            this.SalesUnit = salesUnit;
            this.TaxCategory = taxCategory;
            this.VendorDetails = vendorDetails;
            this.Volume = volume;
            this.VolumeUOM = volumeUOM;
            this.Weight = weight;
            this.WeightUOM = weightUOM;
        }
        
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="Attributes", EmitDefaultValue=false)]
        public List<NonStockItemAttribute> Attributes { get; set; }

        /// <summary>
        /// Gets or Sets BaseUnit
        /// </summary>
        [DataMember(Name="BaseUnit", EmitDefaultValue=false)]
        public StringValue BaseUnit { get; set; }

        /// <summary>
        /// Gets or Sets CrossReferences
        /// </summary>
        [DataMember(Name="CrossReferences", EmitDefaultValue=false)]
        public List<InventoryItemCrossReference> CrossReferences { get; set; }

        /// <summary>
        /// Gets or Sets CurrentCost
        /// </summary>
        [DataMember(Name="CurrentCost", EmitDefaultValue=false)]
        public DecimalValue CurrentCost { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPrice
        /// </summary>
        [DataMember(Name="DefaultPrice", EmitDefaultValue=false)]
        public DecimalValue DefaultPrice { get; set; }

        /// <summary>
        /// Gets or Sets DeferralAccount
        /// </summary>
        [DataMember(Name="DeferralAccount", EmitDefaultValue=false)]
        public StringValue DeferralAccount { get; set; }

        /// <summary>
        /// Gets or Sets DeferralSubaccount
        /// </summary>
        [DataMember(Name="DeferralSubaccount", EmitDefaultValue=false)]
        public StringValue DeferralSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveDate
        /// </summary>
        [DataMember(Name="EffectiveDate", EmitDefaultValue=false)]
        public DateTimeValue EffectiveDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAccount
        /// </summary>
        [DataMember(Name="ExpenseAccount", EmitDefaultValue=false)]
        public StringValue ExpenseAccount { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAccrualAccount
        /// </summary>
        [DataMember(Name="ExpenseAccrualAccount", EmitDefaultValue=false)]
        public StringValue ExpenseAccrualAccount { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAccrualSubaccount
        /// </summary>
        [DataMember(Name="ExpenseAccrualSubaccount", EmitDefaultValue=false)]
        public StringValue ExpenseAccrualSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseSubaccount
        /// </summary>
        [DataMember(Name="ExpenseSubaccount", EmitDefaultValue=false)]
        public StringValue ExpenseSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets InventoryID
        /// </summary>
        [DataMember(Name="InventoryID", EmitDefaultValue=false)]
        public StringValue InventoryID { get; set; }

        /// <summary>
        /// Gets or Sets IsKit
        /// </summary>
        [DataMember(Name="IsKit", EmitDefaultValue=false)]
        public BooleanValue IsKit { get; set; }

        /// <summary>
        /// Gets or Sets ItemClass
        /// </summary>
        [DataMember(Name="ItemClass", EmitDefaultValue=false)]
        public StringValue ItemClass { get; set; }

        /// <summary>
        /// Gets or Sets ItemStatus
        /// </summary>
        [DataMember(Name="ItemStatus", EmitDefaultValue=false)]
        public StringValue ItemStatus { get; set; }

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name="ItemType", EmitDefaultValue=false)]
        public StringValue ItemType { get; set; }

        /// <summary>
        /// Gets or Sets LastCost
        /// </summary>
        [DataMember(Name="LastCost", EmitDefaultValue=false)]
        public DecimalValue LastCost { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name="LastModifiedDateTime", EmitDefaultValue=false)]
        public DateTimeValue LastModifiedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets PendingCost
        /// </summary>
        [DataMember(Name="PendingCost", EmitDefaultValue=false)]
        public DecimalValue PendingCost { get; set; }

        /// <summary>
        /// Gets or Sets PendingCostDate
        /// </summary>
        [DataMember(Name="PendingCostDate", EmitDefaultValue=false)]
        public DateTimeValue PendingCostDate { get; set; }

        /// <summary>
        /// Gets or Sets POAccrualAccount
        /// </summary>
        [DataMember(Name="POAccrualAccount", EmitDefaultValue=false)]
        public StringValue POAccrualAccount { get; set; }

        /// <summary>
        /// Gets or Sets POAccrualSubaccount
        /// </summary>
        [DataMember(Name="POAccrualSubaccount", EmitDefaultValue=false)]
        public StringValue POAccrualSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets PostingClass
        /// </summary>
        [DataMember(Name="PostingClass", EmitDefaultValue=false)]
        public StringValue PostingClass { get; set; }

        /// <summary>
        /// Gets or Sets PriceClass
        /// </summary>
        [DataMember(Name="PriceClass", EmitDefaultValue=false)]
        public StringValue PriceClass { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePriceVarianceAccount
        /// </summary>
        [DataMember(Name="PurchasePriceVarianceAccount", EmitDefaultValue=false)]
        public StringValue PurchasePriceVarianceAccount { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePriceVarianceSubaccount
        /// </summary>
        [DataMember(Name="PurchasePriceVarianceSubaccount", EmitDefaultValue=false)]
        public StringValue PurchasePriceVarianceSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseUnit
        /// </summary>
        [DataMember(Name="PurchaseUnit", EmitDefaultValue=false)]
        public StringValue PurchaseUnit { get; set; }

        /// <summary>
        /// Gets or Sets ReasonCodeSubaccount
        /// </summary>
        [DataMember(Name="ReasonCodeSubaccount", EmitDefaultValue=false)]
        public StringValue ReasonCodeSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets RequireReceipt
        /// </summary>
        [DataMember(Name="RequireReceipt", EmitDefaultValue=false)]
        public BooleanValue RequireReceipt { get; set; }

        /// <summary>
        /// Gets or Sets RequireShipment
        /// </summary>
        [DataMember(Name="RequireShipment", EmitDefaultValue=false)]
        public BooleanValue RequireShipment { get; set; }

        /// <summary>
        /// Gets or Sets SalesAccount
        /// </summary>
        [DataMember(Name="SalesAccount", EmitDefaultValue=false)]
        public StringValue SalesAccount { get; set; }

        /// <summary>
        /// Gets or Sets SalesCategories
        /// </summary>
        [DataMember(Name="SalesCategories", EmitDefaultValue=false)]
        public List<NonStockItemSalesCategory> SalesCategories { get; set; }

        /// <summary>
        /// Gets or Sets SalesSubaccount
        /// </summary>
        [DataMember(Name="SalesSubaccount", EmitDefaultValue=false)]
        public StringValue SalesSubaccount { get; set; }

        /// <summary>
        /// Gets or Sets SalesUnit
        /// </summary>
        [DataMember(Name="SalesUnit", EmitDefaultValue=false)]
        public StringValue SalesUnit { get; set; }

        /// <summary>
        /// Gets or Sets TaxCategory
        /// </summary>
        [DataMember(Name="TaxCategory", EmitDefaultValue=false)]
        public StringValue TaxCategory { get; set; }

        /// <summary>
        /// Gets or Sets VendorDetails
        /// </summary>
        [DataMember(Name="VendorDetails", EmitDefaultValue=false)]
        public List<NonStockItemVendorDetail> VendorDetails { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="Volume", EmitDefaultValue=false)]
        public DecimalValue Volume { get; set; }

        /// <summary>
        /// Gets or Sets VolumeUOM
        /// </summary>
        [DataMember(Name="VolumeUOM", EmitDefaultValue=false)]
        public StringValue VolumeUOM { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name="Weight", EmitDefaultValue=false)]
        public DecimalValue Weight { get; set; }

        /// <summary>
        /// Gets or Sets WeightUOM
        /// </summary>
        [DataMember(Name="WeightUOM", EmitDefaultValue=false)]
        public StringValue WeightUOM { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NonStockItem {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  BaseUnit: ").Append(BaseUnit).Append("\n");
            sb.Append("  CrossReferences: ").Append(CrossReferences).Append("\n");
            sb.Append("  CurrentCost: ").Append(CurrentCost).Append("\n");
            sb.Append("  DefaultPrice: ").Append(DefaultPrice).Append("\n");
            sb.Append("  DeferralAccount: ").Append(DeferralAccount).Append("\n");
            sb.Append("  DeferralSubaccount: ").Append(DeferralSubaccount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  ExpenseAccount: ").Append(ExpenseAccount).Append("\n");
            sb.Append("  ExpenseAccrualAccount: ").Append(ExpenseAccrualAccount).Append("\n");
            sb.Append("  ExpenseAccrualSubaccount: ").Append(ExpenseAccrualSubaccount).Append("\n");
            sb.Append("  ExpenseSubaccount: ").Append(ExpenseSubaccount).Append("\n");
            sb.Append("  InventoryID: ").Append(InventoryID).Append("\n");
            sb.Append("  IsKit: ").Append(IsKit).Append("\n");
            sb.Append("  ItemClass: ").Append(ItemClass).Append("\n");
            sb.Append("  ItemStatus: ").Append(ItemStatus).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  LastCost: ").Append(LastCost).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  PendingCost: ").Append(PendingCost).Append("\n");
            sb.Append("  PendingCostDate: ").Append(PendingCostDate).Append("\n");
            sb.Append("  POAccrualAccount: ").Append(POAccrualAccount).Append("\n");
            sb.Append("  POAccrualSubaccount: ").Append(POAccrualSubaccount).Append("\n");
            sb.Append("  PostingClass: ").Append(PostingClass).Append("\n");
            sb.Append("  PriceClass: ").Append(PriceClass).Append("\n");
            sb.Append("  PurchasePriceVarianceAccount: ").Append(PurchasePriceVarianceAccount).Append("\n");
            sb.Append("  PurchasePriceVarianceSubaccount: ").Append(PurchasePriceVarianceSubaccount).Append("\n");
            sb.Append("  PurchaseUnit: ").Append(PurchaseUnit).Append("\n");
            sb.Append("  ReasonCodeSubaccount: ").Append(ReasonCodeSubaccount).Append("\n");
            sb.Append("  RequireReceipt: ").Append(RequireReceipt).Append("\n");
            sb.Append("  RequireShipment: ").Append(RequireShipment).Append("\n");
            sb.Append("  SalesAccount: ").Append(SalesAccount).Append("\n");
            sb.Append("  SalesCategories: ").Append(SalesCategories).Append("\n");
            sb.Append("  SalesSubaccount: ").Append(SalesSubaccount).Append("\n");
            sb.Append("  SalesUnit: ").Append(SalesUnit).Append("\n");
            sb.Append("  TaxCategory: ").Append(TaxCategory).Append("\n");
            sb.Append("  VendorDetails: ").Append(VendorDetails).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  VolumeUOM: ").Append(VolumeUOM).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  WeightUOM: ").Append(WeightUOM).Append("\n");
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
            return this.Equals(input as NonStockItem);
        }

        /// <summary>
        /// Returns true if NonStockItem instances are equal
        /// </summary>
        /// <param name="input">Instance of NonStockItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NonStockItem input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && base.Equals(input) && 
                (
                    this.BaseUnit == input.BaseUnit ||
                    (this.BaseUnit != null &&
                    this.BaseUnit.Equals(input.BaseUnit))
                ) && base.Equals(input) && 
                (
                    this.CrossReferences == input.CrossReferences ||
                    this.CrossReferences != null &&
                    this.CrossReferences.SequenceEqual(input.CrossReferences)
                ) && base.Equals(input) && 
                (
                    this.CurrentCost == input.CurrentCost ||
                    (this.CurrentCost != null &&
                    this.CurrentCost.Equals(input.CurrentCost))
                ) && base.Equals(input) && 
                (
                    this.DefaultPrice == input.DefaultPrice ||
                    (this.DefaultPrice != null &&
                    this.DefaultPrice.Equals(input.DefaultPrice))
                ) && base.Equals(input) && 
                (
                    this.DeferralAccount == input.DeferralAccount ||
                    (this.DeferralAccount != null &&
                    this.DeferralAccount.Equals(input.DeferralAccount))
                ) && base.Equals(input) && 
                (
                    this.DeferralSubaccount == input.DeferralSubaccount ||
                    (this.DeferralSubaccount != null &&
                    this.DeferralSubaccount.Equals(input.DeferralSubaccount))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && base.Equals(input) && 
                (
                    this.ExpenseAccount == input.ExpenseAccount ||
                    (this.ExpenseAccount != null &&
                    this.ExpenseAccount.Equals(input.ExpenseAccount))
                ) && base.Equals(input) && 
                (
                    this.ExpenseAccrualAccount == input.ExpenseAccrualAccount ||
                    (this.ExpenseAccrualAccount != null &&
                    this.ExpenseAccrualAccount.Equals(input.ExpenseAccrualAccount))
                ) && base.Equals(input) && 
                (
                    this.ExpenseAccrualSubaccount == input.ExpenseAccrualSubaccount ||
                    (this.ExpenseAccrualSubaccount != null &&
                    this.ExpenseAccrualSubaccount.Equals(input.ExpenseAccrualSubaccount))
                ) && base.Equals(input) && 
                (
                    this.ExpenseSubaccount == input.ExpenseSubaccount ||
                    (this.ExpenseSubaccount != null &&
                    this.ExpenseSubaccount.Equals(input.ExpenseSubaccount))
                ) && base.Equals(input) && 
                (
                    this.InventoryID == input.InventoryID ||
                    (this.InventoryID != null &&
                    this.InventoryID.Equals(input.InventoryID))
                ) && base.Equals(input) && 
                (
                    this.IsKit == input.IsKit ||
                    (this.IsKit != null &&
                    this.IsKit.Equals(input.IsKit))
                ) && base.Equals(input) && 
                (
                    this.ItemClass == input.ItemClass ||
                    (this.ItemClass != null &&
                    this.ItemClass.Equals(input.ItemClass))
                ) && base.Equals(input) && 
                (
                    this.ItemStatus == input.ItemStatus ||
                    (this.ItemStatus != null &&
                    this.ItemStatus.Equals(input.ItemStatus))
                ) && base.Equals(input) && 
                (
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
                ) && base.Equals(input) && 
                (
                    this.LastCost == input.LastCost ||
                    (this.LastCost != null &&
                    this.LastCost.Equals(input.LastCost))
                ) && base.Equals(input) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
                ) && base.Equals(input) && 
                (
                    this.PendingCost == input.PendingCost ||
                    (this.PendingCost != null &&
                    this.PendingCost.Equals(input.PendingCost))
                ) && base.Equals(input) && 
                (
                    this.PendingCostDate == input.PendingCostDate ||
                    (this.PendingCostDate != null &&
                    this.PendingCostDate.Equals(input.PendingCostDate))
                ) && base.Equals(input) && 
                (
                    this.POAccrualAccount == input.POAccrualAccount ||
                    (this.POAccrualAccount != null &&
                    this.POAccrualAccount.Equals(input.POAccrualAccount))
                ) && base.Equals(input) && 
                (
                    this.POAccrualSubaccount == input.POAccrualSubaccount ||
                    (this.POAccrualSubaccount != null &&
                    this.POAccrualSubaccount.Equals(input.POAccrualSubaccount))
                ) && base.Equals(input) && 
                (
                    this.PostingClass == input.PostingClass ||
                    (this.PostingClass != null &&
                    this.PostingClass.Equals(input.PostingClass))
                ) && base.Equals(input) && 
                (
                    this.PriceClass == input.PriceClass ||
                    (this.PriceClass != null &&
                    this.PriceClass.Equals(input.PriceClass))
                ) && base.Equals(input) && 
                (
                    this.PurchasePriceVarianceAccount == input.PurchasePriceVarianceAccount ||
                    (this.PurchasePriceVarianceAccount != null &&
                    this.PurchasePriceVarianceAccount.Equals(input.PurchasePriceVarianceAccount))
                ) && base.Equals(input) && 
                (
                    this.PurchasePriceVarianceSubaccount == input.PurchasePriceVarianceSubaccount ||
                    (this.PurchasePriceVarianceSubaccount != null &&
                    this.PurchasePriceVarianceSubaccount.Equals(input.PurchasePriceVarianceSubaccount))
                ) && base.Equals(input) && 
                (
                    this.PurchaseUnit == input.PurchaseUnit ||
                    (this.PurchaseUnit != null &&
                    this.PurchaseUnit.Equals(input.PurchaseUnit))
                ) && base.Equals(input) && 
                (
                    this.ReasonCodeSubaccount == input.ReasonCodeSubaccount ||
                    (this.ReasonCodeSubaccount != null &&
                    this.ReasonCodeSubaccount.Equals(input.ReasonCodeSubaccount))
                ) && base.Equals(input) && 
                (
                    this.RequireReceipt == input.RequireReceipt ||
                    (this.RequireReceipt != null &&
                    this.RequireReceipt.Equals(input.RequireReceipt))
                ) && base.Equals(input) && 
                (
                    this.RequireShipment == input.RequireShipment ||
                    (this.RequireShipment != null &&
                    this.RequireShipment.Equals(input.RequireShipment))
                ) && base.Equals(input) && 
                (
                    this.SalesAccount == input.SalesAccount ||
                    (this.SalesAccount != null &&
                    this.SalesAccount.Equals(input.SalesAccount))
                ) && base.Equals(input) && 
                (
                    this.SalesCategories == input.SalesCategories ||
                    this.SalesCategories != null &&
                    this.SalesCategories.SequenceEqual(input.SalesCategories)
                ) && base.Equals(input) && 
                (
                    this.SalesSubaccount == input.SalesSubaccount ||
                    (this.SalesSubaccount != null &&
                    this.SalesSubaccount.Equals(input.SalesSubaccount))
                ) && base.Equals(input) && 
                (
                    this.SalesUnit == input.SalesUnit ||
                    (this.SalesUnit != null &&
                    this.SalesUnit.Equals(input.SalesUnit))
                ) && base.Equals(input) && 
                (
                    this.TaxCategory == input.TaxCategory ||
                    (this.TaxCategory != null &&
                    this.TaxCategory.Equals(input.TaxCategory))
                ) && base.Equals(input) && 
                (
                    this.VendorDetails == input.VendorDetails ||
                    this.VendorDetails != null &&
                    this.VendorDetails.SequenceEqual(input.VendorDetails)
                ) && base.Equals(input) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && base.Equals(input) && 
                (
                    this.VolumeUOM == input.VolumeUOM ||
                    (this.VolumeUOM != null &&
                    this.VolumeUOM.Equals(input.VolumeUOM))
                ) && base.Equals(input) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && base.Equals(input) && 
                (
                    this.WeightUOM == input.WeightUOM ||
                    (this.WeightUOM != null &&
                    this.WeightUOM.Equals(input.WeightUOM))
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
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.BaseUnit != null)
                    hashCode = hashCode * 59 + this.BaseUnit.GetHashCode();
                if (this.CrossReferences != null)
                    hashCode = hashCode * 59 + this.CrossReferences.GetHashCode();
                if (this.CurrentCost != null)
                    hashCode = hashCode * 59 + this.CurrentCost.GetHashCode();
                if (this.DefaultPrice != null)
                    hashCode = hashCode * 59 + this.DefaultPrice.GetHashCode();
                if (this.DeferralAccount != null)
                    hashCode = hashCode * 59 + this.DeferralAccount.GetHashCode();
                if (this.DeferralSubaccount != null)
                    hashCode = hashCode * 59 + this.DeferralSubaccount.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.ExpenseAccount != null)
                    hashCode = hashCode * 59 + this.ExpenseAccount.GetHashCode();
                if (this.ExpenseAccrualAccount != null)
                    hashCode = hashCode * 59 + this.ExpenseAccrualAccount.GetHashCode();
                if (this.ExpenseAccrualSubaccount != null)
                    hashCode = hashCode * 59 + this.ExpenseAccrualSubaccount.GetHashCode();
                if (this.ExpenseSubaccount != null)
                    hashCode = hashCode * 59 + this.ExpenseSubaccount.GetHashCode();
                if (this.InventoryID != null)
                    hashCode = hashCode * 59 + this.InventoryID.GetHashCode();
                if (this.IsKit != null)
                    hashCode = hashCode * 59 + this.IsKit.GetHashCode();
                if (this.ItemClass != null)
                    hashCode = hashCode * 59 + this.ItemClass.GetHashCode();
                if (this.ItemStatus != null)
                    hashCode = hashCode * 59 + this.ItemStatus.GetHashCode();
                if (this.ItemType != null)
                    hashCode = hashCode * 59 + this.ItemType.GetHashCode();
                if (this.LastCost != null)
                    hashCode = hashCode * 59 + this.LastCost.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.PendingCost != null)
                    hashCode = hashCode * 59 + this.PendingCost.GetHashCode();
                if (this.PendingCostDate != null)
                    hashCode = hashCode * 59 + this.PendingCostDate.GetHashCode();
                if (this.POAccrualAccount != null)
                    hashCode = hashCode * 59 + this.POAccrualAccount.GetHashCode();
                if (this.POAccrualSubaccount != null)
                    hashCode = hashCode * 59 + this.POAccrualSubaccount.GetHashCode();
                if (this.PostingClass != null)
                    hashCode = hashCode * 59 + this.PostingClass.GetHashCode();
                if (this.PriceClass != null)
                    hashCode = hashCode * 59 + this.PriceClass.GetHashCode();
                if (this.PurchasePriceVarianceAccount != null)
                    hashCode = hashCode * 59 + this.PurchasePriceVarianceAccount.GetHashCode();
                if (this.PurchasePriceVarianceSubaccount != null)
                    hashCode = hashCode * 59 + this.PurchasePriceVarianceSubaccount.GetHashCode();
                if (this.PurchaseUnit != null)
                    hashCode = hashCode * 59 + this.PurchaseUnit.GetHashCode();
                if (this.ReasonCodeSubaccount != null)
                    hashCode = hashCode * 59 + this.ReasonCodeSubaccount.GetHashCode();
                if (this.RequireReceipt != null)
                    hashCode = hashCode * 59 + this.RequireReceipt.GetHashCode();
                if (this.RequireShipment != null)
                    hashCode = hashCode * 59 + this.RequireShipment.GetHashCode();
                if (this.SalesAccount != null)
                    hashCode = hashCode * 59 + this.SalesAccount.GetHashCode();
                if (this.SalesCategories != null)
                    hashCode = hashCode * 59 + this.SalesCategories.GetHashCode();
                if (this.SalesSubaccount != null)
                    hashCode = hashCode * 59 + this.SalesSubaccount.GetHashCode();
                if (this.SalesUnit != null)
                    hashCode = hashCode * 59 + this.SalesUnit.GetHashCode();
                if (this.TaxCategory != null)
                    hashCode = hashCode * 59 + this.TaxCategory.GetHashCode();
                if (this.VendorDetails != null)
                    hashCode = hashCode * 59 + this.VendorDetails.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.VolumeUOM != null)
                    hashCode = hashCode * 59 + this.VolumeUOM.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.WeightUOM != null)
                    hashCode = hashCode * 59 + this.WeightUOM.GetHashCode();
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
