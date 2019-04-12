using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class OrdersList
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
        public IList<Order> Orders { get; set; }
    }
}