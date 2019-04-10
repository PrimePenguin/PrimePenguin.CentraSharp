using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Product
{
    /// <summary>
    ///     A service for manipulating Centra products.
    /// </summary>
    public class ProductService : CentraService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        public virtual async Task<CentraProductsList> ListAsync()
        {
            var req = PrepareRequest("products");

            return await ExecuteRequestAsync<CentraProductsList>(req, HttpMethod.Get);
        }

        public virtual async Task<CentraProductsList> GetByFilterAsync(ProductFilter options = null)
        {
            var req = PrepareRequest("products/filter");

            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<CentraProductsList>(req, HttpMethod.Get);
        }


        public virtual async Task<CentraProductsList> GetAsync(long productId)
        {
            var req = PrepareRequest($"products/{productId}");

            return await ExecuteRequestAsync<CentraProductsList>(req, HttpMethod.Get);
        }

        /// <summary>
        ///     Get BrandsList and FilterBy Id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<string>> GetBrands(BrandFilter options)
        {
            var req = PrepareRequest("product-ids");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<IList<string>>(req, HttpMethod.Get);
        }

        /// <summary>
        ///     Get product IDs
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<string>> GetProductIDs()
        {
            var req = PrepareRequest("product-ids");

            return await ExecuteRequestAsync<IList<string>>(req, HttpMethod.Get);
        }


        /// <summary>
        ///     Get CategoryList and FilterBy Id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<CentraProductCategory>> GetCategories(CategoryFilter options)
        {
            var req = PrepareRequest("categories");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<IList<CentraProductCategory>>(req, HttpMethod.Get);
        }


        /// <summary>
        ///     Get CollectionList and FilterBy Id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<CentraCollection>> GetProductCollections(CollectionFilter options)
        {
            var req = PrepareRequest("collections");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<IList<CentraCollection>>(req, HttpMethod.Get);
        }

        public virtual async Task<IList<CentraProductStockList>> GetStock(CentraStockFilter centraStockFilter)
        {
            var req = PrepareRequest("stock");
            if (centraStockFilter != null) req.QueryParams.AddRange(centraStockFilter.ToParameters());

            return await ExecuteRequestAsync<IList<CentraProductStockList>>(req, HttpMethod.Get);
        }

        public virtual async Task<CentraOrder> UpdateAsync(ProductUpdateOptions productUpdateOptions)
        {
            var req = PrepareRequest("stock");
            var body = productUpdateOptions.ToDictionary();
            var content = new JsonContent(new
            {
                body
            });
            return await ExecuteRequestAsync<CentraOrder>(req, HttpMethod.Post, content);
        }
    }
}