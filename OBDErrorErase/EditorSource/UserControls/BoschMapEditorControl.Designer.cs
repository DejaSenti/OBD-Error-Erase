namespace OBDErrorErase
{
    partial class BoschMapEditorControl
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
            TableLayoutFields = new TableLayoutPanel();
            MapName = new TextBox();
            Address = new TextBox();
            Width = new ComboBox();
            NewValue = new TextBox();
            Remove = new Button();
            TableLayoutFields.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutFields
            // 
            TableLayoutFields.ColumnCount = 5;
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            TableLayoutFields.Controls.Add(MapName, 0, 0);
            TableLayoutFields.Controls.Add(Address, 1, 0);
            TableLayoutFields.Controls.Add(Width, 2, 0);
            TableLayoutFields.Controls.Add(NewValue, 3, 0);
            TableLayoutFields.Controls.Add(Remove, 4, 0);
            TableLayoutFields.Dock = DockStyle.Fill;
            TableLayoutFields.Location = new Point(0, 0);
            TableLayoutFields.Name = "TableLayoutFields";
            TableLayoutFields.RowCount = 1;
            TableLayoutFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutFields.Size = new Size(330, 40);
            TableLayoutFields.TabIndex = 7;
            // 
            // MapName
            // 
            MapName.Dock = DockStyle.Fill;
            MapName.Location = new Point(3, 8);
            MapName.Margin = new Padding(3, 8, 3, 8);
            MapName.Name = "MapName";
            MapName.Size = new Size(60, 23);
            MapName.TabIndex = 0;
            // 
            // Address
            // 
            Address.Dock = DockStyle.Fill;
            Address.Location = new Point(69, 8);
            Address.Margin = new Padding(3, 8, 3, 8);
            Address.Name = "Address";
            Address.Size = new Size(60, 23);
            Address.TabIndex = 1;
            // 
            // Width
            // 
            Width.Dock = DockStyle.Fill;
            Width.DropDownStyle = ComboBoxStyle.DropDownList;
            Width.FormattingEnabled = true;
            Width.Location = new Point(135, 8);
            Width.Margin = new Padding(3, 8, 3, 8);
            Width.Name = "Width";
            Width.Size = new Size(60, 23);
            Width.TabIndex = 2;
            // 
            // NewValue
            // 
            NewValue.Dock = DockStyle.Fill;
            NewValue.Location = new Point(201, 8);
            NewValue.Margin = new Padding(3, 8, 3, 8);
            NewValue.Name = "NewValue";
            NewValue.Size = new Size(60, 23);
            NewValue.TabIndex = 3;
            // 
            // Remove
            // 
            Remove.BackColor = Color.LightCoral;
            Remove.Dock = DockStyle.Fill;
            Remove.Location = new Point(267, 3);
            Remove.Name = "Remove";
            Remove.Size = new Size(60, 34);
            Remove.TabIndex = 4;
            Remove.Text = "Remove";
            Remove.UseVisualStyleBackColor = false;
            // 
            // BoschMapEditorControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutFields);
            Name = "BoschMapEditorControl";
            Size = new Size(330, 40);
            TableLayoutFields.ResumeLayout(false);
            TableLayoutFields.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutFields;
        public TextBox MapName;
        public TextBox Address;
        public ComboBox Width;
        public TextBox NewValue;
        public Button Remove;
    }
}
