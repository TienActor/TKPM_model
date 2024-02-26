using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter
{
    internal class MyRectangle
    {
        public int _x;
        public int _y;
        public int _width;
        public int _height;
        public MyRectangle() { }
        public MyRectangle(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _width = width;
            _height = height;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, _x, _y, _width, _height);
        }

    }
}
