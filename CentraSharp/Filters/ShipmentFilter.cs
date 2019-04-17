using System.Collections.Generic;
using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class ShipmentFilter : Parameterizable
    {
        /// <summary>
        /// filter by order
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; } = null;

        /// <summary>
        /// filter by products
        /// </summary>
        [JsonProperty("products")]
        public List<KeyValuePair<string, int>> Products { get; set; } = null;

        /// <summary>
        /// filter by shipped
        /// </summary>
        [JsonProperty("shipped")]
        public bool? Shipped { get; set; } = null;

        /// <summary>
        /// filter by tracking
        /// </summary>
        [JsonProperty("tracking")]
        public string Tracking { get; set; } = null;

        /// <summary>
        /// filter by gtg
        /// </summary>
        [JsonProperty("gtg")]
        public bool? Gtg { get; set; } = null;
    }
}