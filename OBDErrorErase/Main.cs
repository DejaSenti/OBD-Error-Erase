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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EraserTabPage = new System.Windows.Forms.TabPage();
            this.EraserCheckBoxSelectAllMaps = new System.Windows.Forms.CheckBox();
            this.EraserButtonRefreshPresetList = new System.Windows.Forms.Button();
            this.EraserTextboxErrorList = new System.Windows.Forms.TextBox();
            this.EraserCheckBoxSelectAllPresets = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EraserPanelErrorPresets = new System.Windows.Forms.Panel();
            this.EraserTableLayoutErrorPresets = new System.Windows.Forms.TableLayoutPanel();
            this.EraserLabelPresetSelect = new System.Windows.Forms.Label();
            this.EraserLabelMapSelect = new System.Windows.Forms.Label();
            this.EraserLabelErrorCounter = new System.Windows.Forms.Label();
            this.EraserButtonRun = new System.Windows.Forms.Button();
            this.EditorTabPage = new System.Windows.Forms.TabPage();
            this.EditorButtonDuplicateSubProfile = new System.Windows.Forms.Button();
            this.EditorButtonRemoveSubProfile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditorComboBoxProfileType = new System.Windows.Forms.ComboBox();
            this.EditorListSubprofiles = new System.Windows.Forms.ListBox();
            this.EditorTextBoxComputerName = new System.Windows.Forms.TextBox();
            this.EditorDropdownManufacturer = new System.Windows.Forms.ComboBox();
            this.EditorCheckboxFlipBytes = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanelProfileButtons = new System.Windows.Forms.TableLayoutPanel();
            this.EditorButtonNewProfile = new System.Windows.Forms.Button();
            this.EditorButtonRemoveProfile = new System.Windows.Forms.Button();
            this.EditorButtonDuplicateProfile = new System.Windows.Forms.Button();
            this.EraserErrorPreview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EraserLabelFilePath = new System.Windows.Forms.Label();
            this.EraserButtonFileBrowse = new System.Windows.Forms.Button();
            this.EraserTextboxProfileFilter = new System.Windows.Forms.TextBox();
            this.EraserListProfiles = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.EraserTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.EraserPanelErrorPresets.SuspendLayout();
            this.EditorTabPage.SuspendLayout();
            this.TableLayoutPanelProfileButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EraserErrorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EraserTabPage);
            this.TabControl.Controls.Add(this.EditorTabPage);
            this.TabControl.Location = new System.Drawing.Point(555, 19);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(424, 682);
            this.TabControl.TabIndex = 54;
            // 
            // EraserTabPage
            // 
            this.EraserTabPage.Controls.Add(this.EraserCheckBoxSelectAllMaps);
            this.EraserTabPage.Controls.Add(this.EraserButtonRefreshPresetList);
            this.EraserTabPage.Controls.Add(this.EraserTextboxErrorList);
            this.EraserTabPage.Controls.Add(this.EraserCheckBoxSelectAllPresets);
            this.EraserTabPage.Controls.Add(this.panel1);
            this.EraserTabPage.Controls.Add(this.EraserPanelErrorPresets);
            this.EraserTabPage.Controls.Add(this.EraserLabelPresetSelect);
            this.EraserTabPage.Controls.Add(this.EraserLabelMapSelect);
            this.EraserTabPage.Controls.Add(this.EraserLabelErrorCounter);
            this.EraserTabPage.Controls.Add(this.EraserButtonRun);
            this.EraserTabPage.Location = new System.Drawing.Point(4, 24);
            this.EraserTabPage.Name = "EraserTabPage";
            this.EraserTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EraserTabPage.Size = new System.Drawing.Size(416, 654);
            this.EraserTabPage.TabIndex = 0;
            this.EraserTabPage.Text = "Erase Errors";
            this.EraserTabPage.UseVisualStyleBackColor = true;
            this.EraserTabPage.Click += new System.EventHandler(this.EraserTabPage_Click);
            // 
            // EraserCheckBoxSelectAllMaps
            // 
            this.EraserCheckBoxSelectAllMaps.AutoSize = true;
            this.EraserCheckBoxSelectAllMaps.Location = new System.Drawing.Point(57, 373);
            this.EraserCheckBoxSelectAllMaps.Name = "EraserCheckBoxSelectAllMaps";
            this.EraserCheckBoxSelectAllMaps.Size = new System.Drawing.Size(74, 19);
            this.EraserCheckBoxSelectAllMaps.TabIndex = 53;
            this.EraserCheckBoxSelectAllMaps.Text = "Select All";
            this.EraserCheckBoxSelectAllMaps.UseVisualStyleBackColor = true;
            // 
            // EraserButtonRefreshPresetList
            // 
            this.EraserButtonRefreshPresetList.BackColor = System.Drawing.Color.PaleGreen;
            this.EraserButtonRefreshPresetList.Location = new System.Drawing.Point(276, 29);
            this.EraserButtonRefreshPresetList.Name = "EraserButtonRefreshPresetList";
            this.EraserButtonRefreshPresetList.Size = new System.Drawing.Size(81, 24);
            this.EraserButtonRefreshPresetList.TabIndex = 46;
            this.EraserButtonRefreshPresetList.Text = "Refresh List";
            this.EraserButtonRefreshPresetList.UseVisualStyleBackColor = false;
            // 
            // EraserTextboxErrorList
            // 
            this.EraserTextboxErrorList.Location = new System.Drawing.Point(54, 259);
            this.EraserTextboxErrorList.Multiline = true;
            this.EraserTextboxErrorList.Name = "EraserTextboxErrorList";
            this.EraserTextboxErrorList.PlaceholderText = "Enter a list of errors, separated by commas (e.g. a1c7, 1600, 8461, e56f...):";
            this.EraserTextboxErrorList.Size = new System.Drawing.Size(303, 73);
            this.EraserTextboxErrorList.TabIndex = 49;
            this.EraserTextboxErrorList.TextChanged += new System.EventHandler(this.EraserTextboxErrorList_TextChanged_1);
            // 
            // EraserCheckBoxSelectAllPresets
            // 
            this.EraserCheckBoxSelectAllPresets.AutoSize = true;
            this.EraserCheckBoxSelectAllPresets.Location = new System.Drawing.Point(54, 34);
            this.EraserCheckBoxSelectAllPresets.Name = "EraserCheckBoxSelectAllPresets";
            this.EraserCheckBoxSelectAllPresets.Size = new System.Drawing.Size(74, 19);
            this.EraserCheckBoxSelectAllPresets.TabIndex = 52;
            this.EraserCheckBoxSelectAllPresets.Text = "Select All";
            this.EraserCheckBoxSelectAllPresets.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(250, 0);
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(57, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 168);
            this.panel1.TabIndex = 51;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(300, 0);
            this.tableLayoutPanel2.MinimumSize = new System.Drawing.Size(300, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 25);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // EraserPanelErrorPresets
            // 
            this.EraserPanelErrorPresets.AutoScroll = true;
            this.EraserPanelErrorPresets.AutoScrollMinSize = new System.Drawing.Size(250, 0);
            this.EraserPanelErrorPresets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EraserPanelErrorPresets.BackColor = System.Drawing.SystemColors.Window;
            this.EraserPanelErrorPresets.Controls.Add(this.EraserTableLayoutErrorPresets);
            this.EraserPanelErrorPresets.Location = new System.Drawing.Point(54, 58);
            this.EraserPanelErrorPresets.Name = "EraserPanelErrorPresets";
            this.EraserPanelErrorPresets.Size = new System.Drawing.Size(303, 195);
            this.EraserPanelErrorPresets.TabIndex = 50;
            this.EraserPanelErrorPresets.Paint += new System.Windows.Forms.PaintEventHandler(this.EraserPanelErrorPresets_Paint_1);
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
            this.EraserTableLayoutErrorPresets.MinimumSize = new System.Drawing.Size(300, 25);
            this.EraserTableLayoutErrorPresets.Name = "EraserTableLayoutErrorPresets";
            this.EraserTableLayoutErrorPresets.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.EraserTableLayoutErrorPresets.RowCount = 1;
            this.EraserTableLayoutErrorPresets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EraserTableLayoutErrorPresets.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EraserTableLayoutErrorPresets.Size = new System.Drawing.Size(300, 25);
            this.EraserTableLayoutErrorPresets.TabIndex = 42;
            // 
            // EraserLabelPresetSelect
            // 
            this.EraserLabelPresetSelect.AutoSize = true;
            this.EraserLabelPresetSelect.Location = new System.Drawing.Point(54, 11);
            this.EraserLabelPresetSelect.Name = "EraserLabelPresetSelect";
            this.EraserLabelPresetSelect.Size = new System.Drawing.Size(165, 15);
            this.EraserLabelPresetSelect.TabIndex = 48;
            this.EraserLabelPresetSelect.Text = "Select error presets to include:";
            this.EraserLabelPresetSelect.Click += new System.EventHandler(this.EraserLabelPresetSelect_Click_1);
            // 
            // EraserLabelMapSelect
            // 
            this.EraserLabelMapSelect.AutoSize = true;
            this.EraserLabelMapSelect.Location = new System.Drawing.Point(54, 346);
            this.EraserLabelMapSelect.Name = "EraserLabelMapSelect";
            this.EraserLabelMapSelect.Size = new System.Drawing.Size(128, 15);
            this.EraserLabelMapSelect.TabIndex = 47;
            this.EraserLabelMapSelect.Text = "Select maps to modify:";
            this.EraserLabelMapSelect.Click += new System.EventHandler(this.EraserLabelMapSelect_Click_1);
            // 
            // EraserLabelErrorCounter
            // 
            this.EraserLabelErrorCounter.Location = new System.Drawing.Point(54, 621);
            this.EraserLabelErrorCounter.Name = "EraserLabelErrorCounter";
            this.EraserLabelErrorCounter.Size = new System.Drawing.Size(300, 31);
            this.EraserLabelErrorCounter.TabIndex = 45;
            this.EraserLabelErrorCounter.Text = "Deleted: X / Y";
            this.EraserLabelErrorCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EraserLabelErrorCounter.Click += new System.EventHandler(this.EraserLabelErrorCounter_Click_1);
            // 
            // EraserButtonRun
            // 
            this.EraserButtonRun.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EraserButtonRun.Location = new System.Drawing.Point(54, 575);
            this.EraserButtonRun.Name = "EraserButtonRun";
            this.EraserButtonRun.Size = new System.Drawing.Size(300, 43);
            this.EraserButtonRun.TabIndex = 44;
            this.EraserButtonRun.Text = "Erase Errors";
            this.EraserButtonRun.UseVisualStyleBackColor = false;
            this.EraserButtonRun.Click += new System.EventHandler(this.EraserButtonRun_Click_1);
            // 
            // EditorTabPage
            // 
            this.EditorTabPage.Controls.Add(this.EditorButtonDuplicateSubProfile);
            this.EditorTabPage.Controls.Add(this.EditorButtonRemoveSubProfile);
            this.EditorTabPage.Controls.Add(this.label6);
            this.EditorTabPage.Controls.Add(this.label4);
            this.EditorTabPage.Controls.Add(this.label3);
            this.EditorTabPage.Controls.Add(this.label2);
            this.EditorTabPage.Controls.Add(this.label1);
            this.EditorTabPage.Controls.Add(this.panel2);
            this.EditorTabPage.Controls.Add(this.EditorComboBoxProfileType);
            this.EditorTabPage.Controls.Add(this.EditorListSubprofiles);
            this.EditorTabPage.Controls.Add(this.EditorTextBoxComputerName);
            this.EditorTabPage.Controls.Add(this.EditorDropdownManufacturer);
            this.EditorTabPage.Location = new System.Drawing.Point(4, 24);
            this.EditorTabPage.Name = "EditorTabPage";
            this.EditorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditorTabPage.Size = new System.Drawing.Size(416, 654);
            this.EditorTabPage.TabIndex = 1;
            this.EditorTabPage.Text = "Edit Profiles";
            this.EditorTabPage.UseVisualStyleBackColor = true;
            this.EditorTabPage.Click += new System.EventHandler(this.EditorTabPage_Click);
            // 
            // EditorButtonDuplicateSubProfile
            // 
            this.EditorButtonDuplicateSubProfile.BackColor = System.Drawing.Color.NavajoWhite;
            this.EditorButtonDuplicateSubProfile.Location = new System.Drawing.Point(338, 7);
            this.EditorButtonDuplicateSubProfile.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.EditorButtonDuplicateSubProfile.Name = "EditorButtonDuplicateSubProfile";
            this.EditorButtonDuplicateSubProfile.Size = new System.Drawing.Size(33, 35);
            this.EditorButtonDuplicateSubProfile.TabIndex = 50;
            this.EditorButtonDuplicateSubProfile.Text = "D";
            this.EditorButtonDuplicateSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorButtonRemoveSubProfile
            // 
            this.EditorButtonRemoveSubProfile.BackColor = System.Drawing.Color.DarkSalmon;
            this.EditorButtonRemoveSubProfile.Location = new System.Drawing.Point(375, 7);
            this.EditorButtonRemoveSubProfile.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.EditorButtonRemoveSubProfile.Name = "EditorButtonRemoveSubProfile";
            this.EditorButtonRemoveSubProfile.Size = new System.Drawing.Size(34, 35);
            this.EditorButtonRemoveSubProfile.TabIndex = 51;
            this.EditorButtonRemoveSubProfile.Text = "R";
            this.EditorButtonRemoveSubProfile.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Profile Settings:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Select Profile Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(222, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 47;
            this.label3.Text = "Subprofiles:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Computer Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "Manufacturer:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(9, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 400);
            this.panel2.TabIndex = 43;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // EditorComboBoxProfileType
            // 
            this.EditorComboBoxProfileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditorComboBoxProfileType.FormattingEnabled = true;
            this.EditorComboBoxProfileType.Location = new System.Drawing.Point(9, 211);
            this.EditorComboBoxProfileType.Name = "EditorComboBoxProfileType";
            this.EditorComboBoxProfileType.Size = new System.Drawing.Size(179, 23);
            this.EditorComboBoxProfileType.TabIndex = 42;
            this.EditorComboBoxProfileType.SelectedIndexChanged += new System.EventHandler(this.EditorComboBoxProfileType_SelectedIndexChanged_1);
            // 
            // EditorListSubprofiles
            // 
            this.EditorListSubprofiles.FormattingEnabled = true;
            this.EditorListSubprofiles.IntegralHeight = false;
            this.EditorListSubprofiles.ItemHeight = 15;
            this.EditorListSubprofiles.Location = new System.Drawing.Point(222, 45);
            this.EditorListSubprofiles.Name = "EditorListSubprofiles";
            this.EditorListSubprofiles.Size = new System.Drawing.Size(187, 119);
            this.EditorListSubprofiles.Sorted = true;
            this.EditorListSubprofiles.TabIndex = 37;
            // 
            // EditorTextBoxComputerName
            // 
            this.EditorTextBoxComputerName.Location = new System.Drawing.Point(9, 141);
            this.EditorTextBoxComputerName.Name = "EditorTextBoxComputerName";
            this.EditorTextBoxComputerName.PlaceholderText = "Enter computer name...";
            this.EditorTextBoxComputerName.Size = new System.Drawing.Size(179, 23);
            this.EditorTextBoxComputerName.TabIndex = 36;
            // 
            // EditorDropdownManufacturer
            // 
            this.EditorDropdownManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditorDropdownManufacturer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EditorDropdownManufacturer.FormattingEnabled = true;
            this.EditorDropdownManufacturer.Location = new System.Drawing.Point(9, 75);
            this.EditorDropdownManufacturer.Name = "EditorDropdownManufacturer";
            this.EditorDropdownManufacturer.Size = new System.Drawing.Size(179, 23);
            this.EditorDropdownManufacturer.TabIndex = 35;
            this.EditorDropdownManufacturer.Text = "Select Manufacturer...";
            // 
            // EditorCheckboxFlipBytes
            // 
            this.EditorCheckboxFlipBytes.AutoSize = true;
            this.EditorCheckboxFlipBytes.Location = new System.Drawing.Point(449, 122);
            this.EditorCheckboxFlipBytes.Name = "EditorCheckboxFlipBytes";
            this.EditorCheckboxFlipBytes.Size = new System.Drawing.Size(76, 19);
            this.EditorCheckboxFlipBytes.TabIndex = 40;
            this.EditorCheckboxFlipBytes.Text = "Flip Bytes";
            this.EditorCheckboxFlipBytes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditorCheckboxFlipBytes.UseVisualStyleBackColor = true;
            // 
            // TableLayoutPanelProfileButtons
            // 
            this.TableLayoutPanelProfileButtons.ColumnCount = 3;
            this.TableLayoutPanelProfileButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanelProfileButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanelProfileButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanelProfileButtons.Controls.Add(this.EditorButtonNewProfile, 0, 0);
            this.TableLayoutPanelProfileButtons.Controls.Add(this.EditorButtonRemoveProfile, 2, 0);
            this.TableLayoutPanelProfileButtons.Controls.Add(this.EditorButtonDuplicateProfile, 1, 0);
            this.TableLayoutPanelProfileButtons.Location = new System.Drawing.Point(22, 19);
            this.TableLayoutPanelProfileButtons.Name = "TableLayoutPanelProfileButtons";
            this.TableLayoutPanelProfileButtons.RowCount = 1;
            this.TableLayoutPanelProfileButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelProfileButtons.Size = new System.Drawing.Size(236, 65);
            this.TableLayoutPanelProfileButtons.TabIndex = 53;
            // 
            // EditorButtonNewProfile
            // 
            this.EditorButtonNewProfile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EditorButtonNewProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorButtonNewProfile.Location = new System.Drawing.Point(5, 5);
            this.EditorButtonNewProfile.Margin = new System.Windows.Forms.Padding(5);
            this.EditorButtonNewProfile.Name = "EditorButtonNewProfile";
            this.EditorButtonNewProfile.Size = new System.Drawing.Size(68, 55);
            this.EditorButtonNewProfile.TabIndex = 43;
            this.EditorButtonNewProfile.Text = "New";
            this.EditorButtonNewProfile.UseVisualStyleBackColor = false;
            // 
            // EditorButtonRemoveProfile
            // 
            this.EditorButtonRemoveProfile.BackColor = System.Drawing.Color.DarkSalmon;
            this.EditorButtonRemoveProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorButtonRemoveProfile.Location = new System.Drawing.Point(161, 5);
            this.EditorButtonRemoveProfile.Margin = new System.Windows.Forms.Padding(5);
            this.EditorButtonRemoveProfile.Name = "EditorButtonRemoveProfile";
            this.EditorButtonRemoveProfile.Size = new System.Drawing.Size(70, 55);
            this.EditorButtonRemoveProfile.TabIndex = 45;
            this.EditorButtonRemoveProfile.Text = "Remove";
            this.EditorButtonRemoveProfile.UseVisualStyleBackColor = false;
            // 
            // EditorButtonDuplicateProfile
            // 
            this.EditorButtonDuplicateProfile.BackColor = System.Drawing.Color.NavajoWhite;
            this.EditorButtonDuplicateProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorButtonDuplicateProfile.Location = new System.Drawing.Point(83, 5);
            this.EditorButtonDuplicateProfile.Margin = new System.Windows.Forms.Padding(5);
            this.EditorButtonDuplicateProfile.Name = "EditorButtonDuplicateProfile";
            this.EditorButtonDuplicateProfile.Size = new System.Drawing.Size(68, 55);
            this.EditorButtonDuplicateProfile.TabIndex = 44;
            this.EditorButtonDuplicateProfile.Text = "Duplicate";
            this.EditorButtonDuplicateProfile.UseVisualStyleBackColor = false;
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
            this.EraserErrorPreview.Location = new System.Drawing.Point(289, 157);
            this.EraserErrorPreview.Name = "EraserErrorPreview";
            this.EraserErrorPreview.ReadOnly = true;
            this.EraserErrorPreview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.EraserErrorPreview.RowTemplate.Height = 25;
            this.EraserErrorPreview.RowTemplate.ReadOnly = true;
            this.EraserErrorPreview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EraserErrorPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EraserErrorPreview.Size = new System.Drawing.Size(236, 544);
            this.EraserErrorPreview.TabIndex = 52;
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
            // EraserLabelFilePath
            // 
            this.EraserLabelFilePath.Location = new System.Drawing.Point(290, 84);
            this.EraserLabelFilePath.Name = "EraserLabelFilePath";
            this.EraserLabelFilePath.Size = new System.Drawing.Size(235, 24);
            this.EraserLabelFilePath.TabIndex = 51;
            this.EraserLabelFilePath.Text = "some_binary_file_with_a_long_name.bin";
            this.EraserLabelFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EraserButtonFileBrowse
            // 
            this.EraserButtonFileBrowse.BackColor = System.Drawing.Color.LightBlue;
            this.EraserButtonFileBrowse.Location = new System.Drawing.Point(289, 22);
            this.EraserButtonFileBrowse.Name = "EraserButtonFileBrowse";
            this.EraserButtonFileBrowse.Size = new System.Drawing.Size(236, 59);
            this.EraserButtonFileBrowse.TabIndex = 50;
            this.EraserButtonFileBrowse.Text = "Open Binary...";
            this.EraserButtonFileBrowse.UseVisualStyleBackColor = false;
            // 
            // EraserTextboxProfileFilter
            // 
            this.EraserTextboxProfileFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EraserTextboxProfileFilter.Location = new System.Drawing.Point(21, 120);
            this.EraserTextboxProfileFilter.Name = "EraserTextboxProfileFilter";
            this.EraserTextboxProfileFilter.PlaceholderText = "Filter profiles...";
            this.EraserTextboxProfileFilter.Size = new System.Drawing.Size(237, 23);
            this.EraserTextboxProfileFilter.TabIndex = 49;
            // 
            // EraserListProfiles
            // 
            this.EraserListProfiles.FormattingEnabled = true;
            this.EraserListProfiles.ItemHeight = 15;
            this.EraserListProfiles.Location = new System.Drawing.Point(22, 157);
            this.EraserListProfiles.Name = "EraserListProfiles";
            this.EraserListProfiles.Size = new System.Drawing.Size(236, 544);
            this.EraserListProfiles.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(289, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Preview:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(992, 725);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TableLayoutPanelProfileButtons);
            this.Controls.Add(this.EraserErrorPreview);
            this.Controls.Add(this.EraserLabelFilePath);
            this.Controls.Add(this.EraserButtonFileBrowse);
            this.Controls.Add(this.EraserTextboxProfileFilter);
            this.Controls.Add(this.EraserListProfiles);
            this.Controls.Add(this.EditorCheckboxFlipBytes);
            this.Name = "Main";
            this.Text = "OBD Error Erase";
            this.TabControl.ResumeLayout(false);
            this.EraserTabPage.ResumeLayout(false);
            this.EraserTabPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.EraserPanelErrorPresets.ResumeLayout(false);
            this.EraserPanelErrorPresets.PerformLayout();
            this.EditorTabPage.ResumeLayout(false);
            this.EditorTabPage.PerformLayout();
            this.TableLayoutPanelProfileButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EraserErrorPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}