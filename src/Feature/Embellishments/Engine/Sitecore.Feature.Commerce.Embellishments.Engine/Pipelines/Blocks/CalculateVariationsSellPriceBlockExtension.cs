using CommerceServer.Core.Catalog;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Pricing;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Catalog.Cs;
using Sitecore.Commerce.Plugin.Catalog;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class CalculateVariationsSellPriceBlockExtension : PipelineBlock<SellableItem, SellableItem, CommercePipelineExecutionContext>
    {
        private readonly IResolveActivePriceSnapshotByCardPipeline _resolveSnapshotByCardPipeline;
        private readonly IResolveActivePriceSnapshotByTagsPipeline _resolveSnapshotByTagsPipeline;

        public CalculateVariationsSellPriceBlockExtension(IResolveActivePriceSnapshotByCardPipeline resolveSnapshotByCardPipeline, IResolveActivePriceSnapshotByTagsPipeline resolveActivePriceSnapshotByTagsPipeline)
      : base((string) null)
    {
            this._resolveSnapshotByCardPipeline = resolveSnapshotByCardPipeline;
            this._resolveSnapshotByTagsPipeline = resolveActivePriceSnapshotByTagsPipeline;
        }

        public override async Task<SellableItem> Run(SellableItem arg, CommercePipelineExecutionContext context)
        {
            if (arg == null)
                return (SellableItem)null;
            if (!arg.HasComponent<ItemVariationsComponent>())
                return arg;
            Product product = context.CommerceContext.GetObjects<Product>().FirstOrDefault<Product>((Func<Product, bool>)(p => p.ProductId.Equals(arg.FriendlyId, StringComparison.OrdinalIgnoreCase)));
            if (product == null)
                return arg;
            Sitecore.Commerce.Plugin.Catalog.Catalog catalog = context.CommerceContext.GetObjects<Sitecore.Commerce.Plugin.Catalog.Catalog>().FirstOrDefault<Sitecore.Commerce.Plugin.Catalog.Catalog>();
            if (catalog == null)
                return arg;
            string catalogCurrency = catalog.Currency.Code;
            string currentCurrency = context.CommerceContext.CurrentCurrency();
            string priceBookName = catalog.PriceBook.Name;
            PriceCardPolicy priceCardPolicy = arg.Policies.OfType<PriceCardPolicy>().FirstOrDefault<PriceCardPolicy>();
            ItemVariationsComponent component = arg.GetComponent<ItemVariationsComponent>();
            List<ItemVariationComponent> variationComponentList;
            if (component == null)
            {
                variationComponentList = (List<ItemVariationComponent>)null;
            }
            else
            {
                IList<Component> childComponents = component.ChildComponents;
                if (childComponents == null)
                {
                    variationComponentList = (List<ItemVariationComponent>)null;
                }
                else
                {
                    IEnumerable<ItemVariationComponent> source = childComponents.OfType<ItemVariationComponent>();
                    variationComponentList = source != null ? source.ToList<ItemVariationComponent>() : (List<ItemVariationComponent>)null;
                }
            }
            foreach (ItemVariationComponent variationComponent in variationComponentList)
            {
                ItemVariationComponent variation = variationComponent;
                if (!variation.HasPolicy<PurchaseOptionMoneyPolicy>() || !(variation.GetPolicy<PurchaseOptionMoneyPolicy>().Expires > DateTimeOffset.UtcNow))
                {
                    if (variation.HasComponent<PriceSnapshotComponent>())
                        variation.ChildComponents.Remove((Component)variation.GetComponent<PriceSnapshotComponent>());
                    Money variationSellPrice = (Money)null;
                    PriceCardPolicy variationPriceCardPolicy = variation.Policies.OfType<PriceCardPolicy>().FirstOrDefault<PriceCardPolicy>() ?? priceCardPolicy;
                    MessagesComponent variationMessagesComponent = variation.GetComponent<MessagesComponent>();
                    PriceSnapshotComponent snapshotComponent = (PriceSnapshotComponent)null;
                    bool pricingByTags = false;
                    PriceCardPolicy priceCardPolicy1 = variationPriceCardPolicy;
                    if (!string.IsNullOrEmpty(priceCardPolicy1 != null ? priceCardPolicy1.PriceCardName : (string)null))
                        snapshotComponent = await this._resolveSnapshotByCardPipeline.Run(variationPriceCardPolicy.PriceCardName, context);
                    else if (variation.Tags.Any<Tag>() || arg.Tags.Any<Tag>())
                    {
                        snapshotComponent = await this._resolveSnapshotByTagsPipeline.Run(variation.Tags.Any<Tag>() ? (IEnumerable<Tag>)variation.Tags : (IEnumerable<Tag>)arg.Tags, context);
                        pricingByTags = true;
                    }
                    PriceTier priceTier = snapshotComponent != null ? snapshotComponent.Tiers.FirstOrDefault<PriceTier>((Func<PriceTier, bool>)(t =>
                    {
                        if (t.Currency.Equals(currentCurrency, StringComparison.OrdinalIgnoreCase))
                            return t.Quantity == Decimal.One;
                        return false;
                    })) : (PriceTier)null;
                    if (priceTier != null)
                    {
                        variationSellPrice = new Money(priceTier.Currency, priceTier.Price);
                        variation.SetComponent((Component)snapshotComponent);
                        MessagesComponent messagesComponent = variationMessagesComponent;
                        string pricing = context.GetPolicy<KnownMessageCodePolicy>().Pricing;
                        string text;
                        if (!pricingByTags)
                            text = string.Format("Variation.SellPrice<=Variation.PriceCard.Snapshot: Price={0}|Qty={1}|Variation={2}|PriceCard={3}", new object[4]
                            {
                (object) variationSellPrice.AsCurrency(false),
                (object) priceTier.Quantity,
                (object) variation.Id,
                (object) variationPriceCardPolicy.PriceCardName
                            });
                        else
                            text = string.Format("Variation.SellPrice<=Variation.Tags.Snapshot: Price={0}|Qty={1}|Variation={2}|Tags='{3}'", new object[4]
                            {
                (object) variationSellPrice.AsCurrency(false),
                (object) priceTier.Quantity,
                (object) variation.Id,
                (object) string.Join(", ", snapshotComponent.Tags.Select<Tag, string>((Func<Tag, string>) (c => c.Name)))
                            });
                        messagesComponent.AddMessage(pricing, text);
                    }
                    if (variationSellPrice == null && currentCurrency.Equals(catalogCurrency, StringComparison.OrdinalIgnoreCase))
                    {
                        CommerceServer.Core.Catalog.Variant variant = ((ProductFamily)product).Variants.ToList<CommerceServer.Core.Catalog.Variant>().FirstOrDefault<CommerceServer.Core.Catalog.Variant>((Func<CommerceServer.Core.Catalog.Variant, bool>)(v => v.VariantId.Equals(variation.Id, StringComparison.OrdinalIgnoreCase)));
                        if (variant != null)
                        {
                            variationSellPrice = new Money(currentCurrency, variant.ListPrice);
                            variationMessagesComponent.AddMessage(context.GetPolicy<KnownMessageCodePolicy>().Pricing, string.Format("Variation.SellPrice<=Catalog.Product.Variation.ListPrice: Price={0}|Variation={1}", (object)variationSellPrice.AsCurrency(false), (object)variation.Id));
                        }
                    }
                    if (variationSellPrice != null)
                        variation.SetPolicy((Policy)new PurchaseOptionMoneyPolicy()
                        {
                            SellPrice = variationSellPrice
                        });
                    variationSellPrice = (Money)null;
                    variationPriceCardPolicy = (PriceCardPolicy)null;
                    variationMessagesComponent = (MessagesComponent)null;
                }
            }
            List<ItemVariationComponent>.Enumerator enumerator = new List<ItemVariationComponent>.Enumerator();
            return arg;
        }
    }
}
