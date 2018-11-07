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
            background.ChangeBackground(0);
        }

        protected override void GetReady() {
            SetBorderPosition();
            SetPlantWallPosition();

            pPredator.Add(GameSystem.SetPosition(1.1, 1.1));
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
