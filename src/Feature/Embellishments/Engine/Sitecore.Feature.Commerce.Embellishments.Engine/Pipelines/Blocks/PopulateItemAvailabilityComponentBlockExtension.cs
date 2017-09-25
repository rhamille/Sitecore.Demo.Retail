using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Availability;
using Sitecore.Commerce.Plugin.Catalog;
using Sitecore.Framework.Pipelines;
using System;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Inventory;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class PopulateItemAvailabilityComponentBlockExtension : PipelineBlock<ItemAvailabilityComponent, ItemAvailabilityComponent, CommercePipelineExecutionContext>
    {
        private GetInventoryItemCommandExtension _getInventoryItemCommand;

        public PopulateItemAvailabilityComponentBlockExtension(GetInventoryItemCommandExtension getInventoryItemCommand)
      : base((string) null)
    {
            this._getInventoryItemCommand = getInventoryItemCommand;
        }

        public override async Task<ItemAvailabilityComponent> Run(ItemAvailabilityComponent itemAvailabilityComponent, CommercePipelineExecutionContext context)
        {
            if (itemAvailabilityComponent == null)
                return (ItemAvailabilityComponent)null;
            if (string.IsNullOrEmpty(itemAvailabilityComponent.ItemId))
            {
                context.Logger.LogError(string.Format("{0}.InventoryItemNotFound.{1}", (object)this.Name, (object)itemAvailabilityComponent.ItemId), Array.Empty<object>());
                itemAvailabilityComponent.IsAvailable = false;
                itemAvailabilityComponent.GetComponent<MessagesComponent>().AddMessage("InventoryItemNotFound", string.Format("Inventory Item Not Found:{0}", (object)itemAvailabilityComponent.ItemId));
                return itemAvailabilityComponent;
            }
            ProductArgument productArgument = ProductArgument.FromItemId(itemAvailabilityComponent.ItemId);
            InventoryItem inventoryItem = await this._getInventoryItemCommand.Process(context.CommerceContext, productArgument.CatalogName, productArgument.ProductId, productArgument.VariantId);
            if (inventoryItem == null)
            {
                context.Logger.LogError(string.Format("{0}.InventoryItemNotFound.{1}", (object)this.Name, (object)itemAvailabilityComponent.ItemId), Array.Empty<object>());
                itemAvailabilityComponent.IsAvailable = false;
                itemAvailabilityComponent.GetComponent<MessagesComponent>().AddMessage("InventoryItemNotFound", string.Format("Inventory Item Not Found:{0}", (object)itemAvailabilityComponent.ItemId));
                return itemAvailabilityComponent;
            }
            this.PopulateAvailabilityComponent(itemAvailabilityComponent, inventoryItem, context);
            return itemAvailabilityComponent;
        }

        private void PopulateAvailabilityComponent(ItemAvailabilityComponent availability, InventoryItem inventoryItem, CommercePipelineExecutionContext context)
        {
            AllocationComponent allocationComponent = inventoryItem.Components.OfType<AllocationComponent>().FirstOrDefault<AllocationComponent>();
            if (allocationComponent == null)
                context.Logger.LogError(string.Format("PopulateItemAvailabilityBlock.AllocationNull.{0}", (object)availability.ItemId), Array.Empty<object>());
            else if (!allocationComponent.Status.Equals("Enabled", StringComparison.OrdinalIgnoreCase))
            {
                availability.IsAvailable = false;
                availability.AvailableDate = DateTimeOffset.MinValue;
            }
            else
            {
                availability.AvailableQuantity = allocationComponent.OnHandUnits;
                if (allocationComponent.OnHandUnits - allocationComponent.StockOutThreshold <= Decimal.Zero)
                {
                    availability.IsAvailable = false;
                    availability.AvailableDate = allocationComponent.DateAvailable;
                }
                else
                {
                    availability.IsAvailable = true;
                    availability.AvailabilityExpires = context.CommerceContext.CurrentEffectiveDate().AddSeconds((double)context.GetPolicy<GlobalAvailabilityPolicy>().AvailabilityExpires);
                    availability.AvailableDate = allocationComponent.DateAvailable;
                }
            }
        }
    }
}
