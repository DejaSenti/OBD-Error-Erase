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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // Checkbox
            // 
            Checkbox.Dock = DockStyle.Fill;
            Checkbox.Location = new Point(0, 0);
            Checkbox.Margin = new Padding(4, 4, 4, 4);
            Checkbox.Name = "Checkbox";
            Checkbox.Padding = new Padding(19, 0, 0, 0);
            Checkbox.Size = new Size(239, 45);
            Checkbox.TabIndex = 0;
            Checkbox.Text = "TITLE";
            Checkbox.UseVisualStyleBackColor = true;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.Transparent;
            ButtonDelete.BackgroundImage = Properties.Resources.ButtonRemove;
            ButtonDelete.BackgroundImageLayout = ImageLayout.Center;
            ButtonDelete.Dock = DockStyle.Fill;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Location = new Point(0, 0);
            ButtonDelete.Margin = new Padding(4, 4, 4, 4);
            ButtonDelete.MinimumSize = new Size(41, 45);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(57, 45);
            ButtonDelete.TabIndex = 1;
            ButtonDelete.UseVisualStyleBackColor = false;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonOpen
            // 
            ButtonOpen.BackColor = Color.Transparent;
            ButtonOpen.BackgroundImage = Properties.Resources.ButtonOpen;
            ButtonOpen.BackgroundImageLayout = ImageLayout.Center;
            ButtonOpen.Dock = DockStyle.Fill;
            ButtonOpen.FlatAppearance.BorderSize = 0;
            ButtonOpen.FlatStyle = FlatStyle.Flat;
            ButtonOpen.Location = new Point(0, 0);
            ButtonOpen.Margin = new Padding(6, 4, 6, 4);
            ButtonOpen.MinimumSize = new Size(41, 45);
            ButtonOpen.Name = "ButtonOpen";
            ButtonOpen.Size = new Size(56, 45);
            ButtonOpen.TabIndex = 2;
            ButtonOpen.UseVisualStyleBackColor = false;
            ButtonOpen.Click += ButtonOpen_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(Checkbox);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(360, 45);
            splitContainer1.SplitterDistance = 239;
            splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(ButtonOpen);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(ButtonDelete);
            splitContainer2.Size = new Size(117, 45);
            splitContainer2.SplitterDistance = 56;
            splitContainer2.TabIndex = 0;
            // 
            // ErrorPresetControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(360, 45);
            Name = "ErrorPresetControl";
            Size = new Size(360, 45);
            Load += ErrorPresetControl_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public CheckBox Checkbox;
        public Button ButtonDelete;
        public Button ButtonOpen;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
    }
}
