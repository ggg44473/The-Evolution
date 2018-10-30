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

        private int moveSpeed, deceleration, moveInterval;
        private int hp;
        private Random random;
        private double distanceToPlayer;
        private Point direction;
        private int foodCount;

        public Competitor(Form form) : base(form) {
            GameSystem.competitors.Add(this);
            images = ImageContainer.imgCompetitor;
            size = images[0].Size;
            random = new Random(Guid.NewGuid().GetHashCode());
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            moveSpeed = (int)(0.05 * size.Width);
            direction = new Point();
            hp = 5;
        }

        public void CompetitorMove() {
            deceleration = deceleration < moveSpeed ? deceleration + 1 : 0;
            GetDistanceToPlayer();
            if (distanceToPlayer < 3 * size.Width) {
                if (GetArea() > GameSystem.player.GetArea()) {
                    direction = GetDirectionToTarget(GameSystem.player);
                } else {
                    direction = GetDirectionToTarget(GameSystem.player);
                    direction = new Point(direction.X * (-1), direction.Y * (-1));
                }
            } else {
                direction = GetDirectionToTarget(GameSystem.foods[GetClosestFood()]);
            }
            position.X += direction.X * (moveSpeed - deceleration);
            position.Y += direction.Y * (moveSpeed - deceleration);
        }

        public int GetClosestFood() {
            int index;
            double min;
            double distance;
            index = 0;
            min = GameSystem.getDistance(
                    GameSystem.foods[0].GetCenter(), GetCenter());
            for (int i = 1; i < GameSystem.foods.Count; i++) {
                distance = GameSystem.getDistance(
                    GameSystem.foods[i].GetCenter(), GetCenter());
                if (distance < min) {
                    index = i;
                }
            }
            return index;
        }

        public void GetDistanceToPlayer() {
            distanceToPlayer = GameSystem.getDistance(
                GameSystem.player.GetCenter(), GetCenter());
        }

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

        public override void NextStep() {
            if (moveInterval == 0) {
                moveInterval = 2;
                CompetitorMove();
            }
            moveInterval--;
            if (aniInterval == 0) {
                aniInterval = 4;
                Animate();
            }
            aniInterval--;
        }

        public void CollideFood() {
            imgIndex = 0;
            if (foodCount < 4) {
                foodCount++;
            } else {
                foodCount = 0;
                if (Hp < 10) {
                    size.Width += (int)(0.02 * GameSystem.screen.Width);
                    size.Height += (int)(0.02 * GameSystem.screen.Height);
                    Hp += 1;
                }
            }
        }

        public void CollidePlayer() {
            if (Hp > 1) {
                size.Width -= (int)(0.02 * GameSystem.screen.Width);
                size.Height -= (int)(0.02 * GameSystem.screen.Height);
            }
            Hp -= 1;
        }
    }
}
