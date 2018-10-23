using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution {
    public partial class FormStart : Form {
        public FormStart() {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e) {
            GameSystem.SetControlSize(labelTitle, ClientSize, 0.5, 0.3, 0.7, 0.3);
            GameSystem.SetControlSize(labelStart, ClientSize, 0.5, 0.55, 0.15, 0.15);
            GameSystem.SetControlSize(labelContinue, ClientSize, 0.5, 0.65, 0.15, 0.15);
            GameSystem.SetControlSize(labelExit, ClientSize, 0.5, 0.75, 0.15, 0.15);
        }

        private void labelExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void labelStart_Click(object sender, EventArgs e) {
            Hide();
            FormStage formCellStage = new FormStage();
            formCellStage.FormClosed += (s, args) => this.Close();
            formCellStage.Show();
        }
    }
}
