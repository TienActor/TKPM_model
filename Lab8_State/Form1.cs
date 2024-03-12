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
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                // Tạo một đối tượng MyRectangle mới
                MyRectangle rect = new MyRectangle(10, 10, 100, 50);

            }
            // Lựa chọn trạng thái phù hợp dựa trên RadioButton được chọn
            if (radioButton.Text == "SolidState")
            {
                rect.TransitionTo(new SolidState());
            }
            else if (radioButton.Text == "DottedState")
            {
                rect.TransitionTo(new DottedState());
            }
            else if (radioButton.Text == "DashedState")
            {
                rect.TransitionTo(new DashedState());
            }

            // Giả sử form1 là một Control và có phương thức Invalidate() để vẽ lại nó
            // Đoạn mã này sẽ phụ thuộc vào nơi bạn muốn vẽ hình chữ nhật (ví dụ: trên Panel, PictureBox, ...)
            form1.Invalidate(); // Yêu cầu vẽ lại form

            // Khi form được vẽ lại, hãy đảm bảo bạn có logic để vẽ hình chữ nhật
            // Có thể là trong phương thức form1_Paint
        }
    }
    }
