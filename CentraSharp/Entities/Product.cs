using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Product
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
        public string Products { get; set; }

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
        [JsonProperty("HarmDescription")]
        public string HarmDescription { get; set; }

        /// <summary>
        /// Active
        /// </summary>
        [JsonProperty("active")]
        public int Active { get; set; }

        /// <summary>
        /// Name
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
        /// Category
        /// </summary>
        [JsonProperty("categories")]
        public IList<string> Category { get; set; }

        /// <summary>
        /// Image
        /// </summary>
        [JsonProperty("images")]
        public IList<string> Image { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("prices")]
        public IList<Price> Price { get; set; }

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
       
    }
}