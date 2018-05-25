extern alias FoundationServiceProxy;

using Sitecore.Commerce.Engine;
using Microsoft.OData.Client;
using Sitecore.Analytics;
using Sitecore.Commerce.Engine.Connect;
using Sitecore.Commerce.Multishop;
using Sitecore.Configuration;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Security.Accounts;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Sitecore.Commerce.Services;
using FoundationServiceProxy::Sitecore.Commerce.Core;
using Sitecore.ContentSearch.Utilities;
using FoundationServiceProxy::CommerceOps.Sitecore.Commerce.Engine;

namespace Sitecore.Foundation.Commerce.Website.Util
{
    public static class ServiceProviderResultExtensions
    {
        private static SystemMessage CreateSystemMessage(string message)
        {
            return new SystemMessage() { Message = message };
        }
        public static void HandleCommandMessages(this ServiceProviderResult result, FoundationServiceProxy.Sitecore.Commerce.Core.Commands.CommerceCommand command)
        {
            if (command == null)
                return;
            if (command.ResponseCode.Equals("error", StringComparison.OrdinalIgnoreCase))
                result.Success = false;
            command.Messages.Where<CommandMessage>((Func<CommandMessage, bool>)(m =>
            {
                if (!m.Code.Equals("error", StringComparison.OrdinalIgnoreCase))
                    return m.Code.Equals("validationerror", StringComparison.OrdinalIgnoreCase);
                return true;
            })).ForEach<CommandMessage>((Action<CommandMessage>)(m => result.SystemMessages.Add(CreateSystemMessage(m.Text))));
        }
    }

    public static class EngineConnectUtilityExtension
    {
        private static readonly ConcurrentDictionary<string, string> EnvironmentCache = new ConcurrentDictionary<string, string>();
        private static readonly ConcurrentDictionary<string, string> CurrencyCache = new ConcurrentDictionary<string, string>();
        private static CommerceEngineConfiguration _engineConfiguration;

        

        public static CultureInfo CurrentCulture
        {
            get
            {
                return Context.Culture;
            }
        }

        public static CommerceEngineConfiguration EngineConfiguration
        {
            get
            {
                return _engineConfiguration ?? (_engineConfiguration = (CommerceEngineConfiguration)Factory.CreateObject("commerceEngineConfiguration", true));
            }
        }

        public static FoundationServiceProxy::Sitecore.Commerce.Engine.Container GetShopsContainer(string environment = "", string shopName = "", string userId = "", string customerId = "", string language = "", string currency = "", DateTime? effectiveDate = null)
        {
            var container = new FoundationServiceProxy::Sitecore.Commerce.Engine.Container(new Uri(EngineConnectUtility.EngineConfiguration.ShopsServiceUrl));
            string roles = string.Empty;
            if ((Account)Context.User != (Account)null && Context.User.Roles != null && Context.User.Roles.Any<Role>())
                roles = Context.User.Roles.Aggregate<Role, string>(roles, (Func<string, Role, string>)((current, role) => current + role.Name + "|"));
            if (string.IsNullOrEmpty(shopName))
                shopName = EngineConnectUtility.EngineConfiguration.DefaultShopName;
            if (string.IsNullOrEmpty(userId))
                userId = Tracker.Current == null || Tracker.Current.Contact == null || !(Tracker.Current.Contact.ContactId != Guid.Empty) ? string.Empty : Tracker.Current.Contact.ContactId.ToString();
            EventHandler<BuildingRequestEventArgs> eventHandler = (EventHandler<BuildingRequestEventArgs>)((s, e) =>
            {
                e.Headers.Add("ShopName", shopName);
                e.Headers.Add("Environment", string.IsNullOrEmpty(environment) ? EngineConnectUtility.GetShopEnvironment() : environment);
                if (effectiveDate.HasValue)
                {
                    DateTimeOffset dateTimeOffset = (DateTimeOffset)effectiveDate.Value;
                    e.Headers.Add("EffectiveDate", dateTimeOffset.ToString((IFormatProvider)CultureInfo.InvariantCulture));
                }
                if (!string.IsNullOrEmpty(userId))
                    e.Headers.Add("ShopperId", userId);
                if (!string.IsNullOrEmpty(customerId))
                    e.Headers.Add("CustomerId", customerId);
                string str1 = string.IsNullOrEmpty(language) ? EngineConnectUtility.CurrentCulture.Name : language;
                if (!string.IsNullOrEmpty(str1))
                    e.Headers.Add("Language", str1);
                string str2 = string.IsNullOrEmpty(currency) ? EngineConnectUtility.GetShopDefaultCurrency() : currency;
                if (!string.IsNullOrEmpty(str2))
                    e.Headers.Add("Currency", str2);
                if (!string.IsNullOrEmpty(roles))
                    e.Headers.Add("Roles", roles);
                if ((Account)Context.User != (Account)null)
                    e.Headers.Add("IsRegistered", Context.User.IsAuthenticated.ToString());
                if (!EngineConnectUtility.EngineConfiguration.CertificateValidationEnabled)
                    return;
                string certificate = EngineConnectUtility.EngineConfiguration.GetCertificate();
                if (certificate == null)
                    return;
                e.Headers.Add("X-ARR-ClientCert", certificate);
            });
            container.BuildingRequest += eventHandler;
            return container;
        }

