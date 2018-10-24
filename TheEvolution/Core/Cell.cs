using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TheEvolution.Core {
    abstract class Cell : Painter {

        protected int currentImgIndex, aniInterval;
        protected int angle;
        protected Matrix rotation;

        public Cell() {
            images = new List<Bitmap>();
            frame = new Rectangle();
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
