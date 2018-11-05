﻿using System;
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
            GameSystem.player = null;
            GameSystem.competitors.Clear();
            GameSystem.otherCells.Clear();
            GameSystem.foods.Clear();
            GameSystem.organella.Clear();
            GameSystem.painters.Clear();
        }

        public virtual void Pause() {
            if (!FormStage.isPause) {
                threadAct.Suspend();
                threadCollide.Suspend();
            }
        }

        public virtual void Resume() {
            threadAct.Resume();
            threadCollide.Resume();
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
