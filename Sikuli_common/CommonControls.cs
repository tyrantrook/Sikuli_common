namespace Sikuli_common
{
    class Common_Controls
    {
        // Uninitialized var
        private static string Uninit()
        {
            return "uninit";
        }

        #region Universal
        // The ID of the SysListView control that contains the records in the list
        private static int ListControlID()
        {
            return 1424;
        }

        // The ID of the ADD control on the list
        private static int AddButtonID()
        {
            return 1130;
        }

        // The ID of the DELETE control on the list
        private static int DeleteControlID()
        {
            return 1131;
        }

        // The ID of the EDIT button on the list
        private static int EditButtonID()
        {
            return 1132;
        }

        // The ID of the COPY button on the list
        private static int CopyButtonID()
        {
            return 1287;
        }
        // The ID of the control that saves the editor and closes it(also known as the Select button)
        private static int EditorSaveID()
        {
            return 1;
        }

        // The ID of the Export button on the list
        private static int ExportButtonID()
        {
            return 1325;
        }

        // The ID of the SysListView in the Overwrite Changes dialog
        private static string OverwriteChangesListViewID()
        {
            return "[CLASS:SysHeader32;INSTANCE:1]";
        }
        #endregion Universal

        #region Unified Lists

        // The ID of the FILTER button on the list
        private static int UnifiedFilterButtonControlID()
        {
            return 2760;
        }

        // The ID of the control to enter a record name to search for
        private static int UnifiedFilterFieldControlID()
        {
            return 1001;
        }

        // The ID of the ID field on the list
        private static int UnifiedIDControlID()
        {
            return 1138;
        }

        // The ID of the CLEAR FILTERS button on the list
        private static int UnifiedClearFiltersControlID()
        {
            return 2761;
        }

        //  The ID of the CLOSE button on the list
        private static int UnifiedCloseID()
        {
            return 2;
        }
        private static int UnifiedSQLID()
        {
            return 3153;
        }
        #endregion Unified Lists

        #region Unified-Master-Detail Lists

        private static int UMDFilterButtonControlID()
        {
            return 2619;
        }

        private static int UMDFilterFieldControlID()
        {
            return 1001;
        }

        private static int UMDSaveID()
        {
            return 4901;
        }

        private static int UMDSaveAndCloseID()
        {
            return 4902;
        }
        #endregion Unified-Master-Detail Lists

        #region Exporter Column Picker/Flag Picker

        // The ID for the SetAllFlags button
        private static int SetAllFlags()
        {
            return 36001;
        }

        //  The ID of the Listbox that contains the Export Categories
        private static int ExportListControlID()
        {
            return 36003;
        }

        //  The ID for the Flag Name Filter field.
        private static int FlagNameFilterField()
        {
            return 36004;
        }

        // The ID for the ListView where the flags are displayed.
        private static int FlagListViewID()
        {
            return 36005;
        }

        // The ID for the filter button in the Flag Picker.
        private static int FlagFilter()
        {
            return 36006;
        }

        #endregion Exporter Column Picker/Flag Picker

        #region Misc

        private static string DesignBar()
        {
            return "[CLASS:ToolbarWindow32; INSTANCE:2]";
        }

        private static int AttemptCount()
        {
            return 4;
        }

        #endregion Misc

        #region Return Codes

        //  Return code for function failure
        private static int FAILURE()
        {
            return -1;
        }

        //  Return code for function success
        private static int SUCCESS()
        {
            return 0;
        }

        #endregion Return Codes

        #region Window Names
        private static string UniLogWindow()
        {
            return "Universal Login";
        }

        private static string WoWMainWindow()
        {
            return "World Of Warcraft";
        }

        private static string WoWMainWindowSchema99()
        {
            return "World Of Warcraft Editor - Data 99.";
        }

        private static string WorldToolWindow()
        {
            return "World";
        }

        private static string FindListWindow()
        {
            return "Find List/Editor";
        }

        private static string ConfirmDelWindow()
        {
            return "Confirm Delete";
        }

        private static string ItemDelWindow()
        {
            return "WOWEdit - Item Deletion";
        }

        private static string ItemDelRuleWindow()
        {
            return "Item Deletion Rule";
        }

        private static string ExportResultSuccWindow()
        {
            return "Export Results: Success";
        }

        private static string ImportResultSuccWindow()
        {
            return "Import Results: Success";
        }

        private static string ThumbnailPickerWindow()
        {
            return "Thumbnail Picker";
        }

        private static string UndoCheckoutWindow()
        {
            return "WoWEdit - Undo Checkout";
        }

        private static string RowCountWindow()
        {
            return "WoWEdit - Row Count";
        }

        private static string LimitDataPropWindow()
        {
            return "Limit Data Propagation";
        }

        private static string QuestMainWindow()
        {
            return "Quest Main";
        }

        private static string QuestPOIBlobWindow()
        {
            return "Quest POI Blob";
        }

        private static string SpellScriptEditorWindow()
        {
            return "Spell Script Editor";
        }

        private static string SpellScriptTypeWarningWindow()
        {
            return "WoWEdit - Spell Script Editor";
        }

        private static string SkillLineAbilityWindow()
        {
            return "Skill Line Ability (";
        }

        private static string SkillLineRaceClassWindow()
        {
            return "Skill Line Race/Class Info (99.0.0)";
        }

        private static string OverwriteChangesWindow()
        {
            return "Overwrite Future Patches";
        }

        #endregion Window Names

        #region Setup for use in _PerformActionWithRetry($WindowActivateAndRetry)
        private static int[] ArgsUniLog = { 1 };
        private static int[] ArgsWoW = { 1 };
        private static int[] ArgsWoWSchema99 = { 1 };
        private static int[] ArgsWorldTool = { 1 };
        private static int[] ArgsFindList = { 1 };
        private static int[] ArgsWoWEditItemDel = { 1 };
        private static int[] ArgsItemDelRule = { 1 };
        private static int[] ArgsExportResultWindow = { 1 };
        private static int[] ArgsImportResultWindow = { 1 };
        private static int[] ArgsThumbnailPicker = { 1 };
        private static int[] ArgsUndoCheckout = { 1 };
        private static int[] ArgsRowCount = { 1 };
        private static int[] ArgsLimitDataProp = { 1 };
        private static int[] ArgsQuestMain = { 1 };
        private static int[] ArgsQuestPOIBlob = { 1 };
        private static int[] ArgsSpellScriptEditor = { 1 };
        private static int[] ArgsSpellScriptTypeWarningWindow = { 1 };
        private static int[] ArgsSkillLineAbility = { 1 };
        private static int[] ArgsSkillLineRaceClass = { 1 };

        //if ArgsUniLog = 0 then return UniLogWindow; }
        //private static int[] ArgsWoW[0] () { return WoWMainWindow; }
        //private static int[] ArgsWoWSchema99[0] () { return  $WoWMainWindowSchema99
        //private static int[] ArgsWorldTool[0] () { return  $WorldToolWindow
        //private static int[] ArgsFindList[0] () { return  $FindListWindow
        //private static int[] ArgsWoWEditItemDel[0] () { return  $ItemDelWindow
        //private static int[] ArgsItemDelRule[0] () { return  $ItemDelRuleWindow
        //private static int[] ArgsExportResultWindow[0] () { return  $ExportResultSuccWindow
        //private static int[] ArgsImportResultWindow[0] () { return  $ImportResultSuccWindow
        //private static int[] ArgsThumbnailPicker[0] () { return  $ThumbnailPickerWindow
        //private static int[] ArgsUndoCheckout[0] () { return  $UndoCheckoutWindow
        //private static int[] ArgsRowCount[0] () { return  $RowCountWindow
        //private static int[] ArgsLimitDataProp[0] () { return  $LimitDataPropWindow
        //private static int[] ArgsQuestMain[0] () { return  $QuestMainWindow
        //private static int[] ArgsQuestPOIBlob[0] () { return  $QuestPOIBlobWindow
        //private static int[] ArgsSpellScriptEditor[0] () { return  $SpellScriptEditorWindow
        //private static int[] ArgsSpellScriptTypeWarningWindow[0] () { return  $SpellScriptTypeWarningWindow
        //private static int[] ArgsSkillLineAbility[0] () { return  $SkillLineAbilityWindow
        //private static int[] ArgsSkillLineRaceClass[0] () { return  $SkillLineRaceClassWindow

        #endregion Setup for use in _PerformActionWithRetry($WindowActivateAndRetry)

        #region Setup for use in _PerformActionWithRetry($WindowActivateAndRetry2)

        private static int[] ArgsWoWSchema2_99 = { 2 };
        //private static int[] ArgsWoWSchema2_99 = [0]() { return  $WoWMainWindowSchema99
        //private static int[] ArgsWoWSchema2_99[1]() { return  59648 }

        #endregion Setup for use in _PerformActionWithRetry($WindowActivateAndRetry2)

        #region User Credentials
        private static string UserName()
        {
            return Uninit();
        }
        private static string UserPW()
        {
            return Uninit();
        }

        #endregion User Credentials

        #region Build Path Data
        private static string BuildPath()
        {
            return Uninit();
        }
        private static string BuildBranch()
        {
            return Uninit();
        }
        private static string BuildNum()
        {
            return Uninit();
        }

        #endregion Build Path Data
    }
}
