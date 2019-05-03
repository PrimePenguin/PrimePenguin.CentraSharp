using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using PrimePenguin.CentraSharp.Entities;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Filters;

namespace PrimePenguin.CentraSharp.Services.Brand
{
    /// <summary>
    /// A service for manipulating Centra products Brand.
    /// </summary>
    public class BrandService : CentraService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public BrandService(string myCentraUrl, string shopAccessToken) : base(myCentraUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Get BrandsList and FilterBy Id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<Dictionary<string, Brands>> GetBrands(BrandFilter options)
        {
            var req = PrepareRequest("brands");
            if (options != null) req.QueryParams.AddRange(options.ToParameters());

            return await ExecuteRequestAsync<Dictionary<string, Brands>>(req, HttpMethod.Get);
        }


        /// <summary>
        /// Get MeasurementCharts and FilterBy Id
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IList<MeasurementCharts>> GetMeasurementCharts(int measurementChartId)
        {
            var options = new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>("measurementChartId", $"{measurementChartId}")
            };
            var req = PrepareRequest("measurement-charts");
            if (measurementChartId != 0)
            {
                req.QueryParams.AddRange(options);
            }

            return await ExecuteRequestAsync<IList<MeasurementCharts>>(req, HttpMethod.Get);
        }
    }
}