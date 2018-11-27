using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;
using System.Drawing;

namespace TheEvolution.Stage.Organella {
    class Mitochondria : Organelle {

        public Mitochondria(PictureBox picBoxBg, Point point) : base(picBoxBg, point) {
            images = ImageContainer.imgMitochondria;
            size = images[0].Size;
        }

        public override void Collide(int myId) {
            base.Collide(myId);
            switch (FormStage.chapter) {
                case EChapter.Tutorial:
                    GameSystem.formStage.chapterTutorial.ShowLysosome();
                    break;
                case EChapter.Survival:
                    GameSystem.formStage.chapterSurvival.ShowLysosome();
                    break;
            }
        }
    }
}
