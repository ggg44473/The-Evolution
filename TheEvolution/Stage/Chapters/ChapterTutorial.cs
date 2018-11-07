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

        public void ShowLysosome() {
            organella.Add(new Lysosome(GameSystem.picBoxStage, GameSystem.SetPosition(0.31, 2.6)));
        }

        public void ShowER() {
            organella.Add(new ER(GameSystem.picBoxStage, GameSystem.SetPosition(2.6, 0.31)));
        }

        public void ShowCentromere() {
            organella.Add(new Centromere(GameSystem.picBoxStage, GameSystem.SetPosition(2.6, 2.6)));
        }

        protected override void GetReady() {
            SetBorderPosition();
            //SetPlantWallPosition();
            pTracker.Add(GameSystem.SetPosition(0.3, 1.8));
            pTracker.Add(GameSystem.SetPosition(0.5, 1.2));
            pTracker.Add(GameSystem.SetPosition(0.5, 1.8));
            pTracker.Add(GameSystem.SetPosition(0.75, 1.5));
            pTracker.Add(GameSystem.SetPosition(0.8, 1.1));

            pShocker.Add(GameSystem.SetPosition(1.1, 0.5));
            pShocker.Add(GameSystem.SetPosition(1.3, 0.3));
            pShocker.Add(GameSystem.SetPosition(1.5, 0.3));
            pShocker.Add(GameSystem.SetPosition(1.9, 0.3));
            pShocker.Add(GameSystem.SetPosition(1.7, 0.5));

            pPredator.Add(GameSystem.SetPosition(2.4, 1.8));
            pPredator.Add(GameSystem.SetPosition(2.6, 1.8));
            pPredator.Add(GameSystem.SetPosition(2.75, 1.1));
            pPredator.Add(GameSystem.SetPosition(2.75, 1.5));

            pVirus.Add(GameSystem.SetPosition(1.1, 2.1));
            pVirus.Add(GameSystem.SetPosition(1.1, 2.4));
            pVirus.Add(GameSystem.SetPosition(1.5, 2.7));
            pVirus.Add(GameSystem.SetPosition(1.8, 2.1));
            pVirus.Add(GameSystem.SetPosition(1.9, 2.8));
        }

        private void SetPlantWallPosition() {
            pPlantWall.Add(GameSystem.SetPosition(0.2, 1.25));
            pPlantWall.Add(GameSystem.SetPosition(0.2, 1.5));
            pPlantWall.Add(GameSystem.SetPosition(0.2, 2));
            pPlantWall.Add(GameSystem.SetPosition(0.8, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(0.8, 0.5));
            pPlantWall.Add(GameSystem.SetPosition(0.8, 1.75));
            pPlantWall.Add(GameSystem.SetPosition(1.2, 1.75));
            pPlantWall.Add(GameSystem.SetPosition(1.4, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(1.6, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(1.6, 2.5));
            pPlantWall.Add(GameSystem.SetPosition(1.8, 0.75));
            pPlantWall.Add(GameSystem.SetPosition(1.8, 1.0));
            pPlantWall.Add(GameSystem.SetPosition(1.8, 2.4));
            pPlantWall.Add(GameSystem.SetPosition(2, 1.0));
            pPlantWall.Add(GameSystem.SetPosition(2.6, 1.75));
        }
    }
}
