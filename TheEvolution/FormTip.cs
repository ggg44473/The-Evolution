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

        List<Bitmap> tipImages;
        int i;

        public FormTip(List<Bitmap> bitmaps) {
            InitializeComponent();
            i = 0;
            tipImages = bitmaps;
            if (tipImages != null && tipImages.Count > 0) {
                BackgroundImage = tipImages[i];
            }
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
            if (i < tipImages.Count - 1) {
                i++;
                BackgroundImage = tipImages[i];
            } else {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
