using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    public class GetShipmentFilter : Parameterizable
    {
        /// <summary>
        /// Limit amount of orders returned.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Offset how far in to start returning orders.
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// TReturn a specific order.
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Return orders for specified customer id.
        /// </summary>
        [JsonProperty("customer_id")]
        public int? CustomerId { get; set; }

        /// <summary>
        /// Return order newer than date YYYY-mm-dd HH:MM:SS
        /// </summary>
        [JsonProperty("newer_than")]
        public string NewerThan { get; set; }

        /// <summary>
        /// Return order newer than date YYYY-mm-dd HH:MM:SS
        /// </summary>
        [JsonProperty("older_than")]
        public string OlderThan { get; set; }
    }
}