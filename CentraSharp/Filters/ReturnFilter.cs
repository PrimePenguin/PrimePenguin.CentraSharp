using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class ReturnFilter : Parameterizable
    {
        /// <summary>
        /// Limit the number of returns returned.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of page of results to return.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Only show a return with given ID.
        /// </summary>
        [JsonProperty("return")]
        public int? Return { get; set; }

        /// <summary>
        /// Only show a return with given shipment number.
        /// </summary>
        [JsonProperty("shipment")]
        public string Shipment { get; set; }

        /// <summary>
        /// Only fetch returns for a specific order
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Only fetch returns for a specific selection
        /// </summary>
        [JsonProperty("selection")]
        public int? Selection { get; set; }

        /// <summary>
        /// Only fetch returns for a specific customer
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