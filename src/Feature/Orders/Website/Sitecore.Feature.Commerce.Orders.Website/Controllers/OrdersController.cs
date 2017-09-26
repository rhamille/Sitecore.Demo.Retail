﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Web.UI;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Sitecore.Collections.Debugging;
using Sitecore.Commerce.Connect.CommerceServer.Orders.Models;
using Sitecore.Commerce.Entities.Orders;
using Sitecore.Diagnostics;
using Sitecore.Feature.Commerce.Orders.Website.Models;
using Sitecore.Feature.Commerce.Orders.Website.Repositories;
using Sitecore.Feature.Commerce.Orders.Website.Templates;
using Sitecore.Foundation.Commerce.Website;
using Sitecore.Foundation.Commerce.Website.Extensions;
using Sitecore.Foundation.Commerce.Website.Managers;
using Sitecore.Foundation.Commerce.Website.Models;
using Sitecore.Foundation.Commerce.Website.Models.InputModels;
using Sitecore.Foundation.SitecoreExtensions.Attributes;
using Sitecore.Shell.Framework.Commands.Masters;
//using Order = Sitecore.Commerce.Plugin.Orders;
using Sitecore.Foundation.Commerce.Website.Util;
using Sitecore.Foundation.Commerce.ServiceProxy;
using Sitecore.Commerce.Plugin.Orders;

namespace Sitecore.Feature.Commerce.Orders.Website.Controllers
{

    public class XmlActionResult : ActionResult
    {
        private readonly object _document;

        public Formatting Formatting { get; set; }
        public string MimeType { get; set; }

        public XmlActionResult(object document)
        {
            if (document == null)
                throw new ArgumentNullException("document");

            _document = document;

            // Default values
            MimeType = "text/xml";
            Formatting = Formatting.None;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            context.HttpContext.Response.Clear();
            context.HttpContext.Response.ContentType = MimeType;
            XmlSerializer ser = new XmlSerializer(this._document.GetType());
            ser.Serialize(context.HttpContext.Response.OutputStream, _document);

        }
    }

    public class OrdersController : Controller
    {
        public OrdersController(OrderManager orderManager, AccountManager accountManager, CommerceUserContext commerceUserContext, OrdersViewModelRepository ordersViewModelRepository, StorefrontContext storefrontContext, OrderViewModelRepository orderViewModelRepository)
        {
            OrderManager = orderManager;
            AccountManager = accountManager;
            CommerceUserContext = commerceUserContext;
            OrdersViewModelRepository = ordersViewModelRepository;
            StorefrontContext = storefrontContext;
            OrderViewModelRepository = orderViewModelRepository;
        }

        private OrderManager OrderManager { get; }
        private AccountManager AccountManager { get; }
        private CommerceUserContext CommerceUserContext { get; }
        public OrdersViewModelRepository OrdersViewModelRepository { get; }
        public StorefrontContext StorefrontContext { get; }
        public OrderViewModelRepository OrderViewModelRepository { get; }

        public ActionResult SendOrderEQuote(string userid, string orderod)
        {
            var message = new MailMessage("wisbis@test.com", "user@test.com");
               message.Subject = "WIS";
               message.Body = "Body";
               MainUtil.SendMail(message);
            return new EmptyResult();
        }

        public XmlActionResult PunchoutOrderRequest(string userid,string orderid, string exportformat = "cxml")
        {
            var orderViewModel = OrderViewModelRepository.Get(userid,orderid);

            var query = EngineConnectUtilityExtension.GetShopsContainer(string.Empty, "Storefront", userid, userid, "", "", new DateTime?()); //.SetupSession(cart.ExternalId, hostUri, acceptHeaders, userAgents);
            var orderEngine = Proxy.GetValue(query.Orders.ByKey(orderid).Expand("Lines($expand=CartLineComponents),Components"));

            switch (exportformat.ToLower())
            {
                case "oagxml":
                    return ExportAsOAGXML(orderViewModel, orderEngine);
                case "ocixml":
                    return ExportAsOCIXML(orderViewModel, orderEngine);
                case "cxml":
                default:
                    return ExportAsCXML(orderViewModel, orderEngine);
            }
            
        }

