using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;

namespace PrimePenguin.CentraSharp.Services.Brand
{
    /// <summary>
    /// A service for manipulating Centra products Campaign.
    /// </summary>
    public class CampaignService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CampaignService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Get BrandsList and FilterBy Id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<string>> GetBrands(BrandFilter options)
        {
            var req = PrepareRequest("brands");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<IList<string>>(req, HttpMethod.Get);
        }
    }
}