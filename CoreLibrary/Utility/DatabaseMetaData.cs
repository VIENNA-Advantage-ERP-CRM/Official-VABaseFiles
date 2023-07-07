/********************************************************
 * Module/Class Name    : Database Metadata
 * Purpose              : Fetches the database table and columns
 * Chronological Development
 * Jagmohan Bhatt   3-Sep-2009
 ******************************************************/
using System;
using System.Data;
using System.Data.OleDb;
using VAdvantage.DataBase;
using System.Collections.Generic;
using System.Collections;
using System.Data.Common;
using Npgsql;
using CoreLibrary.DataBase;

namespace VAdvantage.Utility
{
/// <summary>
/// Summary description for DatabaseMetaData.
/// </summary>
    public class DatabaseMetaData : IDisposable
    {
        /// <summary>
        /// The Connection Object
        /// </summary>
        //OleDbConnection connection_1;
        DbConnection connection_;

        // Field descriptor #8 I
        public static int importedKeyCascade = 0;

        // Field descriptor #8 I
        public static int importedKeyRestrict = 1;

        // Field descriptor #8 I
        public static int importedKeySetNull = 2;

        public static int importedKeyNoAction = 3;

        /// <summary>
        /// Default No-Argument constructor that
        /// Creates a connection to the database
        /// </summary>
        public DatabaseMetaData()
        {

            //DbProviderFactory dbProviderFactory = null;
            //string CONNECTION_STRING = DB.GetConnectionString();

            //if (DatabaseType.IsOracle)
            //{
            //    dbProviderFactory = DbProviderFactories.GetFactory("System.Data.OracleClient");
            //}
            //else if (DatabaseType.IsPostgre)
            //{
            //    dbProviderFactory = DbProviderFactories.GetFactory("Npgsql");
            //}
            try
            {
               
                //connection_ = dbProviderFactory.CreateConnection();
               // connection_.ConnectionString = DB.GetConnectionString();
                connection_ =(DbConnection)DB.GetConnection();
               
                
            }
            catch
            {
            }
        }

        /// <summary>
        /// Closes the Connection to the Database
        /// </summary>
        public void Dispose()
        {
            if(this.connection_.State == ConnectionState.Open)
            this.connection_.Close();
        }

        /// <summary>
        /// Retrieves Database Metadata information about Tables
        /// of the specific database exposed to this user
        /// </summary>
        public DataSet GetTables()
        {
            DataSet ds = new DataSet();
            //DataTable tables = this.connection_1.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            //DataTable tables = this.connection_.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            this.connection_.Open();
            DataTable tables1 = this.connection_.GetSchema("Tables", null);
            this.connection_.Close();
            ds.Tables.Add(tables1);
            return ds;
        }

        /// <summary>
        /// Retrieves Database Metadata information about Columns
        /// of the specific database exposed to this user
        /// </summary>
        public DataSet GetIndexInfo(string catalog, string schema, string indexName)
        {
            DataSet ds = null;
            try
            {

                ds = new DataSet();
                //DataTable tables1 = this.connection_1.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, schema, "VIENNA_2", null });
                DataTable tables = null;
                connection_.Open();
                if (DatabaseType.IsPostgre)
                    tables = this.connection_.GetSchema("IndexColumns", new string[] { schema, VConnection.Get().Db_searchPath,null,indexName.ToLower()});
                else
                    tables = this.connection_.GetSchema("IndexColumns", new string[] { null, indexName.ToUpper(), schema });
                connection_.Close();
                ds.Tables.Add(tables);
            }
            catch
            {

            }
            return ds;
        }

