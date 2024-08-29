namespace VAdvantage.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for AD_ActionGroup
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_AD_ActionGroup : PO{public X_AD_ActionGroup (Context ctx, int AD_ActionGroup_ID, Trx trxName) : base (ctx, AD_ActionGroup_ID, trxName){/** if (AD_ActionGroup_ID == 0){SetAD_ActionGroup_ID (0);SetName (null);} */
}public X_AD_ActionGroup (Ctx ctx, int AD_ActionGroup_ID, Trx trxName) : base (ctx, AD_ActionGroup_ID, trxName){/** if (AD_ActionGroup_ID == 0){SetAD_ActionGroup_ID (0);SetName (null);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_ActionGroup (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_ActionGroup (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_ActionGroup (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_AD_ActionGroup(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 28007052170732L;/** Last Updated Timestamp 8/29/2024 3:50:53 PM */
public static long updatedMS = 1724926853943L;/** AD_Table_ID=1000598 */
public static int Table_ID; // =1000598;
/** TableName=AD_ActionGroup */
public static String Table_Name="AD_ActionGroup";
protected static KeyNamePair model;protected Decimal accessLevel = new Decimal(4);/** AccessLevel
@return 4 - System 
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_AD_ActionGroup[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Action Group.
@param AD_ActionGroup_ID Key Column */
public void SetAD_ActionGroup_ID (int AD_ActionGroup_ID){if (AD_ActionGroup_ID < 1) throw new ArgumentException ("AD_ActionGroup_ID is mandatory.");Set_ValueNoCheck ("AD_ActionGroup_ID", AD_ActionGroup_ID);}/** Get Action Group.
@return Key Column */
public int GetAD_ActionGroup_ID() {Object ii = Get_Value("AD_ActionGroup_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Font Name.
@param FontName Defines name of font */
public void SetFontName (String FontName){if (FontName != null && FontName.Length > 100){log.Warning("Length > 100 - truncated");FontName = FontName.Substring(0,100);}Set_Value ("FontName", FontName);}/** Get Font Name.
@return Defines name of font */
public String GetFontName() {return (String)Get_Value("FontName");}/** Set HTML Style.
@param HTMLStyle HTML style for field */
public void SetHTMLStyle (String HTMLStyle){if (HTMLStyle != null && HTMLStyle.Length > 300){log.Warning("Length > 300 - truncated");HTMLStyle = HTMLStyle.Substring(0,300);}Set_Value ("HTMLStyle", HTMLStyle);}/** Get HTML Style.
@return HTML style for field */
public String GetHTMLStyle() {return (String)Get_Value("HTMLStyle");}/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name){if (Name == null) throw new ArgumentException ("Name is mandatory.");if (Name.Length > 60){log.Warning("Length > 60 - truncated");Name = Name.Substring(0,60);}Set_Value ("Name", Name);}/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() {return (String)Get_Value("Name");}}
}