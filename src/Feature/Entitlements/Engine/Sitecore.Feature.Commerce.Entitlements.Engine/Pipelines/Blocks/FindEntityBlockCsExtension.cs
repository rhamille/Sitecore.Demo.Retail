
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Linq;
using System.Threading.Tasks;

using Sitecore.Commerce.Plugin.Customers.Cs;
using Sitecore.Commerce.Plugin.Customers;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Blocks
{
    public class FindEntityBlockCsExtension : PipelineBlock<FindEntityArgument, FindEntityArgument, CommercePipelineExecutionContext>
    {
        private IFindCustomerPipeline _findCustomerPipeline;

        public FindEntityBlockCsExtension(IFindCustomerPipeline findCustomerPipeline)
      : base((string) null)
    {
            this._findCustomerPipeline = findCustomerPipeline;
        }

        public override async Task<FindEntityArgument> Run(FindEntityArgument arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<FindEntityArgument>(arg).IsNotNull<FindEntityArgument>(string.Format("{0}: FindEntityArgument can not be null", (object)this.Name));
            if (!arg.EntityId.StartsWith(CommerceEntity.IdPrefix<Customer>(), StringComparison.OrdinalIgnoreCase))
                return arg;
            string customerId = arg.EntityId.Substring(CommerceEntity.IdPrefix<Customer>().Length);
            GetCustomerArgument customerArgument = context.CommerceContext.Objects.OfType<GetCustomerArgument>().FirstOrDefault<GetCustomerArgument>();
            if (customerArgument == null)
            {
                customerArgument = new GetCustomerArgument(customerId, string.Empty, true);
                context.CommerceContext.AddUniqueObjectByType((object)customerArgument);
            }
            FoundEntity foundEntity = context.CommerceContext.Objects.OfType<FoundEntity>().FirstOrDefault<FoundEntity>((Func<FoundEntity, bool>)(p => p.EntityId == arg.EntityId));
            FoundEntity foundEntity1 = foundEntity;
            if (!string.IsNullOrEmpty(foundEntity1 != null ? foundEntity1.SerializedEntity : (string)null) && !customerArgument.IncludeDetails)
            {
                context.Logger.LogDebug(string.Format("Customers.FindEntity.InCtx.{0}: EntityId={1}", (object)arg.EntityType.Name, (object)arg.EntityId), Array.Empty<object>());
                arg.SerializedEntity = foundEntity.SerializedEntity;
                return arg;
            }
            try
            {
                IFindCustomerPipeline customerPipeline = this._findCustomerPipeline;
                Customer customer1 = new Customer();
                string entityId = arg.EntityId;
                customer1.Id = entityId;
                string str = customerId;
                customer1.FriendlyId = str;
                CommercePipelineExecutionContext context1 = context;
                Customer customer2 = await customerPipeline.Run(customer1, context1);
                if (customer2 == null)
                    return arg;
                Customer customer3 = arg.Entity as Customer;
                FoundEntity foundEntity2 = foundEntity;
                if (!string.IsNullOrEmpty(foundEntity2 != null ? foundEntity2.SerializedEntity : (string)null) && customer3 == null)
                {
                    FoundEntity foundEntity3 = foundEntity;
                    customer3 = JsonConvert.DeserializeObject<Customer>(foundEntity3 != null ? foundEntity3.SerializedEntity : (string)null, new JsonSerializerSettings()
                    {
                        TypeNameHandling = TypeNameHandling.Auto,
                        NullValueHandling = NullValueHandling.Ignore
                    });
                }
                if (customer3 != null)
                {
                    foreach (Component component in customer3.Components.Where<Component>((Func<Component, bool>)(c =>
                    {
                        if (!(c is CustomerDetailsComponent))
                            return !(c is AddressComponent);
                        return false;
                    })).ToList<Component>())
                        customer2.Components.Add(component);
                }
                var version = arg.Entity?.Version ?? customer2?.Version ?? 0;
                var persisted = arg.Entity?.IsPersisted ?? customer2?.IsPersisted ?? false;

                arg.Entity = (CommerceEntity)customer2;

                if (arg.Entity != null)
                {
                    arg.Entity.Version = version;
                    arg.Entity.IsPersisted = persisted;
                }

                if (foundEntity == null)
                {
                    FoundEntity foundEntity3 = new FoundEntity();
                    foundEntity3.EntityId = arg.EntityId;
                    foundEntity3.SerializedEntity = (string)null;
                    int num1 = 0;
                    foundEntity3.FoundInCache = num1 != 0;
                    int num2 = 0;
                    foundEntity3.CachedAsEntity = num2 != 0;
                    foundEntity = foundEntity3;
                    context.CommerceContext.AddObject((object)foundEntity);
                }
                else
                {
                    foundEntity.Entity = (object)arg.Entity;
                    foundEntity.SerializedEntity = (string)null;
                }
                return arg;
            }
            catch (Exception ex)
            {
                context.CommerceContext.LogException(string.Format("Customers.FindEntityBlock.Exception: EntityId={0}", (object)arg.EntityId), ex);
                throw;
            }
        }
    }
}
