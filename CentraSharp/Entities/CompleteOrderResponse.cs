using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CompleteOrderResponse
    {
        /// <summary>
        /// Orders
        /// </summary>
        [JsonProperty("order")]
        public IList<string> Orders { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}