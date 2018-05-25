extern alias FoundationServiceProxy;

using Sitecore.Commerce.Automation.MarketingAutomation;
using Sitecore.Commerce.Connect.CommerceServer.Orders.Models;
using Sitecore.Commerce.Contacts;
using Sitecore.Commerce.Data.Carts;
//using Sitecore.Commerce.Engine.Connect.Pipelines;
using Sitecore.Commerce.Entities.Carts;
using Sitecore.Commerce.Multishop;
using Sitecore.Commerce.Pipelines;
using Sitecore.Commerce.Services;
using Sitecore.Commerce.Services.Carts;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Sitecore.Foundation.Commerce.Website.Extensions;
using Sitecore.Commerce.Engine.Connect.Pipelines;
using Sitecore.Analytics;
using Sitecore.Foundation.Commerce.Website.Util;
using FoundationServiceProxy::Sitecore.Feature.Commerce.SubLines.Engine.Entities;
using FoundationServiceProxy.Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Plugin.Carts;
using FoundationServiceProxy.Sitecore.Commerce.Core;



namespace Sitecore.Feature.Commerce.Orders.Website.Pipelines
{
    public class AddCartSubLines : Sitecore.Commerce.Engine.Connect.Pipelines.Carts.CartProcessor
    {
        public bool DisableEaPlan { get; set; }

        protected IEaPlanProvider EaPlanProvider { get; set; }

        protected ICartRepository CartRepository { get; set; }

        public AddCartSubLines(IEaPlanProvider engagementPlanProvider, ICartRepository repository, string disableEaPlan)
        {
            Assert.ArgumentNotNull((object)engagementPlanProvider, "eaPlanProvider");
            this.EaPlanProvider = engagementPlanProvider;
            this.CartRepository = repository;
            if (string.IsNullOrEmpty(disableEaPlan))
                return;
            this.DisableEaPlan = System.Convert.ToBoolean(disableEaPlan, (IFormatProvider)CultureInfo.InvariantCulture);
        }

