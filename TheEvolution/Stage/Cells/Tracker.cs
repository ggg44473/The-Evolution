using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    class Tracker : Cell {

        public Tracker(Form form) : base(form) {
            GameSystem.otherCells.Add(this);
            images = ImageContainer.imgTracker;
            size = images[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            moveSpeed = (int)(0.12 * size.Width);
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
            if (GameSystem.player.Position.Y >= GetCenter().Y) {
                return AngleToPlayer();
            } else {
                return AngleToPlayer() * (-1);
            }
        }

        public int AngleToPlayer() {
            int dirX = GameSystem.player.GetCenter().X - GetCenter().X;
            int dirY = GameSystem.player.GetCenter().Y - GetCenter().Y;
            double R = Math.Sqrt((dirX * dirX) + (dirY * dirY));
            return (int)(Math.Acos(dirX / R) / Math.PI * 180);
        }

        public override void NextStep() {
            Rotate();
            if (aniInterval == 0) {
                aniInterval = 2;
                Animate();
            }
            aniInterval--;
        }
    }
}
