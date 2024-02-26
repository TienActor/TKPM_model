using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter
{
    internal class MyRectangleAdapter:MyRectangle,IShape
    {
        private Point start;
        private Point end;

        public MyRectangleAdapter(Point start, Point end) 
        {
            this.start = start;
            this.end = end;
            int x = Math.Min(start.X, end.X);
            int y = Math.Min(start.Y, end.Y);
            int width = Math.Abs(start.X - end.X);
            int height = Math.Abs(start.Y - end.Y);
            base._x = x;
            base._y = y;
            base._width = width;
            base._height = height;
        }



        public new void Draw(Graphics g)
        {
            base.Draw(g);
        }

    }
}
