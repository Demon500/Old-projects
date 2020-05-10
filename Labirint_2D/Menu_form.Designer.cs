namespace Labirint_2D
{
    partial class MenuForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btStart = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Label();
            this.SoundSt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btStart
            // 
            resources.ApplyResources(this.btStart, "btStart");
            this.btStart.BackColor = System.Drawing.Color.Transparent;
            this.btStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStart.ForeColor = System.Drawing.Color.Gold;
            this.btStart.Name = "btStart";
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btExit
            // 
            resources.ApplyResources(this.btExit, "btExit");
            this.btExit.BackColor = System.Drawing.Color.Transparent;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.ForeColor = System.Drawing.Color.Yellow;
            this.btExit.Name = "btExit";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // SoundSt
            // 
            resources.ApplyResources(this.SoundSt, "SoundSt");
            this.SoundSt.BackColor = System.Drawing.Color.Transparent;
            this.SoundSt.CausesValidation = false;
            this.SoundSt.Checked = true;
            this.SoundSt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundSt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SoundSt.ForeColor = System.Drawing.Color.Yellow;
            this.SoundSt.Name = "SoundSt";
            this.SoundSt.UseVisualStyleBackColor = false;
            this.SoundSt.CheckedChanged += new System.EventHandler(this.SoundSt_CheckedChanged);
            // 
            // MenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Labirint_2D.Properties.Resources.MainLogo;
            this.Controls.Add(this.SoundSt);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Tag = "";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btStart;
        private System.Windows.Forms.Label btExit;
        private System.Windows.Forms.CheckBox SoundSt;
    }
}

