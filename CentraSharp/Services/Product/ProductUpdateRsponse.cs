using System.Collections.Generic;
using Newtonsoft.Json;
using PrimePenguin.CentraSharp.Infrastructure;

namespace PrimePenguin.CentraSharp.Services.Product
{
    public class ProductUpdateRsponse
    {
        public class Errors
        {
            public IList<string> productsNotFound { get; set; }
        }

            public string status { get; set; }
            public string msg { get; set; }
            public Errors errors { get; set; }
    }
}