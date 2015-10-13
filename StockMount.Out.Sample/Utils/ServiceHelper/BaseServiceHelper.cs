using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;

namespace StockMount.Out.Sample.Utils.ServiceHelper
{
    public class BaseServiceHelper
    {
        public static HttpClient GetClient()
        {
            HttpClient httpClient = new HttpClient { BaseAddress = new Uri(System.Configuration.ConfigurationManager.AppSettings["StockMountApiUrl"] ?? String.Empty) };

            #region Authentication
            string authInfo = "a:1";
            authInfo = Convert.ToBase64String(Encoding.Default.GetBytes(authInfo));
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authInfo);
            #endregion

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }
    }
}