namespace VAdvantage.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for AD_SurveyAssignment
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
    public class X_AD_SurveyAssignment : PO
    {
        public X_AD_SurveyAssignment(Context ctx, int AD_SurveyAssignment_ID, Trx trxName) : base(ctx, AD_SurveyAssignment_ID, trxName)
        {/** if (AD_SurveyAssignment_ID == 0){SetAD_SurveyAssignment_ID (0);SetAD_Table_ID (0);} */
        }
        public X_AD_SurveyAssignment(Ctx ctx, int AD_SurveyAssignment_ID, Trx trxName) : base(ctx, AD_SurveyAssignment_ID, trxName)
        {/** if (AD_SurveyAssignment_ID == 0){SetAD_SurveyAssignment_ID (0);SetAD_Table_ID (0);} */
        }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_AD_SurveyAssignment(Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_AD_SurveyAssignment(Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName) { }/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
        public X_AD_SurveyAssignment(Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName) { }/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
        static X_AD_SurveyAssignment() { Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID, Table_Name); }/** Serial Version No */
        static long serialVersionUID = 28023904035270L;/** Last Updated Timestamp 3/12/2025 4:55:18 PM */
        public static long updatedMS = 1741778718481L;/** AD_Table_ID=1001174 */
        public static int Table_ID; // =1001174;
        /** TableName=AD_SurveyAssignment */
        public static String Table_Name = "AD_SurveyAssignment";
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
        public override String ToString() { StringBuilder sb = new StringBuilder("X_AD_SurveyAssignment[").Append(Get_ID()).Append("]"); return sb.ToString(); }/** Set Checklist Assignment.
@param AD_SurveyAssignment_ID Checklist Assignment */
        public void SetAD_SurveyAssignment_ID(int AD_SurveyAssignment_ID) { if (AD_SurveyAssignment_ID < 1) throw new ArgumentException("AD_SurveyAssignment_ID is mandatory."); Set_ValueNoCheck("AD_SurveyAssignment_ID", AD_SurveyAssignment_ID); }/** Get Checklist Assignment.
@return Checklist Assignment */
        public int GetAD_SurveyAssignment_ID() { Object ii = Get_Value("AD_SurveyAssignment_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Checklist.
@param AD_Survey_ID A Checklist is generally a series of specific questions that are asked as part of an overall survey. */
        public void SetAD_Survey_ID(int AD_Survey_ID)
        {
            if (AD_Survey_ID <= 0) Set_Value("AD_Survey_ID", null);
            else
                Set_Value("AD_Survey_ID", AD_Survey_ID);
        }/** Get Checklist.
@return A Checklist is generally a series of specific questions that are asked as part of an overall survey. */
        public int GetAD_Survey_ID() { Object ii = Get_Value("AD_Survey_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Tab.
@param AD_Tab_ID Tab within a Window */
        public void SetAD_Tab_ID(int AD_Tab_ID)
        {
            if (AD_Tab_ID <= 0) Set_Value("AD_Tab_ID", null);
            else
                Set_Value("AD_Tab_ID", AD_Tab_ID);
        }/** Get Tab.
@return Tab within a Window */
        public int GetAD_Tab_ID() { Object ii = Get_Value("AD_Tab_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Table/View.
@param AD_Table_ID Database Table information */
        public void SetAD_Table_ID(int AD_Table_ID) { if (AD_Table_ID < 1) throw new ArgumentException("AD_Table_ID is mandatory."); Set_Value("AD_Table_ID", AD_Table_ID); }/** Get Table/View.
@return Database Table information */
        public int GetAD_Table_ID() { Object ii = Get_Value("AD_Table_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Screen.
@param AD_Window_ID Data entry or display window */
        public void SetAD_Window_ID(int AD_Window_ID)
        {
            if (AD_Window_ID <= 0) Set_Value("AD_Window_ID", null);
            else
                Set_Value("AD_Window_ID", AD_Window_ID);
        }/** Get Screen.
@return Data entry or display window */
        public int GetAD_Window_ID() { Object ii = Get_Value("AD_Window_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }/** Set Document Type.
@param C_DocType_ID Document type or rules */
        public void SetC_DocType_ID(int C_DocType_ID)
        {
            if (C_DocType_ID <= 0) Set_Value("C_DocType_ID", null);
            else
                Set_Value("C_DocType_ID", C_DocType_ID);
        }/** Get Document Type.
@return Document type or rules */
        public int GetC_DocType_ID() { Object ii = Get_Value("C_DocType_ID"); if (ii == null) return 0; return Convert.ToInt32(ii); }
        /** DocAction AD_Reference_ID=1000605 */
        public static int DOCACTION_AD_Reference_ID = 1000605;/** Complete = CO */
        public static String DOCACTION_Complete = "CO";/** Prepare = PR */
        public static String DOCACTION_Prepare = "PR";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
        public bool IsDocActionValid(String test) { return test == null || test.Equals("CO") || test.Equals("PR"); }/** Set Document Action.
@param DocAction The targeted status of the document */
        public void SetDocAction(String DocAction)
        {
            if (!IsDocActionValid(DocAction))
                throw new ArgumentException("DocAction Invalid value - " + DocAction + " - Reference_ID=1000605 - CO - PR"); if (DocAction != null && DocAction.Length > 2) { log.Warning("Length > 2 - truncated"); DocAction = DocAction.Substring(0, 2); }
            Set_Value("DocAction", DocAction);
        }/** Get Document Action.
@return The targeted status of the document */
        public String GetDocAction() { return (String)Get_Value("DocAction"); }/** Set Export.
@param Export_ID Export */
        public void SetExport_ID(String Export_ID) { if (Export_ID != null && Export_ID.Length > 50) { log.Warning("Length > 50 - truncated"); Export_ID = Export_ID.Substring(0, 50); } Set_Value("Export_ID", Export_ID); }/** Get Export.
@return Export */
        public String GetExport_ID() { return (String)Get_Value("Export_ID"); }/** Set  Show based on Condition.
@param IsConditionalChecklist  Show based on Condition for selected table fields in child tab (Condition) when submitting the survey list. */
        public void SetIsConditionalChecklist(Boolean IsConditionalChecklist) { Set_Value("IsConditionalChecklist", IsConditionalChecklist); }/** Get  Show based on Condition.
@return  Show based on Condition for selected table fields in child tab (Condition) when submitting the survey list. */
        public Boolean IsConditionalChecklist() { Object oo = Get_Value("IsConditionalChecklist"); if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo); } return false; }/** Set IsDocAction.
@param IsDocAction IsDocAction */
        public void SetIsDocAction(Boolean IsDocAction) { Set_Value("IsDocAction", IsDocAction); }/** Get IsDocAction.
@return IsDocAction */
        public Boolean IsDocAction() { Object oo = Get_Value("IsDocAction"); if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo); } return false; }/** Set Questions Per Page.
@param QuestionsPerPage Questions Per Page */
        public void SetQuestionsPerPage(Decimal? QuestionsPerPage) { Set_Value("QuestionsPerPage", (Decimal?)QuestionsPerPage); }/** Get Questions Per Page.
@return Questions Per Page */
        public Decimal GetQuestionsPerPage() { Object bd = Get_Value("QuestionsPerPage"); if (bd == null) return Env.ZERO; return Convert.ToDecimal(bd); }/** Set Show All Questions.
@param ShowAllQuestions Show All Questions */
        public void SetShowAllQuestions(Boolean ShowAllQuestions) { Set_Value("ShowAllQuestions", ShowAllQuestions); }/** Get Show All Questions.
@return Show All Questions */
        public Boolean IsShowAllQuestions() { Object oo = Get_Value("ShowAllQuestions"); if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo); } return false; }
        /** SurveyListFor AD_Reference_ID=1000604 */
        public static int SURVEYLISTFOR_AD_Reference_ID = 1000604;/** DocType = DT */
        public static String SURVEYLISTFOR_DocType = "DT";/** Window = WD */
        public static String SURVEYLISTFOR_Window = "WD";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
        public bool IsSurveyListForValid(String test) { return test == null || test.Equals("DT") || test.Equals("WD"); }/** Set SurveyListFor.
@param SurveyListFor SurveyListFor */
        public void SetSurveyListFor(String SurveyListFor)
        {
            if (!IsSurveyListForValid(SurveyListFor))
                throw new ArgumentException("SurveyListFor Invalid value - " + SurveyListFor + " - Reference_ID=1000604 - DT - WD"); if (SurveyListFor != null && SurveyListFor.Length > 2) { log.Warning("Length > 2 - truncated"); SurveyListFor = SurveyListFor.Substring(0, 2); }
            Set_Value("SurveyListFor", SurveyListFor);
        }/** Get SurveyListFor.
@return SurveyListFor */
        public String GetSurveyListFor() { return (String)Get_Value("SurveyListFor"); }
    }
}