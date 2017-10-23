using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Entitlements;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Entities
{
    public class SpendLimitEntitlement : Entitlement
    {
        public Money OriginalAmount { get; set; }

        public Money Balance { get; set; }
    }
}