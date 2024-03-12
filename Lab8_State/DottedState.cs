using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_State
{
    public class DottedState:State
    {
        private MyRectangle _rect;

        public void SetContext(MyRectangle rect)
        { this._rect = rect; }


        public void Draw(Graphics g)
        {
            using (var pen = new Pen(Color.Black,2))
                    {
                pen.DashStyle = DashStyle.Dot;

            }
        }
    }
}
