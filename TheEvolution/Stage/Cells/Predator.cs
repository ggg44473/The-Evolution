using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    class Predator : Cell {

        private bool isAttack;
        private int dirX, dirY, stepTotal, stepX, stepY;
        private Point originalPosition;
        private List<Bitmap> imgPredator;
        private List<Bitmap> imgPredatorEat;

        public Predator(Form form) : base(form) {
            GameSystem.otherCells.Add(this);
            imgPredator = ImageContainer.imgPredator;
            imgPredatorEat = ImageContainer.imgPredatorEat;
            images = ImageContainer.imgPredator;
            size = images[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            originalPosition = position;
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
            dirX = GameSystem.player.GetCenter().X - GetCenter().X;
            dirY = GameSystem.player.GetCenter().Y - GetCenter().Y;
            double R = Math.Sqrt((dirX * dirX) + (dirY * dirY));
            return (int)(Math.Acos(dirX / R) / Math.PI * 180);
        }

        public void PredatorMove() {
            if (DistanceToPlayer <= 1.8 * size.Width || isAttack) {
                if (!isAttack) {
                    isAttack = true;
                    dirX = GameSystem.player.GetCenter().X - GetCenter().X;
                    dirY = GameSystem.player.GetCenter().Y - GetCenter().Y;
                    stepX = dirX / 4;
                    stepY = dirY / 4;
                }
                if (stepTotal < 4) {
                    position.X += stepX;
                    position.Y += stepY;
                } else if (stepTotal < 8) {
                    position.X -= stepX;
                    position.Y -= stepY;
                }
                stepTotal++;
                if (position.X == originalPosition.X && position.Y == originalPosition.Y) {
                    stepTotal = 0;
                    isAttack = false;
                }
            }
        }

        public override void Animate() {
            if (imgIndex < images.Count - 1) {
                imgIndex++;
            } else {
                imgIndex = 0;
                if (images == imgPredatorEat) {
                    images = imgPredator;
                }
            }
        }

        public override void NextStep() {
            PredatorMove();
            Rotate();
            if (aniInterval == 0) {
                aniInterval = 5;
                Animate();
            }
            aniInterval--;
        }
    }
}
