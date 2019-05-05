using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Services.Return
{
    public class CentraReturnResponse
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Return
        /// </summary>
        [JsonProperty("return")]
        public int Return { get; set; }

        /// <summary>
        /// ReturnedItems
        /// </summary>
        [JsonProperty("returnedItems")]
        public List<string> ReturnedItems { get; set; }

        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}