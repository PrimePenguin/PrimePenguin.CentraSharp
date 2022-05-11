using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Order
    {
        /// <summary>
        /// Id of the order.
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Status of the order.
        /// </summary>
        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// Selection ID of the order.
        /// </summary>
        [JsonProperty("selectionId")]
        public string SelectionId { get; set; }

        /// <summary>
        /// Date when order was created.
        /// </summary>
        [JsonProperty("orderDate")]
        public string OrderDate { get; set; }

        /// <summary>
        /// CancelDate
        /// </summary>
        [JsonProperty("cancelDate")]
        public string CancelDate { get; set; }

        /// <summary>
        /// PreferredDeliveryDate
        /// </summary>
        [JsonProperty("preferredDeliveryDate")]
        public string PreferredDeliveryDate { get; set; }

        /// <summary>
        /// EstimatedDeliveryDate
        /// </summary>
        [JsonProperty("estimatedDeliveryDate")]
        public string EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// OrderStore
        /// </summary>
        [JsonProperty("orderStore")]
        public string OrderStore { get; set; }

        /// <summary>
        /// OrderCurrency
        /// </summary>
        [JsonProperty("orderCurrency")]
        public string OrderCurrency { get; set; }

        /// <summary>
        /// CustomerId
        /// </summary>
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// AccountId
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// billingVat
        /// </summary>
        [JsonProperty("billingVAT")]
        public string BillingVat { get; set; }

        /// <summary>
        /// PoNumber
        /// </summary>
        [JsonProperty("poNumber")]
        public string PoNumber { get; set; }

        /// <summary>
        /// ShippingList
        /// </summary>
        [JsonProperty("shippingList")]
        public string ShippingList { get; set; }

        /// <summary>
        /// Suspect
        /// </summary>
        [JsonProperty("suspect")]
        public int Suspect { get; set; }

        /// <summary>
        /// InternalOrder
        /// </summary>
        [JsonProperty("internalOrder")]
        public int InternalOrder { get; set; }

        /// <summary>
        /// Hold
        /// </summary>
        [JsonProperty("hold")]
        public int Hold { get; set; }

        /// <summary>
        /// Waiting For Payment
        /// </summary>
        [JsonProperty("waitingForPayment")]
        public int WaitingForPayment { get; set; }

        /// <summary>
        /// ShippingValue
        /// </summary>
        [JsonProperty("shippingValue")]
        public int ShippingValue { get; set; }

        /// <summary>
        /// VoucherValue
        /// </summary>
        [JsonProperty("voucherValue")]
        public int VoucherValue { get; set; }

        /// <summary>
        /// GrandTotalValue
        /// </summary>
        [JsonProperty("grandTotalValue")]
        public double GrandTotalValue { get; set; }

        /// <summary>
        /// GrandTotalTaxValue
        /// </summary>
        [JsonProperty("grandTotalTaxValue")]
        public double GrandTotalTaxValue { get; set; }

        /// <summary>
        /// Tax Added
        /// </summary>
        [JsonProperty("taxAdded")]
        public int TaxAdded { get; set; }

        /// <summary>
        /// Tax Deducted
        /// </summary>
        [JsonProperty("taxDeducted")]
        public int TaxDeducted { get; set; }

        /// <summary>
        /// DeliveryName
        /// </summary>
        [JsonProperty("deliveryName")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// DeliveryCompany
        /// </summary>
        [JsonProperty("deliveryCompany")]
        public string DeliveryCompany { get; set; }

        /// <summary>
        /// DeliveryAddress
        /// </summary>
        [JsonProperty("deliveryAddress")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// DeliveryCoaddress
        /// </summary>
        [JsonProperty("deliveryCoaddress")]
        public string DeliveryCoaddress { get; set; }

        /// <summary>
        /// DeliveryCity
        /// </summary>
        [JsonProperty("deliveryCity")]
        public string DeliveryCity { get; set; }

        /// <summary>
        /// DeliveryState
        /// </summary>
        [JsonProperty("deliveryState")]
        public string DeliveryState { get; set; }

        /// <summary>
        /// DeliveryZipcode
        /// </summary>
        [JsonProperty("deliveryZipcode")]
        public string DeliveryZipcode { get; set; }

        /// <summary>
        /// DeliveryCountry
        /// </summary>
        [JsonProperty("deliveryCountry")]
        public string DeliveryCountry { get; set; }

        /// <summary>
        /// DeliveryEmail
        /// </summary>
        [JsonProperty("deliveryEmail")]
        public string DeliveryEmail { get; set; }

        /// <summary>
        /// DeliveryTele
        /// </summary>
        [JsonProperty("deliveryTele")]
        public string DeliveryTele { get; set; }

        /// <summary>
        /// DeliveryCell
        /// </summary>
        [JsonProperty("deliveryCell")]
        public string DeliveryCell { get; set; }

        /// <summary>
        /// BillingName
        /// </summary>
        [JsonProperty("billingName")]
        public string BillingName { get; set; }

        /// <summary>
        /// BillingCompany
        /// </summary>
        [JsonProperty("billingCompany")]
        public string BillingCompany { get; set; }

        /// <summary>
        /// BillingAddress
        /// </summary>
        [JsonProperty("billingAddress")]
        public string BillingAddress { get; set; }

        /// <summary>
        /// BillingCoaddress
        /// </summary>
        [JsonProperty("billingCoaddress")]
        public string BillingCoaddress { get; set; }

        /// <summary>
        /// BillingCity
        /// </summary>
        [JsonProperty("billingCity")]
        public string BillingCity { get; set; }

        /// <summary>
        /// BillingState
        /// </summary>
        [JsonProperty("billingState")]
        public string BillingState { get; set; }

        /// <summary>
        /// BillingZipcode
        /// </summary>
        [JsonProperty("billingZipcode")]
        public string BillingZipcode { get; set; }

        /// <summary>
        /// BillingCountry
        /// </summary>
        [JsonProperty("billingCountry")]
        public string BillingCountry { get; set; }

        /// <summary>
        /// BillingEmail
        /// </summary>
        [JsonProperty("billingEmail")]
        public string BillingEmail { get; set; }

        /// <summary>
        /// BillingTele
        /// </summary>
        [JsonProperty("billingTele")]
        public string BillingTele { get; set; }

        /// <summary>
        /// InternalComment
        /// </summary>
        [JsonProperty("internalComment")]
        public string InternalComment { get; set; }

        /// <summary>
        /// MarketId
        /// </summary>
        [JsonProperty("marketId")]
        public int MarketId { get; set; }

        /// <summary>
        /// PriceListId
        /// </summary>
        [JsonProperty("pricelistId")]
        public int PriceListId { get; set; }

        /// <summary>
        /// IpAddress
        /// </summary>
        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// OtherComment
        /// </summary>
        [JsonProperty("otherComment")]
        public string OtherComment { get; set; }

        /// <summary>
        /// PaymentType
        /// </summary>
        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        /// <summary>
        /// Payment Plugin
        /// </summary>
        [JsonProperty("paymentPlugin")]
        public string PaymentPlugin { get; set; }

        /// <summary>
        /// paymentDescription
        /// </summary>
        [JsonProperty("paymentDescription")]
        public string PaymentDescription { get; set; }

        /// <summary>
        /// Payment Reference
        /// </summary>
        [JsonProperty("paymentReference")]
        public string PaymentReference { get; set; }

        /// <summary>
        /// Payment Method
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Tax Break Downs
        /// </summary>
        [JsonProperty("taxBreakdown")]
        public List<TaxBreakDown> TaxBreakDowns { get; set; }


        /// <summary>
        /// DefaultCarrier
        /// </summary>
        [JsonProperty("defaultCarrier")]
        public string DefaultCarrier { get; set; }

        /// <summary>
        /// TotalItemsPriceTax
        /// </summary>
        [JsonProperty("totalItemsPriceTax")]
        public string TotalItemsPriceTax { get; set; }

        /// <summary>
        /// TotalItemsPrice
        /// </summary>
        [JsonProperty("totalItemsPrice")]
        public string TotalItemsPrice { get; set; }

        /// <summary>
        /// TotalItemsWithoutTax
        /// </summary>
        [JsonProperty("totalItemsWithoutTax")]
        public string TotalItemsWithoutTax { get; set; }

        /// <summary>
        /// TotalItemsDiscount
        /// </summary>
        [JsonProperty("totalItemsDiscount")]
        public decimal? TotalItemsDiscount { get; set; }

        /// <summary>
        /// Products inside the order.
        /// </summary>
        [JsonProperty("products")]
        public IList<ProductOrder> Products { get; set; }

        /// <summary>
        /// Order Shipments
        /// </summary>
        [JsonProperty("shipments")]
        public List<OrderShipment> Shipments { get; set; }

        /// <summary>
        /// Products inside the order.
        /// </summary>
        [JsonProperty("discounts")]
        public Discounts Discounts { get; set; }
    }

    public class Discounts
    {
        /// <summary>
        /// AnyDiscount
        /// </summary>
        [JsonProperty("anyDiscount")]
        public bool AnyDiscount { get; set; }

        /// <summary>
        /// Discount
        /// </summary>
        [JsonProperty("discount")]
        public string Discount { get; set; }

        /// <summary>
        /// DiscountAsNumber
        /// </summary>
        [JsonProperty("discountAsNumber")]
        public int DiscountAsNumber { get; set; }

        /// <summary>
        /// Vouchers
        /// </summary>
        [JsonProperty("vouchers")]
        public List<Voucher> Vouchers { get; set; }
    }

    public class Voucher
    {
        /// <summary>
        /// VoucherCode
        /// </summary>
        [JsonProperty("voucher")]
        public string VoucherCode { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// PriceOff
        /// </summary>
        [JsonProperty("priceOff")]
        public string PriceOff { get; set; }

        /// <summary>
        /// priceOffAsANumber
        /// </summary>
        [JsonProperty("priceOffAsANumber")]
        public double? PriceOffAsANumber { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// IsCredit
        /// </summary>
        [JsonProperty("isCredit")]
        public bool IsCredit { get; set; }

        /// <summary>
        /// OriginalPriceOff
        /// </summary>
        [JsonProperty("originalPriceOff")]
        public string OriginalPriceOff { get; set; }

        /// <summary>
        /// OriginalPriceOffAsNumber
        /// </summary>
        [JsonProperty("originalPriceOffAsNumber")]
        public decimal OriginalPriceOffAsNumber { get; set; }
    }
    public class TaxBreakDown
    {
        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// TaxPercent
        /// </summary>
        [JsonProperty("taxPercent")]
        public int TaxPercent { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty("value")]
        public decimal Value { get; set; }
    }

    public class AutomaticDiscount
    {
        /// <summary>
        /// AutomaticItemDiscount
        /// </summary>
        [JsonProperty("automaticDiscount")]
        public string AutomaticItemDiscount { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// PriceOff
        /// </summary>
        [JsonProperty("priceOff")]
        public string PriceOff { get; set; }

        /// <summary>
        /// PriceOffAsNumber
        /// </summary>
        [JsonProperty("priceOffAsNumber")]
        public int PriceOffAsNumber { get; set; }

        /// <summary>
        /// IsCredit
        /// </summary>
        [JsonProperty("isCredit")]
        public bool IsCredit { get; set; }

        /// <summary>
        /// OriginalPriceOff
        /// </summary>
        [JsonProperty("originalPriceOff")]
        public string OriginalPriceOff { get; set; }

        /// <summary>
        /// OriginalPriceOffAsNumber
        /// </summary>
        [JsonProperty("originalPriceOffAsNumber")]
        public decimal OriginalPriceOffAsNumber { get; set; }

    }
}