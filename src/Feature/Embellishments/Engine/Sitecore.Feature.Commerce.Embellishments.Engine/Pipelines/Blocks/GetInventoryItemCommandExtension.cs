using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Framework.Caching;
using Sitecore.Framework.Pipelines;
using System;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Inventory;


namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class GetInventoryItemCommandExtension : GetInventoryItemCommand
    {
        private readonly IGetEnvironmentCachePipeline _cachePipeline;
        private readonly IGetInventoryItemPipeline _getInventoryItemPipeline;

        public GetInventoryItemCommandExtension(IServiceProvider serviceProvider, IGetInventoryItemPipeline getInventoryItemPipeline, IGetEnvironmentCachePipeline cachePipeline)
      : base(serviceProvider, getInventoryItemPipeline, cachePipeline)
    {
            this._cachePipeline = cachePipeline;
            this._getInventoryItemPipeline = getInventoryItemPipeline;
        }

        public override async Task<InventoryItem> Process(CommerceContext commerceContext, string catalog, string productId, string variantId)
        {
            using (CommandActivity.Start(commerceContext, (CommerceCommand)this))
            {
                InventoryItem inventoryItem = commerceContext.GetObjects<InventoryItem>().FirstOrDefault<InventoryItem>((Func<InventoryItem, bool>)(p =>
                {
                    if (p.ProductId.Equals(productId, StringComparison.OrdinalIgnoreCase) && p.VariantId.Equals(variantId, StringComparison.OrdinalIgnoreCase))
                        return p.Catalog.Equals(catalog, StringComparison.OrdinalIgnoreCase);
                    return false;
                }));
                if (inventoryItem != null)
                    return inventoryItem;
                InventoryItemCachePolicy cachePolicy = commerceContext.GetPolicy<InventoryItemCachePolicy>();
                string itemKey = string.Format("{0}|{1}|{2}", (object)catalog, (object)productId, (object)variantId);
                ICache cache = (ICache)null;
                if (cachePolicy.AllowCaching)
                {
                    IGetEnvironmentCachePipeline cachePipeline = this._cachePipeline;
                    EnvironmentCacheArgument environmentCacheArgument = new EnvironmentCacheArgument();
                    environmentCacheArgument.CacheName = cachePolicy.CacheName;
                    CommercePipelineExecutionContextOptions pipelineContextOptions = commerceContext.GetPipelineContextOptions();
                    cache = await cachePipeline.Run(environmentCacheArgument, (IPipelineExecutionContextOptions)pipelineContextOptions);
                    inventoryItem = await cache.Get(itemKey) as InventoryItem;
                }
                if (inventoryItem == null)
                {
                    commerceContext.Logger.LogInformation(string.Format("MemCache.GetInventoryItem.Miss: ItemKey={0}|Expiration={1}|Environment={2}", (object)itemKey, (object)cachePolicy.Expiration, (object)commerceContext.Environment.Name), Array.Empty<object>());
                    IGetInventoryItemPipeline inventoryItemPipeline = this._getInventoryItemPipeline;
                    InventoryItemArgument inventoryItemArgument = new InventoryItemArgument();
                    inventoryItemArgument.CatalogName = catalog;
                    inventoryItemArgument.SellableItemId = productId;
                    inventoryItemArgument.VariantId = variantId;
                    CommercePipelineExecutionContextOptions pipelineContextOptions = commerceContext.GetPipelineContextOptions();
                    inventoryItem = await inventoryItemPipeline.Run(inventoryItemArgument, (IPipelineExecutionContextOptions)pipelineContextOptions);
                }
                else
                    commerceContext.Logger.LogInformation(string.Format("MemCache.GetInventoryItem.Hit: ItemKey={0}", (object)itemKey), Array.Empty<object>());
                if (inventoryItem == null)
                {
                    commerceContext.Logger.LogError(string.Format("GetInventoryItemCmd.IsNull: ProductId={0}|VariantId={1}|Catalog={2}", (object)productId, (object)variantId, (object)catalog), Array.Empty<object>());
                }
                else
                {
                    if (cachePolicy.AllowCaching && cache != null)
                        await cache.Set(itemKey, (ICachable)new Cachable<CommerceEntity>((CommerceEntity)inventoryItem, 1L), cachePolicy.GetCacheEntryOptions());
                    commerceContext.AddObject((object)inventoryItem);
                }
                return inventoryItem;
            }
        }
    }
}
