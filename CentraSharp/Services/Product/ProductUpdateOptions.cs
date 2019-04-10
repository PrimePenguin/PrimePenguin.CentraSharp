using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.Product
{
    public class ProductUpdateOptions
    {
        /// <summary>
        /// Product
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}