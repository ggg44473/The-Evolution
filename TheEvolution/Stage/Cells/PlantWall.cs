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
            
        private int aniInterval;

        public PlantWall(Form form, Point point) : base(form, point) {
            GameSystem.otherCells.Add(this);
            images = ImageContainer.imgPlantWall;
            size = images[0].Size;
        }

        public override void NextStep() {
            if (aniInterval == 0) {
                aniInterval = 5;
                //Animate();
            }
            aniInterval--;
        }
    }
}
