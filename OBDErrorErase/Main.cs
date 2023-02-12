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
            this.EraserErrorPreview = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.EraserLabelPresetSelect = new System.Windows.Forms.Label();
            this.EraserLabelMapSelect = new System.Windows.Forms.Label();
            this.EraserButtonAddPreset = new System.Windows.Forms.Button();
            this.EraserLabelFilePath = new System.Windows.Forms.Label();
            this.EraserLabelErrorCounter = new System.Windows.Forms.Label();
            this.EraserButtonFileBrowse = new System.Windows.Forms.Button();
            this.EraserButtonRun = new System.Windows.Forms.Button();
            this.EraserTextboxProfileFilter = new System.Windows.Forms.TextBox();
            this.EraserListProfiles = new System.Windows.Forms.ListBox();
            this.TabProfileEditor = new System.Windows.Forms.TabPage();
            this.EditorCheckboxFlipBytes = new System.Windows.Forms.CheckBox();
            this.EditorLabelFilePath = new System.Windows.Forms.Label();
            this.EditorButtonDuplicateProfile = new System.Windows.Forms.Button();
            this.EditorTabControlProfileType = new System.Windows.Forms.TabControl();
            this.ProfileTabBosch = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.EditorButtonProfileRemove = new System.Windows.Forms.Button();
            this.EditorButtonNewProfile = new System.Windows.Forms.Button();
            this.EditorListProfiles = new System.Windows.Forms.ListBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TabControlMain.SuspendLayout();
            this.TabErrorEraser.SuspendLayout();
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
            this.TabErrorEraser.Controls.Add(this.EraserErrorPreview);
            this.TabErrorEraser.Controls.Add(this.textBox1);
            this.TabErrorEraser.Controls.Add(this.listView2);
            this.TabErrorEraser.Controls.Add(this.listView1);
            this.TabErrorEraser.Controls.Add(this.EraserLabelPresetSelect);
            this.TabErrorEraser.Controls.Add(this.EraserLabelMapSelect);
            this.TabErrorEraser.Controls.Add(this.EraserButtonAddPreset);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 204);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter a list of errors, separated by commas (e.g. a1c7, 1600, 8461, e56f...):";
            this.textBox1.Size = new System.Drawing.Size(612, 66);
            this.textBox1.TabIndex = 39;
            // 
            // listView2
            // 
            this.listView2.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView2.CheckBoxes = true;
            this.listView2.Location = new System.Drawing.Point(629, 308);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(303, 376);
            this.listView2.TabIndex = 38;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Location = new System.Drawing.Point(320, 308);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 376);
            this.listView1.TabIndex = 37;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // EraserLabelPresetSelect
            // 
            this.EraserLabelPresetSelect.AutoSize = true;
            this.EraserLabelPresetSelect.Location = new System.Drawing.Point(629, 285);
            this.EraserLabelPresetSelect.Name = "EraserLabelPresetSelect";
            this.EraserLabelPresetSelect.Size = new System.Drawing.Size(165, 15);
            this.EraserLabelPresetSelect.TabIndex = 34;
            this.EraserLabelPresetSelect.Text = "Select error presets to include:";
            this.EraserLabelPresetSelect.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // EraserLabelMapSelect
            // 
            this.EraserLabelMapSelect.AutoSize = true;
            this.EraserLabelMapSelect.Location = new System.Drawing.Point(320, 285);
            this.EraserLabelMapSelect.Name = "EraserLabelMapSelect";
            this.EraserLabelMapSelect.Size = new System.Drawing.Size(128, 15);
            this.EraserLabelMapSelect.TabIndex = 33;
            this.EraserLabelMapSelect.Text = "Select maps to modify:";
            this.EraserLabelMapSelect.Click += new System.EventHandler(this.label1_Click);
            // 
            // EraserButtonAddPreset
            // 
            this.EraserButtonAddPreset.BackColor = System.Drawing.Color.LightBlue;
            this.EraserButtonAddPreset.Location = new System.Drawing.Point(818, 276);
            this.EraserButtonAddPreset.Name = "EraserButtonAddPreset";
            this.EraserButtonAddPreset.Size = new System.Drawing.Size(117, 32);
            this.EraserButtonAddPreset.TabIndex = 32;
            this.EraserButtonAddPreset.Text = "Add Error Preset...";
            this.EraserButtonAddPreset.UseVisualStyleBackColor = false;
            this.EraserButtonAddPreset.Click += new System.EventHandler(this.button2_Click);
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
            this.EraserLabelErrorCounter.Text = "X / Y Deleted";
            this.EraserLabelErrorCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EraserLabelErrorCounter.Click += new System.EventHandler(this.EraserLabelErrorCounter_Click);
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
            this.TabProfileEditor.Controls.Add(this.EditorCheckboxFlipBytes);
            this.TabProfileEditor.Controls.Add(this.EditorLabelFilePath);
            this.TabProfileEditor.Controls.Add(this.EditorButtonDuplicateProfile);
            this.TabProfileEditor.Controls.Add(this.EditorTabControlProfileType);
            this.TabProfileEditor.Controls.Add(this.EditorButtonFileBrowse);
            this.TabProfileEditor.Controls.Add(this.EditorListSubprofiles);
            this.TabProfileEditor.Controls.Add(this.EditorButtonSave);
            this.TabProfileEditor.Controls.Add(this.EditorErrorPreview);
            this.TabProfileEditor.Controls.Add(this.EditorTextBoxComputerName);
            this.TabProfileEditor.Controls.Add(this.EditorDropdownManufacturer);
            this.TabProfileEditor.Controls.Add(this.EditorTextboxProfileFilter);
            this.TabProfileEditor.Controls.Add(this.EditorButtonProfileRemove);
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
            this.EditorCheckboxFlipBytes.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // EditorButtonDuplicateProfile
            // 
            this.EditorButtonDuplicateProfile.BackColor = System.Drawing.Color.NavajoWhite;
            this.EditorButtonDuplicateProfile.Location = new System.Drawing.Point(320, 35);
            this.EditorButtonDuplicateProfile.Name = "EditorButtonDuplicateProfile";
            this.EditorButtonDuplicateProfile.Size = new System.Drawing.Size(200, 25);
            this.EditorButtonDuplicateProfile.TabIndex = 24;
            this.EditorButtonDuplicateProfile.Text = "Duplicate Profile";
            this.EditorButtonDuplicateProfile.UseVisualStyleBackColor = false;
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
            this.ProfileTabBosch.Controls.Add(this.textBox2);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(375, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Enter manual length...";
            this.textBox2.Size = new System.Drawing.Size(152, 23);
            this.textBox2.TabIndex = 2;
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
            this.EditorDataGridViewBosch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.EditorListSubprofiles.Location = new System.Drawing.Point(320, 65);
            this.EditorListSubprofiles.Name = "EditorListSubprofiles";
            this.EditorListSubprofiles.Size = new System.Drawing.Size(200, 109);
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
            this.EditorTextBoxComputerName.Location = new System.Drawing.Point(630, 6);
            this.EditorTextBoxComputerName.Name = "EditorTextBoxComputerName";
            this.EditorTextBoxComputerName.PlaceholderText = "Enter computer name...";
            this.EditorTextBoxComputerName.Size = new System.Drawing.Size(302, 23);
            this.EditorTextBoxComputerName.TabIndex = 18;
            // 
            // EditorDropdownManufacturer
            // 
            this.EditorDropdownManufacturer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EditorDropdownManufacturer.FormattingEnabled = true;
            this.EditorDropdownManufacturer.Location = new System.Drawing.Point(320, 6);
            this.EditorDropdownManufacturer.Name = "EditorDropdownManufacturer";
            this.EditorDropdownManufacturer.Size = new System.Drawing.Size(304, 23);
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
            // EditorButtonProfileRemove
            // 
            this.EditorButtonProfileRemove.BackColor = System.Drawing.Color.DarkSalmon;
            this.EditorButtonProfileRemove.Location = new System.Drawing.Point(164, 6);
            this.EditorButtonProfileRemove.Name = "EditorButtonProfileRemove";
            this.EditorButtonProfileRemove.Size = new System.Drawing.Size(150, 60);
            this.EditorButtonProfileRemove.TabIndex = 15;
            this.EditorButtonProfileRemove.Text = "Remove Profile";
            this.EditorButtonProfileRemove.UseVisualStyleBackColor = false;
            // 
            // EditorButtonNewProfile
            // 
            this.EditorButtonNewProfile.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.EditorButtonNewProfile.Location = new System.Drawing.Point(8, 6);
            this.EditorButtonNewProfile.Name = "EditorButtonNewProfile";
            this.EditorButtonNewProfile.Size = new System.Drawing.Size(150, 60);
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EraserLabelErrorCounter_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
                    }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}