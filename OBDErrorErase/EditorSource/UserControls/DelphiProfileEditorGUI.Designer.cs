namespace OBDErrorErase
{
    partial class DelphiProfileEditorGUI
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
            LayoutPanelAll = new TableLayoutPanel();
            LayoutPanelErrorColumn = new TableLayoutPanel();
            ErrorColumn = new TextBox();
            LabelErrorColumn = new Label();
            LayoutPanelNewValue = new TableLayoutPanel();
            NewValue = new TextBox();
            LabelNewValue = new Label();
            LayoutPanelLength = new TableLayoutPanel();
            Length = new TextBox();
            LabelLength = new Label();
            LayoutPanelAddress = new TableLayoutPanel();
            LabelAddress = new Label();
            Address = new TextBox();
            LayoutPanelAll.SuspendLayout();
            LayoutPanelErrorColumn.SuspendLayout();
            LayoutPanelNewValue.SuspendLayout();
            LayoutPanelLength.SuspendLayout();
            LayoutPanelAddress.SuspendLayout();
            SuspendLayout();
            // 
            // LayoutPanelAll
            // 
            LayoutPanelAll.ColumnCount = 1;
            LayoutPanelAll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            LayoutPanelAll.Controls.Add(LayoutPanelErrorColumn, 0, 3);
            LayoutPanelAll.Controls.Add(LayoutPanelNewValue, 0, 2);
            LayoutPanelAll.Controls.Add(LayoutPanelLength, 0, 1);
            LayoutPanelAll.Controls.Add(LayoutPanelAddress, 0, 0);
            LayoutPanelAll.Dock = DockStyle.Top;
            LayoutPanelAll.Location = new Point(0, 0);
            LayoutPanelAll.Name = "LayoutPanelAll";
            LayoutPanelAll.RowCount = 4;
            LayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LayoutPanelAll.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LayoutPanelAll.Size = new Size(400, 331);
            LayoutPanelAll.TabIndex = 0;
            // 
            // LayoutPanelErrorColumn
            // 
            LayoutPanelErrorColumn.ColumnCount = 1;
            LayoutPanelErrorColumn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelErrorColumn.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelErrorColumn.Controls.Add(ErrorColumn, 0, 1);
            LayoutPanelErrorColumn.Controls.Add(LabelErrorColumn, 0, 0);
            LayoutPanelErrorColumn.Dock = DockStyle.Fill;
            LayoutPanelErrorColumn.Location = new Point(3, 249);
            LayoutPanelErrorColumn.Name = "LayoutPanelErrorColumn";
            LayoutPanelErrorColumn.RowCount = 2;
            LayoutPanelErrorColumn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelErrorColumn.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelErrorColumn.Size = new Size(394, 79);
            LayoutPanelErrorColumn.TabIndex = 4;
            // 
            // ErrorColumn
            // 
            ErrorColumn.Dock = DockStyle.Fill;
            ErrorColumn.Location = new Point(3, 42);
            ErrorColumn.Name = "ErrorColumn";
            ErrorColumn.Size = new Size(388, 23);
            ErrorColumn.TabIndex = 2;
            // 
            // LabelErrorColumn
            // 
            LabelErrorColumn.AutoSize = true;
            LabelErrorColumn.Dock = DockStyle.Bottom;
            LabelErrorColumn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelErrorColumn.Location = new Point(3, 24);
            LabelErrorColumn.Name = "LabelErrorColumn";
            LabelErrorColumn.Size = new Size(388, 15);
            LabelErrorColumn.TabIndex = 1;
            LabelErrorColumn.Text = "Error Column:";
            // 
            // LayoutPanelNewValue
            // 
            LayoutPanelNewValue.ColumnCount = 1;
            LayoutPanelNewValue.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelNewValue.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelNewValue.Controls.Add(NewValue, 0, 1);
            LayoutPanelNewValue.Controls.Add(LabelNewValue, 0, 0);
            LayoutPanelNewValue.Dock = DockStyle.Fill;
            LayoutPanelNewValue.Location = new Point(3, 167);
            LayoutPanelNewValue.Name = "LayoutPanelNewValue";
            LayoutPanelNewValue.RowCount = 2;
            LayoutPanelNewValue.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelNewValue.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelNewValue.Size = new Size(394, 76);
            LayoutPanelNewValue.TabIndex = 3;
            // 
            // NewValue
            // 
            NewValue.Dock = DockStyle.Fill;
            NewValue.Location = new Point(3, 41);
            NewValue.Name = "NewValue";
            NewValue.Size = new Size(388, 23);
            NewValue.TabIndex = 2;
            // 
            // LabelNewValue
            // 
            LabelNewValue.AutoSize = true;
            LabelNewValue.Dock = DockStyle.Bottom;
            LabelNewValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNewValue.Location = new Point(3, 23);
            LabelNewValue.Name = "LabelNewValue";
            LabelNewValue.Size = new Size(388, 15);
            LabelNewValue.TabIndex = 1;
            LabelNewValue.Text = "New Value:";
            // 
            // LayoutPanelLength
            // 
            LayoutPanelLength.ColumnCount = 1;
            LayoutPanelLength.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelLength.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelLength.Controls.Add(Length, 0, 1);
            LayoutPanelLength.Controls.Add(LabelLength, 0, 0);
            LayoutPanelLength.Dock = DockStyle.Fill;
            LayoutPanelLength.Location = new Point(3, 85);
            LayoutPanelLength.Name = "LayoutPanelLength";
            LayoutPanelLength.RowCount = 2;
            LayoutPanelLength.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelLength.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelLength.Size = new Size(394, 76);
            LayoutPanelLength.TabIndex = 2;
            // 
            // Length
            // 
            Length.Dock = DockStyle.Fill;
            Length.Location = new Point(3, 41);
            Length.Name = "Length";
            Length.Size = new Size(388, 23);
            Length.TabIndex = 2;
            // 
            // LabelLength
            // 
            LabelLength.AutoSize = true;
            LabelLength.Dock = DockStyle.Bottom;
            LabelLength.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelLength.Location = new Point(3, 23);
            LabelLength.Name = "LabelLength";
            LabelLength.Size = new Size(388, 15);
            LabelLength.TabIndex = 1;
            LabelLength.Text = "Length:";
            // 
            // LayoutPanelAddress
            // 
            LayoutPanelAddress.ColumnCount = 1;
            LayoutPanelAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelAddress.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            LayoutPanelAddress.Controls.Add(LabelAddress, 0, 0);
            LayoutPanelAddress.Controls.Add(Address, 0, 1);
            LayoutPanelAddress.Dock = DockStyle.Fill;
            LayoutPanelAddress.Location = new Point(3, 3);
            LayoutPanelAddress.Name = "LayoutPanelAddress";
            LayoutPanelAddress.RowCount = 2;
            LayoutPanelAddress.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelAddress.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LayoutPanelAddress.Size = new Size(394, 76);
            LayoutPanelAddress.TabIndex = 0;
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Dock = DockStyle.Bottom;
            LabelAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAddress.Location = new Point(3, 23);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(388, 15);
            LabelAddress.TabIndex = 0;
            LabelAddress.Text = "Address:";
            // 
            // Address
            // 
            Address.Dock = DockStyle.Fill;
            Address.Location = new Point(3, 41);
            Address.Name = "Address";
            Address.Size = new Size(388, 23);
            Address.TabIndex = 1;
            // 
            // DelphiProfileEditorGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(LayoutPanelAll);
            Name = "DelphiProfileEditorGUI";
            Size = new Size(400, 400);
            LayoutPanelAll.ResumeLayout(false);
            LayoutPanelErrorColumn.ResumeLayout(false);
            LayoutPanelErrorColumn.PerformLayout();
            LayoutPanelNewValue.ResumeLayout(false);
            LayoutPanelNewValue.PerformLayout();
            LayoutPanelLength.ResumeLayout(false);
            LayoutPanelLength.PerformLayout();
            LayoutPanelAddress.ResumeLayout(false);
            LayoutPanelAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel LayoutPanelAll;
        private TableLayoutPanel LayoutPanelErrorColumn;
        private TextBox ErrorColumn;
        private Label LabelErrorColumn;
        private TableLayoutPanel LayoutPanelNewValue;
        private TextBox NewValue;
        private Label LabelNewValue;
        private TableLayoutPanel LayoutPanelLength;
        private TextBox Length;
        private Label LabelLength;
        private TableLayoutPanel LayoutPanelAddress;
        private Label LabelAddress;
        private TextBox Address;
    }
}
