using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Pricing;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class FilterPriceSnapshotsByDateBlockExtension : PipelineBlock<PriceCard, PriceSnapshotComponent, CommercePipelineExecutionContext>
    {
        public FilterPriceSnapshotsByDateBlockExtension()
      : base((string) null)
    {
        }

        public override async Task<PriceSnapshotComponent> Run(PriceCard arg, CommercePipelineExecutionContext context)
        {
            if (arg != null)
            {
                PriceCard priceCard = arg;
                DateTimeOffset effectiveDate = context.CommerceContext.CurrentEffectiveDate();
                PriceSnapshotComponent snapshotComponent1 = priceCard.Snapshots.Where<PriceSnapshotComponent>((Func<PriceSnapshotComponent, bool>)(s =>
                {
                    if (s.IsApproved(context.CommerceContext))
                        return s.BeginDate.CompareTo(effectiveDate) <= 0;
                    return false;
                })).OrderByDescending<PriceSnapshotComponent, DateTimeOffset>((Func<PriceSnapshotComponent, DateTimeOffset>)(s => s.BeginDate)).FirstOrDefault<PriceSnapshotComponent>();
                if (snapshotComponent1 != null)
                {
                    PriceSnapshotComponent snapshotComponent2 = new PriceSnapshotComponent(snapshotComponent1.BeginDate);
                    string id = snapshotComponent1.Id;
                    snapshotComponent2.Id = id;
                    IList<Component> childComponents = snapshotComponent1.ChildComponents;
                    snapshotComponent2.ChildComponents = childComponents;
                    IList<Component> snapshotComponents = snapshotComponent1.SnapshotComponents;
                    snapshotComponent2.SnapshotComponents = snapshotComponents;
                    IList<Tag> tags = snapshotComponent1.Tags;
                    snapshotComponent2.Tags = tags;
                    string currency = context.CommerceContext.CurrentCurrency();
                    List<PriceTier> list = snapshotComponent1.Tiers.Where<PriceTier>((Func<PriceTier, bool>)(t => t.Currency.Equals(currency, StringComparison.OrdinalIgnoreCase))).ToList<PriceTier>();
                    snapshotComponent2.Tiers = (IList<PriceTier>)list;
                    return snapshotComponent2;
                }
            }
            CommerceContext commerceContext = context.CommerceContext;
            string information = context.GetPolicy<KnownResultCodes>().Information;
            string commerceTermKey = "ActivePriceSnapshotNotFound";
            // ISSUE: variable of the null type
            //__Null local1 = null;
            string format = "{0}.ActivePriceSnapshot.NotFound: Card={1}|EffectiveDate={2}";
            string name = this.Name;
            PriceCard priceCard1 = arg;
            string str1 = priceCard1 != null ? priceCard1.Name : (string)null;
            // ISSUE: variable of a boxed type
            //__Boxed<DateTimeOffset> local2 = (ValueType)context.CommerceContext.CurrentEffectiveDate();
            string defaultMessage = string.Format(format, (object)name, (object)str1, (object)context.CommerceContext.CurrentEffectiveDate());
            string str2 = await commerceContext.AddMessage(information, commerceTermKey, (object[])null, defaultMessage);
            return (PriceSnapshotComponent)null;
        }
    }
}
