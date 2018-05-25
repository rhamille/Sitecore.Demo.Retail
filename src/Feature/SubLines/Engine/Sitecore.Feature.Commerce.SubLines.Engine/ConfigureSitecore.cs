using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.EntityViews;
using Sitecore.Framework.Configuration;
using Sitecore.Framework.Pipelines.Definitions.Extensions;
using Sitecore.Framework.Pipelines.Definitions;
using System;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.SubLines.Engine.Pipelines.Blocks;
using Sitecore.Feature.Commerce.SubLines.Engine.Pipelines;

namespace Sitecore.Feature.Commerce.SubLines.Engine
{
    public class ConfigureSitecore : IConfigureSitecore
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.RegisterAllPipelineBlocks(assembly);
            services.RegisterAllCommands(assembly);

            //services.Sitecore().Pipelines(config => config

            //    .ConfigurePipeline<IConfigureServiceApiPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IConfigureServiceApiPipeline> configure) => configure
            //        .Add<Pipelines.Blocks.ConfigureServiceApiBlock>())
            //    .ConfigurePipeline<ICalculateCartLinesPipeline>(configure => configure
            //        .Add<PopulateCartSubLineComponentItemsBlock>().After<CalculateCartLinesTotalsBlock>(), order: 1001)
            //    //.ConfigurePipeline<ICalculateCartLinesPipeline>(configure => configure
            //    //    .Add<CalculateCartSubLinesSubTotalsBlock>().After<CalculateCartLinesSubTotalsBlock>(), order: 1001)
            //    .ConfigurePipeline<ICalculateCartLinesPipeline>(configure => configure
            //        .Add<CalculateCartSubLinesSubTotalsBlock>().After<PopulateCartSubLineComponentItemsBlock>(), order: 1001)
            //);
        }
    }
}
