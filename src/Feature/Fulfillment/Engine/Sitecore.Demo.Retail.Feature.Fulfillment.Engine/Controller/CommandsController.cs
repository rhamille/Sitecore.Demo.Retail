using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.OData;
using Newtonsoft.Json;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{

    /// <summary>
    /// Commands Controller
    /// </summary>
    /// <seealso cref="CommerceController" />
    public class CommandsController : CommerceController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandsController"/> class.
        /// </summary>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="globalEnvironment">The global environment.</param>
        public CommandsController(IServiceProvider serviceProvider, CommerceEnvironment globalEnvironment)
            : base(serviceProvider, globalEnvironment)
        {
        }

        /// <summary>
        /// Saves the Fulfillment fee book.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("SaveFulfillmentFeeBook()")]
        public async Task<IActionResult> SaveFulfillmentFeeBook([FromBody] ODataActionParameters value)
        {
            if (!this.ModelState.IsValid || value == null)
            {
                return new BadRequestObjectResult(this.ModelState);
            }

            if (value.ContainsKey("name"))
            {
                object obj1 = value["name"];
                if (!string.IsNullOrEmpty(obj1 != null ? obj1.ToString() : null) && value.ContainsKey("FulfillmentFees"))
                {
                    object obj2 = value["FulfillmentFees"];
                    if (!string.IsNullOrEmpty(obj2 != null ? obj2.ToString() : null))
                    {
                        var name = value["name"].ToString();
                        var FulfillmentFees = JsonConvert.DeserializeObject<IList<FulfillmentFee>>(value["FulfillmentFees"].ToString());

                        var command = this.Command<SaveFulfillmentFeeBookCommand>();
                        var FulfillmentFeeBook = await command.Process(this.CurrentContext, name, FulfillmentFees);
                        return new ObjectResult(command);
                    }
                }
            }
            return new BadRequestObjectResult(value);
        }
    }
}
