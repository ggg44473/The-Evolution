﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Foods {
    class Algae : Food {

        public Algae(PictureBox picBoxBg) : base(picBoxBg) {
            images = ImageContainer.imgAlgae;
            size = images[0].Size;
        }
    }
}