        public static string GetShopEnvironment()
        {
            if (Context.Site == null || string.IsNullOrEmpty(Context.Site.Name) || EngineConnectUtility.EngineConfiguration.IsTesting)
                return EngineConnectUtility.EngineConfiguration.DefaultEnvironment;
            string name = Context.Site.Name;
            lock (EnvironmentCache)
            {
                string local_3;
                if (EnvironmentCache.TryGetValue(name, out local_3))
                    return local_3;
                local_3 = EngineConnectUtility.EngineConfiguration.DefaultEnvironment;
                try
                {
                    Item local_5 = ConnectStorefrontContext.Current.StorefrontConfiguration;
                    if (local_5 != null && !string.IsNullOrEmpty(local_5[EngineConnectConstants.KnownFieldNames.Environment]))
                        local_3 = local_5[EngineConnectConstants.KnownFieldNames.Environment];
                    EnvironmentCache.GetOrAdd(name, local_3);
                    return local_3;
                }
                catch
                {
                    return local_3;
                }
            }
        }

        public static string GetShopDefaultCurrency()
        {
            if (Context.Site == null || string.IsNullOrEmpty(Context.Site.Name) || EngineConnectUtility.EngineConfiguration.IsTesting)
                return EngineConnectUtility.EngineConfiguration.DefaultShopCurrency;
            string name = Context.Site.Name;
            lock (CurrencyCache)
            {
                string local_3;
                if (CurrencyCache.TryGetValue(name, out local_3))
                    return local_3;
                local_3 = EngineConnectUtility.EngineConfiguration.DefaultShopCurrency;
                try
                {
                    Item local_5 = ConnectStorefrontContext.Current.StorefrontConfiguration;
                    if (local_5 == null)
                        return local_3;
                    Item local_6 = local_5.Axes.GetChild(EngineConnectConstants.KnownFieldNames.CurrencyConfiguration);
                    if (local_6 != null)
                    {
                        string local_7 = local_6[Sitecore.Commerce.Constants.Templates.CurrencyConfiguration.Fields.CurrencySet];
                        if (local_7 != null)
                        {
                            Item local_8 = Context.Database.GetItem(ID.Parse(local_7));
                            if (local_8 != null)
                                local_3 = local_8[Sitecore.Commerce.Constants.Templates.CurrencySet.Fields.DefaultCurrency];
                        }
                    }
                    CurrencyCache.GetOrAdd(name, local_3);
                    return local_3;
                }
                catch
                {
                    return local_3;
                }
            }
        }
    }
}