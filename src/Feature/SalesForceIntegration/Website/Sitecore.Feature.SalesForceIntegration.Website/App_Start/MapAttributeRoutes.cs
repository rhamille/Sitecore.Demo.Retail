using Sitecore.Pipelines;
using System.Web.Routing;
using System.Web.Mvc;

namespace Sitecore.Feature.SalesForceIntegration.Website
{
    public class MapAttributeRoutes
    {
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapMvcAttributeRoutes();
        }
    }
}
