﻿using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Foundation.DependencyInjection;

namespace Sitecore.Feature.Commerce.Catalog.Website.Infrastructure
{
    public class ServicesConfigurator : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddClassesWithServiceAttribute();
            serviceCollection.AddMvcControllersInCurrentAssembly();
        }
    }
}