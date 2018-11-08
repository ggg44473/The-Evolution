using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using TheEvolution.Core;

namespace TheEvolution {
    public partial class FormEnd : Form {

        private EChapter chapter;
        private int survivedTime;
        private List<Bitmap> playerImages;

        public FormEnd(EChapter chapter, int survivedTime, List<Bitmap> playerImages) {
            InitializeComponent();
            this.chapter = chapter;
            this.survivedTime = survivedTime;
            this.playerImages = playerImages;
            string hasImage = "";
            if (playerImages != null) {
                hasImage = "Got Images";
            }
            labelTest.Text =
                chapter.ToString() + " " +
                survivedTime.ToString() + " " +
                hasImage;
        }

        private void FormEnd_Load(object sender, EventArgs e) {
            GameSystem.SetControlSize(picBoxExit, ClientSize, 0.975, 0.03, 0.04, 0.06);
            GameSystem.SetControlSize(textBoxName, ClientSize, 0.5, 0.7, 0.1, 0.2);
        }

        private void picBoxExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
