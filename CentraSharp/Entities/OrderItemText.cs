using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class OrderItemText
    {
        /// <summary>
        /// Sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Product
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// variant
        /// </summary>
        [JsonProperty("variant")]
        public string Variant { get; set; }
    }
}