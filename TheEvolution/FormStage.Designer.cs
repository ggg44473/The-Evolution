namespace TheEvolution {
    partial class FormStage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.picBoxStage = new System.Windows.Forms.PictureBox();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.picBoxPause = new System.Windows.Forms.PictureBox();
            this.panelTip = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPause)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxStage
            // 
            this.picBoxStage.Location = new System.Drawing.Point(0, 0);
            this.picBoxStage.Name = "picBoxStage";
            this.picBoxStage.Size = new System.Drawing.Size(440, 278);
            this.picBoxStage.TabIndex = 2;
            this.picBoxStage.TabStop = false;
            // 
            // picBoxExit
            // 
            this.picBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.picBoxExit.Image = global::TheEvolution.Properties.Resources.IconExit1;
            this.picBoxExit.Location = new System.Drawing.Point(12, 508);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(84, 73);
            this.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxExit.TabIndex = 3;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Click += new System.EventHandler(this.picBoxExit_Click);
            this.picBoxExit.MouseLeave += new System.EventHandler(this.picBoxExit_MouseLeave);
            this.picBoxExit.MouseHover += new System.EventHandler(this.picBoxExit_MouseHover);
            // 
            // picBoxPause
            // 
            this.picBoxPause.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPause.Image = global::TheEvolution.Properties.Resources.IconStop1;
            this.picBoxPause.Location = new System.Drawing.Point(102, 508);
            this.picBoxPause.Name = "picBoxPause";
            this.picBoxPause.Size = new System.Drawing.Size(100, 71);
            this.picBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPause.TabIndex = 4;
            this.picBoxPause.TabStop = false;
            this.picBoxPause.Click += new System.EventHandler(this.picBoxPause_Click);
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.SystemColors.Control;
            this.panelTip.Location = new System.Drawing.Point(473, 133);
            this.panelTip.Name = "panelTip";
            this.panelTip.Size = new System.Drawing.Size(325, 220);
            this.panelTip.TabIndex = 5;
            this.panelTip.Click += new System.EventHandler(this.panelTip_Click);
            // 
            // FormStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1036, 591);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.picBoxPause);
            this.Controls.Add(this.picBoxExit);
            this.Controls.Add(this.picBoxStage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStage";
            this.Text = "TheEvolution - Cell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox picBoxStage;
        private System.Windows.Forms.PictureBox picBoxExit;
        private System.Windows.Forms.PictureBox picBoxPause;
        private System.Windows.Forms.Panel panelTip;
    }
}