        public DataSet GetTableIndex(string catalog, string schema, string tableName)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                //DataTable tables1 = this.connection_1.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, schema, "VIENNA_2", null });
                DataTable tables = null;
                connection_.Open();
                if (DatabaseType.IsPostgre)
                    tables = this.connection_.GetSchema("Indexes", new string[] { schema, VConnection.Get().Db_searchPath, tableName.ToLower(), null });
                else
                    tables = this.connection_.GetSchema("Indexes", new string[] { schema, null, null, tableName.ToUpper() });
                connection_.Close();
                ds.Tables.Add(tables);
            }
            catch
            {
            }
            return ds;
        }

        public DataSet GetIndexColumns(string catalog, string schema, string tableName)
        {
            DataSet ds = null;
            try
            {
                ds = new DataSet();
                //DataTable tables1 = this.connection_1.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, schema, "VIENNA_2", null });
                DataTable tables = null;
                connection_.Open();
                if (DatabaseType.IsPostgre)
                    tables = this.connection_.GetSchema("IndexColumns", new string[] { schema, VConnection.Get().Db_searchPath, tableName.ToLower(), null });
                else
                    tables = this.connection_.GetSchema("IndexColumns", new string[] { schema,null,null, tableName.ToUpper()  });
                connection_.Close();
                ds.Tables.Add(tables);
            }
            catch
            {
            }
            return ds;
        }

        public DataSet GetTableIndexColumns(string catalog, string schema, string tableName)
        {
            DataSet ds = null;
            DataTable dt = new DataTable();
            dt.Columns.Add("INDEX_NAME");
            dt.Columns.Add("NON_UNIQUE",typeof(bool));
            dt.Columns.Add("COLUMN_NAME");
            dt.Columns.Add("ORDINAL_POSITION");
            dt.Columns.Add("ASC_OR_DESC");

            if (DB.IsOracle())
            {
                try
                {
                    DataSet rs = GetTableIndex(catalog, schema, tableName);
                    foreach (DataRow dr in rs.Tables[0].Rows)
                    {
                        String dbIndexName = dr["INDEX_NAME"].ToString();
                        if (dbIndexName == null)
                            continue;
                        DataSet dsCol = GetIndexInfo(catalog, schema, dbIndexName);
                        foreach (DataRow drCol in dsCol.Tables[0].Rows)
                        {

                            DataRow newRow = dt.NewRow();
                            newRow[0] = dbIndexName;
                            newRow[1] = dr["UNIQUENESS"].ToString() != "UNIQUE";
                            newRow[2] = drCol["COLUMN_NAME"];
                            newRow[3] = drCol["COLUMN_POSITION"];
                            newRow[4] = drCol["DESCEND"];
                            dt.Rows.Add(newRow);
                        }
                    }
                    ds = new DataSet();
                    ds.Tables.Add(dt);
                }
                catch
                {
                }
            }

            else if (DB.IsPostgreSQL())
            {
                string qry = @"SELECT     tnsp.nspname                           AS schema_name, 
           trel.relname AS table_name, 
           irel.relname AS index_name, 
           i.indisunique as IsUniquer_Idx ,
           a.attname AS column_name, 
           1 + Array_position(i.indkey, a.attnum) AS column_position,
           CASE o.OPTION
                                 & 1
                      WHEN 1 THEN 'DESC'
                      ELSE 'ASC'
           END AS order
FROM       pg_index AS i
join       pg_class AS trel
ON         trel.oid = i.indrelid
join pg_namespace AS tnsp
ON trel.relnamespace = tnsp.oid
join pg_class AS irel
ON irel.oid = i.indexrelid
cross join lateral unnest(i.indkey) WITH ordinality    AS c(colnum, ordinality)
left join  lateral unnest(i.indoption) WITH ordinality AS o(OPTION, ordinality)
ON c.ordinality = o.ordinality
join pg_attribute AS a
ON trel.oid = a.attrelid
AND a.attnum = c.colnum
where
  tnsp.nspname = '"+ VConnection.Get().Db_searchPath + @"'
and trel.relname = '" + tableName.ToLower() +@"'
GROUP BY   tnsp.nspname, 
           trel.relname, 
           irel.relname, 
           a.attname, 
           IsUniquer_Idx,
           array_position(i.indkey, a.attnum), 
           o.OPTION
  order by table_name, index_name, column_position";

                DataSet dsIndex = DB.ExecuteDataset(qry);

                foreach (DataRow dr in dsIndex.Tables[0].Rows)
                {
                    String dbIndexName = dr["index_name"].ToString();
                    if (dbIndexName == null)
                        continue;

                    DataRow newRow = dt.NewRow();
                    newRow[0] = dbIndexName;
                    newRow[1] = !Util.GetValueOfBool(dr["IsUniquer_Idx"]);
                    newRow[2] = dr["column_name"];
                    newRow[3] = dr["column_position"];
                    newRow[4] = dr["order"];
                    dt.Rows.Add(newRow);
                }

                ds = new DataSet();
                ds.Tables.Add(dt);
            }
            return ds;
        }

        /// <summary>
        /// Retrieves Database Metadata information about Columns
        /// of the specific database exposed to this user
        /// </summary>
        public DataSet GetColumns(string catalog, string schema, string tableName)
        {
            DataSet ds = null;
            try
            {

                ds = new DataSet();
                //DataTable tables1 = this.connection_1.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, schema, "VIENNA_2", null });
                DataTable tables = null;
                connection_.Open();
                if (DatabaseType.IsPostgre)
                    tables = this.connection_.GetSchema("Columns", new string[] {schema, VConnection.Get().Db_searchPath,tableName.ToLower(), null });
                else if(DatabaseType.IsOracle)
                    tables = this.connection_.GetSchema("Columns", new string[] { schema, tableName.ToUpper() });
                connection_.Close();
                ds.Tables.Add(tables);
            }
            catch
            {

            }
            return ds;
        }

        /// <summary>
        /// Retrieves Database Metadata information about Foreign Keys
        /// of the specific database exposed to this user
        /// </summary>
        public DataSet GetForeignKeys(string catalog, string schema, string tableName)
        {
            DataSet ds = null;
            try
            {

                ds = new DataSet();
                //DataTable tables1 = this.connection_1.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, schema, "VIENNA_2", null });
                DataTable tables = null;
                connection_.Open();
                if (DatabaseType.IsPostgre)
                    tables = this.connection_.GetSchema("ForeignKeys", new string[] { schema, VConnection.Get().Db_searchPath, tableName.ToLower(), null });
                else if (DatabaseType.IsOracle)
                    tables = this.connection_.GetSchema("ForeignKeys", new string[] { schema, tableName.ToUpper() });
                connection_.Close();
                ds.Tables.Add(tables);
            }
            catch
            {

            }
            return ds;
        }

        public  Dictionary<string,string> GetForeignColumnDetail(DataRow dr)
        {
            Dictionary<string, string> retValue = new Dictionary<string, string>();
            
            if(DatabaseType.IsOracle)
            {
                retValue["FK_Column_Name"] = DB.ExecuteScalar("SELECT column_name FROM user_cons_columns WHERE constraint_name='" + dr["FOREIGN_KEY_CONSTRAINT_NAME"].ToString() + "'").ToString();
                retValue["PK_Table_Name"] = dr["PRIMARY_KEY_TABLE_NAME"].ToString();
                retValue["PK_Column_Name"] = DB.ExecuteScalar("SELECT column_name FROM user_cons_columns WHERE constraint_name='" + dr["PRIMARY_KEY_CONSTRAINT_NAME"].ToString() + "'").ToString();
                retValue["Delete_Rule"] = dr["DELETE_RULE"].ToString();
                retValue["ConstraintNameDB"] = dr["FOREIGN_KEY_CONSTRAINT_NAME"].ToString();
            }
            else if(DatabaseType.IsPostgre)
            {
                DataSet ds = DB.ExecuteDataset("SELECT tc.table_name FK_Table_Name,kcu.column_name FK_Column_Name,rc.delete_rule,ccu.table_name PK_Table_Name," +
                                               "ccu.column_name PK_Column_Name FROM information_schema.table_constraints tc LEFT JOIN information_schema.key_column_usage kcu" +
                                               " ON tc.constraint_name = kcu.constraint_name LEFT JOIN information_schema.referential_constraints rc ON tc.constraint_name = rc.constraint_name"+
                                               " LEFT JOIN information_schema.constraint_column_usage ccu ON rc.unique_constraint_name = ccu.constraint_name "+
                                               " WHERE tc.constraint_name = '"+dr["CONSTRAINT_NAME"]+"'");

                retValue["FK_Column_Name"] = ds.Tables[0].Rows[0]["FK_Column_Name"].ToString();
                retValue["PK_Table_Name"] = ds.Tables[0].Rows[0]["PK_Table_Name"].ToString();
                retValue["PK_Column_Name"] = ds.Tables[0].Rows[0]["PK_Column_Name"].ToString();
                retValue["Delete_Rule"] = ds.Tables[0].Rows[0]["Delete_Rule"].ToString();
                retValue["ConstraintNameDB"] = dr["CONSTRAINT_NAME"].ToString();
            }
            return retValue;
        }

        public int GetConstraintTypeDB(string type)
        {
            type = type.ToUpper();
            if (type == "CASCADE")
            {
                return importedKeyCascade;
            }
            else if (type == "RESTRICT")
            {
                return importedKeyRestrict;
            }
            else if (type == "SET NULL")
            {
                return importedKeySetNull;
            }
            return importedKeyNoAction;
        }
    }

    public class Types
    {

        public const string DATE = "DATE";
        public const string TIME = "TIME";
        public const string TIMESTAMP = "TIMESTAMP";
        public const string NUMBER = "NUMBER";
        public const string INTEGER = "INTEGER";
        public const string NUMERIC = "NUMERIC";

        public const string BLOB = "BLOB";
        public const string CLOB = "CLOB";

        public const string CHAR = "CHAR";
        public const string VARCHAR = "NVARCHAR"; 
        public const string DECIMAL = "NUMBER";
        public const string SMALLINT = "NUMBER";

    }
}