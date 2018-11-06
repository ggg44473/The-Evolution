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
    public class ChapterTutorial : Chapter {

        internal List<Organelle> organella = new List<Organelle>();

        public ChapterTutorial(PictureBox picBoxStage) : base(picBoxStage) {
            for (int i = 0; i < 70; i++) {
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
            organella.Add(new Mitochondria(picBoxStage, GameSystem.SetPosition(0.5, 0.5)));
        }

        public void ShowLysosome() {
            organella.Add(new Lysosome(GameSystem.picBoxStage, GameSystem.SetPosition(1.5, 0.5)));
        }

        public void ShowER() {
            organella.Add(new ER(GameSystem.picBoxStage, GameSystem.SetPosition(2.5, 0.5)));
        }

        public void ShowCentromere() {
            organella.Add(new Centromere(GameSystem.picBoxStage, GameSystem.SetPosition(2.5, 1.5)));
        }

        protected override void GetReady() {
            SetBorderPosition();
            //SetPlantWallPosition();
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
        }
    }
}