        private XmlActionResult ExportAsCXML(OrderViewModel orderViewModel, Sitecore.Commerce.Plugin.Orders.Order orderEngine)
        {
            // var orderViewModel = GetOrderViewModel();
            //https://success.coupa.com/Suppliers/Integration_Resources/Sample_Punchout_Order_Message
            var cXML = new cXML()
            {
                payloadID = "test@test.com",
                timestamp = "timestamp",
            };
            var topNodes = new List<object>();
            topNodes.Add(new Header()
            {
                From = new From()
                {
                    Credential = new Credential[1]
                    {
                        new Credential()
                        {
                            domain = "NetworkID"
                        }
                    }
                },
                To = new To()
                {
                    Credential = new Credential[1]
                    {
                        new Credential()
                        {
                            domain = "NetworkID",
                            Identity = new Identity()
                            {
                                Value = "user@sitecore.com"
                            }
                        }
                    }
                },
                Sender = new Sender()
                {
                    Credential = new Credential[1]
                    {
                        new Credential()
                        {
                            domain = "NetworkID",
                        }
                    }
                }
            });

            var message = new Message()
            {
                Item = new PunchOutOrderMessage()
                {
                    BuyerCookie = new BuyerCookie()
                    {
                        Value = "f5d75ddbc9e75b6346b36ee5c28c5e8b"
                    },
                    PunchOutOrderMessageHeader = new PunchOutOrderMessageHeader()
                    {
                        Total = new Total()
                        {
                            Money = new Money()
                            {
                                Value = orderViewModel.Total.ToString(),
                                currency = orderViewModel.Currency
                            }
                        },
                        Shipping = new Shipping()
                        {
                            Money = new Money()
                            {
                                Value = orderViewModel.ShippingTotal.ToString(),
                                currency = orderViewModel.Currency
                            }
                        },
                        Tax = new Tax()
                        {
                            Money = new Money()
                            {
                                Value = orderViewModel.TaxTotal.ToString(),
                                currency = orderViewModel.Currency
                            }
                        }
                    }
                }
            };
            var items = new List<ItemIn>();
            foreach (var orderItem in orderViewModel.Lines)
            {
                items.Add(
                    new ItemIn()
                    {
                        ItemID = new ItemID()
                        {
                            SupplierPartAuxiliaryID = new SupplierPartAuxiliaryID() {Value = "AS-df"},
                            SupplierPartID = new SupplierPartID() {Value = "1234"}
                        },
                        ItemDetail = new ItemDetail()
                        {
                            Description = new Description[1]
                            {
                                new Description()
                                {
                                    Text = new[] {orderItem.Title}
                                }
                            },
                            UnitPrice = new UnitPrice()
                            {
                                Money = new Money()
                                {
                                    Value = orderItem.Total.ToString(),
                                    currency = orderItem.Currency
                                }
                            },
                            UnitOfMeasure = "EA"
                        }
                        ,
                        Comments = new Comments()
                        {
                            type = "Embellishment - Shirt Text",
                            Text = GetEmbelishments(orderEngine, orderItem)
                        }
                       
                        /*ShipTo = new ShipTo()
                        {
                            Address = new Address()
                            {
                                Name = new Name() { Value = model.ShippingAddresses.First().Name },
                                PostalAddress = new PostalAddress()
                                {
                                    City = new City() { Value = model.ShippingAddresses.First().City },
                                    Country = new Country() { Value = model.ShippingAddresses.First().Country },
                                    PostalCode = model.ShippingAddresses.First().ZipPostalCode,
                                    Street = new string[2] { model.ShippingAddresses.First().Address1, model.ShippingAddresses.First().Address2 },
                                    State = new State() { Value = model.ShippingAddresses.First().Region },
                                    name = model.ShippingAddresses.First().Name
                                },
                                addressID = model.ShippingAddresses.First().PartyId

                            }
                        },*/
                    });
            }
            ((PunchOutOrderMessage) message.Item).ItemIn = items.ToArray();
            topNodes.Add(message);
            cXML.Items = topNodes.ToArray();


            return new XmlActionResult(cXML);
        }


