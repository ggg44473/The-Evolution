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
        private bool isCollided;
        private int bumpInterval;
        public event EventHandler Killed;

        public Competitor(Form form) : base(form) {
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
                    direction = GetDirectionToTarget(GameSystem.player);
                } else {
                    direction = GetDirectionToTarget(GameSystem.player);
                    direction.X -= 2 * direction.X;
                    direction.Y -= 2 * direction.Y;
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
            if (isCollided) {
                if (bumpInterval == 0 || bumpInterval == 3) {
                    BumpMove();
                } else if (bumpInterval == 4) {
                    isCollided = false;
                    bumpInterval = 0;
                }
                bumpInterval++;
            }
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
            isCollided = true;
            if (Hp > 1) {
                size.Width -= (int)(0.02 * GameSystem.screen.Width);
                size.Height -= (int)(0.02 * GameSystem.screen.Height);
            }
            Hp -= 1;
            if (Hp == 0) {
                OnKilled();
                GameSystem.deadCompetitors.Add(this);
                GameSystem.competitors.RemoveAt(myId);
                GameSystem.form.Paint -= Paint;
            }
        }

        public void BumpMove() {
            direction = GetDirectionToTarget(GameSystem.player);
            direction.X -= 2 * direction.X;
            direction.Y -= 2 * direction.Y;

            position.X += direction.X * size.Width/2;
            position.Y += direction.Y * size.Height/2;
        }

        protected virtual void OnKilled() {
            Killed?.Invoke(this, EventArgs.Empty);
        }
    }
}
