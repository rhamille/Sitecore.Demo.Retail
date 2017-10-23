using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using Sitecore.Feature.Commerce.Entitlements.Engine;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Arguments;
using Sitecore.Feature.Commerce.Entitlements.Engine.Entities;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines
{
    public interface ISaveCustomerSpendLimitEntitlementPipeline : IPipeline<SaveCustomerSpendLimitEntitlementArgument, SpendLimitEntitlement, CommercePipelineExecutionContext>, IPipelineBlock<SaveCustomerSpendLimitEntitlementArgument, SpendLimitEntitlement, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {

    }
}
