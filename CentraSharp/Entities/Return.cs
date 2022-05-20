using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Return
    {
        /// <summary>
        /// ID of the return
        /// </summary>
        [JsonProperty("returnId")]
        public int ReturnId { get; set; }

        /// <summary>
        /// Completed
        /// </summary>
        [JsonProperty("completed")]
        
        public bool Completed { get; set; }
       
        /// <summary>
        /// Number of the shipment
        /// </summary>
        [JsonProperty("shipment")]
        public string Shipment { get; set; }

        /// <summary>
        /// ID of the shipment
        /// </summary>
        [JsonProperty("shipmentId")]
        public int ShipmentId { get; set; }

        /// <summary>
        /// ID of the order
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// Selection ID of the order
        /// </summary>
        [JsonProperty("selectionId")]
        public string SelectionId { get; set; }

        /// <summary>
        /// Date when return was created
        /// </summary>
        [JsonProperty("date")]
        public string Date { get; set; }

        /// <summary>
        /// Market Id
        /// </summary>
        [JsonProperty("marketId")]

        public int MarketId { get; set; }
        /// <summary>
        /// Price List Id
        /// </summary>
        [JsonProperty("pricelistId")]
        public long PricelistId { get; set; }

        /// <summary>
        /// Cost of the return
        /// </summary>
        [JsonProperty("returnCost")]
        public double ReturnCost { get; set; }

        /// <summary>
        /// Cost of shipping returned
        /// </summary>
        [JsonProperty("shippingCost")]
        public double ShippingCost { get; set; }

        /// <summary>
        /// Handling cost of the return
        /// </summary>
        [JsonProperty("handlingCost")]
        public double HandlingCost { get; set; }

        /// <summary>
        /// Voucher value included in the return
        /// </summary>
        [JsonProperty("voucherValue")]
        public double VoucherValue { get; set; }

        /// <summary>
        /// Tax value of the return, zero if deducted
        /// </summary>
        [JsonProperty("taxValue")]
        public double TaxValue { get; set; }

        /// <summary>
        /// Tax deduction in the return
        /// </summary>
        [JsonProperty("taxDeduction")]
        public int TaxDeduction { get; set; }

        /// <summary>
        /// Currency code in which order and also return was made
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Code of the currency used as base in this store
        /// </summary>
        [JsonProperty("baseCurrency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// Exchange rate between currency and baseCurrency
        /// </summary>
        [JsonProperty("baseCurrencyRate")]
        public double BaseCurrencyRate { get; set; }

        /// <summary>
        /// Whether the return was marked as returned back to stock
        /// </summary>
        [JsonProperty("returnToStock")]
        public bool ReturnToStock { get; set; }

        /// <summary>
        /// Optional description added to the return
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Informs where this return originated, i.e. “Order API”
        /// </summary>
        [JsonProperty("createdFrom")]
        public string CreatedFrom { get; set; }

        /// <summary>
        /// Products inside the return
        /// </summary>
        [JsonProperty("products")]
        public List<ReturnProduct> Products { get; set; }
    }
}