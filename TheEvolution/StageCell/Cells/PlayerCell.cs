using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TheEvolution.Properties;
using TheEvolution.Core;

namespace TheEvolution.StageCell.Cells {
    class PlayerCell : Cell {
        private bool isUp, isDown, isLeft, isRight;
        private int currentImage;

        public PlayerCell() {
            Images.Add(new Bitmap(Resources.P1));
            Images.Add(new Bitmap(Resources.P2));
            Images.Add(new Bitmap(Resources.P3));
            Images.Add(new Bitmap(Resources.P4));
            Images.Add(new Bitmap(Resources.P5));
        }

        public void PlayerKeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Up:
                    isUp = true;
                    break;
                case Keys.Down:
                    isDown = true;
                    break;
                case Keys.Left:
                    isLeft = true;
                    break;
                case Keys.Right:
                    isRight = true;
                    break;
                default:
                    break;
            }
        }

        public void PlayerKeyUp(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Up:
                    isUp = false;
                    break;
                case Keys.Down:
                    isDown = false;
                    break;
                case Keys.Left:
                    isLeft = false;
                    break;
                case Keys.Right:
                    isRight = false;
                    break;
                default:
                    break;
            }
        }

        public void PlayerMove() {
            int speed = (int)(0.1 * (double)frame.Height);
            int adapter = GameSystem.gameTime % speed;
            if (isUp) {
                frame.Y -= speed - adapter;
            }
            if (isDown) {
                frame.Y += speed - adapter;
            }
            if (isLeft) {
                frame.X -= speed - adapter;
            }
            if (isRight) {
                frame.X += speed - adapter;
            }
            GameSystem.currentForm.Invalidate();
        }

        public override void Animate() {
            currentImage = GameSystem.gameTime % images.Count;
        }

        public override void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[currentImage], frame);
        }

        public void NextStep(object sender, EventArgs e) {
            PlayerMove();
            Animate();
        }
    }
}
