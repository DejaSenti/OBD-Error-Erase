namespace OBDErrorErase
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private TabPage TabErrorEraser;
        private Button EditorButtonDuplicateProfile;
        private TabControl EditorTabControlProfileType;
        private TabPage ProfileTabBosch;
        private TabPage ProfileTabDelphi;
        private ListBox EditorListSubprofiles;
        private Button EditorButtonSave;
        private DataGridView EditorErrorPreview;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnError;
        private TextBox EditorTextBoxComputerName;
        private ComboBox EditorDropdownManufacturer;
        private TextBox EditorTextboxProfileFilter;
        private Button EditorButtonProfileRemove;
        private Button EditorButtonNewProfile;
        private ListBox EditorListProfiles;
        private Label EraserLabelFilePath;
        private Label EraserLabelErrorCounter;
        private Button EraserButtonFileBrowse;
        private Button EraserButtonRun;
        private TextBox EraserTextboxProfileFilter;
        private ListBox EraserListProfiles;
        private Label EditorLabelFilePath;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private Button EraserButtonAddPreset;
        private Label EraserLabelMapSelect;
        private Label EraserLabelPresetSelect;
        private ListView EraserListViewErrorPresetSelection;
        private ListView EraserListViewMapSelection;
        private TextBox EraserTextboxErrorList;
        private DataGridView EditorDataGridViewBosch;
        private TextBox EditorTextboxBoschManualLength;
        private ComboBox EditorComboBoxBoschMapLengthAlgoSelect;
        private DataGridView EditorDataGridViewDelphi;
        private CheckBox EditorCheckboxFlipBytes;
        private DataGridView EraserErrorPreview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public Button EditorButtonFileBrowse;
    }
}