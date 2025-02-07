namespace VAdvantage.Model{
/** Generated Model - DO NOT CHANGE */
using System;using System.Text;using VAdvantage.DataBase;using VAdvantage.Common;using VAdvantage.Classes;using VAdvantage.Process;using VAdvantage.Model;using VAdvantage.Utility;using System.Data;/** Generated Model for AD_Field
 *  @author Raghu (Updated) 
 *  @version Vienna Framework 1.1.1 - $Id$ */
public class X_AD_Field : PO{public X_AD_Field (Context ctx, int AD_Field_ID, Trx trxName) : base (ctx, AD_Field_ID, trxName){/** if (AD_Field_ID == 0){SetAD_Field_ID (0);SetAD_Tab_ID (0);SetEntityType (null);// U
SetIsCentrallyMaintained (true);// Y
SetIsDisplayed (true);// Y
SetIsEncrypted (false);SetIsFieldOnly (false);SetIsHeading (false);SetIsReadOnly (false);SetIsSameLine (false);SetName (null);} */
}public X_AD_Field (Ctx ctx, int AD_Field_ID, Trx trxName) : base (ctx, AD_Field_ID, trxName){/** if (AD_Field_ID == 0){SetAD_Field_ID (0);SetAD_Tab_ID (0);SetEntityType (null);// U
SetIsCentrallyMaintained (true);// Y
SetIsDisplayed (true);// Y
SetIsEncrypted (false);SetIsFieldOnly (false);SetIsHeading (false);SetIsReadOnly (false);SetIsSameLine (false);SetName (null);} */
}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_Field (Context ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_Field (Ctx ctx, DataRow rs, Trx trxName) : base(ctx, rs, trxName){}/** Load Constructor 
@param ctx context
@param rs result set 
@param trxName transaction
*/
public X_AD_Field (Ctx ctx, IDataReader dr, Trx trxName) : base(ctx, dr, trxName){}/** Static Constructor 
 Set Table ID By Table Name
 added by ->Harwinder */
static X_AD_Field(){ Table_ID = Get_Table_ID(Table_Name); model = new KeyNamePair(Table_ID,Table_Name);}/** Serial Version No */
static long serialVersionUID = 28007047961198L;/** Last Updated Timestamp 8/29/2024 2:40:44 PM */
public static long updatedMS = 1724922644409L;/** AD_Table_ID=107 */
public static int Table_ID; // =107;
/** TableName=AD_Field */
public static String Table_Name="AD_Field";
protected static KeyNamePair model;protected Decimal accessLevel = new Decimal(4);/** AccessLevel
@return 4 - System 
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
public override String ToString(){StringBuilder sb = new StringBuilder ("X_AD_Field[").Append(Get_ID()).Append("]");return sb.ToString();}
/** AD_Action AD_Reference_ID=1000280 */
public static int AD_ACTION_AD_Reference_ID=1000280;/** Open Form = FOM */
public static String AD_ACTION_OpenForm = "FOM";/** Move to tab = MTT */
public static String AD_ACTION_MoveToTab = "MTT";/** Undo & Move To Tab = MTU */
public static String AD_ACTION_UndoMoveToTab = "MTU";/** Open tab as dialog = OTD */
public static String AD_ACTION_OpenTabAsDialog = "OTD";/** Open Window = WIW */
public static String AD_ACTION_OpenWindow = "WIW";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsAD_ActionValid (String test){return test == null || test.Equals("FOM") || test.Equals("MTT") || test.Equals("MTU") || test.Equals("OTD") || test.Equals("WIW");}/** Set Action.
@param AD_Action This field use for where to show the tab. */
public void SetAD_Action (String AD_Action){if (!IsAD_ActionValid(AD_Action))
throw new ArgumentException ("AD_Action Invalid value - " + AD_Action + " - Reference_ID=1000280 - FOM - MTT - MTU - OTD - WIW");if (AD_Action != null && AD_Action.Length > 3){log.Warning("Length > 3 - truncated");AD_Action = AD_Action.Substring(0,3);}Set_Value ("AD_Action", AD_Action);}/** Get Action.
@return This field use for where to show the tab. */
public String GetAD_Action() {return (String)Get_Value("AD_Action");}/** Set Action Group.
@param AD_ActionGroup_ID Key Column */
public void SetAD_ActionGroup_ID (int AD_ActionGroup_ID){if (AD_ActionGroup_ID <= 0) Set_Value ("AD_ActionGroup_ID", null);else
Set_Value ("AD_ActionGroup_ID", AD_ActionGroup_ID);}/** Get Action Group.
@return Key Column */
public int GetAD_ActionGroup_ID() {Object ii = Get_Value("AD_ActionGroup_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Action Name.
@param AD_ActionName Action name to be open on action button click. */
public void SetAD_ActionName (String AD_ActionName){if (AD_ActionName != null && AD_ActionName.Length > 255){log.Warning("Length > 255 - truncated");AD_ActionName = AD_ActionName.Substring(0,255);}Set_Value ("AD_ActionName", AD_ActionName);}/** Get Action Name.
@return Action name to be open on action button click. */
public String GetAD_ActionName() {return (String)Get_Value("AD_ActionName");}/** Set Column.
@param AD_Column_ID Column in the table */
public void SetAD_Column_ID (int AD_Column_ID){if (AD_Column_ID <= 0) Set_Value ("AD_Column_ID", null);else
Set_Value ("AD_Column_ID", AD_Column_ID);}/** Get Column.
@return Column in the table */
public int GetAD_Column_ID() {Object ii = Get_Value("AD_Column_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Field Section.
@param AD_FieldGroup_ID Logical grouping of fields */
public void SetAD_FieldGroup_ID (int AD_FieldGroup_ID){if (AD_FieldGroup_ID <= 0) Set_Value ("AD_FieldGroup_ID", null);else
Set_Value ("AD_FieldGroup_ID", AD_FieldGroup_ID);}/** Get Field Section.
@return Logical grouping of fields */
public int GetAD_FieldGroup_ID() {Object ii = Get_Value("AD_FieldGroup_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Field.
@param AD_Field_ID Field on a tab in a window */
public void SetAD_Field_ID (int AD_Field_ID){if (AD_Field_ID < 1) throw new ArgumentException ("AD_Field_ID is mandatory.");Set_ValueNoCheck ("AD_Field_ID", AD_Field_ID);}/** Get Field.
@return Field on a tab in a window */
public int GetAD_Field_ID() {Object ii = Get_Value("AD_Field_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Image.
@param AD_Image_ID Image or Icon */
public void SetAD_Image_ID (int AD_Image_ID){if (AD_Image_ID <= 0) Set_Value ("AD_Image_ID", null);else
Set_Value ("AD_Image_ID", AD_Image_ID);}/** Get Image.
@return Image or Icon */
public int GetAD_Image_ID() {Object ii = Get_Value("AD_Image_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Search Screen.
@param AD_InfoWindow_ID Info and search/select Window */
public void SetAD_InfoWindow_ID (int AD_InfoWindow_ID){if (AD_InfoWindow_ID <= 0) Set_Value ("AD_InfoWindow_ID", null);else
Set_Value ("AD_InfoWindow_ID", AD_InfoWindow_ID);}/** Get Search Screen.
@return Info and search/select Window */
public int GetAD_InfoWindow_ID() {Object ii = Get_Value("AD_InfoWindow_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** AD_Reference_ID AD_Reference_ID=1 */
public static int AD_REFERENCE_ID_AD_Reference_ID=1;/** Set Reference.
@param AD_Reference_ID System Reference and Validation */
public void SetAD_Reference_ID (int AD_Reference_ID){if (AD_Reference_ID <= 0) Set_Value ("AD_Reference_ID", null);else
Set_Value ("AD_Reference_ID", AD_Reference_ID);}/** Get Reference.
@return System Reference and Validation */
public int GetAD_Reference_ID() {Object ii = Get_Value("AD_Reference_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Tab.
@param AD_Tab_ID Tab within a Window */
public void SetAD_Tab_ID (int AD_Tab_ID){if (AD_Tab_ID < 1) throw new ArgumentException ("AD_Tab_ID is mandatory.");Set_ValueNoCheck ("AD_Tab_ID", AD_Tab_ID);}/** Get Tab.
@return Tab within a Window */
public int GetAD_Tab_ID() {Object ii = Get_Value("AD_Tab_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Data Validation.
@param AD_Val_Rule_ID Dynamic Validation Rule */
public void SetAD_Val_Rule_ID (int AD_Val_Rule_ID){if (AD_Val_Rule_ID <= 0) Set_Value ("AD_Val_Rule_ID", null);else
Set_Value ("AD_Val_Rule_ID", AD_Val_Rule_ID);}/** Get Data Validation.
@return Dynamic Validation Rule */
public int GetAD_Val_Rule_ID() {Object ii = Get_Value("AD_Val_Rule_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Action Params.
@param ActionParams Action Params */
public void SetActionParams (String ActionParams){if (ActionParams != null && ActionParams.Length > 1000){log.Warning("Length > 1000 - truncated");ActionParams = ActionParams.Substring(0,1000);}Set_Value ("ActionParams", ActionParams);}/** Get Action Params.
@return Action Params */
public String GetActionParams() {return (String)Get_Value("ActionParams");}/** Set Cell Space.
@param CellSpace Spacing From Previous Item */
public void SetCellSpace (int CellSpace){Set_Value ("CellSpace", CellSpace);}/** Get Cell Space.
@return Spacing From Previous Item */
public int GetCellSpace() {Object ii = Get_Value("CellSpace");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Column Width (Pixels).
@param ColumnWidth Define Column width for grid. */
public void SetColumnWidth (int ColumnWidth){Set_Value ("ColumnWidth", ColumnWidth);}/** Get Column Width (Pixels).
@return Define Column width for grid. */
public int GetColumnWidth() {Object ii = Get_Value("ColumnWidth");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Default Logic.
@param DefaultValue Default value hierarchy, separated by ; */
public void SetDefaultValue (String DefaultValue){if (DefaultValue != null && DefaultValue.Length > 2000){log.Warning("Length > 2000 - truncated");DefaultValue = DefaultValue.Substring(0,2000);}Set_Value ("DefaultValue", DefaultValue);}/** Get Default Logic.
@return Default value hierarchy, separated by ; */
public String GetDefaultValue() {return (String)Get_Value("DefaultValue");}/** Set Description.
@param Description Optional short description of the record */
public void SetDescription (String Description){if (Description != null && Description.Length > 255){log.Warning("Length > 255 - truncated");Description = Description.Substring(0,255);}Set_Value ("Description", Description);}/** Get Description.
@return Optional short description of the record */
public String GetDescription() {return (String)Get_Value("Description");}/** Set Display Length.
@param DisplayLength Length of the display */
public void SetDisplayLength (int DisplayLength){Set_Value ("DisplayLength", DisplayLength);}/** Get Display Length.
@return Length of the display */
public int GetDisplayLength() {Object ii = Get_Value("DisplayLength");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Display Logic.
@param DisplayLogic If the Field is displayed, the result determines if the field is actually displayed */
public void SetDisplayLogic (String DisplayLogic){if (DisplayLogic != null && DisplayLogic.Length > 2000){log.Warning("Length > 2000 - truncated");DisplayLogic = DisplayLogic.Substring(0,2000);}Set_Value ("DisplayLogic", DisplayLogic);}/** Get Display Logic.
@return If the Field is displayed, the result determines if the field is actually displayed */
public String GetDisplayLogic() {return (String)Get_Value("DisplayLogic");}
/** EntityType AD_Reference_ID=389 */
public static int ENTITYTYPE_AD_Reference_ID=389;/** Set Entity Type.
@param EntityType Dictionary Entity Type; Determines ownership and synchronization */
public void SetEntityType (String EntityType){if (EntityType.Length > 4){log.Warning("Length > 4 - truncated");EntityType = EntityType.Substring(0,4);}Set_Value ("EntityType", EntityType);}/** Get Entity Type.
@return Dictionary Entity Type; Determines ownership and synchronization */
public String GetEntityType() {return (String)Get_Value("EntityType");}/** Set Export.
@param Export_ID Export */
public void SetExport_ID (String Export_ID){if (Export_ID != null && Export_ID.Length > 100){log.Warning("Length > 100 - truncated");Export_ID = Export_ID.Substring(0,100);}Set_ValueNoCheck ("Export_ID", Export_ID);}/** Get Export.
@return Export */
public String GetExport_ID() {return (String)Get_Value("Export_ID");}/** Set Display Breadth.
@param FieldBreadth No. of rows of Field */
public void SetFieldBreadth (int FieldBreadth){Set_Value ("FieldBreadth", FieldBreadth);}/** Get Display Breadth.
@return No. of rows of Field */
public int GetFieldBreadth() {Object ii = Get_Value("FieldBreadth");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Field Group Default.
@param FieldGroupDefault Show item in field group by default */
public void SetFieldGroupDefault (Boolean FieldGroupDefault){Set_Value ("FieldGroupDefault", FieldGroupDefault);}/** Get Field Group Default.
@return Show item in field group by default */
public Boolean IsFieldGroupDefault() {Object oo = Get_Value("FieldGroupDefault");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Length.
@param FieldLength Length of the column in the database */
public void SetFieldLength (int FieldLength){Set_Value ("FieldLength", FieldLength);}/** Get Length.
@return Length of the column in the database */
public int GetFieldLength() {Object ii = Get_Value("FieldLength");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set HTML Style.
@param HTMLStyle HTML style for field */
public void SetHTMLStyle (String HTMLStyle){if (HTMLStyle != null && HTMLStyle.Length > 2000){log.Warning("Length > 2000 - truncated");HTMLStyle = HTMLStyle.Substring(0,2000);}Set_Value ("HTMLStyle", HTMLStyle);}/** Get HTML Style.
@return HTML style for field */
public String GetHTMLStyle() {return (String)Get_Value("HTMLStyle");}
/** HeaderHeadingOnly AD_Reference_ID=319 */
public static int HEADERHEADINGONLY_AD_Reference_ID=319;/** No = N */
public static String HEADERHEADINGONLY_No = "N";/** Yes = Y */
public static String HEADERHEADINGONLY_Yes = "Y";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsHeaderHeadingOnlyValid (String test){return test == null || test.Equals("N") || test.Equals("Y");}/** Set Show Header Heading Only.
@param HeaderHeadingOnly Display or hide Heading */
public void SetHeaderHeadingOnly (String HeaderHeadingOnly){if (!IsHeaderHeadingOnlyValid(HeaderHeadingOnly))
throw new ArgumentException ("HeaderHeadingOnly Invalid value - " + HeaderHeadingOnly + " - Reference_ID=319 - N - Y");if (HeaderHeadingOnly != null && HeaderHeadingOnly.Length > 1){log.Warning("Length > 1 - truncated");HeaderHeadingOnly = HeaderHeadingOnly.Substring(0,1);}Set_Value ("HeaderHeadingOnly", HeaderHeadingOnly);}/** Get Show Header Heading Only.
@return Display or hide Heading */
public String GetHeaderHeadingOnly() {return (String)Get_Value("HeaderHeadingOnly");}
/** HeaderIconOnly AD_Reference_ID=319 */
public static int HEADERICONONLY_AD_Reference_ID=319;/** No = N */
public static String HEADERICONONLY_No = "N";/** Yes = Y */
public static String HEADERICONONLY_Yes = "Y";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsHeaderIconOnlyValid (String test){return test == null || test.Equals("N") || test.Equals("Y");}/** Set Show Header Icon Only.
@param HeaderIconOnly Display or hide icon */
public void SetHeaderIconOnly (String HeaderIconOnly){if (!IsHeaderIconOnlyValid(HeaderIconOnly))
throw new ArgumentException ("HeaderIconOnly Invalid value - " + HeaderIconOnly + " - Reference_ID=319 - N - Y");if (HeaderIconOnly != null && HeaderIconOnly.Length > 1){log.Warning("Length > 1 - truncated");HeaderIconOnly = HeaderIconOnly.Substring(0,1);}Set_Value ("HeaderIconOnly", HeaderIconOnly);}/** Get Show Header Icon Only.
@return Display or hide icon */
public String GetHeaderIconOnly() {return (String)Get_Value("HeaderIconOnly");}
/** HeaderOverrideReference AD_Reference_ID=1 */
public static int HEADEROVERRIDEREFERENCE_AD_Reference_ID=1;/** Set Header Override Reference.
@param HeaderOverrideReference Display Reference type for field */
public void SetHeaderOverrideReference (int HeaderOverrideReference){Set_Value ("HeaderOverrideReference", HeaderOverrideReference);}/** Get Header Override Reference.
@return Display Reference type for field */
public int GetHeaderOverrideReference() {Object ii = Get_Value("HeaderOverrideReference");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Header Seq no..
@param HeaderSeqno Header Seq no. defines the order of fields in header panel. */
public void SetHeaderSeqno (Decimal? HeaderSeqno){Set_Value ("HeaderSeqno", (Decimal?)HeaderSeqno);}/** Get Header Seq no..
@return Header Seq no. defines the order of fields in header panel. */
public Decimal GetHeaderSeqno() {Object bd =Get_Value("HeaderSeqno");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Header Style.
@param HeaderStyle Change default Header Style */
public void SetHeaderStyle (String HeaderStyle){if (HeaderStyle != null && HeaderStyle.Length > 2000){log.Warning("Length > 2000 - truncated");HeaderStyle = HeaderStyle.Substring(0,2000);}Set_Value ("HeaderStyle", HeaderStyle);}/** Get Header Style.
@return Change default Header Style */
public String GetHeaderStyle() {return (String)Get_Value("HeaderStyle");}/** Set Comment.
@param Help Comment, Help or Hint */
public void SetHelp (String Help){if (Help != null && Help.Length > 2000){log.Warning("Length > 2000 - truncated");Help = Help.Substring(0,2000);}Set_Value ("Help", Help);}/** Get Comment.
@return Comment, Help or Hint */
public String GetHelp() {return (String)Get_Value("Help");}/** Set Centrally maintained.
@param IsCentrallyMaintained Information maintained in System Element table */
public void SetIsCentrallyMaintained (Boolean IsCentrallyMaintained){Set_Value ("IsCentrallyMaintained", IsCentrallyMaintained);}/** Get Centrally maintained.
@return Information maintained in System Element table */
public Boolean IsCentrallyMaintained() {Object oo = Get_Value("IsCentrallyMaintained");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}
/** IsCopy AD_Reference_ID=319 */
public static int ISCOPY_AD_Reference_ID=319;/** No = N */
public static String ISCOPY_No = "N";/** Yes = Y */
public static String ISCOPY_Yes = "Y";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsIsCopyValid (String test){return test == null || test.Equals("N") || test.Equals("Y");}/** Set Copy.
@param IsCopy Copy contents of this field using the Copy Record function. */
public void SetIsCopy (String IsCopy){if (!IsIsCopyValid(IsCopy))
throw new ArgumentException ("IsCopy Invalid value - " + IsCopy + " - Reference_ID=319 - N - Y");if (IsCopy != null && IsCopy.Length > 1){log.Warning("Length > 1 - truncated");IsCopy = IsCopy.Substring(0,1);}Set_Value ("IsCopy", IsCopy);}/** Get Copy.
@return Copy contents of this field using the Copy Record function. */
public String GetIsCopy() {return (String)Get_Value("IsCopy");}/** Set Default Focus.
@param IsDefaultFocus Field received the default focus */
public void SetIsDefaultFocus (Boolean IsDefaultFocus){Set_Value ("IsDefaultFocus", IsDefaultFocus);}/** Get Default Focus.
@return Field received the default focus */
public Boolean IsDefaultFocus() {Object oo = Get_Value("IsDefaultFocus");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Displayed.
@param IsDisplayed Determines, if this field is displayed */
public void SetIsDisplayed (Boolean IsDisplayed){Set_Value ("IsDisplayed", IsDisplayed);}/** Get Displayed.
@return Determines, if this field is displayed */
public Boolean IsDisplayed() {Object oo = Get_Value("IsDisplayed");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Encrypted.
@param IsEncrypted Display or Storage is encrypted */
public void SetIsEncrypted (Boolean IsEncrypted){Set_Value ("IsEncrypted", IsEncrypted);}/** Get Encrypted.
@return Display or Storage is encrypted */
public Boolean IsEncrypted() {Object oo = Get_Value("IsEncrypted");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Field Only.
@param IsFieldOnly Label is not displayed */
public void SetIsFieldOnly (Boolean IsFieldOnly){Set_Value ("IsFieldOnly", IsFieldOnly);}/** Get Field Only.
@return Label is not displayed */
public Boolean IsFieldOnly() {Object oo = Get_Value("IsFieldOnly");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Header Panel Item.
@param IsHeaderPanelItem Header Panel Item or Not */
public void SetIsHeaderPanelItem (Boolean IsHeaderPanelItem){Set_Value ("IsHeaderPanelItem", IsHeaderPanelItem);}/** Get Header Panel Item.
@return Header Panel Item or Not */
public Boolean IsHeaderPanelItem() {Object oo = Get_Value("IsHeaderPanelItem");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Heading only.
@param IsHeading Field without Column - Only label is displayed */
public void SetIsHeading (Boolean IsHeading){Set_Value ("IsHeading", IsHeading);}/** Get Heading only.
@return Field without Column - Only label is displayed */
public Boolean IsHeading() {Object oo = Get_Value("IsHeading");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Line Break.
@param IsLineBreak Start new Row */
public void SetIsLineBreak (Boolean IsLineBreak){Set_Value ("IsLineBreak", IsLineBreak);}/** Get Line Break.
@return Start new Row */
public Boolean IsLineBreak() {Object oo = Get_Value("IsLineBreak");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}
/** IsMandatoryUI AD_Reference_ID=319 */
public static int ISMANDATORYUI_AD_Reference_ID=319;/** No = N */
public static String ISMANDATORYUI_No = "N";/** Yes = Y */
public static String ISMANDATORYUI_Yes = "Y";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsIsMandatoryUIValid (String test){return test == null || test.Equals("N") || test.Equals("Y");}/** Set Mandatory UI.
@param IsMandatoryUI Data entry is required for data entry in the field */
public void SetIsMandatoryUI (String IsMandatoryUI){if (!IsIsMandatoryUIValid(IsMandatoryUI))
throw new ArgumentException ("IsMandatoryUI Invalid value - " + IsMandatoryUI + " - Reference_ID=319 - N - Y");if (IsMandatoryUI != null && IsMandatoryUI.Length > 1){log.Warning("Length > 1 - truncated");IsMandatoryUI = IsMandatoryUI.Substring(0,1);}Set_Value ("IsMandatoryUI", IsMandatoryUI);}/** Get Mandatory UI.
@return Data entry is required for data entry in the field */
public String GetIsMandatoryUI() {return (String)Get_Value("IsMandatoryUI");}/** Set Read Only.
@param IsReadOnly Field is read only */
public void SetIsReadOnly (Boolean IsReadOnly){Set_Value ("IsReadOnly", IsReadOnly);}/** Get Read Only.
@return Field is read only */
public Boolean IsReadOnly() {Object oo = Get_Value("IsReadOnly");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Same Line.
@param IsSameLine Displayed on same line as previous field */
public void SetIsSameLine (Boolean IsSameLine){Set_Value ("IsSameLine", IsSameLine);}/** Get Same Line.
@return Displayed on same line as previous field */
public Boolean IsSameLine() {Object oo = Get_Value("IsSameLine");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Selection Column.
@param IsSelectionColumn Is this column used for finding rows in windows */
public void SetIsSelectionColumn (Boolean IsSelectionColumn){Set_Value ("IsSelectionColumn", IsSelectionColumn);}/** Get Selection Column.
@return Is this column used for finding rows in windows */
public Boolean IsSelectionColumn() {Object oo = Get_Value("IsSelectionColumn");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}
/** MRIsDisplayed AD_Reference_ID=319 */
public static int MRISDISPLAYED_AD_Reference_ID=319;/** No = N */
public static String MRISDISPLAYED_No = "N";/** Yes = Y */
public static String MRISDISPLAYED_Yes = "Y";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsMRIsDisplayedValid (String test){return test == null || test.Equals("N") || test.Equals("Y");}/** Set Multi Row Displayed.
@param MRIsDisplayed Method to show-hide fields in Grid(Multi-Row) view.  */
public void SetMRIsDisplayed (String MRIsDisplayed){if (!IsMRIsDisplayedValid(MRIsDisplayed))
throw new ArgumentException ("MRIsDisplayed Invalid value - " + MRIsDisplayed + " - Reference_ID=319 - N - Y");if (MRIsDisplayed != null && MRIsDisplayed.Length > 1){log.Warning("Length > 1 - truncated");MRIsDisplayed = MRIsDisplayed.Substring(0,1);}Set_Value ("MRIsDisplayed", MRIsDisplayed);}/** Get Multi Row Displayed.
@return Method to show-hide fields in Grid(Multi-Row) view.  */
public String GetMRIsDisplayed() {return (String)Get_Value("MRIsDisplayed");}/** Set Multi-Row Sequence.
@param MRSeqNo Method of ordering fields in Multi-Row (Grid) View; lowest number comes first */
public void SetMRSeqNo (Decimal? MRSeqNo){Set_Value ("MRSeqNo", (Decimal?)MRSeqNo);}/** Get Multi-Row Sequence.
@return Method of ordering fields in Multi-Row (Grid) View; lowest number comes first */
public Decimal GetMRSeqNo() {Object bd =Get_Value("MRSeqNo");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Max Height.
@param MaxHeight Maximum Height in 1/72 if an inch - 0 = no restriction */
public void SetMaxHeight (int MaxHeight){Set_Value ("MaxHeight", MaxHeight);}/** Get Max Height.
@return Maximum Height in 1/72 if an inch - 0 = no restriction */
public int GetMaxHeight() {Object ii = Get_Value("MaxHeight");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Max Width.
@param MaxWidth Maximum Width in 1/72 if an inch - 0 = no restriction */
public void SetMaxWidth (int MaxWidth){Set_Value ("MaxWidth", MaxWidth);}/** Get Max Width.
@return Maximum Width in 1/72 if an inch - 0 = no restriction */
public int GetMaxWidth() {Object ii = Get_Value("MaxWidth");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** MobileListingFormat AD_Reference_ID=1000128 */
public static int MOBILELISTINGFORMAT_AD_Reference_ID=1000128;/** Header = 1 */
public static String MOBILELISTINGFORMAT_Header = "1";/** SubHeader = 2 */
public static String MOBILELISTINGFORMAT_SubHeader = "2";/** DateHeader = 3 */
public static String MOBILELISTINGFORMAT_DateHeader = "3";/** FooterNote = 4 */
public static String MOBILELISTINGFORMAT_FooterNote = "4";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsMobileListingFormatValid (String test){return test == null || test.Equals("1") || test.Equals("2") || test.Equals("3") || test.Equals("4");}/** Set Mobile Listing Format.
@param MobileListingFormat Mobile Listing Format */
public void SetMobileListingFormat (String MobileListingFormat){if (!IsMobileListingFormatValid(MobileListingFormat))
throw new ArgumentException ("MobileListingFormat Invalid value - " + MobileListingFormat + " - Reference_ID=1000128 - 1 - 2 - 3 - 4");if (MobileListingFormat != null && MobileListingFormat.Length > 1){log.Warning("Length > 1 - truncated");MobileListingFormat = MobileListingFormat.Substring(0,1);}Set_Value ("MobileListingFormat", MobileListingFormat);}/** Get Mobile Listing Format.
@return Mobile Listing Format */
public String GetMobileListingFormat() {return (String)Get_Value("MobileListingFormat");}/** Set Name.
@param Name Alphanumeric identifier of the entity */
public void SetName (String Name){if (Name == null) throw new ArgumentException ("Name is mandatory.");if (Name.Length > 60){log.Warning("Length > 60 - truncated");Name = Name.Substring(0,60);}Set_Value ("Name", Name);}/** Get Name.
@return Alphanumeric identifier of the entity */
public String GetName() {return (String)Get_Value("Name");}/** Get Record ID/ColumnName
@return ID/ColumnName pair */
public KeyNamePair GetKeyNamePair() {return new KeyNamePair(Get_ID(), GetName());}
/** ObscureType AD_Reference_ID=291 */
public static int OBSCURETYPE_AD_Reference_ID=291;/** Obscure Digits but last 4 = 904 */
public static String OBSCURETYPE_ObscureDigitsButLast4 = "904";/** Obscure Digits but first/last 4 = 944 */
public static String OBSCURETYPE_ObscureDigitsButFirstLast4 = "944";/** Obscure AlphaNumeric but last 4 = A04 */
public static String OBSCURETYPE_ObscureAlphaNumericButLast4 = "A04";/** Obscure AlphaNumeric but first/last 4 = A44 */
public static String OBSCURETYPE_ObscureAlphaNumericButFirstLast4 = "A44";/** Is test a valid value.
@param test testvalue
@returns true if valid **/
public bool IsObscureTypeValid (String test){return test == null || test.Equals("904") || test.Equals("944") || test.Equals("A04") || test.Equals("A44");}/** Set Obscure.
@param ObscureType Type of obscuring the data (limiting the display) */
public void SetObscureType (String ObscureType){if (!IsObscureTypeValid(ObscureType))
throw new ArgumentException ("ObscureType Invalid value - " + ObscureType + " - Reference_ID=291 - 904 - 944 - A04 - A44");if (ObscureType != null && ObscureType.Length > 3){log.Warning("Length > 3 - truncated");ObscureType = ObscureType.Substring(0,3);}Set_Value ("ObscureType", ObscureType);}/** Get Obscure.
@return Type of obscuring the data (limiting the display) */
public String GetObscureType() {return (String)Get_Value("ObscureType");}/** Set Selection Sequence.
@param SelectionSeqNo Sequence in Selection */
public void SetSelectionSeqNo (int SelectionSeqNo){Set_Value ("SelectionSeqNo", SelectionSeqNo);}/** Get Selection Sequence.
@return Sequence in Selection */
public int GetSelectionSeqNo() {Object ii = Get_Value("SelectionSeqNo");if (ii == null) return 0;return Convert.ToInt32(ii);}/** Set Sequence.
@param SeqNo Method of ordering elements; lowest number comes first */
public void SetSeqNo (Decimal? SeqNo){Set_Value ("SeqNo", (Decimal?)SeqNo);}/** Get Sequence.
@return Method of ordering elements; lowest number comes first */
public Decimal GetSeqNo() {Object bd =Get_Value("SeqNo");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Show Filter Option.
@param ShowFilterOption If checked, display top 5 values */
public void SetShowFilterOption (Boolean ShowFilterOption){Set_Value ("ShowFilterOption", ShowFilterOption);}/** Get Show Filter Option.
@return If checked, display top 5 values */
public Boolean IsShowFilterOption() {Object oo = Get_Value("ShowFilterOption");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Show Icon.
@param ShowIcon Display or hide icon */
public void SetShowIcon (Boolean ShowIcon){Set_Value ("ShowIcon", ShowIcon);}/** Get Show Icon.
@return Display or hide icon */
public Boolean IsShowIcon() {Object oo = Get_Value("ShowIcon");if (oo != null) { if (oo.GetType() == typeof(bool)) return Convert.ToBoolean(oo); return "Y".Equals(oo);}return false;}/** Set Record Sort No.
@param SortNo Determines in what order the records are displayed */
public void SetSortNo (Decimal? SortNo){Set_Value ("SortNo", (Decimal?)SortNo);}/** Get Record Sort No.
@return Determines in what order the records are displayed */
public Decimal GetSortNo() {Object bd =Get_Value("SortNo");if (bd == null) return Env.ZERO;return  Convert.ToDecimal(bd);}/** Set Style Logic.
@param StyleLogic Apply style on field based on logic. */
public void SetStyleLogic (String StyleLogic){if (StyleLogic != null && StyleLogic.Length > 2000){log.Warning("Length > 2000 - truncated");StyleLogic = StyleLogic.Substring(0,2000);}Set_Value ("StyleLogic", StyleLogic);}/** Get Style Logic.
@return Apply style on field based on logic. */
public String GetStyleLogic() {return (String)Get_Value("StyleLogic");}/** Set Tab Index.
@param TabIndex System will move focus to other tab as per defined tab Index number(start with Zero).  */
public void SetTabIndex (int TabIndex){Set_Value ("TabIndex", TabIndex);}/** Get Tab Index.
@return System will move focus to other tab as per defined tab Index number(start with Zero).  */
public int GetTabIndex() {Object ii = Get_Value("TabIndex");if (ii == null) return 0;return Convert.ToInt32(ii);}
/** ZoomWindow_ID AD_Reference_ID=284 */
public static int ZOOMWINDOW_ID_AD_Reference_ID=284;/** Set Zoom Window.
@param ZoomWindow_ID Set window for the zoom record. */
public void SetZoomWindow_ID (int ZoomWindow_ID){if (ZoomWindow_ID <= 0) Set_Value ("ZoomWindow_ID", null);else
Set_Value ("ZoomWindow_ID", ZoomWindow_ID);}/** Get Zoom Window.
@return Set window for the zoom record. */
public int GetZoomWindow_ID() {Object ii = Get_Value("ZoomWindow_ID");if (ii == null) return 0;return Convert.ToInt32(ii);}}
}