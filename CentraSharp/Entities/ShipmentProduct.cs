using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ShipmentProduct
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

        /// <summary>
        /// Categories
        /// </summary>
        [JsonProperty("categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// LineId
        /// </summary>
        [JsonProperty("lineId")]
        public string LineId { get; set; }

        /// <summary>
        /// Qty
        /// </summary>
        [JsonProperty("qty")]
        public int Qty { get; set; }

        /// <summary>
        /// OriginalPrice
        /// </summary>
        [JsonProperty("originalPrice")]
        public decimal? OriginalPrice { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("price")]
        public decimal? Price { get; set; }

        /// <summary>
        /// warehouses
        /// </summary>
        [JsonProperty("warehouses")]
        public ICollection<Warehouse> Warehouses { get; set; } = new Collection<Warehouse>();

        /// <summary>
        /// Is Bundle
        /// </summary>
        [JsonProperty("isBundle")]
        public bool IsBundle { get; set; }

        /// <summary>
        /// Is Part Of Bundle
        /// </summary>
        [JsonProperty("isPartOfBundle")]
        public string IsPartOfBundle { get; set; }
    }
}