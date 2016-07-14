using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class Criteria
    {
        
    }

    public class ConfirmOrRejectOrderItemCriteria : CriteriaBase
    {
        public int StoreId { get; set; }
        public int IntegrationId { get; set; }
        public string IntegrationOrderDetailId { get; set; }
        public byte Status { get; set; }  //  1: confirm   2: reject 
    }

    public class GetIntegrationShipmentCompanyCriteria : CriteriaBase
    {
        public int IntegrationId { get; set; }

    }

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

    public class GetSaleCriteria : CriteriaBase
    {
        public int StoreId { get; set; }
        public string OrderStatus { get; set; }
        public int SmallestOrderDetailId { get; set; }
        public int BiggestOrderDetailId { get; set; }
        public int RowsByPage { get; set; }
        public int PageIndex { get; set; }
    }

    public class GetStoreCriteria : CriteriaBase
    {
        public int StoreId { get; set; }
        public int IntegrationId { get; set; }
    }

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

    public class SetShipmentCriteria : CriteriaBase
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

    public class GetCurrencyCriteria : CriteriaBase
    {
    }

    public class GetProductCriteria : CriteriaBase
    {
        public int ProductId { get; set; }

    }

    public class GetProductSourcesCriteria : CriteriaBase
    {
        
    }

    public class GetProductCategoriesCriteria : CriteriaBase
    {
        public int ProductSourceId { get; set; }
    }
}