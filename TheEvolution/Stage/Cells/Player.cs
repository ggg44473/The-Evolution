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
    class Player : Cell {

        private bool isUp, isDown, isLeft, isRight;
        private int moveSpeed, deceleration, moveInterval;
        private List<Bitmap> imgPlayer;
        private List<Bitmap> imgEat;
        private List<Bitmap> imgPlayer2;
        //private List<Bitmap> imgEat2;

        public Player(Form form) {
            GameSystem.currentPlayer = this;
            form.Load += new EventHandler(Initialize);
            form.Paint += new PaintEventHandler(Paint);
            form.KeyDown += new KeyEventHandler(PlayerKeyDown);
            form.KeyUp += new KeyEventHandler(PlayerKeyUp);
        }

        public void Initialize(object sender, EventArgs e) {
            GameSystem.SetSquareFrame(
                this, GameSystem.currentForm.ClientSize, 0.5, 0.5, 0.06);

            moveSpeed = (int)(0.1 * frame.Width);

            Size imgSize = frame.Size;
            imgPlayer = new List<Bitmap>() {
                new Bitmap(Resources.P1, imgSize), new Bitmap(Resources.P2,imgSize),
                new Bitmap(Resources.P3, imgSize), new Bitmap(Resources.P4, imgSize),
                new Bitmap(Resources.P5, imgSize)};
            imgEat = new List<Bitmap>() {
                new Bitmap(Resources.PlayerCellEat1, imgSize), new Bitmap(Resources.PlayerCellEat2,imgSize),
                new Bitmap(Resources.PlayerCellEat3, imgSize), new Bitmap(Resources.PlayerCellEat4, imgSize),
                new Bitmap(Resources.PlayerCellEat5, imgSize)};
            imgPlayer2 = new List<Bitmap>() {
                new Bitmap(Resources.OP1, imgSize), new Bitmap(Resources.OP2,imgSize),
                new Bitmap(Resources.OP3, imgSize), new Bitmap(Resources.OP4, imgSize),
                new Bitmap(Resources.OP5, imgSize)};
            //imgEat2 = new List<Bitmap>() {
            //    new Bitmap(Resources.OPlayerCellEat2, imgSize), new Bitmap(Resources.OPlayerCellEat2,imgSize),
            //    new Bitmap(Resources.OPlayerCellEat3, imgSize), new Bitmap(Resources.OPlayerCellEat4, imgSize),
            //    new Bitmap(Resources.OPlayerCellEat5, imgSize)};
            images = imgPlayer;
        }

        public override void Paint(object sender, PaintEventArgs e) {
            lock (rotation) {
                e.Graphics.Transform = rotation;
                e.Graphics.DrawImage(images[currentImgIndex], frame);
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
                frame.Y -= moveSpeed - deceleration;
            }
            if (isDown) {
                frame.Y += moveSpeed - deceleration;
            }
            if (isLeft) {
                frame.X -= moveSpeed - deceleration;
            }
            if (isRight) {
                frame.X += moveSpeed - deceleration;
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
