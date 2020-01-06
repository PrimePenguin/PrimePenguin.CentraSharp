using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Price
    {
        /// <summary>
        /// ID of the pricelist
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Price for the product in this pricelist
        /// </summary>
        [JsonProperty("price")]
        public double Prices { get; set; }

        /// <summary>
        /// Name of the pricelist.
        /// </summary>
        [JsonProperty("pricelist")]
        public string PriceList { get; set; }

        /// <summary>
        /// ISO code of the currency for this pricelist
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// List of campaigns this product is connected to in this pricelist
        /// </summary>
        [JsonProperty("campaigns")]
        public IList<Campaign> Campaigns { get; set; }
    }
}