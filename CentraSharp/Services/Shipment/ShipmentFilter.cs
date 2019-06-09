﻿using System.Collections.Generic;
using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    public class ShipmentFilter : Parameterizable
    {
        /// <summary>
        /// Order ID to create shipment on.
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; }

        /// <summary>
        /// Key is lineID from the Get orders response and value is the quantity.
        /// </summary>
        [JsonProperty("products")]
        public Dictionary<string, int> Products { get; set; }

        /// <summary>
        /// Default: true. Mark the shipment as sent.
        /// </summary>
        [JsonProperty("shipped")]
        public bool? Shipped { get; set; }

        /// <summary>
        /// Tracking number for shipment. Only used if shipped is true.
        /// </summary>
        [JsonProperty("tracking")]
        public string Tracking { get; set; }

        /// <summary>
        /// Default: false. Mark the shipment as good to go.
        /// </summary>
        [JsonProperty("gtg")]
        public bool? Gtg { get; set; }
    }
}