using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.OData;
using Newtonsoft.Json;
using Sitecore.Feature.Commerce.Embellishments.Engine.Commands;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Controller
{
    public class CommandsController : CommerceController
    {

        public CommandsController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment)
            : base(serviceProvider, globalEnvironment)
        {

        }

        [HttpPut]
        [Route("SaveCartLineEmbellishment()")]
        [Microsoft.AspNetCore.OData.EnableQuery]
        public async Task<IActionResult> SaveCartLineEmbellishment([FromBody] ODataActionParameters value)
        {
            if (!this.ModelState.IsValid || value == null)
            {
                return new BadRequestObjectResult(this.ModelState);
            }

            if (value.ContainsKey("cartId") && 
                value.ContainsKey("lineId") && 
                value.ContainsKey("itemId") &&
                value.ContainsKey("externalId") &&
                value.ContainsKey("quantity") &&
                value.ContainsKey("type") && 
                value.ContainsKey("value"))
            {
                var command = this.Command<SaveCartLineEmbellishmentsCommand>();
                var cart = await command.Process(this.CurrentContext, 
                                                    value["cartId"].ToString(),
                                                    value["lineId"].ToString(),
                                                    value["itemId"].ToString(),
                                                    value["externalId"].ToString(),
                                                    uint.Parse(value["quantity"].ToString()),
                                                    value["type"].ToString(),
                                                    value["value"].ToString())
                                        .ConfigureAwait(false);

                return new ObjectResult(command);
            }
            return new BadRequestObjectResult(value);
        }
    }
}
