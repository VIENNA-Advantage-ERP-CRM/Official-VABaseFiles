namespace VAdvantage.Model
{

/** Generated Model - DO NOT CHANGE */
using System;
using System.Text;
using VAdvantage.DataBase;
using VAdvantage.Common;
using VAdvantage.Classes;
using VAdvantage.Process;
using VAdvantage.Model;
using VAdvantage.Utility;
using System.Data;
/** Generated Model for C_Channel
 *  @author Jagmohan Bhatt (generated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_C_Channel : PO
{
public X_C_Channel (Context ctx, int C_Channel_ID, Trx trxName) : base (ctx, C_Channel_ID, trxName)
{
/** if (C_Channel_ID == 0)
{
SetC_Channel_ID (0);
SetName (null);
}
 */
}
public X_C_Channel (Ctx ctx, int C_Channel_ID, Trx trxName) : base (ctx, C_Channel_ID, trxName)
{
/** if (C_Channel_ID == 0)
{
SetC_Channel_ID (0);
SetName (null);
}
 */
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Channel (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Channel (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName)
{
}
/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_C_Channel (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName)
{
}
/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_C_Channel()
{
 Table_ID = Get_Table_ID(Table_Name);
 model = new KeyNamePair(Table_ID,Table_Name);
}
/** Serial Version No */
//static long serialVersionUID 27562514371153L;
/** Last Updated Timestamp 7/29/2010 1:07:34 PM */
public static long updatedMS = 1280389054364L;
/** AD_Table_ID=275 */
public static int Table_ID;
 // =275;

/** TableName=C_Channel */
public static String Table_Name="C_Channel";

protected static KeyNamePair model;
protected Decimal accessLevel = new Decimal(3);
/** AccessLevel
@return 3 - Client - Org 
*/
protected override int Get_AccessLevel()
{
return Convert.ToInt32(accessLevel.ToString());
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Ctx ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Load Meta Data
@param ctx context
@return PO Info
*/
protected override POInfo InitPO (Context ctx)
{
POInfo poi = POInfo.GetPOInfo (ctx, Table_ID);
return poi;
}
/** Info
@return info
*/
public override String ToString()
{
StringBuilder sb = new StringBuilder ("X_C_Channel[").Append(Get_ID()).Append("]");
return sb.ToString();
}
/** Set Print Color.
@param AD_PrintColor_ID Color used for printing and display */
public void SetAD_PrintColor_ID (int AD_PrintColor_ID)
{
if (AD_PrintColor_ID <= 0) Set_Value ("AD_PrintColor_ID", null);
else
Set_Value ("AD_PrintColor_ID", AD_PrintColor_ID);
}
/** Get Print Color.
@return Color used for printing and display */
public int GetAD_PrintColor_ID() 
{
Object ii = Get_Value("AD_PrintColor_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Channel.
@param C_Channel_ID Sales Channel */
public void SetC_Channel_ID (int C_Channel_ID)
{
if (C_Channel_ID < 1) throw new ArgumentException ("C_Channel_ID is mandatory.");
Set_ValueNoCheck ("C_Channel_ID", C_Channel_ID);
}
/** Get Channel.
@return Sales Channel */
public int GetC_Channel_ID() 
{
Object ii = Get_Value("C_Channel_ID");
if (ii == null) return 0;
return Convert.ToInt32(ii);
}
/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description)
{
if (Description != null && Description.Length > 255)
{
log.Warning("Length > 255 - truncated");
Description = Description.Substring(0,255);
}
Set_Value ("Description", Description);
}
/** Get Description.
@return Optional short description of the record */
public String GetDescription() 
{
return (String)Get_Value("Description");
}
/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name)
{
if (Name == null) throw new ArgumentException ("Name is mandatory.");
if (Name.Length > 60)
{
log.Warning("Length > 60 - truncated");
Name = Name.Substring(0,60);
}
Set_Value ("Name", Name);
}
/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() 
{
return (String)Get_Value("Name");
}
/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() 
{
return new KeyNamePair(Get_ID(), GetName());
}
}

}
