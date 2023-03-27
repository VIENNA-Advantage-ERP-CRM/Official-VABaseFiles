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
    using System.Data;/** Generated Model for VAS_ContractTerms
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
    public class X_VAS_ContractTerms : PO
    {
        public X_VAS_ContractTerms(Context ctx, int VAS_ContractTerms_ID, Trx trxName) : base(ctx, VAS_ContractTerms_ID, trxName)
        {/** if (VAS_ContractTerms_ID == 0){SetVAS_ContractTerms_ID (0);} */
        }
        public X_VAS_ContractTerms(Ctx ctx, int VAS_ContractTerms_ID, Trx trxName) : base(ctx, VAS_ContractTerms_ID, trxName)
        {/** if (VAS_ContractTerms_ID == 0){SetVAS_ContractTerms_ID (0);} */
        }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractTerms(Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractTerms(Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractTerms(Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName) { }/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
        static X_VAS_ContractTerms() { Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID, Table_Name); }/** Serial Version No */
        static long serialVersionUID = 27957396092945L;/** Last Updated Timestamp 2/1/2023 4:59:36 PM */
        public static long updatedMS = 1675270776156L;/** AD_Table_ID=1000572 */
        public static int Table_ID; // =1000572;
        /** TableName=VAS_ContractTerms */
        public static String Table_Name = "VAS_ContractTerms";
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
        public override String ToString() { StringBuilder sb = new StringBuilder("X_VAS_ContractTerms[").Append(Get_ID()).Append("]"); return sb.ToString(); }/** Set Export.
@param Export_ID Export */
        public void SetExport_ID(String Export_ID) { if (Export_ID != null && Export_ID.Length > 50) { log.Warning("Length > 50 - truncated"); Export_ID = Export_ID.Substring(0, 50); } Set_Value("Export_ID", Export_ID); }/** Get Export.
@return Export */
        public String GetExport_ID() { return (String)Get_Value("Export_ID"); }/** Set Line.
@param LineNo Line */
        public void SetLineNo(int LineNo) { Set_Value("LineNo", LineNo); }/** Get Line.
@return Line */
        public int GetLineNo() { Object ii = Get_Value("LineNo"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set VAS_ContractTerms_ID.
@param VAS_ContractTerms_ID VAS_ContractTerms_ID */
        public void SetVAS_ContractTerms_ID(int VAS_ContractTerms_ID) { if (VAS_ContractTerms_ID < 1) throw new ArgumentException("VAS_ContractTerms_ID is mandatory."); Set_ValueNoCheck("VAS_ContractTerms_ID", VAS_ContractTerms_ID); }/** Get VAS_ContractTerms_ID.
@return VAS_ContractTerms_ID */
        public int GetVAS_ContractTerms_ID() { Object ii = Get_Value("VAS_ContractTerms_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Summary.
@param VAS_Summary Short Summary of the contract terms. */
        public void SetVAS_Summary(String VAS_Summary) { if (VAS_Summary != null && VAS_Summary.Length > 400) { log.Warning("Length > 400 - truncated"); VAS_Summary = VAS_Summary.Substring(0, 400); } Set_Value("VAS_Summary", VAS_Summary); }/** Get Summary.
@return Short Summary of the contract terms. */
        public String GetVAS_Summary() { return (String)Get_Value("VAS_Summary"); }/** Set TermDescription.
@param VAS_TermDescription Short Description of the contract Term. */
        public void SetVAS_TermDescription(String VAS_TermDescription) { if (VAS_TermDescription != null && VAS_TermDescription.Length > 500) { log.Warning("Length > 500 - truncated"); VAS_TermDescription = VAS_TermDescription.Substring(0, 500); } Set_Value("VAS_TermDescription", VAS_TermDescription); }/** Get TermDescription.
@return Short Description of the contract Term. */
        public String GetVAS_TermDescription() { return (String)Get_Value("VAS_TermDescription"); }
        /** Set VAS_ContractMaster_ID.
        @param VAS_ContractMaster_ID VAS_ContractMaster_ID*/
        public void SetVAS_ContractMaster_ID(int VAS_ContractMaster_ID) { if (VAS_ContractMaster_ID < 1) throw new ArgumentException("VAS_ContractMaster_ID is mandatory."); Set_ValueNoCheck("VAS_ContractMaster_ID", VAS_ContractMaster_ID); }
        /** Get VAS_ContractMaster_ID.
@return VAS_ContractMaster_ID */
        public int GetVAS_ContractMaster_ID() { Object ii = Get_Value("VAS_ContractMaster_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }
    }
}