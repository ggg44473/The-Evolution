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
            position = GameSystem.SetPosition(random.Next(3) + random.NextDouble(), random.Next(3) + random.NextDouble());
            GameSystem.foods.Add(this);
        }

        public override void Collide() {
            position.X = random.Next(-GameSystem.screen.Width,  2 * GameSystem.screen.Width - size.Width);
            position.Y = random.Next(-GameSystem.screen.Height, 2 * GameSystem.screen.Height - size.Height);
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
                aniInterval = 4;
                Animate();
            }
            aniInterval--;
        }
    }
}
