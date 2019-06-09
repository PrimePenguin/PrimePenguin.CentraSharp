using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Services.Return
{
    public class CentraReturnOptions
    {
        /// <summary>
        /// The shipmentId from Get shipments or Create shipment.
        /// </summary>
        [JsonProperty("shipment")]
        public string Shipment { get; set; }

        /// <summary>
        /// Insert returned items into stock. If not provided Default stock action on return setting on the store will be used.
        /// </summary>
        [JsonProperty("returnStock")]
        public bool ReturnStock { get; set; }

        /// <summary>
        /// Shipping cost.
        /// </summary>
        [JsonProperty("shippingCost")]
        public double? ShippingCost { get; set; }

        /// <summary>
        /// Additional comment for return, for reference.
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Key is lineID from the Get shipments and value is the quantity.
        /// </summary>
        [JsonProperty("products")]
        public Dictionary<string, int> Products { get; set; }

        /// <summary>
        /// Refund object. Example: {"refund":{"refundPayment": true}} will make refund from return.
        /// </summary>
        [JsonProperty("refund")]
        public Dictionary<string, bool> Refund { get; set; }
    }
}