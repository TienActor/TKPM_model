using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_State
{
    public partial class Form1 : Form
    {
        private MyRectangle rect;
        private bool _moving = false;

        private State currentState;
        private Point _startPoint; // Điểm bắt đầu khi chuột nhấn xuống
        public Form1()
        {
            InitializeComponent();
            // Khởi tạo hình chữ nhật với giá trị ban đầu là kích thước cố định mà bạn muốn
            rect = new MyRectangle(0, 0, 0, 0); // 100 và 50 là ví dụ cho chiều rộng và chiều cao
          
            currentState = new SolidState(); // Trạng thái ban đầu
            currentState.SetContext(rect);
        }

   


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_moving)
            {
                // Cập nhật kích thước của hình chữ nhật dựa trên vị trí chuột di chuyển
                int width = e.X - _startPoint.X;
                int height = e.Y - _startPoint.Y;
                rect = new MyRectangle(_startPoint.X, _startPoint.Y, width, height);
                panel1.Invalidate(); // Yêu cầu vẽ lại panel
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Kết thúc vẽ hình chữ nhật
            _moving = false;

            // Yêu cầu vẽ lại panel lần cuối để "hoàn tất" hình chữ nhật
            panel1.Invalidate();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            rect.width = e.X - rect.x;
            rect.height = e.Y - rect.y;
            //_startPoint = e.Location;
            //_moving = true;
            // Cập nhật điểm bắt đầu và trạng thái khi chuột nhấn xuống


            if (radioButton1.Checked)
            {
                rect.TransitionTo(new SolidState());
            }
            else if (radioButton2.Checked)
            {
                rect.TransitionTo(new DottedState());
            }
            else if (radioButton3.Checked)
            {
                rect.TransitionTo(new DashState());
            }
            currentState.SetContext(rect);
        }
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
                rect.Draw(e.Graphics); // Gọi Draw từ MyRectangle, không phải từ State trực tiếp
            
        }
    }
    }
