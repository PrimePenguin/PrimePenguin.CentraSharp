using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Product
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
        public string Products { get; set; }

        /// <summary>
        /// ID for this product.
        /// </summary>
        [JsonProperty("productId")]
        public int ProductId { get; set; }

        /// <summary>
        /// Variant
        /// </summary>
        [JsonProperty("variant")]
        public string Variant { get; set; }

        /// <summary>
        /// Name of the size for this specific product item
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// ID for this specific stock item
        /// </summary>
        [JsonProperty("stockItemId")]
        public int StockItemId { get; set; }

        /// <summary>
        /// The EAN for this product item size.
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// The weight specified for this product
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// The unit used for the weight
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
        /// If the product item is active or not
        /// </summary>
        [JsonProperty("active")]
        public int Active { get; set; }

        /// <summary>
        /// The externally facing name for this product.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// ShortDescription
        /// </summary>
        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Array with names of the categories the product belongs to.
        /// </summary>
        [JsonProperty("categories")]
        public IList<string> Categories { get; set; }

        ///// <summary>
        ///// Images
        ///// </summary>
        //[JsonProperty("images")]
        //public IList<string> Images { get; set; }

        /// <summary>
        /// Array of the pricelists for this product.
        /// </summary>
        [JsonProperty("prices")]
        public IList<Price> Prices { get; set; }

        /// <summary>
        /// CostPrice
        /// </summary>
        [JsonProperty("costPrice")]
        public double CostPrice { get; set; }

        /// <summary>
        /// CostPriceCurrency
        /// </summary>
        [JsonProperty("costPriceCurrency")]
        public string CostPriceCurrency { get; set; }
    }
}