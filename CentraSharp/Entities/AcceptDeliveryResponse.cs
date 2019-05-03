using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class AcceptDeliveryResponse
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
        /// SupplierOrders
        /// </summary>
        [JsonProperty("additionalDelivery")]
        public List<SupplierOrder> SupplierOrders { get; set; }
    }
}
