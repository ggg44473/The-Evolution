namespace TheEvolution {
    partial class FormStart {
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
            this.components = new System.ComponentModel.Container();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.picContinue = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = global::TheEvolution.Properties.Resources.Title;
            this.picTitle.Location = new System.Drawing.Point(25, 8);
            this.picTitle.Margin = new System.Windows.Forms.Padding(2);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(776, 188);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 4;
            this.picTitle.TabStop = false;
            // 
            // picStart
            // 
            this.picStart.BackColor = System.Drawing.Color.Transparent;
            this.picStart.Image = global::TheEvolution.Properties.Resources.BtnStart;
            this.picStart.Location = new System.Drawing.Point(549, 217);
            this.picStart.Margin = new System.Windows.Forms.Padding(2);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(157, 50);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 5;
            this.picStart.TabStop = false;
            this.picStart.Click += new System.EventHandler(this.picStart_Click);
            // 
            // picContinue
            // 
            this.picContinue.BackColor = System.Drawing.Color.Transparent;
            this.picContinue.Image = global::TheEvolution.Properties.Resources.BtnContinue;
            this.picContinue.Location = new System.Drawing.Point(549, 279);
            this.picContinue.Margin = new System.Windows.Forms.Padding(2);
            this.picContinue.Name = "picContinue";
            this.picContinue.Size = new System.Drawing.Size(245, 50);
            this.picContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContinue.TabIndex = 6;
            this.picContinue.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = global::TheEvolution.Properties.Resources.BtnExit;
            this.picExit.Location = new System.Drawing.Point(549, 340);
            this.picExit.Margin = new System.Windows.Forms.Padding(2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(157, 50);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 7;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 180;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TheEvolution.Properties.Resources.TitleDecoration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 424);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picContinue);
            this.Controls.Add(this.picStart);
            this.Controls.Add(this.picTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormStart";
            this.Text = "The Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormStart_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormStart_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormStart_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.PictureBox picContinue;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Timer timerAnimation;
    }
}

