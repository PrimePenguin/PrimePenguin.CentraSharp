using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CompleteOrderResponse
    {
        /// <summary>
        /// Orders
        /// </summary>
        [JsonProperty("order")]
        public IList<string> Order { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}