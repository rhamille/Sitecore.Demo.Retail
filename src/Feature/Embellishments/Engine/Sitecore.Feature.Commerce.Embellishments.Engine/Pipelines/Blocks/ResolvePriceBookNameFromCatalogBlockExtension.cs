using Sitecore.Commerce.Core;
using Sitecore.Framework.Pipelines;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Catalog.Cs;
using Sitecore.Commerce.Plugin.Catalog;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class ResolvePriceBookNameFromCatalogBlockExtension : PipelineBlock<string, string, CommercePipelineExecutionContext>
    {
        public ResolvePriceBookNameFromCatalogBlockExtension()
          : base((string)null)
        {
        }

        public override Task<string> Run(string arg, CommercePipelineExecutionContext context)
        {
            if (!string.IsNullOrEmpty(arg))
                return Task.FromResult<string>(arg);
            Sitecore.Commerce.Plugin.Catalog.Catalog catalog = context.CommerceContext.Objects.OfType<Sitecore.Commerce.Plugin.Catalog.Catalog>().FirstOrDefault<Sitecore.Commerce.Plugin.Catalog.Catalog>();
            if (catalog == null)
                return Task.FromResult<string>((string)null);
            EntityReference priceBook = catalog.PriceBook;
            string result = !string.IsNullOrEmpty(priceBook != null ? priceBook.Name : (string)null) ? catalog.PriceBook.Name : string.Empty;
            if (!string.IsNullOrEmpty(result))
                return Task.FromResult<string>(result);
            return Task.FromResult<string>((string)null);
        }
    }
}
