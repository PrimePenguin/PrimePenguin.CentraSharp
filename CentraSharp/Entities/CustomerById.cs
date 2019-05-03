using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CustomerById
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Customers
        /// </summary>
        [JsonProperty("customer")]
        public Customer Customers { get; set; }
    }
}