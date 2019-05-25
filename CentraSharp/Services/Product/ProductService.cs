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
        public virtual async Task<ProductsList> ListAsync(ProductListFilter options = null)
        {
            var req = PrepareRequest("products");

            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<ProductsList>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get Stock of Product
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public virtual async Task<ProductStockList> GetStock(ProductListFilter options = null)
        {
            var req = PrepareRequest("stock");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());

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