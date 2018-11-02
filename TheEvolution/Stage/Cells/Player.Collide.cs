using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    partial class Player {

        public void CollideFood() {
            images = imgPlayerEat;
            imgIndex = 0;
            if (foodCount < 4) {
                foodCount++;
            } else {
                foodCount = 0;
                if (Hp < 10) {
                    size.Width += (int)(0.012 * GameSystem.screen.Width);
                    size.Height += (int)(0.02 * GameSystem.screen.Height);
                    Hp += 1;
                }
            }
        }

        public void CollideCompetitor(Competitor competitor) {
            BumpMove(competitor);
            if (Hp > 1) {
                size.Width -= (int)(0.012 * GameSystem.screen.Width);
                size.Height -= (int)(0.02 * GameSystem.screen.Height);
            }
            Hp -= 1;
        }

        public virtual void KillCompetitor(object sender, EventArgs e) {
            for (int i = 0; i < 25; i++) {
                CollideFood();
            }
        }

        public void CollideVirus() {
            Hp -= 1;
        }

        public void CollidePredator(Cell Predator) {
            Hp -= 1;
            BumpMove(Predator);
        }

        public void CollideShocker(Cell shocker) {
            BumpMove(shocker);
            //TODO make player frozen.
        }

        public void CollideTracker(Cell tracker) {
            //BumpMove(tracker);
            if (!isHidden) {
                isHidden = true;
            } else {
                isHidden = false;
            }
        }

        public void CollidePlantWall(Cell plantWall) {
            BumpMove(plantWall);
        }

        public void BumpMove(Cell c) {
            direction = GetDirectionToTarget(c);
            direction.X -= 2 * direction.X;
            direction.Y -= 2 * direction.Y;

            position.X += (int)(direction.X * 1.6);
            position.Y += (int)(direction.Y * 1.6);
        }
    }
}
