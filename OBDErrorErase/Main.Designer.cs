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
        private TabPage ProfileTabBosch;
        private TabPage ProfileTabDelphi;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnError;
        private Label EraserLabelFilePath;
        private Label EraserLabelErrorCounter;
        private Button EraserButtonFileBrowse;
        private TextBox EraserTextboxProfileFilter;
        private ListBox EraserListProfiles;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private Label EraserLabelMapSelect;
        private Label EraserLabelPresetSelect;
        private ListView EraserListViewMapSelection;
        private DataGridView EditorDataGridViewBosch;
        private TextBox EditorTextboxBoschManualLength;
        private ComboBox EditorComboBoxBoschMapLengthAlgoSelect;
        private DataGridView EditorDataGridViewDelphi;
        private DataGridView EraserErrorPreview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public Button EditorButtonDuplicateProfile;
        public TabControl EditorTabControlProfileType;
        public Button EditorButtonFileBrowse;
        public ListBox EditorListSubprofiles;
        public Button EditorButtonSave;
        public DataGridView EditorErrorPreview;
        public TextBox EditorTextBoxComputerName;
        public ComboBox EditorDropdownManufacturer;
        public TextBox EditorTextboxProfileFilter;
        public Button EditorButtonProfileRemove;
        public Button EditorButtonNewProfile;
        public ListBox EditorListProfiles;
        public Label EditorLabelFilePath;
        public CheckBox EditorCheckboxFlipBytes;
        private Panel EraserPanelErrorPresets;
        public TableLayoutPanel EraserTableLayoutErrorPresets;
        public Button EraserButtonRefreshPresetList;
        public TextBox EraserTextboxErrorList;
        public Button EraserButtonRun;
    }
}