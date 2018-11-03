using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using TheEvolution.Core;
using TheEvolution.Stage.Organella;
using TheEvolution.Stage.Foods;
using TheEvolution.Stage.Cells;

namespace TheEvolution.Stage.Chapters {
    class Chapter1 : Chapter {

        List<Point> pPlantWall;
        List<Point> pTracker;
        List<Point> pShocker;
        List<Food> food = new List<Food>();
        List<Cell> otherCells = new List<Cell>();
        Mitochondria mitochondria;

        public Chapter1(FormStage form, Background bg) : base(form, bg) {
            GetReady();
            for (int i = 0; i < 8; i++) {
                food.Add(new Algae(form));
                food.Add(new Charophyta(form));
            }
            for (int i = 0; i < pPlantWall.Count; i++) {
                otherCells.Add(new PlantWall(form, pPlantWall[i]));
            }
            for (int i = 0; i < pTracker.Count; i++) {
                otherCells.Add(new Tracker(form, pTracker[i]));
            }
            for (int i = 0; i < pShocker.Count; i++) {
                otherCells.Add(new Shocker(form, pShocker[i]));
            }
            mitochondria = new Mitochondria(form, GameSystem.SetPosition(0.95, 0.95));
        }

        protected override void GetReady() {
            pPlantWall = new List<Point>();
            SetWallPosition();
            pTracker = new List<Point> {
                GameSystem.SetPosition(0.25, 0.3),
                GameSystem.SetPosition(0.5, 0.3),
                GameSystem.SetPosition(0.75, 0.3)};
            pShocker = new List<Point> {
                GameSystem.SetPosition(0.33, 0.7),
                GameSystem.SetPosition(0.66, 0.7)};
        }

        protected void SetWallPosition() {
            for (double x = -0.025; x < 21; x+=0.05) {
                pPlantWall.Add(GameSystem.SetPosition(x, -0.05));
            }
            for (double x = -0.025; x < 21; x += 0.05) {
                pPlantWall.Add(GameSystem.SetPosition(x, 0.95));
            }
            for (double y = -0.05; y < 11; y += 0.1) {
                pPlantWall.Add(GameSystem.SetPosition(-0.025, y));
            }
            for (double y = -0.05; y < 11; y += 0.1) {
                pPlantWall.Add(GameSystem.SetPosition(0.975, y));
            }
        }
    }
}
