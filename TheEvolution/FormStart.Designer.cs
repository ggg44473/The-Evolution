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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picTutorial = new System.Windows.Forms.PictureBox();
            this.picSurvive = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTutorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSurvive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.Image = ((System.Drawing.Image)(resources.GetObject("picTitle.Image")));
            this.picTitle.Location = new System.Drawing.Point(38, 12);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(1164, 282);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 4;
            this.picTitle.TabStop = false;
            // 
            // picTutorial
            // 
            this.picTutorial.BackColor = System.Drawing.Color.Transparent;
            this.picTutorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTutorial.Image = global::TheEvolution.Properties.Resources.Chapter1;
            this.picTutorial.Location = new System.Drawing.Point(824, 326);
            this.picTutorial.Name = "picTutorial";
            this.picTutorial.Size = new System.Drawing.Size(368, 75);
            this.picTutorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTutorial.TabIndex = 5;
            this.picTutorial.TabStop = false;
            this.picTutorial.Click += new System.EventHandler(this.picStart_Click);
            // 
            // picSurvive
            // 
            this.picSurvive.BackColor = System.Drawing.Color.Transparent;
            this.picSurvive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSurvive.Image = global::TheEvolution.Properties.Resources.Chapter2;
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
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
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
            this.Controls.Add(this.picTutorial);
            this.Controls.Add(this.picTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "The Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormStart_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormStart_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormStart_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTutorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSurvive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picTutorial;
        private System.Windows.Forms.PictureBox picSurvive;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Timer timerAnimation;
    }
}

