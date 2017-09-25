using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Plugin.Inventory;
using Sitecore.Framework.Pipelines;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class GetInventorySkuCommandExtension : CommerceCommand
    {
        private readonly IGetInventorySkuPipeline _getInventorySkuPipeline;

        public GetInventorySkuCommandExtension(IServiceProvider serviceProvider, IGetInventorySkuPipeline getInventorySkuPipeline)
      : base(serviceProvider)
    {
            this._getInventorySkuPipeline = getInventorySkuPipeline;
        }

        public virtual async Task<InventorySku> Process(CommerceContext commerceContext, string catalog, string productId, string variantId)
        {
            using (CommandActivity.Start(commerceContext, (CommerceCommand)this))
            {
                InventorySku inventorySku1 = commerceContext.GetObjects<InventorySku>().FirstOrDefault<InventorySku>((Func<InventorySku, bool>)(p =>
                {
                    if (p.ProductId.Equals(productId, StringComparison.OrdinalIgnoreCase) && p.VariantId.Equals(variantId, StringComparison.OrdinalIgnoreCase))
                        return p.ProductCatalogName.Equals(catalog, StringComparison.OrdinalIgnoreCase);
                    return false;
                }));
                if (inventorySku1 != null)
                    return inventorySku1;
                IGetInventorySkuPipeline inventorySkuPipeline = this._getInventorySkuPipeline;
                InventorySkuArgument inventorySkuArgument = new InventorySkuArgument();
                inventorySkuArgument.CatalogName = catalog;
                inventorySkuArgument.ProductId = productId;
                inventorySkuArgument.VariantId = variantId;
                CommercePipelineExecutionContextOptions pipelineContextOptions = commerceContext.GetPipelineContextOptions();
                InventorySku inventorySku2 = await this._getInventorySkuPipeline.Run(inventorySkuArgument, (IPipelineExecutionContextOptions)pipelineContextOptions);
                if (inventorySku2 == null)
                    commerceContext.Logger.LogError(string.Format("GetInventorySkuCommand.IsNull: ProductId={0}|VariantId={1}|Catalog={2}", (object)productId, (object)variantId, (object)catalog), Array.Empty<object>());
                else if (!commerceContext.GetObjects<InventorySku>().Any<InventorySku>((Func<InventorySku, bool>)(p =>
                {
                    if (p.ProductId == productId && p.VariantId == variantId)
                        return p.ProductCatalogName == catalog;
                    return false;
                })))
                    commerceContext.AddObject((object)inventorySku2);
                return inventorySku2;
            }
        }
    }
}
