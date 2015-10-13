using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StockMount.Out.Sample.Models;
using StockMount.Out.Sample.Utils.Language;

namespace StockMount.Out.Sample.Controllers
{
    public class GuideController : BaseController
    {
        //
        // GET: /Guide/

        public ActionResult ErrorList()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.ErrorList, GetRequestCulture());

            return View();
        }

        public ActionResult Documentation()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.Documentation, GetRequestCulture());

            return View();
        }

        public ActionResult Licenses()
        {
            ViewBag.Message = Message.GetMessage(MessageCode.Documentation, GetRequestCulture());
            if (GetRequestCulture() == Constant.Culture.Turkish)
            {
                return View("LicensesTr");
                
            }
            else
            {
                return View("LicensesEn");
                
            }
        }

        
    }
}
