using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using System;
using System.Threading.Tasks;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Fulfillment Commerce Command
    /// </summary>
    /// <seealso cref="Sitecore.Commerce.Core.Commands.CommerceCommand" />
    public class FulfillmentCommerceCommand : CommerceCommand
    {
        private readonly IFindEntityPipeline _findEntityPipeline;

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentCommerceCommand"/> class.
        /// </summary>
        /// <param name="findEntityPipeline">The find entity pipeline.</param>
        /// <param name="serviceProvider">The service provider.</param>
        protected FulfillmentCommerceCommand(IFindEntityPipeline findEntityPipeline, IServiceProvider serviceProvider)
          : base(serviceProvider)
        {
            this._findEntityPipeline = findEntityPipeline;
        }

        /// <summary>
        /// Gets the Fulfillment fee book.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        protected virtual async Task<FulfillmentFeeBook> GetFulfillmentFeeBook(CommerceContext context, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }

            var entityPrefix = CommerceEntity.IdPrefix<FulfillmentFeeBook>();
            var entityId = name.StartsWith(entityPrefix, StringComparison.OrdinalIgnoreCase) ? name : string.Format("{0}{1}", entityPrefix, name);

            var arg = new FindEntityArgument(typeof(FulfillmentFeeBook), entityId, false);
            var options = new CommercePipelineExecutionContextOptions(context, null, null, null, null, null);

            var FulfillmentFeeBook = await this._findEntityPipeline.Run(arg, options) as FulfillmentFeeBook;
            if (FulfillmentFeeBook == null)
            {
                context.Logger.LogDebug(string.Format("Entity {0} was not found.", name));
            }
            
            return FulfillmentFeeBook;
        }
    }
}

