using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
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
        /// Get CampaignList 
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<CampaignList>> GetCampaign()
        {
            var req = PrepareRequest("campaigns");
            return await ExecuteRequestAsync<List<CampaignList>>(req, HttpMethod.Get);
        }

        /// <summary>
        /// Get Campaign By Id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<CampaignList> GetCampaignById(int campaignId)
        {
            var options = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("campaignId", $"{campaignId}")
            };
            var req = PrepareRequest("campaigns");
            req.QueryParams.AddRange(options);
            return await ExecuteRequestAsync<CampaignList>(req, HttpMethod.Get);
        }
    }
}