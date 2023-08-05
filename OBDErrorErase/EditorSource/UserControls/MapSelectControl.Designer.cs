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
            Checkbox = new CheckBox();
            SuspendLayout();
            // 
            // Checkbox
            // 
            Checkbox.Dock = DockStyle.Fill;
            Checkbox.Location = new Point(0, 0);
            Checkbox.Margin = new Padding(4, 4, 4, 4);
            Checkbox.Name = "Checkbox";
            Checkbox.Padding = new Padding(19, 0, 0, 0);
            Checkbox.Size = new Size(360, 35);
            Checkbox.TabIndex = 1;
            Checkbox.Text = "TITLE";
            Checkbox.UseVisualStyleBackColor = true;
            // 
            // MapSelectControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Checkbox);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(360, 35);
            Name = "MapSelectControl";
            Size = new Size(360, 35);
            ResumeLayout(false);
        }

        #endregion

        public CheckBox Checkbox;
    }
}
