using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Warehouse
    {
        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ItemQty
        /// </summary>
        [JsonProperty("itemQty")]
        public int ItemQty { get; set; }
    }
}
