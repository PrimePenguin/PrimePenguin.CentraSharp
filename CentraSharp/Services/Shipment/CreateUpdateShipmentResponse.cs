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
        /// Shipmentsf
        /// </summary>
        [JsonProperty("shipment")]
        public Entities.Shipment Shipment { get; set; }

        /// <summary>
        /// If status returns no, this value should send back a message why it failed.
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// Order ID that the shipment was created on.
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// URL to a PDF delivery note for the shipment.
        /// </summary>
        [JsonProperty("deliveryNote")]
        public string DeliveryNote { get; set; }

        /// <summary>
        /// URL to a PDF proforma for the shipment.
        /// </summary>
        [JsonProperty("proforma")]
        public string Proforma { get; set; }

        /// <summary>
        /// URL to a PDF invoice for the shipment. Will only be set if an invoice exists
        /// </summary>
        [JsonProperty("invoice")]
        public string Invoice { get; set; }
    }
}
