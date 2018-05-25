
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Plugin.Pricing;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Pipelines
{
    [PipelineDisplayName("Carts.CalculateCartSubLinesParentTotalsBlock")]
    public class CalculateCartSubLinesParentTotalsBlock : PipelineBlock<Cart, Cart, CommercePipelineExecutionContext>
    {
        public CalculateCartSubLinesParentTotalsBlock()
      : base((string) null)
    {
        }

        public override Task<Cart> Run(Cart arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<Cart>(arg).IsNotNull<Cart>(string.Format("{0}: The cart can not be null", (object)this.Name));
            GlobalPricingPolicy policy = context.GetPolicy<GlobalPricingPolicy>();
            string currencyCode = context.CommerceContext.CurrentCurrency();
            bool shouldRoundPriceCalc = policy.ShouldRoundPriceCalc;
            int roundDigits = policy.RoundDigits;
            bool midPointRoundUp = policy.MidPointRoundUp;
            foreach (CartLineComponent cartLineComponent in arg.Lines.Where<CartLineComponent>((Func<CartLineComponent, bool>)(l => l != null)))
            {
                Decimal amount = new Decimal();
                Decimal num = new Decimal();
                foreach (AwardedAdjustment adjustment in (IEnumerable<AwardedAdjustment>)cartLineComponent.Adjustments)
                {
                    if (shouldRoundPriceCalc)
                        adjustment.Adjustment.Amount = Decimal.Round(adjustment.Adjustment.Amount, roundDigits, midPointRoundUp ? MidpointRounding.AwayFromZero : MidpointRounding.ToEven);
                    if (adjustment.IncludeInGrandTotal)
                        num += adjustment.Adjustment.Amount;
                    amount += adjustment.Adjustment.Amount;
                }
                cartLineComponent.Totals.AdjustmentsTotal = new Money(currencyCode, amount);
                cartLineComponent.Totals.GrandTotal = new Money(currencyCode, cartLineComponent.Totals.SubTotal.Amount + num);
                cartLineComponent.Totals.PaymentsTotal = new Money(currencyCode, Decimal.Zero);
            }
            return Task.FromResult<Cart>(arg);
        }
    }
}
