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
using TheEvolution.StageCell.Cells;

namespace TheEvolution {
    public partial class FormCellStage : Form {
        PlayerCell player;

        public FormCellStage() {
            InitializeComponent();
            GameSystem.RePaint += new GameSystem.GameHandler(Invalidate);
            GameEngine.Tick += GameSystem.Act;
            player = new PlayerCell();
            KeyDown += new KeyEventHandler(player.PlayerKeyDown);
            KeyUp += new KeyEventHandler(player.PlayerKeyUp);
            Paint += new PaintEventHandler(player.Paint);
            GameEngine.Tick += new EventHandler(player.NextStep);
        }

        private void FormCellStage_Load(object sender, EventArgs e) {
            GameSystem.setControlSize(labelExit, ClientSize, 0.04, 0.95, 0.05, 0.05);
            GameSystem.setFrame(player, ClientSize, 0.5, 0.5, 0.08, 0.15);
            GameEngine.Start();
        }

        private void labelExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
