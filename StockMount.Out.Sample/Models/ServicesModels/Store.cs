using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public int IntegrationId { get; set; }
        public string IntegrationName { get; set; }
    }
}