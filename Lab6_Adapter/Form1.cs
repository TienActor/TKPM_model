using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_Adapter
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private bool _pressing;
        private Point _sPoint;
        private Point _ePoint;
        public Form1()
        {
            InitializeComponent();

            // thiet lap cac du lieu ban dau cho hinh ve
            g=mainPanel.CreateGraphics();
            _pressing = false;
            _sPoint = new Point(0,0);
            _ePoint = new Point(0,0);
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            _sPoint = _ePoint;
            _pressing=true;
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint = e.Location;
            _pressing=true;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(!_pressing||_sPoint==_ePoint) {
                return;
            }
            g.Clear(Color.White);
            //int x = _sPoint.X < e.X ? _sPoint.X : e.X;
            //int y = _sPoint.Y < e.Y ? _sPoint.Y : e.Y;
            //int w = Math.Abs(_sPoint.X - e.X);
            //int h = Math.Abs(_sPoint.Y - e.Y);
            //MyRectangle r = new MyRectangle(x, y, w, h);

            MyRectangleAdapter r = new MyRectangleAdapter(_sPoint,e.Location);
            r.Draw(g);
        }
    }
}
