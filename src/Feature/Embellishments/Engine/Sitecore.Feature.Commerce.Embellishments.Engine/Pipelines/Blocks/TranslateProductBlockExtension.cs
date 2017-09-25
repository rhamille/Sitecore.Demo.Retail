using CommerceServer.Core.Catalog;
using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Plugin.Availability;
using Sitecore.Commerce.Plugin.Pricing;
using Sitecore.Framework.Caching;
using Sitecore.Framework.Conditions;
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
    public class TranslateProductBlockExtension : PipelineBlock<ProductArgument, SellableItem, CommercePipelineExecutionContext>
    {
        private readonly IFindEntityPipeline _findEntityPipeline;
        private readonly IGetEnvironmentCachePipeline _cachePipeline;
        private readonly GetProductCommand _getProductCommand;
        private readonly CloneEntityCommand _cloneEntityCommand;

        public TranslateProductBlockExtension(IFindEntityPipeline findEntityPipeline, GetProductCommand getProductCommand, CloneEntityCommand cloneEntityCommand, IGetEnvironmentCachePipeline cachePipeline)
      : base((string) null)
    {
            this._findEntityPipeline = findEntityPipeline;
            this._cachePipeline = cachePipeline;
            this._getProductCommand = getProductCommand;
            this._cloneEntityCommand = cloneEntityCommand;
        }

        public override async Task<SellableItem> Run(ProductArgument arg, CommercePipelineExecutionContext context)
        {
            SellableItem item = context.CommerceContext.GetObjects<SellableItem>().FirstOrDefault<SellableItem>((Func<SellableItem, bool>)(p => p.FriendlyId.Equals(arg.ProductId, StringComparison.OrdinalIgnoreCase)));
            if (item != null)
            {
                context.LogInfoIf(context.GetPolicy<Sitecore.Commerce.Plugin.Catalog.Cs.LoggingPolicy>().LogTranslateProductFromContext, string.Format("CS.TranslateProduct.FromContext-{0}: Catalog={1}", (object)arg.ProductId, (object)arg.CatalogName));
                return item;
            }
            context.LogInfoIf(context.GetPolicy<Sitecore.Commerce.Plugin.Catalog.Cs.LoggingPolicy>().LogTranslateProduct, string.Format("CS.TranslateProduct-{0}: Catalog={1}", (object)arg.ProductId, (object)arg.CatalogName));
            Product product = await this._getProductCommand.Process(context.CommerceContext, arg.CatalogName, arg.ProductId);
            if (product == null)
            {
                string str = await context.CommerceContext.AddMessage(context.GetPolicy<KnownResultCodes>().Error, "EntityNotFound", new object[1]
                {
          (object) arg.AsItemId()
                }, string.Format("Entity '{0}' was not found.", (object)arg.AsItemId()));
                return (SellableItem)null;
            }
            item = await this.GetItemTemplate(product, arg, context);
            if (item == null)
                return (SellableItem)null;
            SellableItem itemTemplate = await this._cloneEntityCommand.Process<SellableItem>(context.CommerceContext, (CommerceEntity)item, item.Id);
            item = this.TranslateSellableItem(product, itemTemplate, context);
            if (item == null)
            {
                context.Logger.LogError(string.Format("{0}.NullItem: ProductId={1}", (object)this.Name, (object)arg.ProductId), Array.Empty<object>());
                return (SellableItem)null;
            }
            item.RemovePolicy(typeof(PurchaseOptionMoneyPolicy));
            item.ListPrice = (Money)null;
            this.TranslateSellableItemComponents(product, item, context);
            this.TranslateSellableItemPolicies(product, item, context);
            if (!(product is ProductFamily))
                return item;
            await this.TranslateVariations(item, item, (ProductFamily)product, context);
            if (string.IsNullOrEmpty(arg.VariantId) || !item.HasComponent<ItemVariationsComponent>() || item.GetComponent<ItemVariationsComponent>().ChildComponents.OfType<ItemVariationComponent>().ToList<ItemVariationComponent>().Any<ItemVariationComponent>((Func<ItemVariationComponent, bool>)(v => v.Id.Equals(arg.VariantId))))
                return item;
            string str1 = await context.CommerceContext.AddMessage(context.GetPolicy<KnownResultCodes>().Error, "EntityNotFound", new object[1]
            {
        (object) arg.AsItemId()
            }, string.Format("Entity '{0}' was not found.", (object)arg.AsItemId()));
            return (SellableItem)null;
        }

        private async Task<SellableItem> GetItemTemplate(Product product, ProductArgument arg, CommercePipelineExecutionContext context)
        {
            SellableItem sellableItem1 = await this._findEntityPipeline.Run(new FindEntityArgument(typeof(SellableItem), string.Format("{0}{1}", (object)CommerceEntity.IdPrefix<SellableItem>(), (object)arg.ProductId), false), context) as SellableItem;
            if (sellableItem1 != null)
                return sellableItem1;
            context.Logger.LogDebug(string.Format("{0}: No specific SellableItem '{1}{2}' was found.", (object)this.Name, (object)CommerceEntity.IdPrefix<SellableItem>(), (object)arg.ProductId), Array.Empty<object>());
            SellableItem sellableItem2 = await this._findEntityPipeline.Run(new FindEntityArgument(typeof(SellableItem), string.Format("{0}{1}", (object)CommerceEntity.IdPrefix<SellableItem>(), (object)product.DefinitionName), false), context) as SellableItem;
            if (sellableItem2 != null)
                return sellableItem2.Clone<SellableItem>() as SellableItem;
            context.Logger.LogDebug(string.Format("{0}: No specific ItemTemplate '{1}' was found.", (object)this.Name, (object)product.DefinitionName), Array.Empty<object>());
            SellableItem sellableItem3;
            if (product is ProductFamily)
                sellableItem3 = await this._findEntityPipeline.Run(new FindEntityArgument(typeof(SellableItem), string.Format("{0}DefaultProductFamilyTemplate", (object)CommerceEntity.IdPrefix<SellableItem>()), false), context) as SellableItem;
            else
                sellableItem3 = await this._findEntityPipeline.Run(new FindEntityArgument(typeof(SellableItem), string.Format("{0}DefaultTemplate", (object)CommerceEntity.IdPrefix<SellableItem>()), false), context) as SellableItem;
            if (sellableItem3 != null)
                return sellableItem3.Clone<SellableItem>() as SellableItem;
            string str = await context.CommerceContext.AddMessage(context.GetPolicy<KnownResultCodes>().Error, "ItemTemplateNotFound", new object[1]
            {
        (object) arg.ProductId
            }, string.Format("ItemTemplate or SellableItem were not found for product {0}.", (object)arg.ProductId));
            context.Logger.LogWarning(string.Format("{0}: ItemTemplate or SellableItem were not found for product {1}.", (object)this.Name, (object)arg.ProductId), Array.Empty<object>());
            return (SellableItem)null;
        }

        private SellableItem TranslateSellableItem(Product product, SellableItem itemTemplate, CommercePipelineExecutionContext context)
        {
            Condition.Requires<SellableItem>(itemTemplate).IsNotNull<SellableItem>(string.Format("{0}: The sellable item template should not be null", (object)this.Name));
            Condition.Requires<Product>(product).IsNotNull<Product>(string.Format("{0}: The product should not be null", (object)this.Name));
            Condition.Requires<CommercePipelineExecutionContext>(context).IsNotNull<CommercePipelineExecutionContext>(string.Format("{0}: The context should not be null", (object)this.Name));
            CsItemFieldsPolicy policy = context.GetPolicy<CsItemFieldsPolicy>();
            SellableItem sellableItem = itemTemplate;
            if (sellableItem == null)
                return (SellableItem)null;
            sellableItem.Id = string.Format("{0}{1}", (object)CommerceEntity.IdPrefix<SellableItem>(), (object)product.ProductId);
            sellableItem.FriendlyId = product.ProductId;
            sellableItem.DisplayName = product.DisplayName;
            sellableItem.Name = product.DisplayName;
            sellableItem.ItemTemplate = product.DefinitionName;
            DateTime result = DateTime.Today;
            if (product.HasProperty(policy.IntroductionDate) && product[policy.IntroductionDate] != null)
                DateTime.TryParse(product[policy.IntroductionDate].ToString(), out result);
            sellableItem.DateCreated = new DateTimeOffset?((DateTimeOffset)result);
            List<Tag> itemTags = new List<Tag>();
            if (product.HasProperty(policy.Tags) && product[policy.Tags] != null)
                ((IEnumerable<string>)product[policy.Tags].ToString().Split(',')).Where<string>((Func<string, bool>)(t => !string.IsNullOrEmpty(t))).ForEach<string>((Action<string>)(t => itemTags.Add(new Tag(t))));
            sellableItem.Tags = (IList<Tag>)itemTags;
            return sellableItem;
        }

        private void TranslateSellableItemComponents(Product product, SellableItem item, CommercePipelineExecutionContext context)
        {
            Condition.Requires<SellableItem>(item).IsNotNull<SellableItem>(string.Format("{0}: The sellable item should not be null", (object)this.Name));
            Condition.Requires<Product>(product).IsNotNull<Product>(string.Format("{0}: The product should not be null", (object)this.Name));
            Condition.Requires<CommercePipelineExecutionContext>(context).IsNotNull<CommercePipelineExecutionContext>(string.Format("{0}: The context should not be null", (object)this.Name));
            CsItemFieldsPolicy policy = context.GetPolicy<CsItemFieldsPolicy>();
            item.GetComponent<ClassificationComponent>().Class = product[policy.DefinitionName].ToString();
            //item.GetComponent<CatalogComponent>().Name = product.BaseCatalogName;
            item.GetComponent<CatalogComponent>().Name = product.CatalogName;
            if (product is ProductFamily)
                return;
            item.GetComponent<ExternalMappingComponent>().ExternalId = product.ExternalId.ToString("D");
        }

        private void TranslateSellableItemPolicies(Product product, SellableItem item, CommercePipelineExecutionContext context)
        {
            Condition.Requires<SellableItem>(item).IsNotNull<SellableItem>(string.Format("{0}: The sellable item should not be null", (object)this.Name));
            Condition.Requires<Product>(product).IsNotNull<Product>(string.Format("{0}: The product should not be null", (object)this.Name));
            Condition.Requires<CommercePipelineExecutionContext>(context).IsNotNull<CommercePipelineExecutionContext>(string.Format("{0}: The context should not be null", (object)this.Name));
            CsItemFieldsPolicy policy = context.GetPolicy<CsItemFieldsPolicy>();
            if (item.HasPolicy<PriceCardPolicy>())
                item.Policies.Remove((Policy)item.GetPolicy<PriceCardPolicy>());
            if (product.HasProperty(policy.PriceCardName) && product[policy.PriceCardName] != null)
            {
                string str = product[policy.PriceCardName] as string;
                if (!string.IsNullOrEmpty(str))
                    item.GetPolicy<PriceCardPolicy>().PriceCardName = str;
            }
            try
            {
                if (product[policy.OnSale] == null || product[policy.OnSale].ToString() != "True")
                {
                    if (!item.HasPolicy<OnSalePolicy>())
                        return;
                    item.Policies.Remove((Policy)item.GetPolicy<OnSalePolicy>());
                }
                else
                    item.GetPolicy<OnSalePolicy>().OnSale = true;
            }
            catch (NullReferenceException ex)
            {
                context.CommerceContext.LogException(string.Format("{0} - NullField: {1}", (object)this.Name, (object)policy.OnSale), (Exception)ex);
            }
            catch (Exception ex)
            {
                context.CommerceContext.LogException(this.Name, ex);
            }
        }

        private async Task TranslateVariations(SellableItem item, SellableItem itemTemplate, ProductFamily productFamily, CommercePipelineExecutionContext context)
        {
            Condition.Requires<SellableItem>(item).IsNotNull<SellableItem>(string.Format("{0}: The sellable item should not be null", (object)this.Name));
            Condition.Requires<SellableItem>(itemTemplate).IsNotNull<SellableItem>(string.Format("{0}: The sellable item template should not be null", (object)this.Name));
            Condition.Requires<ProductFamily>(productFamily).IsNotNull<ProductFamily>(string.Format("{0}: The product family should not be null", (object)this.Name));
            Condition.Requires<CommercePipelineExecutionContext>(context).IsNotNull<CommercePipelineExecutionContext>(string.Format("{0}: The context should not be null", (object)this.Name));
            ItemVariationsComponent variationsComponent = item.GetComponent<ItemVariationsComponent>();
            if (context.CommerceContext.Objects.OfType<ProductArgument>().FirstOrDefault<ProductArgument>() == null)
                context.Logger.LogError(string.Format("{0}-ProductArgument not on Objects collection: FriendlyId:{1}", (object)this.Name, (object)item.FriendlyId), Array.Empty<object>());
            CsCachePolicy cachePolicy = context.GetPolicy<CsCachePolicy>();
            string cacheKey = string.Format("{0}|{1}_Variations", (object)context.CommerceContext.CurrentLanguage(), (object)productFamily.ProductId);
            ICache cache = (ICache)null;
            List<CommerceServer.Core.Catalog.Variant> variants = (List<CommerceServer.Core.Catalog.Variant>)null;
            if (cachePolicy.AllowCaching)
            {
                IGetEnvironmentCachePipeline cachePipeline = this._cachePipeline;
                EnvironmentCacheArgument environmentCacheArgument = new EnvironmentCacheArgument();
                environmentCacheArgument.CacheName = cachePolicy.ProductsCacheName;
                CommercePipelineExecutionContext context1 = context;
                cache = await cachePipeline.Run(environmentCacheArgument, context1);
                variants = await cache.Get(cacheKey) as List<CommerceServer.Core.Catalog.Variant>;
            }
            if (variants == null)
            {
                variants = productFamily.Variants.ToList<CommerceServer.Core.Catalog.Variant>();
                if (cachePolicy.AllowCaching && cache != null)
                    await cache.Set(cacheKey, (ICachable)new Cachable<List<CommerceServer.Core.Catalog.Variant>>(variants, 1L), cachePolicy.GetCacheEntryOptions());
                context.Logger.LogInformation("CsCatalog.TranslateVar.LoadedVariations", Array.Empty<object>());
            }
            ItemVariationsComponent component = itemTemplate.GetComponent<ItemVariationsComponent>();
            lock (variationsComponent.ChildComponents)
            {
                foreach (CommerceServer.Core.Catalog.Variant item_0 in variants.Where<CommerceServer.Core.Catalog.Variant>((Func<CommerceServer.Core.Catalog.Variant, bool>)(v => v != null)))
                {
                    CommerceServer.Core.Catalog.Variant variant = item_0;
                    ItemVariationComponent local_13;
                    if (component.ChildComponents.OfType<ItemVariationComponent>().Any<ItemVariationComponent>((Func<ItemVariationComponent, bool>)(v => v.Id.Equals(variant.VariantId, StringComparison.OrdinalIgnoreCase))))
                    {
                        local_13 = component.GetComponents<ItemVariationComponent>().FirstOrDefault<ItemVariationComponent>((Func<ItemVariationComponent, bool>)(v => v.Id.Equals(variant.VariantId, StringComparison.OrdinalIgnoreCase)));
                    }
                    else
                    {
                        ItemVariationComponent temp_79 = new ItemVariationComponent();
                        string temp_82 = variant.VariantId;
                        temp_79.Id = temp_82;
                        string temp_85 = variant.DisplayName;
                        temp_79.Name = temp_85;
                        local_13 = temp_79;
                        variationsComponent.ChildComponents.Add((Component)local_13);
                    }
                    if (local_13 != null)
                    {
                        local_13.RemovePolicy(typeof(PurchaseOptionMoneyPolicy));
                        local_13.ListPrice = (Money)null;
                        local_13.DisplayName = variant.DisplayName;
                        local_13.Name = variant.DisplayName;
                        CsItemFieldsPolicy local_14 = context.GetPolicy<CsItemFieldsPolicy>();
                        List<Tag> variationTags = new List<Tag>();
                        try
                        {
                            object temp_113 = variant[local_14.VariantTags];
                            string[] temp_119;
                            if (temp_113 == null)
                                temp_119 = (string[])null;
                            else
                                temp_119 = temp_113.ToString().Split(',');
                            if (temp_119 != null)
                                ((IEnumerable<string>)temp_119).Where<string>((Func<string, bool>)(t => !string.IsNullOrEmpty(t))).ForEach<string>((Action<string>)(t => variationTags.Add(new Tag(t))));
                        }
                        catch (ArgumentException exception_1)
                        {
                            context.CommerceContext.LogException(this.Name, (Exception)exception_1);
                        }
                        local_13.Tags = (IList<Tag>)variationTags;
                        this.TranslateVariationComponents(item, local_13, variant, context);
                        this.TranslateVariationPolicies(local_13, variant, context);
                    }
                }
            }
        }

        private void TranslateVariationComponents(SellableItem item, ItemVariationComponent variation, CommerceServer.Core.Catalog.Variant variant, CommercePipelineExecutionContext context)
        {
            Condition.Requires<SellableItem>(item).IsNotNull<SellableItem>(string.Format("{0}: The item should not be null", (object)this.Name));
            Condition.Requires<ItemVariationComponent>(variation).IsNotNull<ItemVariationComponent>(string.Format("{0}: The item variation should not be null", (object)this.Name));
            Condition.Requires<CommerceServer.Core.Catalog.Variant>(variant).IsNotNull<CommerceServer.Core.Catalog.Variant>(string.Format("{0}: The product variant should not be null", (object)this.Name));
            Condition.Requires<CommercePipelineExecutionContext>(context).IsNotNull<CommercePipelineExecutionContext>(string.Format("{0}: The context should not be null", (object)this.Name));
            variation.GetComponent<ExternalMappingComponent>().ExternalId = variant.ExternalId.ToString("D");
            CsItemFieldsPolicy policy = context.GetPolicy<CsItemFieldsPolicy>();
            if (!variation.HasComponent<PhysicalItemComponent>())
            {
                DigitalItemTagsPolicy digitalItemTagsPolicy = context.GetPolicy<DigitalItemTagsPolicy>();
                if ((variation.Tags.Count == 0 ? (IEnumerable<Tag>)item.Tags : (IEnumerable<Tag>)variation.Tags).Any<Tag>((Func<Tag, bool>)(tag => digitalItemTagsPolicy.TagList.Contains<string>(tag.Name, (IEqualityComparer<string>)StringComparer.OrdinalIgnoreCase))))
                    return;
            }
            PhysicalItemComponent component = variation.GetComponent<PhysicalItemComponent>();
            try
            {
                component.Color = variant[policy.ProductColor] as string;
            }
            catch (ArgumentException ex)
            {
                component.Color = string.Empty;
            }
            try
            {
                if (!variant.DataRow.Table.Columns.Contains(policy.ProductSize))
                    return;
                component.Size = variant[policy.ProductSize] as string;
            }
            catch (ArgumentException ex)
            {
                component.Size = string.Empty;
            }
        }

        private void TranslateVariationPolicies(ItemVariationComponent variation, CommerceServer.Core.Catalog.Variant variant, CommercePipelineExecutionContext context)
        {
            Condition.Requires<ItemVariationComponent>(variation).IsNotNull<ItemVariationComponent>(string.Format("{0}: The item variation should not be null", (object)this.Name));
            Condition.Requires<CommerceServer.Core.Catalog.Variant>(variant).IsNotNull<CommerceServer.Core.Catalog.Variant>(string.Format("{0}: The product variant should not be null", (object)this.Name));
            Condition.Requires<CommercePipelineExecutionContext>(context).IsNotNull<CommercePipelineExecutionContext>(string.Format("{0}: The context should not be null", (object)this.Name));
            CsItemFieldsPolicy policy = context.GetPolicy<CsItemFieldsPolicy>();
            try
            {
                if (variant[policy.OnSale] == null || variant[policy.OnSale].ToString() != "True")
                {
                    if (variation.HasPolicy<OnSalePolicy>())
                        variation.Policies.Remove((Policy)variation.GetPolicy<OnSalePolicy>());
                }
                else
                    variation.GetPolicy<OnSalePolicy>().OnSale = true;
            }
            catch (NullReferenceException ex)
            {
                context.CommerceContext.LogException(string.Format("{0} - Missing Field:({1})", (object)this.Name, (object)policy.OnSale), (Exception)ex);
            }
            catch (Exception ex)
            {
                context.CommerceContext.LogException(this.Name, ex);
            }
            if (variation.HasPolicy<PriceCardPolicy>())
                variation.Policies.Remove((Policy)variation.GetPolicy<PriceCardPolicy>());
            try
            {
                string str = variant[policy.VariationPriceCardName] as string;
                if (string.IsNullOrEmpty(str))
                    return;
                variation.GetPolicy<PriceCardPolicy>().PriceCardName = str;
            }
            catch (Exception ex)
            {
                context.CommerceContext.LogException(this.Name, ex);
            }
        }
    }
}
