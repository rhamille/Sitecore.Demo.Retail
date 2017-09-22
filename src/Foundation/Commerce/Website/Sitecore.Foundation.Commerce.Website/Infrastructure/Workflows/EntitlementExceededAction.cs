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

    public class EntitlementExceededActionEmail
    {
        public void Process(WorkflowPipelineArgs args)
        {

            Assert.ArgumentNotNull((object)args, "args");
            ProcessorItem processorItem = args.ProcessorItem;
            if (processorItem == null)
                return;
            Item innerItem = processorItem.InnerItem;
            string fullPath = innerItem.Paths.FullPath;
            string text1 = this.GetText(innerItem, "from", args);
            string text2 = this.GetText(innerItem, "to", args);
            string text3 = this.GetText(innerItem, "mail server", args);
            string text4 = this.GetText(innerItem, "subject", args);
            string text5 = this.GetText(innerItem, "message", args);
            text5 = text5.Replace("{orderid}", args.DataItem["OrderId"]);
            Error.Assert(text2.Length > 0, "The 'To' field is not specified in the mail action item: " + fullPath);
            Error.Assert(text1.Length > 0, "The 'From' field is not specified in the mail action item: " + fullPath);
            Error.Assert(text4.Length > 0, "The 'Subject' field is not specified in the mail action item: " + fullPath);
            Error.Assert(text3.Length > 0, "The 'Mail server' field is not specified in the mail action item: " + fullPath);
            new SmtpClient(text3).Send(new MailMessage(text1, text2)
            {
                Subject = text4,
                Body = text5
            });
        }

        /// <summary>Gets the text.</summary>
        /// <param name="commandItem">The command item.</param>
        /// <param name="field">The field.</param>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        private string GetText(Item commandItem, string field, WorkflowPipelineArgs args)
        {
            string text = commandItem[field];
            if (text.Length > 0)
                return this.ReplaceVariables(text, args);
            return string.Empty;
        }

        /// <summary>Replaces the variables.</summary>
        /// <param name="text">The text.</param>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        private string ReplaceVariables(string text, WorkflowPipelineArgs args)
        {
            text = text.Replace("$itemPath$", args.DataItem.Paths.FullPath);
            text = text.Replace("$itemLanguage$", args.DataItem.Language.ToString());
            text = text.Replace("$itemVersion$", args.DataItem.Version.ToString());
            return text;
        }

    }
}