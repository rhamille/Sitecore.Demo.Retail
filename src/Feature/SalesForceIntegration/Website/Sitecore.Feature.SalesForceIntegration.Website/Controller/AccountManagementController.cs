using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Feature.SalesForceIntegration.Website.Controller
{
    public class AccountManagementController : SitecoreController
    {      

        // GET: AccountManagement
        [HttpGet]
        public ActionResult MyCases()
        {
            Security.UserProfile profile = Context.User.Profile;

            return View(profile);
        }
    }
}