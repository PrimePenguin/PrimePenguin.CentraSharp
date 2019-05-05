using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class SupplierDelivery
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// SupplierOrderDelivery
        /// </summary>
        [JsonProperty("delivery")]
        public SupplierOrderDelivery SupplierOrderDelivery { get; set; }


        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}