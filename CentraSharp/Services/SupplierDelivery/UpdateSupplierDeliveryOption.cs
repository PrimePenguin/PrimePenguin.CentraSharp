using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.SupplierDelivery
{
    public class UpdateSupplierDeliveryOption
    {
        /// <summary>
        /// Products
        /// </summary>
        [JsonProperty("products")]
        public Dictionary<int, int> Products { get; set; }
    }
}
