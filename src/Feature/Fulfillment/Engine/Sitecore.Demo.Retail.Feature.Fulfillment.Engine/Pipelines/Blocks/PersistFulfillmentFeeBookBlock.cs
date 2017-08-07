using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System.Threading.Tasks;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Persist Fulfillment Fee Book Block
    /// </summary>
    /// <seealso cref="PipelineBlock{FulfillmentFeeBook, FulfillmentFeeBook, CommercePipelineExecutionContext}" />
    [PipelineDisplayName(FulfillmentConstants.Pipelines.Blocks.PersistFulfillmentFeeBookBlock)]
    public class PersistFulfillmentFeeBookBlock: PipelineBlock<FulfillmentFeeBook, FulfillmentFeeBook, CommercePipelineExecutionContext>
    {
        private readonly IPersistEntityPipeline _persistEntityPipeline;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistFulfillmentFeeBookBlock"/> class.
        /// </summary>
        /// <param name="persistEntityPipeline">The persist entity pipeline.</param>
        public PersistFulfillmentFeeBookBlock(IPersistEntityPipeline persistEntityPipeline)
              : base(null)
        {
            this._persistEntityPipeline = persistEntityPipeline;
        }

        /// <summary>
        /// Runs the specified argument.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public override async Task<FulfillmentFeeBook> Run(FulfillmentFeeBook arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull(string.Format("{0}: The Fulfillment fee book can not be null", this.Name));
            PersistEntityArgument persistEntityArgument = await this._persistEntityPipeline.Run(new PersistEntityArgument(arg), context);
            context.CommerceContext.Entities.Add(arg);
            return arg;
        }
    }
}
