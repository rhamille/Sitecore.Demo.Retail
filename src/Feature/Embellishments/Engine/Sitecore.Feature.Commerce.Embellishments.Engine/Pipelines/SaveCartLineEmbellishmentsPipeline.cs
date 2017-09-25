using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Arguments;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines
{
    public class SaveCartLineEmbellishmentsPipeline : CommercePipeline<SaveCartLineEmbellishmentsArgument, Cart>, ISaveCartLineEmbellishmentsPipeline, IPipeline<SaveCartLineEmbellishmentsArgument, Cart, CommercePipelineExecutionContext>, IPipelineBlock<SaveCartLineEmbellishmentsArgument, Cart, CommercePipelineExecutionContext>, IPipelineBlock, IPipeline
    {
        public SaveCartLineEmbellishmentsPipeline(IPipelineConfiguration<ISaveCartLineEmbellishmentsPipeline> configuration, ILoggerFactory loggerFactory)
          : base((IPipelineConfiguration)configuration, loggerFactory)
        {
        }
    }
}
