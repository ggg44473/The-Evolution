using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TheEvolution.Core {
    abstract class Cell : IPainting {

        protected List<Bitmap> images;
        protected Rectangle frame;
        protected int angle;
        protected Matrix rotation;

        public List<Bitmap> Images { get => images; set => images = value; }

        public Rectangle Frame { get => frame; set => frame = value; }

        public Cell() {
            images = new List<Bitmap>();
            frame = new Rectangle();
            rotation = new Matrix();
        }

        virtual public Point GetCenter() {
            return new Point(
                x: Frame.Left + (Frame.Width / 2),
                y: Frame.Top + (Frame.Height / 2));
        }

        virtual public int GetAngle() { return angle; }

        virtual public void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[0], frame);
        }

        virtual public void Move() { }

        virtual public void Animate() { }
    }
}
