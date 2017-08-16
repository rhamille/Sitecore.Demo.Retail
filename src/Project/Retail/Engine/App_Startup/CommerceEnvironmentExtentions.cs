using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Provider.FileSystem;
using System;

namespace Sitecore.Demo.Retail.Project.Engine.App_Startup
{
    public static class CommerceEnvironmentExtentions
    {
        public static CommerceEnvironment ConfigureCommerceEnvironment(this IServiceCollection services, IConfigurationRoot configuration, NodeContext node, IServiceProvider _hostServices)
        {
            var logger = ApplicationLogging.CreateLogger("ConfigEnvironment");

            logger.LogInformation($"Loading Global Environment using Filesystem Provider from: {node.BootstrapProviderPath}");
      var serializer = new EntitySerializerCommand(_hostServices);
      var bootstrapProvider = new FileSystemEntityProvider(node.BootstrapProviderPath, serializer);

            var appSettingBootstrapFileValue = configuration.GetSection("AppSettings:BootStrapFile").Value;
            if (!string.IsNullOrEmpty(appSettingBootstrapFileValue))
            {
                node.BootstrapEnvironmentPath = appSettingBootstrapFileValue;
            }

            node.AddDataMessage("NodeStartup", $"GlobalEnvironmentFrom='{node.BootstrapEnvironmentPath}.json'");

            var environment = bootstrapProvider.Find<CommerceEnvironment>(node, node.BootstrapEnvironmentPath, false).Result;

            services.AddSingleton(environment);

            return environment;
        }

        public static void Start (this IStartEnvironmentPipeline startEnvironmentPipeline, NodeContext node, IConfigurationRoot configuration)
        {
            // Starting the environment to register Minion policies and run Minions
            var environmentName = configuration.GetSection("AppSettings:EnvironmentName").Value;

            node.AddDataMessage("EnvironmentStartup", $"StartEnvironment={environmentName}");

            startEnvironmentPipeline.Run(environmentName, node.GetPipelineContextOptions()).Wait();
        }
    }
}
