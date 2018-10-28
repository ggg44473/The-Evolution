﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheEvolution.Core;

namespace TheEvolution.Stage.Cells {
    partial class Player : ICollideFood {

        public void CollideFood() {
            size.Width = (int)(1.1 * size.Width);
            size.Height = (int)(1.1 * size.Height);
        }
    }
}
