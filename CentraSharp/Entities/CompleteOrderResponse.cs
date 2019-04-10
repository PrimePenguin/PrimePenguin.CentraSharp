using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CompleteOrderResponse
    {
        /// <summary>
        /// Orders
        /// </summary>
        [JsonProperty("orders")]
        public IList<string> Orders { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}