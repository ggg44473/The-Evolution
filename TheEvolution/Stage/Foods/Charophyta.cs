using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;
using System.Drawing;

namespace TheEvolution.Stage.Foods {
    class Charophyta : Food {

        public Charophyta(Form form) : base(form) {
            images = ImageContainer.imgCharophyta;
            size = images[0].Size;
        }
    }
}
