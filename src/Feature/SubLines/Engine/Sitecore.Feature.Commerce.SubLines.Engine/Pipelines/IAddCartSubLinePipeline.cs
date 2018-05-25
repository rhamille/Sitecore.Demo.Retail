using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Framework.Pipelines;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Pipelines
{
    public interface IAddCartSubLinePipeline : IPipeline<CartLineArgument, Cart, CommercePipelineExecutionContext>, IPipelineBlock<CartLineArgument, Cart, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {
    }
}
