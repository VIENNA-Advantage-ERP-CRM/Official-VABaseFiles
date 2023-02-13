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
    using System.Data;/** Generated Model for VAS_Response
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
    public class X_VAS_Response : PO
    {
        public X_VAS_Response(Context ctx, int VAS_Response_ID, Trx trxName) : base(ctx, VAS_Response_ID, trxName)
        {/** if (VAS_Response_ID == 0){SetDocumentNo (null);SetVAS_Response_ID (0);} */
        }
        public X_VAS_Response(Ctx ctx, int VAS_Response_ID, Trx trxName) : base(ctx, VAS_Response_ID, trxName)
        {/** if (VAS_Response_ID == 0){SetDocumentNo (null);SetVAS_Response_ID (0);} */
        }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_Response(Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_Response(Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_Response(Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName) { }/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
        static X_VAS_Response() { Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID, Table_Name); }/** Serial Version No */
        static long serialVersionUID = 27957396162871L;/** Last Updated Timestamp 2/1/2023 5:00:46 PM */
        public static long updatedMS = 1675270846082L;/** AD_Table_ID=1000573 */
        public static int Table_ID; // =1000573;
        /** TableName=VAS_Response */
        public static String Table_Name = "VAS_Response";
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
        public override String ToString() { StringBuilder sb = new StringBuilder("X_VAS_Response[").Append(Get_ID()).Append("]"); return sb.ToString(); }/** Set RfQ.
@param C_RfQ_ID Request for Quotation */
        public void SetC_RfQ_ID(int C_RfQ_ID)
        {
            if (C_RfQ_ID <= 0) Set_Value("C_RfQ_ID", null);
            else
                Set_Value("C_RfQ_ID", C_RfQ_ID);
        }/** Get RfQ.
@return Request for Quotation */
        public int GetC_RfQ_ID() { Object ii = Get_Value("C_RfQ_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Description.
@param Description Optional short description of the record */
        public void SetDescription(String Description) { if (Description != null && Description.Length > 255) { log.Warning("Length > 255 - truncated"); Description = Description.Substring(0, 255); } Set_Value("Description", Description); }/** Get Description.
@return Optional short description of the record */
        public String GetDescription() { return (String)Get_Value("Description"); }/** Set Document No..
@param DocumentNo Document sequence number of the document */
        public void SetDocumentNo(String DocumentNo) { if (DocumentNo == null) throw new ArgumentException("DocumentNo is mandatory."); if (DocumentNo.Length > 30) { log.Warning("Length > 30 - truncated"); DocumentNo = DocumentNo.Substring(0, 30); } Set_Value("DocumentNo", DocumentNo); }/** Get Document No..
@return Document sequence number of the document */
        public String GetDocumentNo() { return (String)Get_Value("DocumentNo"); }/** Set Export.
@param Export_ID Export */
        public void SetExport_ID(String Export_ID) { if (Export_ID != null && Export_ID.Length > 50) { log.Warning("Length > 50 - truncated"); Export_ID = Export_ID.Substring(0, 50); } Set_Value("Export_ID", Export_ID); }/** Get Export.
@return Export */
        public String GetExport_ID() { return (String)Get_Value("Export_ID"); }/** Set Comment.
@param Help Comment, Help or Hint */
        public void SetHelp(String Help) { if (Help != null && Help.Length > 255) { log.Warning("Length > 255 - truncated"); Help = Help.Substring(0, 255); } Set_Value("Help", Help); }/** Get Comment.
@return Comment, Help or Hint */
        public String GetHelp() { return (String)Get_Value("Help"); }/** Set Name.
@param Name Alphanumeric identifier of the entity */
        public void SetName(String Name) { if (Name != null && Name.Length > 60) { log.Warning("Length > 60 - truncated"); Name = Name.Substring(0, 60); } Set_Value("Name", Name); }/** Get Name.
@return Alphanumeric identifier of the entity */
        public String GetName() { return (String)Get_Value("Name"); }/** Get Record ID/ColumnName
@return ID/ColumnName pair */
        public KeyNamePair GetKeyNamePair() { return new KeyNamePair(Get_ID(), GetName()); }/** Set VAS_Response_ID.
@param VAS_Response_ID VAS_Response_ID */
        public void SetVAS_Response_ID(int VAS_Response_ID) { if (VAS_Response_ID < 1) throw new ArgumentException("VAS_Response_ID is mandatory."); Set_ValueNoCheck("VAS_Response_ID", VAS_Response_ID); }/** Get VAS_Response_ID.
@return VAS_Response_ID */
        public int GetVAS_Response_ID() { Object ii = Get_Value("VAS_Response_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }
    }
}