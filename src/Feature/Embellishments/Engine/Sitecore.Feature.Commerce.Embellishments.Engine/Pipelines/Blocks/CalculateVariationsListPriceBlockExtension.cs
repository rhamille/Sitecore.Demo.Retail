using Sitecore.Commerce.Core;
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
    public class CalculateVariationsListPriceBlockExtension : PipelineBlock<SellableItem, SellableItem, CommercePipelineExecutionContext>
    {
        private readonly IFindEntityPipeline _findEntityPipeline;
        private SellableItem _itemTemplateByDefinition;

        public CalculateVariationsListPriceBlockExtension(IFindEntityPipeline findEntityPipeline)
      : base((string) null)
    {
            this._findEntityPipeline = findEntityPipeline;
        }

        public override async Task<SellableItem> Run(SellableItem arg, CommercePipelineExecutionContext context)
        {
            if (arg == null)
                return (SellableItem)null;
            if (!arg.HasComponent<ItemVariationsComponent>())
                return arg;
            await this.CalculateVariationsListPrice(arg, context);
            return arg;
        }

        private async Task CalculateVariationsListPrice(SellableItem item, CommercePipelineExecutionContext context)
        {
            Condition.Requires<SellableItem>(item).IsNotNull<SellableItem>(string.Format("{0} sellable item cannot be null.", (object)this.Name));
            string currentCurrency = context.CommerceContext.CurrentCurrency();
            ItemVariationsComponent component1 = item.GetComponent<ItemVariationsComponent>();
            List<ItemVariationComponent> variationComponentList;
            if (component1 == null)
            {
                variationComponentList = (List<ItemVariationComponent>)null;
            }
            else
            {
                IList<Component> childComponents = component1.ChildComponents;
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
                if (variation.ListPrice == null || !variation.HasPolicy<PurchaseOptionMoneyPolicy>() || !(variation.GetPolicy<PurchaseOptionMoneyPolicy>().Expires > DateTimeOffset.UtcNow))
                {
                    Money listPrice = (Money)null;
                    if (variation.HasPolicy<ListPricingPolicy>() && variation.GetPolicy<ListPricingPolicy>().Prices.Any<Money>((Func<Money, bool>)(p => p.CurrencyCode.Equals(currentCurrency, StringComparison.OrdinalIgnoreCase))))
                    {
                        listPrice = variation.GetPolicy<ListPricingPolicy>().Prices.FirstOrDefault<Money>((Func<Money, bool>)(p => p.CurrencyCode.Equals(currentCurrency, StringComparison.OrdinalIgnoreCase)));
                        MessagesComponent component2 = variation.GetComponent<MessagesComponent>();
                        string pricing = context.GetPolicy<KnownMessageCodePolicy>().Pricing;
                        string format = "Variation.ListPrice<=Variation.PricePolicy: Variation={0}|Price={1}";
                        string id = variation.Id;
                        Money money = listPrice;
                        string str;
                        if (money == null)
                        {
                            str = (string)null;
                        }
                        else
                        {
                            int num = 0;
                            str = money.AsCurrency(num != 0);
                        }
                        string text = string.Format(format, (object)id, (object)str);
                        component2.AddMessage(pricing, text);
                    }
                    if (listPrice == null && item.HasPolicy<ListPricingPolicy>() && item.GetPolicy<ListPricingPolicy>().Prices.Any<Money>((Func<Money, bool>)(p => p.CurrencyCode.Equals(currentCurrency, StringComparison.OrdinalIgnoreCase))))
                    {
                        listPrice = item.GetPolicy<ListPricingPolicy>().Prices.FirstOrDefault<Money>((Func<Money, bool>)(p => p.CurrencyCode.Equals(currentCurrency, StringComparison.OrdinalIgnoreCase)));
                        MessagesComponent component2 = variation.GetComponent<MessagesComponent>();
                        string pricing = context.GetPolicy<KnownMessageCodePolicy>().Pricing;
                        string format = "Variation.ListPrice<=Item.PricingPolicy: Variation={0}|Price={1}";
                        string id = variation.Id;
                        Money money = listPrice;
                        string str;
                        if (money == null)
                        {
                            str = (string)null;
                        }
                        else
                        {
                            int num = 0;
                            str = money.AsCurrency(num != 0);
                        }
                        string text = string.Format(format, (object)id, (object)str);
                        component2.AddMessage(pricing, text);
                    }
                    if (listPrice == null)
                    {
                        if (this._itemTemplateByDefinition == null)
                        {
                            string str = item.GetComponent<ClassificationComponent>().Class;
                            //CalculateVariationsListPriceBlock variationsListPriceBlock = this;
                            //SellableItem templateByDefinition = variationsListPriceBlock._itemTemplateByDefinition;
                            CommerceEntity commerceEntity = await this._findEntityPipeline.Run(new FindEntityArgument(typeof(SellableItem), string.Format("{0}{1}", (object)CommerceEntity.IdPrefix<SellableItem>(), (object)str), false), context);
                            this._itemTemplateByDefinition = commerceEntity as SellableItem;
                            //variationsListPriceBlock = (CalculateVariationsListPriceBlock)null;
                        }
                        if (this._itemTemplateByDefinition != null && this._itemTemplateByDefinition.HasPolicy<ListPricingPolicy>())
                        {
                            listPrice = this._itemTemplateByDefinition.GetPolicy<ListPricingPolicy>().Prices.FirstOrDefault<Money>((Func<Money, bool>)(p => p.CurrencyCode.Equals(currentCurrency, StringComparison.OrdinalIgnoreCase)));
                            MessagesComponent component2 = variation.GetComponent<MessagesComponent>();
                            string pricing = context.GetPolicy<KnownMessageCodePolicy>().Pricing;
                            string format = "Variation.ListPrice<=Template.PricingPolicy: Variation={0}|Price={1}";
                            string id = variation.Id;
                            Money money = listPrice;
                            string str;
                            if (money == null)
                            {
                                str = (string)null;
                            }
                            else
                            {
                                int num = 0;
                                str = money.AsCurrency(num != 0);
                            }
                            string text = string.Format(format, (object)id, (object)str);
                            component2.AddMessage(pricing, text);
                        }
                    }
                    variation.ListPrice = listPrice;
                    listPrice = (Money)null;
                    variation = (ItemVariationComponent)null;
                }
            }
            List<ItemVariationComponent>.Enumerator enumerator = new List<ItemVariationComponent>.Enumerator();
        }
    }
}
