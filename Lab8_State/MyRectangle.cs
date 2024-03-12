using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_State
{
    public class MyRectangle
    {
        public int x,y, width,height;

        private State _state;


        public MyRectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
         
        }

        public void TransitionTo(State state)
        {
            _state = state;
            _state.SetContext(this);
        }


        public void Draw(Graphics g)
        {
            _state?.Draw(g);
        }
    }
}
