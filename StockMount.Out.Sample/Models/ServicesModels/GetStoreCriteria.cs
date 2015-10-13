using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class GetStoreCriteria :CriteriaBase
    {
        public int StoreId { get; set; }
        public int IntegrationId { get; set; }
    }
}