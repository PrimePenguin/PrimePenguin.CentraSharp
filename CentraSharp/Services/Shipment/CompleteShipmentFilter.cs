using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    public class CompleteShipmentFilter : Parameterizable
    {
        /// <summary>
        /// Order ID to which the shipment belongs
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// Shipment ID for the shipment to complete.
        /// </summary>
        [JsonProperty("shipment")]
        public string Shipment { get; set; }

        /// <summary>
        /// Carrier used for shipping.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Service level used for shipping.
        /// </summary>
        [JsonProperty("service")]
        public string Service { get; set; }

        /// <summary>
        /// Number of packages in shipment.
        /// </summary>
        [JsonProperty("packages")]
        public int? Packages { get; set; }

        /// <summary>
        /// Tracking number for shipment.
        /// </summary>
        [JsonProperty("tracking")]
        public string Tracking { get; set; }

        /// <summary>
        /// Append some text to internal comment field.
        /// </summary>
        [JsonProperty("internalComment")]
        public string InternalComment { get; set; }

        /// <summary>
        /// Default: true. Try to capture the order. Ignored if the capture was already made earlier for the shipment.
        /// </summary>
        [JsonProperty("capture")]
        public int? Capture { get; set; }
    }
}