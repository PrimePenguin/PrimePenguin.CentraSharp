using System.Collections.Generic;
using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Filters
{
    public class CreateOrderFilter : Parameterizable
    {
        /// <summary>
        /// Invoice Address for customer order
        /// </summary>
        [JsonProperty("invoiceAddress")]
        public OrderInvoiceAddress InvoiceAddress { get; set; }

        /// <summary>
        /// Delivery address of order
        /// </summary>
        [JsonProperty("deliveryAddress")]
        public OrderDeliveryAddress DeliveryAddress { get; set; }

        /// <summary>
        /// products included in order
        /// </summary>
        [JsonProperty("products")]
        public IList<OrderProduct> Products { get; set; }
    }
}