using Sitecore.Commerce.Core;
using Sitecore.Commerce.Core.Exceptions;
using System;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Sitecore.Commerce.Plugin.Inventory.Cs;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class ConnectionHelperExtension : Sitecore.Commerce.Plugin.Inventory.Cs.ConnectionHelper
    {
        public new static InventoryCatalogSqlPolicy GetInventorySqlConnectionPolicy(CommerceContext context)
        {
            if (!context.Environment.HasPolicy<InventoryCatalogSqlPolicy>())
                throw new Exception("GetInventorySqlConnectionPolicy a InventoryCatalogSqlPolicy to be returned for SQL Connection");
            return context.Environment.GetPolicy<InventoryCatalogSqlPolicy>();
        }

        public new static InventoryCatalogSqlContextExtension GetInventorySqlContext(CommerceContext context)
        {
            return new InventoryCatalogSqlContextExtension(ConnectionHelper.GetInventorySqlConnectionPolicy(context).ConnectionString(context));
        }

        public new static InventoryCatalogSqlContextExtension GetReadOnlyInventorySqlContext(CommerceContext context)
        {
            return new InventoryCatalogSqlContextExtension(ConnectionHelper.GetInventorySqlConnectionPolicy(context).ReadOnlyConnectionString(context));
        }

        public new static void EvaluateSqlException(SqlException ex, string message)
        {
            switch (ex.Number)
            {
                case 1205:
                    throw new EntityPersistException(message, (Exception)ex);
                case 2627:
                    throw new EntityDuplicateException(message, (Exception)ex);
                case 4060:
                    throw new EntityStoreConnectException(message, (Exception)ex);
                case -2:
                    throw new EntityStoreTimeoutException(message, (Exception)ex);
                case 1105:
                    throw new EntityStoreFullException(message, (Exception)ex);
                default:
                    throw new EntityPersistException(message, (Exception)ex);
            }
        }
    }
}
