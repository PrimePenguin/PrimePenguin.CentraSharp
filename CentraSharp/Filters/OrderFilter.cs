using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;
using System;

namespace PrimePenguin.CentraSharp.Filters
{
    public class OrderFilter : Parameterizable
    {
        /// <summary>
        /// Limit amount of orders returned.
        /// </summary>
        [JsonProperty("limit")]
        public int Limits { get; set; }

        /// <summary>
        /// Offset how far in to start returning orders.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// TReturn a specific order.
        /// </summary>
        [JsonProperty("order")]
        public int order { get; set; }

        /// <summary>
        /// Return orders for specified customer id.
        /// </summary>
        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Return order newer than date (YYYY-MM-DD).
        /// </summary>
        [JsonProperty("newer_than")]
        public DateTime? NewerThan { get; set; }

        /// <summary>
        /// Return order newer than date (YYYY-MM-DD).
        /// </summary>
        [JsonProperty("older_than")]
        public DateTime? OlderThan { get; set; }
    }
}