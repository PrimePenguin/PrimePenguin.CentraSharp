using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Campaign
    {
        /// <summary>
        /// ID of the campaign
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the campaign
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaigns { get; set; }

        /// <summary>
        /// The price when this campaign is applied to the price. Currency will always be the same as in the pricelist.
        /// </summary>
        [JsonProperty("price")]
        public double Price { get; set; }
    }
}