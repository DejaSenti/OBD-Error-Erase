namespace OBDErrorErase
{
    partial class EditorBoschControl
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
            TableLayoutLabels = new TableLayoutPanel();
            LabelAddress = new Label();
            LabelNewValue = new Label();
            LabelWidth = new Label();
            LabelName = new Label();
            ButtonAddMap = new Button();
            GroupBoxMapLength = new GroupBox();
            LabelMapLengthManualEntry = new Label();
            LabelMapLengthSelectAlgorithm = new Label();
            PanelMaps.SuspendLayout();
            TableLayoutLabels.SuspendLayout();
            GroupBoxMapLength.SuspendLayout();
            SuspendLayout();
            // 
            // ComboBoxMapLengthAlgorithm
            // 
            ComboBoxMapLengthAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxMapLengthAlgorithm.Location = new Point(173, 29);
            ComboBoxMapLengthAlgorithm.Name = "ComboBoxMapLengthAlgorithm";
            ComboBoxMapLengthAlgorithm.Size = new Size(151, 23);
            ComboBoxMapLengthAlgorithm.TabIndex = 0;
            // 
            // TextBoxMapLength
            // 
            TextBoxMapLength.Location = new Point(173, 58);
            TextBoxMapLength.Name = "TextBoxMapLength";
            TextBoxMapLength.PlaceholderText = "Enter Length...";
            TextBoxMapLength.Size = new Size(151, 23);
            TextBoxMapLength.TabIndex = 1;
            // 
            // PanelMaps
            // 
            PanelMaps.AutoScroll = true;
            PanelMaps.AutoScrollMinSize = new Size(280, 0);
            PanelMaps.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PanelMaps.Controls.Add(TableLayoutMaps);
            PanelMaps.Location = new Point(34, 135);
            PanelMaps.Name = "PanelMaps";
            PanelMaps.Size = new Size(350, 262);
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
            TableLayoutMaps.MaximumSize = new Size(330, 0);
            TableLayoutMaps.MinimumSize = new Size(330, 40);
            TableLayoutMaps.Name = "TableLayoutMaps";
            TableLayoutMaps.RowCount = 1;
            TableLayoutMaps.RowStyles.Add(new RowStyle());
            TableLayoutMaps.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableLayoutMaps.Size = new Size(330, 40);
            TableLayoutMaps.TabIndex = 0;
            // 
            // TableLayoutLabels
            // 
            TableLayoutLabels.ColumnCount = 5;
            TableLayoutLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutLabels.Controls.Add(LabelAddress, 1, 0);
            TableLayoutLabels.Controls.Add(LabelNewValue, 3, 0);
            TableLayoutLabels.Controls.Add(LabelWidth, 2, 0);
            TableLayoutLabels.Controls.Add(LabelName, 0, 0);
            TableLayoutLabels.Controls.Add(ButtonAddMap, 4, 0);
            TableLayoutLabels.Location = new Point(34, 100);
            TableLayoutLabels.Name = "TableLayoutLabels";
            TableLayoutLabels.RowCount = 1;
            TableLayoutLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutLabels.Size = new Size(330, 32);
            TableLayoutLabels.TabIndex = 0;
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Dock = DockStyle.Fill;
            LabelAddress.Location = new Point(69, 0);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(60, 32);
            LabelAddress.TabIndex = 4;
            LabelAddress.Text = "Address";
            LabelAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelNewValue
            // 
            LabelNewValue.AutoSize = true;
            LabelNewValue.Dock = DockStyle.Fill;
            LabelNewValue.Location = new Point(201, 0);
            LabelNewValue.Name = "LabelNewValue";
            LabelNewValue.Size = new Size(60, 32);
            LabelNewValue.TabIndex = 3;
            LabelNewValue.Text = "New Value";
            LabelNewValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelWidth
            // 
            LabelWidth.AutoSize = true;
            LabelWidth.Dock = DockStyle.Fill;
            LabelWidth.Location = new Point(135, 0);
            LabelWidth.Name = "LabelWidth";
            LabelWidth.Size = new Size(60, 32);
            LabelWidth.TabIndex = 2;
            LabelWidth.Text = "Width";
            LabelWidth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Dock = DockStyle.Fill;
            LabelName.Location = new Point(3, 0);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(60, 32);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name";
            LabelName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonAddMap
            // 
            ButtonAddMap.BackColor = Color.LightGreen;
            ButtonAddMap.Dock = DockStyle.Fill;
            ButtonAddMap.Location = new Point(267, 3);
            ButtonAddMap.Name = "ButtonAddMap";
            ButtonAddMap.Size = new Size(60, 26);
            ButtonAddMap.TabIndex = 5;
            ButtonAddMap.Text = "Add";
            ButtonAddMap.UseVisualStyleBackColor = false;
            // 
            // GroupBoxMapLength
            // 
            GroupBoxMapLength.Controls.Add(LabelMapLengthManualEntry);
            GroupBoxMapLength.Controls.Add(LabelMapLengthSelectAlgorithm);
            GroupBoxMapLength.Controls.Add(ComboBoxMapLengthAlgorithm);
            GroupBoxMapLength.Controls.Add(TextBoxMapLength);
            GroupBoxMapLength.Location = new Point(34, 3);
            GroupBoxMapLength.Name = "GroupBoxMapLength";
            GroupBoxMapLength.Size = new Size(330, 91);
            GroupBoxMapLength.TabIndex = 5;
            GroupBoxMapLength.TabStop = false;
            GroupBoxMapLength.Text = "Map Length";
            // 
            // LabelMapLengthManualEntry
            // 
            LabelMapLengthManualEntry.AutoSize = true;
            LabelMapLengthManualEntry.Location = new Point(6, 63);
            LabelMapLengthManualEntry.Margin = new Padding(3);
            LabelMapLengthManualEntry.Name = "LabelMapLengthManualEntry";
            LabelMapLengthManualEntry.Size = new Size(80, 15);
            LabelMapLengthManualEntry.TabIndex = 3;
            LabelMapLengthManualEntry.Text = "Manual Entry:";
            // 
            // LabelMapLengthSelectAlgorithm
            // 
            LabelMapLengthSelectAlgorithm.AutoSize = true;
            LabelMapLengthSelectAlgorithm.Location = new Point(6, 34);
            LabelMapLengthSelectAlgorithm.Margin = new Padding(3);
            LabelMapLengthSelectAlgorithm.Name = "LabelMapLengthSelectAlgorithm";
            LabelMapLengthSelectAlgorithm.Size = new Size(98, 15);
            LabelMapLengthSelectAlgorithm.TabIndex = 2;
            LabelMapLengthSelectAlgorithm.Text = "Select Algorithm:";
            // 
            // EditorBoschControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(GroupBoxMapLength);
            Controls.Add(TableLayoutLabels);
            Controls.Add(PanelMaps);
            Name = "EditorBoschControl";
            Size = new Size(400, 400);
            PanelMaps.ResumeLayout(false);
            PanelMaps.PerformLayout();
            TableLayoutLabels.ResumeLayout(false);
            TableLayoutLabels.PerformLayout();
            GroupBoxMapLength.ResumeLayout(false);
            GroupBoxMapLength.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelMaps;
        private TableLayoutPanel TableLayoutLabels;
        private Label LabelName;
        private Label LabelAddress;
        private Label LabelNewValue;
        private Label LabelWidth;
        private TableLayoutPanel TableLayoutMaps;
        public ComboBox ComboBoxMapLengthAlgorithm;
        public TextBox TextBoxMapLength;
        public Button ButtonAddMap;
        private Label label6;
        private GroupBox GroupBoxMapLength;
        private Label LabelMapLengthManualEntry;
        private Label LabelMapLengthSelectAlgorithm;
    }
}
