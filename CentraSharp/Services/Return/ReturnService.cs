using PrimePenguin.CentraSharp.Infrastructure;
using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;

namespace PrimePenguin.CentraSharp.Services.Return
{
    /// <summary>
    /// A service for manipulating Return of products.
    /// </summary>
    public class ReturnService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ReturnService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Gets a list of the returns.
        /// </summary>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of returns matching the filter.</returns>
        public virtual async Task<ReturnCollection> ListAsync(ReturnFilter options = null)
        {
            var req = PrepareRequest("returns");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());
            return await ExecuteRequestAsync<ReturnCollection>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Creates a return for the order on the store.
        /// </summary>
        /// <param name="returnOptions"></param>
        /// <returns>The new <see cref="CentraReturnResponse" />.</returns>
        public virtual async Task<CentraReturnResponse> CreateReturnAsync(CentraReturnOptions returnOptions)
        {
            var req = PrepareRequest("return");
            var content = new JsonContent(new
            {
                shipment = returnOptions.Shipment,
                returnStock = returnOptions.ReturnStock,
                comment = returnOptions.Comment,
                products = returnOptions.Products,
               
               
            });
            return await ExecuteRequestAsync<CentraReturnResponse>(req, HttpMethod.Post, content);
        }
    }
}