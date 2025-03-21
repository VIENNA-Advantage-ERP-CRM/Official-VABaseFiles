namespace ViennaAdvantage.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for NodeAPICredential
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_NodeAPICredential : PO{public X_NodeAPICredential (Context ctx, int NodeAPICredential_ID, Trx trxName) : base (ctx, NodeAPICredential_ID, trxName){/** if (NodeAPICredential_ID == 0){SetAD_WF_Node_ID (0);SetNodeAPICredential_ID (0);} */
}public X_NodeAPICredential (Ctx ctx, int NodeAPICredential_ID, Trx trxName) : base (ctx, NodeAPICredential_ID, trxName){/** if (NodeAPICredential_ID == 0){SetAD_WF_Node_ID (0);SetNodeAPICredential_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_NodeAPICredential (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_NodeAPICredential (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_NodeAPICredential (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_NodeAPICredential(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 28023907904018L;/** Last Updated Timestamp 3/12/2025 5:59:47 PM */
public static long updatedMS = 1741782587229L;/** AD_Table_ID=1001369 */
public static int Table_ID; // =1001369;
/** TableName=NodeAPICredential */
public static String Table_Name="NodeAPICredential";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_NodeAPICredential[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Node.
@param AD_WF_Node_ID Workflow Node (activity), step or process */
public void SetAD_WF_Node_ID (int AD_WF_Node_ID){if (AD_WF_Node_ID < 1) throw new ArgumentException ("AD_WF_Node_ID is mandatory.");Set_ValueNoCheck ("AD_WF_Node_ID", AD_WF_Node_ID);}/** Get Node.
@return Workflow Node (activity), step or process */
public int GetAD_WF_Node_ID() {Object ii = Get_Value("AD_WF_Node_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Api Key (if required).
@param ApiKey Api Key provider by provider. */
public void SetApiKey (String ApiKey){Set_Value ("ApiKey", ApiKey);}/** Get Api Key (if required).
@return Api Key provider by provider. */
public String GetApiKey() {return (String)Get_Value("ApiKey");}/** Set Endpoints.
@param Endpoints Endpoints */
public void SetEndpoints (String Endpoints){if (Endpoints != null && Endpoints.Length > 250){log.Warning("Length > 250 - truncated");Endpoints = Endpoints.Substring(0,250);}Set_Value ("Endpoints", Endpoints);}/** Get Endpoints.
@return Endpoints */
public String GetEndpoints() {return (String)Get_Value("Endpoints");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set NodeAPICredential_ID.
@param NodeAPICredential_ID NodeAPICredential_ID */
public void SetNodeAPICredential_ID (int NodeAPICredential_ID){if (NodeAPICredential_ID < 1) throw new ArgumentException ("NodeAPICredential_ID is mandatory.");Set_ValueNoCheck ("NodeAPICredential_ID", NodeAPICredential_ID);}/** Get NodeAPICredential_ID.
@return NodeAPICredential_ID */
public int GetNodeAPICredential_ID() {Object ii = Get_Value("NodeAPICredential_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}