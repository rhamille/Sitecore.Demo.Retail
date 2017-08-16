using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Fulfillment;
using Sitecore.Framework.Conditions;
using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Plugin.Pricing;
using Sitecore.Demo.Retail.Feature.Fulfillment.Engine;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PipelineBlock{Cart, Cart, CommercePipelineExecutionContext}" />
    [PipelineDisplayName(FulfillmentConstants.Pipelines.Blocks.CalculateCartLinesFulfillmentBlock)]
    public class CalculateCartLinesFulfillmentBlock : PipelineBlock<Cart, Cart, CommercePipelineExecutionContext>
    {
        private GetFulfillmentFeeBookCommand _getFulfillmentFeeBookCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculateCartFulfillmentBlock" /> class.
        /// </summary>
        /// <param name="getFulfillmentFeeBookCommand">The get fulfillment fee book command.</param>
        public CalculateCartLinesFulfillmentBlock(GetFulfillmentFeeBookCommand getFulfillmentFeeBookCommand)
          : base(null)
        {
            this._getFulfillmentFeeBookCommand = getFulfillmentFeeBookCommand;
        }

        /// <summary>
        /// Runs the specified argument.
        /// </summary>
        /// <param name="arg">The argument.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public override async Task<Cart> Run(Cart arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires(arg).IsNotNull(string.Format("{0}: The cart cannot be null.", this.Name));
            Condition.Requires(arg.Lines).IsNotNull(string.Format("{0}: The cart lines cannot be null.", this.Name));

            List<CartLineComponent> list = arg.Lines
                .Where(line => line != null)
                .Where(line => line.HasComponent<FulfillmentComponent>())
                .Select(l => l)
                .ToList();

            if (!list.Any())
            {
                context.Logger.LogDebug(string.Format("{0} - No lines with fulfillment components", this.Name));
                return arg;
            }
            else if (arg.Lines.Count() != list.Count())
            {
                // This should never happen.
                string reason = await context.CommerceContext.AddMessage(
                    context.GetPolicy<KnownResultCodes>().ValidationError,
                    "CartLinesFulfillmentComponentNotFound",
                    new object[2] { arg.Lines.Count(), list.Count() },
                    string.Format("Cart line fulfillment component not correctly set. '{0}' cart lines exist but only '{1}' have a fulfillment component set. Expected them to equal.", arg.Lines.Count(), list.Count())
                    );

                context.Abort(reason, context);
                return null;
            }

            var currency = context.CommerceContext.CurrentCurrency();

            var fulfillmentFeeBook = await _getFulfillmentFeeBookCommand.Process(context.CommerceContext);
            if (fulfillmentFeeBook == null || fulfillmentFeeBook.FulfillmentFees == null || !fulfillmentFeeBook.FulfillmentFees.Any())
            {
                context.Logger.LogDebug(string.Format("{0} - No fulfillment fee book available", this.Name));

                return null;
            }

            foreach (CartLineComponent cartLineComponent in list)
            {
                var lineFulfillmentComponent = cartLineComponent.ChildComponents.OfType<FulfillmentComponent>().FirstOrDefault();
                if (!(lineFulfillmentComponent is ElectronicFulfillmentComponent))
                {
                    continue;
                }

                var lineFulfillmentFeeComponent = cartLineComponent.ChildComponents.OfType<FulfillmentFeeComponent>().FirstOrDefault();
                var lineFulfillmentMethodName = lineFulfillmentComponent != null ? lineFulfillmentComponent.FulfillmentMethod.Name : null;
                var lineFulfillmentTypeName = lineFulfillmentFeeComponent != null ? lineFulfillmentFeeComponent.FulfillmentTypeName : null;

                var fulfillmentFee = this.GetFulfillmentFee(context, fulfillmentFeeBook, currency, lineFulfillmentMethodName, lineFulfillmentTypeName);
                if (fulfillmentFee == null)
                {
                    // This should never happen.
                    string reason = await context.CommerceContext.AddMessage(
                        context.GetPolicy<KnownResultCodes>().ValidationError,
                        "FulfillmentFeeNotFound",
                        new object[3] { lineFulfillmentMethodName, lineFulfillmentTypeName, currency },
                        string.Format("Fulfillment fee not found for fulfillment method '{0}', product fulfillment type '{1}' and currency code '{2}'.", lineFulfillmentMethodName, lineFulfillmentTypeName, currency)
                        );

                    context.Abort(reason, context);
                    return null;
                }

                this.SetFulfillmentFeeAward(context, cartLineComponent, fulfillmentFee);
            }

            return arg;
        }

        private FulfillmentFee GetFulfillmentFee(CommercePipelineExecutionContext context, FulfillmentFeeBook fulfillmentFeeBook, string currency, string fulfillmentMethodName, string fulfillmentTypeName)
        {
            FulfillmentFee fulfillmentFee = null;
            if (string.IsNullOrEmpty(fulfillmentMethodName))
            {
                fulfillmentFee = GetFulfillmentFeeDefault(fulfillmentFeeBook, currency, fulfillmentMethodName);
                context.Logger.LogDebug($"Default fee found for fulfillment method '{fulfillmentMethodName}', fulfillment type '{fulfillmentTypeName}' and currency code '{currency}'.");
            }
            else
            {
                fulfillmentFee = GetFulfillmentFeeByType(fulfillmentFeeBook, currency, fulfillmentMethodName, fulfillmentTypeName);
                context.Logger.LogDebug($"Specific fee found for fulfillment method '{fulfillmentMethodName}', fulfillment type '{fulfillmentTypeName}' and currency code '{currency}'.");
            }

            return fulfillmentFee;
        }

        private FulfillmentFee GetFulfillmentFeeDefault(FulfillmentFeeBook fulfillmentFeeBook, string currency, string fulfillmentMethodName)
        {
            return fulfillmentFeeBook.FulfillmentFees.Where(item =>
                item.FulfillmentMethodName.Equals(fulfillmentMethodName, StringComparison.OrdinalIgnoreCase)
                && item.Fee.CurrencyCode.Equals(currency, StringComparison.OrdinalIgnoreCase)
                && item.IsDefault.Equals(true))
                .FirstOrDefault();
        }

        private FulfillmentFee GetFulfillmentFeeByType(FulfillmentFeeBook fulfillmentFeeBook, string currency, string fulfillmentMethodName, string fulfillmentTypeName)
        {
            return fulfillmentFeeBook.FulfillmentFees.Where(item =>
                item.FulfillmentMethodName.Equals(fulfillmentMethodName, StringComparison.OrdinalIgnoreCase)
                && item.FulfillmentTypeName.Equals(fulfillmentTypeName, StringComparison.OrdinalIgnoreCase)
                && item.Fee.CurrencyCode.Equals(currency, StringComparison.OrdinalIgnoreCase)
                && item.IsDefault.Equals(true))
                .FirstOrDefault();
        }

        private void SetFulfillmentFeeAward(CommercePipelineExecutionContext context, CartLineComponent cartLineComponent, FulfillmentFee fulfillmentFee)
        {
            var awardedAdjustment = new CartLineLevelAwardedAdjustment()
            {
                Name = FulfillmentConstants.AwardedAdjustmentAttributes.FulfillmentFeeAttributeName,
                DisplayName = FulfillmentConstants.AwardedAdjustmentAttributes.FulfillmentFeeAttributeName,
                Adjustment = fulfillmentFee.Fee,
                AdjustmentType = context.GetPolicy<KnownCartAdjustmentTypesPolicy>().Fulfillment,
                IsTaxable = false,
                AwardingBlock = this.Name,
                IncludeInGrandTotal = false
            };

            context.Logger.LogDebug(string.Format("{0} - Added fulfillment fee to line:{1} {2}", this.Name, fulfillmentFee.Fee.CurrencyCode, fulfillmentFee.Fee.Amount));

            cartLineComponent.Adjustments.Add(awardedAdjustment);
        }
    }
}

