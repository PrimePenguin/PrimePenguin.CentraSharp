using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    public class GetShipmentFilter : Parameterizable
    {
        /// <summary>
        ///     Limit amount of orders returned.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        ///     TReturn a specific order.
        /// </summary>
        [JsonProperty("order")]
        public int order { get; set; }
    }
}