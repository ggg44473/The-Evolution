using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using TheEvolution.Core;
using System.Windows.Forms;
using TheEvolution.Properties;

namespace TheEvolution.Stage.Chapters {
    public class ChapterSurvival : Chapter {

        public ChapterSurvival(PictureBox picBoxStage) : base(picBoxStage) {
            background.ChangeBackground(1);
        }

        protected override void GetReady() {
            SetBorderPosition();
            SetPlantWallPosition();

            pTracker.Add(GameSystem.SetPosition(0.5, 0.5));
            pTracker.Add(GameSystem.SetPosition(0.2, 0.6));
            pTracker.Add(GameSystem.SetPosition(0.5, 1.2));
            pTracker.Add(GameSystem.SetPosition(0.5, 1.7));
            pTracker.Add(GameSystem.SetPosition(0.4, 2.2));
            pTracker.Add(GameSystem.SetPosition(0.5, 2.3));
            pTracker.Add(GameSystem.SetPosition(0.8, 2.4));
            pTracker.Add(GameSystem.SetPosition(1.1, 0.3));
            pTracker.Add(GameSystem.SetPosition(1.4, 0.45));
            pTracker.Add(GameSystem.SetPosition(1.6, 0.6));
            pTracker.Add(GameSystem.SetPosition(1.3, 2.3));
            pTracker.Add(GameSystem.SetPosition(1.5, 2.5));
            pTracker.Add(GameSystem.SetPosition(1.4, 2.7));
            pTracker.Add(GameSystem.SetPosition(2.55, 0.6));
            pTracker.Add(GameSystem.SetPosition(2.3, 0.5));
            pTracker.Add(GameSystem.SetPosition(2.1, 1.4));
            pTracker.Add(GameSystem.SetPosition(2.2, 1.7));
            pTracker.Add(GameSystem.SetPosition(2.5, 1.8));
            pTracker.Add(GameSystem.SetPosition(2.1, 2.3));
            pTracker.Add(GameSystem.SetPosition(2.3, 2.5));
            pTracker.Add(GameSystem.SetPosition(2.6, 2.4));

            pShocker.Add(GameSystem.SetPosition(0.3, 0.5));
            pShocker.Add(GameSystem.SetPosition(0.42, 0.53));
            pShocker.Add(GameSystem.SetPosition(0.6, 0.45));
            pShocker.Add(GameSystem.SetPosition(0.5, 1.5));
            pShocker.Add(GameSystem.SetPosition(0.7, 1.8));
            pShocker.Add(GameSystem.SetPosition(0.5, 2.6));
            pShocker.Add(GameSystem.SetPosition(1.9, 0.4));
            pShocker.Add(GameSystem.SetPosition(1.4, 1.15));
            pShocker.Add(GameSystem.SetPosition(1.2, 1.4));
            pShocker.Add(GameSystem.SetPosition(1.7, 1.8));
            pShocker.Add(GameSystem.SetPosition(1.75, 2.3));
            pShocker.Add(GameSystem.SetPosition(1.5, 2.7));
            pShocker.Add(GameSystem.SetPosition(2.35, 1.2));
            pShocker.Add(GameSystem.SetPosition(2.2, 1.5));
            pShocker.Add(GameSystem.SetPosition(2.2, 2.2));
            pShocker.Add(GameSystem.SetPosition(2.5, 2.5));

            pPredator.Add(GameSystem.SetPosition(0.26, 0.75));
            pPredator.Add(GameSystem.SetPosition(0.26, 2.28));
            pPredator.Add(GameSystem.SetPosition(0.26, 1.71));
            pPredator.Add(GameSystem.SetPosition(0.38, 1.36));
            pPredator.Add(GameSystem.SetPosition(0.7, 0.27));
            pPredator.Add(GameSystem.SetPosition(0.81, 1.12));
            pPredator.Add(GameSystem.SetPosition(0.87, 2.6));
            pPredator.Add(GameSystem.SetPosition(1.3, 0.38));
            pPredator.Add(GameSystem.SetPosition(1.62, 0.64));
            pPredator.Add(GameSystem.SetPosition(1.1, 1.89));
            pPredator.Add(GameSystem.SetPosition(1.1, 1.55));
            pPredator.Add(GameSystem.SetPosition(1.8, 1.09));
            pPredator.Add(GameSystem.SetPosition(1.12, 2.2));
            pPredator.Add(GameSystem.SetPosition(1.82, 2.6));
            pPredator.Add(GameSystem.SetPosition(2.35, 0.3));
            pPredator.Add(GameSystem.SetPosition(2.5, 0.3));
            pPredator.Add(GameSystem.SetPosition(2.7, 0.8));
            pPredator.Add(GameSystem.SetPosition(2.5, 1.8));
            pPredator.Add(GameSystem.SetPosition(2.7, 2.2));
            pPredator.Add(GameSystem.SetPosition(2.4, 2.6));
            pPredator.Add(GameSystem.SetPosition(2.7, 1.13));
            pPredator.Add(GameSystem.SetPosition(2.12, 0.8));

            pVirus.Add(GameSystem.SetPosition(0.1, 0.1));
            pVirus.Add(GameSystem.SetPosition(0.1, 0.5));
            pVirus.Add(GameSystem.SetPosition(0.1, 2.3));
            pVirus.Add(GameSystem.SetPosition(0.1, 2.7));
            pVirus.Add(GameSystem.SetPosition(2.5, 0.1));
            pVirus.Add(GameSystem.SetPosition(2.8, 0.6));
            pVirus.Add(GameSystem.SetPosition(2.8, 2.8));
            pVirus.Add(GameSystem.SetPosition(2.6, 2.8));
            pVirus.Add(GameSystem.SetPosition(1.3, 2.8));
            pVirus.Add(GameSystem.SetPosition(1.5, 2.8));

            pCompetitor.Add(GameSystem.SetPosition(1.5, 1.5));
            pCompetitor.Add(GameSystem.SetPosition(0.5, 0.5));
            pCompetitor.Add(GameSystem.SetPosition(0.5, 1.5));
            pCompetitor.Add(GameSystem.SetPosition(0.5, 2.5));
            pCompetitor.Add(GameSystem.SetPosition(1.5, 0.5));
            pCompetitor.Add(GameSystem.SetPosition(1.5, 2.5));
            pCompetitor.Add(GameSystem.SetPosition(2.5, 0.5));
            pCompetitor.Add(GameSystem.SetPosition(2.5, 1.5));
            pCompetitor.Add(GameSystem.SetPosition(2.5, 2.5));
        }


