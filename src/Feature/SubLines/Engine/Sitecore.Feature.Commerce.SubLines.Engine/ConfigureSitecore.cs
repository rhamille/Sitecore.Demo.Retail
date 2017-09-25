﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Configuration;

namespace Sitecore.Feature.Commerce.SubLines.Engine
{
    public class ConfigureSitecore : IConfigureSitecore
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.RegisterAllPipelineBlocks(assembly);
            services.RegisterAllCommands(assembly);

            //services.Sitecore().Pipelines(config => config

            //    .ConfigurePipeline<IProvisionEntitlementsPipeline>(c =>
            //    {
            //        c.Add<ProvisionWarrantyEntitlementsBlock>().After<ProvisionEntitlementsBlock>()
            //            .Add<ProvisionDigitalProductEntitlementsBlock>().After<ProvisionEntitlementsBlock>()
            //            .Add<ProvisionInstallationEntitlementsBlock>().After<ProvisionEntitlementsBlock>();
            //    })

            //    .ConfigurePipeline<IGetEntityViewPipeline>(c =>
            //    {
            //        c.Add<GetOrderDigitalProductEntitlementDetailsViewBlock>().After<GetOrderEntitlementsViewBlock>()
            //            .Add<GetCustomerDigitalProductEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>()
            //            .Add<GetOrderWarrantyEntitlementDetailsViewBlock>().After<GetOrderEntitlementsViewBlock>()
            //            .Add<GetCustomerWarrantyEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>()
            //            .Add<GetOrderInstallationEntitlementDetailsViewBlock>().After<GetOrderEntitlementsViewBlock>()
            //            .Add<GetCustomerInstallationEntitlementDetailsViewBlock>().After<GetCustomerEntitlementsViewBlock>();
            //    })
            //);
        }
    }
}
