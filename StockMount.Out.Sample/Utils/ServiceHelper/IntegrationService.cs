using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using StockMount.Out.Sample.Models;
using StockMount.Out.Sample.Models.ServicesModels;

namespace StockMount.Out.Sample.Utils.ServiceHelper
{
    public class IntegrationService : BaseServiceHelper
    {
        public static OperationResult GetStore(GetStoreCriteria getStoreCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/GetStore", getStoreCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<List<Store>>(operationResult.Response.ToString());
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }


        public static OperationResult GetSales(GetSaleCriteria getSaleCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/GetSales", getSaleCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<StoreOrders>(operationResult.Response.ToString());
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }



        public static OperationResult GetUserMessage(GetMessageCriteria getMessageCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/GetUserMessages", getMessageCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<UserMessages>(operationResult.Response.ToString());
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }

        public static OperationResult GetAllUserMessage(GetMessageCriteria getMessageCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/GetAllUserMessage", getMessageCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<UserMessages>(operationResult.Response.ToString());
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }
        public static OperationResult SendUserMessage(SetMessageCriteria setMessageCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/SendUserMessage", setMessageCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result; 
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }
        public static OperationResult SetMessageRead(SetMessageCriteria setMessageCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/SetMessageRead", setMessageCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }

        public static OperationResult ConfirmOrRejectOrderItem(ConfirmOrRejectOrderItemCriteria confirmOrRejectOrderItemCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/ConfirmOrRejectOrderItem", confirmOrRejectOrderItemCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result; 
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }

        public static OperationResult GetIntegrationShipmentCompanies(GetIntegrationShipmentCompanyCriteria getIntegrationShipmentCompanyCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/GetIntegrationShipmentCompanies", getIntegrationShipmentCompanyCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<List<IntegrationShipmentCompany>>(operationResult.Response.ToString());

                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }

        public static OperationResult SetOrderShipmentInformation(SetShipmentCriteria setShipmentCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Integration/SetOrderShipmentInformation", setShipmentCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<List<IntegrationShipmentCompany>>(operationResult.Response.ToString());

                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }
    }
}