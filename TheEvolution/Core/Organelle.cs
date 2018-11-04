using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TheEvolution.Core {

    class Organelle : Painter {

        public Organelle(PictureBox picBoxBg, Point point) : base(picBoxBg) {
            GameSystem.organella.Add(this);
            position = point;
        }

        public virtual void Collide(int myId) {
            Dispose();
            GameSystem.organella.RemoveAt(myId);
        }
    }
}
