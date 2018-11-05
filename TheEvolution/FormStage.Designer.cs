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
            this.panelTip = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.picBoxPause = new System.Windows.Forms.PictureBox();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.picBoxEatBar = new System.Windows.Forms.PictureBox();
            this.picBoxEat = new System.Windows.Forms.PictureBox();
            this.picBoxHp = new System.Windows.Forms.PictureBox();
            this.picBoxHpBar = new System.Windows.Forms.PictureBox();
            this.picBoxStage = new System.Windows.Forms.PictureBox();
            this.panelStatus.SuspendLayout();
            this.panelSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEatBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHpBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTip
            // 
            this.panelTip.BackColor = System.Drawing.SystemColors.Control;
            this.panelTip.Location = new System.Drawing.Point(608, 136);
            this.panelTip.Name = "panelTip";
            this.panelTip.Size = new System.Drawing.Size(326, 220);
            this.panelTip.TabIndex = 5;
            this.panelTip.Visible = false;
            this.panelTip.Click += new System.EventHandler(this.panelTip_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.Black;
            this.panelStatus.Controls.Add(this.picBoxEatBar);
            this.panelStatus.Controls.Add(this.picBoxEat);
            this.panelStatus.Controls.Add(this.picBoxHp);
            this.panelStatus.Controls.Add(this.picBoxHpBar);
            this.panelStatus.Location = new System.Drawing.Point(15, 24);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(571, 62);
            this.panelStatus.TabIndex = 6;
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.Black;
            this.panelSetting.Controls.Add(this.picBoxPause);
            this.panelSetting.Controls.Add(this.picBoxExit);
            this.panelSetting.Location = new System.Drawing.Point(12, 521);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(140, 62);
            this.panelSetting.TabIndex = 9;
            // 
            // picBoxPause
            // 
            this.picBoxPause.BackColor = System.Drawing.Color.Transparent;
            this.picBoxPause.Image = global::TheEvolution.Properties.Resources.IconPause;
            this.picBoxPause.Location = new System.Drawing.Point(56, 6);
            this.picBoxPause.Name = "picBoxPause";
            this.picBoxPause.Size = new System.Drawing.Size(49, 52);
            this.picBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPause.TabIndex = 4;
            this.picBoxPause.TabStop = false;
            this.picBoxPause.Click += new System.EventHandler(this.picBoxPause_Click);
            // 
            // picBoxExit
            // 
            this.picBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.picBoxExit.Image = global::TheEvolution.Properties.Resources.IconExit;
            this.picBoxExit.Location = new System.Drawing.Point(3, 2);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(47, 56);
            this.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxExit.TabIndex = 3;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Click += new System.EventHandler(this.picBoxExit_Click);
            // 
            // picBoxEatBar
            // 
            this.picBoxEatBar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxEatBar.Image = global::TheEvolution.Properties.Resources.Progressbar0;
            this.picBoxEatBar.Location = new System.Drawing.Point(400, 19);
            this.picBoxEatBar.Name = "picBoxEatBar";
            this.picBoxEatBar.Size = new System.Drawing.Size(129, 34);
            this.picBoxEatBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEatBar.TabIndex = 8;
            this.picBoxEatBar.TabStop = false;
            // 
            // picBoxEat
            // 
            this.picBoxEat.BackColor = System.Drawing.Color.Transparent;
            this.picBoxEat.Image = global::TheEvolution.Properties.Resources.IconEat;
            this.picBoxEat.Location = new System.Drawing.Point(283, 7);
            this.picBoxEat.Name = "picBoxEat";
            this.picBoxEat.Size = new System.Drawing.Size(96, 55);
            this.picBoxEat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEat.TabIndex = 7;
            this.picBoxEat.TabStop = false;
            // 
            // picBoxHp
            // 
            this.picBoxHp.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHp.Image = global::TheEvolution.Properties.Resources.IconHP;
            this.picBoxHp.Location = new System.Drawing.Point(17, 4);
            this.picBoxHp.Name = "picBoxHp";
            this.picBoxHp.Size = new System.Drawing.Size(77, 50);
            this.picBoxHp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHp.TabIndex = 5;
            this.picBoxHp.TabStop = false;
            // 
            // picBoxHpBar
            // 
            this.picBoxHpBar.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHpBar.Image = global::TheEvolution.Properties.Resources.Bloodbar5;
            this.picBoxHpBar.Location = new System.Drawing.Point(100, 19);
            this.picBoxHpBar.Name = "picBoxHpBar";
            this.picBoxHpBar.Size = new System.Drawing.Size(157, 34);
            this.picBoxHpBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHpBar.TabIndex = 6;
            this.picBoxHpBar.TabStop = false;
            // 
            // picBoxStage
            // 
            this.picBoxStage.Location = new System.Drawing.Point(96, 115);
            this.picBoxStage.Name = "picBoxStage";
            this.picBoxStage.Size = new System.Drawing.Size(440, 278);
            this.picBoxStage.TabIndex = 2;
            this.picBoxStage.TabStop = false;
            // 
            // FormStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1036, 591);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelTip);
            this.Controls.Add(this.picBoxStage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStage";
            this.Text = "TheEvolution - Cell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStage_Load);
            this.panelStatus.ResumeLayout(false);
            this.panelSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEatBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHpBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxStage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox picBoxStage;
        private System.Windows.Forms.PictureBox picBoxExit;
        private System.Windows.Forms.PictureBox picBoxPause;
        private System.Windows.Forms.Panel panelTip;
        private System.Windows.Forms.PictureBox picBoxEatBar;
        private System.Windows.Forms.PictureBox picBoxHpBar;
        private System.Windows.Forms.Panel panelSetting;
        internal System.Windows.Forms.PictureBox picBoxEat;
        internal System.Windows.Forms.PictureBox picBoxHp;
        internal System.Windows.Forms.Panel panelStatus;
    }
}