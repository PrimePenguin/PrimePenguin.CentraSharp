using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CustomerList
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Customers
        /// </summary>
        [JsonProperty("customers")]
        public List<Customer> Customers { get; set; }
    }
}