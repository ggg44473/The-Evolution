using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheEvolution.Core {
    abstract class Food : Painter {

        public Food() {
            images = new List<Bitmap>();
        }

        public Food(List<Bitmap> images) {
            this.images = images;
        }
    }
}
