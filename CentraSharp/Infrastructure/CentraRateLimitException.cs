using System.Collections.Generic;
using System.Net;

namespace PrimePenguin.CentraSharp.Infrastructure
{
    /// <summary>
    /// An exception thrown when an API call has reached Centra's rate limit.
    /// </summary>
    public class CentraRateLimitException : CentraException
    {
        public CentraRateLimitException(HttpStatusCode httpStatusCode, Dictionary<string, IEnumerable<string>> errors,
            string message, string jsonError, string requestId) : base(httpStatusCode, errors, message, jsonError,
            requestId)
        {
        }
    }
}