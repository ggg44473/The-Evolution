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
using System.Reflection;

namespace TheEvolution {
    public partial class FormStage : Form {

        public static EChapter chapter;
        ChapterTutorial chapterTutorial;
        ChapterSurvival chapterSurvival;

        public FormStage() {
            InitializeComponent();
            ImageContainer.PrepareImage();
            GameSystem.formStage = this;
            GameSystem.picBoxStage = picBoxStage;
            picBoxStage.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(picBoxStage, true, null);
            picBoxStage.Size = new Size(3 * GameSystem.screen.Width, 3 * GameSystem.screen.Height);
            picBoxStage.Location = new Point(-GameSystem.screen.Width, -GameSystem.screen.Height);
        }

        private void FormStage_Load(object sender, EventArgs e) {
            GameSystem.SetControlSize(labelExit, ClientSize, 0.04, 0.95, 0.05, 0.05);
            NextChapter(chapter);
        }

        private void labelExit_Click(object sender, EventArgs e) {
            if (chapterTutorial != null) {
                chapterTutorial.End();
            }
            if (chapterSurvival != null) {
                chapterSurvival.End();
            }
            GameSystem.isStart = false;
            Application.Exit();
        }

        public void GameOver() {
            if (chapterTutorial != null) {
                chapterTutorial.End();
            }
            if (chapterSurvival != null) {
                chapterSurvival.End();
            }
            GameSystem.isStart = false;
            MessageBox.Show("Game Over!");
            Application.Exit();
        }

        public void NextChapter(EChapter chapter) {
            ClearChapter();
            switch (chapter) {
                case EChapter.Tutorial:
                    chapterTutorial = new ChapterTutorial(picBoxStage);
                    chapterTutorial.Start();
                    break;
                case EChapter.Survival:
                    chapterSurvival = new ChapterSurvival(picBoxStage);
                    chapterSurvival.Start();
                    break;
            }
        }

        public void ClearChapter() {
            chapterTutorial = null; chapterSurvival = null;
        }
    }

    public enum EChapter {
        Tutorial, Survival
    }
}
