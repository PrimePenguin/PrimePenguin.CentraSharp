using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class ProductListFilter : Parameterizable
    {
        /// <summary>
        /// Filter on product SKU.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Get all products modified after a certain date. (YYYY-MM-DD).
        /// </summary>
        [JsonProperty("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// Get all products added after a certain date. (YYYY-MM-DD).
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }

        /// <summary>
        /// Get a product with specified EAN code.
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// You will get this amount of products, and a “next” parameter in return if there are multiple pages.
        /// This will go a lot faster to fetch, instead of fetching all products at once.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Variant Id
        /// </summary>
        [JsonProperty("variantId")]
        public int? VariantId { get; set; }

        /// <summary>
        /// ProductId
        /// </summary>
        [JsonProperty("productId")]
        public int? ProductId { get; set; }
    }
}