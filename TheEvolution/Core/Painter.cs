using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheEvolution.Core {
    abstract class Painter : IPainting, ICollide {

        protected List<Bitmap> images;
        protected Rectangle frame;

        public virtual List<Bitmap> Images { get => images; set => images = value; }

        public virtual Rectangle Frame { get => frame; set => frame = value; }

        public virtual void Initialize(object sender, EventArgs e) {
            GameSystem.SetFrame(
                this, GameSystem.currentForm.ClientSize, 0.5, 0.5, 0.06, 0.1);
        }

        public virtual void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[0], frame);
        }

        public virtual Point GetCenter() {
            return new Point(
                x: Frame.Left + (Frame.Width / 2),
                y: Frame.Top + (Frame.Height / 2));
        }

        public virtual Size GetSize() {
            return new Size(frame.Width, frame.Height);
        }

        public virtual void Collide() { }
    }
}
