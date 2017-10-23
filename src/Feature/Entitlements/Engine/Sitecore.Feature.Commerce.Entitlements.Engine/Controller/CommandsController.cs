using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.OData;
using Newtonsoft.Json;
using Sitecore.Feature.Commerce.Entitlements.Engine.Commands;
using Sitecore.Feature.Commerce.Entitlements.Engine.Entities;
using Sitecore.Commerce.Plugin.Customers;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Controller
{
    public class CommandsController : CommerceController
    {

        public CommandsController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment)
            : base(serviceProvider, globalEnvironment)
        {

        }

        [HttpPut]
        [Route("SaveCustomerSpendLimitEntitlement()")]
        [Microsoft.AspNetCore.OData.EnableQuery]
        public async Task<IActionResult> SaveCustomerSpendLimitEntitlement([FromBody] ODataActionParameters value)
        {
            if (!this.ModelState.IsValid || value == null)
            {
                return new BadRequestObjectResult(this.ModelState);
            }

            if (value.ContainsKey("customerId") && 
                value.ContainsKey("originalAmount") &&
                value.ContainsKey("balance"))
            {
                var command = this.Command<SaveCustomerSpendLimitEntitlementCommand>();
                Customer customer = await this.Command<GetCustomerCommand>().Process(this.CurrentContext, value["customerId"].ToString());
                var cart = await command.Process(this.CurrentContext,
                                                    customer,
                                                    decimal.Parse(value["originalAmount"].ToString()),
                                                    decimal.Parse(value["balance"].ToString()))
                                        .ConfigureAwait(false);

                return new ObjectResult(command);
            }
            return new BadRequestObjectResult(value);
        }
    }
}
