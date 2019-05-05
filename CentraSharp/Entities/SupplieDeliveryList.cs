using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class SupplieDeliveryList
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// SupplierOrders
        /// </summary>
        [JsonProperty("deliveries ")]
        public List<SupplierOrderDelivery> SupplierOrderDeliveries { get; set; }
    }
}