        private XmlActionResult ExportAsOAGXML(OrderViewModel orderViewModel, Sitecore.Commerce.Plugin.Orders.Order orderEngine)
        {
            // var orderViewModel = GetOrderViewModel();
            //https://success.coupa.com/Suppliers/Integration_Resources/Sample_Punchout_Order_Message
            var oagXml = new oagXML()
            {
               
            };

            return new XmlActionResult(oagXml);
        }

        private XmlActionResult ExportAsOCIXML(OrderViewModel orderViewModel, Sitecore.Commerce.Plugin.Orders.Order orderEngine)
        {
            // var orderViewModel = GetOrderViewModel();
            //https://success.coupa.com/Suppliers/Integration_Resources/Sample_Punchout_Order_Message
            var ociXml = new ociXML()
            {
                CatalogHeader = "Catalog Header",
                Catalog = new BusinessDocumentCatalog
                {
                    CatalogID = 11,
                    Product = orderViewModel.Lines.Select(x => new BusinessDocumentCatalogProduct
                    {
                        CatalogKey = 11111,
                        ParentCategoryID = 44120000,
                        Description = new BusinessDocumentCatalogProductDescription { Language = "EN", Value = x.Title.ToString()},
                        ManufacturerDescription = new BusinessDocumentCatalogProductManufacturerDescription()
                        {
                            ID = 1,
                            PartnerID = new BusinessDocumentCatalogProductManufacturerDescriptionPartnerID()
                            {
                                Value = 4712,
                                Code = "Other"
                            },
                            PartnerProductID = new BusinessDocumentCatalogProductManufacturerDescriptionPartnerProductID()
                            {
                                Value = 4711,
                                Code = "Other2"
                            },
                        },
                        ParentCategoryIDSpecified = true,
                        ProductID = new BusinessDocumentCatalogProductProductID
                        {
                            Value = x.OrderLineId,
                            Code = "Buyer"
                        },
                        ProductType = "Good Type",
                        ShoppingBasketItem = new BusinessDocumentCatalogProductShoppingBasketItem
                        {
                            ItemText = new BusinessDocumentCatalogProductShoppingBasketItemItemText()
                            {
                                Value = x.Title,
                                Language = "EN"
                            },
                            LeadTime = 1,
                            NetPrice = new BusinessDocumentCatalogProductShoppingBasketItemNetPrice
                            {
                                PriceUnit = 5, 
                                Price = new BusinessDocumentCatalogProductShoppingBasketItemNetPricePrice
                                {
                                    Value = x.ItemPrice,
                                    Currency = x.Currency,
                                   
                                },
                                PriceUnitSpecified = true,
                            },
                            Quantity = new BusinessDocumentCatalogProductShoppingBasketItemQuantity()
                            {
                                Value = (byte) x.Quantity,
                                UoM = "EA"
                            },
                            Quote = new BusinessDocumentCatalogProductShoppingBasketItemQuote()
                            {
                                QuoteID = 111,
                                QuoteItemID = 1111
                            },
                            RefManufacturerDescription = 3,
                            RefVendorDescription = 2,
                            Text = GetEmbelishments(orderEngine, x)
                        }

                    }).ToArray() 
                    
                }
            };
            
            return new XmlActionResult(ociXml);
        }
        private string[] GetEmbelishments(Sitecore.Commerce.Plugin.Orders.Order orderEngine, OrderLineViewModel orderItem)
        {
            if(string.IsNullOrEmpty(orderItem.OrderLineId))
                return new [] { "" };

            var line = orderEngine.Lines.FirstOrDefault(o => o.Id == orderItem.OrderLineId);

            if (line == null)
                return new [] {""};
                var embellishmentComponents = line.CartLineComponents.OfType<Embellishments.Engine.Components.EmbellishmentComponent>().Select(x => x.Value);

                return  embellishmentComponents.Any() ? embellishmentComponents.ToArray() : new [] { "" };
        }

