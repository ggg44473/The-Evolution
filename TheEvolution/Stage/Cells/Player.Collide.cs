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

        public void CollideCompetitor(Competitor c) {
            BumpMove(c);
            if (Hp > 1) {
                size.Width -= (int)(0.012 * GameSystem.screen.Width);
                size.Height -= (int)(0.02 * GameSystem.screen.Height);
            }
            Hp -= 1;
        }

        public void BumpMove(Competitor c) {
            direction = GetDirectionToTarget(c);
            direction.X -= 2 * direction.X;
            direction.Y -= 2 * direction.Y;

            position.X += (int)(direction.X * size.Width / 1.8);
            position.Y += (int)(direction.Y * size.Height / 1.8);
        }

        public virtual void KillCompetitor(object sender, EventArgs e) {
            for (int i = 0; i < 25; i++) {
                CollideFood();
            }
        }
    }
}
