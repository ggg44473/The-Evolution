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
            
        public PlantWall(PictureBox picBoxBg, Point point) : base(picBoxBg, point) {
            GameSystem.otherCells.Add(this);
            images = ImageContainer.imgPlantWall;
            size = images[0].Size;
        }

        public override void NextStep() {
            if (aniInterval == 0) {
                aniInterval = 4;
                Animate();
            }
            aniInterval--;
        }
    }
}
