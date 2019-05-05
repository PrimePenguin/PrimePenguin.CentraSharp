using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class SupplierOrderWithProduct
    {
        /// <summary>
        /// OrderId
        /// </summary>
        [JsonProperty("orderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// SupplierName
        /// </summary>
        [JsonProperty("supplierName")]
        public string SupplierName { get; set; }

        /// <summary>
        /// SupplierCountry
        /// </summary>
        [JsonProperty("supplierCountry")]
        public string SupplierCountry { get; set; }

        /// <summary>
        /// Created
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }

        /// <summary>
        /// Etd
        /// </summary>
        [JsonProperty("ETD")]
        public string Etd { get; set; }

        /// <summary>
        /// Eta
        /// </summary>
        [JsonProperty("ETA")]
        public string Eta { get; set; }

        /// <summary>
        /// Message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// ProductsQty
        /// </summary>
        [JsonProperty("productsQty")]
        public int ProductsQty { get; set; }

        /// <summary>
        /// products
        /// </summary>
        [JsonProperty("products")]
        public List<SupplierProduct> Products { get; set; }
    }

    public class SupplierProduct
    {
        /// <summary>
        /// sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// variantSku
        /// </summary>
        [JsonProperty("variantSku")]
        public string VariantSku { get; set; }

        /// <summary>
        /// sizeSku
        /// </summary>
        [JsonProperty("sizeSku")]
        public string SizeSku { get; set; }

        /// <summary>
        /// brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// collection
        /// </summary>
        [JsonProperty("collection")]
        public string Collection { get; set; }

        /// <summary>
        /// product
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// products
        /// </summary>
        [JsonProperty("variant")]
        public string Variant { get; set; }

        /// <summary>
        /// size
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }

        /// <summary>
        /// ean
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// weight
        /// </summary>
        [JsonProperty("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// weightUnit
        /// </summary>
        [JsonProperty("weightUnit")]
        public string WeightUnit { get; set; }

        /// <summary>
        /// quantity
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// cost
        /// </summary>
        [JsonProperty("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// costCurrency
        /// </summary>
        [JsonProperty("costCurrency")]
        public string CostCurrency { get; set; }
    }
}