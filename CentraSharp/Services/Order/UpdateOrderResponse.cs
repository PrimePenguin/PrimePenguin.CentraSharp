﻿using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Services.Order
{
    public class UpdateOrderResponse
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Msg
        /// </summary>
        [JsonProperty("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// Order
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; }
    }
}