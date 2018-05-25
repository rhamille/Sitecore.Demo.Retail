using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.SubLines.Engine.Components;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Pipelines.Blocks
{
    [PipelineDisplayName("Carts.PopulateCartSubLineComponentItemsBlock")]
    public class PopulateCartSubLineComponentItemsBlock : PipelineBlock<Cart, Cart, CommercePipelineExecutionContext>
    {
        private readonly IPopulateLineItemPipeline _populateLineItemPipeline;

        public PopulateCartSubLineComponentItemsBlock(IPopulateLineItemPipeline populateLineItemPipeline)
          : base((string)null)
        {
            this._populateLineItemPipeline = populateLineItemPipeline;
        }

        public override async Task<Cart> Run(Cart arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<Cart>(arg).IsNotNull<Cart>(string.Format("{0}: The cart can not be null", (object)this.Name));
            Condition.Requires<IList<CartLineComponent>>(arg.Lines).IsNotNull<IList<CartLineComponent>>(string.Format("{0} :The cart's lines can not be null", (object)this.Name));
            if (!arg.Lines.Any<CartLineComponent>())
                return arg;
            foreach (CartLineComponent cartLineComponent1 in arg.Lines.Where<CartLineComponent>((Func<CartLineComponent, bool>)(p => p.ParentId == null)))
            {
                var subLineComponent = cartLineComponent1.GetComponent<SubLinesComponent>(); //new SubLinesComponent() { ParentId = cartLineComponent1.ItemId };

                subLineComponent.ParentId = cartLineComponent1.ItemId;

                foreach (CartLineComponent cartSubLineComponent1 in arg.Lines.Where<CartLineComponent>((Func<CartLineComponent, bool>)(c => c.ParentId == cartLineComponent1.ItemId)))
                {
                    if (!string.IsNullOrEmpty(cartSubLineComponent1.ItemId))
                    {
                        //if (cartLineComponent1.ItemId.Split('|').Length == 3)
                        //{
                        //    CartLineComponent cartLineComponent2 = await this._populateLineItemPipeline.Run(cartLineComponent1, context).ConfigureAwait(false);
                        //}
                        if (!subLineComponent.GetComponents<CartLineComponent>().Where(cc => cc.ItemId == cartSubLineComponent1.ItemId).Any())
                        {
                            subLineComponent.ChildComponents.Add(cartSubLineComponent1);
                        }
                    }
                }
                cartLineComponent1.SetComponent(subLineComponent);
            }
            return arg;
        }
    }
}
