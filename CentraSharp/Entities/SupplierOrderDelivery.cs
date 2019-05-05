using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class SupplierOrderDelivery
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// AccountId
        /// </summary>
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// AccountName
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Buyer
        /// </summary>
        [JsonProperty("buyer")]
        public string Buyer { get; set; }

        /// <summary>
        /// Carrier
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Service
        /// </summary>
        [JsonProperty("service")]
        public string Service { get; set; }

        /// <summary>
        /// Other
        /// </summary>
        [JsonProperty("other")]
        public string Other { get; set; }

        /// <summary>
        /// PaymentTerms
        /// </summary>
        [JsonProperty("paymentTerms")]
        public string PaymentTerms { get; set; }

        /// <summary>
        /// ShippingTerms
        /// </summary>
        [JsonProperty("shippingTerms")]
        public string ShippingTerms { get; set; }

        /// <summary>
        /// PoNumber
        /// </summary>
        [JsonProperty("poNumber")]
        public string PoNumber { get; set; }

        /// <summary>
        /// DeliveryName
        /// </summary>
        [JsonProperty("deliveryName")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// DeliveryCompany
        /// </summary>
        [JsonProperty("deliveryCompany")]
        public string DeliveryCompany { get; set; }

        /// <summary>
        /// DeliveryEmail
        /// </summary>
        [JsonProperty("deliveryEmail")]
        public string DeliveryEmail { get; set; }

        /// <summary>
        /// DeliveryCell
        /// </summary>
        [JsonProperty("deliveryCell")]
        public string DeliveryCell { get; set; }

        /// <summary>
        /// DeliveryTele
        /// </summary>
        [JsonProperty("deliveryTele")]
        public string DeliveryTele { get; set; }

        /// <summary>
        /// DeliveryAddress
        /// </summary>
        [JsonProperty("deliveryAddress")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// DeliveryCoaddress
        /// </summary>
        [JsonProperty("deliveryCoaddress")]
        public string DeliveryCoaddress { get; set; }

        /// <summary>
        /// DeliveryZipcode
        /// </summary>
        [JsonProperty("deliveryZipcode")]
        public string DeliveryZipcode { get; set; }

        /// <summary>
        /// DeliveryCity
        /// </summary>
        [JsonProperty("deliveryCity")]
        public string DeliveryCity { get; set; }

        /// <summary>
        /// DeliveryState
        /// </summary>
        [JsonProperty("deliveryState")]
        public string DeliveryState { get; set; }

        /// <summary>
        /// DeliveryCountry
        /// </summary>
        [JsonProperty("deliveryCountry")]
        public string DeliveryCountry { get; set; }

        /// <summary>
        /// DeliveryId
        /// </summary>
        [JsonProperty("deliveryId")]
        public string DeliveryId { get; set; }

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
        /// Products
        /// </summary>
        [JsonProperty("products")]
        public List<DeliveryProduct> Products { get; set; }
    }

    public class DeliveryProduct
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
        public int Weight { get; set; }

        /// <summary>
        /// WeightUnit
        /// </summary>
        [JsonProperty("weightUnit")]
        public string WeightUnit { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Cost
        /// </summary>
        [JsonProperty("cost")]
        public string Cost { get; set; }

        /// <summary>
        /// CostCurrency
        /// </summary>
        [JsonProperty("costCurrency")]
        public string CostCurrency { get; set; }
    }
}