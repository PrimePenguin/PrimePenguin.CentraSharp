using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class SupplierDeliveryList
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// SupplierOrders
        /// </summary>
        [JsonProperty("deliveries")]
        public List<SupplierOrderDelivery> SupplierOrderDeliveries { get; set; }


        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}