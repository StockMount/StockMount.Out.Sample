using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using StockMount.Out.Sample.Models;
using StockMount.Out.Sample.Models.ServicesModels;

namespace StockMount.Out.Sample.Utils.ServiceHelper
{
    public class ProductService : BaseServiceHelper
    {
        public static OperationResult GetProduct(GetProductCriteria getProductCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Product/GetProduct", getProductCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<Product>(operationResult.Response.ToString());
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }

        public static OperationResult DeleteProduct(GetProductCriteria getProductCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Product/DeleteProduct", getProductCriteria).Result)
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

        public static OperationResult AddProduct(Product product)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Product/AddProduct", product).Result)
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
        public static OperationResult UpdateProduct(Product product)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Product/UpdateProduct", product).Result)
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
        public static OperationResult StopProduct(GetProductCriteria getProductCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Product/StopProduct", getProductCriteria).Result)
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
        public static OperationResult GetProductSources(GetProductSourcesCriteria getProductSourcesCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Product/GetProductSources", getProductSourcesCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<List<ProductSource>>(operationResult.Response.ToString());
                }
                else
                {
                    operationResult.ErrorMessage = String.Format("Status Code: {0}, Reason Pharse: {1}",
                        response.StatusCode, response.ReasonPhrase);
                }
            }
            return operationResult;
        }
        public static OperationResult GetProductCategories(GetProductCategoriesCriteria getProductCategoriesCriteriaCriteria)
        {
            //POST
            var client = GetClient();
            OperationResult operationResult = new OperationResult();

            using (HttpResponseMessage response = client.PostAsJsonAsync("Product/GetProductCategories", getProductCategoriesCriteriaCriteria).Result)
            {
                if (response.IsSuccessStatusCode)
                {
                    operationResult = response.Content.ReadAsAsync<OperationResult>().Result;
                    if (operationResult.Result)
                        operationResult.Response = JsonConvert.DeserializeObject<List<ProductCategory>>(operationResult.Response.ToString());
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