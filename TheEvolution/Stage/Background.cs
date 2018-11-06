using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage {
    class Background : Painter {

        public Background(PictureBox picBoxBg) : base(picBoxBg) {
            images = ImageContainer.imgBackground;
            imgIndex = 2;
            size = images[2].Size;
            position.X = 0;
            position.Y = 0;
        }

        public void ChangeBackground(int index) {
            if (index < images.Count) {
                imgIndex = index;
            }
        }
    }
}
