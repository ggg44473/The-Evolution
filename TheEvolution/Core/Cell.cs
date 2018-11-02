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

        protected int aniInterval;
        protected int angle;
        protected Matrix rotation;
        protected Random random;
        protected int moveSpeed;
        protected Point direction;

        public Cell(Form form) : base(form) {
            rotation = new Matrix();
            random = new Random(Guid.NewGuid().GetHashCode());
            direction = new Point();
        }

        public override void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[imgIndex],
                position.X, position.Y, size.Width, size.Height);
        }

        public virtual void Collide(int myId) {}

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

        public double DistanceToPlayer {
            get {
                return GameSystem.getDistance(
                    GameSystem.player.GetCenter(), GetCenter());
            }
        }

        public Point GetUnitDirectionToTarget(Painter target) {
            int vectorX = target.GetCenter().X - GetCenter().X;
            int vectorY = target.GetCenter().Y - GetCenter().Y;
            int unitX = vectorX > 0 ? 1 : vectorX < 0 ? -1 : 0;
            int unitY = vectorY > 0 ? 1 : vectorY < 0 ? -1 : 0;
            return new Point(unitX, unitY);
        }

        public Point GetDirectionToTarget(Painter target) {
            int vectorX = target.GetCenter().X - GetCenter().X;
            int vectorY = target.GetCenter().Y - GetCenter().Y;
            return new Point(vectorX, vectorY);
        }

        public virtual void NextStep() { }
    }
}
