using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Plugin.ManagedLists;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Carts;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Commands
{
    public class AddCartLineWithSubLinesCommand : CommerceCommand
    {
        private readonly IAddCartLinePipeline _addToCartpipeline;
        private readonly IFindEntityPipeline _getPipeline;

        public AddCartLineWithSubLinesCommand(IFindEntityPipeline getCartPipeline, IAddCartLinePipeline addToCartpipeline, IServiceProvider serviceProvider)
      : base(serviceProvider)
        {
            this._getPipeline = getCartPipeline;
            this._addToCartpipeline = addToCartpipeline;
        }

        public virtual async Task<Cart> Process(CommerceContext commerceContext, string cartId, CartLineComponent line)
        {
            Cart result = (Cart)null;
            //Cart cart1;
            using (CommandActivity.Start(commerceContext, (CommerceCommand)this))
            {
                // ISSUE: variable of a compiler-generated type
                var command = this.Command<AddCartLineWithSubLinesCommand>();
                Func<Task> func = await this.PerformTransaction(commerceContext, (Func<Task>)(async () =>
                {
                    CommercePipelineExecutionContextOptions context = commerceContext.GetPipelineContextOptions();
                    Cart cart = await this._getPipeline.Run(new FindEntityArgument(typeof(Cart), cartId, true), (IPipelineExecutionContextOptions)context).ConfigureAwait(false) as Cart;
                    if (cart == null)
                    {
                        string str = await context.CommerceContext.AddMessage(commerceContext.GetPolicy<KnownResultCodes>().ValidationError, "EntityNotFound", new object[1]
                        {
                    (object) cartId
                        }, string.Format("Entity {0} was not found.", (object)cartId));
                    }
                    else
                    {
                        if (!cart.IsPersisted)
                        {
                            cart.Id = cartId;
                            cart.Name = cartId;
                            cart.ShopName = commerceContext.CurrentShopName();
                            cart.SetComponent((Component)new ListMembershipsComponent()
                            {
                                Memberships = (IList<string>)new List<string>()
                            {
                              CommerceEntity.ListName<Cart>()
                            }
                            });
                        }
                        // ISSUE: variable of a compiler-generated type
                        //AddCartLineCommand cDisplayClass30 = cDisplayClass30_1;
                        // ISSUE: reference to a compiler-generated field
                        //Cart result1 = command.result;
                        var cartResult = await this._addToCartpipeline.Run(new CartLineArgument(cart, line), (IPipelineExecutionContextOptions)context).ConfigureAwait(false);
                        result = cartResult;
                        cartResult = null;
                        // ISSUE: reference to a compiler-generated field
                        //cDisplayClass30.result = cart2;
                        //cDisplayClass30 = (AddCartLineCommand.\u003C\u003Ec__DisplayClass3_0) null;
                    }
                }));
                //cart1 = result;
            }
            return result;
        }

        public async Task<Cart> Process(CommerceContext commerceContext, Cart cart, CartLineComponent line)
        {
            Cart result = (Cart)null;
            Cart cart1;
            using (CommandActivity.Start(commerceContext, (CommerceCommand)this))
            {
                // ISSUE: variable of a compiler-generated type
                //AddCartLineCommand.\u003C\u003Ec__DisplayClass4_0 cDisplayClass40_1;
                Func<Task> func = await this.PerformTransaction(commerceContext, (Func<Task>)(async () =>
                {
                CommercePipelineExecutionContextOptions pipelineContextOptions = commerceContext.GetPipelineContextOptions();
                CartLineArgument cartLineArgument = new CartLineArgument(cart, line);
        // ISSUE: variable of a compiler-generated type
        //AddCartLineCommand.\u003C\u003Ec__DisplayClass4_0 cDisplayClass40 = cDisplayClass40_1;
        // ISSUE: reference to a compiler-generated field
        //Cart result1 = cDisplayClass40.result;
                Cart cart2 = await this._addToCartpipeline.Run(cartLineArgument, (IPipelineExecutionContextOptions)pipelineContextOptions).ConfigureAwait(false);
        // ISSUE: reference to a compiler-generated field
        //cDisplayClass40.result = cart2;
                //cDisplayClass40 = (AddCartLineCommand.\u003C\u003Ec__DisplayClass4_0) null;
            }));
            cart1 = result;
        }
      return cart1;
    }
}
}
