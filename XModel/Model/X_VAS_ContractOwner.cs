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
    using System.Data;/** Generated Model for VAS_ContractOwner
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
    public class X_VAS_ContractOwner : PO
    {
        public X_VAS_ContractOwner(Context ctx, int VAS_ContractOwner_ID, Trx trxName) : base(ctx, VAS_ContractOwner_ID, trxName)
        {/** if (VAS_ContractOwner_ID == 0){SetVAS_ContractMaster_ID (0);SetVAS_ContractOwner_ID (0);} */
        }
        public X_VAS_ContractOwner(Ctx ctx, int VAS_ContractOwner_ID, Trx trxName) : base(ctx, VAS_ContractOwner_ID, trxName)
        {/** if (VAS_ContractOwner_ID == 0){SetVAS_ContractMaster_ID (0);SetVAS_ContractOwner_ID (0);} */
        }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractOwner(Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractOwner(Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractOwner(Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName) { }/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
        static X_VAS_ContractOwner() { Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID, Table_Name); }/** Serial Version No */
        static long serialVersionUID = 27957396058433L;/** Last Updated Timestamp 2/1/2023 4:59:01 PM */
        public static long updatedMS = 1675270741644L;/** AD_Table_ID=1000571 */
        public static int Table_ID; // =1000571;
        /** TableName=VAS_ContractOwner */
        public static String Table_Name = "VAS_ContractOwner";
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
        public override String ToString() { StringBuilder sb = new StringBuilder("X_VAS_ContractOwner[").Append(Get_ID()).Append("]"); return sb.ToString(); }/** Set Role.
@param AD_Role_ID Responsibility Role */
        public void SetAD_Role_ID(int AD_Role_ID)
        {
            if (AD_Role_ID <= 0) Set_Value("AD_Role_ID", null);
            else
                Set_Value("AD_Role_ID", AD_Role_ID);
        }/** Get Role.
@return Responsibility Role */
        public int GetAD_Role_ID() { Object ii = Get_Value("AD_Role_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set User/Contact.
@param AD_User_ID User within the system - Internal or Customer/Prospect Contact. */
        public void SetAD_User_ID(int AD_User_ID)
        {
            if (AD_User_ID <= 0) Set_Value("AD_User_ID", null);
            else
                Set_Value("AD_User_ID", AD_User_ID);
        }/** Get User/Contact.
@return User within the system - Internal or Customer/Prospect Contact. */
        public int GetAD_User_ID() { Object ii = Get_Value("AD_User_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Export.
@param Export_ID Export */
        public void SetExport_ID(String Export_ID) { if (Export_ID != null && Export_ID.Length > 50) { log.Warning("Length > 50 - truncated"); Export_ID = Export_ID.Substring(0, 50); } Set_Value("Export_ID", Export_ID); }/** Get Export.
@return Export */
        public String GetExport_ID() { return (String)Get_Value("Export_ID"); }/** Set VAS_ContractMaster_ID.
@param VAS_ContractMaster_ID VAS_ContractMaster_ID */
        public void SetVAS_ContractMaster_ID(int VAS_ContractMaster_ID) { if (VAS_ContractMaster_ID < 1) throw new ArgumentException("VAS_ContractMaster_ID is mandatory."); Set_ValueNoCheck("VAS_ContractMaster_ID", VAS_ContractMaster_ID); }/** Get VAS_ContractMaster_ID.
@return VAS_ContractMaster_ID */
        public int GetVAS_ContractMaster_ID() { Object ii = Get_Value("VAS_ContractMaster_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set VAS_ContractOwner_ID.
@param VAS_ContractOwner_ID VAS_ContractOwner_ID */
        public void SetVAS_ContractOwner_ID(int VAS_ContractOwner_ID) { if (VAS_ContractOwner_ID < 1) throw new ArgumentException("VAS_ContractOwner_ID is mandatory."); Set_ValueNoCheck("VAS_ContractOwner_ID", VAS_ContractOwner_ID); }/** Get VAS_ContractOwner_ID.
@return VAS_ContractOwner_ID */
        public int GetVAS_ContractOwner_ID() { Object ii = Get_Value("VAS_ContractOwner_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }
    }
}