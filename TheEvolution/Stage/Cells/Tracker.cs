using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    class Tracker : Cell {

        private Point direction;

        public Tracker(Form form) : base(form) {
            GameSystem.otherCells.Add(this);
            images = ImageContainer.imgTracker;
            size = images[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
            moveSpeed = (int)(0.05 * size.Width);
            direction = new Point();
        }
    }
}
