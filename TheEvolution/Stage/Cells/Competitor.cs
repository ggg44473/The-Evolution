using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    class Competitor : Cell, ICollideFood {

        private int hp;
        private int foodCount;
        private int moveSpeed, deceleration;
        private List<Bitmap> imgCompetitor;
        Random random;

        public Competitor(Form form) : base(form) {
            random = new Random(Guid.NewGuid().GetHashCode());
            GameSystem.competitors.Add(this);
            imgCompetitor = ImageContainer.imgCompetitor;
            images = imgCompetitor;
            size = imgCompetitor[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            //GameSystem.SetPainterPosition(this, random.NextDouble(), random.NextDouble());
            moveSpeed = (int)(0.1 * size.Width * 0.6);        //need to set
            hp = 5;
        }

        public override void Animate() {
            if (imgIndex == 0) {
                imgIndex = 1;
            } else {
                imgIndex = 0;
            }
        }

        public void CompetitorMove() {           
            List<double> distances = new List<double>();
            foreach (Food f in GameSystem.foods) {
                distances.Add(Distance(f.Position, position));
            }
            deceleration = deceleration < moveSpeed ? deceleration + 1 : 0;

            double distancePlayer = Distance(GameSystem.currentPlayer.GetCenter(), GetCenter());
            //double Mindistance = Math.Sqrt((_boundary.Width / 2 + playercell.Width / 2) * (_boundary.Width / 2 + playercell.Width / 2) * 0.3 + (_boundary.Height / 2 + playercell.Height / 2) * (_boundary.Height / 2 + playercell.Height / 2) * 0.3);


            position.Y -= moveSpeed - deceleration;
            position.X -= moveSpeed - deceleration;

        }

        public double Distance(Point target, Point self) {
            double dirX = target.X - self.X;
            double dirY = target.Y - self.Y;
            return Math.Sqrt((dirX * dirX) + (dirY * dirY));
        }

        /*
        public void move() {
            List<FoodPoints> foodpoints = new List<FoodPoints>();
            foreach (CellFood f in Foods) {
                FoodPoints xx = new FoodPoints {
                    X = f._boundary.X,
                    Y = f._boundary.Y
                };
                foodpoints.Add(xx);
            }
            List<float> distances = new List<float>();
            foreach (FoodPoints f in foodpoints) {
                distances.Add(Distance(f.X, f.Y, _boundary.X, _boundary.Y));
            }

            int XR = (int)(timer_tick % 6);

            float distancePlayer = Distance((playercell.Left + playercell.Width / 2), (playercell.Top + playercell.Height / 2), _centerX, _centerY);
            float Mindistance = (float)Math.Sqrt((_boundary.Width / 2 + playercell.Width / 2) * (_boundary.Width / 2 + playercell.Width / 2) * 0.3 + (_boundary.Height / 2 + playercell.Height / 2) * (_boundary.Height / 2 + playercell.Height / 2) * 0.3);
            if (distancePlayer <= Mindistance) {
                collecption = true;
                if (collecption) {
                    int dirX = _boundary.X - playercell.X;
                    int dirY = _boundary.Y - playercell.Y;
                    int SX = Math.Abs(dirX); if (SX == 0) { SX = 1; }
                    int SY = Math.Abs(dirY); if (SY == 0) { SY = 1; }
                }
            }
            if (distancePlayer <= 350) {
                int dirX = (playercell.X + playercell.Width / 2) - (_boundary.X + _boundary.Width / 2);
                int dirY = (playercell.Y + playercell.Height / 2) - (_boundary.Y + _boundary.Height / 2);

                int SX = Math.Abs(dirX); if (SX == 0) { SX = 1; }
                int SY = Math.Abs(dirY); if (SY == 0) { SY = 1; }

                if (XR > 8) { XR = 0; } //緩速 
                //面積 >= player追蹤player, else 逃離player
                if (_boundary.Width * _boundary.Height >= Math.Pow(playercell.Width, 2)) {
                    _boundary.X += dirX / SX * (8 - XR);
                    _boundary.Y += dirY / SX * (8 - XR);
                } else if (_boundary.Width * _boundary.Height < Math.Pow(playercell.Width, 2)) {
                    _boundary.X -= dirX / SX * (8 - XR);
                    _boundary.Y -= dirY / SX * (8 - XR);
                }
            } else {
                int MinX = 0;
                float MinValue = distances[0];
                for (int i = 0; i < distances.Count; i++) {

                    if (MinValue > distances[i]) {
                        MinValue = distances[i];
                        MinX = i;
                    }
                }
                int dirXX = foodpoints[MinX].X - _boundary.X;
                int dirYY = foodpoints[MinX].Y - _boundary.Y;
                int SXX = Math.Abs(dirXX); if (SXX == 0) { SXX = 1; }
                int SYY = Math.Abs(dirYY); if (SYY == 0) { SYY = 1; }
                _boundary.X += dirXX / SXX * (8 - XR);
                _boundary.Y += dirYY / SYY * (8 - XR);
            }
        }
        */

        public int Hp {
            get { return hp; }
            set {
                if (value < 0) {
                    hp = 0;
                } else if (value > 10) {
                    hp = 10;
                } else {
                    hp = value;
                }
            }
        }

        public void CollideFood() {
            imgIndex = 0;
            if (Hp < 10) {
                if (foodCount < 4) {
                    foodCount++;
                } else {
                    size.Width += (int)(0.006 * GameSystem.screen.Width);
                    size.Height += (int)(0.01 * GameSystem.screen.Height);
                    Hp += 1;
                    foodCount = 0;
                }
            }
        }
    }
}
