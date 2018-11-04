using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using TheEvolution.Stage;
using TheEvolution.Stage.Cells;
using TheEvolution.Stage.Foods;
using TheEvolution.Stage.Organella;
using System.Windows.Forms;

namespace TheEvolution.Core {
    abstract class Chapter {

        protected Thread threadAct;
        protected Thread threadCollide;
        protected Player player;
        protected Background background;
        protected List<Point> pPlantWall;

        public Chapter(PictureBox picBoxBg) {
            threadAct = new Thread(GameSystem.Act);
            threadCollide = new Thread(GameSystem.CollisionDetect);
            background = new Background(picBoxBg);
            player = new Player(picBoxBg, GameSystem.SetPosition(1.5, 1.5));
            pPlantWall = new List<Point>();
            GetReady();
        }

        protected abstract void GetReady();

        public virtual void Start() {
            GameSystem.isStart = true;
            threadAct.Start();
            threadCollide.Start();
        }

        public virtual void End() {
            GameSystem.isStart = false;
            threadAct.Abort();
            threadCollide.Abort();
            foreach (Painter p in GameSystem.painters) {
                p.Dispose();
            }
            GameSystem.player = null;
            GameSystem.competitors.Clear();
            GameSystem.otherCells.Clear();
            GameSystem.foods.Clear();
            GameSystem.organella.Clear();
            GameSystem.painters.Clear();
        }

        protected void SetBorderPosition() {
            int width = GameSystem.screen.Width;
            int height = GameSystem.screen.Height;
            for (double x = -width; x < 15; x += 0.2) {
                pPlantWall.Add(GameSystem.SetPosition(x, -height));
            }
            for (double x = -width; x < 15; x += 0.2) {
                pPlantWall.Add(GameSystem.SetPosition(x, 3 * height));
            }
            for (double y = -height; y < 12; y += 0.25) {
                pPlantWall.Add(GameSystem.SetPosition(0, y));
            }
            for (double y = -height; y < 12; y += 0.25) {
                pPlantWall.Add(GameSystem.SetPosition(2.8, y));
            }
        }
    }
}
