using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrimePenguin.CentraSharp.Infrastructure;
using PrimePenguin.CentraSharp.Infrastructure.Policies;

namespace PrimePenguin.CentraSharp.Services
{
    public abstract class CentraService
    {
        private static readonly IRequestExecutionPolicy _globalExecutionPolicy = new DefaultRequestExecutionPolicy();

        private static readonly JsonSerializer Serializer = new JsonSerializer
            {DateParseHandling = DateParseHandling.DateTimeOffset};

        private readonly IRequestExecutionPolicy _executionPolicy;

        /// <summary>
        ///     Creates a new instance of <see cref="CentraService" />.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        protected CentraService(string myCentraUrl, string shopAccessToken)
        {
            ShopUri = BuildShopUri(myCentraUrl);
            AccessToken = shopAccessToken;

            // If there's a global execution policy it should be set as this instance's policy.
            // User can override it with instance-specific execution policy.
            _executionPolicy = _globalExecutionPolicy ?? new DefaultRequestExecutionPolicy();
        }

        private static HttpClient Client { get; } = new HttpClient();

        protected Uri ShopUri { get; set; }

        protected string AccessToken { get; set; }

        /// <summary>
        ///     Attempts to build a shop API <see cref="Uri" /> for the given shop. Will throw a <see cref="CentraException" /> if
        ///     the URL cannot be formatted.
        /// </summary>
        /// <param name="myCentraUrl">The shop's *.myCentraUrl.com URL.</param>
        /// <exception cref="CentraException">Thrown if the given URL cannot be converted into a well-formed URI.</exception>
        /// <returns>The shop's API <see cref="Uri" />.</returns>
        public static Uri BuildShopUri(string myCentraUrl)
        {
            if (Uri.IsWellFormedUriString(myCentraUrl, UriKind.Absolute) == false)
            {
                if (Uri.IsWellFormedUriString("https://" + myCentraUrl, UriKind.Absolute) == false)
                    throw new CentraException(
                        $"The given {nameof(myCentraUrl)} cannot be converted into a well-formed URI.");

                myCentraUrl = "https://" + myCentraUrl;
            }

            var builder = new UriBuilder(myCentraUrl)
            {
                Scheme = "https:",
                Port = 443 //SSL port
            };

            return builder.Uri;
        }

        protected RequestUri PrepareRequest(string path)
        {
            var ub = new UriBuilder(ShopUri)
            {
                Scheme = "https:",
                Port = 443,
                Path = $"api/all-everything/{path}"
            };

            return new RequestUri(ub.Uri);
        }

        /// <summary>
        ///     Prepares a request to the path and appends the shop's access token header if applicable.
        /// </summary>
        protected CloneableRequestMessage PrepareRequestMessage(RequestUri uri, HttpMethod method,
            HttpContent content = null)
        {
            var msg = new CloneableRequestMessage(uri.ToUri(), method, content);

            if (!string.IsNullOrEmpty(AccessToken)) msg.Headers.Add("API-Authorization", AccessToken);

            msg.Headers.Add("Accept", "application/json");

            return msg;
        }

        /// <summary>
        ///     Executes a request and returns the given type. Throws an exception when the response is invalid.
        ///     Use this method when the expected response is a single line or simple object that doesn't warrant its own class.
        /// </summary>
        /// <remarks>
        ///     This method will automatically dispose the
        ///     <paramref>
        ///         <name>baseRequestMessage</name>
        ///     </paramref>
        ///     when finished.
        /// </remarks>
        protected async Task<T> ExecuteRequestAsync<T>(RequestUri uri, HttpMethod method, HttpContent content = null,
            string rootElement = null)
        {
            using (var baseRequestMessage = PrepareRequestMessage(uri, method, content))
            {
                var policyResult = await _executionPolicy.Run(baseRequestMessage, async requestMessage =>
                {
                    var request = Client.SendAsync(requestMessage);

                    using (var response = await request)
                    {
                        var rawResult = await response.Content.ReadAsStringAsync();

                        //Check for and throw exception when necessary.
                        CheckResponseExceptions(response, rawResult);

                        // This method may fail when the method was Delete, which is intendend.
                        // Delete methods should not be parsing the response JSON and should instead
                        // be using the non-generic ExecuteRequestAsync.
                        var reader = new JsonTextReader(new StringReader(rawResult));
                        var data = Serializer.Deserialize<JObject>(reader);
                        var result = data.ToObject<T>();
                        return new RequestResult<T>(response, result, rawResult);
                    }
                });

                return policyResult;
            }
        }

