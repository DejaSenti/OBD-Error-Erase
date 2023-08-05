namespace OBDErrorErase
{
    partial class BoschProfileEditorGUI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComboBoxMapLengthAlgorithm = new ComboBox();
            TextBoxMapLength = new TextBox();
            PanelMaps = new Panel();
            TableLayoutMaps = new TableLayoutPanel();
            LabelAddress = new Label();
            LabelNewValue = new Label();
            LabelWidth = new Label();
            LabelName = new Label();
            ButtonAddMap = new Button();
            GroupBoxMapLength = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            LabelMapLengthManualEntry = new Label();
            LabelMapLengthSelectAlgorithm = new Label();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            MapWidth = new TextBox();
            MapName = new TextBox();
            TableLayoutFields = new TableLayoutPanel();
            PanelMaps.SuspendLayout();
            GroupBoxMapLength.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            TableLayoutFields.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxMapLengthAlgorithm
            // 
            ComboBoxMapLengthAlgorithm.Dock = DockStyle.Fill;
            ComboBoxMapLengthAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxMapLengthAlgorithm.Location = new Point(244, 24);
            ComboBoxMapLengthAlgorithm.Margin = new Padding(4);
            ComboBoxMapLengthAlgorithm.Name = "ComboBoxMapLengthAlgorithm";
            ComboBoxMapLengthAlgorithm.Size = new Size(213, 29);
            ComboBoxMapLengthAlgorithm.TabIndex = 0;
            // 
            // TextBoxMapLength
            // 
            TextBoxMapLength.Dock = DockStyle.Fill;
            TextBoxMapLength.Location = new Point(244, 69);
            TextBoxMapLength.Margin = new Padding(4);
            TextBoxMapLength.Name = "TextBoxMapLength";
            TextBoxMapLength.PlaceholderText = "Enter Length...";
            TextBoxMapLength.Size = new Size(213, 29);
            TextBoxMapLength.TabIndex = 1;
            // 
            // PanelMaps
            // 
            PanelMaps.AutoScroll = true;
            PanelMaps.AutoScrollMinSize = new Size(280, 0);
            PanelMaps.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelMaps.Controls.Add(TableLayoutMaps);
            PanelMaps.Dock = DockStyle.Fill;
            PanelMaps.Location = new Point(0, 0);
            PanelMaps.Margin = new Padding(4);
            PanelMaps.Name = "PanelMaps";
            PanelMaps.Size = new Size(501, 190);
            PanelMaps.TabIndex = 2;
            // 
            // TableLayoutMaps
            // 
            TableLayoutMaps.AutoScroll = true;
            TableLayoutMaps.AutoSize = true;
            TableLayoutMaps.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            TableLayoutMaps.ColumnCount = 1;
            TableLayoutMaps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableLayoutMaps.Dock = DockStyle.Top;
            TableLayoutMaps.Location = new Point(0, 0);
            TableLayoutMaps.Margin = new Padding(4);
            TableLayoutMaps.MaximumSize = new Size(424, 0);
            TableLayoutMaps.MinimumSize = new Size(424, 56);
            TableLayoutMaps.Name = "TableLayoutMaps";
            TableLayoutMaps.RowCount = 1;
            TableLayoutMaps.RowStyles.Add(new RowStyle());
            TableLayoutMaps.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            TableLayoutMaps.Size = new Size(424, 56);
            TableLayoutMaps.TabIndex = 0;
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Location = new Point(113, 11);
            LabelAddress.Margin = new Padding(0, 11, 4, 11);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(66, 21);
            LabelAddress.TabIndex = 4;
            LabelAddress.Text = "Address";
            LabelAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelNewValue
            // 
            LabelNewValue.AutoSize = true;
            LabelNewValue.Location = new Point(339, 11);
            LabelNewValue.Margin = new Padding(0, 11, 4, 11);
            LabelNewValue.Name = "LabelNewValue";
            LabelNewValue.Size = new Size(84, 21);
            LabelNewValue.TabIndex = 3;
            LabelNewValue.Text = "New Value";
            LabelNewValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelWidth
            // 
            LabelWidth.AutoSize = true;
            LabelWidth.Location = new Point(226, 11);
            LabelWidth.Margin = new Padding(0, 11, 4, 11);
            LabelWidth.Name = "LabelWidth";
            LabelWidth.Size = new Size(87, 21);
            LabelWidth.TabIndex = 2;
            LabelWidth.Text = "Width(bits)";
            LabelWidth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(0, 11);
            LabelName.Margin = new Padding(0, 11, 4, 11);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(52, 21);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name";
            LabelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonAddMap
            // 
            ButtonAddMap.BackColor = Color.Transparent;
            ButtonAddMap.BackgroundImage = Properties.Resources.ButtonNew;
            ButtonAddMap.BackgroundImageLayout = ImageLayout.Center;
            ButtonAddMap.Dock = DockStyle.Fill;
            ButtonAddMap.FlatAppearance.BorderSize = 0;
            ButtonAddMap.FlatStyle = FlatStyle.Flat;
            ButtonAddMap.Location = new Point(456, 4);
            ButtonAddMap.Margin = new Padding(4);
            ButtonAddMap.MinimumSize = new Size(41, 45);
            ButtonAddMap.Name = "ButtonAddMap";
            ButtonAddMap.Size = new Size(41, 186);
            ButtonAddMap.TabIndex = 5;
            ButtonAddMap.UseVisualStyleBackColor = false;
            // 
            // GroupBoxMapLength
            // 
            GroupBoxMapLength.Controls.Add(tableLayoutPanel2);
            GroupBoxMapLength.Dock = DockStyle.Fill;
            GroupBoxMapLength.Location = new Point(0, 0);
            GroupBoxMapLength.Margin = new Padding(10);
            GroupBoxMapLength.Name = "GroupBoxMapLength";
            GroupBoxMapLength.Padding = new Padding(10);
            GroupBoxMapLength.Size = new Size(501, 172);
            GroupBoxMapLength.TabIndex = 5;
            GroupBoxMapLength.TabStop = false;
            GroupBoxMapLength.Text = "Map Length";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LabelMapLengthManualEntry, 0, 1);
            tableLayoutPanel2.Controls.Add(TextBoxMapLength, 1, 1);
            tableLayoutPanel2.Controls.Add(ComboBoxMapLengthAlgorithm, 1, 0);
            tableLayoutPanel2.Controls.Add(LabelMapLengthSelectAlgorithm, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 32);
            tableLayoutPanel2.Margin = new Padding(10);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(20);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(481, 130);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // LabelMapLengthManualEntry
            // 
            LabelMapLengthManualEntry.AutoSize = true;
            LabelMapLengthManualEntry.Dock = DockStyle.Fill;
            LabelMapLengthManualEntry.Location = new Point(24, 69);
            LabelMapLengthManualEntry.Margin = new Padding(4);
            LabelMapLengthManualEntry.Name = "LabelMapLengthManualEntry";
            LabelMapLengthManualEntry.Size = new Size(212, 37);
            LabelMapLengthManualEntry.TabIndex = 3;
            LabelMapLengthManualEntry.Text = "Manual Entry:";
            // 
            // LabelMapLengthSelectAlgorithm
            // 
            LabelMapLengthSelectAlgorithm.AutoSize = true;
            LabelMapLengthSelectAlgorithm.Dock = DockStyle.Fill;
            LabelMapLengthSelectAlgorithm.Location = new Point(24, 24);
            LabelMapLengthSelectAlgorithm.Margin = new Padding(4);
            LabelMapLengthSelectAlgorithm.Name = "LabelMapLengthSelectAlgorithm";
            LabelMapLengthSelectAlgorithm.Size = new Size(212, 37);
            LabelMapLengthSelectAlgorithm.TabIndex = 2;
            LabelMapLengthSelectAlgorithm.Text = "Select Algorithm:";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(GroupBoxMapLength);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(501, 564);
            splitContainer1.SplitterDistance = 172;
            splitContainer1.TabIndex = 6;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(PanelMaps);
            splitContainer2.Size = new Size(501, 388);
            splitContainer2.SplitterDistance = 194;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(LabelAddress, 1, 0);
            tableLayoutPanel1.Controls.Add(LabelWidth, 2, 0);
            tableLayoutPanel1.Controls.Add(LabelNewValue, 3, 0);
            tableLayoutPanel1.Controls.Add(ButtonAddMap, 4, 0);
            tableLayoutPanel1.Controls.Add(LabelName, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(501, 194);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // MapWidth
            // 
            MapWidth.Dock = DockStyle.Fill;
            MapWidth.Location = new Point(104, 11);
            MapWidth.Margin = new Padding(4, 11, 4, 11);
            MapWidth.Name = "MapWidth";
            MapWidth.Size = new Size(42, 29);
            MapWidth.TabIndex = 2;
            // 
            // MapName
            // 
            MapName.Dock = DockStyle.Fill;
            MapName.Location = new Point(4, 11);
            MapName.Margin = new Padding(4, 11, 4, 11);
            MapName.Name = "MapName";
            MapName.Size = new Size(42, 29);
            MapName.TabIndex = 0;
            // 
            // TableLayoutFields
            // 
            TableLayoutFields.ColumnCount = 5;
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle());
            TableLayoutFields.Controls.Add(MapWidth, 2, 0);
            TableLayoutFields.Location = new Point(0, 0);
            TableLayoutFields.Name = "TableLayoutFields";
            TableLayoutFields.RowCount = 1;
            TableLayoutFields.Size = new Size(200, 100);
            TableLayoutFields.TabIndex = 0;
            // 
            // BoschProfileEditorGUI
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(4);
            Name = "BoschProfileEditorGUI";
            Size = new Size(1362, 889);
            PanelMaps.ResumeLayout(false);
            PanelMaps.PerformLayout();
            GroupBoxMapLength.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            TableLayoutFields.ResumeLayout(false);
            TableLayoutFields.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelMaps;
        private Label LabelName;
        private Label LabelAddress;
        private Label LabelNewValue;
        private Label LabelWidth;
        private TableLayoutPanel TableLayoutMaps;
        public ComboBox ComboBoxMapLengthAlgorithm;
        public TextBox TextBoxMapLength;
        public Button ButtonAddMap;
        private GroupBox GroupBoxMapLength;
        private Label LabelMapLengthManualEntry;
        private Label LabelMapLengthSelectAlgorithm;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        public TextBox MapWidth;
        public TextBox MapName;
        private TableLayoutPanel TableLayoutFields;
    }
}
