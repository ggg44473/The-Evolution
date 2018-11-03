using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using TheEvolution.Core;
using TheEvolution.Stage;
using TheEvolution.Stage.Chapters;

namespace TheEvolution {
    public partial class FormStage : Form {

        public static int chapter;
        Background bg;
        Chapter1 chapter1;
        Chapter2 chapter2;
        Chapter3 chapter3;
        Chapter4 chapter4;

        public FormStage() {
            InitializeComponent();
            ImageContainer.PrepareImage();
            bg = new Background(this);
            GameSystem.form = this;
        }

        private void FormStage_Load(object sender, EventArgs e) {
            GameSystem.SetControlSize(labelExit, ClientSize, 0.04, 0.95, 0.05, 0.05);
            NextChapter(chapter);
        }

        private void labelExit_Click(object sender, EventArgs e) {
            GameSystem.isStart = false;
            Application.Exit();
        }

        public void GameOver() {
            GameSystem.isStart = false;
            MessageBox.Show("Game Over!");
            Application.Exit();
        }

        public void NextChapter(int chapter) {
            ClearChapter();
            switch (chapter) {
                case 1:
                    chapter1 = new Chapter1(this, bg);
                    chapter1.Start();
                    break;
                case 2:
                    chapter2 = new Chapter2(this, bg);
                    chapter2.Start();
                    break;
                case 3:
                    chapter3 = new Chapter3(this, bg);
                    chapter3.Start();
                    break;
                case 4:
                    chapter4 = new Chapter4(this, bg);
                    chapter4.Start();
                    break;
            }
        }

        public void ClearChapter() {
            chapter1 = null; chapter2 = null; chapter3 = null; chapter4 = null;
        }
    }
}
