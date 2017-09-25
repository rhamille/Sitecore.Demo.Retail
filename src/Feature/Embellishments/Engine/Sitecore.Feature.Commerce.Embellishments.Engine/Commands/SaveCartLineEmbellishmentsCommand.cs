using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.Embellishments.Engine.Components;
using Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines;
using Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Arguments;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Commands
{

    public class SaveCartLineEmbellishmentsCommand : CommerceCommand
    {
        private readonly ISaveCartLineEmbellishmentsPipeline _pipeline;
        private readonly IGetCartPipeline _cartPipeline;

        public SaveCartLineEmbellishmentsCommand(ISaveCartLineEmbellishmentsPipeline pipeline, IGetCartPipeline cartPipeline, IFindEntityPipeline findEntityPipeline, IServiceProvider serviceProvider)
            : base()
        {
            this._pipeline = pipeline;
            this._cartPipeline = cartPipeline;
        }

        public virtual async Task<Cart> Process(CommerceContext commerceContext, string cartId,
                string lineId,
                string itemId,
                string externalId,
                uint quantity,
                string type,
                string value)
        {

            CommercePipelineExecutionContextOptions context = commerceContext.GetPipelineContextOptions();

            Cart cart = await this._cartPipeline.Run(new ResolveCartArgument(commerceContext.CurrentShopName(), cartId, commerceContext.CurrentShopperId()), (IPipelineExecutionContextOptions)context).ConfigureAwait(false);

            if (cart != null)
                return await this.Process(commerceContext, cart, lineId, itemId, externalId, quantity, type, value).ConfigureAwait(false);
            
            string str = await context.CommerceContext.AddMessage(
                                commerceContext.GetPolicy<KnownResultCodes>().ValidationError
                                , "EntityNotFound", new object[1] { (object)cartId }
                                , string.Format("Entity {0} was not found.", (object)cartId)
                                );

            return (Cart)null;
        }

        public virtual async Task<Cart> Process(CommerceContext commerceContext, Cart cart,
                string lineId,
                string itemId,
                string externalId,
                uint quantity,
                string type,
                string value)
        {
            CommercePipelineExecutionContextOptions context = commerceContext.GetPipelineContextOptions();
            var cartLine = cart.Lines.First(line => line.Id == lineId);

            if (cartLine != null)
                return await this.Process(commerceContext, cart, cartLine, itemId, externalId, quantity, type, value).ConfigureAwait(false);
            
            string str = await context.CommerceContext.AddMessage(
                                commerceContext.GetPolicy<KnownResultCodes>().ValidationError
                                , "EntityNotFound", new object[1] { (object)lineId }
                                , string.Format("Entity {0} was not found.", (object)lineId)
                                );

            return (Cart)null;
        }

        public virtual async Task<Cart> Process(CommerceContext commerceContext, Cart cart, CartLineComponent cartLine,
                string itemId,
                string externalId,
                uint quantity,
                string type,
                string value)
        {
            using (var activity = CommandActivity.Start(commerceContext, this))
            {
                //Func<Task> func = await this.PerformTransaction(commerceContext, 
                //    (async () =>
                //    {

                CommercePipelineExecutionContextOptions context = commerceContext.GetPipelineContextOptions();
                CartLineArgument cartLineArgument = new CartLineArgument(cart, cartLine);
                if (cart != null)
                    await _pipeline.Run(new SaveCartLineEmbellishmentsArgument(cartLineArgument, new EmbellishmentComponent(itemId, externalId, quantity, type, value)), new CommercePipelineExecutionContextOptions(commerceContext)).ConfigureAwait(false);
                
                //    }
                //));
                return (Cart)null;
            }
        }
    }
}
