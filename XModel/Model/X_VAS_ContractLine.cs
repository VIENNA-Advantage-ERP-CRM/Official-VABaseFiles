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
    using System.Data;/** Generated Model for VAS_ContractLine
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
    public class X_VAS_ContractLine : PO
    {
        public X_VAS_ContractLine(Context ctx, int VAS_ContractLine_ID, Trx trxName) : base(ctx, VAS_ContractLine_ID, trxName)
        {/** if (VAS_ContractLine_ID == 0){SetVAS_ContractLine_ID (0);SetVAS_ContractMaster_ID (0);} */
        }
        public X_VAS_ContractLine(Ctx ctx, int VAS_ContractLine_ID, Trx trxName) : base(ctx, VAS_ContractLine_ID, trxName)
        {/** if (VAS_ContractLine_ID == 0){SetVAS_ContractLine_ID (0);SetVAS_ContractMaster_ID (0);} */
        }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractLine(Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractLine(Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractLine(Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName) { }/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
        static X_VAS_ContractLine() { Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID, Table_Name); }/** Serial Version No */
        static long serialVersionUID = 27957395982324L;/** Last Updated Timestamp 2/1/2023 4:57:45 PM */
        public static long updatedMS = 1675270665535L;/** AD_Table_ID=1000570 */
        public static int Table_ID; // =1000570;
        /** TableName=VAS_ContractLine */
        public static String Table_Name = "VAS_ContractLine";
        protected static KeyNamePair model; protected Decimal accessLevel = new Decimal(3);/** AccessLevel
@return 3 - Client - Org 
*/
        protected override int Get_AccessLevel() { return Convert.ToInt32(accessLevel.ToString()); }/** Load Meta Data
@param ctx context
@return PO Info
*/
        protected override POInfo InitPO(Context ctx) { POInfo poi = POInfo.GetPOInfo(ctx, Table_ID); return poi; }/** Load Meta Data
@param ctx context
@return PO Info
*/
        protected override POInfo InitPO(Ctx ctx) { POInfo poi = POInfo.GetPOInfo(ctx, Table_ID); return poi; }/** Info
@return info
*/
        public override String ToString() { StringBuilder sb = new StringBuilder("X_VAS_ContractLine[").Append(Get_ID()).Append("]"); return sb.ToString(); }/** Set Amount.
@param Amount Amount in a defined currency */
        public void SetAmount(Decimal? Amount) { Set_Value("Amount", (Decimal?)Amount); }/** Get Amount.
@return Amount in a defined currency */
        public Decimal GetAmount() { Object bd = Get_Value("Amount"); if (bd == null) return Env.ZERO; return Convert.ToDecimal(bd); }/** Set Charge.
@param C_Charge_ID Additional document charges */
        public void SetC_Charge_ID(int C_Charge_ID)
        {
            if (C_Charge_ID <= 0) Set_Value("C_Charge_ID", null);
            else
                Set_Value("C_Charge_ID", C_Charge_ID);
        }/** Get Charge.
@return Additional document charges */
        public int GetC_Charge_ID() { Object ii = Get_Value("C_Charge_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set UOM.
@param C_UOM_ID Unit of Measure */
        public void SetC_UOM_ID(int C_UOM_ID)
        {
            if (C_UOM_ID <= 0) Set_Value("C_UOM_ID", null);
            else
                Set_Value("C_UOM_ID", C_UOM_ID);
        }/** Get UOM.
@return Unit of Measure */
        public int GetC_UOM_ID() { Object ii = Get_Value("C_UOM_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Description.
@param Description Optional short description of the record */
        public void SetDescription(String Description) { if (Description != null && Description.Length > 500) { log.Warning("Length > 500 - truncated"); Description = Description.Substring(0, 500); } Set_Value("Description", Description); }/** Get Description.
@return Optional short description of the record */
        public String GetDescription() { return (String)Get_Value("Description"); }/** Set Export.
@param Export_ID Export */
        public void SetExport_ID(String Export_ID) { if (Export_ID != null && Export_ID.Length > 50) { log.Warning("Length > 50 - truncated"); Export_ID = Export_ID.Substring(0, 50); } Set_Value("Export_ID", Export_ID); }/** Get Export.
@return Export */
        public String GetExport_ID() { return (String)Get_Value("Export_ID"); }/** Set Comment.
@param Help Comment, Help or Hint */
        public void SetHelp(String Help) { Set_Value("Help", Help); }/** Get Comment.
@return Comment, Help or Hint */
        public String GetHelp() { return (String)Get_Value("Help"); }/** Set Attribute Set Instance.
@param M_AttributeSetInstance_ID Product Attribute Set Instance */
        public void SetM_AttributeSetInstance_ID(int M_AttributeSetInstance_ID)
        {
            if (M_AttributeSetInstance_ID <= 0) Set_Value("M_AttributeSetInstance_ID", null);
            else
                Set_Value("M_AttributeSetInstance_ID", M_AttributeSetInstance_ID);
        }/** Get Attribute Set Instance.
@return Product Attribute Set Instance */
        public int GetM_AttributeSetInstance_ID() { Object ii = Get_Value("M_AttributeSetInstance_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Product.
@param M_Product_ID Product, Service, Item */
        public void SetM_Product_ID(int M_Product_ID)
        {
            if (M_Product_ID <= 0) Set_Value("M_Product_ID", null);
            else
                Set_Value("M_Product_ID", M_Product_ID);
        }/** Get Product.
@return Product, Service, Item */
        public int GetM_Product_ID() { Object ii = Get_Value("M_Product_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set VAS_ContractLine_ID.
@param VAS_ContractLine_ID VAS_ContractLine_ID */
        public void SetVAS_ContractLine_ID(int VAS_ContractLine_ID) { if (VAS_ContractLine_ID < 1) throw new ArgumentException("VAS_ContractLine_ID is mandatory."); Set_ValueNoCheck("VAS_ContractLine_ID", VAS_ContractLine_ID); }/** Get VAS_ContractLine_ID.
@return VAS_ContractLine_ID */
        public int GetVAS_ContractLine_ID() { Object ii = Get_Value("VAS_ContractLine_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set VAS_ContractMaster_ID.
@param VAS_ContractMaster_ID VAS_ContractMaster_ID */
        public void SetVAS_ContractMaster_ID(int VAS_ContractMaster_ID) { if (VAS_ContractMaster_ID < 1) throw new ArgumentException("VAS_ContractMaster_ID is mandatory."); Set_ValueNoCheck("VAS_ContractMaster_ID", VAS_ContractMaster_ID); }/** Get VAS_ContractMaster_ID.
@return VAS_ContractMaster_ID */
        public int GetVAS_ContractMaster_ID() { Object ii = Get_Value("VAS_ContractMaster_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }
    }
}