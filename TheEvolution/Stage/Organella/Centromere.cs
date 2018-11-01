using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Organella {
    class Centromere : Organelle {

        public Centromere(Form form) : base(form) {
            images = ImageContainer.imgER;
            size = images[0].Size;
        }
    }
}
