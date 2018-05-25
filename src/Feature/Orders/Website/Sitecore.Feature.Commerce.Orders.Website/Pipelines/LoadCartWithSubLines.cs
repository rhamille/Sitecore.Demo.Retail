extern alias FoundationServiceProxy;

using Sitecore.Commerce.Connect.CommerceServer.Orders.Pipelines;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Engine.Connect.Pipelines.Carts;
using Sitecore.Commerce.Entities.Carts;
using Sitecore.Commerce.Pipelines;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Services;
using Sitecore.Commerce.Services.Carts;
//using Sitecore.ContentSearch.Utilities;
using Sitecore.Diagnostics;
using Sitecore.Foundation.Commerce.Website.Extensions;
using Sitecore.Foundation.Commerce.Website.Util;
using System;
using System.Collections.Generic;
using System.Linq;
//using FoundationServiceProxy.Sitecore.Commerce.Core.Commands.ExtensionMethods;
using Sitecore.Commerce.Engine.Connect;
using Sitecore.Commerce.Connect.CommerceServer.Orders.Models;
using Sitecore.Commerce.Engine.Connect.Pipelines.Arguments;
using Sitecore.Commerce.ServiceProxy;

namespace Sitecore.Feature.Commerce.Orders.Website.Pipelines
{
    public class LoadCartWithSubLines : CartProcessor
    {
        public override void Process(ServicePipelineArgs args)
        {
            LoadCartRequest request;
            CartResult result;
            PipelineUtilityExtension.ValidateArguments<LoadCartRequest, CartResult>(args, out request, out result);
            try
            {
                Assert.IsNotNullOrEmpty(request.UserId, "request.Cart.UserId");
                int num = request is LoadCartByNameRequest ? 1 : 0;
                string str = request.CartId;
                if (num != 0 && !string.IsNullOrEmpty(((LoadCartByNameRequest)request).CartName))
                    str = ((LoadCartByNameRequest)request).CartName;
                Assert.IsNotNullOrEmpty(str, "cartId");
                string cartId = str;
                if (num != 0)
                    cartId = str + request.UserId + request.Shop.Name;
                //FoundationServiceProxy.Sitecore.Commerce.Plugin.Carts.Cart cart = this.GetCart(request.UserId, request.Shop.Name, cartId, "");
                Sitecore.Commerce.Plugin.Carts.Cart cart = this.GetCart(request.UserId, request.Shop.Name, cartId, "");
                if (cart != null)
                {
                    var resultCart = (Sitecore.Commerce.Entities.Carts.Cart)this.TranslateCartToEntity(cart, (ServiceProviderResult)result);
                    foreach (var parentLines in cart.Lines.Where<Sitecore.Commerce.Plugin.Carts.CartLineComponent>(c => c.ParentId == null))
                    {
                        var parent = resultCart.Lines.Where<CartLine>(cl => cl.Product.ProductId == parentLines.ItemId).First();
                        var sub = new List<CartLine>();
                        foreach (var subLines in cart.Lines.Where<Sitecore.Commerce.Plugin.Carts.CartLineComponent>(c => c.ParentId == parentLines.ItemId))
                        {
                            var line = resultCart.Lines.Where<CartLine>(cl => cl.Product.ProductId == subLines.ItemId).First();
                            sub.Add(line);
                        }
                        parent.SubLines = new System.Collections.ObjectModel.ReadOnlyCollection<CartLine>(sub);
                    }
                    result.Cart = resultCart;
                    MessagesComponent messagesComponent = cart.Components.OfType<MessagesComponent>().FirstOrDefault<MessagesComponent>();
                    //if (messagesComponent != null)
                    //    messagesComponent.Messages.Where<MessageModel>((Func<MessageModel, bool>)(m => m.Code.Equals("error", StringComparison.OrdinalIgnoreCase))).ForEach<MessageModel>((Action<MessageModel>)(m => result.SystemMessages.Add(PipelineUtilityExtension.CreateSystemMessage(m.Text))));
                }
                else
                    result.Success = false;
            }
            catch (ArgumentException ex)
            {
                result.Success = false;
                result.SystemMessages.Add(PipelineUtilityExtension.CreateSystemMessage((Exception)ex));
            }
            catch (AggregateException ex)
            {
                result.Success = false;
                result.SystemMessages.Add(PipelineUtilityExtension.CreateSystemMessage((Exception)ex));
            }
            base.Process(args);
        }

        //protected new CommerceCart TranslateCartToEntity(FoundationServiceProxy.Sitecore.Commerce.Plugin.Carts.Cart cart, ServiceProviderResult currentResult)
        //{
        //    TranslateCartToEntityRequest cartToEntityRequest = new TranslateCartToEntityRequest();
        //    FoundationServiceProxy.Sitecore.Commerce.Plugin.Carts.Cart cart1 = cart;
        //    cartToEntityRequest.TranslateSource = cart1;
        //    TranslateCartToEntityRequest request = cartToEntityRequest;
        //    TranslateCartToEntityResult cartToEntityResult = PipelineUtility.RunConnectPipeline<TranslateCartToEntityRequest, TranslateCartToEntityResult>(EngineConnectConstants.KnownPipelineNames.TranslateCartToEntity, request);
        //    this.MergeResults(currentResult, (ServiceProviderResult)cartToEntityResult);
        //    return cartToEntityResult.TranslatedEntity;
        //}

        protected new Sitecore.Commerce.Plugin.Carts.Cart GetCart(string userId, string shopName, string cartId, string customerId = "")
        {
            //return FoundationServiceProxy.Sitecore.Foundation.Commerce.ServiceProxy.Proxy.DoCommand<FoundationServiceProxy.Sitecore.Commerce.Core.Commands.CommerceCommand>(this.GetLocalContainer(shopName, userId, customerId, "", "", new DateTime?()).AddCartLineWithSubLines(cartId, itemId, quantity.ToString(), subLines));
            //
            return Proxy.GetValue<Sitecore.Commerce.Plugin.Carts.Cart>(GetLocalContainer(shopName, userId, customerId, "", "", new DateTime?()).Carts.ByKey(cartId).Expand("Lines($expand=CartLineComponents($expand=ChildComponents)),Components"));
        }

        protected virtual Sitecore.Commerce.Engine.Container GetLocalContainer(string shopName, string userId, string customerId = "", string language = "", string currency = "", DateTime? effectiveDate = null)
        {
            return EngineConnectUtility.GetShopsContainer(string.Empty, shopName, userId, customerId, language, currency, effectiveDate);
        }
    }
}
