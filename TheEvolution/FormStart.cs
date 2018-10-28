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
        List<Bitmap> iconPlayer;
        List<Bitmap> iconCompetitor;
        int indexPlayer, indexCompetitor;
        Size playerSize;
        Size competitorSize;
        Point playerPosition;
        Point competitorPosition;

        public FormStart() {
            InitializeComponent();
            GameSystem.currentForm = this;
        }

        private void FormStart_Load(object sender, EventArgs e) {
            GameSystem.screen = ClientSize;
            GameSystem.SetControlSize(picTitle, ClientSize, 0.5, 0.24, 0.95, 0.35);
            GameSystem.SetControlSize(picStart, ClientSize, 0.75, 0.55, 0.19, 0.1);
            GameSystem.SetControlSize(picContinue, ClientSize, 0.75, 0.67, 0.24, 0.1);
            GameSystem.SetControlSize(picExit, ClientSize, 0.75, 0.79, 0.15, 0.1);
            playerSize = GameSystem.SetSize(0.1, 0.1);
            competitorSize = GameSystem.SetSize(0.43, 0.4);
            playerPosition = GameSystem.SetPosition(0.57, 0.5);
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
            //indexPlayer++;
            Invalidate();
        }

        private void FormStart_Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(iconPlayer[indexPlayer], playerPosition);
            e.Graphics.DrawImage(iconCompetitor[indexCompetitor], competitorPosition);
        }
    }
}
