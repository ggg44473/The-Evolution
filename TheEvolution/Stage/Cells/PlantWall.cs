using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    class PlantWall : Cell {

        public PlantWall(Form form) : base(form) {
            GameSystem.otherCells.Add(this);
            images = ImageContainer.imgPlantWall;
            size = images[0].Size;
            position = GameSystem.SetPosition(random.NextDouble(), random.NextDouble());
        }
    }
}
