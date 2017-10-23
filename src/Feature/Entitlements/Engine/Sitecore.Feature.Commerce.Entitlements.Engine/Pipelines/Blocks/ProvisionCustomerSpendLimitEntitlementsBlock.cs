using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Availability;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Plugin.Entitlements;
using Sitecore.Commerce.Plugin.ManagedLists;
using Sitecore.Feature.Commerce.Entitlements.Engine.Entities;
using Sitecore.Feature.Commerce.Entitlements.Engine.Policies;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Arguments;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Blocks
{
    public class ProvisionCustomerSpendLimitEntitlementsBlock : PipelineBlock<SaveCustomerSpendLimitEntitlementArgument, SpendLimitEntitlement, CommercePipelineExecutionContext>
    {
        private readonly IPersistEntityPipeline _persistEntityPipeline;

        public ProvisionCustomerSpendLimitEntitlementsBlock(IPersistEntityPipeline persistEntityPipeline)
        {
            this._persistEntityPipeline = persistEntityPipeline;
        }

        public override async Task<SpendLimitEntitlement> Run(SaveCustomerSpendLimitEntitlementArgument arg, CommercePipelineExecutionContext context)
        {
            //var entitlements = arg as List<Entitlement> ?? arg.ToList();
            //Condition.Requires(entitlements).IsNotNull($"{this.Name}: The entitlements can not be null");

            //var argument = context.CommerceContext.GetObjects<ProvisionEntitlementsArgument>().FirstOrDefault();
            //if (argument == null)
            //{
            //    return arg.SpendLimit;
            //}

            //var customer = arg.Customer;

            try
            {
                var entitlement = arg.SpendLimit;
                var customer = arg.Customer;
                var customerEntitlement = customer.GetComponent<EntitlementsComponent>(); //.Entitlements.OfType<SpendLimitEntitlement>().FirstOrDefault();

                //if (customerEntitlement == null)
                //{
                //    customerEntitlement = customer.GetComponent<EntitlementsComponent>().ChildComponents.Add(entitlement);
                //}

                //var spendLimit = customerEntitlement.com

                var spendLimit = customerEntitlement.Entitlements.OfType<SpendLimitEntitlement>().FirstOrDefault();

                if (spendLimit == null)
                {
                    var id = Guid.NewGuid().ToString("N");
                    entitlement.Id = $"{CommerceEntity.IdPrefix<SpendLimitEntitlement>()}{id}";
                    entitlement.FriendlyId = id;
                    entitlement.SetComponent(
                        new ListMembershipsComponent
                        {
                            Memberships =
                                    new List<string>
                                        {
                                                $"{CommerceEntity.ListName<SpendLimitEntitlement>()}",
                                                $"{CommerceEntity.ListName<Entitlement>()}"
                                        }
                        });
                    entitlement.Order = new EntityReference();

                    if (arg.SpendLimit.Customer != null)
                    {
                        entitlement.Customer = arg.SpendLimit.Customer;
                        customer.GetComponent<EntitlementsComponent>().Entitlements.Add(new EntityItemReference(entitlement.Id, "") { EntityTarget = entitlement.Id });
                    }
                }
                else
                {
                    spendLimit.OriginalAmount = arg.SpendLimit.OriginalAmount;
                    spendLimit.Balance = arg.SpendLimit.Balance;
                    entitlement = spendLimit;
                }

                await this._persistEntityPipeline.Run(new PersistEntityArgument((CommerceEntity)entitlement), context);
                await this._persistEntityPipeline.Run(new PersistEntityArgument((CommerceEntity)customer), context);
                //PersistEntityArgument persistEntityArgument = await this._persistEntityPipeline.Run(new PersistEntityArgument((CommerceEntity)customer), context);
                context.Logger.LogInformation(
                    $"SpendLimitEntitlement Entitlement Created - Order=, LineId=, EntitlementId={entitlement.Id}");
            }
            catch(Exception ex)
            {
                context.Logger.LogError(
                    $"SpendLimitEntitlement Entitlement NOT Created - Order=, LineId=; Message={ex.Message}");
            }

            return arg.SpendLimit;

            //var order = argument.Order;
            //if (order == null)
            //{
            //    return entitlements.AsEnumerable();
            //}

            //var digitalTags = context.GetPolicy<KnownEntitlementsTags>().DigitalProductTags;
            //var lineWithDigitalGoods = order.Lines.Where(line => line != null 
            //    && line.GetComponent<CartProductComponent>().HasPolicy<AvailabilityAlwaysPolicy>()
            //    && line.GetComponent<CartProductComponent>().Tags.Select(t => t.Name).Intersect(digitalTags, StringComparer.OrdinalIgnoreCase).Any()).ToList();
            //if (!lineWithDigitalGoods.Any())
            //{
            //    return entitlements.AsEnumerable();
            //}

            //var hasErrors = false;
            //foreach (var line in lineWithDigitalGoods)
            //{
            //    foreach (var index in Enumerable.Range(1, (int)line.Quantity))
            //    {
            //        try
            //        {
            //            var entitlement = new DigitalProduct();
            //            var id = Guid.NewGuid().ToString("N");
            //            entitlement.Id = $"{CommerceEntity.IdPrefix<DigitalProduct>()}{id}";
            //            entitlement.FriendlyId = id;
            //            entitlement.SetComponent(
            //                new ListMembershipsComponent
            //                    {
            //                        Memberships =
            //                            new List<string>
            //                                {
            //                                    $"{CommerceEntity.ListName<DigitalProduct>()}",
            //                                    $"{CommerceEntity.ListName<Entitlement>()}"
            //                                }
            //                    });
            //            entitlement.Order = new EntityReference(order.Id, order.Name);
            //            if (customer != null)
            //            {
            //                entitlement.Customer = new EntityReference(customer.Id, customer.Name);
            //            }

            //            await this._persistEntityPipeline.Run(new PersistEntityArgument(entitlement), context);
            //            entitlements.Add(entitlement);
            //            context.Logger.LogInformation(
            //                $"DigitalProduct Entitlement Created - Order={order.Id}, LineId={line.Id}, EntitlementId={entitlement.Id}");
            //        }
            //        catch
            //        {
            //            hasErrors = true;
            //            context.Logger.LogError(
            //                $"DigitalProduct Entitlement NOT Created - Order={order.Id}, LineId={line.Id}");
            //            break;
            //        }
            //    }

            //    if (hasErrors)
            //    {
            //        break;
            //    }
            //}

            //if (!hasErrors)
            //{
            //    return entitlements.AsEnumerable();
            //}

            //context.Abort(
            //    await context.CommerceContext.AddMessage(
            //        context.GetPolicy<KnownResultCodes>().Error,
            //        "ProvisioningEntitlementErrors",
            //        new object[] { order.Id },
            //        $"Error(s) occurred provisioning entitlements for order '{order.Id}'"),
            //    context);
            //return null;
        }
    }
}
