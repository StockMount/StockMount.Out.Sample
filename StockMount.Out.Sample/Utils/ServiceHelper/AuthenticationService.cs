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
    public class AuthenticationService :BaseServiceHelper
    {
        public static OperationResult Dologin(Login login)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("user/dologin", login).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result; 
                    if(operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<User>(operationResult.Response.ToString());
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