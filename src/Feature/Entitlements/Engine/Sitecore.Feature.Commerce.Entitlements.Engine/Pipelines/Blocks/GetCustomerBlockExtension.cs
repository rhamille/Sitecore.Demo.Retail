using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Customers;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Blocks
{
    public class GetCustomerBlockExtension : PipelineBlock<GetCustomerArgument, Customer, CommercePipelineExecutionContext>
    {
        private readonly IFindEntityPipeline _findEntityPipeline;

        public GetCustomerBlockExtension(IFindEntityPipeline findEntityPipeline)
      : base((string) null)
    {
            this._findEntityPipeline = findEntityPipeline;
        }

        public override async Task<Customer> Run(GetCustomerArgument arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<GetCustomerArgument>(arg).IsNotNull<GetCustomerArgument>(string.Format("{0}: The argument can not be null.", (object)this.Name));
            if (string.IsNullOrEmpty(arg.CustomerId) && string.IsNullOrEmpty(arg.CustomerEmail))
            {
                string str = await context.CommerceContext.AddMessage(context.GetPolicy<KnownResultCodes>().Error, "InvalidOrMissingPropertyValue", new object[2]
                {
          (object) "CustomerId",
          (object) "CustomerEmail"
                }, "Invalid or missing value for property 'CustomerId' or 'CustomerEmail'.");
                return (Customer)null;
            }
            string customerFriendlyId = arg.CustomerId;
            string customerId = string.Format("{0}{1}", (object)CommerceEntity.IdPrefix<Customer>(), (object)arg.CustomerId);
            if (!string.IsNullOrEmpty(arg.CustomerId) && arg.CustomerId.StartsWith(string.Format("{0}", (object)CommerceEntity.IdPrefix<Customer>())))
            {
                customerFriendlyId = arg.CustomerId.Remove(0, string.Format("{0}", (object)CommerceEntity.IdPrefix<Customer>()).Length);
                customerId = arg.CustomerId;
            }
            if (!string.IsNullOrEmpty(arg.CustomerEmail))
            {
                EntityIndex entityIndex = await this._findEntityPipeline.Run(new FindEntityArgument(typeof(EntityIndex), string.Format("{0}{1}", (object)EntityIndex.IndexPrefix<Customer>("Id"), (object)arg.CustomerEmail), false), context) as EntityIndex;
                if (entityIndex != null)
                {
                    customerFriendlyId = entityIndex.EntityId;
                    customerId = string.Format("{0}{1}", (object)CommerceEntity.IdPrefix<Customer>(), (object)entityIndex.EntityId);
                }
                else
                {
                    string str = await context.CommerceContext.AddMessage(context.GetPolicy<KnownResultCodes>().Error, "EntityNotFound", new object[1]
                    {
            (object) arg
                    }, string.Format("Entity {0} was not found.", (object)arg));
                    return (Customer)null;
                }
            }
            context.CommerceContext.AddUniqueObjectByType((object)arg);
            Customer customer1 = await this._findEntityPipeline.Run(new FindEntityArgument(typeof(Customer), customerId, false), context) as Customer;
            if (customer1 == null)
            {
                Customer customer2 = new Customer();
                string str1 = customerId;
                customer2.Id = str1;
                string str2 = customerFriendlyId;
                customer2.FriendlyId = str2;
                customer1 = customer2;
            }
            return customer1;
        }
    }
}
