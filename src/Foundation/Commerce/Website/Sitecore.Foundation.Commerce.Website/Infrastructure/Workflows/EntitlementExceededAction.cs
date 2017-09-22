using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Workflows.Simple;

namespace Sitecore.Foundation.Commerce.Website.Infrastructure.Workflows
{

    public class EntitlementExceededAction
    {
        public void Process(WorkflowPipelineArgs args)
        {

            Assert.ArgumentNotNull(args, "args");
            ProcessorItem processorItem = args.ProcessorItem;
            if (processorItem != null)
            {
                /*var message = new MailMessage("wisbis@test.com", "user@test.com");
                message.Subject = "WIS";
                message.Body = "Body";
                MainUtil.SendMail(message);*/
            }
        }

    }
}