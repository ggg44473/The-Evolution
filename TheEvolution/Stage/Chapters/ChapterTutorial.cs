using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using TheEvolution.Core;
using System.Windows.Forms;
using TheEvolution.Properties;

namespace TheEvolution.Stage.Chapters {
    public class ChapterTutorial : Chapter {

        public ChapterTutorial(PictureBox picBoxStage) : base(picBoxStage) {
        }

        protected override void GetReady() {
            SetBorderPosition();

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

        public override void ShowTip() {
            List<Bitmap> tipImages = new List<Bitmap> {
                Resources.Tips2, Resources.Tips1 };
            FormTip tip = new FormTip(tipImages);
            tip.ShowDialog();
        }
    }
}
