using Sitecore.Commerce.Core;
using System.Collections.Generic;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Components
{
    /// <summary>
    /// Fulfillment Fee Component
    /// </summary>
    /// <seealso cref="Component" />
    public class EmbellishmentComponent : Component
    {
        /// <summary>
        /// Gets or sets the name of the fulfillment type.
        /// </summary>
        /// <value>
        /// The name of the fulfillment type.
        /// </value>
        public string ItemId { get; set; }
        public string ExternalId { get; set; }
        public uint Quantity { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public EmbellishmentComponent(string itemId,
                string externalId,
                uint quantity,
                string type,
                string value)
        {
            this.ItemId = itemId;
            this.ExternalId = externalId;
            this.Quantity = quantity;
            this.Type = type;
            this.Value = value;
        }
    }

    /// <summary>
    /// TODO:// Handle multiple
    /// </summary>
    /// <seealso cref="Component" />
    //public class EmbellishmentsComponent : Component
    //{
    //    /// <summary>
    //    /// Gets or sets the name of the fulfillment type.
    //    /// </summary>
    //    /// <value>
    //    /// The name of the fulfillment type.
    //    /// </value>
    //    public List<EmbellishmentComponent> Embellishments { get; set; }
    //}
}