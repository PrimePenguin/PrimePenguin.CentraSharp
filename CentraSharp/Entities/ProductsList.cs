using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ProductsList
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Products
        /// </summary>
        [JsonProperty("products")]
        public IList<Product> Products { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}