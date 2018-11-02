using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;
using System.Drawing;

namespace TheEvolution.Stage.Organella {
    class ER : Organelle {

        public ER(Form form) : base(form){
            images = ImageContainer.imgER;
            size = images[0].Size;
            position = new Point(150, 150);
        }
    }
}
