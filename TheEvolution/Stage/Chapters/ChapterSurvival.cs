using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheEvolution.Core;
using TheEvolution.Stage.Cells;
using TheEvolution.Stage.Organella;
using TheEvolution.Stage.Foods;
using System.Windows.Forms;

namespace TheEvolution.Stage.Chapters {
    public class ChapterSurvival : Chapter {

        public ChapterSurvival(PictureBox picBoxStage) : base(picBoxStage) {
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
