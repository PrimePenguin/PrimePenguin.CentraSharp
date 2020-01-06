using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Shipment
    {
        /// <summary>
        /// Id of the order.
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

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
        /// Id of the shipment.
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
        /// Shipping Terms object selected on this shipment.
        /// </summary>
        [JsonProperty("shippingTerms")]
        public ShippingTerms ShippingTerms { get; set; }

        /// <summary>
        /// Payment Terms object selected on this shipment.
        /// </summary>
        [JsonProperty("paymentTerms")]
        public PaymentTerms PaymentTerms { get; set; }

        /// <summary>
        /// URL to a PDF proforma for the shipment.
        /// </summary>
        [JsonProperty("proforma")]
        public string Proforma { get; set; }

        /// <summary>
        /// URL to a PDF delivery note for the shipment.
        /// </summary>
        [JsonProperty("deliveryNote")]
        public string DeliveryNote { get; set; }

        /// <summary>
        /// Name of the carrier for this shipment.
        /// </summary>
        [JsonProperty("defaultCarrier")]
        public string DefaultCarrier { get; set; }

        /// <summary>
        /// Name of the delivery service for this shipment
        /// </summary>
        [JsonProperty("deliveryService")]
        public string DeliveryService { get; set; }

        /// <summary>
        /// URLs to PDF invoices for the shipment. Will only be set if any invoices exists.
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
        /// If the shipment needs to be captured before being shipped
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
        /// billingName
        /// </summary>
        [JsonProperty("billingName")]
        public string BillingName { get; set; }

        /// <summary>
        /// billingCompany
        /// </summary>
        [JsonProperty("billingCompany")]
        public string BillingCompany { get; set; }

        /// <summary>
        /// billingAddress
        /// </summary>
        [JsonProperty("billingAddress")]
        public string BillingAddress { get; set; }

        /// <summary>
        /// BillingCoAddress
        /// </summary>
        [JsonProperty("billingCoaddress")]
        public string BillingCoAddress { get; set; }

        /// <summary>
        /// billingCity
        /// </summary>
        [JsonProperty("billingCity")]
        public string BillingCity { get; set; }

        /// <summary>
        /// billingState
        /// </summary>
        [JsonProperty("billingState")]
        public string BillingState { get; set; }

        /// <summary>
        /// billingZipcode
        /// </summary>
        [JsonProperty("billingZipcode")]
        public string BillingZipcode { get; set; }

        /// <summary>
        /// billingCountry
        /// </summary>
        [JsonProperty("billingCountry")]
        public string BillingCountry { get; set; }

        /// <summary>
        /// billingEmail
        /// </summary>
        [JsonProperty("billingEmail")]
        public string BillingEmail { get; set; }

        /// <summary>
        /// billingTele
        /// </summary>
        [JsonProperty("billingTele")]
        public string BillingTele { get; set; }

        /// <summary>
        /// pickupPointOpt
        /// </summary>
        [JsonProperty("pickupPointOpt")]
        public bool PickupPointOpt { get; set; }

        /// <summary>
        /// gtg
        /// </summary>
        [JsonProperty("gtg")]
        public int gtg { get; set; }

        /// <summary>
        /// ShipmentDate
        /// </summary>
        [JsonProperty("shipmentDate")]
        public string ShipmentDate { get; set; }

        /// <summary>
        /// TrackingNumber
        /// </summary>
        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// TrackingUrl
        /// </summary>
        [JsonProperty("trackingUrl")]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// ReturnSlipTracking
        /// </summary>
        [JsonProperty("returnSlipTracking")]
        public string ReturnSlipTracking { get; set; }

        /// <summary>
        /// Products inside the shipment.
        /// </summary>
        [JsonProperty("products")]
        public List<ShipmentProduct> Products { get; set; }
    }
}