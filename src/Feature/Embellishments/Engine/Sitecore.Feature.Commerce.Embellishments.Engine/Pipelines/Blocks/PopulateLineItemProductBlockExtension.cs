using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Plugin.Catalog;
using Sitecore.Commerce.Plugin.Pricing;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class PopulateLineItemProductBlockExtension : PipelineBlock<CartLineComponent, CartLineComponent, CommercePipelineExecutionContext>
    {
        private readonly GetSellableItemCommand _getSellableItemCommand;

        public PopulateLineItemProductBlockExtension(GetSellableItemCommand getSellableItemCommand)
      : base((string) null)
    {
            this._getSellableItemCommand = getSellableItemCommand;
        }

        public override async Task<CartLineComponent> Run(CartLineComponent line, CommercePipelineExecutionContext context)
        {
            Condition.Requires<CartLineComponent>(line).IsNotNull<CartLineComponent>(string.Format("{0}: The line can not be null", (object)this.Name));
            ProductArgument productArgument = ProductArgument.FromItemId(line.ItemId);
            if (!productArgument.IsValid())
            {
                context.Logger.LogError(string.Format("{0}-ProductArgument Invalid: ItemId={1}", (object)this.Name, (object)line.ItemId), Array.Empty<object>());
                return line;
            }
            CartProductComponent productComponent = line.GetComponent<CartProductComponent>();
            SellableItem sellableItem1 = context.CommerceContext.GetObjects<SellableItem>().FirstOrDefault<SellableItem>((Func<SellableItem, bool>)(s => s.FriendlyId.Equals(productArgument.ProductId, StringComparison.OrdinalIgnoreCase)));
            if (sellableItem1 == null)
                sellableItem1 = await this._getSellableItemCommand.Process(context.CommerceContext, line.ItemId, false);
            SellableItem sellableItem2 = sellableItem1;
            if (sellableItem2 == null)
                return line;
            // BUG : Adds duplicate SellableItem
            //context.CommerceContext.AddObject((object)sellableItem2);
            productComponent.Id = sellableItem2.FriendlyId;
            productComponent.ItemTemplate = sellableItem2.ItemTemplate;
            productComponent.Image = sellableItem2.HasComponent<ImageryComponent>() ? sellableItem2.GetComponent<ImageryComponent>().Images.First<Image>() : context.GetPolicy<GlobalImagePolicy>().DefaultImage;
            foreach (Policy policy in sellableItem2.Policies.Where<Policy>((Func<Policy, bool>)(p =>
            {
                if (!(p is PurchaseOptionMoneyPolicy) && !(p is ListPricingPolicy))
                    return !(p is PriceCardPolicy);
                return false;
            })))
                productComponent.SetPolicy(policy);
            productComponent.Tags = sellableItem2.Tags;
            if (sellableItem2.HasComponent<ItemVariationsComponent>())
            {
                ItemVariationsComponent component = sellableItem2.GetComponent<ItemVariationsComponent>();
                ItemVariationComponent variationComponent1;
                if (component == null)
                {
                    variationComponent1 = (ItemVariationComponent)null;
                }
                else
                {
                    IList<Component> childComponents = component.ChildComponents;
                    variationComponent1 = childComponents != null ? childComponents.OfType<ItemVariationComponent>().FirstOrDefault<ItemVariationComponent>((Func<ItemVariationComponent, bool>)(v => v.Id.Equals(productArgument.VariantId, StringComparison.OrdinalIgnoreCase))) : (ItemVariationComponent)null;
                }
                ItemVariationComponent variationComponent2 = variationComponent1;
                line.GetComponent<ItemVariationSelectedComponent>().VariationId = variationComponent2 != null ? variationComponent2.Id : (string)null;
                productComponent.DisplayName = variationComponent2 != null ? variationComponent2.DisplayName : (string)null;
                productComponent.Name = variationComponent2 != null ? variationComponent2.Name : (string)null;
                productComponent.ProductName = variationComponent2 != null ? variationComponent2.Name : (string)null;
                PhysicalItemComponent physicalItemComponent = variationComponent2 != null ? variationComponent2.ChildComponents.OfType<PhysicalItemComponent>().FirstOrDefault<PhysicalItemComponent>() : (PhysicalItemComponent)null;
                productComponent.Color = (physicalItemComponent != null ? physicalItemComponent.Color : (string)null) ?? string.Empty;
                productComponent.Size = (physicalItemComponent != null ? physicalItemComponent.Size : (string)null) ?? string.Empty;
                productComponent.Style = (physicalItemComponent != null ? physicalItemComponent.Style : (string)null) ?? string.Empty;
                ExternalMappingComponent mappingComponent = variationComponent2 != null ? variationComponent2.ChildComponents.OfType<ExternalMappingComponent>().FirstOrDefault<ExternalMappingComponent>() : (ExternalMappingComponent)null;
                productComponent.ExternalId = (mappingComponent != null ? mappingComponent.ExternalId : (string)null) ?? string.Empty;
                if (variationComponent2 == null)
                    return line;
                if (variationComponent2.Tags.Count > 0)
                    productComponent.Tags = variationComponent2.Tags;
                foreach (Policy policy in variationComponent2.Policies.Where<Policy>((Func<Policy, bool>)(p =>
                {
                    if (!(p is PurchaseOptionMoneyPolicy) && !(p is ListPricingPolicy))
                        return !(p is PriceCardPolicy);
                    return false;
                })))
                    productComponent.SetPolicy(policy);
            }
            else
            {
                productComponent.DisplayName = sellableItem2.DisplayName;
                productComponent.Name = sellableItem2.Name;
                productComponent.ProductName = sellableItem2.Name;
                if (sellableItem2.HasComponent<ExternalMappingComponent>())
                    productComponent.ExternalId = sellableItem2.GetComponent<ExternalMappingComponent>().ExternalId;
            }
            if (sellableItem2.HasComponent<CatalogComponent>())
                productComponent.Catalog = productArgument.CatalogName; // sellableItem2.GetComponent<CatalogComponent>().Name;
            return line;
        }
    }
}
