using System.Web.Routing;
using Sitecore.Pipelines;

namespace Sitecore.Feature.SalesForceIntegration.Website.Infrastructure.Pipeline
{
    public class InitializeRoutes
    {
        public void Process(PipelineArgs args)
        {
            if (!Context.IsUnitTesting)
            {
                //RouteConfig.RegisterRoutes(RouteTable.Routes);
            }
        }
    }
}