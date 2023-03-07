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
        private Panel EraserPanelErrorPresets;
        public TableLayoutPanel EraserTableLayoutErrorPresets;
        public TextBox EraserTextboxErrorList;
        private Label EraserLabelPresetSelect;
        private Label EraserLabelMapSelect;
        public Button EraserButtonRefreshPresetList;
        public Label EraserLabelErrorCounter;
        public Button EraserButtonRun;
        public ComboBox EditorComboBoxProfileType;
        public CheckBox MainCheckboxFlipBytes;
        public ListBox EditorListSubprofiles;
        public TextBox EditorTextBoxComputerName;
        public ComboBox EditorDropdownManufacturer;
        public Button MainButtonNewProfile;
        public Button MainButtonRemoveProfile;
        public Button MainButtonDuplicateProfile;
        public DataGridView MainDataGridFilePreview;
        private DataGridViewTextBoxColumn DataGridViewFilePreviewColumnAddress;
        private DataGridViewTextBoxColumn DataGridViewFilePreviewColumnError;
        public Label MainLabelBinaryFilename;
        public Button MainButtonFileBrowse;
        public TextBox MainTextboxProfileFilter;
        public ListBox MainListProfiles;
        private Panel EraserPanelMapSelector;
        public TableLayoutPanel EraserTableLayoutMapSelector;
        private Label EditorLabelProfileTypeSelect;
        private Label EditorLabelSubprofiles;
        private Label EditorLabelName;
        private Label EditorLabelManufacturer;
        public Label MainLabelPreviewFile;
        private Label EditorLabelProfileSettings;
        public Button EditorButtonDuplicateSubProfile;
        public Button EditorButtonRemoveSubProfile;
        private GroupBox EditorGroupBox;
        public Label MainLabelLoadedBinaryFile;
        public CheckBox EraserCheckBoxSelectAllMaps;
        public TabControl MainTabControl;
        public TabPage EraserTabPage;
        public TabPage EditorTabPage;
        public Panel EditorPanelEditFrame;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}