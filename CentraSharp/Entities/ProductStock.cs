using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ProductStock
    {
        /// <summary>
        /// Sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// VariantSku
        /// </summary>
        [JsonProperty("variantSku")]
        public string VariantSku { get; set; }

        /// <summary>
        /// SizeSku
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
        /// Product
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// Variant
        /// </summary>
        [JsonProperty("variant")]
        public string Variant { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// Ean
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// Weight
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// WeightUnit
        /// </summary>
        [JsonProperty("weightUnit")]
        public string WeightUnit { get; set; }

        /// <summary>
        /// CountryOfOrigin
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
        /// Active
        /// </summary>
        [JsonProperty("active")]
        public int Active { get; set; }

        /// <summary>
        /// PhysicalStock
        /// </summary>
        [JsonProperty("physicalStock")]
        public int PhysicalStock { get; set; }

        /// <summary>
        /// AllocatedStock
        /// </summary>
        [JsonProperty("allocatedStock")]
        public int AllocatedStock { get; set; }

        /// <summary>
        /// AvailableStock
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
    }
}