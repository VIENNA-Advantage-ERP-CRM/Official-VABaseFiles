namespace VAdvantage.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for AD_SurveyShowCondition
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_AD_SurveyShowCondition : PO{public X_AD_SurveyShowCondition (Context ctx, int AD_SurveyShowCondition_ID, Trx trxName) : base (ctx, AD_SurveyShowCondition_ID, trxName){/** if (AD_SurveyShowCondition_ID == 0){SetAD_EqualTo (null);SetAD_SurveyAssignment_ID (0);SetAD_SurveyShowCondition_ID (0);SetAndOr (null);// O
} */
}public X_AD_SurveyShowCondition (Ctx ctx, int AD_SurveyShowCondition_ID, Trx trxName) : base (ctx, AD_SurveyShowCondition_ID, trxName){/** if (AD_SurveyShowCondition_ID == 0){SetAD_EqualTo (null);SetAD_SurveyAssignment_ID (0);SetAD_SurveyShowCondition_ID (0);SetAndOr (null);// O
} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_SurveyShowCondition (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_SurveyShowCondition (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_SurveyShowCondition (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_AD_SurveyShowCondition(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27949412473569L;/** Last Updated Timestamp 11/1/2022 12:49:16 PM */
public static long updatedMS = 1667287156780L;/** AD_Table_ID=1001794 */
public static int Table_ID; // =1001794;
/** TableName=AD_SurveyShowCondition */
public static String Table_Name="AD_SurveyShowCondition";
protected static KeyNamePair model;protected Decimal accessLevel = new Decimal(7);/** AccessLevel
@return 7 - System - Client - Org 
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_AD_SurveyShowCondition[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Column.
@param AD_Column_ID Column in the table */
public void SetAD_Column_ID (int AD_Column_ID){if (AD_Column_ID <= 0) Set_Value ("AD_Column_ID", null);else
Set_Value ("AD_Column_ID", AD_Column_ID);}/** Get Column.
@return Column in the table */
public int GetAD_Column_ID() {Object ii = Get_Value("AD_Column_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Equal To.
@param AD_EqualTo Equal To */
public void SetAD_EqualTo (String AD_EqualTo){if (AD_EqualTo == null) throw new ArgumentException ("AD_EqualTo is mandatory.");if (AD_EqualTo.Length > 100){log.Warning("Length > 100 - truncated");AD_EqualTo = AD_EqualTo.Substring(0,100);}Set_Value ("AD_EqualTo", AD_EqualTo);}/** Get Equal To.
@return Equal To */
public String GetAD_EqualTo() {return (String)Get_Value("AD_EqualTo");}/** Set Survey Assignment.
@param AD_SurveyAssignment_ID Survey Assignment */
public void SetAD_SurveyAssignment_ID (int AD_SurveyAssignment_ID){if (AD_SurveyAssignment_ID < 1) throw new ArgumentException ("AD_SurveyAssignment_ID is mandatory.");Set_ValueNoCheck ("AD_SurveyAssignment_ID", AD_SurveyAssignment_ID);}/** Get Survey Assignment.
@return Survey Assignment */
public int GetAD_SurveyAssignment_ID() {Object ii = Get_Value("AD_SurveyAssignment_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set AD_SurveyShowCondition_ID.
@param AD_SurveyShowCondition_ID AD_SurveyShowCondition_ID */
public void SetAD_SurveyShowCondition_ID (int AD_SurveyShowCondition_ID){if (AD_SurveyShowCondition_ID < 1) throw new ArgumentException ("AD_SurveyShowCondition_ID is mandatory.");Set_ValueNoCheck ("AD_SurveyShowCondition_ID", AD_SurveyShowCondition_ID);}/** Get AD_SurveyShowCondition_ID.
@return AD_SurveyShowCondition_ID */
public int GetAD_SurveyShowCondition_ID() {Object ii = Get_Value("AD_SurveyShowCondition_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** AndOr AD_Reference_ID=204 */
public static int ANDOR_AD_Reference_ID=204;/** And = A */
public static String ANDOR_And = "A";/** Or = O */
public static String ANDOR_Or = "O";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsAndOrValid (String test){return test.Equals("A") || test.Equals("O");}/** Set And/Or.
@param AndOr Logical operation: AND or OR */
public void SetAndOr (String AndOr){if (AndOr == null) throw new ArgumentException ("AndOr is mandatory");if (!IsAndOrValid(AndOr))
throw new ArgumentException ("AndOr Invalid value - " + AndOr + " - Reference_ID=204 - A - O");if (AndOr.Length > 1){log.Warning("Length > 1 - truncated");AndOr = AndOr.Substring(0,1);}Set_Value ("AndOr", AndOr);}/** Get And/Or.
@return Logical operation: AND or OR */
public String GetAndOr() {return (String)Get_Value("AndOr");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}
/** Operation AD_Reference_ID=205 */
public static int OPERATION_AD_Reference_ID=205;/** != = != */
public static String OPERATION_NotEq = "!=";/** < = << */
public static String OPERATION_Le = "<<";/** <= = <= */
public static String OPERATION_LeEq = "<=";/**  = = == */
public static String OPERATION_Eq = "==";/** >= = >= */
public static String OPERATION_GtEq = ">=";/** > = >> */
public static String OPERATION_Gt = ">>";/** |<x>| = AB */
public static String OPERATION_X = "AB";/** sql = SQ */
public static String OPERATION_Sql = "SQ";/**  ~ = ~~ */
public static String OPERATION_Like = "~~";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsOperationValid (String test){return test == null || test.Equals("!=") || test.Equals("<<") || test.Equals("<=") || test.Equals("==") || test.Equals(">=") || test.Equals(">>") || test.Equals("AB") || test.Equals("SQ") || test.Equals("~~");}/** Set Operation.
@param Operation Compare Operation */
public void SetOperation (String Operation){if (!IsOperationValid(Operation))
throw new ArgumentException ("Operation Invalid value - " + Operation + " - Reference_ID=205 - != - << - <= - == - >= - >> - AB - SQ - ~~");if (Operation != null && Operation.Length > 2){log.Warning("Length > 2 - truncated");Operation = Operation.Substring(0,2);}Set_Value ("Operation", Operation);}/** Get Operation.
@return Compare Operation */
public String GetOperation() {return (String)Get_Value("Operation");}/** Set Sequence.
@param SeqNo Method of ordering elements; lowest number comes first */
public void SetSeqNo (int SeqNo){Set_Value ("SeqNo", SeqNo);}/** Get Sequence.
@return Method of ordering elements; lowest number comes first */
public int GetSeqNo() {Object ii = Get_Value("SeqNo");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Value To.
@param Value2 Value To */
public void SetValue2 (String Value2){if (Value2 != null && Value2.Length > 40){log.Warning("Length > 40 - truncated");Value2 = Value2.Substring(0,40);}Set_Value ("Value2", Value2);}/** Get Value To.
@return Value To */
public String GetValue2() {return (String)Get_Value("Value2");}}
}