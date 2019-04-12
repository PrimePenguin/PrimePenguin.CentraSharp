using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

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
