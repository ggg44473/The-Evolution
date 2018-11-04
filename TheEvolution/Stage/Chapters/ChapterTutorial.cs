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
using System.Windows.Forms;

namespace TheEvolution.Stage.Chapters {
    class ChapterTutorial : Chapter {

        List<Point> pTracker;
        List<Point> pShocker;
        List<Food> food = new List<Food>();
        List<Cell> otherCells = new List<Cell>();
        Mitochondria mitochondria;

        public ChapterTutorial(PictureBox picBoxBg) : base(picBoxBg) {
            for (int i = 0; i < 50; i++) {
                food.Add(new Algae(picBoxBg));
                food.Add(new Charophyta(picBoxBg));
            }
            for (int i = 0; i < pPlantWall.Count; i++) {
                otherCells.Add(new PlantWall(picBoxBg, pPlantWall[i]));
            }
            for (int i = 0; i < pTracker.Count; i++) {
                otherCells.Add(new Tracker(picBoxBg, pTracker[i]));
            }
            for (int i = 0; i < pShocker.Count; i++) {
                otherCells.Add(new Shocker(picBoxBg, pShocker[i]));
            }
            mitochondria = new Mitochondria(picBoxBg, GameSystem.SetPosition(0.785, 0.80));
        }

        protected override void GetReady() {
            SetBorderPosition();
            //SetPlantWallPosition();
            pTracker = new List<Point> {
                GameSystem.SetPosition(0.125, 0.62),
                GameSystem.SetPosition(0.5, 0.3)};
            pShocker = new List<Point> {
                GameSystem.SetPosition(0.265, 0.25),
                GameSystem.SetPosition(0.265, 0.65),
                GameSystem.SetPosition(0.415, 0.65),
                GameSystem.SetPosition(0.568, 0.24),
                GameSystem.SetPosition(0.825, 0.24)};
        }

        private void SetPlantWallPosition() {
            pPlantWall.Add(GameSystem.SetPosition(0.125, 0.05));
            pPlantWall.Add(GameSystem.SetPosition(0.125, 0.15));
            pPlantWall.Add(GameSystem.SetPosition(0.125, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(0.125, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.125, 0.45));
            pPlantWall.Add(GameSystem.SetPosition(0.125, 0.75));
            pPlantWall.Add(GameSystem.SetPosition(0.125, 0.85));
            pPlantWall.Add(GameSystem.SetPosition(0.275, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.275, 0.45));
            pPlantWall.Add(GameSystem.SetPosition(0.275, 0.55));
            pPlantWall.Add(GameSystem.SetPosition(0.275, 0.75));
            pPlantWall.Add(GameSystem.SetPosition(0.275, 0.85));
            pPlantWall.Add(GameSystem.SetPosition(0.325, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(0.325, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.375, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(0.375, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.425, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(0.425, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.475, 0.65));
            pPlantWall.Add(GameSystem.SetPosition(0.525, 0.65));
            pPlantWall.Add(GameSystem.SetPosition(0.575, 0.05));
            pPlantWall.Add(GameSystem.SetPosition(0.575, 0.15));
            pPlantWall.Add(GameSystem.SetPosition(0.575, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.575, 0.45));
            pPlantWall.Add(GameSystem.SetPosition(0.575, 0.55));
            pPlantWall.Add(GameSystem.SetPosition(0.575, 0.65));
            pPlantWall.Add(GameSystem.SetPosition(0.725, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(0.725, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.725, 0.45));
            pPlantWall.Add(GameSystem.SetPosition(0.725, 0.55));
            pPlantWall.Add(GameSystem.SetPosition(0.725, 0.65));
            pPlantWall.Add(GameSystem.SetPosition(0.725, 0.75));
            pPlantWall.Add(GameSystem.SetPosition(0.725, 0.85));
            pPlantWall.Add(GameSystem.SetPosition(0.775, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(0.775, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.775, 0.45));
            pPlantWall.Add(GameSystem.SetPosition(0.775, 0.55));
            pPlantWall.Add(GameSystem.SetPosition(0.775, 0.65));
            pPlantWall.Add(GameSystem.SetPosition(0.825, 0.35));
            pPlantWall.Add(GameSystem.SetPosition(0.825, 0.45));
            pPlantWall.Add(GameSystem.SetPosition(0.825, 0.55));
            pPlantWall.Add(GameSystem.SetPosition(0.825, 0.65));
        }
    }
}
