using System.Collections.Generic;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class Product : CriteriaBase
    {
        public int ProductId { get; set; }
        public int ProductSourceId { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Subtitle { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public decimal TaxRate { get; set; }
        public string Model { get; set; }
        public string Category { get; set; }
        public int CurrencyId { get; set; }
        public List<ProductImage> Images { get; set; }
        public decimal MarketPrice { get; set; }
        public int Status { get; set; }
        public decimal Volume { get; set; }
        public decimal Height { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public string VariantName1 { get; set; }
        public string VariantName2 { get; set; }
        public string VariantName3 { get; set; }
        public string VariantName4 { get; set; }
        public List<ProductVariant> Variants { get; set; }
        public List<ProductSpec> Specs { get; set; }

    }

    public class ProductImage
    {
        public int Order { get; set; }
        public string Url { get; set; }
        public string Base64 { get; set; }
    }

    public class ProductVariant
    {
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Barcode { get; set; }
        public int CurrencyId { get; set; }

        public string ImageUrl { get; set; }
        public string ImageBase64 { get; set; }
        public string VariantValue1 { get; set; }
        public string VariantValue2 { get; set; }
        public string VariantValue3 { get; set; }
        public string VariantValue4 { get; set; }
        
    }

    public class ProductSpec
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
    }

    public class ProductSource
    {
        public int ProductSourceId { get; set; }
        public string Name { get; set; }
    }
}
