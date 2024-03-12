namespace Lab8_Strategy_WF
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBT1 = new System.Windows.Forms.RadioButton();
            this.radioBT2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(25, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 407);
            this.panel1.TabIndex = 0;
            // 
            // radioBT1
            // 
            this.radioBT1.AutoSize = true;
            this.radioBT1.Location = new System.Drawing.Point(676, 62);
            this.radioBT1.Name = "radioBT1";
            this.radioBT1.Size = new System.Drawing.Size(62, 20);
            this.radioBT1.TabIndex = 2;
            this.radioBT1.TabStop = true;
            this.radioBT1.Text = "Circle";
            this.radioBT1.UseVisualStyleBackColor = true;
            // 
            // radioBT2
            // 
            this.radioBT2.AutoSize = true;
            this.radioBT2.Location = new System.Drawing.Point(676, 99);
            this.radioBT2.Name = "radioBT2";
            this.radioBT2.Size = new System.Drawing.Size(90, 20);
            this.radioBT2.TabIndex = 3;
            this.radioBT2.TabStop = true;
            this.radioBT2.Text = "Rectangle";
            this.radioBT2.UseVisualStyleBackColor = true;
            this.radioBT2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioBT2);
            this.Controls.Add(this.radioBT1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBT1;
        private System.Windows.Forms.RadioButton radioBT2;
    }
}

