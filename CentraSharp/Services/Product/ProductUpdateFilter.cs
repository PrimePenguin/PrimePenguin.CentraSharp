using System.Collections.Generic;
using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Product
{
    public class ProductUpdateFilter : Parameterizable
    {
        /// <summary>
        ///  ProductUpdateOptions
        /// </summary>
        [JsonProperty("products")]
        public List<ProductUpdateOptions> ProductUpdateOptions { get; set; }
    }
}