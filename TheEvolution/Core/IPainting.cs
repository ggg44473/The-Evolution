using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TheEvolution.Core {
    interface IPainting {

        List<Bitmap> Images { get; set; }
        Size Size { get; set; }
        Point Position { get; set; }
        void Paint(object sender, PaintEventArgs e);
    }
}
