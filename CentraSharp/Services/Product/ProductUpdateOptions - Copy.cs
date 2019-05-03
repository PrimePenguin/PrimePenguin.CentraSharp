using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Product
{
    public class ProductUpdateOptions
    {
        /// <summary>
        /// Product
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        ///// <summary>
        ///// CostPrice
        ///// </summary>
        //[JsonProperty("costPrice")]
        //public string CostPrice { get; set; } = null;

        ///// <summary>
        ///// CostPriceCurrency
        ///// </summary>
        //[JsonProperty("costPriceCurrency")]
        //public string CostPriceCurrency { get; set; } = null;
    }
}