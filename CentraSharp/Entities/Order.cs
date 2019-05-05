using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Order
    {
        /// <summary>
        /// OrderId
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// OrderStatus
        /// </summary>
        [JsonProperty("orderStatus")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// SelectionId
        /// </summary>
        [JsonProperty("selectionId")]
        public string SelectionId { get; set; }

        /// <summary>
        /// OrderDate
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
        public int GrandTotalValue { get; set; }

        /// <summary>
        /// GrandTotalTaxValue
        /// </summary>
        [JsonProperty("grandTotalTaxValue")]
        public double GrandTotalTaxValue { get; set; }

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
        /// Products
        /// </summary>
        [JsonProperty("products")]
        public IList<Product> Products { get; set; }
    }
}