using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;
using PrimePenguin.CentraSharp.Infrastructure;
using PrimePenguin.CentraSharp.Services.Customer;

namespace PrimePenguin.CentraSharp.Services.Order
{
    /// <summary>
    /// A service for manipulating Centra orders.
    /// </summary>
    public class OrderService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public OrderService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Gets a list of the shop's orders.
        /// </summary>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of orders matching the filter.</returns>
        public virtual async Task<OrdersList> ListAsync(OrderFilter options = null)
        {
            var req = PrepareRequest("orders");

            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<OrdersList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Retrieves the order with the given id.
        /// </summary>
        /// <param name="orderId">The id of the order to retrieve.</param>
        /// <returns>The <see cref="PrimePenguin.CentraSharp.Services.Order" />.</returns>
        public virtual async Task<OrdersList> GetAsync(int orderId)
        {
            var options = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("order", $"{orderId}")
            };

            var req = PrepareRequest($"orders");
            req.QueryParams.AddRange(options);
            return await ExecuteRequestAsync<OrdersList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Update the order
        /// </summary>
        /// <param name="orderUpdateOptions"></param>
        /// <returns></returns>
        public virtual async Task<UpdateOrderResponse> UpdateAsync(OrderUpdateOptions orderUpdateOptions)
        {
            var req = PrepareRequest("orders");
            var body = orderUpdateOptions.ToDictionary();
            var content = new JsonContent(body);
            return await ExecuteRequestAsync<UpdateOrderResponse>(req, HttpMethod.Put, content);
        }

        /// <summary>
        /// Creates a new <see cref="PrimePenguin.CentraSharp.Services.Order" /> on the store.
        /// </summary>
        /// <param name="order">A new <see cref="PrimePenguin.CentraSharp.Services.Order" />. Id should be set to null.</param>
        /// <param name="options">Options for creating the order.</param>
        /// <returns>The new <see cref="PrimePenguin.CentraSharp.Services.Order" />.</returns>
        public virtual async Task<Entities.Order> CreateAsync(CreateOrderFilter order)
        {
            var req = PrepareRequest("order");
            var body = order.ToDictionary();
            var content = new JsonContent(body);

            return await ExecuteRequestAsync<Entities.Order>(req, HttpMethod.Post, content);
        }

        /// <summary>
        /// Complete the given <see cref="PrimePenguin.CentraSharp.Services.Order" />.
        /// </summary>
        /// <param name="orderId">Id of the object being updated.</param>
        /// <param name="comment"></param>
        /// <returns>The updated <see cref="PrimePenguin.CentraSharp.Services.Order" />.</returns>
        public virtual async Task<CompleteOrderResponse> CompleteOrderAsync(long orderId, string comment)
        {
            var req = PrepareRequest($"order/{orderId}");
            var content = new JsonContent(comment);
            return await ExecuteRequestAsync<CompleteOrderResponse>(req, HttpMethod.Post, content);
        }
    }
}