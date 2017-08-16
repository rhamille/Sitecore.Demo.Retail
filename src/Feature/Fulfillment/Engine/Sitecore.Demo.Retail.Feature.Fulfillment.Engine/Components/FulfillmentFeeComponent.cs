using Sitecore.Commerce.Core;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Fulfillment Fee Component
    /// </summary>
    /// <seealso cref="Component" />
    public class FulfillmentFeeComponent : Component
    {
        /// <summary>
        /// Gets or sets the name of the fulfillment type.
        /// </summary>
        /// <value>
        /// The name of the fulfillment type.
        /// </value>
        public string FulfillmentTypeName { get; set; }
    }
}