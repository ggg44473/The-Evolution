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

namespace TheEvolution.Core {
    abstract class Chapter {

        FormStage form;
        Background background;
        Thread threadAct;
        Thread threadCollide;
        Player player;

        public Chapter(FormStage form, Background bg) {
            this.form = form;
            background = bg;
            threadAct = new Thread(GameSystem.Act);
            threadCollide = new Thread(GameSystem.CollisionDetect);
            player = new Player(form, GameSystem.SetPosition(0.1, 0.1));
        }

        protected abstract void GetReady();

        public virtual void Start() {
            GameSystem.isStart = true;
            threadAct.Start();
            threadCollide.Start();
        }

        public virtual void End() {
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
    }
}
