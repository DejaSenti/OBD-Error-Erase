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
            label1 = new Label();
            EraserCheckBoxSelectAllMaps = new CheckBox();
            EraserButtonRefreshPresetList = new Button();
            EraserTextboxErrorList = new TextBox();
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
            MainLabelLoadedBinaryFile = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            this.EditorButtonSaveProfile = new Button();
            MainTabControl.SuspendLayout();
            EraserTabPage.SuspendLayout();
            EraserPanelMapSelector.SuspendLayout();
            EraserPanelErrorPresets.SuspendLayout();
            EditorTabPage.SuspendLayout();
            EditorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridFilePreview).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EraserTabPage);
            MainTabControl.Controls.Add(EditorTabPage);
            MainTabControl.Location = new Point(554, 14);
            MainTabControl.Margin = new Padding(5);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(443, 729);
            MainTabControl.TabIndex = 54;
            // 
            // EraserTabPage
            // 
            EraserTabPage.BackColor = Color.White;
            EraserTabPage.Controls.Add(label1);
            EraserTabPage.Controls.Add(EraserCheckBoxSelectAllMaps);
            EraserTabPage.Controls.Add(EraserButtonRefreshPresetList);
            EraserTabPage.Controls.Add(EraserTextboxErrorList);
            EraserTabPage.Controls.Add(EraserPanelMapSelector);
            EraserTabPage.Controls.Add(EraserPanelErrorPresets);
            EraserTabPage.Controls.Add(EraserLabelPresetSelect);
            EraserTabPage.Controls.Add(EraserLabelMapSelect);
            EraserTabPage.Controls.Add(EraserLabelErrorCounter);
            EraserTabPage.Controls.Add(EraserButtonRun);
            EraserTabPage.Location = new Point(4, 24);
            EraserTabPage.Name = "EraserTabPage";
            EraserTabPage.Padding = new Padding(3);
            EraserTabPage.Size = new Size(435, 701);
            EraserTabPage.TabIndex = 0;
            EraserTabPage.Text = "Erase Errors";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 54;
            label1.Text = "Refresh";
            // 
            // EraserCheckBoxSelectAllMaps
            // 
            EraserCheckBoxSelectAllMaps.AutoSize = true;
            EraserCheckBoxSelectAllMaps.Location = new Point(54, 373);
            EraserCheckBoxSelectAllMaps.Name = "EraserCheckBoxSelectAllMaps";
            EraserCheckBoxSelectAllMaps.Size = new Size(74, 19);
            EraserCheckBoxSelectAllMaps.TabIndex = 53;
            EraserCheckBoxSelectAllMaps.Text = "Select All";
            EraserCheckBoxSelectAllMaps.UseVisualStyleBackColor = true;
            // 
            // EraserButtonRefreshPresetList
            // 
            EraserButtonRefreshPresetList.BackColor = Color.Transparent;
            EraserButtonRefreshPresetList.BackgroundImage = Properties.Resources.ButtonRefresh;
            EraserButtonRefreshPresetList.BackgroundImageLayout = ImageLayout.Stretch;
            EraserButtonRefreshPresetList.FlatAppearance.BorderSize = 0;
            EraserButtonRefreshPresetList.FlatStyle = FlatStyle.Flat;
            EraserButtonRefreshPresetList.Location = new Point(325, 21);
            EraserButtonRefreshPresetList.MaximumSize = new Size(32, 32);
            EraserButtonRefreshPresetList.MinimumSize = new Size(32, 32);
            EraserButtonRefreshPresetList.Name = "EraserButtonRefreshPresetList";
            EraserButtonRefreshPresetList.Size = new Size(32, 32);
            EraserButtonRefreshPresetList.TabIndex = 46;
            EraserButtonRefreshPresetList.UseVisualStyleBackColor = false;
            // 
            // EraserTextboxErrorList
            // 
            EraserTextboxErrorList.Location = new Point(54, 259);
            EraserTextboxErrorList.Multiline = true;
            EraserTextboxErrorList.Name = "EraserTextboxErrorList";
            EraserTextboxErrorList.PlaceholderText = "Enter a list of errors, separated by commas (e.g. a1c7, 1600, 8461, e56f...):";
            EraserTextboxErrorList.ScrollBars = ScrollBars.Vertical;
            EraserTextboxErrorList.Size = new Size(303, 73);
            EraserTextboxErrorList.TabIndex = 49;
            // 
            // EraserPanelMapSelector
            // 
            EraserPanelMapSelector.AutoScroll = true;
            EraserPanelMapSelector.AutoScrollMinSize = new Size(250, 0);
            EraserPanelMapSelector.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EraserPanelMapSelector.BackColor = SystemColors.Window;
            EraserPanelMapSelector.BorderStyle = BorderStyle.FixedSingle;
            EraserPanelMapSelector.Controls.Add(EraserTableLayoutMapSelector);
            EraserPanelMapSelector.Location = new Point(54, 398);
            EraserPanelMapSelector.Name = "EraserPanelMapSelector";
            EraserPanelMapSelector.Size = new Size(303, 195);
            EraserPanelMapSelector.TabIndex = 51;
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
            EraserPanelErrorPresets.BorderStyle = BorderStyle.FixedSingle;
            EraserPanelErrorPresets.Controls.Add(EraserTableLayoutErrorPresets);
            EraserPanelErrorPresets.Location = new Point(54, 58);
            EraserPanelErrorPresets.Name = "EraserPanelErrorPresets";
            EraserPanelErrorPresets.Size = new Size(303, 195);
            EraserPanelErrorPresets.TabIndex = 50;
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
            // 
            // EraserLabelMapSelect
            // 
            EraserLabelMapSelect.AutoSize = true;
            EraserLabelMapSelect.Location = new Point(54, 346);
            EraserLabelMapSelect.Name = "EraserLabelMapSelect";
            EraserLabelMapSelect.Size = new Size(128, 15);
            EraserLabelMapSelect.TabIndex = 47;
            EraserLabelMapSelect.Text = "Select maps to modify:";
            // 
            // EraserLabelErrorCounter
            // 
            EraserLabelErrorCounter.Location = new Point(57, 654);
            EraserLabelErrorCounter.Name = "EraserLabelErrorCounter";
            EraserLabelErrorCounter.Size = new Size(300, 31);
            EraserLabelErrorCounter.TabIndex = 45;
            EraserLabelErrorCounter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EraserButtonRun
            // 
            EraserButtonRun.BackColor = Color.DarkSeaGreen;
            EraserButtonRun.FlatAppearance.BorderColor = Color.White;
            EraserButtonRun.FlatAppearance.BorderSize = 0;
            EraserButtonRun.FlatStyle = FlatStyle.Flat;
            EraserButtonRun.Location = new Point(54, 605);
            EraserButtonRun.Name = "EraserButtonRun";
            EraserButtonRun.Size = new Size(303, 43);
            EraserButtonRun.TabIndex = 44;
            EraserButtonRun.Text = "Erase Errors";
            EraserButtonRun.UseVisualStyleBackColor = false;
            // 
            // EditorTabPage
            // 
            EditorTabPage.Controls.Add(this.EditorButtonSaveProfile);
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
            EditorTabPage.Size = new Size(435, 701);
            EditorTabPage.TabIndex = 1;
            EditorTabPage.Text = "Edit Profiles";
            EditorTabPage.UseVisualStyleBackColor = true;
            // 
            // EditorGroupBox
            // 
            EditorGroupBox.Controls.Add(EditorComboBoxProfileType);
            EditorGroupBox.Controls.Add(EditorPanelEditFrame);
            EditorGroupBox.Controls.Add(EditorLabelProfileTypeSelect);
            EditorGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorGroupBox.Location = new Point(6, 144);
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
            // 
            // EditorPanelEditFrame
            // 
            EditorPanelEditFrame.Location = new Point(12, 76);
            EditorPanelEditFrame.Name = "EditorPanelEditFrame";
            EditorPanelEditFrame.Size = new Size(400, 400);
            EditorPanelEditFrame.TabIndex = 43;
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
            EditorButtonDuplicateSubProfile.BackColor = Color.Transparent;
            EditorButtonDuplicateSubProfile.BackgroundImage = Properties.Resources.Duplicate1;
            EditorButtonDuplicateSubProfile.FlatAppearance.BorderSize = 0;
            EditorButtonDuplicateSubProfile.FlatStyle = FlatStyle.Flat;
            EditorButtonDuplicateSubProfile.Location = new Point(332, 6);
            EditorButtonDuplicateSubProfile.Margin = new Padding(30, 15, 30, 15);
            EditorButtonDuplicateSubProfile.MaximumSize = new Size(36, 36);
            EditorButtonDuplicateSubProfile.MinimumSize = new Size(36, 36);
            EditorButtonDuplicateSubProfile.Name = "EditorButtonDuplicateSubProfile";
            EditorButtonDuplicateSubProfile.Size = new Size(36, 36);
            EditorButtonDuplicateSubProfile.TabIndex = 50;
            EditorButtonDuplicateSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorButtonRemoveSubProfile
            // 
            EditorButtonRemoveSubProfile.BackColor = Color.Transparent;
            EditorButtonRemoveSubProfile.BackgroundImage = Properties.Resources.Delete1;
            EditorButtonRemoveSubProfile.FlatAppearance.BorderSize = 0;
            EditorButtonRemoveSubProfile.FlatStyle = FlatStyle.Flat;
            EditorButtonRemoveSubProfile.Location = new Point(373, 6);
            EditorButtonRemoveSubProfile.Margin = new Padding(30, 15, 30, 15);
            EditorButtonRemoveSubProfile.MaximumSize = new Size(36, 36);
            EditorButtonRemoveSubProfile.MinimumSize = new Size(36, 36);
            EditorButtonRemoveSubProfile.Name = "EditorButtonRemoveSubProfile";
            EditorButtonRemoveSubProfile.Size = new Size(36, 36);
            EditorButtonRemoveSubProfile.TabIndex = 51;
            EditorButtonRemoveSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorLabelProfileSettings
            // 
            EditorLabelProfileSettings.AutoSize = true;
            EditorLabelProfileSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorLabelProfileSettings.Location = new Point(9, 17);
            EditorLabelProfileSettings.Name = "EditorLabelProfileSettings";
            EditorLabelProfileSettings.Size = new Size(96, 15);
            EditorLabelProfileSettings.TabIndex = 49;
            EditorLabelProfileSettings.Text = "Profile Settings:";
            EditorLabelProfileSettings.Click += EditorLabelProfileSettings_Click;
            // 
            // EditorLabelSubprofiles
            // 
            EditorLabelSubprofiles.AutoSize = true;
            EditorLabelSubprofiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorLabelSubprofiles.Location = new Point(222, 17);
            EditorLabelSubprofiles.Name = "EditorLabelSubprofiles";
            EditorLabelSubprofiles.Size = new Size(73, 15);
            EditorLabelSubprofiles.TabIndex = 47;
            EditorLabelSubprofiles.Text = "Subprofiles:";
            // 
            // EditorLabelName
            // 
            EditorLabelName.AutoSize = true;
            EditorLabelName.Location = new Point(9, 95);
            EditorLabelName.Name = "EditorLabelName";
            EditorLabelName.Size = new Size(101, 15);
            EditorLabelName.TabIndex = 46;
            EditorLabelName.Text = "Computer Model:";
            EditorLabelName.Click += EditorLabelName_Click;
            // 
            // EditorLabelManufacturer
            // 
            EditorLabelManufacturer.AutoSize = true;
            EditorLabelManufacturer.Location = new Point(9, 46);
            EditorLabelManufacturer.Name = "EditorLabelManufacturer";
            EditorLabelManufacturer.Size = new Size(82, 15);
            EditorLabelManufacturer.TabIndex = 45;
            EditorLabelManufacturer.Text = "Manufacturer:";
            EditorLabelManufacturer.Click += EditorLabelManufacturer_Click;
            // 
            // EditorListSubprofiles
            // 
            EditorListSubprofiles.FormattingEnabled = true;
            EditorListSubprofiles.IntegralHeight = false;
            EditorListSubprofiles.ItemHeight = 15;
            EditorListSubprofiles.Location = new Point(222, 46);
            EditorListSubprofiles.Name = "EditorListSubprofiles";
            EditorListSubprofiles.Size = new Size(187, 90);
            EditorListSubprofiles.Sorted = true;
            EditorListSubprofiles.TabIndex = 37;
            // 
            // EditorTextBoxComputerName
            // 
            EditorTextBoxComputerName.Location = new Point(9, 113);
            EditorTextBoxComputerName.Name = "EditorTextBoxComputerName";
            EditorTextBoxComputerName.PlaceholderText = "Enter computer name...";
            EditorTextBoxComputerName.Size = new Size(179, 23);
            EditorTextBoxComputerName.TabIndex = 36;
            EditorTextBoxComputerName.TextChanged += EditorTextBoxComputerName_TextChanged;
            // 
            // EditorDropdownManufacturer
            // 
            EditorDropdownManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EditorDropdownManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;
            EditorDropdownManufacturer.FormattingEnabled = true;
            EditorDropdownManufacturer.Location = new Point(9, 64);
            EditorDropdownManufacturer.Name = "EditorDropdownManufacturer";
            EditorDropdownManufacturer.Size = new Size(179, 23);
            EditorDropdownManufacturer.TabIndex = 35;
            EditorDropdownManufacturer.Text = "Select Manufacturer...";
            EditorDropdownManufacturer.SelectedIndexChanged += EditorDropdownManufacturer_SelectedIndexChanged;
            // 
            // MainCheckboxFlipBytes
            // 
            MainCheckboxFlipBytes.AutoSize = true;
            MainCheckboxFlipBytes.Location = new Point(169, 155);
            MainCheckboxFlipBytes.Name = "MainCheckboxFlipBytes";
            MainCheckboxFlipBytes.Size = new Size(79, 19);
            MainCheckboxFlipBytes.TabIndex = 40;
            MainCheckboxFlipBytes.Text = "Flip Bytes";
            MainCheckboxFlipBytes.TextAlign = ContentAlignment.MiddleRight;
            MainCheckboxFlipBytes.UseVisualStyleBackColor = true;
            // 
            // MainButtonNewProfile
            // 
            MainButtonNewProfile.BackColor = Color.Transparent;
            MainButtonNewProfile.BackgroundImage = Properties.Resources.Add__new_1;
            MainButtonNewProfile.BackgroundImageLayout = ImageLayout.Center;
            MainButtonNewProfile.FlatAppearance.BorderSize = 0;
            MainButtonNewProfile.FlatStyle = FlatStyle.Flat;
            MainButtonNewProfile.Location = new Point(27, 9);
            MainButtonNewProfile.Margin = new Padding(20, 5, 20, 5);
            MainButtonNewProfile.MaximumSize = new Size(36, 36);
            MainButtonNewProfile.MinimumSize = new Size(36, 36);
            MainButtonNewProfile.Name = "MainButtonNewProfile";
            MainButtonNewProfile.Padding = new Padding(20, 0, 20, 0);
            MainButtonNewProfile.Size = new Size(36, 36);
            MainButtonNewProfile.TabIndex = 43;
            MainButtonNewProfile.UseVisualStyleBackColor = false;
            // 
            // MainButtonRemoveProfile
            // 
            MainButtonRemoveProfile.BackColor = Color.Transparent;
            MainButtonRemoveProfile.BackgroundImage = Properties.Resources.Delete1;
            MainButtonRemoveProfile.FlatAppearance.BorderSize = 0;
            MainButtonRemoveProfile.FlatStyle = FlatStyle.Flat;
            MainButtonRemoveProfile.Location = new Point(179, 9);
            MainButtonRemoveProfile.Margin = new Padding(20, 5, 20, 5);
            MainButtonRemoveProfile.MaximumSize = new Size(36, 36);
            MainButtonRemoveProfile.MinimumSize = new Size(36, 36);
            MainButtonRemoveProfile.Name = "MainButtonRemoveProfile";
            MainButtonRemoveProfile.Padding = new Padding(20, 0, 20, 0);
            MainButtonRemoveProfile.Size = new Size(36, 36);
            MainButtonRemoveProfile.TabIndex = 45;
            MainButtonRemoveProfile.UseVisualStyleBackColor = false;
            // 
            // MainButtonDuplicateProfile
            // 
            MainButtonDuplicateProfile.BackColor = Color.Transparent;
            MainButtonDuplicateProfile.BackgroundImage = Properties.Resources.Duplicate1;
            MainButtonDuplicateProfile.FlatAppearance.BorderSize = 0;
            MainButtonDuplicateProfile.FlatStyle = FlatStyle.Flat;
            MainButtonDuplicateProfile.Location = new Point(103, 9);
            MainButtonDuplicateProfile.Margin = new Padding(20, 5, 20, 5);
            MainButtonDuplicateProfile.MaximumSize = new Size(36, 36);
            MainButtonDuplicateProfile.MinimumSize = new Size(36, 36);
            MainButtonDuplicateProfile.Name = "MainButtonDuplicateProfile";
            MainButtonDuplicateProfile.Padding = new Padding(20, 0, 20, 0);
            MainButtonDuplicateProfile.Size = new Size(36, 36);
            MainButtonDuplicateProfile.TabIndex = 44;
            MainButtonDuplicateProfile.UseVisualStyleBackColor = false;
            // 
            // MainDataGridFilePreview
            // 
            MainDataGridFilePreview.AllowUserToAddRows = false;
            MainDataGridFilePreview.AllowUserToDeleteRows = false;
            MainDataGridFilePreview.AllowUserToResizeColumns = false;
            MainDataGridFilePreview.AllowUserToResizeRows = false;
            MainDataGridFilePreview.BorderStyle = BorderStyle.None;
            MainDataGridFilePreview.CellBorderStyle = DataGridViewCellBorderStyle.RaisedHorizontal;
            MainDataGridFilePreview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            MainDataGridFilePreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MainDataGridFilePreview.Columns.AddRange(new DataGridViewColumn[] { DataGridViewFilePreviewColumnAddress, DataGridViewFilePreviewColumnError });
            MainDataGridFilePreview.EditMode = DataGridViewEditMode.EditProgrammatically;
            MainDataGridFilePreview.Location = new Point(12, 178);
            MainDataGridFilePreview.Name = "MainDataGridFilePreview";
            MainDataGridFilePreview.ReadOnly = true;
            MainDataGridFilePreview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MainDataGridFilePreview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            MainDataGridFilePreview.RowTemplate.Height = 25;
            MainDataGridFilePreview.RowTemplate.ReadOnly = true;
            MainDataGridFilePreview.RowTemplate.Resizable = DataGridViewTriState.False;
            MainDataGridFilePreview.SelectionMode = DataGridViewSelectionMode.CellSelect;
            MainDataGridFilePreview.Size = new Size(236, 538);
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
            MainLabelBinaryFilename.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabelBinaryFilename.Location = new Point(13, 103);
            MainLabelBinaryFilename.Name = "MainLabelBinaryFilename";
            MainLabelBinaryFilename.Size = new Size(235, 47);
            MainLabelBinaryFilename.TabIndex = 51;
            MainLabelBinaryFilename.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainButtonFileBrowse
            // 
            MainButtonFileBrowse.AllowDrop = true;
            MainButtonFileBrowse.BackColor = Color.AliceBlue;
            MainButtonFileBrowse.BackgroundImage = Properties.Resources.ButtonUpload;
            MainButtonFileBrowse.BackgroundImageLayout = ImageLayout.Center;
            MainButtonFileBrowse.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            MainButtonFileBrowse.FlatStyle = FlatStyle.Flat;
            MainButtonFileBrowse.Location = new Point(12, 28);
            MainButtonFileBrowse.Name = "MainButtonFileBrowse";
            MainButtonFileBrowse.Size = new Size(236, 54);
            MainButtonFileBrowse.TabIndex = 50;
            MainButtonFileBrowse.UseVisualStyleBackColor = false;
            // 
            // MainTextboxProfileFilter
            // 
            MainTextboxProfileFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            MainTextboxProfileFilter.Location = new Point(12, 103);
            MainTextboxProfileFilter.Name = "MainTextboxProfileFilter";
            MainTextboxProfileFilter.PlaceholderText = "Filter profiles...";
            MainTextboxProfileFilter.Size = new Size(237, 23);
            MainTextboxProfileFilter.TabIndex = 49;
            // 
            // MainListProfiles
            // 
            MainListProfiles.FormattingEnabled = true;
            MainListProfiles.IntegralHeight = false;
            MainListProfiles.ItemHeight = 15;
            MainListProfiles.Location = new Point(12, 148);
            MainListProfiles.Name = "MainListProfiles";
            MainListProfiles.Size = new Size(236, 568);
            MainListProfiles.TabIndex = 48;
            MainListProfiles.SelectedIndexChanged += MainListProfiles_SelectedIndexChanged;
            // 
            // MainLabelPreviewFile
            // 
            MainLabelPreviewFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainLabelPreviewFile.Location = new Point(12, 150);
            MainLabelPreviewFile.Name = "MainLabelPreviewFile";
            MainLabelPreviewFile.Size = new Size(61, 24);
            MainLabelPreviewFile.TabIndex = 55;
            MainLabelPreviewFile.Text = "Preview:";
            MainLabelPreviewFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainLabelLoadedBinaryFile
            // 
            MainLabelLoadedBinaryFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainLabelLoadedBinaryFile.Location = new Point(12, 81);
            MainLabelLoadedBinaryFile.Name = "MainLabelLoadedBinaryFile";
            MainLabelLoadedBinaryFile.Size = new Size(235, 24);
            MainLabelLoadedBinaryFile.TabIndex = 57;
            MainLabelLoadedBinaryFile.Text = "Loaded Binary:";
            MainLabelLoadedBinaryFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(MainButtonRemoveProfile);
            panel1.Controls.Add(MainButtonNewProfile);
            panel1.Controls.Add(MainButtonDuplicateProfile);
            panel1.Location = new Point(7, 28);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(245, 54);
            panel1.TabIndex = 58;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(MainListProfiles);
            groupBox1.Controls.Add(MainTextboxProfileFilter);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 729);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profiles";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(MainButtonFileBrowse);
            groupBox2.Controls.Add(MainCheckboxFlipBytes);
            groupBox2.Controls.Add(MainLabelLoadedBinaryFile);
            groupBox2.Controls.Add(MainLabelBinaryFilename);
            groupBox2.Controls.Add(MainLabelPreviewFile);
            groupBox2.Controls.Add(MainDataGridFilePreview);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(284, 14);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 729);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Binary File";
            // 
            // EditorButtonSaveProfile
            // 
            this.EditorButtonSaveProfile.BackColor = Color.DarkSeaGreen;
            this.EditorButtonSaveProfile.FlatAppearance.BorderColor = Color.White;
            this.EditorButtonSaveProfile.FlatAppearance.BorderSize = 0;
            this.EditorButtonSaveProfile.FlatStyle = FlatStyle.Flat;
            this.EditorButtonSaveProfile.Location = new Point(54, 640);
            this.EditorButtonSaveProfile.Name = "EditorButtonSaveProfile";
            this.EditorButtonSaveProfile.Size = new Size(303, 43);
            this.EditorButtonSaveProfile.TabIndex = 53;
            this.EditorButtonSaveProfile.Text = "Save Profile";
            this.EditorButtonSaveProfile.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            ClientSize = new Size(1010, 757);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(MainTabControl);
            Name = "Main";
            Text = "OBD Error Erase";
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
            ((System.ComponentModel.ISupportInitialize)MainDataGridFilePreview).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private void EditorLabelProfileSettings_Click(object sender, EventArgs e)
        {

        }

        private void EditorLabelManufacturer_Click(object sender, EventArgs e)
        {
        }

        private void EditorDropdownManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EditorLabelName_Click(object sender, EventArgs e)
        {
        }

        private void EditorTextBoxComputerName_TextChanged(object sender, EventArgs e)
        {
        }

        private void MainListProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EraserPanelMapSelector_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}