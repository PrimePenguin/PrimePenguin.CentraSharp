using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.Return
{
    public class CentraReturnOptions
    {
        /// <summary>
        /// Shipment
        /// </summary>
        [JsonProperty("shipment")]
        public string Shipment { get; set; }

        /// <summary>
        /// ReturnStock
        /// </summary>
        [JsonProperty("returnStock")]
        public int ReturnStock { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Products
        /// </summary>
        [JsonProperty("products")]
        public List<KeyValuePair<string, int>> Products { get; set; } = null;
    }
}