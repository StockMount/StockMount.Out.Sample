﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using StockMount.Out.Sample.Models;

namespace StockMount.Out.Sample.Controllers
{
    public class BaseController : Controller
    {
        protected string RequestCulture;
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            RequestCulture = GetRequestCulture();
            RequestCulture = RequestCulture ?? Constant.Culture.English;
             

            Thread.CurrentThread.CurrentCulture = new CultureInfo(RequestCulture);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
             

        }

        /// <summary>
        /// --------------
        /// </summary>
        /// <returns></returns>
        protected string GetRequestCulture()
        {

            string userCulture = Constant.Culture.English;
            try
            {
                userCulture = HttpContext.Request.UserLanguages.FirstOrDefault();
                if (!Constant.Culture.Turkish.Contains(userCulture))
                    userCulture = Constant.Culture.English;
            }
            catch (Exception)
            {
                 
            }
            
            if (Request.Cookies["culture"] != null)
            {
                HttpCookie cultureCookie = Request.Cookies["culture"];

                userCulture = cultureCookie.Value;
            }
             
            return userCulture;
        }
    }

    

}
