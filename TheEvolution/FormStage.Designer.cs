﻿namespace TheEvolution {
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
            this.labelExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelExit.Location = new System.Drawing.Point(12, 515);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(123, 67);
            this.labelExit.TabIndex = 0;
            this.labelExit.Text = "Exit";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FormStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1036, 591);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStage";
            this.Text = "TheEvolution - Cell";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormStage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelExit;
        public System.Windows.Forms.Label label1;
    }
}