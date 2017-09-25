using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Configuration;
using Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines;
using Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks;
using Sitecore.Framework.Pipelines.Definitions.Extensions;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Plugin.Catalog;
using Sitecore.Commerce.Plugin.Availability;
using Sitecore.Commerce.Plugin.Inventory;
using Sitecore.Commerce.Plugin.Inventory.Cs;
using Sitecore.Commerce.Plugin.Catalog.Cs;
using Sitecore.Commerce.Plugin.Pricing;

namespace Sitecore.Feature.Commerce.Embellishments.Engine
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

                .ConfigurePipeline<IConfigureOpsServiceApiPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IConfigureOpsServiceApiPipeline> configure) => configure
                    .Add<Pipelines.Blocks.ConfigureServiceApiBlock>())

                .AddPipeline<ISaveCartLineEmbellishmentsPipeline, SaveCartLineEmbellishmentsPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<ISaveCartLineEmbellishmentsPipeline> configure) => configure
                    .Add<SaveCartLineEmbellishmentsBlock>()
                    .Add<PersistCartBlock>()
                    )

            .ConfigurePipeline<IPopulateLineItemPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IPopulateLineItemPipeline> configure) => configure
                .Replace<PopulateLineItemProductBlock, Pipelines.Blocks.PopulateLineItemProductBlockExtension>())

            .ConfigurePipeline<IPopulateItemAvailabilityComponentPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IPopulateItemAvailabilityComponentPipeline> configure) => configure
                .Replace<PopulateItemAvailabilityComponentBlock, Pipelines.Blocks.PopulateItemAvailabilityComponentBlockExtension>())

            .ConfigurePipeline<IGetInventoryItemPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IGetInventoryItemPipeline> configure) => configure
                .Replace<PopulateInventoryItemAllocationBlock, Pipelines.Blocks.PopulateInventoryItemAllocationBlockExtension>())


            .ConfigurePipeline<IGetInventorySkuPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IGetInventorySkuPipeline> configure) => configure
                .Replace<GetInventorySkuBlock, Pipelines.Blocks.GetInventorySkuBlockExtension>())

            .ConfigurePipeline<IGetInventorySkuPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IGetInventorySkuPipeline> configure) => configure
                .Add<Pipelines.Blocks.GetInventorySkuBlockExtension>().After<GetInventorySkuBlock>())


            .ConfigurePipeline<IGetInventoryItemPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IGetInventoryItemPipeline> configure) => configure
                .Replace<PopulateInventoryItemBlock, Pipelines.Blocks.PopulateInventoryItemBlockExtension>())

            //.ConfigurePipeline<ICalculateVariationsListPricePipeline>((Framework.Pipelines.Definitions.PipelineDefinition<ICalculateVariationsListPricePipeline> configure) => configure
            //    .Replace<CalculateVariationsListPriceBlock, Pipelines.Blocks.CalculateVariationsListPriceBlockExtension>())

            .ConfigurePipeline<IResolveActivePriceSnapshotByCardPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IResolveActivePriceSnapshotByCardPipeline> configure) => configure
                .Replace<ResolvePriceCardByNameBlock, Pipelines.Blocks.ResolvePriceCardByNameBlockExtension>())

            .ConfigurePipeline<IResolveActivePriceSnapshotByCardPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IResolveActivePriceSnapshotByCardPipeline> configure) => configure
                .Replace<FilterPriceSnapshotsByDateBlock, Pipelines.Blocks.FilterPriceSnapshotsByDateBlockExtension>())

            .ConfigurePipeline<IResolvePriceBookNamePipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IResolvePriceBookNamePipeline> configure) => configure
                .Replace<ResolvePriceBookNameFromCatalogBlock, Pipelines.Blocks.ResolvePriceBookNameFromCatalogBlockExtension>())

            .ConfigurePipeline<ICalculateSellableItemPricesPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<ICalculateSellableItemPricesPipeline> configure) => configure
                .Replace<GetSellableItemCatalogBlock, Pipelines.Blocks.GetSellableItemCatalogBlockExtension>())

            .ConfigurePipeline<IGetSellableItemPipeline>((Framework.Pipelines.Definitions.PipelineDefinition<IGetSellableItemPipeline> configure) => configure
                .Replace<TranslateProductBlock, Pipelines.Blocks.TranslateProductBlockExtension>())


            );
        }
    }
}
