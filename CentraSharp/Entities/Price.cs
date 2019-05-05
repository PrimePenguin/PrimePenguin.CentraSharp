using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Price
    {
        /// <summary>
        /// Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [JsonProperty("price")]
        public int Prices { get; set; }

        /// <summary>
        /// PriceList
        /// </summary>
        [JsonProperty("pricelist")]
        public string PriceList { get; set; }

        /// <summary>
        /// Currency
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Campaign
        /// </summary>
        [JsonProperty("campaigns")]
        public IList<Campaign> Campaign { get; set; }
    }
}