using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ReturnCollection
    {
        /// <summary>
        ///  status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Array of fetched returns.
        /// </summary>
        [JsonProperty("returns")]
        public List<Return> Returns { get; set; }
    }
}