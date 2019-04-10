using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraCollection
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Collection
        /// </summary>
        [JsonProperty("collection")]
        public string Collection { get; set; }

        /// <summary>
        /// Uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }
}