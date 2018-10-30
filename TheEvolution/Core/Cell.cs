using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TheEvolution.Core {
    abstract class Cell : Painter {

        protected int imgIndex, aniInterval;
        protected int angle;
        protected Matrix rotation;

        // Delete it after completing all derived classes.
        public Cell() { }

        public Cell(Form form) : base(form) {
            rotation = new Matrix();
        }

        public override void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[imgIndex],
                position.X, position.Y, size.Width, size.Height);
        }

        public virtual void Animate() {
            if (imgIndex < images.Count - 1) {
                imgIndex++;
            } else {
                imgIndex = 0;
            }
        }

        public virtual int GetAngle() {
            return angle;
        }

        public virtual void Rotate() {
            lock (rotation) {
                rotation.RotateAt(GetAngle(), GetCenter());
            }
        }
        public virtual int GetArea() {
            return size.Width * size.Height;
        }

        public Point GetDirectionToTarget(Painter target) {
            int vectorX = target.GetCenter().X - GetCenter().X;
            int vectorY = target.GetCenter().Y - GetCenter().Y;
            int unitX = vectorX > 0 ? 1 : vectorX < 0 ? -1 : 0;
            int unitY = vectorY > 0 ? 1 : vectorY < 0 ? -1 : 0;
            return new Point(unitX, unitY);
        }

        public virtual void NextStep() {}
    }
}
