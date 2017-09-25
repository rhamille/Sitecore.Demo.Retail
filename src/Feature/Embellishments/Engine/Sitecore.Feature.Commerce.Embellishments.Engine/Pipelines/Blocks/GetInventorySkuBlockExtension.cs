using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.CsAgent;
using Sitecore.Commerce.Plugin.Inventory;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Inventory.Cs;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    [ExcludeFromCodeCoverage]
    [PipelineDisplayName("CsInventory.block.getinventorysku")]
    public class GetInventorySkuBlockExtension : PipelineBlock<InventorySkuArgument, InventorySku, CommercePipelineExecutionContext>
    {
        private readonly GetInventoryCatalogCommand _getInventoryCatalogCommand;

        public GetInventorySkuBlockExtension(GetInventoryCatalogCommand getInventoryCatalogCommand)
          : base((string)null)
        {
            this._getInventoryCatalogCommand = getInventoryCatalogCommand;
        }

        public override async Task<InventorySku> Run(InventorySkuArgument arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<string>(arg.ProductId).IsNotNull<string>(string.Format("{0}: The product id can not be null", (object)this.Name));
            Condition.Requires<string>(arg.CatalogName).IsNotNull<string>(string.Format("{0}: The catalog name can not be null", (object)this.Name));
            CsCatalogPolicy catalogPolicy = context.CommerceContext.GetPolicy<CsCatalogPolicy>();
            InventorySku inventorySku = string.IsNullOrEmpty(arg.VariantId) ? context.CommerceContext.GetObjects<InventorySku>().FirstOrDefault<InventorySku>((Func<InventorySku, bool>)(p => p.ProductId.Equals(arg.ProductId, StringComparison.OrdinalIgnoreCase))) : context.CommerceContext.GetObjects<InventorySku>().FirstOrDefault<InventorySku>((Func<InventorySku, bool>)(p =>
            {
                if (p.ProductId.Equals(arg.ProductId, StringComparison.OrdinalIgnoreCase))
                    return p.VariantId.Equals(arg.VariantId, StringComparison.OrdinalIgnoreCase);
                return false;
            }));
            if (inventorySku != null)
            {
                if (context.CommerceContext.GetPolicy<Sitecore.Commerce.Plugin.Inventory.Cs.LoggingPolicy>().LogInventorySkuFromContext)
                    context.CommerceContext.Logger.LogDebug(string.Format("CsInventory.GetInvSku.FromCtx.{0}-{1}", (object)arg.ProductId, (object)arg.VariantId), Array.Empty<object>());
                return inventorySku;
            }
            InventoryCatalog inventoryCatalog = await this._getInventoryCatalogCommand.Process(context.CommerceContext, arg.CatalogName);
            if (inventoryCatalog != null)
            {
                inventorySku = await ConnectionHelperExtension.GetReadOnlyInventorySqlContext(context.CommerceContext).GetSku(inventoryCatalog.Name, arg.CatalogName, arg.ProductId, arg.VariantId);
            }
            else
            {
                string str1 = await context.CommerceContext.AddMessage(context.CommerceContext.GetPolicy<KnownResultCodes>().Error, "InventoryCatalogNotFound", new object[3]
                {
          (object) catalogPolicy.SiteName,
          (object) catalogPolicy.ServiceUrl,
          (object) context.CommerceContext.Environment.Name
                }, string.Format("CsInventory.GetInventorySku.InventoryCatalogNotFound: Catalog={0}|Site={1}|Url={2}|Environment={3}", new object[4]
                {
          (object) arg.CatalogName,
          (object) catalogPolicy.SiteName,
          (object) catalogPolicy.ServiceUrl,
          (object) context.CommerceContext.Environment.Name
                }));
            }
            if (inventorySku == null)
            {
                string str2 = await context.CommerceContext.AddMessage(context.CommerceContext.GetPolicy<KnownResultCodes>().Error, "InventorySkuNotFound", new object[6]
                {
          (object) catalogPolicy.SiteName,
          (object) catalogPolicy.ServiceUrl,
          (object) context.CommerceContext.Environment.Name,
          (object) arg.ProductId,
          (object) arg.VariantId,
          (object) arg.CatalogName
                }, string.Format("CsInventory.GetInvSku.NotFound.{0}-{1}: Catalog={2}|Site={3}|Url={4}|Environment={5}", (object)arg.ProductId, (object)arg.VariantId, (object)arg.CatalogName, (object)catalogPolicy.SiteName, (object)catalogPolicy.ServiceUrl, (object)context.CommerceContext.Environment.Name));
            }
            else
            {
                context.CommerceContext.Logger.LogInformation(string.Format("CsInventory.GetInvSku.Loaded.{0}-{1}", (object)arg.ProductId, (object)arg.VariantId), Array.Empty<object>());
                context.CommerceContext.AddObject((object)inventorySku);
            }
            return inventorySku;
        }
    }
}
