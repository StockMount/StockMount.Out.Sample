using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class ConfirmOrRejectOrderItemCriteria :CriteriaBase
    {
        public int StoreId { get; set; }
        public int IntegrationId { get; set; }
        public string IntegrationOrderDetailId { get; set; }
        public byte Status { get; set; }  //  1: confirm   2: reject 
    }
}