using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Framework.Pipelines;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Pipelines
{

    [PipelineDisplayName("pipelines:calculatecartsublines")]
    public interface ICalculateCartSubLinesPipelines : IPipeline<Cart, Cart, CommercePipelineExecutionContext>, IPipelineBlock<Cart, Cart, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {
    }
}
