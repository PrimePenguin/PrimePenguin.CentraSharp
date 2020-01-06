using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class OrderShipment
    {
        /// <summary>
        /// ShipmentId
        /// </summary>
        [JsonProperty("shipmentId")]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Shipped Date
        /// </summary>
        [JsonProperty("shippedDate")]
        public string ShippedDate { get; set; }

        /// <summary>
        /// Carrier
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Service
        /// </summary>
        [JsonProperty("service")]
        public string Service { get; set; }

        /// <summary>
        /// Tracking Id
        /// </summary>
        [JsonProperty("trackingId")]
        public string TrackingId { get; set; }

        /// <summary>
        /// Tracking Url
        /// </summary>
        [JsonProperty("trackingUrl")]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// ReturnSlipTracking
        /// </summary>
        [JsonProperty("returnSlipTracking")]
        public string ReturnSlipTracking { get; set; }
    }
}