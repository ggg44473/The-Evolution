using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TheEvolution.Properties;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
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
            form.Load += new EventHandler(Initialize);
            form.Paint += new PaintEventHandler(Paint);
            form.KeyDown += new KeyEventHandler(PlayerKeyDown);
            form.KeyUp += new KeyEventHandler(PlayerKeyUp);
        }

        public void Initialize(object sender, EventArgs e) {
            GameSystem.SetFrame(
                this, GameSystem.currentForm.ClientSize, 0.5, 0.5, 0.08, 0.15);
            speed = (int)(0.12 * frame.Height);
        }

        public override void Paint(object sender, PaintEventArgs e) {
            e.Graphics.Transform = rotation;
            e.Graphics.DrawImage(images[currentImgIndex], frame);
            rotation.Reset();
            e.Graphics.Transform = rotation;
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

        public override int GetAngle() {
            int speed = 10;
            angle = (angle + 360) % 360;

            if (isUp) {
                if(90<= angle && angle <=270) {
                    angle += speed;
                } else {
                    angle -= speed;
                }
            }
            if (isDown) {
                if (90 <= angle && angle <= 270) {
                    angle -= speed;
                } else {
                    angle += speed;
                }
            }
            if (isLeft) {
                if (0 <= angle && angle <= 180) {
                    angle += speed;
                } else {
                    angle -= speed;
                }
            }
            if (isRight) {
                if (0 <= angle && angle <= 180) {
                    angle -= speed;
                } else {
                    angle += speed;
                }
            }

            return angle;
        }

        public void Rotate() {
            rotation.RotateAt(GetAngle(), GetCenter());
        }

        public void NextStep() {
            Rotate();
            PlayerMove();
            Animate();
            GameSystem.currentForm.Invalidate();
        }
    }
}
