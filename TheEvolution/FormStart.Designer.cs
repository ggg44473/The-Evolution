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
            this.picTitle.Location = new System.Drawing.Point(25, 8);
            this.picTitle.Margin = new System.Windows.Forms.Padding(2);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(776, 188);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitle.TabIndex = 4;
            this.picTitle.TabStop = false;
            // 
            // picTutorial
            // 
            this.picTutorial.BackColor = System.Drawing.Color.Transparent;
            this.picTutorial.Image = ((System.Drawing.Image)(resources.GetObject("picTutorial.Image")));
            this.picTutorial.Location = new System.Drawing.Point(549, 217);
            this.picTutorial.Margin = new System.Windows.Forms.Padding(2);
            this.picTutorial.Name = "picTutorial";
            this.picTutorial.Size = new System.Drawing.Size(245, 50);
            this.picTutorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTutorial.TabIndex = 5;
            this.picTutorial.TabStop = false;
            this.picTutorial.Click += new System.EventHandler(this.picStart_Click);
            // 
            // picSurvive
            // 
            this.picSurvive.BackColor = System.Drawing.Color.Transparent;
            this.picSurvive.Image = ((System.Drawing.Image)(resources.GetObject("picSurvive.Image")));
            this.picSurvive.Location = new System.Drawing.Point(549, 279);
            this.picSurvive.Margin = new System.Windows.Forms.Padding(2);
            this.picSurvive.Name = "picSurvive";
            this.picSurvive.Size = new System.Drawing.Size(245, 50);
            this.picSurvive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSurvive.TabIndex = 6;
            this.picSurvive.TabStop = false;
            this.picSurvive.Click += new System.EventHandler(this.picSurvive_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
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
            this.Controls.Add(this.picSurvive);
            this.Controls.Add(this.picTutorial);
            this.Controls.Add(this.picTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
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

