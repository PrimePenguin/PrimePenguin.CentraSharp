using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimePenguin.CentraSharp.Infrastructure
{
    public class RequestUri
    {
        private readonly Uri _url;

        public RequestUri(Uri uri)
        {
            _url = uri;
        }

        public Dictionary<string, object> QueryParams { get; } = new Dictionary<string, object>();

        public Uri ToUri()
        {
            // Combine the url and the query param dictionary into a uri
            var query = QueryParams.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value.ToString())}");
            var ub = new UriBuilder(_url)
            {
                Query = string.Join("&", query)
            };

            return ub.Uri;
        }

        public override string ToString()
        {
            return ToUri().ToString();
        }
    }
}