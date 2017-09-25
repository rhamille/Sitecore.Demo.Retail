using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using Sitecore.Feature.Commerce.Embellishments.Engine;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Arguments;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines
{
    public interface ISaveCartLineEmbellishmentsPipeline : IPipeline<SaveCartLineEmbellishmentsArgument, Cart, CommercePipelineExecutionContext>, IPipelineBlock<SaveCartLineEmbellishmentsArgument, Cart, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {

    }
}
