﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Commerce.Core;
using Sitecore.Feature.Commerce.HabitatData.Engine.Pipelines.Blocks;
using Sitecore.Framework.Configuration;
using Sitecore.Framework.Pipelines.Definitions.Extensions;
using Sitecore.Commerce.Plugin.Carts;

namespace Sitecore.Feature.Commerce.HabitatData.Engine
{
    public class ConfigureSitecore : IConfigureSitecore
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.RegisterAllPipelineBlocks(assembly);
            services.RegisterAllCommands(assembly);

            services.Sitecore().Pipelines(config => config

                .ConfigurePipeline<IInitializeEnvironmentPipeline>(c =>
                {
                    c.Add<InitializeEnvironmentGiftCardsBlock>()
                        .Add<InitializeEnvironmentSellableItemsBlock>()
                        .Add<InitializeEnvironmentPricingBlock>()
                        .Add<InitializeEnvironmentPromotionsBlock>();
                })

                .ConfigurePipeline<IAddCartLinePipeline>(configure => configure.Add<AddCartLineGiftCardBlock>().Before<PersistCartBlock>())

                .ConfigurePipeline<IUpdateCartLinePipeline>(configure => configure.Add<AddCartLineGiftCardBlock>().Before<ICalculateCartPipeline>())
                
            );
        }
    }
}
