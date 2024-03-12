using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_State
{
    public interface State
    {
        void SetContext(MyRectangle rect);

        void Draw(Graphics g);
    }
}
