using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_State
{
    public class SolidState:State
    {
        private MyRectangle _rect;

        public void SetContext(MyRectangle rect)
        {
            _rect = rect;
        }

        public void Draw(Graphics g)
        {
            using(var pen= new Pen(Color.Black,2))
            {
                g.DrawRactangle(pen,_rect.x, _rect.y,_rect.width,_rect.height);
            }
        }

    }
}
