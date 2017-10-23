using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.Plugin.Customers;
using Sitecore.Feature.Commerce.Entitlements.Engine.Entities;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Arguments;
using Sitecore.Framework.Pipelines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Commands
{
    public class SaveCustomerSpendLimitEntitlementCommand : CommerceCommand
    {
        private readonly ISaveCustomerSpendLimitEntitlementPipeline _pipeline;
        private readonly IGetCustomerPipeline _getCustomerPipeline;

        public SaveCustomerSpendLimitEntitlementCommand(ISaveCustomerSpendLimitEntitlementPipeline pipeline, IGetCustomerPipeline getCustomerPipeline, IFindEntityPipeline findEntityPipeline, IServiceProvider serviceProvider)
            : base()
        {
            this._pipeline = pipeline;
            this._getCustomerPipeline = getCustomerPipeline;
        }

        public virtual async Task<SpendLimitEntitlement> Process(CommerceContext commerceContext, string customerId, decimal originalAmount, decimal balance)
        {

            CommercePipelineExecutionContextOptions context = commerceContext.GetPipelineContextOptions();

            var customer = await this._getCustomerPipeline.Run(new GetCustomerArgument(customerId, string.Empty, false), (IPipelineExecutionContextOptions)context).ConfigureAwait(false);

            if (customer != null)
            {
                return await this.Process(commerceContext, customer, originalAmount, balance).ConfigureAwait(false);
            }

            string str = await context.CommerceContext.AddMessage(
                                commerceContext.GetPolicy<KnownResultCodes>().ValidationError
                                , "EntityNotFound", new object[1] { (object)customerId }
                                , string.Format("Entity {0} was not found.", (object)customerId)
                                );

            return (SpendLimitEntitlement)null;
        }


        public virtual async Task<SpendLimitEntitlement> Process(CommerceContext commerceContext, Customer customer, decimal originalAmount, decimal balance)
        {
            using (var activity = CommandActivity.Start(commerceContext, this))
            {
                //Func<Task> func = await this.PerformTransaction(commerceContext, 
                //    (async () =>
                //    {

                CommercePipelineExecutionContextOptions context = commerceContext.GetPipelineContextOptions();
                var arg = new SaveCustomerSpendLimitEntitlementArgument(customer, new SpendLimitEntitlement { Customer = new EntityReference(customer.Id, ""), OriginalAmount = new Money(originalAmount), Balance = new Money(balance) });
                await _pipeline.Run(arg, new CommercePipelineExecutionContextOptions(commerceContext)).ConfigureAwait(false);

                //    }
                //));
                return (SpendLimitEntitlement)null;
            }
        }
    }
}
