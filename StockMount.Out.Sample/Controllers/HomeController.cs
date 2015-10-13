﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockMount.Out.Sample.Utils.Language;

namespace StockMount.Out.Sample.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        #region Authentication ..
        public ActionResult DoLogin()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.DoLoginService, GetRequestCulture());

            return View();
        }
        #endregion 

        #region  Integration ..
        public ActionResult GetStores()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.GetStoresService, GetRequestCulture());

            return View();
        }

        public ActionResult GetSales()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.GetSalesService, GetRequestCulture());

            return View();
        }

  
        public ActionResult GetMessages()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.GetMessagesService, GetRequestCulture());

            return View();
        }


        public ActionResult GetAllUserMessage()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.GetAllUserMessageService, GetRequestCulture());

            return View();
        }

        public ActionResult SendUserMessage()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.SendUserMessageService, GetRequestCulture());

            return View();
        }
        public ActionResult SetMessageRead()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.SetMessageReadService, GetRequestCulture());

            return View();
        }

        
        public ActionResult ConfirmOrRejectOrderItem()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.SendUserMessageService, GetRequestCulture());

            return View();
        }

        public ActionResult GetIntegrationShipmentCompanies()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.GetIntegrationShipmentCompaniesService, GetRequestCulture());

            return View();
        }
        public ActionResult SetOrderShipmentInformation()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.SetOrderShipmentInformationService, GetRequestCulture());

            return View();
        }

        


        #endregion 

        

    }
}
