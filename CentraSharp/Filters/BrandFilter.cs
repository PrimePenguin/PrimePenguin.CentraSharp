using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class BrandFilter : Parameterizable
    {
        /// <summary>
        ///     Filter by BrandID;
        /// </summary>
        [JsonProperty("brandId")]
        public int BrandId { get; set; }
    }
}