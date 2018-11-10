namespace TheEvolution {
    partial class FormEnd {
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
            this.picBoxRestart = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.picBoxGameOver = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.picBoxPlayerImage = new System.Windows.Forms.PictureBox();
            this.timerAnimate = new System.Windows.Forms.Timer(this.components);
            this.labelPlayerTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxRestart
            // 
            this.picBoxRestart.BackColor = System.Drawing.Color.Transparent;
            this.picBoxRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxRestart.Image = global::TheEvolution.Properties.Resources.IconRestart;
            this.picBoxRestart.Location = new System.Drawing.Point(1148, 21);
            this.picBoxRestart.Name = "picBoxRestart";
            this.picBoxRestart.Size = new System.Drawing.Size(46, 56);
            this.picBoxRestart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRestart.TabIndex = 4;
            this.picBoxRestart.TabStop = false;
            this.picBoxRestart.Click += new System.EventHandler(this.picBoxRestart_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBoxName.Font = new System.Drawing.Font("Cambria", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.Honeydew;
            this.textBoxName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxName.Location = new System.Drawing.Point(507, 421);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(192, 68);
            this.textBoxName.TabIndex = 5;
            // 
            // labelConfirm
            // 
            this.labelConfirm.AutoSize = true;
            this.labelConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelConfirm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelConfirm.Location = new System.Drawing.Point(722, 433);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(246, 65);
            this.labelConfirm.TabIndex = 6;
            this.labelConfirm.Text = "Confirm";
            this.labelConfirm.Click += new System.EventHandler(this.labelConfirm_Click);
            // 
            // picBoxGameOver
            // 
            this.picBoxGameOver.Image = global::TheEvolution.Properties.Resources.GameOver;
            this.picBoxGameOver.Location = new System.Drawing.Point(23, 376);
            this.picBoxGameOver.Name = "picBoxGameOver";
            this.picBoxGameOver.Size = new System.Drawing.Size(228, 192);
            this.picBoxGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGameOver.TabIndex = 8;
            this.picBoxGameOver.TabStop = false;
            this.picBoxGameOver.Click += new System.EventHandler(this.picBoxGameOver_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Cyan;
            this.labelName.Location = new System.Drawing.Point(267, 158);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(160, 55);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Cyan;
            this.labelTime.Location = new System.Drawing.Point(561, 158);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(138, 55);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "Time";
            // 
            // picBoxPlayerImage
            // 
            this.picBoxPlayerImage.Location = new System.Drawing.Point(331, 386);
            this.picBoxPlayerImage.Name = "picBoxPlayerImage";
            this.picBoxPlayerImage.Size = new System.Drawing.Size(139, 112);
            this.picBoxPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayerImage.TabIndex = 11;
            this.picBoxPlayerImage.TabStop = false;
            // 
            // timerAnimate
            // 
            this.timerAnimate.Tick += new System.EventHandler(this.timerAnimate_Tick);
            // 
            // labelPlayerTime
            // 
            this.labelPlayerTime.AutoSize = true;
            this.labelPlayerTime.BackColor = System.Drawing.SystemColors.ControlText;
            this.labelPlayerTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerTime.ForeColor = System.Drawing.Color.Cyan;
            this.labelPlayerTime.Location = new System.Drawing.Point(532, 356);
            this.labelPlayerTime.Name = "labelPlayerTime";
            this.labelPlayerTime.Size = new System.Drawing.Size(156, 51);
            this.labelPlayerTime.TabIndex = 12;
            this.labelPlayerTime.Text = "PTime";
            // 
            // FormEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::TheEvolution.Properties.Resources.Rank;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1222, 580);
            this.Controls.Add(this.picBoxGameOver);
            this.Controls.Add(this.labelPlayerTime);
            this.Controls.Add(this.picBoxPlayerImage);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.picBoxRestart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormEnd";
            this.Text = "The Evolution";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEnd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEnd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBoxRestart;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.PictureBox picBoxGameOver;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.PictureBox picBoxPlayerImage;
        private System.Windows.Forms.Timer timerAnimate;
        private System.Windows.Forms.Label labelPlayerTime;
    }
}