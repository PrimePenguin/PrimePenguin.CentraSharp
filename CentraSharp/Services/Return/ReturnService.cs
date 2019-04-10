using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Return
{
    /// <summary>
    ///     A service for manipulating Return of products.
    /// </summary>
    public class ReturnService : CentraService
    {
        /// <summary>
        ///     Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ReturnService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        ///     Creates a return for the order on the store.
        /// </summary>
        /// <param name="returnOptions"></param>
        /// <returns>The new <see cref="Order" />.</returns>
        public virtual async Task<CentraReturnResponse> CreateReturnAsync(CentraReturnOptions returnOptions)
        {
            var req = PrepareRequest("return");
            var body = returnOptions.ToDictionary();
            var content = new JsonContent(new
            {
                body
            });
            return await ExecuteRequestAsync<CentraReturnResponse>(req, HttpMethod.Post, content);
        }
    }
}