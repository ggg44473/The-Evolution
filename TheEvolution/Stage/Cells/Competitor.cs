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

        private int deceleration, moveInterval;
        private int hp;
        private int foodCount;
        public event EventHandler Killed;

        public Competitor(PictureBox picBoxBg, Point point) : base(picBoxBg, point) {
            GameSystem.competitors.Add(this);
            Killed += GameSystem.player.KillCompetitor;
            images = ImageContainer.imgCompetitor;
            size = images[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            moveSpeed = (int)(0.1 * size.Width);
            hp = 5;
        }
        
        public void CompetitorMove() {
            deceleration = deceleration < moveSpeed ? deceleration + 1 : 0;
            if (DistanceToPlayer < 2.5 * size.Width) {
                if (GetArea() > GameSystem.player.GetArea()) {
                    direction = GetUnitDirectionToTarget(GameSystem.player);
                } else {
                    direction = GetUnitDirectionToTarget(GameSystem.player);
                    direction.X -= 2 * direction.X;
                    direction.Y -= 2 * direction.Y;
                }
            } else {
                direction = GetUnitDirectionToTarget(GameSystem.foods[GetClosestFood()]);
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

        public void CollidePlayer(int myId) {
            if (Hp > 1) {
                size.Width -= (int)(0.02 * GameSystem.screen.Width);
                size.Height -= (int)(0.02 * GameSystem.screen.Height);
            }
            Hp -= 1;
            if (Hp == 0) {
                OnKilled();
                GameSystem.competitors.RemoveAt(myId);
                Dispose();
            }
            BumpMove();
        }

        public void BumpMove() {
            direction = GetDirectionToTarget(GameSystem.player);
            direction.X -= 2 * direction.X;
            direction.Y -= 2 * direction.Y;

            position.X += (int)(direction.X * 1.3);
            position.Y += (int)(direction.Y * 1.3);
        }

        protected virtual void OnKilled() {
            Killed?.Invoke(this, EventArgs.Empty);
        }
    }
}
