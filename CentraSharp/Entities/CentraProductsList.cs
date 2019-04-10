using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraProductsList
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
        public IList<CentraProduct> Products { get; set; }
    }
}