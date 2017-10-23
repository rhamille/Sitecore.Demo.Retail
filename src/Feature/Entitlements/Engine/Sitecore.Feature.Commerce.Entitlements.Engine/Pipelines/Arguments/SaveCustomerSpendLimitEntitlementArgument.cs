using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Commerce.Plugin.Customers;
using Sitecore.Feature.Commerce.Entitlements.Engine.Entities;
using Sitecore.Framework.Conditions;
using System.Collections.Generic;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Arguments
{
    public class SaveCustomerSpendLimitEntitlementArgument : PipelineArgument
    {
        //public string ItemId { get; set; }
        //public string ExternalId { get; set; }
        //public uint Quantity { get; set; }
        //public string Type { get; set; }
        //public string Value { get; set; }


        public SpendLimitEntitlement SpendLimit { get; set; }
        public Customer Customer { get; set; }

        public SaveCustomerSpendLimitEntitlementArgument(Customer customer, SpendLimitEntitlement spendLimit)
            : base()
        {
            //this.ItemId = itemId;
            //this.ExternalId = externalId;
            //this.Quantity = quantity;
            //this.Type = type;
            //this.Value = value;
            this.Customer = customer;
            this.SpendLimit = spendLimit;
        }
    }
}