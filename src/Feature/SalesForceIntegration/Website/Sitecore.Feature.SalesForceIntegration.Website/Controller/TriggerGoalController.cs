using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Mvc.Controllers;
using System.Net;
using Sitecore.Mvc.Presentation;
using Sitecore.Feature.SalesForceIntegration.Website.Service;
using System.Web.Security;
using Sitecore.Analytics;
//using Sitecore.Analytics.Data.Items;

namespace Sitecore.Feature.SalesForceIntegration.Website.Controller
{
    public class TriggerGoalController : SitecoreController
    {

        private void SendGoalToSalesForce(string goalName)
        {
            
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;


            var loginClient = new sfpartner.SforceService();
            var loginResponse = loginClient.login("vahid@rxpservices.com", "qweasdzxcV123" + "L80Spq90HxBbUAHujt8617At");


            var goalClient = new sfgoal.GoalWebServiceService();
            goalClient.SessionHeaderValue = new sfgoal.SessionHeader
            {
                sessionId = loginResponse.sessionId,
            };

            var goalResponse = goalClient.addGoalEvent(new sfgoal.Request
            {
                contactId = (User.Identity.IsAuthenticated) ? Membership.GetUser().Email : "",
                goalName = goalName,
                IPAddress = GetIPAddress(),
                pageName = Sitecore.Context.Item.DisplayName,
                timestamp = DateTime.Now,
                timestampSpecified = true,
                email = (User.Identity.IsAuthenticated) ? Membership.GetUser().Email : "",
                campaignId = GetCampaignName(),
                engagementValue = GetEngangementValue(),
                engagementValueSpecified = true,
                profile = "Athlete"
            });
        }

        private string GetCampaignName()
        {
            if (Tracker.Current?.Interaction?.CampaignId != null)
            {
                var campaign = Sitecore.Context.Database.GetItem(new Data.ID(Tracker.Current?.Interaction?.CampaignId.Value.ToString()));

                if (campaign != null)
                {
                    return campaign.DisplayName;
                }
            }

            return "";
        }

        private int GetEngangementValue()
        {
            var pageEvents = Tracker.Current?.Interaction?.CurrentPage?.PageEvents;

            return (pageEvents == null) ? 0 : pageEvents.Where(x => x.IsGoal).Sum(x => x.Value);
        }

        private string GetIPAddress()
        {
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }
        // GET: TriggerGoal
        [HttpGet]
        public ActionResult TriggerGoal()
        {

            var goalItems = new List<Sitecore.Data.Items.Item>();
            var pageConext = PageContext.Current.Item;

            if (pageConext != null)
            {
                goalItems = SitecoreItemHelper.GetGoalReferers(pageConext.ID);
            }

            if (goalItems.Count > 0)
            {
                var goal = goalItems.First();
              
                SendGoalToSalesForce(goal.Name);
            }

            return View();
        }

    
    }
}