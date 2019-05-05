using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Infrastructure;
using System.Net.Http;
using System.Threading.Tasks;

namespace PrimePenguin.CentraSharp.Services.SupplierDelivery
{
    /// <summary>
    /// A service for manipulating Shipment of Supplier.
    /// </summary>
    public class SupplierDeliveryService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public SupplierDeliveryService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Get List of Supplier Deliveries
        /// </summary>
        /// <returns></returns>
        public virtual async Task<SupplierDeliveryList> ListSupplierDeliveriesAsync()
        {
            var req = PrepareRequest("supplier-deliveries");
            return await ExecuteRequestAsync<SupplierDeliveryList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get delivery For Supplier By Id
        /// </summary>
        /// <param name="supplierDeliveryId"></param>
        /// <returns></returns>
        public virtual async Task<Entities.SupplierDelivery> GetSupplierDeliveryAsync(int supplierDeliveryId)
        {
            var req = PrepareRequest($"supplier-deliveries/{supplierDeliveryId}");
            return await ExecuteRequestAsync<Entities.SupplierDelivery>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get Supplier Delivery Details
        /// </summary>
        /// <param name="supplierDeliveryId"></param>
        /// <returns></returns>
        public virtual async Task<Entities.SupplierDelivery> GetSupplierDeliveryDetailsAsync(int supplierDeliveryId)
        {
            var req = PrepareRequest($"supplier-deliveries/{supplierDeliveryId}/details");
            return await ExecuteRequestAsync<Entities.SupplierDelivery>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Accept Supplier Delivery
        /// </summary>
        /// <param name="option"></param>
        /// <param name="supplierDeliveryId"></param>
        /// <returns></returns>
        public virtual async Task<AcceptDeliveryResponse> AcceptSupplierDeliveryAsync(UpdateSupplierDeliveryOption option, int supplierDeliveryId)
        {
            var req = PrepareRequest($"supplier-deliveries/{supplierDeliveryId}");
            var content = new JsonContent(new
            {
                products = option.Products
            });
            return await ExecuteRequestAsync<AcceptDeliveryResponse>(req, HttpMethod.Post, content);
        }
    }
}