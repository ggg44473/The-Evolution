using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using TheEvolution.Stage.Cells;

namespace TheEvolution.Core {
    abstract class Food : Painter {

        Random random;
        int aniInterval;

        public Food(PictureBox picBoxBg) : base(picBoxBg) {
            random = new Random(Guid.NewGuid().GetHashCode());
            do {
                position = GameSystem.SetPosition(random.Next(3) + random.NextDouble() - 0.255, random.Next(3) + random.NextDouble() - 0.325);
            } while (position.X < 0.22 * GameSystem.screen.Width || position.Y < 0.27 * GameSystem.screen.Height);
            GameSystem.foods.Add(this);
        }

        public override void Collide() {
            do {
                position = GameSystem.SetPosition(random.Next(3) + random.NextDouble() - 0.255, random.Next(3) + random.NextDouble() - 0.325);
            } while (position.X < 0.22 * GameSystem.screen.Width || position.Y < 0.27 * GameSystem.screen.Height);
        }

        public virtual void Animate() {
            if (imgIndex < images.Count - 1) {
                imgIndex++;
            } else {
                imgIndex = 0;
            }
        }

        public virtual void NextStep() {
            if (aniInterval == 0) {
                aniInterval = 8;
                Animate();
            }
            aniInterval--;
        }
    }
}
