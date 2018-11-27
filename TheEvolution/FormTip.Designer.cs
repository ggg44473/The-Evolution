namespace TheEvolution {
    partial class FormTip {
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
            this.timerGif = new System.Windows.Forms.Timer(this.components);
            this.picBoxPlot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGif
            // 
            this.timerGif.Interval = 11000;
            this.timerGif.Tick += new System.EventHandler(this.timerGif_Tick);
            // 
            // picBoxPlot
            // 
            this.picBoxPlot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxPlot.Location = new System.Drawing.Point(0, 0);
            this.picBoxPlot.Name = "picBoxPlot";
            this.picBoxPlot.Size = new System.Drawing.Size(100, 50);
            this.picBoxPlot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlot.TabIndex = 0;
            this.picBoxPlot.TabStop = false;
            this.picBoxPlot.Click += new System.EventHandler(this.picBoxPlot_Click);
            // 
            // FormTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBoxPlot);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTip";
            this.Text = "FormTip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTip_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTip_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPlot;
        private System.Windows.Forms.Timer timerGif;
    }
}