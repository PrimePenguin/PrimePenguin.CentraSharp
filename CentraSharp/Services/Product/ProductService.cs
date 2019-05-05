using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;

namespace PrimePenguin.CentraSharp.Services.Product
{

    /// <summary>
    /// A service for manipulating Centra products.
    /// </summary>
    public class ProductService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop. Use ShopAPI token from centra store</param>
        public ProductService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Get List Of Products
        /// </summary>
        /// <returns></returns>
        [Obsolete(" Use ShopAPI token from centra store")]
        public virtual async Task<ProductsList> ListAsync()
        {
            var req = PrepareRequest("products");

            return await ExecuteRequestAsync<ProductsList>(req, HttpMethod.Get);
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

        /// <summary>
        /// Get Stock of Product
        /// </summary>
        /// <param name="centraStockFilter"></param>
        /// <returns></returns>
        public virtual async Task<ProductStockList> GetStock(StockFilter centraStockFilter = null)
        {
            var req = PrepareRequest("stock");
            if (centraStockFilter != null) req.QueryParams.AddRange(centraStockFilter.ToParameters());

            return await ExecuteRequestAsync<ProductStockList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="productUpdateOptions"></param>
        /// <returns></returns>
        public virtual async Task<ProductUpdateRsponse> UpdateAsync(ProductUpdateFilter productUpdateOptions)
        {
            var req = PrepareRequest("stock");
            var body = productUpdateOptions.ToDictionary();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(body);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            return await ExecuteRequestAsync<ProductUpdateRsponse>(req, HttpMethod.Post, httpContent);
        }
    }
}