using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sitecore.Commerce.Plugin.Inventory.Cs;
using Sitecore.Commerce.Plugin.Inventory;
using System.Data.SqlClient;
using System.Data;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Blocks
{
    public class InventoryCatalogSqlContextExtension : Sitecore.Commerce.Plugin.Inventory.Cs.InventoryCatalogSqlContext
    {
        public string ConnectionString { get; set; }

        public InventoryCatalogSqlContextExtension(string connectionString) : base (connectionString)
        {
            this.ConnectionString = connectionString;
        }

        internal async Task<InventoryCatalog> GetAssociatedInventoryCatalog(string productCatalogName)
        {
            InventoryCatalog inventoryCatalog;
            using (SqlConnection sqlConnection = new SqlConnection(this.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                SqlCommand command = sqlConnection.CreateCommand();
                string str = "inv_GetAssociatedInventoryCatalogProperties";
                command.CommandText = str;
                int num1 = 4;
                command.CommandType = (CommandType)num1;
                SqlParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@ProductCatalogName";
                parameter.DbType = DbType.String;
                parameter.Value = (object)productCatalogName;
                command.Parameters.Add(parameter);
                int num2 = 32;
                SqlDataReader reader = await command.ExecuteReaderAsync((CommandBehavior)num2);
                int num3 = await reader.ReadAsync() ? 1 : 0;
                InventoryCatalog result = new InventoryCatalog()
                {
                    Name = reader.GetString(0)
                };
                InventoryCatalog associatedProductCatalogs = await this.GetAssociatedProductCatalogs(result);
                inventoryCatalog = result;
            }
            return inventoryCatalog;
        }

        internal async Task<InventoryCatalog> GetAssociatedProductCatalogs(InventoryCatalog inventoryCatalog)
        {
            InventoryCatalog inventoryCatalog1;
            using (SqlConnection sqlConnection = new SqlConnection(this.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                SqlCommand command = sqlConnection.CreateCommand();
                string str = "inv_GetAssociatedProductCatalogs";
                command.CommandText = str;
                int num1 = 4;
                command.CommandType = (CommandType)num1;
                SqlParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@InventoryCatalogName";
                parameter.DbType = DbType.String;
                parameter.Value = (object)inventoryCatalog.Name;
                command.Parameters.Add(parameter);
                int num2 = 32;
                SqlDataReader reader = await command.ExecuteReaderAsync((CommandBehavior)num2);
                while (true)
                {
                    if (await reader.ReadAsync())
                        inventoryCatalog.AssociatedProductCatalogs.Add(reader.GetString(0));
                    else
                        break;
                }
                inventoryCatalog1 = inventoryCatalog;
            }
            return inventoryCatalog1;
        }

        internal async Task<InventorySku> GetSku(string inventoryCatalogName, string productCatalogName, string productId, string variantId)
        {
            InventorySku inventorySku1;
            using (SqlConnection sqlConnection = new SqlConnection(this.ConnectionString))
            {
                await sqlConnection.OpenAsync();
                SqlCommand command = sqlConnection.CreateCommand();
                string str = "inv_GetInventorySkus";
                command.CommandText = str;
                int num1 = 4;
                command.CommandType = (CommandType)num1;
                SqlParameter parameter1 = command.CreateParameter();
                parameter1.ParameterName = "@InventoryCatalogName";
                parameter1.DbType = DbType.String;
                parameter1.Value = (object)inventoryCatalogName;
                command.Parameters.Add(parameter1);
                SqlParameter parameter2 = command.CreateParameter();
                parameter2.ParameterName = "@NumRecords";
                parameter2.DbType = DbType.Int32;
                parameter2.Value = (object)1000;
                command.Parameters.Add(parameter2);
                SqlParameter parameter3 = command.CreateParameter();
                parameter3.ParameterName = "@OrderBy";
                parameter3.DbType = DbType.String;
                parameter3.Value = (object)"SkuId";
                command.Parameters.Add(parameter3);
                SqlParameter parameter4 = command.CreateParameter();
                parameter4.ParameterName = "@PropertiesToReturn";
                parameter4.DbType = DbType.String;
                parameter4.Value = (object)"*,dbo.inv_func_GetPreorderedQuantity(Preorderable,OnHandQuantity,PreorderLimit,StockOutThreshold,0) as PreorderedQuantity,dbo.inv_func_GetPreorderedQuantity(Backorderable,OnHandQuantity,BackorderLimit,StockOutThreshold,0) as BackorderedQuantity";
                command.Parameters.Add(parameter4);
                SqlParameter parameter5 = command.CreateParameter();
                parameter5.ParameterName = "@SearchCondition";
                parameter5.DbType = DbType.String;
                parameter5.Value = string.IsNullOrEmpty(variantId) ? (object)string.Format("ProductCatalogName =\"{0}\" AND SkuId = \"{1}\"", (object)productCatalogName, (object)productId) : (object)string.Format("ProductCatalogName =\"{0}\" AND SkuId = \"{1}\" AND SkuVariantId = \"{2}\"", (object)productCatalogName, (object)productId, (object)variantId);
                command.Parameters.Add(parameter5);
                SqlParameter parameter6 = command.CreateParameter();
                parameter6.ParameterName = "@SortAscending";
                parameter6.DbType = DbType.Boolean;
                parameter6.Value = (object)true;
                command.Parameters.Add(parameter6);
                SqlParameter parameter7 = command.CreateParameter();
                parameter7.ParameterName = "@StartingRecord";
                parameter7.DbType = DbType.Int16;
                parameter7.Value = (object)1;
                command.Parameters.Add(parameter7);
                int num2 = 32;
                SqlDataReader reader = await command.ExecuteReaderAsync((CommandBehavior)num2);
                int num3 = await reader.ReadAsync() ? 1 : 0;
                InventorySku inventorySku2 = (InventorySku)null;
                if (reader.HasRows)
                    inventorySku2 = InventoryCatalogSqlContextExtension.LoadCommerceInventorySku((IDataRecord)reader);
                reader.Close();
                inventorySku1 = inventorySku2;
            }
            return inventorySku1;
        }

        internal async Task UpdateInventorySkuQuantity(InventorySku productSku)
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            try
            {
                await connection.OpenAsync();
                SqlCommand command = connection.CreateCommand();
                string str = "inv_UpdateInventorySkus";
                command.CommandText = str;
                int num = 4;
                command.CommandType = (CommandType)num;
                SqlParameter parameter1 = command.CreateParameter();
                parameter1.ParameterName = "@InventoryCatalogName";
                parameter1.DbType = DbType.String;
                parameter1.Value = (object)productSku.InventoryCatalogName;
                command.Parameters.Add(parameter1);
                SqlParameter parameter2 = command.CreateParameter();
                parameter2.ParameterName = "@updateclauses";
                parameter2.DbType = DbType.String;
                parameter2.Value = (object)string.Format("OnHandQuantity = {0}", (object)productSku.Quantity);
                command.Parameters.Add(parameter2);
                SqlParameter parameter3 = command.CreateParameter();
                parameter3.ParameterName = "@expression";
                parameter3.DbType = DbType.String;
                parameter3.Value = (object)string.Format("SkuId = '{0}' AND SkuVariantId = '{1}'", (object)productSku.ProductId, (object)productSku.VariantId);
                command.Parameters.Add(parameter3);
                object obj = await command.ExecuteScalarAsync();
            }
            finally
            {
                if (connection != null)
                    connection.Dispose();
            }
            connection = (SqlConnection)null;
        }

        private static InventorySku LoadCommerceInventorySku(IDataRecord reader)
        {
            InventorySku inventorySku = new InventorySku();
            inventorySku.InventoryCatalogName = reader["InventoryCatalogName"].ToString();
            inventorySku.ProductCatalogName = reader["ProductCatalogName"].ToString();
            inventorySku.ProductId = reader["SkuId"].ToString();
            inventorySku.VariantId = reader["SkuVariantId"].ToString();
            int num1 = string.IsNullOrEmpty(reader["Backorderable"].ToString()) ? 0 : (bool.Parse(reader["Backorderable"].ToString()) ? 1 : 0);
            inventorySku.Backorderable = num1 != 0;
            int num2 = string.IsNullOrEmpty(reader["Preorderable"].ToString()) ? 0 : (bool.Parse(reader["Preorderable"].ToString()) ? 1 : 0);
            inventorySku.Preorderable = num2 != 0;
            int num3 = string.IsNullOrEmpty(reader["Status"].ToString()) ? 2 : (int)Enum.Parse(typeof(StockStatus), reader["Status"].ToString());
            inventorySku.Status = (StockStatus)num3;
            Decimal num4 = (Decimal)(string.IsNullOrEmpty(reader["OnHandQuantity"].ToString()) ? 0 : int.Parse(reader["OnHandQuantity"].ToString()));
            inventorySku.Quantity = num4;
            Decimal num5 = (Decimal)(string.IsNullOrEmpty(reader["ExcessOnHandQuantity"].ToString()) ? 0 : int.Parse(reader["ExcessOnHandQuantity"].ToString()));
            inventorySku.ExcessOnHandQuantity = num5;
            Decimal num6 = (Decimal)(string.IsNullOrEmpty(reader["ReorderPoint"].ToString()) ? 0 : int.Parse(reader["ReorderPoint"].ToString()));
            inventorySku.ReorderPoint = num6;
            Decimal num7 = (Decimal)(string.IsNullOrEmpty(reader["TargetQuantity"].ToString()) ? 0 : int.Parse(reader["TargetQuantity"].ToString()));
            inventorySku.TargetQuantity = num7;
            Decimal num8 = (Decimal)(string.IsNullOrEmpty(reader["BackorderLimit"].ToString()) ? 0 : int.Parse(reader["BackorderLimit"].ToString()));
            inventorySku.BackorderLimit = num8;
            Decimal num9 = (Decimal)(string.IsNullOrEmpty(reader["PreorderLimit"].ToString()) ? 0 : int.Parse(reader["PreorderLimit"].ToString()));
            inventorySku.PreorderLimit = num9;
            Decimal num10 = (Decimal)(string.IsNullOrEmpty(reader["StockOutThreshold"].ToString()) ? 0 : int.Parse(reader["StockOutThreshold"].ToString()));
            inventorySku.StockOutThreshold = num10;
            DateTimeOffset fromDateTimeString1 = InventoryCatalogSqlContextExtension.GetDateTimeOffsetFromDateTimeString(reader["PreorderAvailabilityDate"].ToString());
            inventorySku.PreorderAvailabilityDate = fromDateTimeString1;
            DateTimeOffset fromDateTimeString2 = InventoryCatalogSqlContextExtension.GetDateTimeOffsetFromDateTimeString(reader["BackorderAvailabilityDate"].ToString());
            inventorySku.BackorderAvailabilityDate = fromDateTimeString2;
            DateTimeOffset fromDateTimeString3 = InventoryCatalogSqlContextExtension.GetDateTimeOffsetFromDateTimeString(reader["LastRestocked"].ToString());
            inventorySku.LastRestocked = fromDateTimeString3;
            DateTimeOffset fromDateTimeString4 = InventoryCatalogSqlContextExtension.GetDateTimeOffsetFromDateTimeString(reader["SkuLastModified"].ToString());
            inventorySku.LastModified = fromDateTimeString4;
            Decimal num11 = string.IsNullOrEmpty(reader["BackorderedQuantity"].ToString()) ? Decimal.Zero : Decimal.Parse(reader["BackorderedQuantity"].ToString());
            inventorySku.BackorderedQuantity = num11;
            Decimal num12 = string.IsNullOrEmpty(reader["PreorderedQuantity"].ToString()) ? Decimal.Zero : Decimal.Parse(reader["PreorderedQuantity"].ToString());
            inventorySku.PreorderedQuantity = num12;
            string str1 = reader["UnitOfMeasure"].ToString();
            inventorySku.UnitOfMeasure = str1;
            string str2 = reader["Memo"].ToString();
            inventorySku.Memo = str2;
            return inventorySku;
        }

        private static DateTimeOffset GetDateTimeOffsetFromDateTimeString(string dateTimeInUtc)
        {
            DateTimeOffset minValue = DateTimeOffset.MinValue;
            if (string.IsNullOrEmpty(dateTimeInUtc))
                return minValue;
            return (DateTimeOffset)DateTime.SpecifyKind(DateTime.Parse(dateTimeInUtc), DateTimeKind.Utc);
        }
    }
}
