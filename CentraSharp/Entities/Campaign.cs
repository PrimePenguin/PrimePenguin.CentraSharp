using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Campaign
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Campaign
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaigns { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; }
    }
}