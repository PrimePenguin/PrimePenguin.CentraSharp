using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Filters
{
    public class ProductFilter : Parameterizable
    {
        /// <summary>
        /// Filter by Product IDs, passed as string or array of strings;
        /// </summary>
        [JsonProperty("products")]
        public IList<string> Products { get; set; }

        /// <summary>
        /// Filter by Product URI.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Filter by  Maximum amount of returned products.
        /// </summary>
        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// Filter by offset in the filtered list from where results will be returned.
        /// </summary>
        [JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Filter by Centra product ID.
        /// </summary>
        [JsonProperty("silkProduct")]
        public string SilkProduct { get; set; }

        /// <summary>
        /// Filter by Centra variant ID.
        /// </summary>
        [JsonProperty("silkVariant")]
        public string SilkVariant { get; set; }

        /// <summary>
        /// Filter on the category ID for the products.
        /// </summary>
        [JsonProperty("categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// Filter on product SKU.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Filter on market ID.
        /// </summary>
        [JsonProperty("market")]
        public string Market { get; set; }

        /// <summary>
        /// Return products not being activated yet.
        /// </summary>
        [JsonProperty("preview")]
        public bool Preview { get; set; }
    }
}