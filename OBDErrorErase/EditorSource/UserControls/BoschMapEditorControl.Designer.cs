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
            MapWidth = new ComboBox();
            NewValue = new TextBox();
            Remove = new Button();
            TableLayoutFields.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutFields
            // 
            TableLayoutFields.ColumnCount = 5;
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutFields.ColumnStyles.Add(new ColumnStyle());
            TableLayoutFields.Controls.Add(MapName, 0, 0);
            TableLayoutFields.Controls.Add(Address, 1, 0);
            TableLayoutFields.Controls.Add(MapWidth, 2, 0);
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
            MapName.Size = new Size(66, 23);
            MapName.TabIndex = 0;
            // 
            // Address
            // 
            Address.Dock = DockStyle.Fill;
            Address.Location = new Point(75, 8);
            Address.Margin = new Padding(3, 8, 3, 8);
            Address.Name = "Address";
            Address.Size = new Size(66, 23);
            Address.TabIndex = 1;
            // 
            // MapWidth
            // 
            MapWidth.Dock = DockStyle.Fill;
            MapWidth.DropDownStyle = ComboBoxStyle.DropDownList;
            MapWidth.FormattingEnabled = true;
            MapWidth.Location = new Point(147, 8);
            MapWidth.Margin = new Padding(3, 8, 3, 8);
            MapWidth.Name = "MapWidth";
            MapWidth.Size = new Size(66, 23);
            MapWidth.TabIndex = 2;
            // 
            // NewValue
            // 
            NewValue.Dock = DockStyle.Fill;
            NewValue.Location = new Point(216, 8);
            NewValue.Margin = new Padding(0, 8, 0, 8);
            NewValue.Name = "NewValue";
            NewValue.Size = new Size(72, 23);
            NewValue.TabIndex = 3;
            // 
            // Remove
            // 
            Remove.BackColor = Color.Transparent;
            Remove.BackgroundImage = Properties.Resources.ListDelete;
            Remove.BackgroundImageLayout = ImageLayout.Center;
            Remove.FlatAppearance.BorderSize = 0;
            Remove.FlatStyle = FlatStyle.Flat;
            Remove.Location = new Point(298, 8);
            Remove.Margin = new Padding(10, 8, 7, 10);
            Remove.MaximumSize = new Size(25, 25);
            Remove.MinimumSize = new Size(25, 25);
            Remove.Name = "Remove";
            Remove.Size = new Size(25, 25);
            Remove.TabIndex = 4;
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
        public ComboBox MapWidth;
        public TextBox NewValue;
        public Button Remove;
    }
}
