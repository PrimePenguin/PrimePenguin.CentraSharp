using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class PaymentTerms
    {
        /// <summary>
        /// Id of the specific payment terms object.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the specific payment terms object.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Description of the specific payment terms object.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}