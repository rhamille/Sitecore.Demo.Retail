using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using System.Threading.Tasks;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Global Policy
    /// </summary>
    /// <seealso cref="Sitecore.Commerce.Core.Policy" />
    public class GlobalPolicy : Policy
    {
        /// <summary>
        /// Gets or sets the default name of the Fulfillment fee book.
        /// </summary>
        /// <value>
        /// The default name of the Fulfillment fee book.
        /// </value>
        public string DefaultFulfillmentFeeBookName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalPolicy"/> class.
        /// </summary>
        public GlobalPolicy()
        {
            this.DefaultFulfillmentFeeBookName = "Default";
        }

        /// <summary>
        /// Gets the name of the Fulfillment fee book.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public string GetFulfillmentFeeBookName(string name, CommerceContext context)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return name;
            }

            context.Logger.LogDebug("Using default Fulfillment fee book name.");
            return this.DefaultFulfillmentFeeBookName;
        }
    }
}
