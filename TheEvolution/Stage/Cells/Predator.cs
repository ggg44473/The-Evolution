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
        private int dirX, dirY;
        private int moveX, moveY;
        private int total;
        private int PredatorX, PredatorY;
        private int MoveInterval;
        private List<Bitmap> imgPredator;
        private List<Bitmap> imgPredatorEat;

        public Predator(Form form) : base(form) {
            GameSystem.otherCells.Add(this);
            imgPredator = ImageContainer.imgPredator;
            imgPredatorEat = ImageContainer.imgPredatorEat;
            images = ImageContainer.imgPredator;
            size = images[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            PredatorX = position.X;
            PredatorY = position.Y;
        }
        //same as virus
        public override void Paint(object sender, PaintEventArgs e) {
            lock (rotation) {
                e.Graphics.Transform = rotation;
                e.Graphics.DrawImage(images[imgIndex],
                    position.X, position.Y, size.Width, size.Height);
                rotation.Reset();
                e.Graphics.Transform = rotation;
            }
        }
        //same as virus
        public override int GetAngle() {
            if (GameSystem.player.Position.Y >= GetCenter().Y) {
                return AngleToPlayer() ;            
            }else  {
                return AngleToPlayer() * (-1) ;
            }
        }
        //same as virus
        public int AngleToPlayer() {
            int dirX = GameSystem.player.GetCenter().X - GetCenter().X;
            int dirY = GameSystem.player.GetCenter().Y - GetCenter().Y;
            double R = Math.Sqrt((dirX * dirX) + (dirY * dirY));
            return (int)(Math.Acos(dirX / R) / Math.PI * 180);
        }

        public void PredatorMove() {
            if (DistanceToPlayer <= 1.8 * size.Width || isAttack) {
                if (DistanceToPlayer <= 3 * size.Width) {
                    if (!isAttack) {
                        isAttack = true;
                        dirX = GameSystem.player.GetCenter().X - GetCenter().X;
                        dirY = GameSystem.player.GetCenter().Y - GetCenter().Y;
                        moveX = dirX / 3;
                        moveY = dirY / 3;
                    }
                    if (total < 3) {
                        position.X += moveX;
                        position.Y += moveY;
                    } else if (total < 6) {
                        position.X -= moveX;
                        position.Y -= moveY;
                    }
                    total++;
                    if (position.X == PredatorX && position.Y == PredatorY) {
                        total = 0;
                        isAttack = false;
                    }
                } else {
                    if (total < 3) {
                        position.X += moveX;
                        position.Y += moveY;
                        total++;
                        if (total == 0) {
                            isAttack = false;
                        }
                    } else if (total > 2 && total < 6) {
                        total++;
                        position.X -= moveX;
                        position.Y -= moveY;
                        if (total == 6) {
                            total = 0;
                            isAttack = false;
                        }
                    }
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

        public void CollideFood() {
            images = imgPredatorEat;
            imgIndex = 0;
        }


        public override void NextStep() {            
            if (MoveInterval == 0) {
                MoveInterval = 1;
                PredatorMove();
                Rotate();
            }
            MoveInterval--;
            if (aniInterval == 0) {
                aniInterval = 5;
                Animate();
            }
            aniInterval--;
        }
    }
}
