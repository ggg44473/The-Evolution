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
    partial class Player : Cell, ICollideFood {

        private bool isUp, isDown, isLeft, isRight;
        private int originalSpeed, deceleration, moveAmount;
        private List<Bitmap> imgPlayer;
        private List<Bitmap> imgPlayerEat;
        private List<Bitmap> imgPlayerSick;
        private List<Bitmap> imgPlayerSickEat;
        private List<Bitmap> imgPlayerShocked;
        private List<Bitmap> imgPlayerMito;
        private List<Bitmap> imgPlayerMitoLyso;
        private List<Bitmap> imgPlayerMitoLysoER;
        private List<Bitmap> imgPlayerComplete;
        private int hp;
        private int foodCount;
        private bool isHidden;
        private int hiddenInterval;
        private bool isSick, isShocked;
        private int sickInterval, shockInterval;
        public event EventHandler<PlayerEventArgs> HpChanged;
        public event EventHandler<PlayerEventArgs> Eat;

        public Player(PictureBox picBoxBg, Point point) : base(picBoxBg, point) {
            GameSystem.player = this;
            imgPlayer = ImageContainer.imgPlayer;
            imgPlayerEat = ImageContainer.imgPlayerEat;
            imgPlayerSick = ImageContainer.imgPlayerSick;
            imgPlayerSickEat = ImageContainer.imgPlayerSickEat;
            imgPlayerShocked = ImageContainer.imgPlayerShocked;
            imgPlayerMito = ImageContainer.imgPlayerMito;
            imgPlayerMitoLyso = ImageContainer.imgPlayerMitoLyso;
            imgPlayerMitoLysoER = ImageContainer.imgPlayerMitoLysoER;
            imgPlayerComplete = ImageContainer.imgPlayerComplete;
            images = imgPlayer;
            size = imgPlayer[0].Size;
            moveSpeed = (int)(0.18 * size.Width);
            originalSpeed = moveSpeed;
            GameSystem.formStage.KeyDown += PlayerKeyDown;
            GameSystem.formStage.KeyUp += PlayerKeyUp;
            hp = 5;
        }

        public override void Dispose() {
            GameSystem.formStage.picBoxStage.Paint -= Paint;
            GameSystem.formStage.KeyDown -= PlayerKeyDown;
            GameSystem.formStage.KeyUp -= PlayerKeyUp;
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
            moveAmount = moveSpeed - deceleration;
            if (isUp) {
                position.Y -= moveAmount;
                CheckTopBorderTouched();
            }
            if (isDown) {
                position.Y += moveAmount;
                CheckBottomBorderTouched();
            }
            if (isLeft) {
                position.X -= moveAmount;
                CheckLeftBorderTouched();
            }
            if (isRight) {
                position.X += moveAmount;
                CheckRightBorderTouched();
            }
        }

        public void CheckTopBorderTouched() {
            int height = GameSystem.screen.Height;
            if (position.Y < height && GameSystem.picBoxStage.Top == -height) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.picBoxStage.Top = 0;
                });
            }
            if (position.Y < 2 * height && GameSystem.picBoxStage.Top == -2*height) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.picBoxStage.Top = -height;
                });
            }
        }

        public void CheckBottomBorderTouched() {
            int height = GameSystem.screen.Height;
            if (position.Y > 2 * height && GameSystem.picBoxStage.Top == -height) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.picBoxStage.Top = -2 * height;
                });
            }
            if (position.Y > height && GameSystem.picBoxStage.Top == 0) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.picBoxStage.Top = -height;
                });
            }
        }

        public void CheckLeftBorderTouched() {
            int width = GameSystem.screen.Width;
            if (position.X < width && GameSystem.picBoxStage.Left == -width) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.picBoxStage.Left = 0;
                });
            }
            if (position.X < 2 * width && GameSystem.picBoxStage.Left == - 2* width) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.picBoxStage.Left = -width;
                });
            }
        }

        public void CheckRightBorderTouched() {
            int width = GameSystem.screen.Width;
            if (position.X > 2 * width && GameSystem.picBoxStage.Left == -width) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.picBoxStage.Left = -2 * width;
                });
            }
            if (position.X > width && GameSystem.picBoxStage.Left == 0) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.picBoxStage.Left = -width;
                });
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
                    HpChanged(this, new PlayerEventArgs(hp));
                }
            }
        }

        public override void NextStep() {
            PlayerMove();
            Rotate();
            if (aniInterval == 0) {
                aniInterval = 3;
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

    public class PlayerEventArgs : EventArgs {

        public int hp;
        public int foodCount;

        public PlayerEventArgs(int hp) {
            this.hp = hp;
        }

        public PlayerEventArgs(int foodCount, int hp) {
            this.foodCount = foodCount;
            this.hp = hp;
        }
    }
}
