namespace VAdvantage.Model
{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAS_ContractCategory
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAS_ContractCategory : PO{public X_VAS_ContractCategory (Context ctx, int VAS_ContractCategory_ID, Trx trxName) : base (ctx, VAS_ContractCategory_ID, trxName){/** if (VAS_ContractCategory_ID == 0){SetVAS_ContractCategory_ID (0);} */
}public X_VAS_ContractCategory (Ctx ctx, int VAS_ContractCategory_ID, Trx trxName) : base (ctx, VAS_ContractCategory_ID, trxName){/** if (VAS_ContractCategory_ID == 0){SetVAS_ContractCategory_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAS_ContractCategory (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAS_ContractCategory (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAS_ContractCategory (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAS_ContractCategory(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27957220487298L;/** Last Updated Timestamp 1/30/2023 4:12:50 PM */
public static long updatedMS = 1675095170509L;/** AD_Table_ID=1000568 */
public static int Table_ID; // =1000568;
/** TableName=VAS_ContractCategory */
public static String Table_Name="VAS_ContractCategory";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAS_ContractCategory[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description){if (Description != null && Description.Length > 500){log.Warning("Length > 500 - truncated");Description = Description.Substring(0,500);}Set_Value ("Description", Description);}/** Get Description.
@return Optional short description of the record */
public String GetDescription() {return (String)Get_Value("Description");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name){if (Name != null && Name.Length > 60){log.Warning("Length > 60 - truncated");Name = Name.Substring(0,60);}Set_Value ("Name", Name);}/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() {return (String)Get_Value("Name");}/** Set VAS_ContractCategory_ID.
@param VAS_ContractCategory_ID VAS_ContractCategory_ID */
public void SetVAS_ContractCategory_ID (int VAS_ContractCategory_ID){if (VAS_ContractCategory_ID < 1) throw new ArgumentException ("VAS_ContractCategory_ID is mandatory.");Set_ValueNoCheck ("VAS_ContractCategory_ID", VAS_ContractCategory_ID);}/** Get VAS_ContractCategory_ID.
@return VAS_ContractCategory_ID */
public int GetVAS_ContractCategory_ID() {Object ii = Get_Value("VAS_ContractCategory_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Search Key.
@param Value Search key for the record in the format required - must be unique */
public void SetValue (String Value){if (Value != null && Value.Length > 30){log.Warning("Length > 30 - truncated");Value = Value.Substring(0,30);}Set_Value ("Value", Value);}/** Get Search Key.
@return Search key for the record in the format required - must be unique */
public String GetValue() {return (String)Get_Value("Value");}}
}