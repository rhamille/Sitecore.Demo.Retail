using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Inventory;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class PopulateInventoryItemAllocationBlockExtension : PipelineBlock<InventoryItem, InventoryItem, CommercePipelineExecutionContext>
    {
        public PopulateInventoryItemAllocationBlockExtension()
      : base((string) null)
    {
        }

        public override Task<InventoryItem> Run(InventoryItem inventoryItem, CommercePipelineExecutionContext context)
        {
            Condition.Requires<InventoryItem>(inventoryItem).IsNotNull<InventoryItem>(string.Format("{0}: The inventoryItem can not be null", (object)this.Name));
            Condition.Requires<string>(inventoryItem.ProductId).IsNotNull<string>(string.Format("{0}: The inventoryItem.ProductId can not be null", (object)this.Name));
            Condition.Requires<string>(inventoryItem.Catalog).IsNotNull<string>(string.Format("{0}: The inventoryItem.Catalog can not be null", (object)this.Name));
            InventorySku inventorySku = context.CommerceContext.GetObjects<InventorySku>().FirstOrDefault<InventorySku>((Func<InventorySku, bool>)(p =>
            {
                if (p.ProductId.Equals(inventoryItem.ProductId, StringComparison.OrdinalIgnoreCase) && p.VariantId.Equals(inventoryItem.VariantId, StringComparison.OrdinalIgnoreCase))
                    return p.ProductCatalogName.Equals(inventoryItem.Catalog, StringComparison.OrdinalIgnoreCase);
                return false;
            }));
            if (inventorySku == null)
                return Task.FromResult<InventoryItem>(inventoryItem);
            AllocationComponent allocationComponent = inventoryItem.Components.OfType<AllocationComponent>().FirstOrDefault<AllocationComponent>((Func<AllocationComponent, bool>)(p => p.FulfillmentCenterId.Equals(inventorySku.InventoryCatalogName, StringComparison.OrdinalIgnoreCase)));
            if (allocationComponent == null)
            {
                allocationComponent = new AllocationComponent()
                {
                    FulfillmentCenterId = inventorySku.InventoryCatalogName
                };
                inventoryItem.Components.Add((Component)allocationComponent);
            }
            allocationComponent.Bin = inventoryItem.Sku;
            allocationComponent.LastModifiedDate = inventorySku.LastModified;
            allocationComponent.LastRestockDate = inventorySku.LastRestocked;
            allocationComponent.Status = inventorySku.Status.ToString();
            allocationComponent.StockOutThreshold = inventorySku.StockOutThreshold;
            allocationComponent.OnHandUnits = inventorySku.Quantity;
            allocationComponent.Expires = context.CommerceContext.CurrentEffectiveDate().AddSeconds(10.0);
            allocationComponent.DateAvailable = context.GetPolicy<GlobalInventoryPolicy>().DefaultAllocationDateAvailable;
            allocationComponent.IsAvailable = inventorySku.Status == StockStatus.Enabled && !(inventorySku.Quantity - inventorySku.StockOutThreshold <= Decimal.Zero);
            return Task.FromResult<InventoryItem>(inventoryItem);
        }
    }
}
