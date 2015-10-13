using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Web;

namespace StockMount.Out.Sample.Utils.Language
{
    public class Message
    {
        public static string GetMessage(string messageCode, string culture, bool returnEmpty = false)
        {
            ResourceManager resourceManager = new ResourceManager("StockMount.Out.Sample.Utils.Language.Glossary", Assembly.GetExecutingAssembly());
            string message = "";

            try
            {
                message = resourceManager.GetString(messageCode, new CultureInfo(culture));

                if (String.IsNullOrEmpty(message) && !returnEmpty)
                {
                    message = messageCode;
                }


                message = message ?? String.Empty;
            }
            catch (Exception)
            {
                // message = resourceManager.GetString(MessageCode.NotFound, new CultureInfo(culture));
            }
            return message;
        } 
    }
}