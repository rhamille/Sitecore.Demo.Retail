using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.OData;
using Newtonsoft.Json;
using Sitecore.Feature.Commerce.SubLines.Engine.Commands;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.SubLines.Engine.Entities;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Controllers
{
    public class CommandsController : CommerceController
    {

        public CommandsController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment)
            : base(serviceProvider, globalEnvironment)
        {

        }

        //[HttpPut]
        //[Route("SaveCartLineEmbellishment()")]
        //[Microsoft.AspNetCore.OData.EnableQuery]
        //public async Task<IActionResult> SaveCartLineEmbellishment([FromBody] ODataActionParameters value)
        //{
        //    if (!this.ModelState.IsValid || value == null)
        //    {
        //        return new BadRequestObjectResult(this.ModelState);
        //    }

        //    if (value.ContainsKey("cartId") &&
        //        value.ContainsKey("lineId") &&
        //        value.ContainsKey("itemId") &&
        //        value.ContainsKey("externalId") &&
        //        value.ContainsKey("quantity") &&
        //        value.ContainsKey("type") &&
        //        value.ContainsKey("value"))
        //    {
        //        var command = this.Command<SaveCartLineEmbellishmentsCommand>();
        //        var cart = await command.Process(this.CurrentContext,
        //                                            value["cartId"].ToString(),
        //                                            value["lineId"].ToString(),
        //                                            value["itemId"].ToString(),
        //                                            value["externalId"].ToString(),
        //                                            uint.Parse(value["quantity"].ToString()),
        //                                            value["type"].ToString(),
        //                                            value["value"].ToString())
        //                                .ConfigureAwait(false);

        //        return new ObjectResult(command);
        //    }
        //    return new BadRequestObjectResult(value);
        //}

        [HttpPut]
        [Route("AddCartLineWithSubLines()")]
        public async Task<IActionResult> AddCartLineWithSubLines([FromBody] ODataActionParameters value)
        {
            if (!this.ModelState.IsValid || value == null)
                return (IActionResult)new BadRequestObjectResult(this.ModelState);

            var parentItemId = value["itemId"].ToString();
            var cartLineWithSubLines = JsonConvert.DeserializeObject<List<CartLineInputModel>>(value["subLines"].ToString());

            if (cartLineWithSubLines != null && cartLineWithSubLines.Count > 0)
            {
                AddCartLineCommand command = this.Command<AddCartLineCommand>();
                foreach (var subLine in cartLineWithSubLines)
                {
                    string cartId = subLine.CartId;
                    string itemId = subLine.ItemId;
                    CartLineComponent line = new CartLineComponent()
                    {
                        ItemId = subLine.ItemId,
                        Quantity = subLine.Quantity,
                        ParentId = parentItemId
                    };
                    Cart cart = await command.Process(this.CurrentContext, cartId, line).ConfigureAwait(false);
                }
                return (IActionResult)new ObjectResult((object)command);
            }
            //if (value.ContainsKey("cartId"))
            //{
            //    object obj1 = value["cartId"];
            //    if (!string.IsNullOrEmpty(obj1 != null ? obj1.ToString() : (string)null) && value.ContainsKey("itemId"))
            //    {
            //        object obj2 = value["itemId"];
            //        if (!string.IsNullOrEmpty(obj2 != null ? obj2.ToString() : (string)null) && value.ContainsKey("quantity"))
            //        {
            //            object obj3 = value["quantity"];
            //            if (!string.IsNullOrEmpty(obj3 != null ? obj3.ToString() : (string)null))
            //            {
            //                string cartId = value["cartId"].ToString();
            //                string str = value["itemId"].ToString();
            //                Decimal result;
            //                if (!Decimal.TryParse(value["quantity"].ToString(), out result))
            //                    return (IActionResult)new BadRequestObjectResult((object)value);
            //                AddCartLineCommand command = this.Command<AddCartLineCommand>();
            //                CartLineComponent line = new CartLineComponent()
            //                {
            //                    ItemId = str,
            //                    Quantity = result
            //                };
            //                Cart cart = await command.Process(this.CurrentContext, cartId, line).ConfigureAwait(false);
            //                return (IActionResult)new ObjectResult((object)command);
            //            }
            //        }
            //    }
            //}
            return (IActionResult)new BadRequestObjectResult((object)value);
        }
    }
}
