using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;
using TheEvolution.Core;
using TheEvolution.Stage;
using TheEvolution.Stage.Chapters;
using TheEvolution.Properties;
using TheEvolution.Stage.Cells;
using TheEvolution.Stage.Organella;

namespace TheEvolution {
    public partial class FormStage : Form {

        public static EChapter chapter;
        public static bool isPause;
        public ChapterTutorial chapterTutorial;
        public ChapterSurvival chapterSurvival;
        public int hpBeatInterval;

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

            GameSystem.SetControlSize(panelStatus, ClientSize, 0.15, 0.025, 0.3, 0.05);
            GameSystem.SetSquareControlSize(picBoxHp, panelStatus.Size, 0.06, 0.5, 0.08);
            GameSystem.SetControlSize(picBoxHpBar, panelStatus.Size, 0.38, 0.5, 0.5, 0.95);
            GameSystem.SetSquareControlSize(picBoxEat, panelStatus.Size, 0.7, 0.5, 0.1);
            GameSystem.SetControlSize(picBoxEatBar, panelStatus.Size, 0.88, 0.5, 0.2, 0.95);

            GameSystem.SetControlSize(panelSetting, ClientSize, 0.96, 0.025, 0.08, 0.05);
            GameSystem.SetSquareControlSize(picBoxPause, panelSetting.Size, 0.255, 0.5, 0.45);
            GameSystem.SetSquareControlSize(picBoxExit, panelSetting.Size, 0.745, 0.5, 0.45);

            NextChapter(chapter);
        }

        public void GameOver() {
            if (chapterTutorial != null) {
                chapterTutorial.End();
            }
            if (chapterSurvival != null) {
                chapterSurvival.End();
            }
            MessageBox.Show("Game Over!");
            Application.Exit();
        }

        public void NextChapter(EChapter chapter) {
            ClearChapter();
            switch (chapter) {
                case EChapter.Tutorial:
                    chapterTutorial = new ChapterTutorial(picBoxStage);
                    GameSystem.player.HpChanged += OnPlayerHpChanged;
                    GameSystem.player.Eat += OnPlayerEat;
                    chapterTutorial.Start();
                    break;
                case EChapter.Survival:
                    picBoxStage.Location = new Point(-GameSystem.screen.Width, -GameSystem.screen.Height);
                    picBoxHpBar.Image = Resources.Bloodbar5;
                    picBoxEatBar.Image = Resources.Progressbar0;
                    chapterSurvival = new ChapterSurvival(picBoxStage);
                    GameSystem.player.HpChanged += OnPlayerHpChanged;
                    GameSystem.player.Eat += OnPlayerEat;
                    chapterSurvival.Start();
                    break;
            }
        }

        public void ClearChapter() {
            chapterTutorial = null; chapterSurvival = null;
        }

        public void OnPlayerHpChanged(object sender, PlayerEventArgs args) {
            hpBeatInterval = 4;
            if (InvokeRequired) {
                Invoke((Action)delegate() {
                    GameSystem.SetSquareControlSize(picBoxHp, panelStatus.Size, 0.06, 0.5, 0.15);
                });
            } else {
                GameSystem.SetSquareControlSize(picBoxHp, panelStatus.Size, 0.06, 0.5, 0.15);
            }
            switch (args.hp) {
                case 0:
                    picBoxHpBar.Image = Resources.Bloodbar0;
                    break;
                case 1:
                    picBoxHpBar.Image = Resources.Bloodbar1;
                    break;
                case 2:
                    picBoxHpBar.Image = Resources.Bloodbar2;
                    break;
                case 3:
                    picBoxHpBar.Image = Resources.Bloodbar3;
                    break;
                case 4:
                    picBoxHpBar.Image = Resources.Bloodbar4;
                    break;
                case 5:
                    picBoxHpBar.Image = Resources.Bloodbar5;
                    break;
                case 6:
                    picBoxHpBar.Image = Resources.Bloodbar6;
                    break;
                case 7:
                    picBoxHpBar.Image = Resources.Bloodbar7;
                    break;
                case 8:
                    picBoxHpBar.Image = Resources.Bloodbar8;
                    break;
                case 9:
                    picBoxHpBar.Image = Resources.Bloodbar9;
                    break;
                case 10:
                    picBoxHpBar.Image = Resources.Bloodbar10;
                    break;
            }
        }

        public void OnPlayerEat(object sender, PlayerEventArgs args) {
            if (args.hp != 10) {
                switch (args.foodCount) {
                    case 0:
                        picBoxEatBar.Image = Resources.Progressbar0;
                        break;
                    case 1:
                        picBoxEatBar.Image = Resources.Progressbar1;
                        break;
                    case 2:
                        picBoxEatBar.Image = Resources.Progressbar2;
                        break;
                    case 3:
                        picBoxEatBar.Image = Resources.Progressbar3;
                        break;
                }
            } else {
                picBoxEatBar.Image = Resources.Progressbar4;
            }
        }

        private void picBoxExit_Click(object sender, EventArgs e) {
            if (!isPause) {
                if (chapterTutorial != null) {
                    chapterTutorial.End();
                }
                if (chapterSurvival != null) {
                    chapterSurvival.End();
                }
                Application.Exit();
            }
        }

        public void Pause_Click(object sender, EventArgs e) {
            if (chapterTutorial != null) {
                chapterTutorial.Pause();
            } else if (chapterSurvival != null) {
                chapterSurvival.Pause();
            }
            if (sender != this) {
                if (sender is Mitochondria) {
                    panelTip.BackgroundImage = Resources.MitoIntro;
                } else if (sender is Lysosome) {
                    panelTip.BackgroundImage = Resources.LysoIntro;
                } else if (sender is ER) {
                    panelTip.BackgroundImage = Resources.ERIntro;
                } else if (sender is Centromere) {
                    panelTip.BackgroundImage = Resources.CentroIntro;
                    chapter = EChapter.Survival;
                }
            } else {
                panelTip.BackgroundImage = Resources.MitoIntro;
            }
            panelTip.Visible = true;
        }

        private void panelTip_Click(object sender, EventArgs e) {
            if (chapterTutorial != null) {
                chapterTutorial.Resume();
            } else if (chapterSurvival != null) {
                chapterSurvival.Resume();
            }
            panelTip.Visible = false;
            if (chapter==EChapter.Survival) {
                chapterTutorial.End();
                picBoxStage.Location = new Point(-GameSystem.screen.Width, -GameSystem.screen.Height);
                picBoxHpBar.Image = Resources.Bloodbar5;
                picBoxEatBar.Image = Resources.Progressbar0;
                NextChapter(EChapter.Survival);
            }
        }
    }

    public enum EChapter {
        Tutorial, Survival
    }
}
