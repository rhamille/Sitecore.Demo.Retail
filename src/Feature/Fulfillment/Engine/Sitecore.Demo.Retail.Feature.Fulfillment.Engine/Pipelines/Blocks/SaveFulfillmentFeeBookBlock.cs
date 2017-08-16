using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System.Threading.Tasks;
using System.Linq;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Save Fulfillment Fee Book
    /// </summary>
    /// <seealso cref="PipelineBlock{SaveFulfillmentFeeBookArgument, FulfillmentFeeBook, CommercePipelineExecutionContext}" />
    [PipelineDisplayName(FulfillmentConstants.Pipelines.Blocks.SaveFulfillmentFeeBookBlock)]
    public class SaveFulfillmentFeeBook : PipelineBlock<SaveFulfillmentFeeBookArgument, FulfillmentFeeBook, CommercePipelineExecutionContext>
    {
        private readonly IDoesEntityExistPipeline _findEntityPipeline;
        private readonly IGetCurrencySetPipeline _getCurrencySetPipeline;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveFulfillmentFeeBook"/> class.
        /// </summary>
        /// <param name="findEntityPipeline">The find entity pipeline.</param>
        /// <param name="getCurrencySetPipeline">The get currency set pipeline.</param>
        public SaveFulfillmentFeeBook(IDoesEntityExistPipeline findEntityPipeline, IGetCurrencySetPipeline getCurrencySetPipeline)
          : base((string)null)
        {
            this._findEntityPipeline = findEntityPipeline;
            this._getCurrencySetPipeline = getCurrencySetPipeline;
        }

        /// <summary>
        /// Runs the specified argument.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public async override Task<FulfillmentFeeBook> Run(SaveFulfillmentFeeBookArgument arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull(string.Format("{0}: The argument cannot be null.", this.Name));
            Condition.Requires(arg.Name).IsNotNullOrEmpty(string.Format("{0}: The Fulfillment fee book name cannot be null or empty.", this.Name));
            Condition.Requires(arg.FulfillmentFees).IsNotNull(string.Format("{0}: The Fulfillment fee collection cannot be null.", this.Name));
            Condition.Requires(arg.FulfillmentFees).IsLongerThan(0, string.Format("{0}: The Fulfillment fee collection must have one or more entries.", this.Name));


            string str = await context.CommerceContext.AddMessage(
                context.GetPolicy<KnownResultCodes>().Information,
                null,
                null,
                string.Format("Fulfillment Fee Book '{0}', will be '{1}'.", arg.Name, arg.FulfillmentFeeBook == null ? "created" : "replaced"));

            var fulfillmentOptionGroupList = from df in arg.FulfillmentFees
                                          group df by new
                                          {
                                              df.FulfillmentMethodName,
                                              df.Fee.CurrencyCode
                                          } into gdf
                                          select new
                                          {
                                              FulfillmentMethodName = gdf.Key.FulfillmentMethodName,
                                              CurrencyCode = gdf.Key.CurrencyCode,
                                              DefaultCount = gdf.Count(options => options.IsDefault.Equals(true))
                                          };

            foreach (var fulfillmentOptionGroup in fulfillmentOptionGroupList)
            {
                if (fulfillmentOptionGroup.DefaultCount != 1)
                {
                    string reason = await context.CommerceContext.AddMessage(
                        context.GetPolicy<KnownResultCodes>().ValidationError,
                        "FulfillmentFeeOptionDefaultNotFound",
                        new object[2] { fulfillmentOptionGroup.FulfillmentMethodName, fulfillmentOptionGroup.CurrencyCode },
                        $"Fee default for fulfillment method '{fulfillmentOptionGroup.FulfillmentMethodName}' and currency code '{fulfillmentOptionGroup.CurrencyCode}' was not found. Count of defaults found '{fulfillmentOptionGroup.DefaultCount}'."
                        );

                    context.Abort(reason, context);
                    return await Task.FromResult<FulfillmentFeeBook>(null);
                }
            }

            var FulfillmentFeeBook = arg.FulfillmentFeeBook;
            if (FulfillmentFeeBook == null)
            {
                FulfillmentFeeBook = new FulfillmentFeeBook(arg.Name, arg.FulfillmentFees);
            }
            else
            {
                FulfillmentFeeBook.FulfillmentFees = arg.FulfillmentFees;
            }

            return await Task.FromResult(FulfillmentFeeBook);
        }
    }
}

