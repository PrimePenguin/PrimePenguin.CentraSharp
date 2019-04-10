using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraShipmentResponse
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
        public IList<object> Invoice { get; set; }
    }
}