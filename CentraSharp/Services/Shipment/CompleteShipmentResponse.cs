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
        /// Order
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// Shipments
        /// </summary>
        [JsonProperty("shipment")]
        public Entities.Shipment Shipment { get; set; }
    }
}