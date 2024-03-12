using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Adapter
{
    internal class MyRectangleAdapter:MyRectangle,IShape
    {
        private MyRectangle _rectangle;  ///adapteee 
        // gồm conbotructor bao gồm cái mới và cái cũ có bước biến đổi 
        public MyRectangleAdapter(Point startPoint, Point endPoint)
        {
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);

            _rectangle = new MyRectangle(x, y, width, height);
        }



        public new void Draw(Graphics g)
        {
            base.Draw(g);
        }

    }
}
