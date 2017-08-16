using Sitecore.Commerce.Core;
using Sitecore.Framework.Caching;
using System;
using System.Threading.Tasks;

namespace Sitecore.Demo.Retail.Feature.Fulfillment.Engine
{
    /// <summary>
    /// Get Fulfillment Fee Book Command
    /// </summary>
    /// <seealso cref="Sitecore.Demo.Retail.Feature.Fulfillment.Engine.FulfillmentCommerceCommand" />
    public class GetFulfillmentFeeBookCommand : FulfillmentCommerceCommand
    {
        private readonly IGetEnvironmentCachePipeline _cachePipeline;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentFeeBookCommand"/> class.
        /// </summary>
        /// <param name="findEntityPipeline">The find entity pipeline.</param>
        /// <param name="serviceProvider">The service provider.</param>
        /// <param name="cachePipeline">The cache pipeline.</param>
        public GetFulfillmentFeeBookCommand(IFindEntityPipeline findEntityPipeline, IServiceProvider serviceProvider, IGetEnvironmentCachePipeline cachePipeline)
          : base(findEntityPipeline, serviceProvider)
        {
            this._cachePipeline = cachePipeline;
        }

        /// <summary>
        /// Processes the specified commerce context.
        /// </summary>
        /// <param name="commerceContext">The commerce context.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public virtual async Task<FulfillmentFeeBook> Process(CommerceContext commerceContext, string name = "")
        {
            using (var activity = CommandActivity.Start(commerceContext, this))
            {
                var FulfillmentFeeBookName = commerceContext.GetPolicy<GlobalPolicy>().GetFulfillmentFeeBookName(name, commerceContext);
                var cachePolicy = commerceContext.GetPolicy<FulfillmentFeeCachePolicy>();
                var cacheKey = string.Format("{0}{1}", commerceContext.CurrentLanguage(), FulfillmentFeeBookName);

                ICache cache = null;
                FulfillmentFeeBook FulfillmentFeeBook = null;

                if (cachePolicy.AllowCaching)
                {
                    var environmentCacheArgument = new EnvironmentCacheArgument { CacheName = cachePolicy.CacheName };
                    cache = await _cachePipeline.Run(environmentCacheArgument, commerceContext.GetPipelineContextOptions());
                    FulfillmentFeeBook = await cache.Get(cacheKey) as FulfillmentFeeBook;
                }

                if (FulfillmentFeeBook == null)
                {
                    FulfillmentFeeBook = await this.GetFulfillmentFeeBook(commerceContext, FulfillmentFeeBookName);

                    if (cachePolicy.AllowCaching && cache != null)
                    {
                        await cache.Set(cacheKey, new Cachable<FulfillmentFeeBook>(FulfillmentFeeBook, 1L), cachePolicy.GetCacheEntryOptions());
                    }
                }

                return FulfillmentFeeBook;
            }
        }
    }
}