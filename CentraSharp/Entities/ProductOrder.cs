using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        /// <summary>
        /// OtherComment
        /// </summary>
        [JsonProperty("otherComment")]
        public string OtherComment { get; set; }

        ///// <summary>
        ///// Categories
        ///// </summary>
        //[JsonProperty("categories")]
        //public IList<string> Categories { get; set; }

        /// <summary>
        /// Id of the specific product item in this order.
        /// </summary>
        [JsonProperty("lineId")]
        public string LineId { get; set; }

        /// <summary>
        /// Quantity of this specific product item.
        /// </summary>
        [JsonProperty("qty")]
        public int Qty { get; set; }

        /// <summary>
        /// price
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; }

        /// <summary>
        /// OriginalPrice
        /// </summary>
        [JsonProperty("originalPrice")]
        public double OriginalPrice { get; set; }

        /// <summary>
        /// TaxPercent
        /// </summary>
        [JsonProperty("taxPercent")]
        public double? TaxPercent { get; set; }

        /// <summary>
        /// PriceDiscount
        /// </summary>
        [JsonProperty("priceDiscount")]
        public double? PriceDiscount { get; set; }

        /// <summary>
        /// PriceDiscountAsPercent
        /// </summary>
        [JsonProperty("priceDiscountAsPercent")]
        public double? PriceDiscountAsPercent { get; set; }

        /// <summary>
        /// taxValue
        /// </summary>
        [JsonProperty("taxValue")]
        public double? TaxValue { get; set; }

        /// <summary>
        /// TotalPrice
        /// </summary>
        [JsonProperty("totalPrice")]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// AnyDiscount
        /// </summary>
        [JsonProperty("anyDiscount")]
        public bool AnyDiscount { get; set; }

        /// <summary>
        /// PriceEachWithoutTax
        /// </summary>
        [JsonProperty("priceEachWithoutTax")]
        public double? PriceEachWithoutTax { get; set; }

        /// <summary>
        /// warehouses
        /// </summary>
        [JsonProperty("warehouses")]
        public ICollection<Warehouse> Warehouses { get; set; } = new Collection<Warehouse>();
    }
}