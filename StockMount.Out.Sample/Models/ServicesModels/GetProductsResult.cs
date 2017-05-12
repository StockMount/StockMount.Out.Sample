using System.Collections.Generic;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class GetProductsResult
    {
        public int TotalProductCount { get; set; }
        public int FilteredProductCount { get; set; }
        public List<Product> Products { get; set; }
    }
}