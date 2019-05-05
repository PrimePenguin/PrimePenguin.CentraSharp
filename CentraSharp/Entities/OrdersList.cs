using Newtonsoft.Json;
using System.Collections.Generic;

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
        public IList<ProductOrder> Orders { get; set; }

        /// <summary>
        /// Orders
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}