using Sitecore.Commerce.Core;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Components
{
    public class SubLinesComponent : Component
    {
        /// <summary>
        /// Gets or sets the name of the fulfillment type.
        /// </summary>
        /// <value>
        /// The name of the fulfillment type.
        /// </value>
        public string ParentId { get; set; }
    }
}