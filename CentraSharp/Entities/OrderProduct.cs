using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class OrderProduct
    {
        /// <summary>
        /// Qty
        /// </summary>
        [JsonProperty("qty")]
        public int Qty { get; set; }

        /// <summary>
        /// Ean
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// UnitPrice
        /// </summary>
        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        /// <summary>
        /// OriginalPrice
        /// </summary>
        [JsonProperty("originalPrice")]
        public double OriginalPrice { get; set; }

        /// <summary>
        /// ItemText
        /// </summary>
        [JsonProperty("itemText")]
        public OrderItemText ItemText { get; set; }

        /// <summary>
        /// Sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }
    }
}