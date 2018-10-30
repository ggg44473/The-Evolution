using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    partial class Player : ICollideFood {

        private int foodCount;

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

        public void CollideCompetitor() {
            if (Hp > 1) {
                size.Width -= (int)(0.012 * GameSystem.screen.Width);
                size.Height -= (int)(0.02 * GameSystem.screen.Height);
            }
            Hp -= 1;
        }
    }
}
