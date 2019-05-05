using PrimePenguin.CentraSharp.Entities;
using System.Net.Http;
using System.Threading.Tasks;

namespace PrimePenguin.CentraSharp.Services.SupplierOrder
{
    /// <summary>
    /// A service for manipulating Shipment of Supplier.
    /// </summary>
    public class SupplierOrderService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public SupplierOrderService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Get Order For Supplier By Id
        /// </summary>
        /// <param name="supplierOrderId"></param>
        /// <returns></returns>
        public virtual async Task<ShipmentResponse> GetSupplierOrderAsync(long supplierOrderId)
        {
            var req = PrepareRequest($"supplier-orders/{supplierOrderId}");
            return await ExecuteRequestAsync<ShipmentResponse>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get list of Supplier orders
        /// </summary>
        /// <returns></returns>
        public virtual async Task<SupplierOrdersList> ListSupplierOrdersAsync()
        {
            var req = PrepareRequest("supplier-orders");
            return await ExecuteRequestAsync<SupplierOrdersList>(req, HttpMethod.Get);
        }
    }
}