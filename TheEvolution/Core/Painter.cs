﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheEvolution.Core {
    abstract class Painter {

        protected List<Bitmap> images;
        protected Size size;
        protected Point position;

        // Delete it after completing all derived classes.
        public Painter() { }

        public Painter(Form form) {
            form.Paint += Paint;
        }

        public virtual Size Size { get => size; set =>size = value; }

        public virtual Point Position { get => position; set => position = value; }

        public virtual void Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawImage(images[0], position.X, position.Y, size.Width, size.Height);
        }

        public virtual Point GetCenter() {
            return new Point(
                x: position.X + (Size.Width / 2),
                y: position.Y + (Size.Height / 2));
        }

        public virtual void Collide() { }
    }
}
