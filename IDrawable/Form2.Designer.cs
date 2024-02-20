namespace IDrawable
{
    partial class MyPaint_V2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.inpPenWidth = new System.Windows.Forms.NumericUpDown();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.pattern = new System.Windows.Forms.RadioButton();
            this.color = new System.Windows.Forms.RadioButton();
            this.none = new System.Windows.Forms.RadioButton();
            this.lblPenColor1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.cdPenColor = new System.Windows.Forms.ColorDialog();
            this.cdFillColor = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(31, 28);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(847, 529);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnColor);
            this.groupBox1.Controls.Add(this.inpPenWidth);
            this.groupBox1.Controls.Add(this.lblPenColor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(953, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(68, 65);
            this.btnColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(107, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Pick a Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(68, 20);
            this.inpPenWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(120, 22);
            this.inpPenWidth.TabIndex = 2;
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenColor.Location = new System.Drawing.Point(11, 65);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(49, 20);
            this.lblPenColor.TabIndex = 1;
            this.lblPenColor.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor1);
            this.groupBox2.Controls.Add(this.pattern);
            this.groupBox2.Controls.Add(this.color);
            this.groupBox2.Controls.Add(this.none);
            this.groupBox2.Controls.Add(this.lblPenColor1);
            this.groupBox2.Location = new System.Drawing.Point(953, 212);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(200, 126);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brush";
            // 
            // btnColor1
            // 
            this.btnColor1.Location = new System.Drawing.Point(68, 96);
            this.btnColor1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(107, 23);
            this.btnColor1.TabIndex = 4;
            this.btnColor1.Text = "Pick a Color";
            this.btnColor1.UseVisualStyleBackColor = true;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // pattern
            // 
            this.pattern.AutoSize = true;
            this.pattern.Location = new System.Drawing.Point(13, 73);
            this.pattern.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pattern.Name = "pattern";
            this.pattern.Size = new System.Drawing.Size(90, 20);
            this.pattern.TabIndex = 3;
            this.pattern.TabStop = true;
            this.pattern.Text = "Pattern Fill";
            this.pattern.UseVisualStyleBackColor = true;
            this.pattern.CheckedChanged += new System.EventHandler(this.pattern_CheckedChanged);
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Location = new System.Drawing.Point(13, 48);
            this.color.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(80, 20);
            this.color.TabIndex = 2;
            this.color.TabStop = true;
            this.color.Text = "Color Fill";
            this.color.UseVisualStyleBackColor = true;
            this.color.CheckedChanged += new System.EventHandler(this.color_CheckedChanged);
            // 
            // none
            // 
            this.none.AutoSize = true;
            this.none.Location = new System.Drawing.Point(13, 21);
            this.none.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(66, 20);
            this.none.TabIndex = 1;
            this.none.TabStop = true;
            this.none.Text = "No Fill";
            this.none.UseVisualStyleBackColor = true;
            this.none.CheckedChanged += new System.EventHandler(this.none_CheckedChanged);
            // 
            // lblPenColor1
            // 
            this.lblPenColor1.AutoSize = true;
            this.lblPenColor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenColor1.Location = new System.Drawing.Point(11, 96);
            this.lblPenColor1.Name = "lblPenColor1";
            this.lblPenColor1.Size = new System.Drawing.Size(49, 20);
            this.lblPenColor1.TabIndex = 0;
            this.lblPenColor1.Text = "Color";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Circle);
            this.groupBox3.Controls.Add(this.Rectangle);
            this.groupBox3.Location = new System.Drawing.Point(953, 402);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(200, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shape";
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Location = new System.Drawing.Point(13, 66);
            this.Circle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(62, 20);
            this.Circle.TabIndex = 1;
            this.Circle.TabStop = true;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.CheckedChanged += new System.EventHandler(this.Circle_CheckedChanged);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(13, 39);
            this.Rectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(90, 20);
            this.Rectangle.TabIndex = 0;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.CheckedChanged += new System.EventHandler(this.Rectangle_CheckedChanged);
            // 
            // MyPaint_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 587);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyPaint_V2";
            this.Text = "MyPaint_V2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPenColor1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.RadioButton pattern;
        private System.Windows.Forms.RadioButton color;
        private System.Windows.Forms.RadioButton none;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.ColorDialog cdPenColor;
        private System.Windows.Forms.ColorDialog cdFillColor;
    }
}