namespace IDrawable
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inpPenWidth = new System.Windows.Forms.NumericUpDown();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Location = new System.Drawing.Point(23, 22);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(992, 545);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1050, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nét vẽ";
            // 
            // inpPenWidth
            // 
            this.inpPenWidth.Location = new System.Drawing.Point(1153, 45);
            this.inpPenWidth.Name = "inpPenWidth";
            this.inpPenWidth.Size = new System.Drawing.Size(120, 22);
            this.inpPenWidth.TabIndex = 2;
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenColor.Location = new System.Drawing.Point(1050, 89);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(44, 22);
            this.lblPenColor.TabIndex = 3;
            this.lblPenColor.Text = "Màu";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(1165, 89);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Chọn màu";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 579);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblPenColor);
            this.Controls.Add(this.inpPenWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inpPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inpPenWidth;
        private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.Button btnColor;
    }
}

