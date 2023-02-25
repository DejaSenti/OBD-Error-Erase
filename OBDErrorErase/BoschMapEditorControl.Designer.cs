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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Name = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Width = new System.Windows.Forms.ComboBox();
            this.NewValue = new System.Windows.Forms.TextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(43, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 100);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(123, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 100);
            this.label6.TabIndex = 3;
            this.label6.Text = "New Value";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Name, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Address, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Width, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NewValue, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Remove, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 40);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // Name
            // 
            this.Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name.Location = new System.Drawing.Point(3, 8);
            this.Name.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(60, 23);
            this.Name.TabIndex = 0;
            // 
            // Address
            // 
            this.Address.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address.Location = new System.Drawing.Point(69, 8);
            this.Address.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(60, 23);
            this.Address.TabIndex = 1;
            // 
            // Width
            // 
            this.Width.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Width.FormattingEnabled = true;
            this.Width.Items.AddRange(new object[] {
            "8bit",
            "16bit",
            "32bit",
            "64bit"});
            this.Width.Location = new System.Drawing.Point(135, 8);
            this.Width.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(60, 23);
            this.Width.TabIndex = 2;
            // 
            // NewValue
            // 
            this.NewValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewValue.Location = new System.Drawing.Point(201, 8);
            this.NewValue.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.NewValue.Name = "NewValue";
            this.NewValue.Size = new System.Drawing.Size(60, 23);
            this.NewValue.TabIndex = 3;
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.LightCoral;
            this.Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remove.Location = new System.Drawing.Point(267, 3);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(60, 34);
            this.Remove.TabIndex = 4;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            // 
            // BoschMapEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name.Name = "BoschMapEditorControl";
            this.Size = new System.Drawing.Size(330, 40);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        public TextBox Name;
        public TextBox Address;
        public ComboBox Width;
        public TextBox NewValue;
        public Button Remove;
    }
}
