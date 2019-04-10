using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraOrdersList
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Orders
        /// </summary>
        [JsonProperty("orders")]
        public IList<CentraOrder> Orders { get; set; }
    }
}