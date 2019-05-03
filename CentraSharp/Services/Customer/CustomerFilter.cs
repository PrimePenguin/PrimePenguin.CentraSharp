using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Customer
{
    public class CustomerFilter : Parameterizable
    {
        /// <summary>
        /// Limit amount of customers returned.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; } = null;

        /// <summary>
        /// Offset how far in to start returning customers.
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; } = null;

        /// <summary>
        /// Return a specific customer.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; } = null;

        /// <summary>
        /// Get all customers added after a certain date.
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; } = null;

        /// <summary>
        /// Get all customers modified after a certain date.
        /// </summary>
        [JsonProperty("modified")]
        public string Modified { get; set; } = null;
    }
}