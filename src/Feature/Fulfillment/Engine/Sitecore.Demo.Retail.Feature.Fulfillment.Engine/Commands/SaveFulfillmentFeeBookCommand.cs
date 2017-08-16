using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Save Fulfillment Fee Book Command
    /// </summary>
    /// <seealso cref="Sitecore.Demo.Retail.Feature.Fulfillment.Engine.FulfillmentCommerceCommand" />
    public class SaveFulfillmentFeeBookCommand : FulfillmentCommerceCommand
    {
        private readonly ISaveFulfillmentFeeBookPipeline _pipeline;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveFulfillmentFeeBookCommand"/> class.
        /// </summary>
        /// <param name="pipeline">The pipeline.</param>
        /// <param name="findEntityPipeline">The find entity pipeline.</param>
        /// <param name="serviceProvider">The service provider.</param>
        public SaveFulfillmentFeeBookCommand(ISaveFulfillmentFeeBookPipeline pipeline, IFindEntityPipeline findEntityPipeline, IServiceProvider serviceProvider)
            : base(findEntityPipeline, serviceProvider)
        {
            this._pipeline = pipeline;
        }

        /// <summary>
        /// Processes the specified commerce context.
        /// </summary>
        /// <param name="commerceContext">The commerce context.</param>
        /// <param name="name">The name.</param>
        /// <param name="FulfillmentFees">The Fulfillment fees.</param>
        /// <returns></returns>
        public virtual async Task<FulfillmentFeeBook> Process(CommerceContext commerceContext, string name, IList<FulfillmentFee> FulfillmentFees)
        {
            using (var activity = CommandActivity.Start(commerceContext, this))
            {
                var FulfillmentFeeBook = await this.GetFulfillmentFeeBook(commerceContext, name);
                var arg = new SaveFulfillmentFeeBookArgument(FulfillmentFeeBook, name, FulfillmentFees);
                return await this._pipeline.Run(arg, new CommercePipelineExecutionContextOptions(commerceContext));
            }
        }
    }
}
