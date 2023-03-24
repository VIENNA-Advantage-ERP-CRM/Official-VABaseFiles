/********************************************************
 * Module Name    :     General DB Custom Message
 * Purpose        :     Modify DB Exception Message
 * Author         :     Mandeep Singh
 * Date           :     07-March-2023
  ******************************************************/
using Npgsql;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.Common;
using System.Text.RegularExpressions;
using VAdvantage.DataBase;
using VAdvantage.Utility;

namespace CoreLibrary.DataBase
{
    public class DBCustomMessage
    {
        /// <summary>
        /// Modify Exception Message
        /// </summary>
        /// <param name="exp"></param>
        /// <returns></returns>
        public static Exception ModifyMessage(DbException exp)
        {
            if (DatabaseType.IsOracle)
            {
                OracleException ex = exp as OracleException; // Cast the exception object to OracleException
                
                int errorCode = ex.Number; // get the Oracle error code
                string message = ex.Message;
                string indexName = null;
                if (errorCode == 1)
                {
                    string pattern = @"\((.*?)\)"; // Define a regular expression pattern to match the index name
                    Match match = Regex.Match(message, pattern);
                    if (match.Success)
                    {
                        // Extract the index name from the matched group and split it to get the actual index name (if it exists)
                        indexName = match.Groups[1].Value.Split('.').Length > 0 ? match.Groups[1].Value.Split('.')[1] : null;
                        if (indexName != null)
                        {
                            string qry = @"SELECT a.column_name FROM user_ind_columns a, user_indexes b WHERE a.index_name=b.index_name AND a.index_name = upper('" + indexName + @"')
                                    ORDER BY a.table_name, a.index_name, a.column_position";
                            DataSet DS  = DB.ExecuteDataset(qry);

                            string msg = GetColumnNames(DS);

                            if (msg!="")
                            {                               
                                return new Exception(msg, ex);
                            }
                        }
                    }
                }
                return ex;
            }
            else
            {
                PostgresException ex = exp as PostgresException;
                // Check if the exception is a unique constraint violation
                if (ex.SqlState == "23505")
                {
                    string qry = @"SELECT C.ColumnName as column_name FROM AD_TableIndex  TI INNER JOIN AD_IndexColumn  IC
                                    ON TI.AD_TableIndex_ID=IC.AD_TableIndex_ID
                                    INNER JOIN AD_Column C ON C.AD_Column_ID=IC.AD_Column_ID
                                    WHERE UPPER(TI.Name)=upper('" + ex.ConstraintName + "')";
                    DataSet DS = DB.ExecuteDataset(qry);
                    string msg = GetColumnNames(DS);
                    if (msg != "")
                    {
                        return new Exception(msg, ex);
                    }
                }
            }
            return exp;
        }

        private static string GetColumnNames(DataSet DS)
        {
            if (DS != null && DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                string columnName = "VISDBERRORCOLUMN: "; //Unique Name for split exception message. 
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    columnName += Util.GetValueOfString(DS.Tables[0].Rows[i]["column_name"]).ToUpper();
                    if (DS.Tables[0].Rows.Count != (i + 1))
                    {
                        columnName += ",";
                    }
                }
                return columnName;
            }
            else
            {
                return "";
            }
        }
    }
}
