using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraSv
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// MetaTitle
        /// </summary>
        [JsonProperty("metaTitle")]
        public string MetaTitle { get; set; }
    }
}