using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ReturnProduct
    {
        /// <summary>
        /// ID of the specific product item in this return
        /// </summary>
        [JsonProperty("returnLineId")]
        public int ReturnLineId { get; set; }

        /// <summary>
        /// ID of the related shipment line
        /// </summary>
        [JsonProperty("shipmentLineId")]
        public int ShipmentLineId { get; set; }

        /// <summary>
        /// ID of the related order line
        /// </summary>
        [JsonProperty("orderLineId")]
        public int OrderLineId { get; set; }

        /// <summary>
        /// ID of the product
        /// </summary>
        [JsonProperty("productId")]
        public int ProductId { get; set; }

        /// <summary>
        /// ID of the product variant
        /// </summary>
        [JsonProperty("variantId")]
        public int VariantId { get; set; }

        /// <summary>
        /// ID of the product variant
        /// </summary>
        [JsonProperty("productName")]
        public string ProductName { get; set; }

        /// <summary>
        /// Brand name of the product
        /// </summary>
        [JsonProperty("productBrand")]
        public string ProductBrand { get; set; }

        /// <summary>
        /// Name of the product variant
        /// </summary>
        [JsonProperty("variantName")]
        public string VariantName { get; set; }

        /// <summary>
        /// Size description, if any
        /// </summary>
        [JsonProperty("size")]
        public object Size { get; set; }

        /// <summary>
        /// Product SKU
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Product variant SKU
        /// </summary>
        [JsonProperty("variantSku")]
        public string VariantSku { get; set; }

        /// <summary>
        /// Product variant SKU.
        /// </summary>
        [JsonProperty("sizeSku")]
        public string SizeSku { get; set; }

        /// <summary>
        /// EAN of the item
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// Quantity of this specific product item returned.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Price of this specific product item returned.
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; }
    }
}