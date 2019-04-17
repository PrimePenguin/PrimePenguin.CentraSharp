using System;
using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class StockFilter : Parameterizable
    {
        /// <summary>
        /// Filter stock by sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; } = null;

        /// <summary>
        /// filter stock by ean
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; } = null;

        /// <summary>
        /// filter stock by limit
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; } = null;

        /// <summary>
        /// Created
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; } = null;

        /// <summary>
        /// Modified
        /// </summary>
        [JsonProperty("modified")]
        public string Modified { get; set; } = null;
    }
}