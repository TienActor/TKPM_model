using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_State
{
    public class DashState:State
    {
        private MyRectangle _rectangle;

        public void SetContext(MyRectangle rectangle)
        { this._rectangle = rectangle; }

        public void Draw(Graphics graphics)
        {
            using(var pen= new Pen(Color.Black, 2)) {
                pen.DashStyle = DashStyle.DashDot;


            }
        }
    }
}
