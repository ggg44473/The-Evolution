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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelContinue = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(351, 129);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(598, 71);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "標題";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Font = new System.Drawing.Font("Trebuchet MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.ForeColor = System.Drawing.Color.Turquoise;
            this.labelStart.Location = new System.Drawing.Point(522, 267);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(157, 70);
            this.labelStart.TabIndex = 1;
            this.labelStart.Text = "Start";
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // labelContinue
            // 
            this.labelContinue.AutoSize = true;
            this.labelContinue.BackColor = System.Drawing.Color.Transparent;
            this.labelContinue.Font = new System.Drawing.Font("Trebuchet MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContinue.ForeColor = System.Drawing.Color.Turquoise;
            this.labelContinue.Location = new System.Drawing.Point(472, 337);
            this.labelContinue.Name = "labelContinue";
            this.labelContinue.Size = new System.Drawing.Size(266, 70);
            this.labelContinue.TabIndex = 2;
            this.labelContinue.Text = "Continue";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Trebuchet MS", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.Turquoise;
            this.labelExit.Location = new System.Drawing.Point(522, 416);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(132, 70);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "Exit";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TheEvolution.Properties.Resources.bg_start;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 636);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelContinue);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStart";
            this.Text = "The Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelContinue;
        private System.Windows.Forms.Label labelExit;
    }
}

