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
using TheEvolution.Properties;
using System.Drawing.Drawing2D;

namespace TheEvolution {
    public partial class FormStage : Form {

        public static EChapter chapter;
        public static bool isPause;
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
            GameSystem.SetControlSize(panelTip, ClientSize, 0.5, 0.5, 0.6, 0.6);
            GameSystem.SetControlSize(picBoxExit, ClientSize, 0.04, 0.93, 0.05, 0.1);
            GameSystem.SetControlSize(picBoxPause, ClientSize, 0.11, 0.93, 0.05, 0.1);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBoxExit.Width, picBoxExit.Width);
            picBoxExit.Region = new Region(path);
            picBoxPause.Region = picBoxExit.Region;
            NextChapter(chapter);
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

        private void picBoxExit_Click(object sender, EventArgs e) {
            if (!isPause) {
                if (chapterTutorial != null) {
                    chapterTutorial.End();
                }
                if (chapterSurvival != null) {
                    chapterSurvival.End();
                }
                GameSystem.isStart = false;
                Application.Exit();
            }
        }

        private void picBoxExit_MouseHover(object sender, EventArgs e) {
            picBoxExit.Image = Resources.IconExit2;
        }

        private void picBoxExit_MouseLeave(object sender, EventArgs e) {
            picBoxExit.Image = Resources.IconExit1;
        }

        private void picBoxPause_Click(object sender, EventArgs e) {
            if (chapterTutorial != null) {
                chapterTutorial.Pause();
            } else if (chapterSurvival != null) {
                chapterSurvival.Pause();
            }
            isPause = true;
        }

        private void panelTip_Click(object sender, EventArgs e) {
            if (chapterTutorial != null) {
                chapterTutorial.Resume();
            } else if (chapterSurvival != null) {
                chapterSurvival.Resume();
            }
            isPause = false;
        }
    }

    public enum EChapter {
        Tutorial, Survival
    }
}
