using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Organella {
    class Chloroplast : Organelle {

        public Chloroplast(Form form) : base(form) {
            images = ImageContainer.imgChloroplast;
            size = images[0].Size;
        }
    }
}
