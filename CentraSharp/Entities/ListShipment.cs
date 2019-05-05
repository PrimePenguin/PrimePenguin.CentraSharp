using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ListShipment
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Shipments
        /// </summary>
        [JsonProperty("shipments")]
        public List<Shipment> Shipments { get; set; }
    }
}