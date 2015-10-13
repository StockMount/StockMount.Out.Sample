using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class SetShipmentCriteria :CriteriaBase
    {
        public string IntegrationOrderCode { get; set; }
        public string IntegrationOrderDetailId { get; set; }
        public string ShipmentCompany { get; set; }
        public string ShipmentTrackingCode { get; set; }
        public string ShipmentBranch { get; set; }

        public string ShipmentCompanyName { get; set; }

        public string CampaignNumber { get; set; }

        public long ShipmentCompanyId { get; set; }

        public string ShipmentMethod { get; set; }

        public int OrderDetailId { get; set; }

        public bool SendPhoneMessage { get; set; }
        public bool SendShipmentInformation { get; set; }

        public UserMessage UserMessage { get; set; }

        public int StoreId { get; set; }
        public int IntegrationId { get; set; }
        public int OrderId { get; set; }
    }
}