        [HttpGet]
        [OutputCache(NoStore = true, Location = OutputCacheLocation.None)]
        public ActionResult MyOrders()
        {
            if (!Context.User.IsAuthenticated)
            {
                return new EmptyResult();
            }

            var orders = OrdersViewModelRepository.Get(CommerceUserContext.Current);
            return View(orders);
        }


        [HttpGet]
        [OutputCache(NoStore = true, Location = OutputCacheLocation.None)]
        public ActionResult MyOrder(string id)
        {
            if (!Context.User.IsAuthenticated)
            {
                return new EmptyResult();
            }

            var order = OrderViewModelRepository.Get(id);
            return View(order);
        }


        [HttpPost]
        [Authorize]
        [ValidateJsonAntiForgeryToken]
        [OutputCache(NoStore = true, Location = OutputCacheLocation.None)]
        [SkipAnalyticsTracking]
        public JsonResult RecentOrders()
        {
            if (!Context.User.IsAuthenticated)
            {
                Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                return null;
            }

            try
            {
                var recentOrders = new List<OrderHeader>();

                var response = OrderManager.GetUserOrders(CommerceUserContext.Current.UserName);
                var result = new OrdersApiModel(response?.ServiceProviderResult);
                if (response != null)
                {
                    result.SetErrors(response.ServiceProviderResult);
                    if (response.ServiceProviderResult.Success && response.Result != null)
                    {
                        var orders = response.Result.Cast<CommerceOrderHeader>().ToList();
                        recentOrders = orders.Where(order => order.LastModified > DateTime.Today.AddDays(-30)).Take(5).Cast<OrderHeader>().ToList();
                    }
                }

                result.Initialize(recentOrders);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new ErrorApiModel("RecentOrders", e), JsonRequestBehavior.AllowGet);
            }
        }

        [Authorize]
        [HttpPost]
        [ValidateJsonAntiForgeryToken]
        [OutputCache(NoStore = true, Location = OutputCacheLocation.None)]
        [SkipAnalyticsTracking]
        public JsonResult Reorder(ReorderInputModel inputModel)
        {
            try
            {
                Assert.ArgumentNotNull(inputModel, nameof(inputModel));
                var validationResult = this.CreateJsonResult();
                if (validationResult.HasErrors)
                {
                    return Json(validationResult, JsonRequestBehavior.AllowGet);
                }

                var response = OrderManager.Reorder(CommerceUserContext.Current.UserId, inputModel);
                var result = new BaseApiModel(response.ServiceProviderResult);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new ErrorApiModel("Reorder", e), JsonRequestBehavior.AllowGet);
            }
        }


        [Authorize]
        [HttpPost]
        [ValidateJsonAntiForgeryToken]
        [OutputCache(NoStore = true, Location = OutputCacheLocation.None)]
        [SkipAnalyticsTracking]
        public JsonResult CancelOrder(CancelOrderInputModel inputModel)
        {
            try
            {
                Assert.ArgumentNotNull(inputModel, nameof(inputModel));
                var validationResult = this.CreateJsonResult<CancelOrderApiModel>();
                if (validationResult.HasErrors)
                {
                    return Json(validationResult, JsonRequestBehavior.AllowGet);
                }

                var response = OrderManager.CancelOrder(CommerceUserContext.Current.UserId, inputModel);
                var result = new CancelOrderApiModel(response.ServiceProviderResult);

                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(new ErrorApiModel("CancelOrder", e), JsonRequestBehavior.AllowGet);
            }
        }

        private OrderViewModel GetOrderViewModel()
        {
            var ovm = new OrderViewModel()
            {
                Currency = "AUD",
                Total = 500,
                TaxTotal = 50,
                OrderId = "TEST_OR_1",
                Created = DateTime.Now,
                LastModified = DateTime.Now,
                Status = "Unfulfilled",
                Subtotal = 450,
                TotalSavings = 0,
                ShippingTotal = 70,
                Lines = new List<OrderLineViewModel>()
                {
                    new OrderLineViewModel()
                    {
                        Currency = "AUD",
                        Total = 500,
                        Title = "Product1",
                        ItemPrice = 500,
                        OrderLineId = "1",
                        Quantity = 5,
                        
                        
                    }
                }
            };


            return ovm;
        }
    }
}