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
    partial class Player : Cell {

        private bool isUp, isDown, isLeft, isRight;
        private int moveSpeed, deceleration, moveInterval;
        private List<Bitmap> imgPlayer;
        private List<Bitmap> imgPlayer2;
        private List<Bitmap> imgPlayerEat;

        public Player(Form form) :base(form) {
            GameSystem.currentPlayer = this;
            imgPlayer = ImageContainer.imgPlayer;
            imgPlayer2 = ImageContainer.imgPlayer2;
            imgPlayerEat = ImageContainer.imgPlayerEat;
            images = imgPlayer;
            size = imgPlayer[0].Size;
            GameSystem.SetPainterPosition(this, 0.5, 0.5);
            moveSpeed = (int)(0.1 * size.Width);
            form.KeyDown += new KeyEventHandler(PlayerKeyDown);
            form.KeyUp += new KeyEventHandler(PlayerKeyUp);
        }

        public override void Paint(object sender, PaintEventArgs e) {
            lock (rotation) {
                e.Graphics.Transform = rotation;
                e.Graphics.DrawImage(images[currentImgIndex],
                    position.X, position.Y, size.Width, size.Height);
                rotation.Reset();
                e.Graphics.Transform = rotation;
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
                if (90 <= angle && angle <= 270) {
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
            deceleration = deceleration < moveSpeed ? deceleration + 1 : 0;
            if (isUp) {
                position.Y -= moveSpeed - deceleration;
            }
            if (isDown) {
                position.Y += moveSpeed - deceleration;
            }
            if (isLeft) {
                position.X -= moveSpeed - deceleration;
            }
            if (isRight) {
                position.X += moveSpeed - deceleration;
            }
        }

        public void NextStep() {
            if (moveInterval == 0) {
                moveInterval = 1;
                Rotate();
                PlayerMove();
            }
            moveInterval--;
            if (aniInterval == 0) {
                aniInterval = 2;
                Animate();
            }
            aniInterval--;
        }
    }
}
