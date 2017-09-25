using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Arguments;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{

    public class SaveCartLineEmbellishmentsBlock : PipelineBlock<SaveCartLineEmbellishmentsArgument, Cart, CommercePipelineExecutionContext>
    {

        public SaveCartLineEmbellishmentsBlock()
          : base(null)
        {
        }

        public override Task<Cart> Run(SaveCartLineEmbellishmentsArgument arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull("The argument can not be null");

            //var cartlineArg = context.CommerceContext.GetObjects<CartLineArgument>().First();
            //var cartLine = arg.Cart.Line;

            //if (cartLine.ItemId.Split('|').Length >= 3)
            //{
            //    var friendlyId = cartLine.ItemId.Split('|').GetValue(1).ToString();
            //    //var sellableItem = context.CommerceContext.GetObjects<EmbellishmentsComponent>().FirstOrDefault(p => p.FriendlyId.Equals(friendlyId, StringComparison.OrdinalIgnoreCase));

            //}

            arg.CartLine.SetComponent(arg.Embellishment);


            return Task.FromResult(arg.Cart);
        }
    }
}