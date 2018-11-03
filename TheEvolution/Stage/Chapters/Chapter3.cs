using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheEvolution.Core;
using TheEvolution.Stage.Organella;
using TheEvolution.Stage.Cells;
using TheEvolution.Stage.Foods;

namespace TheEvolution.Stage.Chapters {
    class Chapter3 : Chapter {

        List<Point> pPlantWall;
        List<Point> pTracker;
        List<Point> pShocker;
        List<Point> pPredator;
        List<Point> pVirus;
        List<Point> pCompetitor;
        List<Food> food = new List<Food>();
        List<Cell> otherCells = new List<Cell>();
        List<Competitor> competitors = new List<Competitor>();
        ER eR;

        public Chapter3(FormStage form, Background bg) : base(form, bg) {
            for (int i = 0; i < 8; i++) {
                food.Add(new Algae(form));
                food.Add(new Charophyta(form));
            }
            for (int i = 0; i < 2; i++) {
                otherCells.Add(new PlantWall(form, pPlantWall[i]));
                otherCells.Add(new Tracker(form, pTracker[i]));
                otherCells.Add(new Shocker(form, pShocker[i]));
                otherCells.Add(new Predator(form, pPredator[i]));
                otherCells.Add(new Virus(form, pVirus[i]));
            }
            for (int i = 0; i < 4; i++) {
                competitors.Add(new Competitor(form, pCompetitor[i]));
            }
            eR = new ER(form, GameSystem.SetPosition(0.95, 0.95));
        }

        protected override void GetReady() {
        }
    }
}
