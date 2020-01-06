using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.Product
{
    public class ProductUpdateOptions
    {
        /// <summary>
        /// String to update a product item. Use ean or a combination of sku, variantSku and sizeSku to update the quantity for each product.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// The quantity of the physical stock for the item
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// The internal cost price for this item.
        /// </summary>
        [JsonProperty("costPrice")]
        public string CostPrice { get; set; }

        /// <summary>
        /// ISO code for the currency for the cost price. USD, EUR, SEK, etc
        /// </summary>
        [JsonProperty("costPriceCurrency")]
        public string CostPriceCurrency { get; set; }
    }
}