using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CampaignList
    {
        /// <summary>
        /// name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// campaign
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("brand")]
        public Dictionary<int, Campaigns> Brand { get; set; }

        /// <summary>
        /// Errors
        /// </summary>
        [JsonProperty("errors")]
        public Errors Errors { get; set; }

        /// <summary>
        /// Markets
        /// </summary>
        [JsonProperty("markets")]
        public Dictionary<int, Market> Markets { get; set; }
    }

    public class Errors
    {
        /// <summary>
        /// campaign
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaign { get; set; }
    }

    public class Campaigns
    {
        /// <summary>
        /// name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// campaign
        /// </summary>
        [JsonProperty("campaign")]
        public string Campaign { get; set; }

        /// <summary>
        /// Markets
        /// </summary>
        [JsonProperty("markets")]
        public Dictionary<int, Market> Markets { get; set; }
    }

    public class Market
    {
        /// <summary>
        /// Pricelists
        /// </summary>
        [JsonProperty("pricelists")]
        public Dictionary<int, Pricelist> Pricelists { get; set; }
    }

    public class Pricelist
    {
        /// <summary>
        /// ProductsOnSales
        /// </summary>
        [JsonProperty("productsOnSale")]
        public List<string> ProductsOnSales { get; set; }
    }
}