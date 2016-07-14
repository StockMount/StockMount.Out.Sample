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
    public class GeneralService : BaseServiceHelper
    {
        public static OperationResult GetCurrencies(GetCurrencyCriteria getCurrencyCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("General/GetCurrencies", getCurrencyCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<List<Currency>>(operationResult.Response.ToString());
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