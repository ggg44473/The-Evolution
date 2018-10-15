using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TheEvolution.Core {
    abstract class Creature {
        private int top, left;
        private Point[] frame;
        private Point center;
        private Region region;
        private Matrix rotation;
        private List<Image> imageList;

        public Creature() {
            GraphicsPath path = new GraphicsPath();
            path.AddPolygon(frame);
            region = new Region(path);
        }

        virtual public Point getCenter() {
            return new Point(
                (frame.Max(point => point.X) + frame.Min(point => point.X)) / 2,
                (frame.Max(point => point.Y) + frame.Min(point => point.Y)) / 2);
        }

        abstract public void Paint();
    }
}
