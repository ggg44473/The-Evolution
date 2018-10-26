using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TheEvolution.Properties;
using TheEvolution.Core;

namespace TheEvolution.Stage {
    class Background : Painter {

        int imgIndex;

        public Background(Form form) {
            images = ImageContainer.imgBackground;
            imgIndex = 2;
            size = images[0].Size;
            position.X = 0;
            position.Y = 0;
            form.Paint += new PaintEventHandler(Paint);
        }

        public override void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[imgIndex], position.X, position.Y, size.Width, size.Height);
        }
    }
}
