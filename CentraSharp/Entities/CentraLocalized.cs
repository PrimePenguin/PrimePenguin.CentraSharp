using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraLocalized
    {
        /// <summary>
        /// Sv
        /// </summary>
        [JsonProperty("sv")]
        public CentraSv Sv { get; set; }
    }
}