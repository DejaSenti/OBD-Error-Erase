namespace OBDErrorErase
{
    partial class ErrorPresetControl
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
            this.Checkbox = new System.Windows.Forms.CheckBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Checkbox
            // 
            this.Checkbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Checkbox.Location = new System.Drawing.Point(0, 0);
            this.Checkbox.MaximumSize = new System.Drawing.Size(130, 0);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Checkbox.Size = new System.Drawing.Size(130, 25);
            this.Checkbox.TabIndex = 0;
            this.Checkbox.Text = "TITLE";
            this.Checkbox.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonDelete.Location = new System.Drawing.Point(205, 0);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 25);
            this.ButtonDelete.TabIndex = 1;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonOpen.Location = new System.Drawing.Point(130, 0);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 25);
            this.ButtonOpen.TabIndex = 2;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = false;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ErrorPresetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.Checkbox);
            this.MaximumSize = new System.Drawing.Size(280, 25);
            this.Name = "ErrorPresetControl";
            this.Size = new System.Drawing.Size(280, 25);
            this.ResumeLayout(false);

        }

        #endregion

        public CheckBox Checkbox;
        public Button ButtonDelete;
        public Button ButtonOpen;
    }
}
