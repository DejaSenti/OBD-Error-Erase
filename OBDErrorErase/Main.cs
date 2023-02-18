namespace OBDErrorErase
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabErrorEraser = new System.Windows.Forms.TabPage();
            this.EraserPanelErrorPresets = new System.Windows.Forms.Panel();
            this.EraserTableLayoutErrorPresets = new System.Windows.Forms.TableLayoutPanel();
            this.EraserErrorPreview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EraserTextboxErrorList = new System.Windows.Forms.TextBox();
            this.EraserListViewMapSelection = new System.Windows.Forms.ListView();
            this.EraserLabelPresetSelect = new System.Windows.Forms.Label();
            this.EraserLabelMapSelect = new System.Windows.Forms.Label();
            this.EraserButtonRefreshPresetList = new System.Windows.Forms.Button();
            this.EraserLabelFilePath = new System.Windows.Forms.Label();
            this.EraserLabelErrorCounter = new System.Windows.Forms.Label();
            this.EraserButtonFileBrowse = new System.Windows.Forms.Button();
            this.EraserButtonRun = new System.Windows.Forms.Button();
            this.EraserTextboxProfileFilter = new System.Windows.Forms.TextBox();
            this.EraserListProfiles = new System.Windows.Forms.ListBox();
            this.TabProfileEditor = new System.Windows.Forms.TabPage();
            this.EditorComboBoxProfileType = new System.Windows.Forms.ComboBox();
            this.EditorButtonRemoveProfile = new System.Windows.Forms.Button();
            this.EditorButtonRemoveSubProfile = new System.Windows.Forms.Button();
            this.EditorCheckboxFlipBytes = new System.Windows.Forms.CheckBox();
            this.EditorLabelFilePath = new System.Windows.Forms.Label();
            this.EditorButtonDuplicateSubProfile = new System.Windows.Forms.Button();
            this.EditorTabControlProfileType = new System.Windows.Forms.TabControl();
            this.ProfileTabBosch = new System.Windows.Forms.TabPage();
            this.EditorTextboxBoschManualLength = new System.Windows.Forms.TextBox();
            this.EditorComboBoxBoschMapLengthAlgoSelect = new System.Windows.Forms.ComboBox();
            this.EditorDataGridViewBosch = new System.Windows.Forms.DataGridView();
            this.ProfileTabDelphi = new System.Windows.Forms.TabPage();
            this.EditorDataGridViewDelphi = new System.Windows.Forms.DataGridView();
            this.EditorButtonFileBrowse = new System.Windows.Forms.Button();
            this.EditorListSubprofiles = new System.Windows.Forms.ListBox();
            this.EditorButtonSave = new System.Windows.Forms.Button();
            this.EditorErrorPreview = new System.Windows.Forms.DataGridView();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnError = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditorTextBoxComputerName = new System.Windows.Forms.TextBox();
            this.EditorDropdownManufacturer = new System.Windows.Forms.ComboBox();
            this.EditorTextboxProfileFilter = new System.Windows.Forms.TextBox();
            this.EditorButtonDuplicateProfile = new System.Windows.Forms.Button();
            this.EditorButtonNewProfile = new System.Windows.Forms.Button();
            this.EditorListProfiles = new System.Windows.Forms.ListBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TabControlMain.SuspendLayout();
            this.TabErrorEraser.SuspendLayout();
            this.EraserPanelErrorPresets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EraserErrorPreview)).BeginInit();
            this.TabProfileEditor.SuspendLayout();
            this.EditorTabControlProfileType.SuspendLayout();
            this.ProfileTabBosch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorDataGridViewBosch)).BeginInit();
            this.ProfileTabDelphi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorDataGridViewDelphi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorErrorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.TabErrorEraser);
            this.TabControlMain.Controls.Add(this.TabProfileEditor);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(1198, 725);
            this.TabControlMain.TabIndex = 0;
            // 
            // TabErrorEraser
            // 
            this.TabErrorEraser.Controls.Add(this.EraserPanelErrorPresets);
            this.TabErrorEraser.Controls.Add(this.EraserErrorPreview);
            this.TabErrorEraser.Controls.Add(this.EraserTextboxErrorList);
            this.TabErrorEraser.Controls.Add(this.EraserListViewMapSelection);
            this.TabErrorEraser.Controls.Add(this.EraserLabelPresetSelect);
            this.TabErrorEraser.Controls.Add(this.EraserLabelMapSelect);
            this.TabErrorEraser.Controls.Add(this.EraserButtonRefreshPresetList);
            this.TabErrorEraser.Controls.Add(this.EraserLabelFilePath);
            this.TabErrorEraser.Controls.Add(this.EraserLabelErrorCounter);
            this.TabErrorEraser.Controls.Add(this.EraserButtonFileBrowse);
            this.TabErrorEraser.Controls.Add(this.EraserButtonRun);
            this.TabErrorEraser.Controls.Add(this.EraserTextboxProfileFilter);
            this.TabErrorEraser.Controls.Add(this.EraserListProfiles);
            this.TabErrorEraser.Location = new System.Drawing.Point(4, 24);
            this.TabErrorEraser.Name = "TabErrorEraser";
            this.TabErrorEraser.Padding = new System.Windows.Forms.Padding(3);
            this.TabErrorEraser.Size = new System.Drawing.Size(1190, 697);
            this.TabErrorEraser.TabIndex = 0;
            this.TabErrorEraser.Text = "Error Eraser";
            this.TabErrorEraser.UseVisualStyleBackColor = true;
            // 
            // EraserPanelErrorPresets
            // 
            this.EraserPanelErrorPresets.AutoScroll = true;
            this.EraserPanelErrorPresets.AutoScrollMinSize = new System.Drawing.Size(250, 0);
            this.EraserPanelErrorPresets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EraserPanelErrorPresets.Controls.Add(this.EraserTableLayoutErrorPresets);
            this.EraserPanelErrorPresets.Location = new System.Drawing.Point(629, 308);
            this.EraserPanelErrorPresets.Name = "EraserPanelErrorPresets";
            this.EraserPanelErrorPresets.Size = new System.Drawing.Size(303, 376);
            this.EraserPanelErrorPresets.TabIndex = 42;
            // 
            // EraserTableLayoutErrorPresets
            // 
            this.EraserTableLayoutErrorPresets.AutoScroll = true;
            this.EraserTableLayoutErrorPresets.AutoSize = true;
            this.EraserTableLayoutErrorPresets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EraserTableLayoutErrorPresets.ColumnCount = 1;
            this.EraserTableLayoutErrorPresets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EraserTableLayoutErrorPresets.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EraserTableLayoutErrorPresets.Dock = System.Windows.Forms.DockStyle.Top;
            this.EraserTableLayoutErrorPresets.Location = new System.Drawing.Point(0, 0);
            this.EraserTableLayoutErrorPresets.MaximumSize = new System.Drawing.Size(300, 0);
            this.EraserTableLayoutErrorPresets.MinimumSize = new System.Drawing.Size(300, 75);
            this.EraserTableLayoutErrorPresets.Name = "EraserTableLayoutErrorPresets";
            this.EraserTableLayoutErrorPresets.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.EraserTableLayoutErrorPresets.RowCount = 1;
            this.EraserTableLayoutErrorPresets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EraserTableLayoutErrorPresets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EraserTableLayoutErrorPresets.Size = new System.Drawing.Size(300, 75);
            this.EraserTableLayoutErrorPresets.TabIndex = 42;
            // 
            // EraserErrorPreview
            // 
            this.EraserErrorPreview.AllowUserToAddRows = false;
            this.EraserErrorPreview.AllowUserToDeleteRows = false;
            this.EraserErrorPreview.AllowUserToResizeColumns = false;
            this.EraserErrorPreview.AllowUserToResizeRows = false;
            this.EraserErrorPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EraserErrorPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.EraserErrorPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EraserErrorPreview.Enabled = false;
            this.EraserErrorPreview.Location = new System.Drawing.Point(938, 6);
            this.EraserErrorPreview.Name = "EraserErrorPreview";
            this.EraserErrorPreview.ReadOnly = true;
            this.EraserErrorPreview.RowTemplate.Height = 25;
            this.EraserErrorPreview.RowTemplate.ReadOnly = true;
            this.EraserErrorPreview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EraserErrorPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EraserErrorPreview.Size = new System.Drawing.Size(244, 535);
            this.EraserErrorPreview.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Address";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Error Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // EraserTextboxErrorList
            // 
            this.EraserTextboxErrorList.Location = new System.Drawing.Point(320, 204);
            this.EraserTextboxErrorList.Multiline = true;
            this.EraserTextboxErrorList.Name = "EraserTextboxErrorList";
            this.EraserTextboxErrorList.PlaceholderText = "Enter a list of errors, separated by commas (e.g. a1c7, 1600, 8461, e56f...):";
            this.EraserTextboxErrorList.Size = new System.Drawing.Size(612, 66);
            this.EraserTextboxErrorList.TabIndex = 39;
            // 
            // EraserListViewMapSelection
            // 
            this.EraserListViewMapSelection.CheckBoxes = true;
            this.EraserListViewMapSelection.Location = new System.Drawing.Point(320, 308);
            this.EraserListViewMapSelection.Name = "EraserListViewMapSelection";
            this.EraserListViewMapSelection.Size = new System.Drawing.Size(303, 376);
            this.EraserListViewMapSelection.TabIndex = 37;
            this.EraserListViewMapSelection.UseCompatibleStateImageBehavior = false;
            // 
            // EraserLabelPresetSelect
            // 
            this.EraserLabelPresetSelect.AutoSize = true;
            this.EraserLabelPresetSelect.Location = new System.Drawing.Point(629, 285);
            this.EraserLabelPresetSelect.Name = "EraserLabelPresetSelect";
            this.EraserLabelPresetSelect.Size = new System.Drawing.Size(165, 15);
            this.EraserLabelPresetSelect.TabIndex = 34;
            this.EraserLabelPresetSelect.Text = "Select error presets to include:";
            // 
            // EraserLabelMapSelect
            // 
            this.EraserLabelMapSelect.AutoSize = true;
            this.EraserLabelMapSelect.Location = new System.Drawing.Point(320, 285);
            this.EraserLabelMapSelect.Name = "EraserLabelMapSelect";
            this.EraserLabelMapSelect.Size = new System.Drawing.Size(128, 15);
            this.EraserLabelMapSelect.TabIndex = 33;
            this.EraserLabelMapSelect.Text = "Select maps to modify:";
            // 
            // EraserButtonRefreshPresetList
            // 
            this.EraserButtonRefreshPresetList.BackColor = System.Drawing.Color.PaleGreen;
            this.EraserButtonRefreshPresetList.Location = new System.Drawing.Point(843, 276);
            this.EraserButtonRefreshPresetList.Name = "EraserButtonRefreshPresetList";
            this.EraserButtonRefreshPresetList.Size = new System.Drawing.Size(92, 32);
            this.EraserButtonRefreshPresetList.TabIndex = 32;
            this.EraserButtonRefreshPresetList.Text = "Refresh List";
            this.EraserButtonRefreshPresetList.UseVisualStyleBackColor = false;
            // 
            // EraserLabelFilePath
            // 
            this.EraserLabelFilePath.Location = new System.Drawing.Point(320, 177);
            this.EraserLabelFilePath.Name = "EraserLabelFilePath";
            this.EraserLabelFilePath.Size = new System.Drawing.Size(612, 24);
            this.EraserLabelFilePath.TabIndex = 29;
            this.EraserLabelFilePath.Text = "Once a file is loaded, its path will be displayed here.";
            this.EraserLabelFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EraserLabelErrorCounter
            // 
            this.EraserLabelErrorCounter.Location = new System.Drawing.Point(940, 662);
            this.EraserLabelErrorCounter.Name = "EraserLabelErrorCounter";
            this.EraserLabelErrorCounter.Size = new System.Drawing.Size(244, 31);
            this.EraserLabelErrorCounter.TabIndex = 28;
            this.EraserLabelErrorCounter.Text = "Deleted: X / Y";
            this.EraserLabelErrorCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EraserButtonFileBrowse
            // 
            this.EraserButtonFileBrowse.BackColor = System.Drawing.Color.LightBlue;
            this.EraserButtonFileBrowse.Location = new System.Drawing.Point(320, 6);
            this.EraserButtonFileBrowse.Name = "EraserButtonFileBrowse";
            this.EraserButtonFileBrowse.Size = new System.Drawing.Size(612, 168);
            this.EraserButtonFileBrowse.TabIndex = 27;
            this.EraserButtonFileBrowse.Text = "Open Binary...";
            this.EraserButtonFileBrowse.UseVisualStyleBackColor = false;
            // 
            // EraserButtonRun
            // 
            this.EraserButtonRun.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EraserButtonRun.Location = new System.Drawing.Point(938, 547);
            this.EraserButtonRun.Name = "EraserButtonRun";
            this.EraserButtonRun.Size = new System.Drawing.Size(244, 112);
            this.EraserButtonRun.TabIndex = 26;
            this.EraserButtonRun.Text = "Erase Errors";
            this.EraserButtonRun.UseVisualStyleBackColor = false;
            // 
            // EraserTextboxProfileFilter
            // 
            this.EraserTextboxProfileFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EraserTextboxProfileFilter.Location = new System.Drawing.Point(7, 6);
            this.EraserTextboxProfileFilter.Name = "EraserTextboxProfileFilter";
            this.EraserTextboxProfileFilter.PlaceholderText = "Filter profiles...";
            this.EraserTextboxProfileFilter.Size = new System.Drawing.Size(306, 23);
            this.EraserTextboxProfileFilter.TabIndex = 24;
            // 
            // EraserListProfiles
            // 
            this.EraserListProfiles.FormattingEnabled = true;
            this.EraserListProfiles.ItemHeight = 15;
            this.EraserListProfiles.Location = new System.Drawing.Point(8, 35);
            this.EraserListProfiles.Name = "EraserListProfiles";
            this.EraserListProfiles.Size = new System.Drawing.Size(306, 649);
            this.EraserListProfiles.TabIndex = 23;
            // 
            // TabProfileEditor
            // 
            this.TabProfileEditor.Controls.Add(this.EditorComboBoxProfileType);
            this.TabProfileEditor.Controls.Add(this.EditorButtonRemoveProfile);
            this.TabProfileEditor.Controls.Add(this.EditorButtonRemoveSubProfile);
            this.TabProfileEditor.Controls.Add(this.EditorCheckboxFlipBytes);
            this.TabProfileEditor.Controls.Add(this.EditorLabelFilePath);
            this.TabProfileEditor.Controls.Add(this.EditorButtonDuplicateSubProfile);
            this.TabProfileEditor.Controls.Add(this.EditorTabControlProfileType);
            this.TabProfileEditor.Controls.Add(this.EditorButtonFileBrowse);
            this.TabProfileEditor.Controls.Add(this.EditorListSubprofiles);
            this.TabProfileEditor.Controls.Add(this.EditorButtonSave);
            this.TabProfileEditor.Controls.Add(this.EditorErrorPreview);
            this.TabProfileEditor.Controls.Add(this.EditorTextBoxComputerName);
            this.TabProfileEditor.Controls.Add(this.EditorDropdownManufacturer);
            this.TabProfileEditor.Controls.Add(this.EditorTextboxProfileFilter);
            this.TabProfileEditor.Controls.Add(this.EditorButtonDuplicateProfile);
            this.TabProfileEditor.Controls.Add(this.EditorButtonNewProfile);
            this.TabProfileEditor.Controls.Add(this.EditorListProfiles);
            this.TabProfileEditor.Location = new System.Drawing.Point(4, 24);
            this.TabProfileEditor.Name = "TabProfileEditor";
            this.TabProfileEditor.Padding = new System.Windows.Forms.Padding(3);
            this.TabProfileEditor.Size = new System.Drawing.Size(1190, 697);
            this.TabProfileEditor.TabIndex = 1;
            this.TabProfileEditor.Text = "Profile Editor";
            this.TabProfileEditor.UseVisualStyleBackColor = true;
            // 
            // EditorComboBoxProfileType
            // 
            this.EditorComboBoxProfileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorComboBoxProfileType.FormattingEnabled = true;
            this.EditorComboBoxProfileType.Location = new System.Drawing.Point(320, 7);
            this.EditorComboBoxProfileType.Name = "EditorComboBoxProfileType";
            this.EditorComboBoxProfileType.Size = new System.Drawing.Size(200, 23);
            this.EditorComboBoxProfileType.TabIndex = 34;
            // 
            // EditorButtonRemoveProfile
            // 
            this.EditorButtonRemoveProfile.BackColor = System.Drawing.Color.DarkSalmon;
            this.EditorButtonRemoveProfile.Location = new System.Drawing.Point(232, 6);
            this.EditorButtonRemoveProfile.Name = "EditorButtonRemoveProfile";
            this.EditorButtonRemoveProfile.Size = new System.Drawing.Size(82, 60);
            this.EditorButtonRemoveProfile.TabIndex = 33;
            this.EditorButtonRemoveProfile.Text = "Remove Profile";
            this.EditorButtonRemoveProfile.UseVisualStyleBackColor = false;
            // 
            // EditorButtonRemoveSubProfile
            // 
            this.EditorButtonRemoveSubProfile.BackColor = System.Drawing.Color.DarkSalmon;
            this.EditorButtonRemoveSubProfile.Location = new System.Drawing.Point(442, 149);
            this.EditorButtonRemoveSubProfile.Name = "EditorButtonRemoveSubProfile";
            this.EditorButtonRemoveSubProfile.Size = new System.Drawing.Size(79, 25);
            this.EditorButtonRemoveSubProfile.TabIndex = 32;
            this.EditorButtonRemoveSubProfile.Text = "Remove";
            this.EditorButtonRemoveSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorCheckboxFlipBytes
            // 
            this.EditorCheckboxFlipBytes.AutoSize = true;
            this.EditorCheckboxFlipBytes.Location = new System.Drawing.Point(849, 657);
            this.EditorCheckboxFlipBytes.Name = "EditorCheckboxFlipBytes";
            this.EditorCheckboxFlipBytes.Size = new System.Drawing.Size(76, 19);
            this.EditorCheckboxFlipBytes.TabIndex = 31;
            this.EditorCheckboxFlipBytes.Text = "Flip Bytes";
            this.EditorCheckboxFlipBytes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditorCheckboxFlipBytes.UseVisualStyleBackColor = true;
            // 
            // EditorLabelFilePath
            // 
            this.EditorLabelFilePath.Location = new System.Drawing.Point(320, 177);
            this.EditorLabelFilePath.Name = "EditorLabelFilePath";
            this.EditorLabelFilePath.Size = new System.Drawing.Size(612, 24);
            this.EditorLabelFilePath.TabIndex = 30;
            this.EditorLabelFilePath.Text = "Once a file is loaded, its path will be displayed here.";
            this.EditorLabelFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EditorButtonDuplicateSubProfile
            // 
            this.EditorButtonDuplicateSubProfile.BackColor = System.Drawing.Color.NavajoWhite;
            this.EditorButtonDuplicateSubProfile.Location = new System.Drawing.Point(319, 149);
            this.EditorButtonDuplicateSubProfile.Name = "EditorButtonDuplicateSubProfile";
            this.EditorButtonDuplicateSubProfile.Size = new System.Drawing.Size(117, 25);
            this.EditorButtonDuplicateSubProfile.TabIndex = 24;
            this.EditorButtonDuplicateSubProfile.Text = "Duplicate";
            this.EditorButtonDuplicateSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorTabControlProfileType
            // 
            this.EditorTabControlProfileType.Controls.Add(this.ProfileTabBosch);
            this.EditorTabControlProfileType.Controls.Add(this.ProfileTabDelphi);
            this.EditorTabControlProfileType.Location = new System.Drawing.Point(320, 204);
            this.EditorTabControlProfileType.Name = "EditorTabControlProfileType";
            this.EditorTabControlProfileType.SelectedIndex = 0;
            this.EditorTabControlProfileType.Size = new System.Drawing.Size(612, 440);
            this.EditorTabControlProfileType.TabIndex = 23;
            // 
            // ProfileTabBosch
            // 
            this.ProfileTabBosch.Controls.Add(this.EditorTextboxBoschManualLength);
            this.ProfileTabBosch.Controls.Add(this.EditorComboBoxBoschMapLengthAlgoSelect);
            this.ProfileTabBosch.Controls.Add(this.EditorDataGridViewBosch);
            this.ProfileTabBosch.Location = new System.Drawing.Point(4, 24);
            this.ProfileTabBosch.Name = "ProfileTabBosch";
            this.ProfileTabBosch.Padding = new System.Windows.Forms.Padding(3);
            this.ProfileTabBosch.Size = new System.Drawing.Size(604, 412);
            this.ProfileTabBosch.TabIndex = 0;
            this.ProfileTabBosch.Text = "Bosch";
            this.ProfileTabBosch.UseVisualStyleBackColor = true;
            // 
            // EditorTextboxBoschManualLength
            // 
            this.EditorTextboxBoschManualLength.Location = new System.Drawing.Point(375, 371);
            this.EditorTextboxBoschManualLength.Name = "EditorTextboxBoschManualLength";
            this.EditorTextboxBoschManualLength.PlaceholderText = "Enter manual length...";
            this.EditorTextboxBoschManualLength.Size = new System.Drawing.Size(152, 23);
            this.EditorTextboxBoschManualLength.TabIndex = 2;
            // 
            // EditorComboBoxBoschMapLengthAlgoSelect
            // 
            this.EditorComboBoxBoschMapLengthAlgoSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorComboBoxBoschMapLengthAlgoSelect.FormattingEnabled = true;
            this.EditorComboBoxBoschMapLengthAlgoSelect.Items.AddRange(new object[] {
            "Manual Input",
            "BMW"});
            this.EditorComboBoxBoschMapLengthAlgoSelect.Location = new System.Drawing.Point(246, 371);
            this.EditorComboBoxBoschMapLengthAlgoSelect.Name = "EditorComboBoxBoschMapLengthAlgoSelect";
            this.EditorComboBoxBoschMapLengthAlgoSelect.Size = new System.Drawing.Size(123, 23);
            this.EditorComboBoxBoschMapLengthAlgoSelect.TabIndex = 1;
            // 
            // EditorDataGridViewBosch
            // 
            this.EditorDataGridViewBosch.AllowDrop = true;
            this.EditorDataGridViewBosch.AllowUserToResizeColumns = false;
            this.EditorDataGridViewBosch.AllowUserToResizeRows = false;
            this.EditorDataGridViewBosch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EditorDataGridViewBosch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.EditorDataGridViewBosch.Location = new System.Drawing.Point(77, 37);
            this.EditorDataGridViewBosch.Name = "EditorDataGridViewBosch";
            this.EditorDataGridViewBosch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EditorDataGridViewBosch.RowTemplate.Height = 25;
            this.EditorDataGridViewBosch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EditorDataGridViewBosch.Size = new System.Drawing.Size(450, 315);
            this.EditorDataGridViewBosch.TabIndex = 0;
            this.EditorDataGridViewBosch.VirtualMode = true;
            // 
            // ProfileTabDelphi
            // 
            this.ProfileTabDelphi.Controls.Add(this.EditorDataGridViewDelphi);
            this.ProfileTabDelphi.Location = new System.Drawing.Point(4, 24);
            this.ProfileTabDelphi.Name = "ProfileTabDelphi";
            this.ProfileTabDelphi.Padding = new System.Windows.Forms.Padding(3);
            this.ProfileTabDelphi.Size = new System.Drawing.Size(604, 412);
            this.ProfileTabDelphi.TabIndex = 1;
            this.ProfileTabDelphi.Text = "Delphi";
            this.ProfileTabDelphi.UseVisualStyleBackColor = true;
            // 
            // EditorDataGridViewDelphi
            // 
            this.EditorDataGridViewDelphi.AllowDrop = true;
            this.EditorDataGridViewDelphi.AllowUserToResizeColumns = false;
            this.EditorDataGridViewDelphi.AllowUserToResizeRows = false;
            this.EditorDataGridViewDelphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EditorDataGridViewDelphi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.EditorDataGridViewDelphi.Location = new System.Drawing.Point(6, 37);
            this.EditorDataGridViewDelphi.Name = "EditorDataGridViewDelphi";
            this.EditorDataGridViewDelphi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EditorDataGridViewDelphi.RowTemplate.Height = 25;
            this.EditorDataGridViewDelphi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EditorDataGridViewDelphi.Size = new System.Drawing.Size(592, 315);
            this.EditorDataGridViewDelphi.TabIndex = 1;
            this.EditorDataGridViewDelphi.VirtualMode = true;
            // 
            // EditorButtonFileBrowse
            // 
            this.EditorButtonFileBrowse.BackColor = System.Drawing.Color.LightBlue;
            this.EditorButtonFileBrowse.Location = new System.Drawing.Point(526, 35);
            this.EditorButtonFileBrowse.Name = "EditorButtonFileBrowse";
            this.EditorButtonFileBrowse.Size = new System.Drawing.Size(406, 139);
            this.EditorButtonFileBrowse.TabIndex = 22;
            this.EditorButtonFileBrowse.Text = "Open Binary...";
            this.EditorButtonFileBrowse.UseVisualStyleBackColor = false;
            // 
            // EditorListSubprofiles
            // 
            this.EditorListSubprofiles.FormattingEnabled = true;
            this.EditorListSubprofiles.ItemHeight = 15;
            this.EditorListSubprofiles.Location = new System.Drawing.Point(320, 36);
            this.EditorListSubprofiles.Name = "EditorListSubprofiles";
            this.EditorListSubprofiles.Size = new System.Drawing.Size(200, 109);
            this.EditorListSubprofiles.Sorted = true;
            this.EditorListSubprofiles.TabIndex = 21;
            // 
            // EditorButtonSave
            // 
            this.EditorButtonSave.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EditorButtonSave.Location = new System.Drawing.Point(938, 547);
            this.EditorButtonSave.Name = "EditorButtonSave";
            this.EditorButtonSave.Size = new System.Drawing.Size(244, 143);
            this.EditorButtonSave.TabIndex = 20;
            this.EditorButtonSave.Text = "Save Profile";
            this.EditorButtonSave.UseVisualStyleBackColor = false;
            // 
            // EditorErrorPreview
            // 
            this.EditorErrorPreview.AllowUserToAddRows = false;
            this.EditorErrorPreview.AllowUserToDeleteRows = false;
            this.EditorErrorPreview.AllowUserToResizeColumns = false;
            this.EditorErrorPreview.AllowUserToResizeRows = false;
            this.EditorErrorPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EditorErrorPreview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAddress,
            this.ColumnError});
            this.EditorErrorPreview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EditorErrorPreview.Enabled = false;
            this.EditorErrorPreview.Location = new System.Drawing.Point(938, 6);
            this.EditorErrorPreview.Name = "EditorErrorPreview";
            this.EditorErrorPreview.ReadOnly = true;
            this.EditorErrorPreview.RowTemplate.Height = 25;
            this.EditorErrorPreview.RowTemplate.ReadOnly = true;
            this.EditorErrorPreview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EditorErrorPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EditorErrorPreview.Size = new System.Drawing.Size(244, 535);
            this.EditorErrorPreview.TabIndex = 19;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.HeaderText = "Address";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnError
            // 
            this.ColumnError.HeaderText = "Error Number";
            this.ColumnError.Name = "ColumnError";
            this.ColumnError.ReadOnly = true;
            // 
            // EditorTextBoxComputerName
            // 
            this.EditorTextBoxComputerName.Location = new System.Drawing.Point(712, 6);
            this.EditorTextBoxComputerName.Name = "EditorTextBoxComputerName";
            this.EditorTextBoxComputerName.PlaceholderText = "Enter computer name...";
            this.EditorTextBoxComputerName.Size = new System.Drawing.Size(220, 23);
            this.EditorTextBoxComputerName.TabIndex = 18;
            // 
            // EditorDropdownManufacturer
            // 
            this.EditorDropdownManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditorDropdownManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditorDropdownManufacturer.FormattingEnabled = true;
            this.EditorDropdownManufacturer.Location = new System.Drawing.Point(526, 6);
            this.EditorDropdownManufacturer.Name = "EditorDropdownManufacturer";
            this.EditorDropdownManufacturer.Size = new System.Drawing.Size(179, 23);
            this.EditorDropdownManufacturer.TabIndex = 17;
            this.EditorDropdownManufacturer.Text = "Select Manufacturer...";
            // 
            // EditorTextboxProfileFilter
            // 
            this.EditorTextboxProfileFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditorTextboxProfileFilter.Location = new System.Drawing.Point(8, 72);
            this.EditorTextboxProfileFilter.Name = "EditorTextboxProfileFilter";
            this.EditorTextboxProfileFilter.PlaceholderText = "Filter profiles...";
            this.EditorTextboxProfileFilter.Size = new System.Drawing.Size(306, 23);
            this.EditorTextboxProfileFilter.TabIndex = 16;
            // 
            // EditorButtonDuplicateProfile
            // 
            this.EditorButtonDuplicateProfile.BackColor = System.Drawing.Color.NavajoWhite;
            this.EditorButtonDuplicateProfile.Location = new System.Drawing.Point(147, 6);
            this.EditorButtonDuplicateProfile.Name = "EditorButtonDuplicateProfile";
            this.EditorButtonDuplicateProfile.Size = new System.Drawing.Size(79, 60);
            this.EditorButtonDuplicateProfile.TabIndex = 15;
            this.EditorButtonDuplicateProfile.Text = "Duplicate Profile";
            this.EditorButtonDuplicateProfile.UseVisualStyleBackColor = false;
            // 
            // EditorButtonNewProfile
            // 
            this.EditorButtonNewProfile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EditorButtonNewProfile.Location = new System.Drawing.Point(8, 6);
            this.EditorButtonNewProfile.Name = "EditorButtonNewProfile";
            this.EditorButtonNewProfile.Size = new System.Drawing.Size(133, 60);
            this.EditorButtonNewProfile.TabIndex = 14;
            this.EditorButtonNewProfile.Text = "New Profile";
            this.EditorButtonNewProfile.UseVisualStyleBackColor = false;
            // 
            // EditorListProfiles
            // 
            this.EditorListProfiles.FormattingEnabled = true;
            this.EditorListProfiles.ItemHeight = 15;
            this.EditorListProfiles.Location = new System.Drawing.Point(8, 110);
            this.EditorListProfiles.Name = "EditorListProfiles";
            this.EditorListProfiles.Size = new System.Drawing.Size(306, 574);
            this.EditorListProfiles.Sorted = true;
            this.EditorListProfiles.TabIndex = 13;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1198, 725);
            this.Controls.Add(this.TabControlMain);
            this.Name = "Main";
            this.Text = "OBD Error Erase";
            this.TabControlMain.ResumeLayout(false);
            this.TabErrorEraser.ResumeLayout(false);
            this.TabErrorEraser.PerformLayout();
            this.EraserPanelErrorPresets.ResumeLayout(false);
            this.EraserPanelErrorPresets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EraserErrorPreview)).EndInit();
            this.TabProfileEditor.ResumeLayout(false);
            this.TabProfileEditor.PerformLayout();
            this.EditorTabControlProfileType.ResumeLayout(false);
            this.ProfileTabBosch.ResumeLayout(false);
            this.ProfileTabBosch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditorDataGridViewBosch)).EndInit();
            this.ProfileTabDelphi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditorDataGridViewDelphi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditorErrorPreview)).EndInit();
            this.ResumeLayout(false);

        }

        private TabControl TabControlMain;
        private TabPage TabProfileEditor;
    }
}