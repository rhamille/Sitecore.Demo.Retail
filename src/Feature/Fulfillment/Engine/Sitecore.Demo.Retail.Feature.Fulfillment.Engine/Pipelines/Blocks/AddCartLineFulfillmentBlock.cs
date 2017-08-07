using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Catalog;
using Sitecore.Framework.Pipelines;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Framework.Conditions;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;
using System;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PipelineBlock{Cart, Cart, CommercePipelineExecutionContext}" />
    [PipelineDisplayName(FulfillmentConstants.Pipelines.Blocks.AddCartLineFulfillmentBlock)]
    public class AddCartLineFulfillmentBlock : PipelineBlock<Cart, Cart, CommercePipelineExecutionContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddCartLineFulfillmentBlock"/> class.
        /// </summary>
        public AddCartLineFulfillmentBlock()
          : base(null)
        {
        }

        /// <summary>
        /// Runs the specified argument.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public override Task<Cart> Run(Cart arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull("The argument can not be null");

            var cartlineArg = context.CommerceContext.GetObjects<CartLineArgument>().First();
            var cartLine = cartlineArg.Line;

            if(cartLine.ItemId.Split('|').Length >= 3)
            {
                var friendlyId = cartLine.ItemId.Split('|').GetValue(1).ToString();
                var sellableItem = context.CommerceContext.GetObjects<SellableItem>().FirstOrDefault(p => p.FriendlyId.Equals(friendlyId, StringComparison.OrdinalIgnoreCase));

                cartLine.SetComponent(sellableItem.GetComponent<FulfillmentFeeComponent>());
            }

            return Task.FromResult(arg);
        }
    }
}