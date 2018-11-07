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
        internal List<Organelle> organella;
        public DateTime startTime;
        public int survivedTime;

        public Chapter(PictureBox picBoxStage) {
            GameSystem.chapter = this;
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
            organella = new List<Organelle>();

            GetReady();

            for (int i = 0; i < 40; i++) {
                food.Add(new Algae(picBoxStage));
                food.Add(new Charophyta(picBoxStage));
            }
            for (int i = 0; i < pPlantWall.Count; i++) {
                otherCells.Add(new PlantWall(picBoxStage, pPlantWall[i]));
            }
            for (int i = 0; i < pTracker.Count; i++) {
                otherCells.Add(new Tracker(picBoxStage, pTracker[i]));
            }
            for (int i = 0; i < pShocker.Count; i++) {
                otherCells.Add(new Shocker(picBoxStage, pShocker[i]));
            }
            for (int i = 0; i < pPredator.Count; i++) {
                otherCells.Add(new Predator(picBoxStage, pPredator[i]));
            }
            for (int i = 0; i < pVirus.Count; i++) {
                otherCells.Add(new Virus(picBoxStage, pVirus[i]));
            }

            organella.Add(new Mitochondria(picBoxStage, GameSystem.SetPosition(0.31, 0.31)));
        }

        protected abstract void GetReady();

        public abstract void ShowTip();

        public virtual void Start() {
            GameSystem.isStart = true;
            threadAct.Start();
            threadCollide.Start();
            startTime = DateTime.Now;
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

        public virtual void ShowLysosome() {
            organella.Add(new Lysosome(GameSystem.picBoxStage, GameSystem.SetPosition(0.31, 2.6)));
        }

        public virtual void ShowER() {
            organella.Add(new ER(GameSystem.picBoxStage, GameSystem.SetPosition(2.6, 0.31)));
        }

        public virtual void ShowCentromere() {
            organella.Add(new Centromere(GameSystem.picBoxStage, GameSystem.SetPosition(2.6, 2.6)));
        }

        public string GetTimeSurvived() {
            survivedTime = (int)(DateTime.Now - startTime).TotalSeconds;

            string string_m = (survivedTime / 60).ToString();

            int s = survivedTime % 60;
            string string_s = s < 10 ? "0" + s.ToString() : s.ToString();

            return string_m + ":" + string_s;
        }
    }
}
