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
            imgIndex = 0;
            size = images[0].Size;
            position.X = 0;
            position.Y = 0;
        }
    }
}
