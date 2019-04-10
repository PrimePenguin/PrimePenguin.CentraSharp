using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.Order
{
    public class OrderUpdateOptions
    {
        /// <summary>
        ///     AOrder ID to update.
        /// </summary>
        [JsonProperty("order")]
        public int order { get; set; }

        /// <summary>
        ///     Append some text to internal comment field.
        /// </summary>
        [JsonProperty("internalComment")]
        public string internalComment { get; set; }

        /// <summary>
        ///     TResponse in xml format instead of json.
        /// </summary>
        [JsonProperty("xml")]
        public bool xml { get; set; }
    }
}