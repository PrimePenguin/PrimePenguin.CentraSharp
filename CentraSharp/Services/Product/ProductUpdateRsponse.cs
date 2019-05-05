using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Services.Product
{
    public class ProductUpdateRsponse
    {
        public class Errors
        {
            /// <summary>
            /// ProductsNotFound
            /// </summary>
            [JsonProperty("productsNotFound")]
            public IList<string> ProductsNotFound { get; set; }
        }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// Error
        /// </summary>
        [JsonProperty("errors")]
        public Errors Error { get; set; }
    }
}