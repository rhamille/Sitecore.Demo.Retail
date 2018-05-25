using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Plugin.Pricing;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Pipelines
{
    [PipelineDisplayName("Carts.CalculateCartSubLinesSubTotalsBlock")]
    public class CalculateCartSubLinesSubTotalsBlock : PipelineBlock<Cart, Cart, CommercePipelineExecutionContext>
    {
        public CalculateCartSubLinesSubTotalsBlock()
      : base((string) null)
    {
        }

        public override Task<Cart> Run(Cart arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<Cart>(arg).IsNotNull<Cart>(string.Format("{0}: The cart can not be null", (object)this.Name));
            string currencyCode = context.CommerceContext.CurrentCurrency();
            foreach (CartLineComponent cartLineComponent in arg.Lines.Where<CartLineComponent>((Func<CartLineComponent, bool>)(l => l != null && l.ParentId == null)))
            {
                decimal parentListPrice = 0.0M;
                decimal parentSubTotal = 0.0M;
                foreach (CartLineComponent cartSubLineComponent1 in arg.Lines.Where<CartLineComponent>((Func<CartLineComponent, bool>)(c => c.ParentId == cartLineComponent.ItemId)))
                {
                    PurchaseOptionMoneyPolicy policy = cartSubLineComponent1.GetPolicy<PurchaseOptionMoneyPolicy>();
                    parentSubTotal += (policy.SellPrice.Amount * cartSubLineComponent1.Quantity);
                    parentListPrice += (policy.SellPrice.Amount);
                    //cartSubLineComponent1.Totals.GrandTotal = new Money(currencyCode, 0.00M);

                }
                if (cartLineComponent.HasPolicy<PurchaseOptionMoneyPolicy>())
                {
                    PurchaseOptionMoneyPolicy policy = cartLineComponent.GetPolicy<PurchaseOptionMoneyPolicy>();
                    //cartLineComponent.Totals.GrandTotal = new Money(currencyCode, parentSubTotal);
                    cartLineComponent.Totals.SubTotal = new Money(currencyCode, parentSubTotal);
                    policy.SellPrice = new Money(currencyCode, parentSubTotal);
                    cartLineComponent.UnitListPrice = policy.SellPrice;
                }
                else
                    cartLineComponent.Totals.SubTotal = new Money(currencyCode, Decimal.Zero);
            }
            return Task.FromResult<Cart>(arg);
        }
    }
}
