using System.Reflection;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Blocks;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.EntityViews;
using Sitecore.Commerce.Plugin.Entitlements;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Blocks.EntityViews;
using Sitecore.Framework.Configuration;
using Sitecore.Framework.Pipelines.Definitions.Extensions;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines;
using Sitecore.Commerce.Plugin.Customers;
using Sitecore.Commerce.Plugin.SQL;
using Sitecore.Framework.Pipelines.Definitions;
using System;

namespace Sitecore.Feature.Commerce.Entitlements.Engine
{
    public class ConfigureSitecore : IConfigureSitecore
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.RegisterAllPipelineBlocks(assembly);
            services.RegisterAllCommands(assembly);

            services.Sitecore().Pipelines(config => config

                .ConfigurePipeline<IConfigureServiceApiPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IConfigureServiceApiPipeline> configure) => configure
                    .Add<Pipelines.Blocks.ConfigureServiceApiBlock>())

                .ConfigurePipeline<IProvisionEntitlementsPipeline>(c =>
                {
                    c.Add<ProvisionWarrantyEntitlementsBlock>().After<ProvisionEntitlementsBlock>()
                        .Add<ProvisionDigitalProductEntitlementsBlock>().After<ProvisionEntitlementsBlock>()
                        .Add<ProvisionInstallationEntitlementsBlock>().After<ProvisionEntitlementsBlock>();
                })

                .ConfigurePipeline<IGetEntityViewPipeline>(c =>
                {
                    c.Add<GetOrderDigitalProductEntitlementDetailsViewBlock>().After<GetOrderEntitlementsViewBlock>()
                        .Add<GetCustomerDigitalProductEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>()
                        .Add<GetOrderWarrantyEntitlementDetailsViewBlock>().After<GetOrderEntitlementsViewBlock>()
                        .Add<GetCustomerWarrantyEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>()
                        .Add<GetOrderInstallationEntitlementDetailsViewBlock>().After<GetOrderEntitlementsViewBlock>()
                        .Add<GetCustomerInstallationEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>()
                        .Add<GetCustomerSpendLimitEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>()
                        ;
                })

                .AddPipeline<ISaveCustomerSpendLimitEntitlementPipeline, SaveCustomerSpendLimitEntitlementPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<ISaveCustomerSpendLimitEntitlementPipeline> configure) => configure
                    .Add<ProvisionCustomerSpendLimitEntitlementsBlock>()
                    //.Add<PersistCartBlock>()
                )

                .ConfigurePipeline<IGetCustomerPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IGetCustomerPipeline> configure) => configure
                .Replace<GetCustomerBlock, Pipelines.Blocks.GetCustomerBlockExtension>())

                .ConfigurePipeline<IFindEntityPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IFindEntityPipeline> configure) => configure
                .Replace<FindEntityBlock, Pipelines.Blocks.FindEntityBlockExtension>())

                .ConfigurePipeline<IFindEntityPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IFindEntityPipeline> configure) => configure
                .Replace<Sitecore.Commerce.Plugin.Customers.Cs.FindEntityBlock, Pipelines.Blocks.FindEntityBlockCsExtension>())

                //.ConfigurePipeline<IGetEntityViewPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IGetEntityViewPipeline> configure) => configure
                //    //.Add<GetEntityViewOrderSummaryGiftCardBlock>().After<GetOrderSummaryEntityViewBlock>()
                //    //.Add<GetOrderPaymentDetailsViewBlock>().After<Sitecore.Commerce.Plugin.Payments.GetOrderPaymentDetailsViewBlock>()
                //    //.Add<GetOrderGiftCardEntitlementDetailsViewBlock>().After<GetOrderEntitlementsViewBlock>()
                //    //.Add<GetCustomerGiftCardEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>()
                //    .Add<GetCustomerSpendLimitEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>()
                //    )

            );
        }
    }
}
