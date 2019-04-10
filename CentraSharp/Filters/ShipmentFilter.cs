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
        public int Order { get; set; }

        /// <summary>
        /// filter by products
        /// </summary>
        [JsonProperty("products")]
        public Dictionary<int, int> Products { get; set; }

        /// <summary>
        /// filter by shipped
        /// </summary>
        [JsonProperty("shipped")]
        public bool Shipped { get; set; }

        /// <summary>
        /// filter by tracking
        /// </summary>
        [JsonProperty("tracking")]
        public string Tracking { get; set; }

        /// <summary>
        /// filter by gtg
        /// </summary>
        [JsonProperty("gtg")]
        public bool Gtg { get; set; }
    }
}