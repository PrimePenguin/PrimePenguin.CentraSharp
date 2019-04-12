using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Infrastructure;

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
        public virtual async Task<SupplieDeliveryList> ListSupplierDeliveriesAsync()
        {
            var req = PrepareRequest("supplier-deliveries");
            return await ExecuteRequestAsync<SupplieDeliveryList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get delivery For Supplier By Id
        /// </summary>
        /// <param name="supplierDeliveryId"></param>
        /// <returns></returns>
        public virtual async Task<SupplieDeliveryList> GetSupplierDeliveryAsync(long supplierDeliveryId)
        {
            var req = PrepareRequest($"supplier-delivery/{supplierDeliveryId}");
            return await ExecuteRequestAsync<SupplieDeliveryList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get Supplier Delivery Details
        /// </summary>
        /// <param name="supplierDeliveryId"></param>
        /// <returns></returns>
        public virtual async Task<SupplieDeliveryList> GetSupplierDeliveryDetailsAsync(long supplierDeliveryId)
        {
            var req = PrepareRequest($"supplier-delivery/{supplierDeliveryId}/details");
            return await ExecuteRequestAsync<SupplieDeliveryList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Accept Supplier Delivery
        /// </summary>
        /// <param name="option"></param>
        /// <param name="supplierDeliveryId"></param>
        /// <returns></returns>
        public virtual async Task<AcceptDeliveryResponse> AcceptSupplierDeliveryAsync(UpdateSupplierDeliveryOption option, long supplierDeliveryId)
        {
            var req = PrepareRequest($"supplier-deliveries/{supplierDeliveryId}");
            var body = option.ToDictionary();
            var content = new JsonContent(new
            {
                body
            });
            return await ExecuteRequestAsync<AcceptDeliveryResponse>(req, HttpMethod.Post, content);
        }
    }
}