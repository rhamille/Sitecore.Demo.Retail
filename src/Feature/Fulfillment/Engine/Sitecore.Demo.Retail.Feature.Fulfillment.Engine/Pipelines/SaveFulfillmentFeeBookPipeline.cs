using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Save Fulfillment Fee Book Pipeline
    /// </summary>
    /// <seealso cref="CommercePipeline{SaveFulfillmentFeeBookArgument, FulfillmentFeeBook}" />
    /// <seealso cref="ISaveFulfillmentFeeBookPipeline" />
    /// <seealso cref="IPipeline{SaveFulfillmentFeeBookArgument, FulfillmentFeeBook, CommercePipelineExecutionContext}" />
    /// <seealso cref="IPipelineBlock{SaveFulfillmentFeeBookArgument, FulfillmentFeeBook, CommercePipelineExecutionContext}" />
    /// <seealso cref="IPipelineBlock" />
    /// <seealso cref="IPipeline" />
    public class SaveFulfillmentFeeBookPipeline : CommercePipeline<SaveFulfillmentFeeBookArgument, FulfillmentFeeBook>, ISaveFulfillmentFeeBookPipeline, IPipeline<SaveFulfillmentFeeBookArgument, FulfillmentFeeBook, CommercePipelineExecutionContext>, IPipelineBlock<SaveFulfillmentFeeBookArgument, FulfillmentFeeBook, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveFulfillmentFeeBookPipeline"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <param name="loggerFactory">The logger factory.</param>
        public SaveFulfillmentFeeBookPipeline(IPipelineConfiguration<ISaveFulfillmentFeeBookPipeline> configuration, ILoggerFactory loggerFactory)
            : base(configuration, loggerFactory)
        {
        }
    }
}
