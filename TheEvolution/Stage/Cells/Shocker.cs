using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    class Shocker : Cell {

        public Shocker(PictureBox picBoxBg, Point point) : base(picBoxBg, point) {
            GameSystem.otherCells.Add(this);
            images = ImageContainer.imgShocker;
            size = images[0].Size;
        }

        public override void Paint(object sender, PaintEventArgs e) {
            lock (rotation) {
                e.Graphics.Transform = rotation;
                e.Graphics.DrawImage(images[imgIndex],
                    position.X, position.Y, size.Width, size.Height);
                rotation.Reset();
                e.Graphics.Transform = rotation;
            }
        }

        public override int GetAngle() {
            angle += 5;
            return angle;
        }

        public override void NextStep() {
            Rotate();
            if (aniInterval == 0) {
                aniInterval = 15;
                Animate();
            }
            aniInterval--;
        }
    }
}
