using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrimePenguin.CentraSharp.Services.Product
{
    /// <summary>
    /// A service for manipulating Centra products using Shop APIs.
    /// </summary>
    public class ShopProductService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop. Use ShopAPI token from centra store</param>
        public ShopProductService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Get Products By Filter.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        [Obsolete(" Use ShopAPI token from centra store")]
        public virtual async Task<Dictionary<string, ProductsFilter>> GetByFilterAsync(ProductFilter options = null)
        {
            var req = PrepareRequest("products/filter");

            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<Dictionary<string, ProductsFilter>>(req, HttpMethod.Post);
        }

        /// <summary>
        /// Get Product By ID
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [Obsolete(" Use ShopAPI token from centra store")]
        public virtual async Task<ProductsFilter> GetAsync(long productId)
        {
            var req = PrepareRequest($"products/{productId}");

            return await ExecuteRequestAsync<ProductsFilter>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get product IDs
        /// </summary>
        /// <returns></returns>
        [Obsolete(" Use ShopAPI token from centra store")]
        public virtual async Task<IList<string>> GetProductIDs()
        {
            var req = PrepareRequest("product-ids");

            return await ExecuteRequestAsync<IList<string>>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get CollectionList and FilterBy Id
        /// </summary>
        /// <returns></returns>
        [Obsolete(" Use ShopAPI token from centra store")]
        public virtual async Task<Dictionary<string, CentraCollection>> GetProductCollections(CollectionFilter options)
        {
            var req = PrepareRequest("collections");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<Dictionary<string, CentraCollection>>(req, HttpMethod.Get);
        }
    }
}