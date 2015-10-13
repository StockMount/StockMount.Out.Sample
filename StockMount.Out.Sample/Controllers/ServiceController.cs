using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using StockMount.Out.Sample.Models;
using StockMount.Out.Sample.Models.ServicesModels;
using StockMount.Out.Sample.Utils.Language;

namespace StockMount.Out.Sample.Controllers
{
    public class ServiceController : BaseController
    {
        //
        // GET: /Service/
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.RouteData.Values["action"].ToString().ToLower() != ("DoLogin").ToLower() && Session["ApiCode"] == null)
            {
                OperationResult result = new OperationResult();
                result.ErrorCode = "00001";
                result.ErrorMessage = Message.GetMessage(MessageCode.Error00001, GetRequestCulture());
                
                filterContext.Result = Json(new
                {
                    Result = result
                }, JsonRequestBehavior.AllowGet);
        
            }
                 
        }

         
        public JsonResult DoLogin(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                Login loginModel = JsonConvert.DeserializeObject<Login>(param);
                result =
                    Utils.ServiceHelper.AuthenticationService.Dologin(loginModel);
                if (result.Result)
                    Session["ApiCode"] = (result.Response as User).ApiCode;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStores(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                GetStoreCriteria getStoreCriteria = JsonConvert.DeserializeObject<GetStoreCriteria>(param);
                if (Session["ApiCode"] != null)
                    getStoreCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.GetStore(getStoreCriteria);
                 
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSales(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                GetSaleCriteria getSaleCriteria = JsonConvert.DeserializeObject<GetSaleCriteria>(param);
                if (Session["ApiCode"] != null)
                    getSaleCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.GetSales(getSaleCriteria);

            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetUserMessage(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                GetMessageCriteria getMessageCriteria = JsonConvert.DeserializeObject<GetMessageCriteria>(param);
                if (Session["ApiCode"] != null)
                    getMessageCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.GetUserMessage(getMessageCriteria);

            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllUserMessage(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                GetMessageCriteria getMessageCriteria = JsonConvert.DeserializeObject<GetMessageCriteria>(param);
                if (Session["ApiCode"] != null)
                    getMessageCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.GetAllUserMessage(getMessageCriteria);

            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }



        public JsonResult SendUserMessage(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                SetMessageCriteria setMessageCriteria = JsonConvert.DeserializeObject<SetMessageCriteria>(param);
                if (Session["ApiCode"] != null)
                    setMessageCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.SendUserMessage(setMessageCriteria);

            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SetMessageRead(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                SetMessageCriteria setMessageCriteria = JsonConvert.DeserializeObject<SetMessageCriteria>(param);
                if (Session["ApiCode"] != null)
                    setMessageCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.SetMessageRead(setMessageCriteria);

            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ConfirmOrRejectOrderItem(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                ConfirmOrRejectOrderItemCriteria confirmOrRejectOrderItemCriteria = JsonConvert.DeserializeObject<ConfirmOrRejectOrderItemCriteria>(param);
                if (Session["ApiCode"] != null)
                    confirmOrRejectOrderItemCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.ConfirmOrRejectOrderItem(confirmOrRejectOrderItemCriteria);

            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetIntegrationShipmentCompanies(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                GetIntegrationShipmentCompanyCriteria getIntegrationShipmentCompanyCriteria  = JsonConvert.DeserializeObject<GetIntegrationShipmentCompanyCriteria>(param);
                if (Session["ApiCode"] != null)
                    getIntegrationShipmentCompanyCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.GetIntegrationShipmentCompanies(getIntegrationShipmentCompanyCriteria);
                  
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult SetOrderShipmentInformation(string param)
        {
            OperationResult result = new OperationResult();
            try
            {
                SetShipmentCriteria setShipmentCriteria  = JsonConvert.DeserializeObject<SetShipmentCriteria>(param);
                if (Session["ApiCode"] != null)
                    setShipmentCriteria.ApiCode = Session["ApiCode"].ToString();
                result =
                    Utils.ServiceHelper.IntegrationService.SetOrderShipmentInformation(setShipmentCriteria);
                  
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;

            }


            return Json(new
            {
                Result = result
            }, JsonRequestBehavior.AllowGet);
        }
        

    }
}
