namespace OBDErrorErase
{
    public partial class Main : Form
    {
        public const string NAME_ERASER_TAB_PAGE = "EraserTabPage";

        public Main()
        {
            InitializeComponent();
            InitGUI();
        }

        private void InitializeComponent()
        {
            MainTabControl = new TabControl();
            EraserTabPage = new TabPage();
            splitContainer8 = new SplitContainer();
            splitContainer9 = new SplitContainer();
            splitContainer10 = new SplitContainer();
            EraserLabelRefresh = new Label();
            EraserButtonRefreshPresetList = new Button();
            EraserLabelPresetSelect = new Label();
            splitContainer11 = new SplitContainer();
            EraserPanelErrorPresets = new Panel();
            EraserTableLayoutErrorPresets = new TableLayoutPanel();
            EraserTextboxErrorList = new TextBox();
            splitContainer12 = new SplitContainer();
            EraserLabelMapSelect = new Label();
            EraserCheckBoxSelectAllMaps = new CheckBox();
            splitContainer13 = new SplitContainer();
            EraserPanelMapSelector = new Panel();
            EraserTableLayoutMapSelector = new TableLayoutPanel();
            EraserButtonRun = new Button();
            EditorTabPage = new TabPage();
            splitContainer14 = new SplitContainer();
            splitContainer17 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            EditorLabelProfileSettings = new Label();
            EditorLabelManufacturer = new Label();
            EditorDropdownManufacturer = new ComboBox();
            EditorLabelName = new Label();
            EditorTextBoxComputerName = new TextBox();
            splitContainer18 = new SplitContainer();
            splitContainer19 = new SplitContainer();
            EditorButtonDuplicateSubProfile = new Button();
            EditorButtonRemoveSubProfile = new Button();
            EditorLabelSubprofiles = new Label();
            EditorListSubprofiles = new ListBox();
            splitContainer15 = new SplitContainer();
            EditorGroupBox = new GroupBox();
            splitContainer16 = new SplitContainer();
            EditorComboBoxProfileType = new ComboBox();
            EditorLabelProfileTypeSelect = new Label();
            EditorPanelEditFrame = new Panel();
            EditorButtonSaveProfile = new Button();
            EraserLabelErrorCounter = new Label();
            MainCheckboxFlipBytes = new CheckBox();
            MainDataGridFilePreview = new DataGridView();
            DataGridViewFilePreviewColumnAddress = new DataGridViewTextBoxColumn();
            DataGridViewFilePreviewColumnError = new DataGridViewTextBoxColumn();
            MainButtonFileBrowse = new Button();
            MainTextboxProfileFilter = new TextBox();
            MainListProfiles = new ListBox();
            MainLabelPreviewFile = new Label();
            groupBox1 = new GroupBox();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            MainButtonDuplicateProfile = new Button();
            MainButtonNewProfile = new Button();
            MainButtonRemoveProfile = new Button();
            groupBox2 = new GroupBox();
            splitContainer6 = new SplitContainer();
            splitContainer5 = new SplitContainer();
            splitContainer7 = new SplitContainer();
            MainLabelLoadedBinaryFile = new Label();
            MainLabelBinaryFilename = new Label();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            MainTabControl.SuspendLayout();
            EraserTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer8).BeginInit();
            splitContainer8.Panel1.SuspendLayout();
            splitContainer8.Panel2.SuspendLayout();
            splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer9).BeginInit();
            splitContainer9.Panel1.SuspendLayout();
            splitContainer9.Panel2.SuspendLayout();
            splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer10).BeginInit();
            splitContainer10.Panel1.SuspendLayout();
            splitContainer10.Panel2.SuspendLayout();
            splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).BeginInit();
            splitContainer11.Panel1.SuspendLayout();
            splitContainer11.Panel2.SuspendLayout();
            splitContainer11.SuspendLayout();
            EraserPanelErrorPresets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer12).BeginInit();
            splitContainer12.Panel1.SuspendLayout();
            splitContainer12.Panel2.SuspendLayout();
            splitContainer12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer13).BeginInit();
            splitContainer13.Panel1.SuspendLayout();
            splitContainer13.Panel2.SuspendLayout();
            splitContainer13.SuspendLayout();
            EraserPanelMapSelector.SuspendLayout();
            EditorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer14).BeginInit();
            splitContainer14.Panel1.SuspendLayout();
            splitContainer14.Panel2.SuspendLayout();
            splitContainer14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer17).BeginInit();
            splitContainer17.Panel1.SuspendLayout();
            splitContainer17.Panel2.SuspendLayout();
            splitContainer17.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer18).BeginInit();
            splitContainer18.Panel1.SuspendLayout();
            splitContainer18.Panel2.SuspendLayout();
            splitContainer18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer19).BeginInit();
            splitContainer19.Panel1.SuspendLayout();
            splitContainer19.Panel2.SuspendLayout();
            splitContainer19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer15).BeginInit();
            splitContainer15.Panel1.SuspendLayout();
            splitContainer15.Panel2.SuspendLayout();
            splitContainer15.SuspendLayout();
            EditorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer16).BeginInit();
            splitContainer16.Panel1.SuspendLayout();
            splitContainer16.Panel2.SuspendLayout();
            splitContainer16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridFilePreview).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer6).BeginInit();
            splitContainer6.Panel1.SuspendLayout();
            splitContainer6.Panel2.SuspendLayout();
            splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer7).BeginInit();
            splitContainer7.Panel1.SuspendLayout();
            splitContainer7.Panel2.SuspendLayout();
            splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EraserTabPage);
            MainTabControl.Controls.Add(EditorTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Margin = new Padding(5);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(614, 859);
            MainTabControl.TabIndex = 54;
            // 
            // EraserTabPage
            // 
            EraserTabPage.BackColor = Color.Transparent;
            EraserTabPage.Controls.Add(splitContainer8);
            EraserTabPage.Location = new Point(4, 30);
            EraserTabPage.Name = "EraserTabPage";
            EraserTabPage.Padding = new Padding(3);
            EraserTabPage.Size = new Size(606, 825);
            EraserTabPage.TabIndex = 0;
            EraserTabPage.Text = "Erase Errors";
            // 
            // splitContainer8
            // 
            splitContainer8.BackColor = Color.Transparent;
            splitContainer8.Dock = DockStyle.Fill;
            splitContainer8.IsSplitterFixed = true;
            splitContainer8.Location = new Point(3, 3);
            splitContainer8.Name = "splitContainer8";
            splitContainer8.Orientation = Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            splitContainer8.Panel1.Controls.Add(splitContainer9);
            // 
            // splitContainer8.Panel2
            // 
            splitContainer8.Panel2.Controls.Add(splitContainer12);
            splitContainer8.Size = new Size(600, 819);
            splitContainer8.SplitterDistance = 333;
            splitContainer8.SplitterWidth = 20;
            splitContainer8.TabIndex = 0;
            // 
            // splitContainer9
            // 
            splitContainer9.Dock = DockStyle.Fill;
            splitContainer9.Location = new Point(0, 0);
            splitContainer9.Name = "splitContainer9";
            splitContainer9.Orientation = Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            splitContainer9.Panel1.Controls.Add(splitContainer10);
            splitContainer9.Panel1.Controls.Add(EraserLabelPresetSelect);
            // 
            // splitContainer9.Panel2
            // 
            splitContainer9.Panel2.Controls.Add(splitContainer11);
            splitContainer9.Size = new Size(600, 333);
            splitContainer9.SplitterDistance = 45;
            splitContainer9.TabIndex = 0;
            // 
            // splitContainer10
            // 
            splitContainer10.Dock = DockStyle.Right;
            splitContainer10.Location = new Point(474, 0);
            splitContainer10.Name = "splitContainer10";
            // 
            // splitContainer10.Panel1
            // 
            splitContainer10.Panel1.Controls.Add(EraserLabelRefresh);
            // 
            // splitContainer10.Panel2
            // 
            splitContainer10.Panel2.Controls.Add(EraserButtonRefreshPresetList);
            splitContainer10.Size = new Size(126, 45);
            splitContainer10.SplitterDistance = 67;
            splitContainer10.TabIndex = 60;
            // 
            // EraserLabelRefresh
            // 
            EraserLabelRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            EraserLabelRefresh.AutoSize = true;
            EraserLabelRefresh.Location = new Point(3, 14);
            EraserLabelRefresh.Name = "EraserLabelRefresh";
            EraserLabelRefresh.Size = new Size(63, 21);
            EraserLabelRefresh.TabIndex = 54;
            EraserLabelRefresh.Text = "Refresh";
            // 
            // EraserButtonRefreshPresetList
            // 
            EraserButtonRefreshPresetList.BackColor = Color.Transparent;
            EraserButtonRefreshPresetList.BackgroundImage = Properties.Resources.ButtonRefresh;
            EraserButtonRefreshPresetList.BackgroundImageLayout = ImageLayout.Center;
            EraserButtonRefreshPresetList.Dock = DockStyle.Fill;
            EraserButtonRefreshPresetList.FlatAppearance.BorderSize = 0;
            EraserButtonRefreshPresetList.FlatStyle = FlatStyle.Flat;
            EraserButtonRefreshPresetList.Location = new Point(0, 0);
            EraserButtonRefreshPresetList.MinimumSize = new Size(32, 32);
            EraserButtonRefreshPresetList.Name = "EraserButtonRefreshPresetList";
            EraserButtonRefreshPresetList.Size = new Size(55, 45);
            EraserButtonRefreshPresetList.TabIndex = 46;
            EraserButtonRefreshPresetList.UseVisualStyleBackColor = false;
            // 
            // EraserLabelPresetSelect
            // 
            EraserLabelPresetSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EraserLabelPresetSelect.AutoSize = true;
            EraserLabelPresetSelect.Location = new Point(1, 19);
            EraserLabelPresetSelect.Name = "EraserLabelPresetSelect";
            EraserLabelPresetSelect.Size = new Size(219, 21);
            EraserLabelPresetSelect.TabIndex = 48;
            EraserLabelPresetSelect.Text = "Select error presets to include:";
            // 
            // splitContainer11
            // 
            splitContainer11.Dock = DockStyle.Fill;
            splitContainer11.Location = new Point(0, 0);
            splitContainer11.Name = "splitContainer11";
            splitContainer11.Orientation = Orientation.Horizontal;
            // 
            // splitContainer11.Panel1
            // 
            splitContainer11.Panel1.Controls.Add(EraserPanelErrorPresets);
            // 
            // splitContainer11.Panel2
            // 
            splitContainer11.Panel2.Controls.Add(EraserTextboxErrorList);
            splitContainer11.Size = new Size(600, 284);
            splitContainer11.SplitterDistance = 202;
            splitContainer11.TabIndex = 0;
            // 
            // EraserPanelErrorPresets
            // 
            EraserPanelErrorPresets.AutoScroll = true;
            EraserPanelErrorPresets.AutoScrollMinSize = new Size(250, 0);
            EraserPanelErrorPresets.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EraserPanelErrorPresets.BackColor = SystemColors.Window;
            EraserPanelErrorPresets.BorderStyle = BorderStyle.FixedSingle;
            EraserPanelErrorPresets.Controls.Add(EraserTableLayoutErrorPresets);
            EraserPanelErrorPresets.Dock = DockStyle.Fill;
            EraserPanelErrorPresets.Location = new Point(0, 0);
            EraserPanelErrorPresets.Name = "EraserPanelErrorPresets";
            EraserPanelErrorPresets.Size = new Size(600, 202);
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
            // EraserTextboxErrorList
            // 
            EraserTextboxErrorList.Dock = DockStyle.Fill;
            EraserTextboxErrorList.Location = new Point(0, 0);
            EraserTextboxErrorList.Multiline = true;
            EraserTextboxErrorList.Name = "EraserTextboxErrorList";
            EraserTextboxErrorList.PlaceholderText = "Enter a list of errors, separated by commas (e.g. a1c7, 1600, 8461, e56f...):";
            EraserTextboxErrorList.ScrollBars = ScrollBars.Vertical;
            EraserTextboxErrorList.Size = new Size(600, 78);
            EraserTextboxErrorList.TabIndex = 49;
            // 
            // splitContainer12
            // 
            splitContainer12.Dock = DockStyle.Fill;
            splitContainer12.Location = new Point(0, 0);
            splitContainer12.Name = "splitContainer12";
            splitContainer12.Orientation = Orientation.Horizontal;
            // 
            // splitContainer12.Panel1
            // 
            splitContainer12.Panel1.Controls.Add(EraserLabelMapSelect);
            splitContainer12.Panel1.Controls.Add(EraserCheckBoxSelectAllMaps);
            // 
            // splitContainer12.Panel2
            // 
            splitContainer12.Panel2.Controls.Add(splitContainer13);
            splitContainer12.Size = new Size(600, 466);
            splitContainer12.SplitterDistance = 35;
            splitContainer12.TabIndex = 0;
            // 
            // EraserLabelMapSelect
            // 
            EraserLabelMapSelect.AutoSize = true;
            EraserLabelMapSelect.Dock = DockStyle.Left;
            EraserLabelMapSelect.Location = new Point(0, 0);
            EraserLabelMapSelect.Name = "EraserLabelMapSelect";
            EraserLabelMapSelect.Size = new Size(167, 21);
            EraserLabelMapSelect.TabIndex = 47;
            EraserLabelMapSelect.Text = "Select maps to modify:";
            // 
            // EraserCheckBoxSelectAllMaps
            // 
            EraserCheckBoxSelectAllMaps.AutoSize = true;
            EraserCheckBoxSelectAllMaps.Dock = DockStyle.Right;
            EraserCheckBoxSelectAllMaps.Location = new Point(508, 0);
            EraserCheckBoxSelectAllMaps.MaximumSize = new Size(0, 21);
            EraserCheckBoxSelectAllMaps.Name = "EraserCheckBoxSelectAllMaps";
            EraserCheckBoxSelectAllMaps.Size = new Size(92, 21);
            EraserCheckBoxSelectAllMaps.TabIndex = 53;
            EraserCheckBoxSelectAllMaps.Text = "Select All";
            EraserCheckBoxSelectAllMaps.UseVisualStyleBackColor = true;
            // 
            // splitContainer13
            // 
            splitContainer13.Dock = DockStyle.Fill;
            splitContainer13.FixedPanel = FixedPanel.Panel2;
            splitContainer13.Location = new Point(0, 0);
            splitContainer13.Name = "splitContainer13";
            splitContainer13.Orientation = Orientation.Horizontal;
            // 
            // splitContainer13.Panel1
            // 
            splitContainer13.Panel1.Controls.Add(EraserPanelMapSelector);
            // 
            // splitContainer13.Panel2
            // 
            splitContainer13.Panel2.Controls.Add(EraserButtonRun);
            splitContainer13.Panel2MinSize = 70;
            splitContainer13.Size = new Size(600, 427);
            splitContainer13.SplitterDistance = 353;
            splitContainer13.TabIndex = 0;
            // 
            // EraserPanelMapSelector
            // 
            EraserPanelMapSelector.AutoScroll = true;
            EraserPanelMapSelector.AutoScrollMinSize = new Size(250, 0);
            EraserPanelMapSelector.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EraserPanelMapSelector.BackColor = SystemColors.Window;
            EraserPanelMapSelector.BorderStyle = BorderStyle.FixedSingle;
            EraserPanelMapSelector.Controls.Add(EraserTableLayoutMapSelector);
            EraserPanelMapSelector.Dock = DockStyle.Fill;
            EraserPanelMapSelector.Location = new Point(0, 0);
            EraserPanelMapSelector.Name = "EraserPanelMapSelector";
            EraserPanelMapSelector.Size = new Size(600, 353);
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
            EraserTableLayoutMapSelector.MinimumSize = new Size(300, 25);
            EraserTableLayoutMapSelector.Name = "EraserTableLayoutMapSelector";
            EraserTableLayoutMapSelector.Padding = new Padding(0, 3, 0, 3);
            EraserTableLayoutMapSelector.RowCount = 1;
            EraserTableLayoutMapSelector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EraserTableLayoutMapSelector.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            EraserTableLayoutMapSelector.Size = new Size(598, 25);
            EraserTableLayoutMapSelector.TabIndex = 42;
            // 
            // EraserButtonRun
            // 
            EraserButtonRun.BackColor = Color.DarkSeaGreen;
            EraserButtonRun.Dock = DockStyle.Fill;
            EraserButtonRun.FlatAppearance.BorderColor = Color.White;
            EraserButtonRun.FlatAppearance.BorderSize = 0;
            EraserButtonRun.FlatStyle = FlatStyle.Flat;
            EraserButtonRun.Location = new Point(0, 0);
            EraserButtonRun.MinimumSize = new Size(0, 70);
            EraserButtonRun.Name = "EraserButtonRun";
            EraserButtonRun.Size = new Size(600, 70);
            EraserButtonRun.TabIndex = 44;
            EraserButtonRun.Text = "Erase Errors";
            EraserButtonRun.UseVisualStyleBackColor = false;
            // 
            // EditorTabPage
            // 
            EditorTabPage.Controls.Add(splitContainer14);
            EditorTabPage.Location = new Point(4, 30);
            EditorTabPage.Name = "EditorTabPage";
            EditorTabPage.Padding = new Padding(3);
            EditorTabPage.Size = new Size(606, 825);
            EditorTabPage.TabIndex = 1;
            EditorTabPage.Text = "Edit Profiles";
            EditorTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer14
            // 
            splitContainer14.Dock = DockStyle.Fill;
            splitContainer14.Location = new Point(3, 3);
            splitContainer14.Name = "splitContainer14";
            splitContainer14.Orientation = Orientation.Horizontal;
            // 
            // splitContainer14.Panel1
            // 
            splitContainer14.Panel1.Controls.Add(splitContainer17);
            // 
            // splitContainer14.Panel2
            // 
            splitContainer14.Panel2.Controls.Add(splitContainer15);
            splitContainer14.Size = new Size(600, 819);
            splitContainer14.SplitterDistance = 197;
            splitContainer14.SplitterWidth = 10;
            splitContainer14.TabIndex = 0;
            // 
            // splitContainer17
            // 
            splitContainer17.Dock = DockStyle.Fill;
            splitContainer17.Location = new Point(0, 0);
            splitContainer17.Name = "splitContainer17";
            // 
            // splitContainer17.Panel1
            // 
            splitContainer17.Panel1.Controls.Add(tableLayoutPanel2);
            // 
            // splitContainer17.Panel2
            // 
            splitContainer17.Panel2.Controls.Add(splitContainer18);
            splitContainer17.Size = new Size(600, 197);
            splitContainer17.SplitterDistance = 300;
            splitContainer17.SplitterWidth = 8;
            splitContainer17.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(EditorLabelProfileSettings, 0, 0);
            tableLayoutPanel2.Controls.Add(EditorLabelManufacturer, 0, 1);
            tableLayoutPanel2.Controls.Add(EditorDropdownManufacturer, 0, 2);
            tableLayoutPanel2.Controls.Add(EditorLabelName, 0, 3);
            tableLayoutPanel2.Controls.Add(EditorTextBoxComputerName, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.31579F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7894735F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0526314F));
            tableLayoutPanel2.Size = new Size(300, 197);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // EditorLabelProfileSettings
            // 
            EditorLabelProfileSettings.AutoSize = true;
            EditorLabelProfileSettings.Dock = DockStyle.Top;
            EditorLabelProfileSettings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorLabelProfileSettings.Location = new Point(3, 0);
            EditorLabelProfileSettings.Name = "EditorLabelProfileSettings";
            EditorLabelProfileSettings.Size = new Size(294, 15);
            EditorLabelProfileSettings.TabIndex = 49;
            EditorLabelProfileSettings.Text = "Profile Settings:";
            // 
            // EditorLabelManufacturer
            // 
            EditorLabelManufacturer.AutoSize = true;
            EditorLabelManufacturer.Dock = DockStyle.Bottom;
            EditorLabelManufacturer.Location = new Point(3, 61);
            EditorLabelManufacturer.Name = "EditorLabelManufacturer";
            EditorLabelManufacturer.Size = new Size(294, 21);
            EditorLabelManufacturer.TabIndex = 45;
            EditorLabelManufacturer.Text = "Manufacturer:";
            // 
            // EditorDropdownManufacturer
            // 
            EditorDropdownManufacturer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EditorDropdownManufacturer.AutoCompleteSource = AutoCompleteSource.ListItems;
            EditorDropdownManufacturer.Dock = DockStyle.Top;
            EditorDropdownManufacturer.FormattingEnabled = true;
            EditorDropdownManufacturer.Location = new Point(3, 85);
            EditorDropdownManufacturer.Name = "EditorDropdownManufacturer";
            EditorDropdownManufacturer.Size = new Size(294, 29);
            EditorDropdownManufacturer.TabIndex = 35;
            EditorDropdownManufacturer.Text = "Select Manufacturer...";
            // 
            // EditorLabelName
            // 
            EditorLabelName.AutoSize = true;
            EditorLabelName.Dock = DockStyle.Bottom;
            EditorLabelName.Location = new Point(3, 133);
            EditorLabelName.Name = "EditorLabelName";
            EditorLabelName.Size = new Size(294, 21);
            EditorLabelName.TabIndex = 46;
            EditorLabelName.Text = "Computer Model:";
            // 
            // EditorTextBoxComputerName
            // 
            EditorTextBoxComputerName.Dock = DockStyle.Top;
            EditorTextBoxComputerName.Location = new Point(3, 157);
            EditorTextBoxComputerName.Name = "EditorTextBoxComputerName";
            EditorTextBoxComputerName.PlaceholderText = "Enter computer name...";
            EditorTextBoxComputerName.Size = new Size(294, 29);
            EditorTextBoxComputerName.TabIndex = 36;
            // 
            // splitContainer18
            // 
            splitContainer18.Dock = DockStyle.Fill;
            splitContainer18.Location = new Point(0, 0);
            splitContainer18.Name = "splitContainer18";
            splitContainer18.Orientation = Orientation.Horizontal;
            // 
            // splitContainer18.Panel1
            // 
            splitContainer18.Panel1.Controls.Add(splitContainer19);
            splitContainer18.Panel1.Controls.Add(EditorLabelSubprofiles);
            // 
            // splitContainer18.Panel2
            // 
            splitContainer18.Panel2.Controls.Add(EditorListSubprofiles);
            splitContainer18.Size = new Size(292, 197);
            splitContainer18.SplitterDistance = 58;
            splitContainer18.TabIndex = 0;
            // 
            // splitContainer19
            // 
            splitContainer19.Dock = DockStyle.Right;
            splitContainer19.Location = new Point(202, 0);
            splitContainer19.Name = "splitContainer19";
            // 
            // splitContainer19.Panel1
            // 
            splitContainer19.Panel1.Controls.Add(EditorButtonDuplicateSubProfile);
            // 
            // splitContainer19.Panel2
            // 
            splitContainer19.Panel2.Controls.Add(EditorButtonRemoveSubProfile);
            splitContainer19.Size = new Size(90, 58);
            splitContainer19.SplitterDistance = 44;
            splitContainer19.TabIndex = 0;
            // 
            // EditorButtonDuplicateSubProfile
            // 
            EditorButtonDuplicateSubProfile.BackColor = Color.Transparent;
            EditorButtonDuplicateSubProfile.BackgroundImage = Properties.Resources.Duplicate1;
            EditorButtonDuplicateSubProfile.BackgroundImageLayout = ImageLayout.Center;
            EditorButtonDuplicateSubProfile.Dock = DockStyle.Fill;
            EditorButtonDuplicateSubProfile.FlatAppearance.BorderSize = 0;
            EditorButtonDuplicateSubProfile.FlatStyle = FlatStyle.Flat;
            EditorButtonDuplicateSubProfile.Location = new Point(0, 0);
            EditorButtonDuplicateSubProfile.Margin = new Padding(30, 15, 30, 15);
            EditorButtonDuplicateSubProfile.MinimumSize = new Size(36, 36);
            EditorButtonDuplicateSubProfile.Name = "EditorButtonDuplicateSubProfile";
            EditorButtonDuplicateSubProfile.Size = new Size(44, 58);
            EditorButtonDuplicateSubProfile.TabIndex = 50;
            EditorButtonDuplicateSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorButtonRemoveSubProfile
            // 
            EditorButtonRemoveSubProfile.BackColor = Color.Transparent;
            EditorButtonRemoveSubProfile.BackgroundImage = Properties.Resources.Delete1;
            EditorButtonRemoveSubProfile.BackgroundImageLayout = ImageLayout.Center;
            EditorButtonRemoveSubProfile.Dock = DockStyle.Fill;
            EditorButtonRemoveSubProfile.FlatAppearance.BorderSize = 0;
            EditorButtonRemoveSubProfile.FlatStyle = FlatStyle.Flat;
            EditorButtonRemoveSubProfile.Location = new Point(0, 0);
            EditorButtonRemoveSubProfile.Margin = new Padding(30, 15, 30, 15);
            EditorButtonRemoveSubProfile.MinimumSize = new Size(36, 36);
            EditorButtonRemoveSubProfile.Name = "EditorButtonRemoveSubProfile";
            EditorButtonRemoveSubProfile.Size = new Size(42, 58);
            EditorButtonRemoveSubProfile.TabIndex = 51;
            EditorButtonRemoveSubProfile.UseVisualStyleBackColor = false;
            // 
            // EditorLabelSubprofiles
            // 
            EditorLabelSubprofiles.Anchor = AnchorStyles.Left;
            EditorLabelSubprofiles.AutoSize = true;
            EditorLabelSubprofiles.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorLabelSubprofiles.Location = new Point(3, 23);
            EditorLabelSubprofiles.Name = "EditorLabelSubprofiles";
            EditorLabelSubprofiles.Size = new Size(73, 15);
            EditorLabelSubprofiles.TabIndex = 47;
            EditorLabelSubprofiles.Text = "Subprofiles:";
            // 
            // EditorListSubprofiles
            // 
            EditorListSubprofiles.Dock = DockStyle.Fill;
            EditorListSubprofiles.FormattingEnabled = true;
            EditorListSubprofiles.IntegralHeight = false;
            EditorListSubprofiles.ItemHeight = 21;
            EditorListSubprofiles.Location = new Point(0, 0);
            EditorListSubprofiles.Name = "EditorListSubprofiles";
            EditorListSubprofiles.Size = new Size(292, 135);
            EditorListSubprofiles.Sorted = true;
            EditorListSubprofiles.TabIndex = 37;
            // 
            // splitContainer15
            // 
            splitContainer15.Dock = DockStyle.Fill;
            splitContainer15.FixedPanel = FixedPanel.Panel2;
            splitContainer15.Location = new Point(0, 0);
            splitContainer15.Name = "splitContainer15";
            splitContainer15.Orientation = Orientation.Horizontal;
            // 
            // splitContainer15.Panel1
            // 
            splitContainer15.Panel1.Controls.Add(EditorGroupBox);
            // 
            // splitContainer15.Panel2
            // 
            splitContainer15.Panel2.Controls.Add(EditorButtonSaveProfile);
            splitContainer15.Panel2MinSize = 70;
            splitContainer15.Size = new Size(600, 612);
            splitContainer15.SplitterDistance = 537;
            splitContainer15.TabIndex = 0;
            // 
            // EditorGroupBox
            // 
            EditorGroupBox.Controls.Add(splitContainer16);
            EditorGroupBox.Dock = DockStyle.Fill;
            EditorGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EditorGroupBox.Location = new Point(0, 0);
            EditorGroupBox.Name = "EditorGroupBox";
            EditorGroupBox.Size = new Size(600, 537);
            EditorGroupBox.TabIndex = 52;
            EditorGroupBox.TabStop = false;
            EditorGroupBox.Text = "Editor";
            // 
            // splitContainer16
            // 
            splitContainer16.Dock = DockStyle.Fill;
            splitContainer16.FixedPanel = FixedPanel.Panel1;
            splitContainer16.Location = new Point(3, 19);
            splitContainer16.Name = "splitContainer16";
            splitContainer16.Orientation = Orientation.Horizontal;
            // 
            // splitContainer16.Panel1
            // 
            splitContainer16.Panel1.Controls.Add(EditorComboBoxProfileType);
            splitContainer16.Panel1.Controls.Add(EditorLabelProfileTypeSelect);
            // 
            // splitContainer16.Panel2
            // 
            splitContainer16.Panel2.Controls.Add(EditorPanelEditFrame);
            splitContainer16.Size = new Size(594, 515);
            splitContainer16.SplitterDistance = 25;
            splitContainer16.TabIndex = 0;
            // 
            // EditorComboBoxProfileType
            // 
            EditorComboBoxProfileType.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            EditorComboBoxProfileType.DropDownStyle = ComboBoxStyle.DropDownList;
            EditorComboBoxProfileType.FormattingEnabled = true;
            EditorComboBoxProfileType.Location = new Point(415, 2);
            EditorComboBoxProfileType.Name = "EditorComboBoxProfileType";
            EditorComboBoxProfileType.Size = new Size(179, 23);
            EditorComboBoxProfileType.TabIndex = 42;
            // 
            // EditorLabelProfileTypeSelect
            // 
            EditorLabelProfileTypeSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditorLabelProfileTypeSelect.AutoSize = true;
            EditorLabelProfileTypeSelect.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EditorLabelProfileTypeSelect.Location = new Point(0, 5);
            EditorLabelProfileTypeSelect.Name = "EditorLabelProfileTypeSelect";
            EditorLabelProfileTypeSelect.Size = new Size(105, 15);
            EditorLabelProfileTypeSelect.TabIndex = 48;
            EditorLabelProfileTypeSelect.Text = "Select Profile Type:";
            // 
            // EditorPanelEditFrame
            // 
            EditorPanelEditFrame.Dock = DockStyle.Fill;
            EditorPanelEditFrame.Location = new Point(0, 0);
            EditorPanelEditFrame.Name = "EditorPanelEditFrame";
            EditorPanelEditFrame.Size = new Size(594, 486);
            EditorPanelEditFrame.TabIndex = 43;
            // 
            // EditorButtonSaveProfile
            // 
            EditorButtonSaveProfile.BackColor = Color.DarkSeaGreen;
            EditorButtonSaveProfile.Dock = DockStyle.Fill;
            EditorButtonSaveProfile.FlatAppearance.BorderColor = Color.White;
            EditorButtonSaveProfile.FlatAppearance.BorderSize = 0;
            EditorButtonSaveProfile.FlatStyle = FlatStyle.Flat;
            EditorButtonSaveProfile.Location = new Point(0, 0);
            EditorButtonSaveProfile.MinimumSize = new Size(0, 70);
            EditorButtonSaveProfile.Name = "EditorButtonSaveProfile";
            EditorButtonSaveProfile.Size = new Size(600, 71);
            EditorButtonSaveProfile.TabIndex = 53;
            EditorButtonSaveProfile.Text = "Save Profile";
            EditorButtonSaveProfile.UseVisualStyleBackColor = false;
            // 
            // EraserLabelErrorCounter
            // 
            EraserLabelErrorCounter.Location = new Point(1102, 715);
            EraserLabelErrorCounter.Name = "EraserLabelErrorCounter";
            EraserLabelErrorCounter.Size = new Size(300, 31);
            EraserLabelErrorCounter.TabIndex = 45;
            EraserLabelErrorCounter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainCheckboxFlipBytes
            // 
            MainCheckboxFlipBytes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MainCheckboxFlipBytes.AutoSize = true;
            MainCheckboxFlipBytes.Location = new Point(321, 63);
            MainCheckboxFlipBytes.Name = "MainCheckboxFlipBytes";
            MainCheckboxFlipBytes.Size = new Size(79, 19);
            MainCheckboxFlipBytes.TabIndex = 40;
            MainCheckboxFlipBytes.Text = "Flip Bytes";
            MainCheckboxFlipBytes.TextAlign = ContentAlignment.MiddleRight;
            MainCheckboxFlipBytes.UseVisualStyleBackColor = true;
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
            MainDataGridFilePreview.Dock = DockStyle.Fill;
            MainDataGridFilePreview.EditMode = DataGridViewEditMode.EditProgrammatically;
            MainDataGridFilePreview.Location = new Point(0, 0);
            MainDataGridFilePreview.Name = "MainDataGridFilePreview";
            MainDataGridFilePreview.ReadOnly = true;
            MainDataGridFilePreview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MainDataGridFilePreview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            MainDataGridFilePreview.RowTemplate.Height = 25;
            MainDataGridFilePreview.RowTemplate.ReadOnly = true;
            MainDataGridFilePreview.RowTemplate.Resizable = DataGridViewTriState.False;
            MainDataGridFilePreview.SelectionMode = DataGridViewSelectionMode.CellSelect;
            MainDataGridFilePreview.Size = new Size(400, 640);
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
            // MainButtonFileBrowse
            // 
            MainButtonFileBrowse.AllowDrop = true;
            MainButtonFileBrowse.BackColor = Color.AliceBlue;
            MainButtonFileBrowse.BackgroundImage = Properties.Resources.ButtonUpload;
            MainButtonFileBrowse.BackgroundImageLayout = ImageLayout.Center;
            MainButtonFileBrowse.Dock = DockStyle.Fill;
            MainButtonFileBrowse.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            MainButtonFileBrowse.FlatStyle = FlatStyle.Flat;
            MainButtonFileBrowse.Location = new Point(0, 0);
            MainButtonFileBrowse.MinimumSize = new Size(36, 36);
            MainButtonFileBrowse.Name = "MainButtonFileBrowse";
            MainButtonFileBrowse.Size = new Size(400, 91);
            MainButtonFileBrowse.TabIndex = 50;
            MainButtonFileBrowse.UseVisualStyleBackColor = false;
            // 
            // MainTextboxProfileFilter
            // 
            MainTextboxProfileFilter.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            MainTextboxProfileFilter.Dock = DockStyle.Bottom;
            MainTextboxProfileFilter.Location = new Point(0, 59);
            MainTextboxProfileFilter.Name = "MainTextboxProfileFilter";
            MainTextboxProfileFilter.PlaceholderText = "Filter profiles...";
            MainTextboxProfileFilter.Size = new Size(411, 23);
            MainTextboxProfileFilter.TabIndex = 49;
            // 
            // MainListProfiles
            // 
            MainListProfiles.Dock = DockStyle.Fill;
            MainListProfiles.FormattingEnabled = true;
            MainListProfiles.IntegralHeight = false;
            MainListProfiles.ItemHeight = 15;
            MainListProfiles.Location = new Point(0, 0);
            MainListProfiles.Name = "MainListProfiles";
            MainListProfiles.Size = new Size(411, 640);
            MainListProfiles.TabIndex = 48;
            // 
            // MainLabelPreviewFile
            // 
            MainLabelPreviewFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainLabelPreviewFile.Location = new Point(3, 47);
            MainLabelPreviewFile.Name = "MainLabelPreviewFile";
            MainLabelPreviewFile.Size = new Size(112, 24);
            MainLabelPreviewFile.TabIndex = 55;
            MainLabelPreviewFile.Text = "Preview:";
            MainLabelPreviewFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitContainer3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 859);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profiles";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 19);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(MainListProfiles);
            splitContainer3.Size = new Size(411, 837);
            splitContainer3.SplitterDistance = 187;
            splitContainer3.SplitterWidth = 10;
            splitContainer3.TabIndex = 59;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(tableLayoutPanel1);
            splitContainer4.Panel1MinSize = 0;
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(MainTextboxProfileFilter);
            splitContainer4.Panel2.Padding = new Padding(0, 0, 0, 10);
            splitContainer4.Panel2MinSize = 0;
            splitContainer4.Size = new Size(411, 187);
            splitContainer4.SplitterDistance = 91;
            splitContainer4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(MainButtonDuplicateProfile, 1, 0);
            tableLayoutPanel1.Controls.Add(MainButtonNewProfile, 0, 0);
            tableLayoutPanel1.Controls.Add(MainButtonRemoveProfile, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(411, 91);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MainButtonDuplicateProfile
            // 
            MainButtonDuplicateProfile.BackColor = Color.Transparent;
            MainButtonDuplicateProfile.BackgroundImage = Properties.Resources.Duplicate1;
            MainButtonDuplicateProfile.BackgroundImageLayout = ImageLayout.Center;
            MainButtonDuplicateProfile.Dock = DockStyle.Fill;
            MainButtonDuplicateProfile.FlatAppearance.BorderSize = 0;
            MainButtonDuplicateProfile.FlatStyle = FlatStyle.Flat;
            MainButtonDuplicateProfile.Location = new Point(156, 5);
            MainButtonDuplicateProfile.Margin = new Padding(20, 5, 20, 5);
            MainButtonDuplicateProfile.MinimumSize = new Size(36, 36);
            MainButtonDuplicateProfile.Name = "MainButtonDuplicateProfile";
            MainButtonDuplicateProfile.Padding = new Padding(20, 0, 20, 0);
            MainButtonDuplicateProfile.Size = new Size(97, 81);
            MainButtonDuplicateProfile.TabIndex = 44;
            MainButtonDuplicateProfile.UseVisualStyleBackColor = false;
            // 
            // MainButtonNewProfile
            // 
            MainButtonNewProfile.BackColor = Color.Transparent;
            MainButtonNewProfile.BackgroundImage = Properties.Resources.Add__new_1;
            MainButtonNewProfile.BackgroundImageLayout = ImageLayout.Center;
            MainButtonNewProfile.Dock = DockStyle.Fill;
            MainButtonNewProfile.FlatAppearance.BorderSize = 0;
            MainButtonNewProfile.FlatStyle = FlatStyle.Flat;
            MainButtonNewProfile.Location = new Point(20, 5);
            MainButtonNewProfile.Margin = new Padding(20, 5, 20, 5);
            MainButtonNewProfile.MinimumSize = new Size(36, 36);
            MainButtonNewProfile.Name = "MainButtonNewProfile";
            MainButtonNewProfile.Padding = new Padding(20);
            MainButtonNewProfile.Size = new Size(96, 81);
            MainButtonNewProfile.TabIndex = 43;
            MainButtonNewProfile.UseVisualStyleBackColor = false;
            // 
            // MainButtonRemoveProfile
            // 
            MainButtonRemoveProfile.BackColor = Color.Transparent;
            MainButtonRemoveProfile.BackgroundImage = Properties.Resources.Delete1;
            MainButtonRemoveProfile.BackgroundImageLayout = ImageLayout.Center;
            MainButtonRemoveProfile.Dock = DockStyle.Fill;
            MainButtonRemoveProfile.FlatAppearance.BorderSize = 0;
            MainButtonRemoveProfile.FlatStyle = FlatStyle.Flat;
            MainButtonRemoveProfile.Location = new Point(293, 5);
            MainButtonRemoveProfile.Margin = new Padding(20, 5, 20, 5);
            MainButtonRemoveProfile.MinimumSize = new Size(36, 36);
            MainButtonRemoveProfile.Name = "MainButtonRemoveProfile";
            MainButtonRemoveProfile.Size = new Size(98, 81);
            MainButtonRemoveProfile.TabIndex = 45;
            MainButtonRemoveProfile.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(splitContainer6);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 859);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "Binary File";
            // 
            // splitContainer6
            // 
            splitContainer6.Dock = DockStyle.Fill;
            splitContainer6.Location = new Point(3, 19);
            splitContainer6.Name = "splitContainer6";
            splitContainer6.Orientation = Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            splitContainer6.Panel1.Controls.Add(splitContainer5);
            // 
            // splitContainer6.Panel2
            // 
            splitContainer6.Panel2.Controls.Add(MainDataGridFilePreview);
            splitContainer6.Size = new Size(400, 837);
            splitContainer6.SplitterDistance = 187;
            splitContainer6.SplitterWidth = 10;
            splitContainer6.TabIndex = 60;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(MainButtonFileBrowse);
            splitContainer5.Panel1MinSize = 80;
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(splitContainer7);
            splitContainer5.Panel2.Controls.Add(MainLabelPreviewFile);
            splitContainer5.Panel2.Controls.Add(MainCheckboxFlipBytes);
            splitContainer5.Panel2MinSize = 80;
            splitContainer5.Size = new Size(400, 187);
            splitContainer5.SplitterDistance = 91;
            splitContainer5.TabIndex = 0;
            // 
            // splitContainer7
            // 
            splitContainer7.Dock = DockStyle.Top;
            splitContainer7.Location = new Point(0, 0);
            splitContainer7.MinimumSize = new Size(0, 30);
            splitContainer7.Name = "splitContainer7";
            // 
            // splitContainer7.Panel1
            // 
            splitContainer7.Panel1.Controls.Add(MainLabelLoadedBinaryFile);
            // 
            // splitContainer7.Panel2
            // 
            splitContainer7.Panel2.Controls.Add(MainLabelBinaryFilename);
            splitContainer7.Size = new Size(400, 30);
            splitContainer7.SplitterDistance = 126;
            splitContainer7.TabIndex = 60;
            // 
            // MainLabelLoadedBinaryFile
            // 
            MainLabelLoadedBinaryFile.Dock = DockStyle.Fill;
            MainLabelLoadedBinaryFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MainLabelLoadedBinaryFile.Location = new Point(0, 0);
            MainLabelLoadedBinaryFile.Name = "MainLabelLoadedBinaryFile";
            MainLabelLoadedBinaryFile.Size = new Size(126, 30);
            MainLabelLoadedBinaryFile.TabIndex = 57;
            MainLabelLoadedBinaryFile.Text = "Loaded Binary:";
            MainLabelLoadedBinaryFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainLabelBinaryFilename
            // 
            MainLabelBinaryFilename.Dock = DockStyle.Fill;
            MainLabelBinaryFilename.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabelBinaryFilename.Location = new Point(0, 0);
            MainLabelBinaryFilename.Name = "MainLabelBinaryFilename";
            MainLabelBinaryFilename.Size = new Size(270, 30);
            MainLabelBinaryFilename.TabIndex = 51;
            MainLabelBinaryFilename.Text = "cfxhbxbxb";
            MainLabelBinaryFilename.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(MainTabControl);
            splitContainer1.Size = new Size(1457, 859);
            splitContainer1.SplitterDistance = 833;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 59;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox2);
            splitContainer2.Size = new Size(833, 859);
            splitContainer2.SplitterDistance = 417;
            splitContainer2.SplitterWidth = 10;
            splitContainer2.TabIndex = 0;
            // 
            // Main
            // 
            ClientSize = new Size(1457, 859);
            Controls.Add(splitContainer1);
            Controls.Add(EraserLabelErrorCounter);
            Name = "Main";
            Text = "OBD Error Erase";
            MainTabControl.ResumeLayout(false);
            EraserTabPage.ResumeLayout(false);
            splitContainer8.Panel1.ResumeLayout(false);
            splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer8).EndInit();
            splitContainer8.ResumeLayout(false);
            splitContainer9.Panel1.ResumeLayout(false);
            splitContainer9.Panel1.PerformLayout();
            splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer9).EndInit();
            splitContainer9.ResumeLayout(false);
            splitContainer10.Panel1.ResumeLayout(false);
            splitContainer10.Panel1.PerformLayout();
            splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer10).EndInit();
            splitContainer10.ResumeLayout(false);
            splitContainer11.Panel1.ResumeLayout(false);
            splitContainer11.Panel2.ResumeLayout(false);
            splitContainer11.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer11).EndInit();
            splitContainer11.ResumeLayout(false);
            EraserPanelErrorPresets.ResumeLayout(false);
            EraserPanelErrorPresets.PerformLayout();
            splitContainer12.Panel1.ResumeLayout(false);
            splitContainer12.Panel1.PerformLayout();
            splitContainer12.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer12).EndInit();
            splitContainer12.ResumeLayout(false);
            splitContainer13.Panel1.ResumeLayout(false);
            splitContainer13.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer13).EndInit();
            splitContainer13.ResumeLayout(false);
            EraserPanelMapSelector.ResumeLayout(false);
            EraserPanelMapSelector.PerformLayout();
            EditorTabPage.ResumeLayout(false);
            splitContainer14.Panel1.ResumeLayout(false);
            splitContainer14.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer14).EndInit();
            splitContainer14.ResumeLayout(false);
            splitContainer17.Panel1.ResumeLayout(false);
            splitContainer17.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer17).EndInit();
            splitContainer17.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            splitContainer18.Panel1.ResumeLayout(false);
            splitContainer18.Panel1.PerformLayout();
            splitContainer18.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer18).EndInit();
            splitContainer18.ResumeLayout(false);
            splitContainer19.Panel1.ResumeLayout(false);
            splitContainer19.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer19).EndInit();
            splitContainer19.ResumeLayout(false);
            splitContainer15.Panel1.ResumeLayout(false);
            splitContainer15.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer15).EndInit();
            splitContainer15.ResumeLayout(false);
            EditorGroupBox.ResumeLayout(false);
            splitContainer16.Panel1.ResumeLayout(false);
            splitContainer16.Panel1.PerformLayout();
            splitContainer16.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer16).EndInit();
            splitContainer16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainDataGridFilePreview).EndInit();
            groupBox1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            splitContainer6.Panel1.ResumeLayout(false);
            splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer6).EndInit();
            splitContainer6.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer7.Panel1.ResumeLayout(false);
            splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer7).EndInit();
            splitContainer7.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}