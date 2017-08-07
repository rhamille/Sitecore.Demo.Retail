using Sitecore.Commerce.Core;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Fulfillment Fee
    /// </summary>
    public class FulfillmentFee
    {
        /// <summary>
        /// Gets or sets the name of the fulfillment method.
        /// </summary>
        /// <value>
        /// The name of the fulfillment method.
        /// </value>
        public string FulfillmentMethodName { get; set; }

        /// <summary>
        /// Gets or sets the Fulfillment option key.
        /// </summary>
        /// <value>
        /// The Fulfillment option key.
        /// </value>
        public string FulfillmentTypeName { get; set; }

        /// <summary>
        /// Gets or sets the fee.
        /// </summary>
        /// <value>
        /// The fee.
        /// </value>
        public Money Fee { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is default.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        public bool IsDefault { get; set; }
    }
}
