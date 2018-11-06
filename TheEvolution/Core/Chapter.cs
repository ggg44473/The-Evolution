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
    public abstract class Chapter {

        protected Thread threadAct;
        protected Thread threadCollide;
        internal Player player;
        internal Background background;
        protected List<Point> pPlantWall;
        protected List<Point> pTracker;
        protected List<Point> pShocker;
        protected List<Point> pPredator;
        protected List<Point> pVirus;
        protected List<Point> pCompetitor;
        internal List<Food> food;
        internal List<Cell> otherCells;

        public Chapter(PictureBox picBoxStage) {
            threadAct = new Thread(GameSystem.Act);
            threadCollide = new Thread(GameSystem.CollisionDetect);
            background = new Background(picBoxStage);
            player = new Player(picBoxStage, GameSystem.SetPosition(1.5, 1.5));
            pPlantWall = new List<Point>();
            pTracker = new List<Point>();
            pShocker = new List<Point>();
            pPredator = new List<Point>();
            pVirus = new List<Point>();
            pCompetitor = new List<Point>();
            food = new List<Food>();
            otherCells = new List<Cell>();
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
            GameSystem.player = null;
            GameSystem.competitors.Clear();
            GameSystem.otherCells.Clear();
            GameSystem.foods.Clear();
            GameSystem.organella.Clear();
            GameSystem.painters.Clear();
        }

        public virtual void Pause() {
            if (!FormStage.isPause) {
                threadAct.Abort();
                FormStage.isPause = true;
            }
        }

        public virtual void Resume() {
            if (FormStage.isPause) {
                threadAct = new Thread(GameSystem.Act);
                threadAct.Start();
                FormStage.isPause = false;
            }
        }

        protected void SetBorderPosition() {
            int width = GameSystem.screen.Width;
            int height = GameSystem.screen.Height;
            for (double x = 0; x < 15; x += 0.2) {
                pPlantWall.Add(GameSystem.SetPosition(x, 0));
                pPlantWall.Add(GameSystem.SetPosition(x, 2.75));
            }
            for (double y = 0; y < 10; y += 0.25) {
                pPlantWall.Add(GameSystem.SetPosition(0, y));
                pPlantWall.Add(GameSystem.SetPosition(2.8, y));
            }
        }
    }
}
