using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;


namespace IDrawable
{
    public partial class MyPaint_V2 : Form
    {
        private Graphics _graphics;
        private Pen _pen;
        private Point _startPoint;
        private Point _endPoint;
        private bool _isDrawing;
        private bool _drawRectangle;
        private bool _drawCircle;
        private LinkedList<Myrectangle> _rectangles;
        private LinkedList<MyCircle> _circles;
        private int iFillable;

        public MyPaint_V2()
        {
            InitializeComponent();
            _graphics = mainPanel.CreateGraphics();
            _pen = new Pen(Color.Black, 1);
            _startPoint = Point.Empty;
            _endPoint = Point.Empty;
            _isDrawing = false;
            _drawRectangle = false;
            _drawCircle = false;
            _rectangles = new LinkedList<Myrectangle>();
            _circles = new LinkedList<MyCircle>();
            iFillable = 2;
        }


        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _startPoint = e.Location;
                _isDrawing = true;
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _endPoint = e.Location;
                mainPanel.Invalidate(); // Triggers the Paint event
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isDrawing)
            {
                _isDrawing = false;
                Color penColor = cdPenColor.Color;
                Color fillColor =cdFillColor.Color;
                ///
                HatchStyle fillPattern = HatchStyle.BackwardDiagonal; // Default pattern, you can change it or make it selectable

                SolidBrush chosenFillColor = iFillable == 1 ? new SolidBrush(fillColor) : new SolidBrush(Color.Transparent); // Use fillColor if color fill is selected
                HatchStyle chosenPattern = iFillable == 2 ? fillPattern : HatchStyle.Cross; // Example pattern
               

                if (_drawRectangle)
                {
                    
                    Myrectangle rect = new Myrectangle(_startPoint, _endPoint, (int)inpPenWidth.Value, penColor)
                    {
                        Fill = (iFillable == 1 || iFillable == 2),
                        FillColor = chosenFillColor.Color,
                        FillPattern = chosenPattern
                    };
                    _rectangles.AddLast(rect);
                }
                else if (_drawCircle)
                {
                    int radius = (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_endPoint.Y - _startPoint.Y, 2)) / 2;
                    MyCircle circle = new MyCircle(_startPoint, radius, (int)inpPenWidth.Value, penColor)
                    {
                        Fill = (iFillable == 1 || iFillable == 2),
                        FillColor = chosenFillColor.Color,
                        FillPattern = chosenPattern
                    };
                    _circles.AddLast(circle);
                }
                mainPanel.Invalidate(); // Update the drawing
            }
        }

        private void Rectangle_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            _drawRectangle = radioButton.Checked;
            // When the rectangle is checked, ensure the circle is not
            if (_drawRectangle) _drawCircle = false;
        }

        private void Circle_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            _drawCircle = radioButton.Checked;
            // When the circle is checked, ensure the rectangle is not
            if (_drawCircle) _drawRectangle = false;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Myrectangle rect in _rectangles)
            {
                rect.Draw(e.Graphics);
            }
            foreach (MyCircle circ in _circles)
            {
                circ.Draw(e.Graphics);
            }
            if (_isDrawing)
            {
                // Draw the current shape being drawn
                if (_drawRectangle)
                {
                    e.Graphics.DrawRectangle(_pen, _startPoint.X, _startPoint.Y, _endPoint.X - _startPoint.X, _endPoint.Y - _startPoint.Y);
                }
                else if (_drawCircle)
                {
                    int radius = (int)Math.Sqrt(Math.Pow(_endPoint.X - _startPoint.X, 2) + Math.Pow(_endPoint.Y - _startPoint.Y, 2)) / 2;
                    e.Graphics.DrawEllipse(_pen, _startPoint.X - radius, _startPoint.Y - radius, radius * 2, radius * 2);
                }
            }
        }

      

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cdPenColor.ShowDialog() == DialogResult.OK)
            {
                lblPenColor.ForeColor = cdPenColor.Color;
            }
        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            if(cdFillColor.ShowDialog() == DialogResult.OK)
            {
                lblPenColor1.ForeColor=cdFillColor.Color;
            }
        }

        private void none_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                iFillable = 0; // Set iFillable for no fill
            }
        }

        private void color_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                iFillable = 1; // Set iFillable for color fill
            }
        }

        private void pattern_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                iFillable = 2; // Set iFillable for pattern fill
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool userChoseJson=false;

            IShapeVisitor visitor;

            // Determine format based on user choice or file extension
            if (userChoseJson) // This condition needs to be determined based on user input
            {
                visitor = new JsonExportVisitor();
            }
            else // CSV by default or based on user input
            {
                visitor = new CsvExportVisitor();
            }
            List<Shape> shapes = new List<Shape>(); // Assuming Shape is the base class/interface for all shapes

            foreach (var shape in shapes)
            {
                shape.Accept(visitor);
            }

            string exportedData = "";
            if (visitor is JsonExportVisitor jsonVisitor)
            {
                exportedData = jsonVisitor.Export();
            }
            else if (visitor is CsvExportVisitor csvVisitor)
            {
                exportedData = csvVisitor.Export();
            }

            // Save exportedData to a file
        }
    }
}
