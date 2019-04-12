using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class CategoryFilter : Parameterizable
    {
        /// <summary>
        /// Filter by categoryId;
        /// </summary>
        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }
    }
}