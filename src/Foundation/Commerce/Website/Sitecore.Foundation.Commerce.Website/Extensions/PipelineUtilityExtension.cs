using Sitecore.Commerce.Pipelines;
using Sitecore.Commerce.Services;
using Sitecore.Diagnostics;
using Sitecore.Pipelines;
using System;

namespace Sitecore.Foundation.Commerce.Website.Extensions
{
    public class PipelineUtilityExtension
    {
        public const string CartLineItemIdDelimiter = "|";
        public const string SellableItemIdIdDelimiter = ",";
        public const string SellableItemsIdIdDelimiter = "|";

        public static TResult RunConnectPipeline<TRequest, TResult>(string pipelineName, TRequest request) where TRequest : ServiceProviderRequest where TResult : ServiceProviderResult, new()
        {
            ServicePipelineArgs servicePipelineArgs = new ServicePipelineArgs((ServiceProviderRequest)request, (ServiceProviderResult)Activator.CreateInstance<TResult>());
            CorePipeline.Run(pipelineName, (PipelineArgs)servicePipelineArgs);
            return servicePipelineArgs.Result as TResult;
        }

        public static SystemMessage CreateSystemMessage(Exception ex)
        {
            SystemMessage systemMessage1 = new SystemMessage()
            {
                Message = ex.Message
            };
            if (ex.InnerException != null && !ex.Message.Equals(ex.InnerException.Message, StringComparison.OrdinalIgnoreCase))
            {
                SystemMessage systemMessage2 = systemMessage1;
                string str = systemMessage2.Message + " - " + ex.InnerException.Message;
                systemMessage2.Message = str;
            }
            return systemMessage1;
        }

        public  static SystemMessage CreateSystemMessage(string message)
        {
            return new SystemMessage() { Message = message };
        }

        public static void ValidateArguments<TRequest, TResult>(ServicePipelineArgs args, out TRequest request, out TResult result) where TRequest : ServiceProviderRequest where TResult : ServiceProviderResult
        {
            Assert.ArgumentNotNull((object)args, "args");
            Assert.ArgumentNotNull((object)args.Request, "args.Request");
            Assert.ArgumentNotNull((object)args.Request.RequestContext, "args.Request.RequestContext");
            Assert.ArgumentNotNull((object)args.Result, "args.Result");
            request = args.Request as TRequest;
            result = args.Result as TResult;
            Assert.IsNotNull((object)request, "The parameter args.Request was not of the expected type.  Expected {0}.  Actual {1}.", new object[2]
            {
        (object) typeof (TRequest).Name,
        (object) args.Request.GetType().Name
            });
            Assert.IsNotNull((object)result, "The parameter args.Result was not of the expected type.  Expected {0}.  Actual {1}.", new object[2]
            {
        (object) typeof (TResult).Name,
        (object) args.Result.GetType().Name
            });
        }
    }
}