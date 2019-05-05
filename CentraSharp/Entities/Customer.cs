using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class Customer
    {
        /// <summary>
        /// CustomerId
        /// </summary>
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Address1
        /// </summary>
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        /// <summary>
        /// Address2
        /// </summary>
        [JsonProperty("address2")]
        public string Address2 { get; set; }

        /// <summary>
        /// ZipCode
        /// </summary>
        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// PhoneNumber
        /// </summary>
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Newsletter
        /// </summary>
        [JsonProperty("newsletter")]
        public bool Newsletter { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// Registered
        /// </summary>
        [JsonProperty("registered")]
        public bool Registered { get; set; }

        /// <summary>
        /// Consents
        /// </summary>
        [JsonProperty("consents")]
        public List<Consent> Consents { get; set; }

        /// <summary>
        /// Created
        /// </summary>
        [JsonProperty("created")]
        public string Created { get; set; }

        /// <summary>
        /// Modified
        /// </summary>
        [JsonProperty("modified")]
        public string Modified { get; set; }
    }

    public class Consent
    {
        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Consented
        /// </summary>
        [JsonProperty("consented")]
        public bool Consented { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Created
        /// </summary>
        [JsonProperty("created")]
        public DateTimeOffset? Created { get; set; }

        /// <summary>
        /// Modified
        /// </summary>
        [JsonProperty("modified")]
        public DateTimeOffset? Modified { get; set; }
    }
}