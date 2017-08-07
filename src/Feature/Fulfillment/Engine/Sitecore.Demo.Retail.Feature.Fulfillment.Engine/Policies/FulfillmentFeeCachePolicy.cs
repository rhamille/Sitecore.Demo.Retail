using Sitecore.Commerce.Core;
using Sitecore.Framework.Caching;
using System;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Fulfillment Cache Policy
    /// </summary>
    /// <seealso cref="CachePolicy" />
    public class FulfillmentFeeCachePolicy : Policy //CachePolicy in upd1
    {
        /// <summary>
        /// Gets or sets the name of the cache.
        /// </summary>
        /// <value>
        /// The name of the cache.
        /// </value>
        public string CacheName { get; set; }

        /// <summary>
        /// Gets or sets the expiration.
        /// </summary>
        /// <value>
        /// The expiration.
        /// </value>
        public int Expiration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow caching].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow caching]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowCaching { get; set; }

        /// <summary>
        /// Gets the cache entry options.
        /// </summary>
        /// <returns></returns>
        public virtual CacheEntryOptions GetCacheEntryOptions()
        {
            return new CacheEntryOptions()
            {
                AbsoluteExpiration = new DateTimeOffset?(DateTimeOffset.UtcNow.AddMilliseconds((double)this.Expiration))
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentFeeCachePolicy"/> class.
        /// </summary>
        public FulfillmentFeeCachePolicy()
        {
            this.Expiration = 300000;
            this.AllowCaching = true;
            this.CacheName = "FulfillmentFeeBooks";
        }
    }
}
