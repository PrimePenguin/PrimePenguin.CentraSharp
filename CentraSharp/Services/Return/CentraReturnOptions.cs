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
        public bool? ReturnStock { get; set; }

        /// <summary>
        /// Default false. Set to true to use Handling cost from Shipment. You cannot provide handlingCost at the same time this option is used.
        /// </summary>
        [JsonProperty("handlingCostFromShipment")]
        public bool? HandlingCostFromShipment { get; set; }

        /// <summary>
        /// Default false. Set to true to use Shipping cost from Shipment. You cannot provide shippingCost at the same time this option is used.
        /// </summary>
        [JsonProperty("shippingCostFromShipment")]
        public bool? ShippingCostFromShipment { get; set; }

        /// <summary>
        /// Shipping cost.
        /// </summary>
        [JsonProperty("shippingCost")]
        public double? ShippingCost { get; set; }

        /// <summary>
        /// Return cost. If the return itself should have a cost to it. Providing a value here will deduct the amount of money to refund.
        /// </summary>
        [JsonProperty("returnCost")]
        public double? ReturnCost { get; set; }

        /// <summary>
        /// Handling cost.
        /// </summary>
        [JsonProperty("handlingCost")]
        public double? HandlingCost { get; set; }

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