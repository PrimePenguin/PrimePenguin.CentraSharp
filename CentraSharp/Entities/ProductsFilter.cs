using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Extensions;
using PrimePenguin.CentraSharp.Services;

namespace PrimePenguin.CentraSharp.Entities
{
    public class ProductsFilter
    {

        /// <summary>
        /// product
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// uri
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// productSku
        /// </summary>
        [JsonProperty("productSku")]
        public string ProductSku { get; set; }

        /// <summary>
        /// group
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// groupName
        /// </summary>
        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        /// <summary>
        /// Brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// brandName
        /// </summary>
        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        /// <summary>
        /// Collection
        /// </summary>
        [JsonProperty("collection")]
        public string Collection { get; set; }

        /// <summary>
        /// CollectionName
        /// </summary>
        [JsonProperty("collectionName")]
        public string CollectionName { get; set; }

        /// <summary>
        /// folderName
        /// </summary>
        [JsonProperty("folderName")]
        public string FolderName { get; set; }

        /// <summary>
        /// foldersName
        /// </summary>
        [JsonProperty("foldersName")]
        public string FoldersName { get; set; }


        /// <summary>
        /// variantName
        /// </summary>
        [JsonProperty("variantName")]
        public string VariantName { get; set; }

        /// <summary>
        /// measurementChart
        /// </summary>
        [JsonProperty("measurementChart")]
        public string MeasurementChart { get; set; }

        /// <summary>
        /// MeasurementChartRows
        /// </summary>
        [JsonProperty("measurementChartRows")]
        public string MeasurementChartRows { get; set; }

        /// <summary>
        /// Weight
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// WeightUnit
        /// </summary>
        [JsonProperty("weightUnit")]
        public string WeightUnit { get; set; }

        /// <summary>
        /// excerpt
        /// </summary>
        [JsonProperty("excerpt")]
        public string Excerpt { get; set; }

        /// <summary>
        /// metaKeywords
        /// </summary>
        [JsonProperty("metaKeywords")]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// metaTitle
        /// </summary>
        [JsonProperty("metaTitle")]
        public string MetaTitle { get; set; }

        /// <summary>
        /// metaDescription
        /// </summary>
        [JsonProperty("metaDescription")]
        public string MetaDescription { get; set; }


        public ProductsFilter()
        {
            this.Markets = new Dictionary<string, Markets>();
            this.Items = new Dictionary<string, Itemslist>();
           // this.Categories = new Dictionary<string, Category>();
        }
        /// <summary>
        /// markets
        /// </summary>
        [JsonProperty("markets")]
        public Dictionary<string, Markets> Markets { get; set; }


        /// <summary>
        /// canonicalCategory
        /// </summary>
        [JsonProperty("canonicalCategory")]
        public string CanonicalCategory { get; set; }

        /// <summary>
        /// markets
        /// </summary>
        [JsonProperty("items")]
        public Dictionary<string, Itemslist> Items { get; set; }

        /// <summary>
        /// canonicallUri
        /// </summary>
        [JsonProperty("canonicallUri")]
        public string CanonicallUri { get; set; }

        /// <summary>
        /// Categories
        /// </summary>
        //[JsonProperty("categories")]
        //public Dictionary<string, Category> Categories { get; set; }


        public Dictionary<string, Category> Categories
        {
            get
            {
                var json = this.CategoriesJson.ToString();
                if (json.Length==2)
                {
                    return new Dictionary<string, Category>();
                }
                else
                {
                    return JsonConvert.DeserializeObject<Dictionary<string, Category>>(json);
                }
            }
        }

        [JsonProperty(PropertyName = "categories")]
        public object CategoriesJson { get; set; }
        /// <summary>
        /// relatedProducts
        /// </summary>
        [JsonProperty("relatedProducts")]
        public List<RelatedProducts> relatedProducts { get; set; }

        

    }

    public class RelatedProducts
    {
        public string product { get; set; }
        public string relation { get; set; }
    }
    public class Category
    {
        public string category { get; set; }
        public string name { get; set; }
        public string sortOrder { get; set; }
        public string uri { get; set; }
    }

    public class Markets
    {
        public Markets()
        {
            pricesByPricelist = new Dictionary<string, PriceList>();
        }

        public string stockOfAllItems { get; set; }
        public Dictionary<string, PriceList>  pricesByPricelist { get; set; }
    }

    public class Itemslist
    {
        public Itemslist()
        {
            StockByMarket = new Dictionary<string, string>();
        }
        public string item { get; set; }
    public string name { get; set; }
    public string ean { get; set; }
    public string sku { get; set; }
    public Dictionary<string, string> StockByMarket { get; set; }
    }


public class PriceList
    {
        public string price { get; set; }
        public double priceAsNumber { get; set; }
        public string priceBeforeDiscount { get; set; }
        public string priceReduction { get; set; }
        public int discountPercent { get; set; }
        public bool showAsOnSale { get; set; }
        public bool newProduct { get; set; }
    }
}