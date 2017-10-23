using System;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Commands;
using Sitecore.Commerce.EntityViews;
using Sitecore.Commerce.Plugin.Customers;
using Sitecore.Commerce.Plugin.Entitlements;
using Sitecore.Feature.Commerce.Entitlements.Engine.Entities;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System.Collections.Generic;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Blocks.EntityViews
{
    public class GetCustomerSpendLimitEntitlementDetailsViewBlock : PipelineBlock<EntityView, EntityView, CommercePipelineExecutionContext>
    {
        private readonly FindEntityCommand _findEntityCommand;

        public GetCustomerSpendLimitEntitlementDetailsViewBlock(FindEntityCommand findEntityCommand)
      : base((string) null)
    {
            this._findEntityCommand = findEntityCommand;
        }

        public override async Task<EntityView> Run(EntityView entityView, CommercePipelineExecutionContext context)
        {
            Condition.Requires<EntityView>(entityView).IsNotNull<EntityView>(string.Format("{0}: The argument cannot be null.", (object)this.Name));
            EntityViewArgument entityViewArgument = context.CommerceContext.Objects.OfType<EntityViewArgument>().FirstOrDefault<EntityViewArgument>();
            if (string.IsNullOrEmpty(entityViewArgument != null ? entityViewArgument.ViewName : (string)null) 
                || !entityViewArgument.ViewName.Equals(context.GetPolicy<KnownEntitlementsViewsPolicy>().CustomerEntitlements, StringComparison.OrdinalIgnoreCase) 
                && !entityViewArgument.ViewName.Equals(context.GetPolicy<KnownCustomerViewsPolicy>().Master, StringComparison.OrdinalIgnoreCase) 
                || !(entityViewArgument.Entity is Customer) 
                || !entityViewArgument.Entity.HasComponent<EntitlementsComponent>())
            {
                //if (!(entityViewArgument.Entity is Customer)
                //|| !entityViewArgument.Entity.HasComponent<EntitlementsComponent>())
                //{
                //    var ent = entityViewArgument.Entity.GetComponent<EntitlementsComponent>();
                //}
                //else
                    return entityView;

            }
            EntityView entitlementsView = entityViewArgument.ViewName.Equals(context.GetPolicy<KnownCustomerViewsPolicy>().Master, StringComparison.OrdinalIgnoreCase) ? entityView.ChildViews.Cast<EntityView>().FirstOrDefault<EntityView>((Func<EntityView, bool>)(ev => ev.Name.Equals(context.GetPolicy<KnownEntitlementsViewsPolicy>().CustomerEntitlements, StringComparison.OrdinalIgnoreCase))) : entityView;
            EntityView entityView1 = entitlementsView;
            List<EntityView> entityViewList = entityView1 != null ? entityView1.ChildViews.Where<Model>((Func<Model, bool>)(cv => cv.Name.Equals(context.GetPolicy<KnownEntitlementsViewsPolicy>().CustomerEntitlementDetails, StringComparison.OrdinalIgnoreCase))).Cast<EntityView>().ToList<EntityView>() : (List<EntityView>)null;
            if (entityViewList == null)
                return entityView;
            foreach (EntityView entityView2 in entityViewList)
            {
                EntityView entitlementView = entityView2;
                CommerceEntity commerceEntity = await this._findEntityCommand.Process(context.CommerceContext, typeof(Entitlement), entitlementView.ItemId, false);
                if (commerceEntity == null || commerceEntity.HasComponent<DeletedEntitlementComponent>())
                {
                    entitlementsView.ChildViews.Remove((Model)entitlementView);
                }
                else
                {
                    SpendLimitEntitlement giftCard = commerceEntity as SpendLimitEntitlement;
                    if (giftCard != null)
                    {
                        List<ViewProperty> properties1 = entitlementView.Properties;
                        ViewProperty viewProperty1 = new ViewProperty();
                        string str1 = "Details";
                        viewProperty1.Name = str1;
                        int num1 = 1;
                        viewProperty1.IsReadOnly = num1 != 0;
                        string str2 = string.Format("Type=SpendLimitEntitlement, OriginalAmount={0}, Balance={1}", (object)giftCard.OriginalAmount.Amount, (object)giftCard.Balance.Amount);
                        viewProperty1.RawValue = (object)str2;
                        properties1.Add(viewProperty1);
                        List<ViewProperty> properties2 = entitlementView.Properties;
                        ViewProperty viewProperty2 = new ViewProperty();
                        string str3 = "Disabled";
                        viewProperty2.Name = str3;
                        int num2 = 1;
                        viewProperty2.IsReadOnly = num2 != 0;
                        // ISSUE: variable of a boxed type
                        var local = (ValueType)giftCard.HasPolicy<DisabledPolicy>();
                        viewProperty2.RawValue = (object)local;
                        properties2.Add(viewProperty2);
                        entitlementView = (EntityView)null;
                    }
                }
            }
            List<EntityView>.Enumerator enumerator = new List<EntityView>.Enumerator();
            return entityView;
        }
    }
}
