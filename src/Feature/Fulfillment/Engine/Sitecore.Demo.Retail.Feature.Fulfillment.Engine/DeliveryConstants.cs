using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Fulfillment Constants
    /// </summary>
    public class FulfillmentConstants
    {
        /// <summary>
        /// Pipelines
        /// </summary>
        public static class Pipelines
        {
            /// <summary>
            /// The save Fulfillment fee book pipeline
            /// </summary>
            public const string SaveFulfillmentFeeBookPipeline = "Fulfillment.Pipeline.SaveFulfillmentFeeBook";

            /// <summary>
            /// Blocks
            /// </summary>
            public static class Blocks
            {
                /// <summary>
                /// The calculate cart lines Fulfillment block
                /// </summary>
                public const string CalculateCartLinesFulfillmentBlock = "Fulfillment.Block.CalculateCartLinesFulfillment";
                /// <summary>
                /// The configure service API block
                /// </summary>
                public const string ConfigureServiceApiBlock = "Fulfillment.Block.ConfigureServiceApi";
                /// <summary>
                /// The persist Fulfillment fee book block
                /// </summary>
                public const string PersistFulfillmentFeeBookBlock = "Fulfillment.Block.PersistFulfillmentFeeBook";
                /// <summary>
                /// The save Fulfillment fee book block
                /// </summary>
                public const string SaveFulfillmentFeeBookBlock = "Fulfillment.Block.SaveFulfillmentFeeBook";
                /// <summary>
                /// The sellable item Fulfillment block
                /// </summary>
                public const string SellableItemFulfillmentBlock = "Fulfillment.Block.SellableItemFulfillment";
                /// <summary>
                /// The add cart line Fulfillment block
                /// </summary>
                public const string AddCartLineFulfillmentBlock = "Fulfillment.Block.AddCartLineFulfillment";
            }
        }

        /// <summary>
        /// Product Attributes
        /// </summary>
        public static class ProductAttributes
        {
            /// <summary>
            /// The Fulfillment type key attribute name
            /// </summary>
            public const string FulfillmentTypeAttributeName = "FulfillmentType";
        }

        /// <summary>
        /// Awarded Adjustment Attributes
        /// </summary>
        public static class AwardedAdjustmentAttributes
        {
            /// <summary>
            /// The Fulfillment type key attribute name
            /// </summary>
            public const string FulfillmentFeeAttributeName = "FulfillmentFee";
        }
    }
}
