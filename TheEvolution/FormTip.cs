using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheEvolution {
    public partial class FormTip : Form {
        public FormTip() {
            InitializeComponent();
        }

        public void SetBackgroundImage(Bitmap bitmap) {
            BackgroundImage = bitmap;
        }

        private void FormTip_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ExitTip();
            }
        }

        private void FormTip_Click(object sender, EventArgs e) {
            ExitTip();
        }

        private void ExitTip() {
            DialogResult = DialogResult.OK;
        }
    }
}
