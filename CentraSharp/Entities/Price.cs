﻿using Newtonsoft.Json;
using System.Collections.Generic;

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
        public double Prices { get; set; }

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
        /// Campaigns
        /// </summary>
        [JsonProperty("campaigns")]
        public IList<Campaign> Campaigns { get; set; }
    }
}