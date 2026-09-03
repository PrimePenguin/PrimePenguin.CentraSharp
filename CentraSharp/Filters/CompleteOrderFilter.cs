using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class CompleteOrderFilter : Parameterizable
    {
        /// <summary>
        /// status
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Authorization / capture
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Amount of the order
        /// </summary>
        [JsonProperty("amount")]
        public double Amount { get; set; }

        /// <summary>
        /// OrderId
        /// </summary>
        [JsonProperty("orderId")]
        public int OrderId { get; set; }
    }
}
