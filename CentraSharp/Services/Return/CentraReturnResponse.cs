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
        /// Return Completed
        /// </summary>
        [JsonProperty("returnCompleted")]
        public bool ReturnCompleted { get; set; }

        /// <summary>
        /// ReturnedItems
        /// </summary>
        [JsonProperty("returnedItems")]
        public string[] ReturnedItems { get; set; }

        /// <summary>
        /// ReturnedItems
        /// </summary>
        [JsonProperty("refund")]
        public Dictionary<string,string> Refund { get; set; }

        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}