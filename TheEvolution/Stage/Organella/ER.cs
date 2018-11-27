using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;
using System.Drawing;

namespace TheEvolution.Stage.Organella {
    class ER : Organelle {

        public ER(PictureBox picBoxBg, Point point) : base(picBoxBg, point){
            images = ImageContainer.imgER;
            size = images[0].Size;
        }

        public override void Collide(int myId) {
            base.Collide(myId);
            switch (FormStage.chapter) {
                case EChapter.Tutorial:
                    GameSystem.formStage.chapterTutorial.ShowCentromere();
                    break;
                case EChapter.Survival:
                    GameSystem.formStage.chapterSurvival.ShowCentromere();
                    break;
            }
        }
    }
}
