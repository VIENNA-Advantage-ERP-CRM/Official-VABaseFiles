namespace VAdvantage.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for VAS_VariationThreshold
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_VAS_VariationThreshold : PO{public X_VAS_VariationThreshold (Context ctx, int VAS_VariationThreshold_ID, Trx trxName) : base (ctx, VAS_VariationThreshold_ID, trxName){/** if (VAS_VariationThreshold_ID == 0){SetVAS_VariationThreshold_ID (0);} */
}public X_VAS_VariationThreshold (Ctx ctx, int VAS_VariationThreshold_ID, Trx trxName) : base (ctx, VAS_VariationThreshold_ID, trxName){/** if (VAS_VariationThreshold_ID == 0){SetVAS_VariationThreshold_ID (0);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAS_VariationThreshold (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAS_VariationThreshold (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_VAS_VariationThreshold (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_VAS_VariationThreshold(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 27967827418036L;/** Last Updated Timestamp 6/2/2023 4:35:01 AM */
public static long updatedMS = 1685702101247L;/** AD_Table_ID=1001317 */
public static int Table_ID; // =1001317;
/** TableName=VAS_VariationThreshold */
public static String Table_Name="VAS_VariationThreshold";
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_VAS_VariationThreshold[").Append(Get_ID()).Append("]");return sb.ToString();}/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description){if (Description != null && Description.Length > 255){log.Warning("Length > 255 - truncated");Description = Description.Substring(0,255);}Set_Value ("Description", Description);}/** Get Description.
@return Optional short description of the record */
public String GetDescription() {return (String)Get_Value("Description");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 50){log.Warning("Length > 50 - truncated");Export_ID = Export_ID.Substring(0,50);}Set_Value ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Comment.
@param Help Comment, Help or Hint */
public void SetHelp (String Help){if (Help != null && Help.Length > 255){log.Warning("Length > 255 - truncated");Help = Help.Substring(0,255);}Set_Value ("Help", Help);}/** Get Comment.
@return Comment, Help or Hint */
public String GetHelp() {return (String)Get_Value("Help");}/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name){if (Name != null && Name.Length > 60){log.Warning("Length > 60 - truncated");Name = Name.Substring(0,60);}Set_Value ("Name", Name);}/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() {return (String)Get_Value("Name");}
/** VAS_ThresholdBasis AD_Reference_ID=1000821 */
public static int VAS_THRESHOLDBASIS_AD_Reference_ID=1000821;/** General = GNL */
public static String VAS_THRESHOLDBASIS_General = "GNL";/** Purchase Order/Contract = POC */
public static String VAS_THRESHOLDBASIS_PurchaseOrderContract = "POC";/** Product/Product Category = PPC */
public static String VAS_THRESHOLDBASIS_ProductProductCategory = "PPC";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsVAS_ThresholdBasisValid (String test){return test == null || test.Equals("GNL") || test.Equals("POC") || test.Equals("PPC");}/** Set Threshold Basis.
@param VAS_ThresholdBasis This field will provide the basis on which the threshold will function. */
public void SetVAS_ThresholdBasis (String VAS_ThresholdBasis){if (!IsVAS_ThresholdBasisValid(VAS_ThresholdBasis))
throw new ArgumentException ("VAS_ThresholdBasis Invalid value - " + VAS_ThresholdBasis + " - Reference_ID=1000821 - GNL - POC - PPC");if (VAS_ThresholdBasis != null && VAS_ThresholdBasis.Length > 3){log.Warning("Length > 3 - truncated");VAS_ThresholdBasis = VAS_ThresholdBasis.Substring(0,3);}Set_Value ("VAS_ThresholdBasis", VAS_ThresholdBasis);}/** Get Threshold Basis.
@return This field will provide the basis on which the threshold will function. */
public String GetVAS_ThresholdBasis() {return (String)Get_Value("VAS_ThresholdBasis");}/** Set VAS_VariationThreshold_ID.
@param VAS_VariationThreshold_ID VAS_VariationThreshold_ID */
public void SetVAS_VariationThreshold_ID (int VAS_VariationThreshold_ID){if (VAS_VariationThreshold_ID < 1) throw new ArgumentException ("VAS_VariationThreshold_ID is mandatory.");Set_ValueNoCheck ("VAS_VariationThreshold_ID", VAS_VariationThreshold_ID);}/** Get VAS_VariationThreshold_ID.
@return VAS_VariationThreshold_ID */
public int GetVAS_VariationThreshold_ID() {Object ii = Get_Value("VAS_VariationThreshold_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Valid from.
@param ValidFrom Valid from including this date (first day) */
public void SetValidFrom (DateTime? ValidFrom){Set_Value ("ValidFrom", (DateTime?)ValidFrom);}/** Get Valid from.
@return Valid from including this date (first day) */
public DateTime? GetValidFrom() {return (DateTime?)Get_Value("ValidFrom");}/** Set Valid to.
@param ValidTo Valid to including this date (last day) */
public void SetValidTo (DateTime? ValidTo){Set_Value ("ValidTo", (DateTime?)ValidTo);}/** Get Valid to.
@return Valid to including this date (last day) */
public DateTime? GetValidTo() {return (DateTime?)Get_Value("ValidTo");}/** Set Search Key.
@param Value Search key for the record in the format required - must be unique */
public void SetValue (String Value){if (Value != null && Value.Length > 30){log.Warning("Length > 30 - truncated");Value = Value.Substring(0,30);}Set_Value ("Value", Value);}/** Get Search Key.
@return Search key for the record in the format required - must be unique */
public String GetValue() {return (String)Get_Value("Value");}}
}