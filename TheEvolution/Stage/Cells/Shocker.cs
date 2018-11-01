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
        private int Angle;
        private int ShockerInterval;

        public Shocker(Form form) : base(form) {
            GameSystem.otherCells.Add(this);
            images = ImageContainer.imgShocker;
            size = images[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
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
            Angle += 10;
            return Angle;
        }

        public override void Animate() {
            if (imgIndex < images.Count - 1) {
                imgIndex++;
            } else {
                imgIndex = 0;
            }
        }

        public override void NextStep() {
            Rotate();
            ShockerInterval--;
            if (aniInterval == 0) {
                aniInterval = 4;
                Animate();
            }
            aniInterval--;
        }
    }
}
