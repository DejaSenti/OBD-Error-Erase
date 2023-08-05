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
            MapWidth = new TextBox();
            MapName = new TextBox();
            Address = new TextBox();
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
            TableLayoutFields.Controls.Add(MapWidth, 2, 0);
            TableLayoutFields.Controls.Add(MapName, 0, 0);
            TableLayoutFields.Controls.Add(Address, 1, 0);
            TableLayoutFields.Controls.Add(NewValue, 3, 0);
            TableLayoutFields.Controls.Add(Remove, 4, 0);
            TableLayoutFields.Dock = DockStyle.Fill;
            TableLayoutFields.Location = new Point(0, 0);
            TableLayoutFields.Margin = new Padding(4);
            TableLayoutFields.Name = "TableLayoutFields";
            TableLayoutFields.RowCount = 1;
            TableLayoutFields.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutFields.Size = new Size(424, 56);
            TableLayoutFields.TabIndex = 7;
            // 
            // MapWidth
            // 
            MapWidth.Dock = DockStyle.Fill;
            MapWidth.Location = new Point(188, 11);
            MapWidth.Margin = new Padding(4, 11, 4, 11);
            MapWidth.Name = "MapWidth";
            MapWidth.Size = new Size(84, 29);
            MapWidth.TabIndex = 2;
            // 
            // MapName
            // 
            MapName.Dock = DockStyle.Fill;
            MapName.Location = new Point(4, 11);
            MapName.Margin = new Padding(4, 11, 4, 11);
            MapName.Name = "MapName";
            MapName.Size = new Size(84, 29);
            MapName.TabIndex = 0;
            // 
            // Address
            // 
            Address.Dock = DockStyle.Fill;
            Address.Location = new Point(96, 11);
            Address.Margin = new Padding(4, 11, 4, 11);
            Address.Name = "Address";
            Address.Size = new Size(84, 29);
            Address.TabIndex = 1;
            // 
            // NewValue
            // 
            NewValue.Dock = DockStyle.Fill;
            NewValue.Location = new Point(276, 11);
            NewValue.Margin = new Padding(0, 11, 0, 11);
            NewValue.Name = "NewValue";
            NewValue.Size = new Size(92, 29);
            NewValue.TabIndex = 3;
            // 
            // Remove
            // 
            Remove.BackColor = Color.Transparent;
            Remove.BackgroundImage = Properties.Resources.ListDelete;
            Remove.BackgroundImageLayout = ImageLayout.Center;
            Remove.FlatAppearance.BorderSize = 0;
            Remove.FlatStyle = FlatStyle.Flat;
            Remove.Location = new Point(381, 11);
            Remove.Margin = new Padding(13, 11, 9, 14);
            Remove.MaximumSize = new Size(32, 35);
            Remove.MinimumSize = new Size(32, 35);
            Remove.Name = "Remove";
            Remove.Size = new Size(32, 35);
            Remove.TabIndex = 4;
            Remove.UseVisualStyleBackColor = false;
            // 
            // BoschMapEditorControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutFields);
            Margin = new Padding(4);
            Name = "BoschMapEditorControl";
            Size = new Size(424, 56);
            TableLayoutFields.ResumeLayout(false);
            TableLayoutFields.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutFields;
        public TextBox MapName;
        public TextBox Address;
        public TextBox NewValue;
        public Button Remove;
        public TextBox MapWidth;
    }
}
