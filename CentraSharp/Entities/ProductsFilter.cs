using System.Collections.Generic;
using Newtonsoft.Json;

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


        public Dictionary<string, Category> Categories
        {
            get
            {
                var json = this.CategoriesJson.ToString();
                if (json.Length == 2)
                {
                    return new Dictionary<string, Category>();
                }
                else
                {
                    return JsonConvert.DeserializeObject<Dictionary<string, Category>>(json);
                }
            }
        }

        /// <summary>
        /// CategoriesJson
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public object CategoriesJson { get; set; }

        /// <summary>
        /// RelatedProducts
        /// </summary>
        [JsonProperty("relatedProducts")]
        public List<RelatedProducts> RelatedProducts { get; set; }

    }

    public class RelatedProducts
    {
        /// <summary>
        /// Product
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// Relation
        /// </summary>
        [JsonProperty("relation")]
        public string Relation { get; set; }
    }
    public class Category
    {
        /// <summary>
        /// Categories
        /// </summary>
        [JsonProperty("category")]
        public string Categories { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

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
    }

    public class Markets
    {
        public Markets()
        {
            PricesByPricelist = new Dictionary<string, PriceList>();
        }

        /// <summary>
        /// StockOfAllItems
        /// </summary>
        [JsonProperty("stockOfAllItems")]
        public string StockOfAllItems { get; set; }

        /// <summary>
        /// PricesByPricelist
        /// </summary>
        [JsonProperty("pricesByPricelist")]
        public Dictionary<string, PriceList> PricesByPricelist { get; set; }
    }

    public class Itemslist
    {
        public Itemslist()
        {
            StockByMarket = new Dictionary<string, string>();
        }

        /// <summary>
        /// item
        /// </summary>
        [JsonProperty("item")]
        public string Item { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// ean
        /// </summary>
        [JsonProperty("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// sku
        /// </summary>
        [JsonProperty("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// StockByMarket
        /// </summary>
        public Dictionary<string, string> StockByMarket { get; set; }
    }


    public class PriceList
    {
        /// <summary>
        /// price
        /// </summary>
        [JsonProperty("price")]
        public string Price { get; set; }

        /// <summary>
        /// PriceAsNumber
        /// </summary>
        [JsonProperty("priceAsNumber")]
        public double PriceAsNumber { get; set; }

        /// <summary>
        /// PriceBeforeDiscount
        /// </summary>
        [JsonProperty("priceBeforeDiscount")]
        public string PriceBeforeDiscount { get; set; }

        /// <summary>
        /// priceReduction
        /// </summary>
        [JsonProperty("priceReduction")]
        public string PriceReduction { get; set; }

        /// <summary>
        /// discountPercent
        /// </summary>
        [JsonProperty("discountPercent")]
        public int DiscountPercent { get; set; }

        /// <summary>
        /// ShowAsOnSale
        /// </summary>
        [JsonProperty("showAsOnSale")]
        public bool ShowAsOnSale { get; set; }

        /// <summary>
        /// newProduct
        /// </summary>
        [JsonProperty("newProduct")]
        public bool NewProduct { get; set; }
    }
}