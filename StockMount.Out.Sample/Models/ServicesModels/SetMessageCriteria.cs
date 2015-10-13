using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class SetMessageCriteria : CriteriaBase
    {
        public long UserMessageId { get; set; }
        public string UserMessageCode { get; set; }
        public bool SetMessageRead { get; set; }
        public string Message { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public int StoreId { get; set; }
        public int IntegrationId { get; set; }
        public string Subject { get; set; }
    }
}