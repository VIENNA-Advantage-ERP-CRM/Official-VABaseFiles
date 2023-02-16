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
    using System.Data;/** Generated Model for VAS_ContractMaster
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
    public class X_VAS_ContractMaster : PO
    {
        public X_VAS_ContractMaster(Context ctx, int VAS_ContractMaster_ID, Trx trxName) : base(ctx, VAS_ContractMaster_ID, trxName)
        {/** if (VAS_ContractMaster_ID == 0){SetDocumentNo (null);SetVAS_ContractMaster_ID (0);} */
        }
        public X_VAS_ContractMaster(Ctx ctx, int VAS_ContractMaster_ID, Trx trxName) : base(ctx, VAS_ContractMaster_ID, trxName)
        {/** if (VAS_ContractMaster_ID == 0){SetDocumentNo (null);SetVAS_ContractMaster_ID (0);} */
        }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractMaster(Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractMaster(Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_VAS_ContractMaster(Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName) { }/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
        static X_VAS_ContractMaster() { Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID, Table_Name); }/** Serial Version No */
        static long serialVersionUID = 27957395906687L;/** Last Updated Timestamp 2/1/2023 4:56:29 PM */
        public static long updatedMS = 1675270589898L;/** AD_Table_ID=1000569 */
        public static int Table_ID; // =1000569;
        /** TableName=VAS_ContractMaster */
        public static String Table_Name = "VAS_ContractMaster";
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
        public override String ToString() { StringBuilder sb = new StringBuilder("X_VAS_ContractMaster[").Append(Get_ID()).Append("]"); return sb.ToString(); }
        /** Bill_Location_ID AD_Reference_ID=159 */
        public static int BILL_LOCATION_ID_AD_Reference_ID = 159;/** Set Bill To Location.
@param Bill_Location_ID Account /Prospect Location for invoicing */
        public void SetBill_Location_ID(int Bill_Location_ID)
        {
            if (Bill_Location_ID <= 0) Set_ValueNoCheck("Bill_Location_ID", null);
            else
                Set_ValueNoCheck("Bill_Location_ID", Bill_Location_ID);
        }/** Get Bill To Location.
@return Account /Prospect Location for invoicing */
        public int GetBill_Location_ID() { Object ii = Get_Value("Bill_Location_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }
        /** Bill_User_ID AD_Reference_ID=110 */
        public static int BILL_USER_ID_AD_Reference_ID = 110;/** Set Invoice Contact.
@param Bill_User_ID Account/Prospect Contact for invoicing */
        public void SetBill_User_ID(int Bill_User_ID)
        {
            if (Bill_User_ID <= 0) Set_Value("Bill_User_ID", null);
            else
                Set_Value("Bill_User_ID", Bill_User_ID);
        }/** Get Invoice Contact.
@return Account/Prospect Contact for invoicing */
        public int GetBill_User_ID() { Object ii = Get_Value("Bill_User_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Business Partner.
@param C_BPartner_ID Identifies a Customer/Prospect */
        public void SetC_BPartner_ID(int C_BPartner_ID)
        {
            if (C_BPartner_ID <= 0) Set_Value("C_BPartner_ID", null);
            else
                Set_Value("C_BPartner_ID", C_BPartner_ID);
        }/** Get Business Partner.
@return Identifies a Customer/Prospect */
        public int GetC_BPartner_ID() { Object ii = Get_Value("C_BPartner_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Currency.
@param C_Currency_ID The Currency for this record */
        public void SetC_Currency_ID(int C_Currency_ID)
        {
            if (C_Currency_ID <= 0) Set_Value("C_Currency_ID", null);
            else
                Set_Value("C_Currency_ID", C_Currency_ID);
        }/** Get Currency.
@return The Currency for this record */
        public int GetC_Currency_ID() { Object ii = Get_Value("C_Currency_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Inco Term.
@param C_IncoTerm_ID Inco term will be used to create or define the Inco term based on client requirement */
        public void SetC_IncoTerm_ID(int C_IncoTerm_ID)
        {
            if (C_IncoTerm_ID <= 0) Set_Value("C_IncoTerm_ID", null);
            else
                Set_Value("C_IncoTerm_ID", C_IncoTerm_ID);
        }/** Get Inco Term.
@return Inco term will be used to create or define the Inco term based on client requirement */
        public int GetC_IncoTerm_ID() { Object ii = Get_Value("C_IncoTerm_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Payment Term.
@param C_PaymentTerm_ID The terms of Payment (timing, discount) */
        public void SetC_PaymentTerm_ID(int C_PaymentTerm_ID)
        {
            if (C_PaymentTerm_ID <= 0) Set_Value("C_PaymentTerm_ID", null);
            else
                Set_Value("C_PaymentTerm_ID", C_PaymentTerm_ID);
        }/** Get Payment Term.
@return The terms of Payment (timing, discount) */
        public int GetC_PaymentTerm_ID() { Object ii = Get_Value("C_PaymentTerm_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Project.
@param C_Project_ID Business Opportunity */
        public void SetC_Project_ID(int C_Project_ID)
        {
            if (C_Project_ID <= 0) Set_Value("C_Project_ID", null);
            else
                Set_Value("C_Project_ID", C_Project_ID);
        }/** Get Project.
@return Business Opportunity */
        public int GetC_Project_ID() { Object ii = Get_Value("C_Project_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Notice Days.
@param CancelBeforeDays Notice Days */
        public void SetCancelBeforeDays(Decimal? CancelBeforeDays) { Set_Value("CancelBeforeDays", (Decimal?)CancelBeforeDays); }/** Get Notice Days.
@return Notice Days */
        public Decimal GetCancelBeforeDays() { Object bd = Get_Value("CancelBeforeDays"); if (bd == null) return Env.ZERO; return Convert.ToDecimal(bd); }
        /** ContractType AD_Reference_ID=1000239 */
        public static int CONTRACTTYPE_AD_Reference_ID = 1000239;/** Accounts Payable = ASP */
        public static String CONTRACTTYPE_AccountsPayable = "ASP";/** Accounts Receivable = ASR */
        public static String CONTRACTTYPE_AccountsReceivable = "ASR";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
        public bool IsContractTypeValid(String test) { return test == null || test.Equals("ASP") || test.Equals("ASR"); }/** Set Contract Type.
@param ContractType The list to check if the service contract is a Payable Service Contract or Receivable Service Contract */
        public void SetContractType(String ContractType)
        {
            if (!IsContractTypeValid(ContractType))
                throw new ArgumentException("ContractType Invalid value - " + ContractType + " - Reference_ID=1000239 - ASP - ASR"); if (ContractType != null && ContractType.Length > 3) { log.Warning("Length > 3 - truncated"); ContractType = ContractType.Substring(0, 3); }
            Set_Value("ContractType", ContractType);
        }/** Get Contract Type.
@return The list to check if the service contract is a Payable Service Contract or Receivable Service Contract */
        public String GetContractType() { return (String)Get_Value("ContractType"); }/** Set No of Cycles.
@param Cycles No of Cycles */
        public void SetCycles(Decimal? Cycles) { Set_Value("Cycles", (Decimal?)Cycles); }/** Get No of Cycles.
@return No of Cycles */
        public Decimal GetCycles() { Object bd = Get_Value("Cycles"); if (bd == null) return Env.ZERO; return Convert.ToDecimal(bd); }/** Set Document Date.
@param DateDoc Date of the Document */
        public void SetDateDoc(DateTime? DateDoc) { Set_Value("DateDoc", (DateTime?)DateDoc); }/** Get Document Date.
@return Date of the Document */
        public DateTime? GetDateDoc() { return (DateTime?)Get_Value("DateDoc"); }/** Set Document No..
@param DocumentNo Document sequence number of the document */
        public void SetDocumentNo(String DocumentNo) { if (DocumentNo == null) throw new ArgumentException("DocumentNo is mandatory."); if (DocumentNo.Length > 30) { log.Warning("Length > 30 - truncated"); DocumentNo = DocumentNo.Substring(0, 30); } Set_Value("DocumentNo", DocumentNo); }/** Get Document No..
@return Document sequence number of the document */
        public String GetDocumentNo() { return (String)Get_Value("DocumentNo"); }/** Set End Date.
@param EndDate Last effective date (inclusive) */
        public void SetEndDate(DateTime? EndDate) { Set_Value("EndDate", (DateTime?)EndDate); }/** Get End Date.
@return Last effective date (inclusive) */
        public DateTime? GetEndDate() { return (DateTime?)Get_Value("EndDate"); }/** Set Export.
@param Export_ID Export */
        public void SetExport_ID(String Export_ID) { if (Export_ID != null && Export_ID.Length > 50) { log.Warning("Length > 50 - truncated"); Export_ID = Export_ID.Substring(0, 50); } Set_Value("Export_ID", Export_ID); }/** Get Export.
@return Export */
        public String GetExport_ID() { return (String)Get_Value("Export_ID"); }
        /** IsExpiredContracts AD_Reference_ID=319 */
        public static int ISEXPIREDCONTRACTS_AD_Reference_ID = 319;/** No = N */
        public static String ISEXPIREDCONTRACTS_No = "N";/** Yes = Y */
        public static String ISEXPIREDCONTRACTS_Yes = "Y";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
        public bool IsIsExpiredContractsValid(String test) { return test == null || test.Equals("N") || test.Equals("Y"); }/** Set Expired Contracts.
@param IsExpiredContracts Expired Contracts */
        public void SetIsExpiredContracts(String IsExpiredContracts)
        {
            if (!IsIsExpiredContractsValid(IsExpiredContracts))
                throw new ArgumentException("IsExpiredContracts Invalid value - " + IsExpiredContracts + " - Reference_ID=319 - N - Y"); if (IsExpiredContracts != null && IsExpiredContracts.Length > 5) { log.Warning("Length > 5 - truncated"); IsExpiredContracts = IsExpiredContracts.Substring(0, 5); }
            Set_Value("IsExpiredContracts", IsExpiredContracts);
        }/** Get Expired Contracts.
@return Expired Contracts */
        public String GetIsExpiredContracts() { return (String)Get_Value("IsExpiredContracts"); }/** Set Price List.
@param M_PriceList_ID Unique identifier of a Price List */
        public void SetM_PriceList_ID(int M_PriceList_ID)
        {
            if (M_PriceList_ID <= 0) Set_Value("M_PriceList_ID", null);
            else
                Set_Value("M_PriceList_ID", M_PriceList_ID);
        }/** Get Price List.
@return Unique identifier of a Price List */
        public int GetM_PriceList_ID() { Object ii = Get_Value("M_PriceList_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }
        /** Ref_Contract_ID AD_Reference_ID=1000265 */
        public static int REF_CONTRACT_ID_AD_Reference_ID = 1000265;/** Set Contract Ref..
@param Ref_Contract_ID Reference of base contract */
        public void SetRef_Contract_ID(int Ref_Contract_ID)
        {
            if (Ref_Contract_ID <= 0) Set_Value("Ref_Contract_ID", null);
            else
                Set_Value("Ref_Contract_ID", Ref_Contract_ID);
        }/** Get Contract Ref..
@return Reference of base contract */
        public int GetRef_Contract_ID() { Object ii = Get_Value("Ref_Contract_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }
        /** RenewalType AD_Reference_ID=1000266 */
        public static int RENEWALTYPE_AD_Reference_ID = 1000266;/** Automatic = ATC */
        public static String RENEWALTYPE_Automatic = "ATC";/** Manual = MNL */
        public static String RENEWALTYPE_Manual = "MNL";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
        public bool IsRenewalTypeValid(String test) { return test == null || test.Equals("ATC") || test.Equals("MNL"); }/** Set Renewal Type.
@param RenewalType Renewal Type */
        public void SetRenewalType(String RenewalType)
        {
            if (!IsRenewalTypeValid(RenewalType))
                throw new ArgumentException("RenewalType Invalid value - " + RenewalType + " - Reference_ID=1000266 - ATC - MNL"); if (RenewalType != null && RenewalType.Length > 3) { log.Warning("Length > 3 - truncated"); RenewalType = RenewalType.Substring(0, 3); }
            Set_Value("RenewalType", RenewalType);
        }/** Get Renewal Type.
@return Renewal Type */
        public String GetRenewalType() { return (String)Get_Value("RenewalType"); }/** Set Start Date.
@param StartDate First effective day (inclusive) */
        public void SetStartDate(DateTime? StartDate) { Set_Value("StartDate", (DateTime?)StartDate); }/** Get Start Date.
@return First effective day (inclusive) */
        public DateTime? GetStartDate() { return (DateTime?)Get_Value("StartDate"); }/** Set Contract Amount.
@param VAS_ContractAmount Amount of the Contract. */
        public void SetVAS_ContractAmount(Decimal? VAS_ContractAmount) { Set_Value("VAS_ContractAmount", (Decimal?)VAS_ContractAmount); }/** Get Contract Amount.
@return Amount of the Contract. */
        public Decimal GetVAS_ContractAmount() { Object bd = Get_Value("VAS_ContractAmount"); if (bd == null) return Env.ZERO; return Convert.ToDecimal(bd); }/** Set VAS_ContractCategory_ID.
@param VAS_ContractCategory_ID VAS_ContractCategory_ID */
        public void SetVAS_ContractCategory_ID(int VAS_ContractCategory_ID)
        {
            if (VAS_ContractCategory_ID <= 0) Set_Value("VAS_ContractCategory_ID", null);
            else
                Set_Value("VAS_ContractCategory_ID", VAS_ContractCategory_ID);
        }/** Get VAS_ContractCategory_ID.
@return VAS_ContractCategory_ID */
        public int GetVAS_ContractCategory_ID() { Object ii = Get_Value("VAS_ContractCategory_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Contract Duration.
@param VAS_ContractDuration Duration of contract. */
        public void SetVAS_ContractDuration(String VAS_ContractDuration) { if (VAS_ContractDuration != null && VAS_ContractDuration.Length > 10) { log.Warning("Length > 10 - truncated"); VAS_ContractDuration = VAS_ContractDuration.Substring(0, 10); } Set_Value("VAS_ContractDuration", VAS_ContractDuration); }/** Get Contract Duration.
@return Duration of contract. */
        public String GetVAS_ContractDuration() { return (String)Get_Value("VAS_ContractDuration"); }
        /** Set Contract Months.
@param VAS_ContractMonths Months of contract. */
        public void SetVAS_ContractMonths(String VAS_ContractMonths) { if (VAS_ContractMonths != null && VAS_ContractMonths.Length > 10) { log.Warning("Length > 10 - truncated"); VAS_ContractMonths = VAS_ContractMonths.Substring(0, 10); } Set_Value("VAS_ContractMonths", VAS_ContractMonths); }/** Get Contract Months.
@return Months of contract. */
        public String GetVAS_ContractMonths() { return (String)Get_Value("VAS_ContractMonths"); }
        /** Set VAS_ContractMaster_ID.
@param VAS_ContractMaster_ID VAS_ContractMaster_ID */
        public void SetVAS_ContractMaster_ID(int VAS_ContractMaster_ID) { if (VAS_ContractMaster_ID < 1) throw new ArgumentException("VAS_ContractMaster_ID is mandatory."); Set_ValueNoCheck("VAS_ContractMaster_ID", VAS_ContractMaster_ID); }/** Get VAS_ContractMaster_ID.
@return VAS_ContractMaster_ID */
        public int GetVAS_ContractMaster_ID() { Object ii = Get_Value("VAS_ContractMaster_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Contract Summary.
@param VAS_ContractSummary Short Summary of Contract. */
        public void SetVAS_ContractSummary(String VAS_ContractSummary) { if (VAS_ContractSummary != null && VAS_ContractSummary.Length > 1000) { log.Warning("Length > 1000 - truncated"); VAS_ContractSummary = VAS_ContractSummary.Substring(0, 1000); } Set_Value("VAS_ContractSummary", VAS_ContractSummary); }/** Get Contract Summary.
@return Short Summary of Contract. */
        public String GetVAS_ContractSummary() { return (String)Get_Value("VAS_ContractSummary"); }/** Set Contract Utilized Amount.
@param VAS_ContractUtilizedAmount Amount Utilized from Contract Total. */
        public void SetVAS_ContractUtilizedAmount(Decimal? VAS_ContractUtilizedAmount) { Set_Value("VAS_ContractUtilizedAmount", (Decimal?)VAS_ContractUtilizedAmount); }/** Get Contract Utilized Amount.
@return Amount Utilized from Contract Total. */
        public Decimal GetVAS_ContractUtilizedAmount() { Object bd = Get_Value("VAS_ContractUtilizedAmount"); if (bd == null) return Env.ZERO; return Convert.ToDecimal(bd); }/** Set Jurisdiction.
@param VAS_Jurisdiction Jurisdiction for contract. */
        public void SetVAS_Jurisdiction(String VAS_Jurisdiction) { if (VAS_Jurisdiction != null && VAS_Jurisdiction.Length > 30) { log.Warning("Length > 30 - truncated"); VAS_Jurisdiction = VAS_Jurisdiction.Substring(0, 30); } Set_Value("VAS_Jurisdiction", VAS_Jurisdiction); }/** Get Jurisdiction.
@return Jurisdiction for contract. */
        public String GetVAS_Jurisdiction() { return (String)Get_Value("VAS_Jurisdiction"); }/** Set Over Limit.
@param VAS_OverLimit Checkbox that will indicate the contract budget has exceeded. */
        public void SetVAS_OverLimit(Boolean VAS_OverLimit) { Set_Value("VAS_OverLimit", VAS_OverLimit); }/** Get Over Limit.
@return Checkbox that will indicate the contract budget has exceeded. */
        public Boolean IsVAS_OverLimit() { Object oo = Get_Value("VAS_OverLimit"); if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo); } return false; }/** Set RenewContract.
@param VAS_RenewContract Renew of the Contract. */
        public void SetVAS_RenewContract(String VAS_RenewContract) { if (VAS_RenewContract != null && VAS_RenewContract.Length > 1) { log.Warning("Length > 1 - truncated"); VAS_RenewContract = VAS_RenewContract.Substring(0, 1); } Set_Value("VAS_RenewContract", VAS_RenewContract); }/** Get RenewContract.
@return Renew of the Contract. */
        public String GetVAS_RenewContract() { return (String)Get_Value("VAS_RenewContract"); }/** Set Renewal Date.
@param VAS_RenewalDate Date when the contract renews. */
        public void SetVAS_RenewalDate(DateTime? VAS_RenewalDate) { Set_Value("VAS_RenewalDate", (DateTime?)VAS_RenewalDate); }/** Get Renewal Date.
@return Date when the contract renews. */
        public DateTime? GetVAS_RenewalDate() { return (DateTime?)Get_Value("VAS_RenewalDate"); }/** Set Renewal Term.
@param VAS_RenewalTerm Term for the renewal. */
        public void SetVAS_RenewalTerm(String VAS_RenewalTerm) { if (VAS_RenewalTerm != null && VAS_RenewalTerm.Length > 500) { log.Warning("Length > 500 - truncated"); VAS_RenewalTerm = VAS_RenewalTerm.Substring(0, 500); } Set_Value("VAS_RenewalTerm", VAS_RenewalTerm); }/** Get Renewal Term.
@return Term for the renewal. */
        public String GetVAS_RenewalTerm() { return (String)Get_Value("VAS_RenewalTerm"); }/** Set VAS_Terminate.
@param VAS_Terminate Date of termination of contract.  */
        public void SetVAS_Terminate(Boolean VAS_Terminate) { Set_Value("VAS_Terminate", VAS_Terminate); }/** Get VAS_Terminate.
@return Date of termination of contract.  */
        public Boolean IsVAS_Terminate() { Object oo = Get_Value("VAS_Terminate"); if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo); } return false; }/** Set VAS_TerminationDate.
@param VAS_TerminationDate Date of termination of contract. */
        public void SetVAS_TerminationDate(DateTime? VAS_TerminationDate) { Set_Value("VAS_TerminationDate", (DateTime?)VAS_TerminationDate); }/** Get VAS_TerminationDate.
@return Date of termination of contract. */
        public DateTime? GetVAS_TerminationDate() { return (DateTime?)Get_Value("VAS_TerminationDate"); }/** Set Termination Reason.
@param VAS_TerminationReason Reason for the termination of contract. */
        public void SetVAS_TerminationReason(String VAS_TerminationReason) { if (VAS_TerminationReason != null && VAS_TerminationReason.Length > 500) { log.Warning("Length > 500 - truncated"); VAS_TerminationReason = VAS_TerminationReason.Substring(0, 500); } Set_Value("VAS_TerminationReason", VAS_TerminationReason); }/** Get Termination Reason.
@return Reason for the termination of contract. */
        public String GetVAS_TerminationReason() { return (String)Get_Value("VAS_TerminationReason"); }
    }
}