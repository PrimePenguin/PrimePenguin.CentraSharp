using System;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class SupplierOrder
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
        public DateTimeOffset? Created { get; set; }

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
    }
}
