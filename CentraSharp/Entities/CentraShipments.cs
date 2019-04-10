using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraShipment
    {
        /// <summary>
        /// OrderId
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

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
        /// OderStore
        /// </summary>
        [JsonProperty("orderStore")]
        public string OderStore { get; set; }

        /// <summary>
        /// OrderCurrency
        /// </summary>
        [JsonProperty("orderCurrency")]
        public string OrderCurrency { get; set; }

        /// <summary>
        /// ShipmentId
        /// </summary>
        [JsonProperty("shipmentId")]
        public string ShipmentId { get; set; }

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
        /// DeliveryEmail
        /// </summary>
        [JsonProperty("deliveryEmail")]
        public string DeliveryEmail { get; set; }

        /// <summary>
        /// DeliveryCell
        /// </summary>
        [JsonProperty("deliveryCell")]
        public string DeliveryCell { get; set; }

        /// <summary>
        /// DeliveryTele
        /// </summary>
        [JsonProperty("deliveryTele")]
        public string DeliveryTele { get; set; }

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
        /// DeliveryZipcode
        /// </summary>
        [JsonProperty("deliveryZipcode")]
        public string DeliveryZipcode { get; set; }

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
        /// DeliveryCountry
        /// </summary>
        [JsonProperty("deliveryCountry")]
        public string DeliveryCountry { get; set; }

        /// <summary>
        /// BillingVAT
        /// </summary>
        [JsonProperty("billingVAT")]
        public string BillingVAT { get; set; }

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
        /// ShippingTerms
        /// </summary>
        [JsonProperty("shippingTerms")]
        public CentraShippingTerms ShippingTerms { get; set; }

        /// <summary>
        /// PaymentTerms
        /// </summary>
        [JsonProperty("paymentTerms")]
        public CentraPaymentTerms PaymentTerms { get; set; }

        /// <summary>
        /// Proforma
        /// </summary>
        [JsonProperty("proforma")]
        public string Proforma { get; set; }

        /// <summary>
        /// DeliveryNote
        /// </summary>
        [JsonProperty("deliveryNote")]
        public string DeliveryNote { get; set; }

        /// <summary>
        /// DefaultCarrier
        /// </summary>
        [JsonProperty("defaultCarrier")]
        public string DefaultCarrier { get; set; }

        /// <summary>
        /// DeliveryService
        /// </summary>
        [JsonProperty("deliveryService")]
        public string DeliveryService { get; set; }

        /// <summary>
        /// Invoices
        /// </summary>
        [JsonProperty("invoices")]
        public List<string> Invoices { get; set; }

        /// <summary>
        /// Suspect
        /// </summary>
        [JsonProperty("suspect")]
        public int Suspect { get; set; }

        /// <summary>
        /// Hold
        /// </summary>
        [JsonProperty("hold")]
        public int Hold { get; set; }

        /// <summary>
        /// Paid
        /// </summary>
        [JsonProperty("paid")]
        public int Paid { get; set; }

        /// <summary>
        /// ShouldCapture
        /// </summary>
        [JsonProperty("shouldCapture")]
        public int ShouldCapture { get; set; }

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
        /// InternalComment
        /// </summary>
        [JsonProperty("internalComment")]
        public string InternalComment { get; set; }

        /// <summary>
        /// OtherComment
        /// </summary>
        [JsonProperty("otherComment")]
        public string OtherComment { get; set; }

        /// <summary>
        /// Products
        /// </summary>
        [JsonProperty("products")]
        public List<CentraProduct> Products { get; set; }
    }
}