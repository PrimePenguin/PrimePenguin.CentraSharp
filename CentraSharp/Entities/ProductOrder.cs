using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ProductOrder
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
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        ///// <summary>
        ///// Categories
        ///// </summary>
        //[JsonProperty("categories")]
        //public IList<string> Categories { get; set; }

        /// <summary>
        /// LineId
        /// </summary>
        [JsonProperty("lineId")]
        public string LineId { get; set; }

        /// <summary>
        /// Qty
        /// </summary>
        [JsonProperty("qty")]
        public string Qty { get; set; }

        /// <summary>
        /// price
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// OriginalPrice
        /// </summary>
        [JsonProperty("originalPrice")]
        public string OriginalPrice { get; set; }
    }
}