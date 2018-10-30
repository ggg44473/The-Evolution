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

        FormStage formStage;
        List<Bitmap> iconPlayer, iconCompetitor;
        int indexPlayer, indexCompetitor;
        Size playerSize, competitorSize;
        Point playerPosition, competitorPosition;
        bool isUp, isDown, isEnter, isActed;

        public FormStart() {
            InitializeComponent();
            GameSystem.form = this;
            isActed = false;
        }

        private void FormStart_Load(object sender, EventArgs e) {
            GameSystem.screen = ClientSize;
            GameSystem.SetControlSize(picTitle, ClientSize, 0.5, 0.24, 0.95, 0.35);
            GameSystem.SetControlSize(picStart, ClientSize, 0.75, 0.55, 0.19, 0.08);
            GameSystem.SetControlSize(picContinue, ClientSize, 0.78, 0.68, 0.24, 0.08);
            GameSystem.SetControlSize(picExit, ClientSize, 0.73, 0.82, 0.15, 0.07);
            playerSize = GameSystem.SetSize(0.07, 0.1);
            competitorSize = GameSystem.SetSize(0.41, 0.4);
            playerPosition = GameSystem.SetPosition(0.56, 0.5);     
            competitorPosition = GameSystem.SetPosition(0.05, 0.5);
            iconPlayer = new List<Bitmap>() {
                new Bitmap(Resources.P1, playerSize),
                new Bitmap(Resources.P2, playerSize),
                new Bitmap(Resources.P3, playerSize),
                new Bitmap(Resources.P4, playerSize),
                new Bitmap(Resources.P5, playerSize)};
            iconCompetitor = new List<Bitmap>() {
                new Bitmap(Resources.Competitor1, competitorSize),
                new Bitmap(Resources.Competitor2, competitorSize)};
            timerAnimation.Start();
            formStage = new FormStage();
        }

        private void picStart_Click(object sender, EventArgs e) {
            formStage.Closed += (s, arg) => this.Close();
            this.Hide();
            formStage.Show();
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
            BtnAnimate();
            Invalidate();
        }

        private void BtnAnimate() {           
            if (!isActed) {
                isActed = true;
                if (playerPosition == GameSystem.SetPosition(0.56, 0.5)) {
                    picStart.Size = GameSystem.SetSize(0.24, 0.13);
                    picStart.Location = GameSystem.SetPosition(0.655, 0.49);
                } else if (playerPosition == GameSystem.SetPosition(0.56, 0.63)) {
                    picContinue.Size = GameSystem.SetSize(0.29, 0.13);
                    picContinue.Location = GameSystem.SetPosition(0.655, 0.62);
                } else if (playerPosition == GameSystem.SetPosition(0.56, 0.77)) {
                    picExit.Size = GameSystem.SetSize(0.20, 0.12);
                    picExit.Location = GameSystem.SetPosition(0.655, 0.76);
                }
            } else {
                isActed = false;
                GameSystem.SetControlSize(picStart, ClientSize, 0.75, 0.55, 0.19, 0.08);
                GameSystem.SetControlSize(picContinue, ClientSize, 0.78, 0.68, 0.24, 0.08);
                GameSystem.SetControlSize(picExit, ClientSize, 0.73, 0.82, 0.15, 0.07);
            }
            
        }
        
        private void BtnOperate() {
            if (isDown) {
                if (playerPosition == GameSystem.SetPosition(0.56, 0.5)) {
                    playerPosition = GameSystem.SetPosition(0.56, 0.63);
                } else if (playerPosition == GameSystem.SetPosition(0.56, 0.63)) {
                    playerPosition = GameSystem.SetPosition(0.56, 0.77);
                }                
            }
            if (isUp) {
                if (playerPosition == GameSystem.SetPosition(0.56, 0.77)) {
                    playerPosition = GameSystem.SetPosition(0.56, 0.63);
                } else if (playerPosition == GameSystem.SetPosition(0.56, 0.63)) {
                    playerPosition = GameSystem.SetPosition(0.56, 0.5);
                }
            }
            if (isEnter) {
                if (playerPosition == GameSystem.SetPosition(0.56, 0.5)) {
                    formStage.Closed += (s, arg) => this.Close();
                    this.Hide();
                    formStage.Show();
                } else if (playerPosition == GameSystem.SetPosition(0.56, 0.63)) {

                } else if (playerPosition == GameSystem.SetPosition(0.56, 0.77)) {
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
