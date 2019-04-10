using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class CollectionFilter : Parameterizable
    {
        /// <summary>
        /// Filter by BrandID;
        /// </summary>
        [JsonProperty("collectionId")]
        public int CollectionId { get; set; }
    }
}