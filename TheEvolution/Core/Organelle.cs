using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TheEvolution.Core {

    abstract class Organelle : Painter {

        public Organelle(PictureBox picBoxBg, Point point) : base(picBoxBg) {
            GameSystem.organella.Add(this);
            position = point;
        }

        public virtual void Collide(int myId) {
            Dispose();
            GameSystem.organella.RemoveAt(myId);
            if (GameSystem.formStage.InvokeRequired) {
                GameSystem.formStage.Invoke((Action)delegate () {
                    GameSystem.formStage.Pause_Click(this, EventArgs.Empty);
                });
            } else {
                GameSystem.formStage.Pause_Click(this, EventArgs.Empty);
            }
        }

        public virtual Point GetPosition() {
            return position;
        }
    }
}
