using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    public class CreateUpdateShipmentResponse
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Shipments
        /// </summary>
        [JsonProperty("shipment")]
        public Entities.Shipment Shipment { get; set; }

        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}