        private void SetPlantWallPosition() {
            pPlantWall.Add(GameSystem.SetPosition(0.2, 1.13));
            pPlantWall.Add(GameSystem.SetPosition(0.2, 1.4));
            pPlantWall.Add(GameSystem.SetPosition(0.2, 1.88));
            pPlantWall.Add(GameSystem.SetPosition(0.9, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(0.9, 0.5));
            pPlantWall.Add(GameSystem.SetPosition(0.9, 1.87));
            pPlantWall.Add(GameSystem.SetPosition(1.32, 1.87));
            pPlantWall.Add(GameSystem.SetPosition(1.4, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(1.6, 0.25));
            pPlantWall.Add(GameSystem.SetPosition(1.6, 2.5));
            pPlantWall.Add(GameSystem.SetPosition(1.9, 0.75));
            pPlantWall.Add(GameSystem.SetPosition(1.9, 1.0));
            pPlantWall.Add(GameSystem.SetPosition(1.9, 2.28));
            pPlantWall.Add(GameSystem.SetPosition(2.1, 0.88));
            pPlantWall.Add(GameSystem.SetPosition(2.6, 1.87));
        }

        public override void ShowTip() {
            List<Bitmap> tipImages = new List<Bitmap> {
                Resources.SurvivalIntro, Resources.SurvivalIntro };
            FormTip tip = new FormTip(tipImages);
            tip.ShowDialog();
        }
    }
}
