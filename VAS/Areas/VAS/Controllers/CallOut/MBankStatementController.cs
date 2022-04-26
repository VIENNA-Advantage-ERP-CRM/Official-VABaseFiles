﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using VAdvantage.Model;
using VAdvantage.Utility;
using VIS.Models;

namespace VIS.Controllers
{
    public class MBankStatementController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //Get BankStatement Detail
        public JsonResult GetCurrentBalance(string fields)
        {
            
            string retJSON = "";
            if (Session["ctx"] != null)
            {
                VAdvantage.Utility.Ctx ctx = Session["ctx"] as Ctx;
                MBankStatementModel objBankStatement = new MBankStatementModel();
                retJSON = JsonConvert.SerializeObject(objBankStatement.GetCurrentBalance(ctx, fields));
            }
           
            return Json(retJSON , JsonRequestBehavior.AllowGet);
        }    

        // Get Payment Details
        public JsonResult GetPayment(string fields)
        {

            string retJSON = "";
            if (Session["ctx"] != null)
            {
                VAdvantage.Utility.Ctx ctx = Session["ctx"] as Ctx;
                MBankStatementModel objBankStatement = new MBankStatementModel();
                retJSON = JsonConvert.SerializeObject(objBankStatement.GetPayment(ctx, fields));
            }

            return Json(retJSON, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Get Converted Amount
        /// </summary>
        /// <param name="fields">String Fields</param>
        /// <returns>JSON Data</returns>
        public JsonResult GetConvertedAmt(string fields)
        {

            string retJSON = "";
            if (Session["ctx"] != null)
            {
                VAdvantage.Utility.Ctx ctx = Session["ctx"] as Ctx;
                MBankStatementModel objBankStatement = new MBankStatementModel();
                retJSON = JsonConvert.SerializeObject(objBankStatement.GetConvertedAmt(ctx, fields));
            }

            return Json(retJSON, JsonRequestBehavior.AllowGet);
        }
    }
}