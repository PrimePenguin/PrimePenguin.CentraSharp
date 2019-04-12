using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ProductStockList
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// <see cref="CentraProductStocks" />
        /// </summary>
        [JsonProperty("centraProductStocks")]
        public List<ProductStock> CentraProductStocks { get; set; }

        /// <summary>
        /// Previous
        /// </summary>
        [JsonProperty("previous")]
        public string Previous { get; set; }

        /// <summary>
        /// Next
        /// </summary>
        [JsonProperty("next")]
        public string Next { get; set; }
    }
}