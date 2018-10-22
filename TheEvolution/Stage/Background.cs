using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TheEvolution.Properties;
using TheEvolution.Core;

namespace TheEvolution.Stage {
    class Background {

        Size imgSize;
        List<Bitmap> images;
        int imgIndex;

        public Background(Form form) {
            images = new List<Bitmap>();
            imgIndex = 0;
            form.Load += new EventHandler(Initialize);
            form.Paint += new PaintEventHandler(Paint);
        }

        public void Initialize(object sender, EventArgs e) {
            imgSize = GameSystem.currentForm.ClientSize;
            images.Add(new Bitmap(Resources.bg1, imgSize));
            images.Add(new Bitmap(Resources.bg2, imgSize));
            images.Add(new Bitmap(Resources.bg3, imgSize));
        }
        public void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[imgIndex], 0, 0, imgSize.Width, imgSize.Height);
        }
    }
}
