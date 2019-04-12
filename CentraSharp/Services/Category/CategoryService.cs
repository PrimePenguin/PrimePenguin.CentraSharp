using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;

namespace PrimePenguin.CentraSharp.Services.Category
{
    /// <summary>
    /// A service for manipulating Centra products category.
    /// </summary>
    public class CategoryService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CategoryService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Get CategoryList and FilterBy Id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<ProductCategory>> GetCategories(CategoryFilter options)
        {
            var req = PrepareRequest("categories");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<IList<ProductCategory>>(req, HttpMethod.Get);
        }
    }
}