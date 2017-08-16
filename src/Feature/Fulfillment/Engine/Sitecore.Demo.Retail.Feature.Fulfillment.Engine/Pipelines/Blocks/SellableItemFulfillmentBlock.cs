using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Catalog;
using Sitecore.Framework.Pipelines;
using CommerceServer.Core.Catalog;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Sellable Item Fulfillment Block
    /// </summary>
    /// <seealso cref="PipelineBlock{SellableItem, SellableItem, CommercePipelineExecutionContext}" />
    [PipelineDisplayName(FulfillmentConstants.Pipelines.Blocks.SellableItemFulfillmentBlock)]
    public class SellableItemFulfillmentBlock : PipelineBlock<SellableItem, SellableItem, CommercePipelineExecutionContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellableItemFulfillmentBlock"/> class.
        /// </summary>
        public SellableItemFulfillmentBlock()
          : base(null)
        {
        }

        /// <summary>
        /// Runs the specified argument.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public override Task<SellableItem> Run(SellableItem arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull("The argument can not be null");

            var product = context.CommerceContext.GetObjects<Product>().FirstOrDefault(p => p.ProductId.Equals(arg.FriendlyId, StringComparison.OrdinalIgnoreCase));

            if (product[FulfillmentConstants.ProductAttributes.FulfillmentTypeAttributeName] != null)
            {
                arg.GetComponent<FulfillmentFeeComponent>().FulfillmentTypeName = product[FulfillmentConstants.ProductAttributes.FulfillmentTypeAttributeName].ToString();
            }

            return Task.FromResult(arg);
        }
    }
}