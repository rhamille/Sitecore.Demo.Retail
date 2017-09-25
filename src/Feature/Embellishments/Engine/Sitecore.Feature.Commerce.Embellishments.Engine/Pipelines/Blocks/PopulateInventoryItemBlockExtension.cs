using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Inventory;
using Sitecore.Commerce.Core;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class PopulateInventoryItemBlockExtension : PipelineBlock<InventoryItemArgument, InventoryItem, CommercePipelineExecutionContext>
    {
        private readonly GetInventorySkuCommandExtension _getInventorySkuCommand;

        public PopulateInventoryItemBlockExtension(GetInventorySkuCommandExtension getInventorySkuCommand)
      : base((string) null)
    {
            this._getInventorySkuCommand = getInventorySkuCommand;
        }

        public override async Task<InventoryItem> Run(InventoryItemArgument productArgument, CommercePipelineExecutionContext context)
        {
            Condition.Requires<InventoryItemArgument>(productArgument).IsNotNull<InventoryItemArgument>(string.Format("{0}: The ProductArgument cannot be null", (object)this.Name));
            context.CommerceContext.AddUniqueObjectByType((object)productArgument);
            InventoryItem inventoryItem = context.CommerceContext.GetObjects<InventoryItem>().FirstOrDefault<InventoryItem>((Func<InventoryItem, bool>)(p =>
            {
                if (p.Catalog.Equals(productArgument.CatalogName, StringComparison.OrdinalIgnoreCase) && p.ProductId.Equals(productArgument.SellableItemId, StringComparison.OrdinalIgnoreCase))
                    return p.VariantId.Equals(productArgument.VariantId, StringComparison.OrdinalIgnoreCase);
                return false;
            }));
            if (inventoryItem != null)
            {
                context.LogInfoIf(context.GetPolicy<Sitecore.Commerce.Plugin.Inventory.LoggingPolicy>().LogInventoryItemFromContext, string.Format("Inventory.GetInventoryItem-FromContext-{0}|{1}|{2}", (object)productArgument.CatalogName, (object)productArgument.SellableItemId, (object)productArgument.VariantId));
                return inventoryItem;
            }
            context.LogInfoIf(context.GetPolicy<Sitecore.Commerce.Plugin.Inventory.LoggingPolicy>().LogGetDefaultInventoryItem, string.Format("Inventory.GetInventoryItem-{0}|{1}|{2}", (object)productArgument.CatalogName, (object)productArgument.SellableItemId, (object)productArgument.VariantId));
            InventoryItem inventoryItem1 = new InventoryItem();
            string str1 = string.Format("{0}|{1}|{2}", (object)productArgument.CatalogName, (object)productArgument.SellableItemId, (object)productArgument.VariantId);
            inventoryItem1.Id = str1;
            string sellableItemId = productArgument.SellableItemId;
            inventoryItem1.ProductId = sellableItemId;
            string variantId = productArgument.VariantId;
            inventoryItem1.VariantId = variantId;
            string catalogName = productArgument.CatalogName;
            inventoryItem1.Catalog = catalogName;
            string str2 = productArgument.AsItemId();
            inventoryItem1.Sku = str2;
            inventoryItem = inventoryItem1;
            context.CommerceContext.AddObject((object)inventoryItem);
            InventorySku inventorySku = await this._getInventorySkuCommand.Process(context.CommerceContext, inventoryItem.Catalog, inventoryItem.ProductId, inventoryItem.VariantId);
            if (inventorySku == null)
                return inventoryItem;
            inventoryItem.UnitOfMeasure = inventorySku.UnitOfMeasure;
            return inventoryItem;
        }
    }
}
