using CoreLibrary.DataBase;
using Microsoft.AspNet.Identity;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Owin;
using Microsoft.Owin.Host.SystemWeb;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using VAdvantage.Utility;
//using Microsoft.Web.WebPages.OAuth;


namespace ViennaBase
{
    public static class AuthConfig
    {
       // // The Client ID is used by the application to uniquely identify itself to Azure AD.
       //static string clientId = System.Configuration.ConfigurationManager.AppSettings["ClientId"];

       // // RedirectUri is the URL where the user will be redirected to after they sign in.
       // static string redirectUri = System.Configuration.ConfigurationManager.AppSettings["RedirectUri"];

       // // Tenant is the tenant ID (e.g. contoso.onmicrosoft.com, or 'common' for multi-tenant)
       // static string tenant = System.Configuration.ConfigurationManager.AppSettings["Tenant"];

       // // Authority is the URL for authority, composed by Microsoft identity platform endpoint and the tenant name (e.g. https://login.microsoftonline.com/contoso.onmicrosoft.com/v2.0)
       // static string authority = String.Format(System.Globalization.CultureInfo.InvariantCulture, System.Configuration.ConfigurationManager.AppSettings["Authority"], tenant);

        public static void RegisterAuth(Owin.IAppBuilder app)
        {

            DataSet DS = DB.ExecuteDataset(@"SELECT clientID,authorityurl,tenantoptional,redirecturi,Provider,AD_Ref_List.value,ad_ref_list.name FROM sso_configuration 
                        INNER JOIN AD_Ref_List  ON AD_Ref_List.Value=sso_configuration.Provider
                        WHERE sso_configuration.IsActive='Y' AND AD_Reference_ID IN (
                        SELECT ad_reference_ID FROM ad_reference WHERE NAme='VIS_ServiceProvider'
                        )");
           

            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);


            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                CookieManager = new SystemWebCookieManager(),
                LoginPath = new PathString("/Account/JsonLogin"),
                LogoutPath = new PathString("/")
            });

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/JsonLogin"), // Set the login page URL                
                LogoutPath = new PathString("/")
            });


            if (DS != null && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string authority = String.Format(System.Globalization.CultureInfo.InvariantCulture, Util.GetValueOfString(DS.Tables[0].Rows[i]["authorityurl"]), Util.GetValueOfString(DS.Tables[0].Rows[i]["tenantoptional"]));
                    app.UseOpenIdConnectAuthentication(
                               new OpenIdConnectAuthenticationOptions
                               {
                                   AuthenticationType = Util.GetValueOfString(DS.Tables[0].Rows[i]["value"]).ToLower(),
                                   ClientId = Util.GetValueOfString(DS.Tables[0].Rows[i]["clientID"]),
                                   Authority = authority,
                                   RedirectUri = Util.GetValueOfString(DS.Tables[0].Rows[i]["redirecturi"]),

                                   PostLogoutRedirectUri = Util.GetValueOfString(DS.Tables[0].Rows[i]["redirecturi"]),
                                   Scope = OpenIdConnectScope.OpenIdProfile,
                                   // ResponseType is set to request the code id_token - which contains basic information about the signed-in user
                                   ResponseType = OpenIdConnectResponseType.CodeIdToken,
                                   // OpenIdConnectAuthenticationNotifications configures OWIN to send notification of failed authentications to OnAuthenticationFailed method

                                   TokenValidationParameters = new TokenValidationParameters()
                                   {
                                       ValidateIssuer = false // Simplification (see note below)
                                   },
                                   Notifications = new OpenIdConnectAuthenticationNotifications
                                   {
                                       //AuthenticationFailed = OnAuthenticationFailed
                                   }
                               }


                           );
                }
            }

           
        }
    }
}
