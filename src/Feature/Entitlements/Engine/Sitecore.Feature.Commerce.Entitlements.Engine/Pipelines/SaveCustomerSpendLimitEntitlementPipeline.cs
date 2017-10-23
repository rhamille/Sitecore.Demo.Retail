using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using Sitecore.Feature.Commerce.Entitlements.Engine;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Arguments;
using Sitecore.Feature.Commerce.Entitlements.Engine.Entities;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines;
using Microsoft.Extensions.Logging;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines
{
    public class SaveCustomerSpendLimitEntitlementPipeline : CommercePipeline<SaveCustomerSpendLimitEntitlementArgument, SpendLimitEntitlement>, ISaveCustomerSpendLimitEntitlementPipeline, IPipeline<SaveCustomerSpendLimitEntitlementArgument, SpendLimitEntitlement, CommercePipelineExecutionContext>, IPipelineBlock<SaveCustomerSpendLimitEntitlementArgument, SpendLimitEntitlement, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {
        public SaveCustomerSpendLimitEntitlementPipeline(IPipelineConfiguration<ISaveCustomerSpendLimitEntitlementPipeline> configuration, ILoggerFactory loggerFactory)
          : base((IPipelineConfiguration)configuration, loggerFactory)
        {
        }
    }
}
