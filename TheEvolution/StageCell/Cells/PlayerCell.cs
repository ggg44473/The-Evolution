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
        private int currentImgIndex;
        private int speed, deceleration;

        public PlayerCell(Form form) {
            GameSystem.currentPlayer = this;
            Images.Add(new Bitmap(Resources.P1));
            Images.Add(new Bitmap(Resources.P2));
            Images.Add(new Bitmap(Resources.P3));
            Images.Add(new Bitmap(Resources.P4));
            Images.Add(new Bitmap(Resources.P5));
            form.Load += new EventHandler(initialize);
            form.Paint += new PaintEventHandler(Paint);
            form.KeyDown += new KeyEventHandler(PlayerKeyDown);
            form.KeyUp += new KeyEventHandler(PlayerKeyUp);
        }

        public void initialize(object sender, EventArgs e) {
            GameSystem.setFrame(
                this, GameSystem.currentForm.ClientSize, 0.5, 0.5, 0.08, 0.15);
            speed = (int)(0.1 * frame.Height);
        }

        public override void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[currentImgIndex], frame);
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
            deceleration = 0;
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
            deceleration = deceleration <= speed ?
                deceleration + 1 : 0;
            if (isUp) {
                frame.Y -= speed - deceleration;
            }
            if (isDown) {
                frame.Y += speed - deceleration;
            }
            if (isLeft) {
                frame.X -= speed - deceleration;
            }
            if (isRight) {
                frame.X += speed - deceleration;
            }
        }

        public override void Animate() {
            //Make sure index won't be out of the range after plus.
            if (currentImgIndex < images.Count - 1) {
                currentImgIndex++;
            } else {
                currentImgIndex = 0;
            }
        }

        public void NextStep() {
            PlayerMove();
            Animate();
            GameSystem.currentForm.Invalidate();
        }
    }
}
