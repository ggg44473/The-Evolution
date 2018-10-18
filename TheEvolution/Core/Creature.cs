using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TheEvolution.Core {
    abstract class Creature : IPainting {
        protected List<Bitmap> images;
        protected Rectangle frame;
        protected Matrix rotation;

        public List<Bitmap> Images { get => images; set => images = value; }

        public Rectangle Frame { get => frame; set => frame = value; }

        public Creature() {
            images = new List<Bitmap>();
            frame = new Rectangle();
            rotation = new Matrix();
        }

        virtual public Point getCenter() {
            return new Point(
                x: Frame.Left + (Frame.Width / 2),
                y: Frame.Top + (Frame.Height / 2));
        }

        virtual public void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[0], frame);
        }
    }
}
