﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TheEvolution.Properties;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    partial class Player : Cell, ICollideFood {

        private bool isUp, isDown, isLeft, isRight;
        private int originalSpeed, deceleration;
        private List<Bitmap> imgPlayer;
        private List<Bitmap> imgPlayerEat;
        private List<Bitmap> imgPlayerSick;
        private List<Bitmap> imgPlayerSickEat;
        private List<Bitmap> imgPlayerShocked;
        private int hp;
        private int foodCount;
        private bool isHidden;
        private int hiddenInterval;
        private bool isSick, isShocked;
        private int sickInterval, shockInterval;

        public Player(Form form, Point point) : base(form, point) {
            GameSystem.player = this;
            imgPlayer = ImageContainer.imgPlayer;
            imgPlayerEat = ImageContainer.imgPlayerEat;
            imgPlayerSick = ImageContainer.imgPlayerSick;
            imgPlayerSickEat = ImageContainer.imgPlayerSickEat;
            imgPlayerShocked = ImageContainer.imgPlayerShocked;
            images = imgPlayer;
            size = imgPlayer[0].Size;
            moveSpeed = (int)(0.15 * size.Width);
            originalSpeed = moveSpeed;
            form.KeyDown += PlayerKeyDown;
            form.KeyUp += PlayerKeyUp;
            hp = 5;
        }

        public override void Dispose() {
            GameSystem.form.Paint -= Paint;
            GameSystem.form.KeyDown -= PlayerKeyDown;
            GameSystem.form.KeyUp -= PlayerKeyUp;
            GameSystem.player = null;
        }

        public override void Paint(object sender, PaintEventArgs e) {
            lock (rotation) {
                e.Graphics.Transform = rotation;
                if (!isHidden) {
                    e.Graphics.DrawImage(images[imgIndex],
                        position.X, position.Y, size.Width, size.Height);
                } else {
                    if (hiddenInterval < 3) {
                        e.Graphics.DrawImage(images[imgIndex],
                            position.X, position.Y, size.Width, size.Height);
                    }
                }
                rotation.Reset();
                e.Graphics.Transform = rotation;
            }
        }

        public override void Animate() {
            if (imgIndex < images.Count - 1) {
                imgIndex++;
            } else {
                imgIndex = 0;
                if (!isSick) {
                    if (images == imgPlayerEat) {
                        images = imgPlayer;
                    }
                } else {
                    if (images == imgPlayerSickEat) {
                        images = imgPlayerSick;
                    }
                }
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

        public int Hp {
            get { return hp; }
            set {
                if (value < 0) {
                    hp = 0;
                } else if (value > 10) {
                    hp = 10;
                } else {
                    if (value > hp) {
                        size.Width += (int)(0.012 * GameSystem.screen.Width);
                        size.Height += (int)(0.02 * GameSystem.screen.Height);
                    } else {
                        size.Width -= (int)(0.012 * GameSystem.screen.Width);
                        size.Height -= (int)(0.02 * GameSystem.screen.Height);
                    }
                    hp = value;
                }
            }
        }

        public override void NextStep() {
            PlayerMove();
            Rotate();
            if (aniInterval == 0) {
                aniInterval = 2;
                Animate();
            }
            aniInterval--;
            if (isHidden) {
                if (hiddenInterval == 0) {
                    hiddenInterval = 17;
                }
                hiddenInterval--;
            }
            if (isSick) {
                sickInterval--;
                if (sickInterval == 0) {
                    Hp -= 1;
                    images = imgPlayer;
                    isSick = false;
                }
            }
            if (isShocked) {
                shockInterval--;
                if (shockInterval == 0) {
                    if (!isSick) {
                        images = imgPlayer;
                    } else {
                        images = imgPlayerSick;
                    }
                    isShocked = false;
                    moveSpeed = originalSpeed;
                }
            }
        }
    }
}
