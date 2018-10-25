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

namespace TheEvolution {
    public partial class FormStage : Form {

        Background background;
        Player player;
        Thread threadAct;
        Thread threadCollide;

        public FormStage() {
            InitializeComponent();
            GameSystem.currentForm = this;
            background = new Background(this);
            player = new Player(this);
            threadAct = new Thread(GameSystem.Act);
            threadCollide = new Thread(GameSystem.CollisionDetect);
        }

        private void FormCellStage_Load(object sender, EventArgs e) {
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
    }
}
