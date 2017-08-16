using System.Threading.Tasks;
using Microsoft.AspNetCore.OData.Builder;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PipelineBlock{ODataConventionModelBuilder, ODataConventionModelBuilder, CommercePipelineExecutionContext}" />
    [PipelineDisplayName(FulfillmentConstants.Pipelines.Blocks.ConfigureServiceApiBlock)]
    public class ConfigureServiceApiBlock : PipelineBlock<ODataConventionModelBuilder, ODataConventionModelBuilder, CommercePipelineExecutionContext>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureServiceApiBlock"/> class.
        /// </summary>
        public ConfigureServiceApiBlock()
          : base(null)
        {}

        /// <summary>
        /// Runs the specified model builder.
        /// </summary>
        /// <param name="modelBuilder">The model builder.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public override Task<ODataConventionModelBuilder> Run(ODataConventionModelBuilder modelBuilder, CommercePipelineExecutionContext context)
        {
            Condition.Requires(modelBuilder).IsNotNull("The argument can not be null");

            var actionConfiguration1 = modelBuilder.Action("SaveFulfillmentFeeBook");
            actionConfiguration1.Parameter<string>("name");
            actionConfiguration1.CollectionParameter<FulfillmentFee>("FulfillmentFees");
            actionConfiguration1.ReturnsFromEntitySet<CommerceCommand>("Commands");

            return Task.FromResult(modelBuilder);
        }
    }
}
