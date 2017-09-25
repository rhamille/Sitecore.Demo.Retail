using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Catalog;
using System.Linq;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class GetSellableItemCatalogBlockExtension : PipelineBlock<SellableItem, SellableItem, CommercePipelineExecutionContext>
    {
        private readonly IGetCatalogPipeline _getCatalogPipeline;

        public GetSellableItemCatalogBlockExtension(IGetCatalogPipeline getCatalogPipeline)
      : base((string) null)
    {
            this._getCatalogPipeline = getCatalogPipeline;
        }

        public override async Task<SellableItem> Run(SellableItem arg, CommercePipelineExecutionContext context)
        {
            if (arg == null)
                return (SellableItem)null;
            if (!arg.HasComponent<CatalogComponent>())
                return arg;

            //var productArg = context.CommerceContext.Objects.OfType<ProductArgument>().FirstOrDefault<ProductArgument>();
            //Sitecore.Commerce.Plugin.Catalog.Catalog catalog = await this._getCatalogPipeline.Run(productArg.CatalogName, context);

            Sitecore.Commerce.Plugin.Catalog.Catalog catalog = await this._getCatalogPipeline.Run(arg.GetComponent<CatalogComponent>().Name, context);

            if (catalog == null)
                return arg;

            context.CommerceContext.AddUniqueObjectByType((object)catalog);
            return arg;
        }
    }
}