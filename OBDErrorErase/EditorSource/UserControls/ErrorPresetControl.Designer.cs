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
            Checkbox = new CheckBox();
            ButtonDelete = new Button();
            ButtonOpen = new Button();
            SuspendLayout();
            // 
            // Checkbox
            // 
            Checkbox.Location = new Point(0, 0);
            Checkbox.Name = "Checkbox";
            Checkbox.Padding = new Padding(15, 0, 0, 0);
            Checkbox.Size = new Size(195, 32);
            Checkbox.TabIndex = 0;
            Checkbox.Text = "TITLE";
            Checkbox.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.Transparent;
            ButtonDelete.BackgroundImage = Properties.Resources.ButtonRemove;
            ButtonDelete.BackgroundImageLayout = ImageLayout.Center;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Location = new Point(243, 0);
            ButtonDelete.MaximumSize = new Size(32, 32);
            ButtonDelete.MinimumSize = new Size(32, 32);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(32, 32);
            ButtonDelete.TabIndex = 1;
            ButtonDelete.UseVisualStyleBackColor = false;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonOpen
            // 
            ButtonOpen.BackColor = Color.Transparent;
            ButtonOpen.BackgroundImage = Properties.Resources.ButtonOpen;
            ButtonOpen.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonOpen.FlatAppearance.BorderSize = 0;
            ButtonOpen.FlatStyle = FlatStyle.Flat;
            ButtonOpen.Location = new Point(203, 0);
            ButtonOpen.Margin = new Padding(5, 3, 5, 3);
            ButtonOpen.MaximumSize = new Size(32, 32);
            ButtonOpen.MinimumSize = new Size(32, 32);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(32, 32);
            ButtonOpen.TabIndex = 2;
            ButtonOpen.UseVisualStyleBackColor = false;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // ErrorPresetControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(ButtonOpen);
            Controls.Add(ButtonDelete);
            Controls.Add(Checkbox);
            MaximumSize = new Size(280, 32);
            Name = "ErrorPresetControl";
            Size = new Size(278, 32);
            ResumeLayout(false);
        }

        #endregion

        public CheckBox Checkbox;
        public Button ButtonDelete;
        public Button ButtonOpen;
    }
}
