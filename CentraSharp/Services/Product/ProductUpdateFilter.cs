using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;
using System.Collections.Generic;

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