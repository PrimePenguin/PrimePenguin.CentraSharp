using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Services.SupplierDelivery
{
    public class UpdateSupplierDeliveryOption
    {
        /// <summary>
        /// Products
        /// </summary>
        [JsonProperty("products")]
        public List<KeyValuePair<string, int>> Products { get; set; } = null;
    }
}