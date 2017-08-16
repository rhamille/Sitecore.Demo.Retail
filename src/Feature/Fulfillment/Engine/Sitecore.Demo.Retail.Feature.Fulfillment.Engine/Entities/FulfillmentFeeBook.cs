using Sitecore.Commerce.Core;
using System.Collections.Generic;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Fulfillment Fee Book
    /// </summary>
    /// <seealso cref="CommerceEntity" />
    public class FulfillmentFeeBook : CommerceEntity
    {
        /// <summary>
        /// Gets or sets the Fulfillment fees.
        /// </summary>
        /// <value>
        /// The Fulfillment fees.
        /// </value>
        public IList<FulfillmentFee> FulfillmentFees { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentFeeBook"/> class.
        /// </summary>
        public FulfillmentFeeBook()
        {
            this.FulfillmentFees = new List<FulfillmentFee>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentFeeBook"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="FulfillmentFees">The Fulfillment fees.</param>
        public FulfillmentFeeBook(string name, IList<FulfillmentFee> FulfillmentFees)
        {
            this.Id = string.Format("{0}{1}", IdPrefix<FulfillmentFeeBook>(), name);
            this.Name = name;
            this.FulfillmentFees = FulfillmentFees;
        }
    }
}