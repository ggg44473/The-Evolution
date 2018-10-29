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

        public virtual void Animate() { }

        public virtual void Move() { }

        public virtual int GetAngle() { return angle; }

        public virtual void Rotate() {
            lock (rotation) {
                rotation.RotateAt(GetAngle(), GetCenter());
            }
        }
    }
}
