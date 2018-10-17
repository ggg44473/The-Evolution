using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheEvolution.Core;
using System.Windows.Forms;

namespace TheEvolution.StageCell {
    abstract class Cell : Creature {
        virtual public void Move() { }
        virtual public void Animate() { }
    }
}
