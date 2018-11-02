﻿using System;
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
using TheEvolution.Stage.Organella;

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

            for (int i = 0; i < 8; i++) {
                Algae algae = new Algae(this);
                Charophyta charophyta = new Charophyta(this);
            }

            player = new Player(this);
            Predator predator = new Predator(this);
            Competitor competitor = new Competitor(this);

            Centromere centromere = new Centromere(this);
            Chloroplast chloroplast = new Chloroplast(this);
            ER eR = new ER(this);
            Lysosome lysosome = new Lysosome(this);
            Mitochondria mitochondria = new Mitochondria(this);

            for (int i = 0; i < 2; i++) {
                Shocker shocker = new Shocker(this);
            }

            for (int i = 0; i < 3; i++) {
                Virus virus = new Virus(this);
                Tracker tracker = new Tracker(this);               
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

        public void GameOver() {
            GameSystem.isStart = false;
            MessageBox.Show("Game Over!");
            Application.Exit();
        }
    }
}
