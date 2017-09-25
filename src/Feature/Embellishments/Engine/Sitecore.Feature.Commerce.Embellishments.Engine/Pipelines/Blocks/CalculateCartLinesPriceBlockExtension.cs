using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Plugin.Pricing;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Catalog.Cs;
using Sitecore.Commerce.Plugin.Catalog;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class CalculateCartLinesPriceBlockExtension : PipelineBlock<Cart, Cart, CommercePipelineExecutionContext>
    {
        private readonly GetSellableItemCommand _getSellableItemCommand;

        public CalculateCartLinesPriceBlockExtension(GetSellableItemCommand getSellableItemCommand)
      : base((string) null)
    {
            this._getSellableItemCommand = getSellableItemCommand;
        }

        public override async Task<Cart> Run(Cart arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<Cart>(arg).IsNotNull<Cart>(string.Format("{0}: Cart cannot be null.", (object)this.Name));
            Condition.Requires<IList<CartLineComponent>>(arg.Lines).IsNotNull<IList<CartLineComponent>>(string.Format("{0}: The cart's lines cannot be null", (object)this.Name));
            if (!arg.Lines.Any<CartLineComponent>())
                return arg;
            foreach (CartLineComponent cartLineComponent in arg.Lines.Where<CartLineComponent>((Func<CartLineComponent, bool>)(l =>
            {
                if (l == null || !l.HasComponent<CartProductComponent>() || string.IsNullOrEmpty(l.ItemId))
                    return false;
                return l.ItemId.Split('|').Length >= 2;
            })))
            {
                CartLineComponent line = cartLineComponent;
                ItemVariationSelectedComponent lineVariant = line.ChildComponents.OfType<ItemVariationSelectedComponent>().FirstOrDefault<ItemVariationSelectedComponent>();
                SellableItem sellableItem = await this._getSellableItemCommand.Process(context.CommerceContext, line.ItemId, false);
                if (sellableItem == null)
                {
                    context.Logger.LogError(string.Format("{0}-SellableItemNotFound for Cart Line: ItemId={1}|CartId={2}|LineId={3}", new object[4]
                    {
            (object) this.Name,
            (object) line.ItemId,
            (object) arg.Id,
            (object) line.Id
                    }), Array.Empty<object>());
                    return arg;
                }
                MessagesComponent component1 = line.GetComponent<MessagesComponent>();
                component1.Clear(context.GetPolicy<KnownMessageCodePolicy>().Pricing);
                if (sellableItem.HasComponent<MessagesComponent>())
                {
                    List<MessageModel> messages = sellableItem.GetComponent<MessagesComponent>().GetMessages(context.GetPolicy<KnownMessageCodePolicy>().Pricing);
                    component1.AddMessages((IEnumerable<MessageModel>)messages);
                }
                line.UnitListPrice = sellableItem.ListPrice;
                string text1 = string.Format("CartItem.ListPrice<=SellableItem.ListPrice: Price={0}", (object)line.UnitListPrice.AsCurrency(false));
                string text2 = string.Empty;
                PurchaseOptionMoneyPolicy optionMoneyPolicy = new PurchaseOptionMoneyPolicy();
                if (sellableItem.HasPolicy<PurchaseOptionMoneyPolicy>())
                {
                    optionMoneyPolicy.SellPrice = sellableItem.GetPolicy<PurchaseOptionMoneyPolicy>().SellPrice;
                    text2 = string.Format("CartItem.SellPrice<=SellableItem.SellPrice: Price={0}", (object)optionMoneyPolicy.SellPrice.AsCurrency(false));
                }
                PriceSnapshotComponent snapshotComponent;
                if (sellableItem.HasComponent<ItemVariationsComponent>())
                {
                    ItemVariationsComponent component2 = sellableItem.GetComponent<ItemVariationsComponent>();
                    ItemVariationComponent variationComponent1;
                    if (component2 == null)
                    {
                        variationComponent1 = (ItemVariationComponent)null;
                    }
                    else
                    {
                        IList<Component> childComponents = component2.ChildComponents;
                        variationComponent1 = childComponents != null ? childComponents.OfType<ItemVariationComponent>().FirstOrDefault<ItemVariationComponent>((Func<ItemVariationComponent, bool>)(v =>
                        {
                            if (string.IsNullOrEmpty(v.Id))
                                return false;
                            string id = v.Id;
                            ItemVariationSelectedComponent selectedComponent = lineVariant;
                            string str = selectedComponent != null ? selectedComponent.VariationId : (string)null;
                            int num = 5;
                            return id.Equals(str, (StringComparison)num);
                        })) : (ItemVariationComponent)null;
                    }
                    ItemVariationComponent variationComponent2 = variationComponent1;
                    if (variationComponent2 != null)
                    {
                        if (variationComponent2.HasComponent<MessagesComponent>())
                        {
                            List<MessageModel> messages = variationComponent2.GetComponent<MessagesComponent>().GetMessages(context.GetPolicy<KnownMessageCodePolicy>().Pricing);
                            component1.AddMessages((IEnumerable<MessageModel>)messages);
                        }
                        line.UnitListPrice = variationComponent2.ListPrice;
                        text1 = string.Format("CartItem.ListPrice<=SellableItem.Variation.ListPrice: Price={0}", (object)line.UnitListPrice.AsCurrency(false));
                        if (variationComponent2.HasPolicy<PurchaseOptionMoneyPolicy>())
                        {
                            optionMoneyPolicy.SellPrice = variationComponent2.GetPolicy<PurchaseOptionMoneyPolicy>().SellPrice;
                            text2 = string.Format("CartItem.SellPrice<=SellableItem.Variation.SellPrice: Price={0}", (object)optionMoneyPolicy.SellPrice.AsCurrency(false));
                        }
                    }
                    snapshotComponent = variationComponent2 != null ? variationComponent2.ChildComponents.OfType<PriceSnapshotComponent>().FirstOrDefault<PriceSnapshotComponent>() : (PriceSnapshotComponent)null;
                }
                else
                    snapshotComponent = sellableItem.Components.OfType<PriceSnapshotComponent>().FirstOrDefault<PriceSnapshotComponent>();
                PriceTier priceTier = snapshotComponent != null ? snapshotComponent.Tiers.OrderByDescending<PriceTier, Decimal>((Func<PriceTier, Decimal>)(t => t.Quantity)).FirstOrDefault<PriceTier>((Func<PriceTier, bool>)(t => t.Quantity <= line.Quantity)) : (PriceTier)null;
                if (priceTier != null)
                {
                    optionMoneyPolicy.SellPrice = new Money(priceTier.Currency, priceTier.Price);
                    text2 = string.Format("CartItem.SellPrice<=PriceCard.ActiveSnapshot: Price={0}|Qty={1}", (object)optionMoneyPolicy.SellPrice.AsCurrency(false), (object)priceTier.Quantity);
                }
                line.Policies.Remove((Policy)line.Policies.OfType<PurchaseOptionMoneyPolicy>().FirstOrDefault<PurchaseOptionMoneyPolicy>());
                if (optionMoneyPolicy.SellPrice != null)
                {
                    line.SetPolicy((Policy)optionMoneyPolicy);
                    if (!string.IsNullOrEmpty(text2))
                        component1.AddMessage(context.GetPolicy<KnownMessageCodePolicy>().Pricing, text2);
                    if (!string.IsNullOrEmpty(text1))
                        component1.AddMessage(context.GetPolicy<KnownMessageCodePolicy>().Pricing, text1);
                }
            }
            return arg;
        }
    }
}