        /// <summary>
        ///     Checks a response for exceptions or invalid status codes. Throws an exception when necessary.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="rawResponse"></param>
        public static void CheckResponseExceptions(HttpResponseMessage response, string rawResponse)
        {
            var statusCode = (int) response.StatusCode;

            // No error if response was between 200 and 300.
            if (statusCode >= 200 && statusCode < 300) return;

            var requestIdHeader =
                response.Headers.FirstOrDefault(h => h.Key.Equals("X-Request-Id", StringComparison.OrdinalIgnoreCase));
            var requestId = requestIdHeader.Value?.FirstOrDefault();
            var code = response.StatusCode;

            // If the error was caused by reaching the API rate limit, throw a rate limit exception.
            if ((int) code == 429 /* Too many requests */)
            {
                const string listMessage = "Exceeded 2 calls per second for api client. Reduce request rates to resume uninterrupted service.";
                var rateLimitMessage = $"Error: {listMessage}";

                // centra used to return JSON for rate limit exceptions, but then made an unannounced change and started returing HTML. 
                // This dictionary is an attempt at preserving what was previously returned.
                var rateLimitErrors = new Dictionary<string, IEnumerable<string>>
                {
                    {"Error", new List<string> {listMessage}}
                };

                throw new CentraRateLimitException(code, rateLimitErrors, rateLimitMessage, rawResponse, requestId);
            }

            var errors = ParseErrorJson(rawResponse);
            var message = $"Response did not indicate success. Status: {(int) code} {response.ReasonPhrase}.";

            if (errors == null)
            {
                errors = new Dictionary<string, IEnumerable<string>>
                {
                    {
                        $"{(int) code} {response.ReasonPhrase}",
                        new[] {message}
                    }
                };
            }
            else
            {
                var firstError = errors.First();

                message = $"{firstError.Key}: {string.Join(", ", firstError.Value)}";
            }

            throw new CentraException(code, errors, message, rawResponse, requestId);
        }

        /// <summary>
        ///     Parses a JSON string for Centra API errors.
        /// </summary>
        /// <returns>Returns null if the JSON could not be parsed into an error.</returns>
        public static Dictionary<string, IEnumerable<string>> ParseErrorJson(string json)
        {
            if (string.IsNullOrEmpty(json)) return null;

            var errors = new Dictionary<string, IEnumerable<string>>();

            try
            {
                var parsed = JToken.Parse(string.IsNullOrEmpty(json) ? "{}" : json);

                // Errors can be any of the following:
                // 1. { errors: "some error message"}
                // 2. { errors: { "order" : "some error message" } }
                // 3. { errors: { "order" : [ "some error message" ] } }
                // 4. { error: "invalid_request", error_description:"The authorization code was not found or was already used" }

                if (parsed.Any(p => p.Path == "error") && parsed.Any(p => p.Path == "error_description"))
                {
                    // Error is type #4
                    var description = parsed["error_description"];

                    errors.Add("invalid_request", new List<string> {description.Value<string>()});
                }
                else if (parsed.Any(x => x.Path == "errors"))
                {
                    var parsedErrors = parsed["errors"];

                    //errors can be either a single string, or an array of other errors
                    if (parsedErrors.Type == JTokenType.String)
                        errors.Add("Error", new List<string> {parsedErrors.Value<string>()});
                    else
                        foreach (var val in parsedErrors.Values())
                        {
                            var name = val.Path.Split('.').Last();
                            var list = new List<string>();

                            switch (val.Type)
                            {
                                case JTokenType.String:
                                    list.Add(val.Value<string>());
                                    break;
                                case JTokenType.Array:
                                    list = val.Values<string>().ToList();
                                    break;
                                case JTokenType.None:
                                    break;
                                case JTokenType.Object:
                                    break;
                                case JTokenType.Constructor:
                                    break;
                                case JTokenType.Property:
                                    break;
                                case JTokenType.Comment:
                                    break;
                                case JTokenType.Integer:
                                    break;
                                case JTokenType.Float:
                                    break;
                                case JTokenType.Boolean:
                                    break;
                                case JTokenType.Null:
                                    break;
                                case JTokenType.Undefined:
                                    break;
                                case JTokenType.Date:
                                    break;
                                case JTokenType.Raw:
                                    break;
                                case JTokenType.Bytes:
                                    break;
                                case JTokenType.Guid:
                                    break;
                                case JTokenType.Uri:
                                    break;
                                case JTokenType.TimeSpan:
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException();
                            }
                            errors.Add(name, list);
                        }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                errors.Add(e.Message, new List<string> {json});
            }

            // KVPs are structs and can never be null. Instead, check if the first error equals the default kvp value.
            return errors.FirstOrDefault().Equals(default(KeyValuePair<string, IEnumerable<string>>)) ? null : errors;
        }
    }
}