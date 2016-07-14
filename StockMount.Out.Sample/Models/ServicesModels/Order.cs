using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Nickname { get; set; }
        public DateTime OrderDate { get; set; }
        public string IntegrationOrderCode { get; set; }
        public string OrderStatus { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string TaxAuthority { get; set; }
        public string TaxNumber { get; set; }
        public string City { get; set; }
        public string Notes { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail  
    {
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public string IntegrationProductCode { get; set; }
        public string IntegrationOrderDetailId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TaxRate { get; set; }
        public bool Invoiced { get; set; }
        public bool Unread { get; set; }
        public int SmUserSchemaId { get; set; }
        public string SchemaName { get; set; }
        public string Telephone { get; set; } 
        public string DeliveryTitle { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; } 
        public string CargoCompany { get; set; }
        public string CargoLabelCode { get; set; }
        public string CargoPayment { get; set; }
        public DateTime CargoDate { get; set; } 
        public string VariantProductCode { get; set; }
        public string VariantName1 { get; set; }
        public string VariantValue1 { get; set; }
        public string VariantName2 { get; set; }
        public string VariantValue2 { get; set; }
        public string VariantName3 { get; set; }
        public string VariantValue3 { get; set; } 
        public string VariantProductBarcode { get; set; } 
        public string VariantPhrase { get; set; }
    }

    public class StoreOrders  
    {
        public int TotalOrderCount { get; set; }
        public int TotalNotInvoicedCount { get; set; }
        public int TotalUnreadCount { get; set; }
        public List<Order> Orders { get; set; }
    }
}