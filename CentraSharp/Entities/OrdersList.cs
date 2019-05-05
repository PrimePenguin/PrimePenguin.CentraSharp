﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class OrdersList
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        [JsonProperty("orders")]
        public IList<ProductOrder> Order { get; set; }

        /// <summary>
        /// Orders
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}