        public override void Process(ServicePipelineArgs args)
        {
            AddCartLinesRequest request;
            CartResult result;
            PipelineUtilityExtension.ValidateArguments<AddCartLinesRequest, CartResult>(args, out request, out result);
            //Sitecore.Commerce.Plugin.Carts.Cart cart = this.GetCart(request.Cart.UserId, request.Cart.ShopName, request.Cart.ExternalId, "");

            try
            {
                Assert.IsNotNull((object)request.Cart, "request.Cart");
                Assert.IsNotNullOrEmpty(request.Cart.UserId, "request.Cart.UserId");
                Assert.IsNotNull((object)request.Lines, "request.Lines");
                List<CartLine> list = request.Lines.ToList<CartLine>();
                list.RemoveAll((Predicate<CartLine>)(l =>
                {
                    if (l != null)
                        return l.Product == null;
                    return true;
                }));
                request.Lines = (IEnumerable<CartLine>)list;
                
                foreach (CartLine line in request.Lines)
                {
                    //var input = new CartLineWithSubLinesInputModel();
                    string lineItemId = this.GenerateLineItemId(line as CommerceCartLine);
                    if (!string.IsNullOrEmpty(lineItemId))
                    {
                        //input.CartLine = new CartLineInputModel();
                        //input.CartLine.CartId = request.Cart.ExternalId;
                        //input.CartLine.ItemId = lineItemId;
                        //input.CartLine.Quantity = (long)line.Quantity;
                        var subLines = new List<CartLineInputModel>();

                        foreach (CartLine subline in line.SubLines)
                        {
                            string sublineItemId = this.GenerateLineItemId(subline as CommerceCartLine);
                            if (!string.IsNullOrEmpty(sublineItemId))
                            {
                                var sublineInput = new CartLineInputModel();
                                sublineInput.CartId = request.Cart.ExternalId;
                                sublineInput.ItemId = sublineItemId;
                                sublineInput.Quantity = (long)subline.Quantity;
                                subLines.Add(sublineInput);
                            }
                        }

                        //input.SubLines = new DataServiceCollection<CartLineInputModel>(subLines, TrackingMode.None);

                        FoundationServiceProxy.Sitecore.Commerce.Core.Commands.CommerceCommand command = this.AddCartLineWithSubLines(request.Cart.UserId, request.Cart.ShopName, request.Cart.ExternalId, lineItemId, (long)line.Quantity, subLines, request.Cart.CustomerId);
                        result.HandleCommandMessages(command);
                        if (!result.Success)
                            break;
                    }
                    
                }
                Sitecore.Commerce.Plugin.Carts.Cart cart = this.GetCart(request.Cart.UserId, request.Cart.ShopName, request.Cart.ExternalId, "");
                if (cart != null)
                    result.Cart = (Sitecore.Commerce.Entities.Carts.Cart)this.TranslateCartToEntity(cart, (ServiceProviderResult)result);
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

        //protected new Sitecore.Commerce.Plugin.Carts.Cart GetCartx(string userId, string shopName, string cartId, string customerId = "")
        //{
        //    //return FoundationServiceProxy.Sitecore.Foundation.Commerce.ServiceProxy.Proxy.DoCommand<FoundationServiceProxy.Sitecore.Commerce.Core.Commands.CommerceCommand>(this.GetLocalContainer(shopName, userId, customerId, "", "", new DateTime?()).AddCartLineWithSubLines(cartId, itemId, quantity.ToString(), subLines));
        //    //
        //    var container = this.GetLocalContainer(shopName, userId, customerId, "", "", new DateTime?());
        //    var query = container.Carts.ByKey(cartId).Expand("Lines($expand=CartLineComponents($expand=ChildComponents)),Components");
        //    var result = query.GetValueAsync().Result;
        //    return FoundationServiceProxy.Sitecore.Foundation.Commerce.ServiceProxy.Proxy.GetValue<Sitecore.Commerce.Plugin.Carts.Cart>(query);
        //    //return FoundationServiceProxy.Sitecore.Foundation.Commerce.ServiceProxy.Proxy.GetValue<Sitecore.Commerce.Plugin.Carts.Cart>(container.Carts.ByKey(cartId).Expand("Lines($expand=CartLineComponents),Components"));
        //    //return Sitecore.Commerce.ServiceProxy.Proxy.GetValue<Sitecore.Commerce.Plugin.Carts.Cart>(container.Carts.ByKey(cartId).Expand("Lines($expand=CartLineComponents($expand=ChildComponents)),Components"));
        //}

        protected virtual FoundationServiceProxy.Sitecore.Commerce.Core.Commands.CommerceCommand AddCartLineWithSubLines(string userId, string shopName, string cartId, string itemId, long quantity, List<CartLineInputModel> subLines, string customerId = "")
        {
            //var input = new CartLineWithSubLinesInputModel() { CartLine = new CartLine() { CartId = cartId, ItemId = itemId, Quantity = quantity }, }
            //var x = FoundationServiceProxy.Sitecore.Foundation.Commerce.ServiceProxy.Proxy.DoCommand<FoundationServiceProxy.Sitecore.Commerce.Core.Commands.CommerceCommand>(this.GetLocalContainer(shopName, userId, customerId, "", "", new DateTime?()).CreateFunctionQuery<CartLineWithSubLinesInputModelSingle>();
            return FoundationServiceProxy.Sitecore.Foundation.Commerce.ServiceProxy.Proxy.DoCommand<FoundationServiceProxy.Sitecore.Commerce.Core.Commands.CommerceCommand>(this.GetLocalContainer(shopName, userId, customerId, "", "", new DateTime?()).AddCartLineWithSubLines(cartId, itemId, quantity.ToString(), subLines));
        }

        protected virtual FoundationServiceProxy.Sitecore.Commerce.Engine.Container GetLocalContainer(string shopName, string userId, string customerId = "", string language = "", string currency = "", DateTime? effectiveDate = null)
        {
            return EngineConnectUtilityExtension.GetShopsContainer(string.Empty, shopName, userId, customerId, language, currency, effectiveDate);
        }

        protected virtual void AddVisitorAndCartToEaPlan(AddCartLinesRequest request, Sitecore.Commerce.Entities.Carts.Cart cart)
        {
            Assert.IsNotNull((object)request, "request");
            Assert.IsNotNull((object)Tracker.Current, "Tracker.Current");
            Assert.IsNotNull((object)Tracker.Current.Contact, "Tracker.Current.Contact");
            ContactFactory contactFactory = (ContactFactory)Factory.CreateObject("contactFactory", true);
            string message = "contactFactory";
            Assert.IsNotNull((object)contactFactory, message);
            Tuple<ID, ID> eaPlanId = this.EaPlanProvider.GetEaPlanId(request.Cart.ShopName);
            ID planId = eaPlanId.Item1;
            ID stateId = eaPlanId.Item2;
            CommerceAutomationHelper.AddContactToState(contactFactory.GetContact(), planId, stateId, false);
        }
    }
}