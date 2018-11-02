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

        public Organelle(Form form) : base(form) {
            GameSystem.organella.Add(this);
        }

        public override void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[imgIndex],
                position.X, position.Y, size.Width, size.Height);
        }

        public virtual void Collide(int myId) {
            GameSystem.form.Paint -= Paint;
            GameSystem.organella.RemoveAt(myId);
        }
    }
}
