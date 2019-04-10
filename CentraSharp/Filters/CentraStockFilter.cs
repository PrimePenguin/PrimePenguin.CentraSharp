using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class CentraStockFilter : Parameterizable
    {
        /// <summary>
        /// Filter stock by sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// filter stock by ean
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }
        
        /// <summary>
        /// filter stock by limit
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}