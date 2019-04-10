using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraCustomerList
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
        public List<CentraCustomer> Customers { get; set; }
    }
}