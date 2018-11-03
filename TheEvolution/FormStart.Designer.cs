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
            this.picSurvive = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSurvive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = global::TheEvolution.Properties.Resources.Title;
            this.picTitle.Location = new System.Drawing.Point(38, 12);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(1164, 282);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 4;
            this.picTitle.TabStop = false;
            // 
            // picStart
            // 
            this.picStart.BackColor = System.Drawing.Color.Transparent;
            this.picStart.Image = global::TheEvolution.Properties.Resources.BtnStart;
            this.picStart.Location = new System.Drawing.Point(824, 326);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(236, 75);
            this.picStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStart.TabIndex = 5;
            this.picStart.TabStop = false;
            this.picStart.Click += new System.EventHandler(this.picStart_Click);
            // 
            // picSurvive
            // 
            this.picSurvive.BackColor = System.Drawing.Color.Transparent;
            this.picSurvive.Image = global::TheEvolution.Properties.Resources.BtnContinue;
            this.picSurvive.Location = new System.Drawing.Point(824, 418);
            this.picSurvive.Name = "picSurvive";
            this.picSurvive.Size = new System.Drawing.Size(368, 75);
            this.picSurvive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSurvive.TabIndex = 6;
            this.picSurvive.TabStop = false;
            this.picSurvive.Click += new System.EventHandler(this.picSurvive_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = global::TheEvolution.Properties.Resources.BtnExit;
            this.picExit.Location = new System.Drawing.Point(824, 510);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(236, 75);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::TheEvolution.Properties.Resources.TitleDecoration;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 636);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.picSurvive);
            this.Controls.Add(this.picStart);
            this.Controls.Add(this.picTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStart";
            this.Text = "The Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormStart_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormStart_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormStart_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSurvive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.PictureBox picSurvive;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Timer timerAnimation;
    }
}

