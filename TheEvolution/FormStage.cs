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
using TheEvolution.Stage.Cells;
using TheEvolution.Stage.Foods;

namespace TheEvolution {
    public partial class FormStage : Form {

        ImageContainer imgContainer;
        Background background;
        Player player;
        Thread threadAct;
        Thread threadCollide;

        public FormStage() {
            InitializeComponent();
            imgContainer = new ImageContainer();
            background = new Background(this);

            for (int i = 0; i < 10; i++) {
                Algae algae = new Algae(this);
                Charophyta charophyta = new Charophyta(this);
            }

            player = new Player(this);
            player.GameOver += OnGameOver;

            for (int i = 0; i < 2; i++) {
                Competitor competitor = new Competitor(this);
            }

            for (int i = 0; i < 4; i++) {
                Virus virus = new Virus(this);
                Tracker tracker = new Tracker(this);
                Shocker shocker = new Shocker(this);
                Predator predator = new Predator(this);
                PlantWall plantWall = new PlantWall(this);
            }

            threadAct = new Thread(GameSystem.Act);
            threadCollide = new Thread(GameSystem.CollisionDetect);

            GameSystem.form = this;
        }

        private void FormStage_Load(object sender, EventArgs e) {
            GameSystem.SetControlSize(labelExit, ClientSize, 0.04, 0.95, 0.05, 0.05);
            GameSystem.CheckPainterGenerated();
            if (GameSystem.isPainterGenerated) {
                GameSystem.isStart = true;
                threadAct.Start();
                threadCollide.Start();
            }
        }

        private void labelExit_Click(object sender, EventArgs e) {
            GameSystem.isStart = false;
            Application.Exit();
        }

        private void OnGameOver(object sender, EventArgs e) {
            GameSystem.isStart = false;
            MessageBox.Show("Game Over!");
            Application.Exit();
        }
    }
}
