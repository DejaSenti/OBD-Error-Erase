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
            LabelMapLengthManualEntry = new Label();
            LabelMapLengthSelectAlgorithm = new Label();
            PanelMaps.SuspendLayout();
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
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Location = new Point(110, 115);
            LabelAddress.Margin = new Padding(0, 8, 3, 8);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(49, 15);
            LabelAddress.TabIndex = 4;
            LabelAddress.Text = "Address";
            LabelAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelNewValue
            // 
            LabelNewValue.AutoSize = true;
            LabelNewValue.Location = new Point(247, 115);
            LabelNewValue.Margin = new Padding(0, 8, 3, 8);
            LabelNewValue.Name = "LabelNewValue";
            LabelNewValue.Size = new Size(62, 15);
            LabelNewValue.TabIndex = 3;
            LabelNewValue.Text = "New Value";
            LabelNewValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelWidth
            // 
            LabelWidth.AutoSize = true;
            LabelWidth.Location = new Point(180, 115);
            LabelWidth.Margin = new Padding(0, 8, 3, 8);
            LabelWidth.Name = "LabelWidth";
            LabelWidth.Size = new Size(66, 15);
            LabelWidth.TabIndex = 2;
            LabelWidth.Text = "Width(bits)";
            LabelWidth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(40, 115);
            LabelName.Margin = new Padding(0, 8, 3, 8);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 15);
            LabelName.TabIndex = 0;
            LabelName.Text = "Name";
            LabelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonAddMap
            // 
            ButtonAddMap.BackColor = Color.Transparent;
            ButtonAddMap.BackgroundImage = Properties.Resources.ButtonNew;
            ButtonAddMap.BackgroundImageLayout = ImageLayout.Center;
            ButtonAddMap.FlatAppearance.BorderSize = 0;
            ButtonAddMap.FlatStyle = FlatStyle.Flat;
            ButtonAddMap.Location = new Point(322, 103);
            ButtonAddMap.MaximumSize = new Size(32, 32);
            ButtonAddMap.MinimumSize = new Size(32, 32);
            ButtonAddMap.Name = "ButtonAddMap";
            ButtonAddMap.Size = new Size(32, 32);
            ButtonAddMap.TabIndex = 5;
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
            // BoschProfileEditorGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LabelNewValue);
            Controls.Add(ButtonAddMap);
            Controls.Add(LabelAddress);
            Controls.Add(LabelWidth);
            Controls.Add(GroupBoxMapLength);
            Controls.Add(PanelMaps);
            Controls.Add(LabelName);
            Name = "BoschProfileEditorGUI";
            Size = new Size(400, 400);
            PanelMaps.ResumeLayout(false);
            PanelMaps.PerformLayout();
            GroupBoxMapLength.ResumeLayout(false);
            GroupBoxMapLength.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
