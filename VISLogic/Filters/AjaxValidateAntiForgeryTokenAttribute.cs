﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace VISLogic.Filters
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class AjaxValidateAntiForgeryTokenAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            try
            {
                if (filterContext.HttpContext.Request.IsAjaxRequest()) // if it is ajax request.
                {
                    this.ValidateRequestHeader(filterContext.HttpContext.Request); // run the validation.
                }
                else if (filterContext.HttpContext.Request.Url.Segments.ToList().IndexOf("MsgForToastr")>0)
                {
                    string vari = filterContext.HttpContext.Request.QueryString["varificationToken"];
                    ValidateVerificationToken(vari);
                }
                else
                {
                    AntiForgery.Validate();
                }
            }
            catch (HttpAntiForgeryException)
            {
                //filterContext.Result = new JsonResult { Data = "_Logon_" };
                filterContext.HttpContext.Response.StatusCode = 401;
                filterContext.Result = new JsonResult { Data = "_Logon_" };
                filterContext.HttpContext.Response.End();
            }
        }

        private void ValidateRequestHeader(HttpRequestBase request)
        {
            string tokenValue = request.Headers["VerificationToken"]; // read the header key and validate the tokens.
            ValidateVerificationToken(tokenValue);
        }

        private void ValidateVerificationToken(string tokenValue)
        {
            string cookieToken = string.Empty;
            string formToken = string.Empty;
            if (!string.IsNullOrEmpty(tokenValue))
            {
                string[] tokens = tokenValue.Split(':');
                if (tokens.Length == 2)
                {
                    cookieToken = tokens[0].Trim();
                    formToken = tokens[1].Trim();
                }
            }

            AntiForgery.Validate(cookieToken, formToken); // this validates the request token.
        }
    }
}