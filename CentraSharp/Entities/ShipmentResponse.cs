using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ShipmentResponse
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// Shipment
        /// </summary>
        [JsonProperty("shipment")]
        public string Shipment { get; set; }

        /// <summary>
        /// DeliveryNote
        /// </summary>
        [JsonProperty("deliveryNote")]
        public string DeliveryNote { get; set; }

        /// <summary>
        /// Proforma
        /// </summary>
        [JsonProperty("proforma")]
        public string Proforma { get; set; }

        /// <summary>
        /// Invoice
        /// </summary>
        [JsonProperty("invoice")]
        public List<string> Invoice { get; set; }

        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}