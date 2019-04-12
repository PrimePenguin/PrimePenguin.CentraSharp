using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    /// <summary>
    /// An object representing a product image.
    /// </summary>
    public class ProductMarkets
    {
        /// <summary>
        /// The keys in the object is the price list IDs.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The price after discounts for this product in this price list represented as a number.
        /// </summary>
        [JsonProperty("priceAsNumber")]
        public decimal PriceAsNumber { get; set; }

        /// <summary>
        /// The price before discount represented as a string with proper currency formatting.
        /// </summary>
        [JsonProperty("priceBeforeDiscount")]
        public string PriceBeforeDiscount { get; set; }

        /// <summary>
        /// The percentage of discount applied on the product price.
        /// </summary>
        [JsonProperty("discountPercent")]
        public int DiscountPercent { get; set; }

        /// <summary>
        /// The amount that was reduced from the current price represented as a number.
        /// </summary>
        [JsonProperty("priceReductionAsNumber")]
        public decimal PriceReductionAsNumber { get; set; }

        /// <summary>
        /// The amount that was reduced from the current price
        /// represented as a string with proper currency formatting.
        /// </summary>
        [JsonProperty("priceReduction")]
        public string PriceReduction { get; set; }

        /// <summary>
        /// If the product should be listed as currently on sale or not.
        /// </summary>
        [JsonProperty("showAsOnSale")]
        public bool Filename { get; set; }

        /// <summary>
        /// If the product should be listed as being added recently.
        /// </summary>
        [JsonProperty("newProduct")]
        public bool NewProduct { get; set; }
    }
}