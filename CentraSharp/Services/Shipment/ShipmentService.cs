using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;
using PrimePenguin.CentraSharp.Infrastructure;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(body);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            return await ExecuteRequestAsync<ShipmentResponse>(req, HttpMethod.Post, httpContent);
        }

        /// <summary>
        /// Update a Shipment for the order on the store.
        /// </summary>
        /// <param name="shipment"></param>
        /// <param name="shipmentId"></param>
        /// <returns>The new <see cref="PrimePenguin.CentraSharp.Services.Order" />.</returns>
        public virtual async Task<ShipmentResponse> UpdateShipmentAsync(ShipmentFilter shipment, string shipmentId)
        {
            var req = PrepareRequest($"shipments/{shipmentId}");
            var body = shipment.ToDictionary();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(body);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            return await ExecuteRequestAsync<ShipmentResponse>(req, HttpMethod.Put, httpContent);
        }

        /// <summary>
        /// Get list of shipments for orders
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public virtual async Task<ListShipment> ListShipmentAsync(GetShipmentFilter options = null)
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
        public virtual async Task<CompleteShipmentResponse> CompleteShipmentAsync(CompleteShipmentFilter options)
        {
            var req = PrepareRequest("shipment");
            var body = options.ToDictionary();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(body);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            return await ExecuteRequestAsync<CompleteShipmentResponse>(req, HttpMethod.Put, httpContent);
        }

        /// <summary>
        /// Capture Shipment for order
        /// </summary>
        /// <param name="shipmentId"></param>
        /// <returns></returns>
        public virtual async Task<CompleteShipmentResponse> CaptureShipmentAsync(string shipmentId)
        {
            var req = PrepareRequest("capture");
            var content = new JsonContent(new
            {
                shipment = shipmentId
            });
            return await ExecuteRequestAsync<CompleteShipmentResponse>(req, HttpMethod.Put, content);
        }

        /// <summary>
        /// Delete Shipment Form store By ID
        /// </summary>
        /// <param name="shipmentId"></param>
        /// <returns></returns>
        public virtual async Task<CompleteShipmentResponse> DeleteShipmentAsync(string shipmentId)
        {
            var req = PrepareRequest($"shipments/{shipmentId}");
            return await ExecuteRequestAsync<CompleteShipmentResponse>(req, HttpMethod.Delete);
        }
    }
}