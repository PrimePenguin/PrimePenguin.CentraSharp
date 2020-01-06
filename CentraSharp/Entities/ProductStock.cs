using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ProductStock
    {
        /// <summary>
        /// SKU for this product.
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// ID for this variant.
        /// </summary>
        [JsonProperty("variantId")]
        public int VariantId { get; set; }

        /// <summary>
        /// SKU for this variant
        /// </summary>
        [JsonProperty("variantSku")]
        public string VariantSku { get; set; }

        /// <summary>
        /// SKU for this size
        /// </summary>
        [JsonProperty("sizeSku")]
        public string SizeSku { get; set; }

        /// <summary>
        /// Brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// Collection
        /// </summary>
        [JsonProperty("collection")]
        public string Collection { get; set; }

        /// <summary>
        /// The internal name for this product.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// The ID for this product
        /// </summary>
        [JsonProperty("productId")]
        public int ProductId { get; set; }

        /// <summary>
        /// Variant
        /// </summary>
        [JsonProperty("variant")]
        public string Variant { get; set; }

        /// <summary>
        /// Name of the size for this specific product item.
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// The EAN for this product item size.
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// The weight specified for this product.
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// The unit used for the weight.
        /// </summary>
        [JsonProperty("weightUnit")]
        public string WeightUnit { get; set; }

        /// <summary>
        /// ISO-Alpha-2 (SE, US, GB etc)
        /// </summary>
        [JsonProperty("countryOfOrigin")]
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// HarmCode
        /// </summary>
        [JsonProperty("harmCode")]
        public string HarmCode { get; set; }

        /// <summary>
        /// HarmDescription
        /// </summary>
        [JsonProperty("harmDescription")]
        public string HarmDescription { get; set; }

        /// <summary>
        /// If the product item is active or not.
        /// </summary>
        [JsonProperty("active")]
        public int Active { get; set; }

        /// <summary>
        /// The amount of items in the physical stock. If an order is placed without being shipped, the physical stock of the product does not change. However, as soon as a shipment is completed, the physical stock will decrease
        /// </summary>
        [JsonProperty("physicalStock")]
        public int PhysicalStock { get; set; }

        /// <summary>
        /// The amount of items in the physical stock that is currently allocated against orders.
        /// </summary>
        [JsonProperty("allocatedStock")]
        public int AllocatedStock { get; set; }

        /// <summary>
        /// The amount of items in the physical stock that is currently available to sell
        /// </summary>
        [JsonProperty("availableStock")]
        public int AvailableStock { get; set; }

        /// <summary>
        /// OriginalPrice
        /// </summary>
        [JsonProperty("costPrice")]
        public double CostPrice { get; set; }

        /// <summary>
        /// costPriceCurrency
        /// </summary>
        [JsonProperty("costPriceCurrency")]
        public string CostPriceCurrency { get; set; }

        /// <summary>
        /// AvailableStock
        /// </summary>
        [JsonProperty("stockItemId")]
        public int? StockItemId { get; set; }
    }
}