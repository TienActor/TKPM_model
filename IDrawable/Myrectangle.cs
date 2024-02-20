using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDrawable
{
    internal class Myrectangle:Shape
    {
        private Point Location { get; set; }
        private int Width { get; set; }
        private int Height { get; set; }

        public Myrectangle()
        {

        }

        public Myrectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor)
        {
            Location = sPoint;
            Width = Math.Abs(sPoint.X - ePoint.X);
            Height = Math.Abs(sPoint.Y - ePoint.Y);
            BorderWidth = borderWidth;
            BorderColor = borderColor;
        }

        public Myrectangle(Point location, int width, int height, int borderWidth, Color borderColor)
        {
            Location = location;
            Width = width;
            Height = height;
            BorderWidth = borderWidth;
            BorderColor = borderColor;
            Fill = false; // Default no fill
        }

        // Method to draw the rectangle with fill
        public override void Draw(Graphics g)
        {
            if (Fill)
            {
                using (Brush brush = new HatchBrush(FillPattern, FillColor, Color.Transparent))
                {
                    g.FillRectangle(brush, Location.X, Location.Y, Width, Height);
                }
            }
            using (Pen pen = new Pen(BorderColor, BorderWidth))
            {
                g.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
            }
        }
    }
}
