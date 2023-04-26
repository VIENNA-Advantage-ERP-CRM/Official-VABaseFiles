namespace VAdvantage.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for M_RevaluationAcctSchema
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_M_RevaluationAcctSchema : PO{public X_M_RevaluationAcctSchema (Context ctx, int M_RevaluationAcctSchema_ID, Trx trxName) : base (ctx, M_RevaluationAcctSchema_ID, trxName){/** if (M_RevaluationAcctSchema_ID == 0){SetM_InventoryRevaluation_ID (0);SetM_RevaluationAcctSchema_ID (0);} */
}public X_M_RevaluationAcctSchema (Ctx ctx, int M_RevaluationAcctSchema_ID, Trx trxName) : base (ctx, M_RevaluationAcctSchema_ID, trxName){/** if (M_RevaluationAcctSchema_ID == 0){SetM_InventoryRevaluation_ID (0);SetM_RevaluationAcctSchema_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_RevaluationAcctSchema (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_RevaluationAcctSchema (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_M_RevaluationAcctSchema (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_M_RevaluationAcctSchema(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27964611935404L;/** Last Updated Timestamp 4/26/2023 5:23:38 AM */
public static long updatedMS = 1682486618615L;/** AD_Table_ID=1002362 */
public static int Table_ID; // =1002362;
/** TableName=M_RevaluationAcctSchema */
public static String Table_Name="M_RevaluationAcctSchema";
protected static KeyNamePair model;protected Decimal accessLevel = new Decimal(3);/** AccessLevel
@return 3 - Client - Org 
*/
protected override int Get_AccessLevel(){return Convert.ToInt32(accessLevel.ToString());}/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Context ctx){POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);return poi;}/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Ctx ctx){POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);return poi;}/** Info
@return info
*/
public override String ToString(){StringBuilder sb = new StringBuilder ("X_M_RevaluationAcctSchema[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Accounting Book.
@param C_AcctSchema_ID Rules for accounting */
public void SetC_AcctSchema_ID (int C_AcctSchema_ID){if (C_AcctSchema_ID <= 0) Set_Value ("C_AcctSchema_ID", null);else
Set_Value ("C_AcctSchema_ID", C_AcctSchema_ID);}/** Get Accounting Book.
@return Rules for accounting */
public int GetC_AcctSchema_ID() {Object ii = Get_Value("C_AcctSchema_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Currency Rate Type.
@param C_ConversionType_ID Currency Conversion Rate Type */
public void SetC_ConversionType_ID (int C_ConversionType_ID){if (C_ConversionType_ID <= 0) Set_Value ("C_ConversionType_ID", null);else
Set_Value ("C_ConversionType_ID", C_ConversionType_ID);}/** Get Currency Rate Type.
@return Currency Conversion Rate Type */
public int GetC_ConversionType_ID() {Object ii = Get_Value("C_ConversionType_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Currency.
@param C_Currency_ID The Currency for this record */
public void SetC_Currency_ID (int C_Currency_ID){if (C_Currency_ID <= 0) Set_Value ("C_Currency_ID", null);else
Set_Value ("C_Currency_ID", C_Currency_ID);}/** Get Currency.
@return The Currency for this record */
public int GetC_Currency_ID() {Object ii = Get_Value("C_Currency_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set M_InventoryRevaluation_ID.
@param M_InventoryRevaluation_ID M_InventoryRevaluation_ID */
public void SetM_InventoryRevaluation_ID (int M_InventoryRevaluation_ID){if (M_InventoryRevaluation_ID < 1) throw new ArgumentException ("M_InventoryRevaluation_ID is mandatory.");Set_ValueNoCheck ("M_InventoryRevaluation_ID", M_InventoryRevaluation_ID);}/** Get M_InventoryRevaluation_ID.
@return M_InventoryRevaluation_ID */
public int GetM_InventoryRevaluation_ID() {Object ii = Get_Value("M_InventoryRevaluation_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Revaluation Accounting Schema.
@param M_RevaluationAcctSchema_ID Revaluation Accounting Schema */
public void SetM_RevaluationAcctSchema_ID (int M_RevaluationAcctSchema_ID){if (M_RevaluationAcctSchema_ID < 1) throw new ArgumentException ("M_RevaluationAcctSchema_ID is mandatory.");Set_ValueNoCheck ("M_RevaluationAcctSchema_ID", M_RevaluationAcctSchema_ID);}/** Get Revaluation Accounting Schema.
@return Revaluation Accounting Schema */
public int GetM_RevaluationAcctSchema_ID() {Object ii = Get_Value("M_RevaluationAcctSchema_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Rate.
@param Rate Rate or Tax or Exchange */
public void SetRate (Decimal? Rate){Set_Value ("Rate", (Decimal?)Rate);}/** Get Rate.
@return Rate or Tax or Exchange */
public Decimal GetRate() {Object bd =Get_Value("Rate");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}}
}