﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace PrimePenguin.CentraSharp.Entities
{
    public class CentraCategories
    {
        /// <summary>
        /// MetaTitle
        /// </summary>
        [JsonProperty("metaTitle")]
        public string MetaTitle { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// MetaDescription
        /// </summary>
        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }

        /// <summary>
        /// SortString
        /// </summary>
        [JsonProperty("sortString")]
        public string SortString { get; set; }

        /// <summary>
        /// SortOrder
        /// </summary>
        [JsonProperty("sortOrder")]
        public string SortOrder { get; set; }

        /// <summary>
        /// Uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Localized
        /// </summary>
        [JsonProperty("localized")]
        public CentraLocalized Localized { get; set; }

        /// <summary>
        /// CompleteUri
        /// </summary>
        [JsonProperty("completeUri")]
        public string CompleteUri { get; set; }

        /// <summary>
        /// MetaKeywords
        /// </summary>
        [JsonProperty("metaKeywords")]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Category
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Products
        /// </summary>
        [JsonProperty("products")]
        public IList<string> Products { get; set; }
    }
}