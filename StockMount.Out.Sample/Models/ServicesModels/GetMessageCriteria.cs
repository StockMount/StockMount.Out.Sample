using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class GetMessageCriteria : CriteriaBase
    {
        private GetMessageCriteria()
        {
            BiggestIntegrationMessageId = 0;
            SmallestIntegrationMessageId = 0;
        }

        public int MessageTypeId { get; set; }
        public int StoreId { get; set; }
        public string User { get; set; }

        public long BiggestIntegrationMessageId { get; set; }
        public long SmallestIntegrationMessageId { get; set; } 
    }
}