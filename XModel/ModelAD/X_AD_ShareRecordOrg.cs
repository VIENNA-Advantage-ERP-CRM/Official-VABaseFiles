namespace VAdvantage.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for AD_ShareRecordOrg
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_AD_ShareRecordOrg : PO{public X_AD_ShareRecordOrg (Context ctx, int AD_ShareRecordOrg_ID, Trx trxName) : base (ctx, AD_ShareRecordOrg_ID, trxName){/** if (AD_ShareRecordOrg_ID == 0){SetAD_OrgShared_ID (0);SetAD_ShareRecordOrg_ID (0);SetAD_Table_ID (0);SetRecord_ID (0);} */
}public X_AD_ShareRecordOrg (Ctx ctx, int AD_ShareRecordOrg_ID, Trx trxName) : base (ctx, AD_ShareRecordOrg_ID, trxName){/** if (AD_ShareRecordOrg_ID == 0){SetAD_OrgShared_ID (0);SetAD_ShareRecordOrg_ID (0);SetAD_Table_ID (0);SetRecord_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_ShareRecordOrg (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_ShareRecordOrg (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_ShareRecordOrg (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_AD_ShareRecordOrg(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27950524652339L;/** Last Updated Timestamp 11/14/2022 9:45:35 AM */
public static long updatedMS = 1668399335550L;/** AD_Table_ID=1001075 */
public static int Table_ID; // =1001075;
/** TableName=AD_ShareRecordOrg */
public static String Table_Name="AD_ShareRecordOrg";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_AD_ShareRecordOrg[").Append(Get_ID()).Append("]");return sb.ToString();}
/** AD_OrgShared_ID AD_Reference_ID=276 */
public static int AD_ORGSHARED_ID_AD_Reference_ID=276;/** Set Organization.
@param AD_OrgShared_ID Organization */
public void SetAD_OrgShared_ID (int AD_OrgShared_ID){if (AD_OrgShared_ID < 1) throw new ArgumentException ("AD_OrgShared_ID is mandatory.");Set_Value ("AD_OrgShared_ID", AD_OrgShared_ID);}/** Get Organization.
@return Organization */
public int GetAD_OrgShared_ID() {Object ii = Get_Value("AD_OrgShared_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set AD_ShareRecordOrg_ID.
@param AD_ShareRecordOrg_ID AD_ShareRecordOrg_ID */
public void SetAD_ShareRecordOrg_ID (int AD_ShareRecordOrg_ID){if (AD_ShareRecordOrg_ID < 1) throw new ArgumentException ("AD_ShareRecordOrg_ID is mandatory.");Set_ValueNoCheck ("AD_ShareRecordOrg_ID", AD_ShareRecordOrg_ID);}/** Get AD_ShareRecordOrg_ID.
@return AD_ShareRecordOrg_ID */
public int GetAD_ShareRecordOrg_ID() {Object ii = Get_Value("AD_ShareRecordOrg_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Table/View.
@param AD_Table_ID Database Table information */
public void SetAD_Table_ID (int AD_Table_ID){if (AD_Table_ID < 1) throw new ArgumentException ("AD_Table_ID is mandatory.");Set_Value ("AD_Table_ID", AD_Table_ID);}/** Get Table/View.
@return Database Table information */
public int GetAD_Table_ID() {Object ii = Get_Value("AD_Table_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Read Only.
@param IsReadOnly Field is read only */
public void SetIsReadOnly (Boolean IsReadOnly){Set_Value ("IsReadOnly", IsReadOnly);}/** Get Read Only.
@return Field is read only */
public Boolean IsReadOnly() {Object oo = Get_Value("IsReadOnly");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Record ID.
@param Record_ID Direct internal record ID */
public void SetRecord_ID (int Record_ID){if (Record_ID < 0) throw new ArgumentException ("Record_ID is mandatory.");Set_Value ("Record_ID", Record_ID);}/** Get Record ID.
@return Direct internal record ID */
public int GetRecord_ID() {Object ii = Get_Value("Record_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}