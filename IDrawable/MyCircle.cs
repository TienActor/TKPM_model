using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDrawable
{
    internal class MyCircle:Shape
    {
        public Point Location { get; private set; }
        public int Radius { get; private set; }
    

        // Constructor with initialization
        public MyCircle(Point location, int radius, int borderWidth, Color borderColor)
        {
            Location = location;
            Radius = radius;
            BorderWidth = borderWidth;
            BorderColor = borderColor;
            Fill = false;
        }

        // Method to draw the circle
        public override void Draw(Graphics g)
        {
            if (Fill)
            {
                using
                    (Brush brush = new HatchBrush(FillPattern, FillColor, Color.Transparent))
                {
                    g.FillEllipse(brush, Location.X - Radius, Location.Y - Radius, Radius * 2, Radius * 2);
                }
            }
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                g.DrawEllipse(pen, Location.X - Radius, Location.Y -

                Radius, Radius *2,Radius * 2);
            }
            
        }
    }
}
