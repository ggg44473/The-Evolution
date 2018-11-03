using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;
using System.Drawing;

namespace TheEvolution.Stage.Organella {
    class Chloroplast : Organelle {

        public Chloroplast(Form form, Point point) : base(form, point) {
            images = ImageContainer.imgChloroplast;
            size = images[0].Size;
        }
    }
}
