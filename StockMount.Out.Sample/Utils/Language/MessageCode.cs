using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Utils.Language
{
    public static class MessageCode
    {

        public const string General = "General";
        public const string SiteTitle = "SiteTitle";
        public const string Home = "Home";
        public const string About = "About";
        public const string Contact = "Contact";
        public const string Career = "Career";
        public const string ErrorList = "ErrorList";
        public const string Authentication = "Authentication";
        public const string Guide = "Guide";


        public const string ServicesList = "ServicesList";


        public const string DoLoginService = "DoLoginService";
        public const string GetStoresService = "GetStoresService";
        public const string GetSalesService = "GetSalesService";
        public const string GetMessagesService = "GetMessagesService";
        public const string GetAllUserMessageService = "GetAllUserMessageService";
        public const string SendUserMessageService = "SendUserMessageService";
        public const string ConfirmOrRejectOrderItemService = "ConfirmOrRejectOrderItemService";
        public const string GetIntegrationShipmentCompaniesService = "GetIntegrationShipmentCompaniesService";
        public const string SetOrderShipmentInformationService = "SetOrderShipmentInformationService";
        public const string SetMessageReadService = "SetMessageReadService";

        //currency
        public const string GetCurrenciesService = "GetCurrenciesService";

        
        //product
        public const string GetProductService = "GetProductService";
        public const string DeleteProductService = "DeleteProductService";
        public const string AddProductService = "AddProductService";
        public const string UpdateProductService = "UpdateProductService";
        public const string StopProductService = "StopProductService";
        public const string GetProductCategoriesService = "GetProductCategoriesService";
        public const string GetProductSourcesService = "GetProductSourcesService";
     
        public const string Product = "Product";

        public const string ProductSourceId = "ProductSourceId";

        public const string Barcode = "Barcode";

        public const string Name = "Name";

        public const string Subtitle = "Subtitle";

        public const string Price = "Price";

        public const string Quantity = "Quantity";

        public const string Brand = "Brand";

        public const string TaxRate = "TaxRate";

        public const string Model = "Model";

        public const string Category = "Category";

        public const string CurrencyId = "CurrencyId";

        public const string MarketPrice = "MarketPrice";

        public const string Volume = "Volume";

        public const string Height = "Height";

        public const string Length = "Length";

        public const string Width = "Width";

        public const string VariantName = "VariantName";

        public const string Url = "Url";

        public const string Images = "Images";

        public const string Variants = "Variants";

        public const string ImageUrl = "ImageUrl";

        public const string VariantValue = "VariantValue";

        public const string Value = "Value";
        public const string Specs = "Specs";
       

        public const string DoLoginServiceDescription = "DoLoginServiceDescription";
        public const string GetStoresServiceDescription = "GetStoresServiceDescription";
        public const string GetSalesServiceDescription = "GetSalesServiceDescription";
        public const string GetMessagesServiceDescription = "GetMessagesServiceDescription";
        public const string SendUserMessageServiceDescription = "SendUserMessageServiceDescription";
        public const string ConfirmOrRejectOrderItemDescription = "ConfirmOrRejectOrderItemServiceDescription";
        public const string GetAllUserMessageServiceDescription = "GetAllUserMessageServiceDescription";
        public const string GetIntegrationShipmentCompaniesServiceDescription = "GetIntegrationShipmentCompaniesServiceDescription";
        public const string SetOrderShipmentInformationServiceDescription = "SetOrderShipmentInformationServiceDescription";
        public const string SetMessageReadServiceDescription = "SetMessageReadServiceDescription";
        
        //currency
        public const string GetCurrenciesServiceDescription = "GetCurrenciesServiceDescription";

        //product
        public const string GetProductServiceDescription = "GetProductServiceDescription";
        public const string DeleteProductServiceDescription = "DeleteProductServiceDescription";
        public const string AddProductServiceDescription = "AddProductServiceDescription";
        public const string UpdateProductServiceDescription = "UpdateProductServiceDescription";
        public const string StopProductServiceDescription = "StopProductServiceDescription";
        public const string GetProductSourcesServiceDescription = "GetProductSourcesServiceDescription";
        public const string GetProductCategoriesServiceDescription = "GetProductCategoriesServiceDescription";
        public const string ProductId = "ProductId";

        public const string Code = "Code";

        public const string Description = "Description";
        public const string RequestType = "RequestType";
        public const string RequestUrl = "RequestUrl";
        public const string TestService = "TestService";
        public const string Execute = "Execute";



        public const string UserName = "UserName";
        public const string Password = "Password";


        public const string StoreId = "StoreId";
        public const string IntegrationId = "IntegrationId";

        public const string OrderStatus = "OrderStatus";
        public const string Status = "Status";


        public const string GgWaitingPayment = "GgWaitingPayment";
        public const string GgWaitingCargo = "GgWaitingCargo";
        public const string GgWaitingConfirmation = "GgWaitingConfirmation";
        public const string GgMoneyTransfer = "GgMoneyTransfer";
        public const string GgReturnedOrder = "GgReturnedOrder";
        public const string GgCompleted = "GgCompleted";


        public const string N11NewOrder = "N11NewOrder";
        public const string N11ApprovedOrder = "N11ApprovedOrder";
        public const string N11Shipped = "N11Shipped";
        public const string N11Rejected = "N11Rejected";
        public const string N11Delivered = "N11Delivered";
        public const string N11Completed = "N11Completed";

        public const string SmNewOrder = "SmNewOrder";
        public const string SmApprovedOrder = "SmApprovedOrder";
        public const string SmShipped = "SmShipped";
        public const string SmRejected = "SmRejected";
        public const string SmDelivered = "SmDelivered";
        public const string SmCompleted = "SmCompleted";

        public const string SpPaymentConfirmation = "SpPaymentConfirmation";
        public const string SpWaitingShipment = "SpWaitingShipment";
        public const string SpShipmentNotReceived = "SpShipmentNotReceived";
        public const string SpShipmentOnWay = "SpShipmentOnWay";
        public const string SpCustomerConfirmed = "SpCustomerConfirmed";
        public const string SpCustomerReturned = "SpCustomerReturned";
        public const string SpMoneyTransfer = "SpMoneyTransfer";
        public const string SpMoneyRefund = "SpMoneyRefund";
        public const string SpOrderSuspensed = "SpOrderSuspensed";
        public const string SpSellerCancelled = "SpSellerCancelled";
        public const string SpCustomerCancelled = "SpCustomerCancelled";
        public const string SpSanalPazarCancelled = "SpSanalPazarCancelled";

        public const string MessageType = "MessageType";

        public const string Inbox = "Inbox";
        public const string Sent = "Sent";

        public const string UserMessageId = "UserMessageId";
        public const string UserMessageCode = "UserMessageCode";
        public const string From = "From";
        public const string To = "To";
        public const string Subject = "Subject";
        public const string Message = "Message";
        public const string SetMessageRead = "SetMessageRead";


        public const string Required = "Required";


        public const string User = "User";
        public const string BiggestIntegrationMessageId = "BiggestIntegrationMessageId";
        public const string SmallestIntegrationMessageId = "SmallestIntegrationMessageId";


        public const string SelectIntegration = "SelectIntegration";

        public const string SmallestOrderDetailId = "SmallestOrderDetailId";
        public const string BiggestOrderDetailId = "BiggestOrderDetailId";


        public const string IntegrationOrderDetailId = "IntegrationOrderDetailId";


        public const string Confirm = "Confirm";
        public const string Reject = "Reject";


        public const string IntegrationOrderCode = "IntegrationOrderCode";
        public const string ShipmentCompany = "ShipmentCompany";
        public const string ShipmentTrackingCode = "ShipmentTrackingCode";
        public const string ShipmentBranch = "ShipmentBranch";
        public const string ShipmentCompanyName = "ShipmentCompanyName";
        public const string CampaignNumber = "CampaignNumber";
        public const string ShipmentCompanyId = "ShipmentCompanyId";
        public const string ShipmentMethod = "ShipmentMethod";
        public const string OrderDetailId = "OrderDetailId";
        public const string SendPhoneMessage = "SendPhoneMessage";
        public const string SendShipmentInformation = "SendShipmentInformation";
        public const string UserMessage = "UserMessage";
        public const string OrderId = "OrderId";



        public const string Error00001 = "Error00001";
        public const string Error00002 = "Error00002";
        public const string Error00003 = "Error00003";
        public const string Error00004 = "Error00004";
        public const string Error00005 = "Error00005";
        public const string Error00006 = "Error00006";
        public const string Error10001 = "Error10001";
        public const string Error99999 = "Error99999";
        public const string Error60001 = "Error60001";
        public const string Error60002 = "Error60002";

        public const string Language = "Language";



        public const string Documentation = "Documentation";


        public const string HomePageDescription = "HomePageDescription";


        public const string Phone = "Phone";
        public const string Fax = "Fax";
        public const string Email = "Email";
        public const string Owner = "Owner";

        public const string Licenses = "Licenses";

        public const string Links = "Links";
        public const string StockMountSite = "StockMountSite";
        public const string StockMountGitHub = "StockMountGitHub";


        public const string BiggestIntegrationMessageIdDescription = "BiggestIntegrationMessageIdDescription";
        public const string SmallestIntegrationMessageIdDescription = "SmallestIntegrationMessageIdDescription";


        public const string SmallestOrderDetailIdDescription = "SmallestOrderDetailIdDescription";
        public const string BiggestOrderDetailIdDescription = "BiggestOrderDetailIdDescription";



        public const string RowsByPage = "RowsByPage";
        public const string PageIndexDescription = "PageIndexDescription";
        public const string PageIndex = "PageIndex";
        public const string RowsByPageDescription = "RowsByPageDescription";


        public const string Open = "Open";
        public const string Unpacked = "Unpacked";



        public const string GetProductsServiceDescription = "GetProductsServiceDescription";

        public const string All = "All";

        public const string GetProductsService = "GetProductsService";
    }
}