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

        private TabControl TabControl;
        private TabPage EraserTabPage;
        private Panel EraserPanelErrorPresets;
        public TableLayoutPanel EraserTableLayoutErrorPresets;
        public TextBox EraserTextboxErrorList;
        private Label EraserLabelPresetSelect;
        private Label EraserLabelMapSelect;
        public Button EraserButtonRefreshPresetList;
        public Label EraserLabelErrorCounter;
        public Button EraserButtonRun;
        private TabPage EditorTabPage;
        public ComboBox EditorComboBoxProfileType;
        public CheckBox EditorCheckboxFlipBytes;
        public ListBox EditorListSubprofiles;
        public TextBox EditorTextBoxComputerName;
        public ComboBox EditorDropdownManufacturer;
        private TableLayoutPanel TableLayoutPanelProfileButtons;
        public Button EditorButtonNewProfile;
        public Button EditorButtonRemoveProfile;
        public Button EditorButtonDuplicateProfile;
        public DataGridView EraserErrorPreview;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public Label EraserLabelFilePath;
        public Button EraserButtonFileBrowse;
        public TextBox EraserTextboxProfileFilter;
        public ListBox EraserListProfiles;
        private Panel panel1;
        public TableLayoutPanel tableLayoutPanel2;
        private CheckBox EraserCheckBoxSelectAllMaps;
        private CheckBox EraserCheckBoxSelectAllPresets;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public Label label5;
        private Label label6;
        public Button EditorButtonDuplicateSubProfile;
        public Button EditorButtonRemoveSubProfile;
    }
}