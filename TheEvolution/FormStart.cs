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
using TheEvolution.Properties;

namespace TheEvolution {
    public partial class FormStart : Form {

        List<Bitmap> iconPlayer, iconCompetitor;
        int indexPlayer, indexCompetitor;
        Size playerSize, competitorSize;
        Point playerPosition, competitorPosition;
        bool isUp, isDown, isEnter, isActed;
        int btnAnimateInterval;

        public FormStart() {
            InitializeComponent();
            GameSystem.formStart = this;
            isActed = false;
        }

        private void FormStart_Load(object sender, EventArgs e) {
            GameSystem.screen = ClientSize;
            GameSystem.SetControlSize(picTitle, ClientSize, 0.5, 0.24, 0.95, 0.35);

            GameSystem.SetControlSize(picTutorial, ClientSize, 0.78, 0.55, 0.22, 0.1);
            GameSystem.SetControlSize(picSurvive, ClientSize, 0.78, 0.69, 0.22, 0.1);
            GameSystem.SetControlSize(picExit, ClientSize, 0.76, 0.82, 0.15, 0.07);
            
            playerSize = GameSystem.SetSize(0.41, 0.4);
            competitorSize = GameSystem.SetSize(0.09, 0.1);
            playerPosition = GameSystem.SetPosition(0.05, 0.5);
            competitorPosition = GameSystem.SetPosition(0.55, 0.5);
            iconPlayer = new List<Bitmap>() {
                new Bitmap(Resources.PlayerComplete1, playerSize),
                new Bitmap(Resources.PlayerComplete2, playerSize),
                new Bitmap(Resources.PlayerComplete3, playerSize),
                new Bitmap(Resources.PlayerComplete4, playerSize),
                new Bitmap(Resources.PlayerComplete5, playerSize)};
            iconCompetitor = new List<Bitmap>() {
                new Bitmap(Resources.Competitor1, competitorSize),
                new Bitmap(Resources.Competitor2, competitorSize)};
            timerAnimation.Start();
            GameSystem.formStage = new FormStage();
            //GameSystem.formStage.Closed += (s, arg) => Close();

            MCImusic.mciMusic("Musics/S4.mp3", "play", "repeat");
        }

        private void picStart_Click(object sender, EventArgs e) {
            Hide();
            FormStage.chapter = EChapter.Tutorial;
            GameSystem.formStage.Show();
        }

        private void picSurvive_Click(object sender, EventArgs e) {
            Hide();
            FormStage.chapter = EChapter.Survival;
            GameSystem.formStage.Show();
        }

        private void picExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void timerAnimation_Tick(object sender, EventArgs e) {
            if (indexCompetitor == 0) {
                indexCompetitor = 1;
            } else {
                indexCompetitor = 0;
            }
            if (indexPlayer < 4) {
                indexPlayer++;
            } else {
                indexPlayer = 0;
            }
            if (btnAnimateInterval == 0) {
                BtnAnimate();
                btnAnimateInterval = 2;
            }
            btnAnimateInterval--;
            Invalidate();
        }

        private void BtnAnimate() {           
            if (!isActed) {
                isActed = true;
                if (competitorPosition == GameSystem.SetPosition(0.55, 0.5)) {
                    GameSystem.SetControlSize(picTutorial, ClientSize, 0.78, 0.55, 0.27, 0.1);
                } else if (competitorPosition == GameSystem.SetPosition(0.55, 0.63)) {
                    GameSystem.SetControlSize(picSurvive, ClientSize, 0.78, 0.69, 0.27, 0.1);
                } else if (competitorPosition == GameSystem.SetPosition(0.55, 0.77)) {
                    GameSystem.SetControlSize(picExit, ClientSize, 0.76, 0.82, 0.17, 0.07);
                }
            } else {
                isActed = false;
                GameSystem.SetControlSize(picTutorial, ClientSize, 0.78, 0.55, 0.22, 0.1);
                GameSystem.SetControlSize(picSurvive, ClientSize, 0.78, 0.69, 0.22, 0.1);
                GameSystem.SetControlSize(picExit, ClientSize, 0.76, 0.82, 0.15, 0.07);
            }
        }
        
        private void BtnOperate() {
            if (isDown) {
                if (competitorPosition == GameSystem.SetPosition(0.55, 0.5)) {
                    competitorPosition = GameSystem.SetPosition(0.55, 0.63);
                } else if (competitorPosition == GameSystem.SetPosition(0.55, 0.63)) {
                    competitorPosition = GameSystem.SetPosition(0.55, 0.77);
                }                
            }
            if (isUp) {
                if (competitorPosition == GameSystem.SetPosition(0.55, 0.77)) {
                    competitorPosition = GameSystem.SetPosition(0.55, 0.63);
                } else if (competitorPosition == GameSystem.SetPosition(0.55, 0.63)) {
                    competitorPosition = GameSystem.SetPosition(0.55, 0.5);
                }
            }
            if (isEnter) {
                if (competitorPosition == GameSystem.SetPosition(0.55, 0.5)) {
                    Hide();
                    FormStage.chapter = EChapter.Tutorial;
                    GameSystem.formStage.Show();
                } else if (competitorPosition == GameSystem.SetPosition(0.55, 0.63)) {
                    Hide();
                    FormStage.chapter = EChapter.Survival;
                    GameSystem.formStage.Show();
                } else if (competitorPosition == GameSystem.SetPosition(0.55, 0.77)) {
                    Application.Exit();
                }
            }
        }

        private void FormStart_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case (Keys.Up):
                    isUp = true;
                    break;
                case (Keys.Down):
                    isDown = true;
                    break;
                case (Keys.Enter):
                    isEnter = true;
                    break;
            }
            BtnOperate();
        }

        private void FormStart_KeyUp(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case (Keys.Up):
                    isUp = false;
                    break;
                case (Keys.Down):
                    isDown = false;
                    break;
                case (Keys.Enter):
                    isEnter = false;
                    break;
            }
        }

        private void FormStart_Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(iconPlayer[indexPlayer], playerPosition);
            e.Graphics.DrawImage(iconCompetitor[indexCompetitor], competitorPosition);
        }
    }
}
