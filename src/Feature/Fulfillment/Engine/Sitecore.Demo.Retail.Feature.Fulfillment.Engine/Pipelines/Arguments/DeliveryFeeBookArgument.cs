using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;
using Sitecore.Commerce.Core;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PipelineArgument" />
    public class FulfillmentFeeBookArgument : PipelineArgument
    {
        /// <summary>
        /// Gets or sets the Fulfillment fee book.
        /// </summary>
        /// <value>
        /// The Fulfillment fee book.
        /// </value>
        public FulfillmentFeeBook FulfillmentFeeBook { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentFeeBookArgument"/> class.
        /// </summary>
        /// <param name="FulfillmentFeeBook">The Fulfillment fee book.</param>
        public FulfillmentFeeBookArgument(FulfillmentFeeBook FulfillmentFeeBook)
        {
            this.FulfillmentFeeBook = FulfillmentFeeBook;
        }
    }
}