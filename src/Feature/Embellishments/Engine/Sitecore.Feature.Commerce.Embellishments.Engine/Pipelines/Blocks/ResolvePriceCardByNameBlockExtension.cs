using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Pricing;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class ResolvePriceCardByNameBlockExtension : PipelineBlock<string, PriceCard, CommercePipelineExecutionContext>
    {
        private readonly IResolvePriceBookNamePipeline _resolvePriceBookNamePipeline;
        private readonly IFindEntityPipeline _findEntityPipeline;

        public ResolvePriceCardByNameBlockExtension(IFindEntityPipeline findEntityPipeline, IResolvePriceBookNamePipeline resolvePriceBookNamePipeline)
      : base((string) null)
    {
            this._findEntityPipeline = findEntityPipeline;
            this._resolvePriceBookNamePipeline = resolvePriceBookNamePipeline;
        }

        public override async Task<PriceCard> Run(string arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<string>(arg).IsNotNullOrEmpty(string.Format("{0}: The price card name cannot be null or empty.", (object)this.Name));
            string bookName = await this._resolvePriceBookNamePipeline.Run(string.Empty, context);
            if (string.IsNullOrEmpty(bookName))
            {
                string str = await context.CommerceContext.AddMessage(context.GetPolicy<KnownResultCodes>().Warning, "BookNameNotFound", (object[])null, "Book name was not found.");
                return (PriceCard)null;
            }
            string partialId = string.Format("{0}-{1}", (object)bookName, (object)arg);
            PriceCard priceCard = await this._findEntityPipeline.Run(new FindEntityArgument(typeof(PriceCard), string.Format("{0}{1}", (object)CommerceEntity.IdPrefix<PriceCard>(), (object)partialId), false), context) as PriceCard;
            if (priceCard != null)
                return priceCard;
            string str1 = await context.CommerceContext.AddMessage(context.GetPolicy<KnownResultCodes>().Warning, "EntityNotFound", new object[1]
            {
        (object) partialId
            }, string.Format("Entity{0} was not found.", (object)partialId));
            return (PriceCard)null;
        }
    }
}
