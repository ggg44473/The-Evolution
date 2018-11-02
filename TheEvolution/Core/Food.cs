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

        public Food(Form form) : base(form) {
            random = new Random(Guid.NewGuid().GetHashCode());
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            GameSystem.foods.Add(this);
        }

        public override void Collide() {
            position.X = random.Next(1, GameSystem.screen.Width - size.Width);
            position.Y = random.Next(1, GameSystem.screen.Height - size.Height);
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
