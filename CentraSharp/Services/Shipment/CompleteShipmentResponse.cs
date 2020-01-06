using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    public class CompleteShipmentResponse
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// Order ID that was completed
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// Shipment ID that was completed.
        /// </summary>
        [JsonProperty("shipment")]
        public string Shipment { get; set; }
    }
}