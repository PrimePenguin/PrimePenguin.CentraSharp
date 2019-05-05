using Newtonsoft.Json;
using System.Collections.Generic;

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
        public Dictionary<string, int> Products { get; set; } = null;
    }
}