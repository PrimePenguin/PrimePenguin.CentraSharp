﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace PrimePenguin.CentraSharp.Entities
{
    public class SupplierOrdersList
    {
        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// SupplierOrders
        /// </summary>
        [JsonProperty("orders")]
        public List<SupplierOrder> SupplierOrders { get; set; }
    }
}