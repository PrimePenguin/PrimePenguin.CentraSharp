using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Shipment
{
    /// <summary>
    /// A service for manipulating Shipment of products.
    /// </summary>
    public class ShipmentService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShipmentService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Creates a Shipment for the order on the store.
        /// </summary>
        /// <param name="shipment"></param>
        /// <returns>The new <see cref="PrimePenguin.CentraSharp.Services.Order" />.</returns>
        public virtual async Task<ShipmentResponse> CreateShipmentAsync(ShipmentFilter shipment)
        {
            var req = PrepareRequest("shipments");
            var body = shipment.ToDictionary();
            var content = new JsonContent(new
            {
                body
            });

            return await ExecuteRequestAsync<ShipmentResponse>(req, HttpMethod.Post, content);
        }

        /// <summary>
        /// Update a Shipment for the order on the store.
        /// </summary>
        /// <param name="shipment"></param>
        /// <param name="shipmentId"></param>
        /// <returns>The new <see cref="PrimePenguin.CentraSharp.Services.Order" />.</returns>
        public virtual async Task<ListShipment> UpdateShipmentAsync(ShipmentFilter shipment, long shipmentId)
        {
            var req = PrepareRequest($"shipments/${shipmentId}");
            var body = shipmentId.ToDictionary();
            var content = new JsonContent(new
            {
                body
            });

            return await ExecuteRequestAsync<ListShipment>(req, HttpMethod.Put, content);
        }

        /// <summary>
        /// Get list of shipments for orders
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public virtual async Task<ListShipment> ListShipmentAsync(GetShipmentFilter options)
        {
            var req = PrepareRequest("shipments");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());
            return await ExecuteRequestAsync<ListShipment>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Complete Shipment for order
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public virtual async Task<ShipmentResponse> CompleteShipmentAsync(CompleteShipmentFilter options)
        {
            var req = PrepareRequest("shipment");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());
            return await ExecuteRequestAsync<ShipmentResponse>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Capture Shipment for order
        /// </summary>
        /// <param name="shipmentId"></param>
        /// <returns></returns>
        public virtual async Task<ShipmentResponse> CaptureShipmentAsync(string shipmentId)
        {
            var req = PrepareRequest($"shipment?shipment={shipmentId}");
            return await ExecuteRequestAsync<ShipmentResponse>(req, HttpMethod.Put);
        }

        /// <summary>
        /// Delete Shipment Form store By ID
        /// </summary>
        /// <param name="shipmentId"></param>
        /// <returns></returns>
        public virtual async Task<ShipmentResponse> DeleteShipmentAsync(string shipmentId)
        {
            var req = PrepareRequest($"shipments?shipmentId={shipmentId}");
            return await ExecuteRequestAsync<ShipmentResponse>(req, HttpMethod.Delete);
        }
    }
}