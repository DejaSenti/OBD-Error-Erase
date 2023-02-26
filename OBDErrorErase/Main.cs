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
            MainTabControl = new TabControl();
            EraserTabPage = new TabPage();
            EraserCheckBoxSelectAllMaps = new CheckBox();
            EraserButtonRefreshPresetList = new Button();
            EraserTextboxErrorList = new TextBox();
            EraserCheckBoxSelectAllPresets = new CheckBox();
            EraserPanelMapSelector = new Panel();
            EraserTableLayoutMapSelector = new TableLayoutPanel();
            EraserPanelErrorPresets = new Panel();
            EraserTableLayoutErrorPresets = new TableLayoutPanel();
            EraserLabelPresetSelect = new Label();
            EraserLabelMapSelect = new Label();
            EraserLabelErrorCounter = new Label();
            EraserButtonRun = new Button();
            EditorTabPage = new TabPage();
            EditorGroupBox = new GroupBox();
            EditorComboBoxProfileType = new ComboBox();
            EditorPanelEditFrame = new Panel();
            EditorLabelProfileTypeSelect = new Label();
            EditorButtonDuplicateSubProfile = new Button();
            EditorButtonRemoveSubProfile = new Button();
            EditorLabelProfileSettings = new Label();
            EditorLabelSubprofiles = new Label();
            EditorLabelName = new Label();
            EditorLabelManufacturer = new Label();
            EditorListSubprofiles = new ListBox();
            EditorTextBoxComputerName = new TextBox();
            EditorDropdownManufacturer = new ComboBox();
            MainCheckboxFlipBytes = new CheckBox();
            MainTableLayoutPanelProfileButtons = new TableLayoutPanel();
            MainButtonNewProfile = new Button();
            MainButtonRemoveProfile = new Button();
            MainButtonDuplicateProfile = new Button();
            MainDataGridFilePreview = new DataGridView();
            DataGridViewFilePreviewColumnAddress = new DataGridViewTextBoxColumn();
            DataGridViewFilePreviewColumnError = new DataGridViewTextBoxColumn();
            MainLabelBinaryFilename = new Label();
            MainButtonFileBrowse = new Button();
            MainTextboxProfileFilter = new TextBox();
            MainListProfiles = new ListBox();
            MainLabelPreviewFile = new Label();
            MainLabelSelectProfile = new Label();
            MainLabelLoadedBinaryFile = new Label();
            MainTabControl.SuspendLayout();
            EraserTabPage.SuspendLayout();
            EraserPanelMapSelector.SuspendLayout();
            EraserPanelErrorPresets.SuspendLayout();
            EditorTabPage.SuspendLayout();
            EditorGroupBox.SuspendLayout();
            MainTableLayoutPanelProfileButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridFilePreview).BeginInit();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EraserTabPage);
            MainTabControl.Controls.Add(EditorTabPage);
            MainTabControl.Location = new Point(555, 19);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(443, 697);
            MainTabControl.TabIndex = 54;
            // 
            // EraserTabPage
            // 
            EraserTabPage.Controls.Add(EraserCheckBoxSelectAllMaps);
            EraserTabPage.Controls.Add(EraserButtonRefreshPresetList);
            EraserTabPage.Controls.Add(EraserTextboxErrorList);
            EraserTabPage.Controls.Add(EraserCheckBoxSelectAllPresets);
            EraserTabPage.Controls.Add(EraserPanelMapSelector);
            EraserTabPage.Controls.Add(EraserPanelErrorPresets);
            EraserTabPage.Controls.Add(EraserLabelPresetSelect);
            EraserTabPage.Controls.Add(EraserLabelMapSelect);
            EraserTabPage.Controls.Add(EraserLabelErrorCounter);
            EraserTabPage.Controls.Add(EraserButtonRun);
            EraserTabPage.Location = new Point(4, 24);
            EraserTabPage.Name = "EraserTabPage";
            EraserTabPage.Padding = new Padding(3);
            EraserTabPage.Size = new Size(435, 669);
            EraserTabPage.TabIndex = 0;
            EraserTabPage.Text = "Erase Errors";
            EraserTabPage.UseVisualStyleBackColor = true;
            EraserTabPage.Click += EraserTabPage_Click;
            // 
            // EraserCheckBoxSelectAllMaps
            // 
            EraserCheckBoxSelectAllMaps.AutoSize = true;
            EraserCheckBoxSelectAllMaps.Location = new Point(57, 373);
            EraserCheckBoxSelectAllMaps.Name = "EraserCheckBoxSelectAllMaps";
            EraserCheckBoxSelectAllMaps.Size = new Size(74, 19);
            EraserCheckBoxSelectAllMaps.TabIndex = 53;
            EraserCheckBoxSelectAllMaps.Text = "Select All";
            EraserCheckBoxSelectAllMaps.UseVisualStyleBackColor = true;
            // 
            // EraserButtonRefreshPresetList
            // 
            EraserButtonRefreshPresetList.BackColor = Color.PaleGreen;
            EraserButtonRefreshPresetList.Location = new Point(276, 29);
            EraserButtonRefreshPresetList.Name = "EraserButtonRefreshPresetList";
            EraserButtonRefreshPresetList.Size = new Size(81, 24);
            EraserButtonRefreshPresetList.TabIndex = 46;
            EraserButtonRefreshPresetList.Text = "Refresh List";
            EraserButtonRefreshPresetList.UseVisualStyleBackColor = false;
            // 
            // EraserTextboxErrorList
            // 
            EraserTextboxErrorList.Location = new Point(54, 259);
            EraserTextboxErrorList.Multiline = true;
            EraserTextboxErrorList.Name = "EraserTextboxErrorList";
            EraserTextboxErrorList.PlaceholderText = "Enter a list of errors, separated by commas (e.g. a1c7, 1600, 8461, e56f...):";
            EraserTextboxErrorList.Size = new Size(303, 73);
            EraserTextboxErrorList.TabIndex = 49;
            EraserTextboxErrorList.TextChanged += EraserTextboxErrorList_TextChanged_1;
            // 
            // EraserCheckBoxSelectAllPresets
            // 
            EraserCheckBoxSelectAllPresets.AutoSize = true;
            EraserCheckBoxSelectAllPresets.Location = new Point(54, 34);
            EraserCheckBoxSelectAllPresets.Name = "EraserCheckBoxSelectAllPresets";
            EraserCheckBoxSelectAllPresets.Size = new Size(74, 19);
            EraserCheckBoxSelectAllPresets.TabIndex = 52;
            EraserCheckBoxSelectAllPresets.Text = "Select All";
            EraserCheckBoxSelectAllPresets.UseVisualStyleBackColor = true;
            // 
            // EraserPanelMapSelector
            // 
            EraserPanelMapSelector.AutoScroll = true;
            EraserPanelMapSelector.AutoScrollMinSize = new Size(250, 0);
            EraserPanelMapSelector.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EraserPanelMapSelector.BackColor = SystemColors.Window;
            EraserPanelMapSelector.Controls.Add(EraserTableLayoutMapSelector);
            EraserPanelMapSelector.Location = new Point(57, 398);
            EraserPanelMapSelector.Name = "EraserPanelMapSelector";
            EraserPanelMapSelector.Size = new Size(303, 168);
            EraserPanelMapSelector.TabIndex = 51;
            EraserPanelMapSelector.Paint += panel1_Paint;
            // 
            // EraserTableLayoutMapSelector
            // 
            EraserTableLayoutMapSelector.AutoScroll = true;
            EraserTableLayoutMapSelector.AutoSize = true;
            EraserTableLayoutMapSelector.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EraserTableLayoutMapSelector.ColumnCount = 1;
            EraserTableLayoutMapSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EraserTableLayoutMapSelector.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EraserTableLayoutMapSelector.Dock = DockStyle.Top;
            EraserTableLayoutMapSelector.Location = new Point(0, 0);
            EraserTableLayoutMapSelector.MaximumSize = new Size(300, 0);
            EraserTableLayoutMapSelector.MinimumSize = new Size(300, 25);
            EraserTableLayoutMapSelector.Name = "EraserTableLayoutMapSelector";
            EraserTableLayoutMapSelector.Padding = new Padding(0, 3, 0, 3);
            EraserTableLayoutMapSelector.RowCount = 1;
            EraserTableLayoutMapSelector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EraserTableLayoutMapSelector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EraserTableLayoutMapSelector.Size = new Size(300, 25);
            EraserTableLayoutMapSelector.TabIndex = 42;
            // 
            // EraserPanelErrorPresets
            // 
            EraserPanelErrorPresets.AutoScroll = true;
            EraserPanelErrorPresets.AutoScrollMinSize = new Size(250, 0);
            EraserPanelErrorPresets.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EraserPanelErrorPresets.BackColor = SystemColors.Window;
            EraserPanelErrorPresets.Controls.Add(EraserTableLayoutErrorPresets);
            EraserPanelErrorPresets.Location = new Point(54, 58);
            EraserPanelErrorPresets.Name = "EraserPanelErrorPresets";
            EraserPanelErrorPresets.Size = new Size(303, 195);
            EraserPanelErrorPresets.TabIndex = 50;
            EraserPanelErrorPresets.Paint += EraserPanelErrorPresets_Paint_1;
            // 
            // EraserTableLayoutErrorPresets
            // 
            EraserTableLayoutErrorPresets.AutoScroll = true;
            EraserTableLayoutErrorPresets.AutoSize = true;
            EraserTableLayoutErrorPresets.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EraserTableLayoutErrorPresets.ColumnCount = 1;
            EraserTableLayoutErrorPresets.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EraserTableLayoutErrorPresets.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            EraserTableLayoutErrorPresets.Dock = DockStyle.Top;
            EraserTableLayoutErrorPresets.Location = new Point(0, 0);
            EraserTableLayoutErrorPresets.MaximumSize = new Size(300, 0);
            EraserTableLayoutErrorPresets.MinimumSize = new Size(300, 25);
            EraserTableLayoutErrorPresets.Name = "EraserTableLayoutErrorPresets";
            EraserTableLayoutErrorPresets.Padding = new Padding(0, 3, 0, 3);
            EraserTableLayoutErrorPresets.RowCount = 1;
            EraserTableLayoutErrorPresets.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EraserTableLayoutErrorPresets.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EraserTableLayoutErrorPresets.Size = new Size(300, 25);
            EraserTableLayoutErrorPresets.TabIndex = 42;
            // 
            // EraserLabelPresetSelect
            // 
            EraserLabelPresetSelect.AutoSize = true;
            EraserLabelPresetSelect.Location = new Point(54, 11);
            EraserLabelPresetSelect.Name = "EraserLabelPresetSelect";
            EraserLabelPresetSelect.Size = new Size(165, 15);
            EraserLabelPresetSelect.TabIndex = 48;
            EraserLabelPresetSelect.Text = "Select error presets to include:";
            EraserLabelPresetSelect.Click += EraserLabelPresetSelect_Click_1;
            // 
            // EraserLabelMapSelect
            // 
            EraserLabelMapSelect.AutoSize = true;
            EraserLabelMapSelect.Location = new Point(54, 346);
            EraserLabelMapSelect.Name = "EraserLabelMapSelect";
            EraserLabelMapSelect.Size = new Size(128, 15);
            EraserLabelMapSelect.TabIndex = 47;
            EraserLabelMapSelect.Text = "Select maps to modify:";
            EraserLabelMapSelect.Click += EraserLabelMapSelect_Click_1;
            // 
            // EraserLabelErrorCounter
            // 
            EraserLabelErrorCounter.Location = new Point(54, 621);
            EraserLabelErrorCounter.Name = "EraserLabelErrorCounter";
            EraserLabelErrorCounter.Size = new Size(300, 31);
            EraserLabelErrorCounter.TabIndex = 45;
            EraserLabelErrorCounter.Text = "Deleted: X / Y";
            EraserLabelErrorCounter.TextAlign = ContentAlignment.MiddleLeft;
            EraserLabelErrorCounter.Click += EraserLabelErrorCounter_Click_1;
            // 
            // EraserButtonRun
            // 
            EraserButtonRun.BackColor = Color.DarkSeaGreen;
            EraserButtonRun.Location = new Point(54, 575);
            EraserButtonRun.Name = "EraserButtonRun";
            EraserButtonRun.Size = new Size(300, 43);
            EraserButtonRun.TabIndex = 44;
            EraserButtonRun.Text = "Erase Errors";
            EraserButtonRun.UseVisualStyleBackColor = false;
            EraserButtonRun.Click += EraserButtonRun_Click_1;
            // 
            // EditorTabPage
            // 
            EditorTabPage.Controls.Add(EditorGroupBox);
            EditorTabPage.Controls.Add(EditorButtonDuplicateSubProfile);
            EditorTabPage.Controls.Add(EditorButtonRemoveSubProfile);
            EditorTabPage.Controls.Add(EditorLabelProfileSettings);
            EditorTabPage.Controls.Add(EditorLabelSubprofiles);
            EditorTabPage.Controls.Add(EditorLabelName);
            EditorTabPage.Controls.Add(EditorLabelManufacturer);
            EditorTabPage.Controls.Add(EditorListSubprofiles);
            EditorTabPage.Controls.Add(EditorTextBoxComputerName);
            EditorTabPage.Controls.Add(EditorDropdownManufacturer);
            EditorTabPage.Location = new Point(4, 24);
            EditorTabPage.Name = "EditorTabPage";
            EditorTabPage.Padding = new Padding(3);
            EditorTabPage.Size = new Size(435, 669);
            EditorTabPage.TabIndex = 1;
            EditorTabPage.Text = "Edit Profiles";
            EditorTabPage.UseVisualStyleBackColor = true;
            EditorTabPage.Click += EditorTabPage_Click;
            // 
            // EditorGroupBox
            // 
            EditorGroupBox.Controls.Add(EditorComboBoxProfileType);
            EditorGroupBox.Controls.Add(EditorPanelEditFrame);
            EditorGroupBox.Controls.Add(EditorLabelProfileTypeSelect);
            EditorGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorGroupBox.Location = new Point(6, 181);
            EditorGroupBox.Name = "EditorGroupBox";
            EditorGroupBox.Size = new Size(423, 482);
            EditorGroupBox.TabIndex = 52;
            EditorGroupBox.TabStop = false;
            EditorGroupBox.Text = "Editor";
            // 
            // EditorComboBoxProfileType
            // 
            EditorComboBoxProfileType.DropDownStyle = ComboBoxStyle.DropDownList;
            EditorComboBoxProfileType.FormattingEnabled = true;
            EditorComboBoxProfileType.Location = new Point(12, 47);
            EditorComboBoxProfileType.Name = "EditorComboBoxProfileType";
            EditorComboBoxProfileType.Size = new Size(179, 23);
            EditorComboBoxProfileType.TabIndex = 42;
            EditorComboBoxProfileType.SelectedIndexChanged += EditorComboBoxProfileType_SelectedIndexChanged_1;
            // 
            // EditorPanelEditFrame
            // 
            EditorPanelEditFrame.Location = new Point(12, 76);
            EditorPanelEditFrame.Name = "EditorPanelEditFrame";
            EditorPanelEditFrame.Size = new Size(400, 400);
            EditorPanelEditFrame.TabIndex = 43;
            EditorPanelEditFrame.Paint += panel2_Paint;
            // 
            // EditorLabelProfileTypeSelect
            // 
            EditorLabelProfileTypeSelect.AutoSize = true;
            EditorLabelProfileTypeSelect.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EditorLabelProfileTypeSelect.Location = new Point(12, 27);
            EditorLabelProfileTypeSelect.Name = "EditorLabelProfileTypeSelect";
            EditorLabelProfileTypeSelect.Size = new Size(105, 15);
            EditorLabelProfileTypeSelect.TabIndex = 48;
            EditorLabelProfileTypeSelect.Text = "Select Profile Type:";
            // 
            // EditorButtonDuplicateSubProfile
            // 
            EditorButtonDuplicateSubProfile.BackColor = Color.NavajoWhite;
            EditorButtonDuplicateSubProfile.Location = new Point(338, 7);
            EditorButtonDuplicateSubProfile.Margin = new Padding(30, 15, 30, 15);
            EditorButtonDuplicateSubProfile.Name = "EditorButtonDuplicateSubProfile";
            EditorButtonDuplicateSubProfile.Size = new Size(33, 35);
            EditorButtonDuplicateSubProfile.TabIndex = 50;
            EditorButtonDuplicateSubProfile.Text = "D";
            EditorButtonDuplicateSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorButtonRemoveSubProfile
            // 
            EditorButtonRemoveSubProfile.BackColor = Color.DarkSalmon;
            EditorButtonRemoveSubProfile.Location = new Point(375, 7);
            EditorButtonRemoveSubProfile.Margin = new Padding(30, 15, 30, 15);
            EditorButtonRemoveSubProfile.Name = "EditorButtonRemoveSubProfile";
            EditorButtonRemoveSubProfile.Size = new Size(34, 35);
            EditorButtonRemoveSubProfile.TabIndex = 51;
            EditorButtonRemoveSubProfile.Text = "R";
            EditorButtonRemoveSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorLabelProfileSettings
            // 
            EditorLabelProfileSettings.AutoSize = true;
            EditorLabelProfileSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorLabelProfileSettings.Location = new Point(9, 12);
            EditorLabelProfileSettings.Name = "EditorLabelProfileSettings";
            EditorLabelProfileSettings.Size = new Size(96, 15);
            EditorLabelProfileSettings.TabIndex = 49;
            EditorLabelProfileSettings.Text = "Profile Settings:";
            EditorLabelProfileSettings.Click += label6_Click;
            // 
            // EditorLabelSubprofiles
            // 
            EditorLabelSubprofiles.AutoSize = true;
            EditorLabelSubprofiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorLabelSubprofiles.Location = new Point(222, 12);
            EditorLabelSubprofiles.Name = "EditorLabelSubprofiles";
            EditorLabelSubprofiles.Size = new Size(73, 15);
            EditorLabelSubprofiles.TabIndex = 47;
            EditorLabelSubprofiles.Text = "Subprofiles:";
            // 
            // EditorLabelName
            // 
            EditorLabelName.AutoSize = true;
            EditorLabelName.Location = new Point(9, 123);
            EditorLabelName.Name = "EditorLabelName";
            EditorLabelName.Size = new Size(101, 15);
            EditorLabelName.TabIndex = 46;
            EditorLabelName.Text = "Computer Model:";
            // 
            // EditorLabelManufacturer
            // 
            EditorLabelManufacturer.AutoSize = true;
            EditorLabelManufacturer.Location = new Point(9, 57);
            EditorLabelManufacturer.Name = "EditorLabelManufacturer";
            EditorLabelManufacturer.Size = new Size(82, 15);
            EditorLabelManufacturer.TabIndex = 45;
            EditorLabelManufacturer.Text = "Manufacturer:";
            // 
            // EditorListSubprofiles
            // 
            EditorListSubprofiles.FormattingEnabled = true;
            EditorListSubprofiles.IntegralHeight = false;
            EditorListSubprofiles.ItemHeight = 15;
            EditorListSubprofiles.Location = new Point(222, 45);
            EditorListSubprofiles.Name = "EditorListSubprofiles";
            EditorListSubprofiles.Size = new Size(187, 119);
            EditorListSubprofiles.Sorted = true;
            EditorListSubprofiles.TabIndex = 37;
            // 
            // EditorTextBoxComputerName
            // 
            EditorTextBoxComputerName.Location = new Point(9, 141);
            EditorTextBoxComputerName.Name = "EditorTextBoxComputerName";
            EditorTextBoxComputerName.PlaceholderText = "Enter computer name...";
            EditorTextBoxComputerName.Size = new Size(179, 23);
            EditorTextBoxComputerName.TabIndex = 36;
            // 
            // EditorDropdownManufacturer
            // 
            EditorDropdownManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EditorDropdownManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;
            EditorDropdownManufacturer.FormattingEnabled = true;
            EditorDropdownManufacturer.Location = new Point(9, 75);
            EditorDropdownManufacturer.Name = "EditorDropdownManufacturer";
            EditorDropdownManufacturer.Size = new Size(179, 23);
            EditorDropdownManufacturer.TabIndex = 35;
            EditorDropdownManufacturer.Text = "Select Manufacturer...";
            // 
            // MainCheckboxFlipBytes
            // 
            MainCheckboxFlipBytes.AutoSize = true;
            MainCheckboxFlipBytes.Location = new Point(449, 137);
            MainCheckboxFlipBytes.Name = "MainCheckboxFlipBytes";
            MainCheckboxFlipBytes.Size = new Size(76, 19);
            MainCheckboxFlipBytes.TabIndex = 40;
            MainCheckboxFlipBytes.Text = "Flip Bytes";
            MainCheckboxFlipBytes.TextAlign = ContentAlignment.MiddleRight;
            MainCheckboxFlipBytes.UseVisualStyleBackColor = true;
            // 
            // MainTableLayoutPanelProfileButtons
            // 
            MainTableLayoutPanelProfileButtons.ColumnCount = 3;
            MainTableLayoutPanelProfileButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            MainTableLayoutPanelProfileButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            MainTableLayoutPanelProfileButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            MainTableLayoutPanelProfileButtons.Controls.Add(MainButtonNewProfile, 0, 0);
            MainTableLayoutPanelProfileButtons.Controls.Add(MainButtonRemoveProfile, 2, 0);
            MainTableLayoutPanelProfileButtons.Controls.Add(MainButtonDuplicateProfile, 1, 0);
            MainTableLayoutPanelProfileButtons.Location = new Point(22, 19);
            MainTableLayoutPanelProfileButtons.Name = "MainTableLayoutPanelProfileButtons";
            MainTableLayoutPanelProfileButtons.RowCount = 1;
            MainTableLayoutPanelProfileButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanelProfileButtons.Size = new Size(236, 65);
            MainTableLayoutPanelProfileButtons.TabIndex = 53;
            // 
            // MainButtonNewProfile
            // 
            MainButtonNewProfile.BackColor = Color.DarkSeaGreen;
            MainButtonNewProfile.Dock = DockStyle.Fill;
            MainButtonNewProfile.Location = new Point(5, 5);
            MainButtonNewProfile.Margin = new Padding(5);
            MainButtonNewProfile.Name = "MainButtonNewProfile";
            MainButtonNewProfile.Size = new Size(68, 55);
            MainButtonNewProfile.TabIndex = 43;
            MainButtonNewProfile.Text = "New";
            MainButtonNewProfile.UseVisualStyleBackColor = false;
            // 
            // MainButtonRemoveProfile
            // 
            MainButtonRemoveProfile.BackColor = Color.DarkSalmon;
            MainButtonRemoveProfile.Dock = DockStyle.Fill;
            MainButtonRemoveProfile.Location = new Point(161, 5);
            MainButtonRemoveProfile.Margin = new Padding(5);
            MainButtonRemoveProfile.Name = "MainButtonRemoveProfile";
            MainButtonRemoveProfile.Size = new Size(70, 55);
            MainButtonRemoveProfile.TabIndex = 45;
            MainButtonRemoveProfile.Text = "Remove";
            MainButtonRemoveProfile.UseVisualStyleBackColor = false;
            // 
            // MainButtonDuplicateProfile
            // 
            MainButtonDuplicateProfile.BackColor = Color.NavajoWhite;
            MainButtonDuplicateProfile.Dock = DockStyle.Fill;
            MainButtonDuplicateProfile.Location = new Point(83, 5);
            MainButtonDuplicateProfile.Margin = new Padding(5);
            MainButtonDuplicateProfile.Name = "MainButtonDuplicateProfile";
            MainButtonDuplicateProfile.Size = new Size(68, 55);
            MainButtonDuplicateProfile.TabIndex = 44;
            MainButtonDuplicateProfile.Text = "Duplicate";
            MainButtonDuplicateProfile.UseVisualStyleBackColor = false;
            // 
            // MainDataGridFilePreview
            // 
            MainDataGridFilePreview.AllowUserToAddRows = false;
            MainDataGridFilePreview.AllowUserToDeleteRows = false;
            MainDataGridFilePreview.AllowUserToResizeColumns = false;
            MainDataGridFilePreview.AllowUserToResizeRows = false;
            MainDataGridFilePreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MainDataGridFilePreview.Columns.AddRange(new DataGridViewColumn[] { DataGridViewFilePreviewColumnAddress, DataGridViewFilePreviewColumnError });
            MainDataGridFilePreview.EditMode = DataGridViewEditMode.EditProgrammatically;
            MainDataGridFilePreview.Location = new Point(289, 157);
            MainDataGridFilePreview.Name = "MainDataGridFilePreview";
            MainDataGridFilePreview.ReadOnly = true;
            MainDataGridFilePreview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            MainDataGridFilePreview.RowTemplate.Height = 25;
            MainDataGridFilePreview.RowTemplate.ReadOnly = true;
            MainDataGridFilePreview.RowTemplate.Resizable = DataGridViewTriState.False;
            MainDataGridFilePreview.SelectionMode = DataGridViewSelectionMode.CellSelect;
            MainDataGridFilePreview.Size = new Size(236, 559);
            MainDataGridFilePreview.TabIndex = 52;
            // 
            // DataGridViewFilePreviewColumnAddress
            // 
            DataGridViewFilePreviewColumnAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewFilePreviewColumnAddress.HeaderText = "Address";
            DataGridViewFilePreviewColumnAddress.Name = "DataGridViewFilePreviewColumnAddress";
            DataGridViewFilePreviewColumnAddress.ReadOnly = true;
            // 
            // DataGridViewFilePreviewColumnError
            // 
            DataGridViewFilePreviewColumnError.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewFilePreviewColumnError.HeaderText = "Error Number";
            DataGridViewFilePreviewColumnError.Name = "DataGridViewFilePreviewColumnError";
            DataGridViewFilePreviewColumnError.ReadOnly = true;
            // 
            // MainLabelBinaryFilename
            // 
            MainLabelBinaryFilename.Location = new Point(290, 104);
            MainLabelBinaryFilename.Name = "MainLabelBinaryFilename";
            MainLabelBinaryFilename.Size = new Size(235, 24);
            MainLabelBinaryFilename.TabIndex = 51;
            MainLabelBinaryFilename.Text = "some_binary_file_with_a_long_name.bin";
            MainLabelBinaryFilename.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainButtonFileBrowse
            // 
            MainButtonFileBrowse.BackColor = Color.LightBlue;
            MainButtonFileBrowse.Location = new Point(289, 22);
            MainButtonFileBrowse.Name = "MainButtonFileBrowse";
            MainButtonFileBrowse.Size = new Size(236, 59);
            MainButtonFileBrowse.TabIndex = 50;
            MainButtonFileBrowse.Text = "Open Binary...";
            MainButtonFileBrowse.UseVisualStyleBackColor = false;
            // 
            // MainTextboxProfileFilter
            // 
            MainTextboxProfileFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            MainTextboxProfileFilter.Location = new Point(21, 124);
            MainTextboxProfileFilter.Name = "MainTextboxProfileFilter";
            MainTextboxProfileFilter.PlaceholderText = "Filter profiles...";
            MainTextboxProfileFilter.Size = new Size(237, 23);
            MainTextboxProfileFilter.TabIndex = 49;
            // 
            // MainListProfiles
            // 
            MainListProfiles.FormattingEnabled = true;
            MainListProfiles.ItemHeight = 15;
            MainListProfiles.Location = new Point(22, 157);
            MainListProfiles.Name = "MainListProfiles";
            MainListProfiles.Size = new Size(236, 559);
            MainListProfiles.TabIndex = 48;
            // 
            // MainLabelPreviewFile
            // 
            MainLabelPreviewFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainLabelPreviewFile.Location = new Point(289, 132);
            MainLabelPreviewFile.Name = "MainLabelPreviewFile";
            MainLabelPreviewFile.Size = new Size(61, 24);
            MainLabelPreviewFile.TabIndex = 55;
            MainLabelPreviewFile.Text = "Preview:";
            MainLabelPreviewFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainLabelSelectProfile
            // 
            MainLabelSelectProfile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainLabelSelectProfile.Location = new Point(22, 85);
            MainLabelSelectProfile.Name = "MainLabelSelectProfile";
            MainLabelSelectProfile.Size = new Size(235, 24);
            MainLabelSelectProfile.TabIndex = 56;
            MainLabelSelectProfile.Text = "Select Profile:";
            MainLabelSelectProfile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainLabelLoadedBinaryFile
            // 
            MainLabelLoadedBinaryFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainLabelLoadedBinaryFile.Location = new Point(290, 85);
            MainLabelLoadedBinaryFile.Name = "MainLabelLoadedBinaryFile";
            MainLabelLoadedBinaryFile.Size = new Size(235, 24);
            MainLabelLoadedBinaryFile.TabIndex = 57;
            MainLabelLoadedBinaryFile.Text = "Loaded Binary:";
            MainLabelLoadedBinaryFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            ClientSize = new Size(1014, 736);
            Controls.Add(MainLabelLoadedBinaryFile);
            Controls.Add(MainLabelSelectProfile);
            Controls.Add(MainLabelPreviewFile);
            Controls.Add(MainTabControl);
            Controls.Add(MainTableLayoutPanelProfileButtons);
            Controls.Add(MainDataGridFilePreview);
            Controls.Add(MainLabelBinaryFilename);
            Controls.Add(MainButtonFileBrowse);
            Controls.Add(MainTextboxProfileFilter);
            Controls.Add(MainListProfiles);
            Controls.Add(MainCheckboxFlipBytes);
            Name = "Main";
            Text = "OBD Error Erase";
            Load += Main_Load;
            MainTabControl.ResumeLayout(false);
            EraserTabPage.ResumeLayout(false);
            EraserTabPage.PerformLayout();
            EraserPanelMapSelector.ResumeLayout(false);
            EraserPanelMapSelector.PerformLayout();
            EraserPanelErrorPresets.ResumeLayout(false);
            EraserPanelErrorPresets.PerformLayout();
            EditorTabPage.ResumeLayout(false);
            EditorTabPage.PerformLayout();
            EditorGroupBox.ResumeLayout(false);
            EditorGroupBox.PerformLayout();
            MainTableLayoutPanelProfileButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainDataGridFilePreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void EraserLabelFilePath_Click(object sender, EventArgs e)
        {

        }

        private void EraserPanelErrorPresets_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void EraserButtonFileBrowse_Click(object sender, EventArgs e)
        {

        }

        private void EditorErrorPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EraserLabelPresetSelect_Click(object sender, EventArgs e)
        {

        }

        private void EditorListProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditorDropdownManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditorDataGridViewDelphi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProfileTabBosch_Click(object sender, EventArgs e)
        {

        }

        private void EraserButtonRefreshPresetList_Click(object sender, EventArgs e)
        {

        }

        private void EditorTextBoxComputerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EraserListProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EraserTextboxErrorList_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditorTextboxProfileFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditorButtonRemoveProfile_Click(object sender, EventArgs e)
        {

        }

        private void EraserTableLayoutErrorPresets_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EraserLabelMapSelect_Click(object sender, EventArgs e)
        {

        }

        private void EditorListSubprofiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProfileTabDelphi_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditorButtonRemoveSubProfile_Click(object sender, EventArgs e)
        {

        }

        private void EditorTabControlProfileType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditorButtonDuplicateProfile_Click(object sender, EventArgs e)
        {

        }

        private void EraserErrorPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditorDataGridViewBosch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditorLabelFilePath_Click(object sender, EventArgs e)
        {

        }

        private void EditorButtonNewProfile_Click(object sender, EventArgs e)
        {

        }

        private void TabProfileEditor_Click(object sender, EventArgs e)
        {

        }

        private void EraserLabelErrorCounter_Click(object sender, EventArgs e)
        {

        }

        private void EditorCheckboxFlipBytes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditorTextboxBoschManualLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabErrorEraser_Click(object sender, EventArgs e)
        {

        }

        private void EraserTextboxProfileFilter_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditorComboBoxBoschMapLengthAlgoSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EraserCheckboxListMapSelection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditorButtonDuplicateSubProfile_Click(object sender, EventArgs e)
        {

        }

        private void EditorComboBoxProfileType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EraserButtonRun_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void EditorButtonDuplicateSubProfile_Click_1(object sender, EventArgs e)
        {

        }

        private void EditorButtonRemoveSubProfile_Click_1(object sender, EventArgs e)
        {

        }

        private void EditorComboBoxProfileType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EraserTabPage_Click(object sender, EventArgs e)
        {

        }

        private void EraserPanelErrorPresets_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void EraserTextboxErrorList_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void EraserLabelPresetSelect_Click_1(object sender, EventArgs e)
        {

        }

        private void EraserLabelMapSelect_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EraserButtonRun_Click_1(object sender, EventArgs e)
        {

        }

        private void EraserLabelErrorCounter_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void EditorTabPage_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}