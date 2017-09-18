using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Sitecore.Project.Commerce.Retail.Website
{
    public class Global : Sitecore.Web.Application
    {

        /*  protected void Application_Start(object sender, EventArgs e)
          {

          }

          protected void Session_Start(object sender, EventArgs e)
          {

          }
          */
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Response.Headers.Remove("X-Frame-Options");
            Response.AddHeader("X-Frame-Options", "AllowAll");
            Response.AddHeader("Content-Security-Policy", "frame-ancestors 'self' *.dev.local");
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
        }
        /*
                protected void Application_AuthenticateRequest(object sender, EventArgs e)
                {

                }

                protected void Application_Error(object sender, EventArgs e)
                {

                }

                protected void Session_End(object sender, EventArgs e)
                {

                }

                protected void Application_End(object sender, EventArgs e)
                {

                }*/
    }
}