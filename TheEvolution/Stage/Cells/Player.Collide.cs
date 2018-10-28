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
            currentImgIndex = 0;
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
