using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class SupplierOrderResponse
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
        public SupplierOrder Order { get; set; }

        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}