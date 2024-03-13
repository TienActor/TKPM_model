using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDrawable
{
    public abstract class Shape
    {
            public Color BorderColor { get; set; }
            public int BorderWidth { get; set; }
            public Color FillColor { get; set; }
            public HatchStyle FillPattern
            {
                get;
                set;
            }
            public bool Fill { get; set; }

            // Abstract method to draw the shape
            public abstract void Draw(Graphics g);


        /// visitor
        public abstract void Accept(IShapeVisitor visitor);

    }
}
