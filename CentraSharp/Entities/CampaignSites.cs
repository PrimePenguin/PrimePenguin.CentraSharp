using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CampaignSites
    {
        /// <summary>
        /// Brand
        /// </summary>
        [JsonProperty("brand")]
        public Dictionary<string, CampaignData> Brand { get; set; }

        /// <summary>
        /// errors
        /// </summary>
        [JsonProperty("errors")]
        public ErrorsCampaignSites Errors { get; set; }
    }

    public class ErrorsCampaignSites
    {
        /// <summary>
        /// campaignSite
        /// </summary>
        [JsonProperty("campaignSite")]
        public string CampaignSite { get; set; }
    }

    public class CampaignData
    {
        /// <summary>
        /// market
        /// </summary>
        [JsonProperty("market")]
        public string Market { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// goTo
        /// </summary>
        [JsonProperty("goTo")]
        public string GoTo { get; set; }

        /// <summary>
        /// campaignSite
        /// </summary>
        [JsonProperty("campaignSite")]
        public string CampaignSite { get; set; }
    }
}