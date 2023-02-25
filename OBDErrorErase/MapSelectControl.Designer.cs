namespace OBDErrorErase
{
    partial class MapSelectControl
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
            this.SuspendLayout();
            // 
            // Checkbox
            // 
            this.Checkbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Checkbox.Location = new System.Drawing.Point(0, 0);
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Checkbox.Size = new System.Drawing.Size(280, 25);
            this.Checkbox.TabIndex = 1;
            this.Checkbox.Text = "TITLE";
            this.Checkbox.UseVisualStyleBackColor = true;
            // 
            // MapSelectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Checkbox);
            this.MaximumSize = new System.Drawing.Size(280, 25);
            this.Name = "MapSelectControl";
            this.Size = new System.Drawing.Size(280, 25);
            this.ResumeLayout(false);

        }

        #endregion

        public CheckBox Checkbox;
    }
}
