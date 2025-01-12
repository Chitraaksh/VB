using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalculator
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn1 = new Button();
            btn1.Click += new EventHandler(btnNumber_Click);
            btn2 = new Button();
            btn2.Click += new EventHandler(btnNumber_Click);
            btn3 = new Button();
            btn3.Click += new EventHandler(btnNumber_Click);
            btnAdd = new Button();
            btnAdd.Click += new EventHandler(btnOperation_Click);
            btn4 = new Button();
            btn4.Click += new EventHandler(btnNumber_Click);
            btn5 = new Button();
            btn5.Click += new EventHandler(btnNumber_Click);
            btn6 = new Button();
            btn6.Click += new EventHandler(btnNumber_Click);
            btnSubtract = new Button();
            btnSubtract.Click += new EventHandler(btnOperation_Click);
            btn7 = new Button();
            btn7.Click += new EventHandler(btnNumber_Click);
            btn8 = new Button();
            btn8.Click += new EventHandler(btnNumber_Click);
            btn9 = new Button();
            btn9.Click += new EventHandler(btnNumber_Click);
            btnMultiply = new Button();
            btnMultiply.Click += new EventHandler(btnOperation_Click);
            btnClear = new Button();
            btnClear.Click += new EventHandler(btnClear_Click);
            btn0 = new Button();
            btn0.Click += new EventHandler(btnNumber_Click);
            btnEquals = new Button();
            btnEquals.Click += new EventHandler(btnEquals_Click);
            btnDivide = new Button();
            btnDivide.Click += new EventHandler(btnOperation_Click);
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(114, 110, 127);
            txtDisplay.Location = new Point(31, 25);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular);
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(613, 189);
            txtDisplay.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(114, 110, 127);
            btn1.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn1.Location = new Point(45, 239);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(114, 110, 127);
            btn2.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn2.Location = new Point(186, 239);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(114, 110, 127);
            btn3.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn3.Location = new Point(339, 239);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(114, 110, 127);
            btnAdd.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btnAdd.Location = new Point(488, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 100);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(114, 110, 127);
            btn4.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn4.Location = new Point(45, 373);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(114, 110, 127);
            btn5.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn5.Location = new Point(186, 373);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(114, 110, 127);
            btn6.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn6.Location = new Point(339, 373);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(114, 110, 127);
            btnSubtract.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btnSubtract.Location = new Point(488, 373);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(100, 100);
            btnSubtract.TabIndex = 8;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(114, 110, 127);
            btn7.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn7.Location = new Point(45, 513);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 9;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(114, 110, 127);
            btn8.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn8.Location = new Point(186, 513);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 10;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(114, 110, 127);
            btn9.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn9.Location = new Point(339, 513);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(114, 110, 127);
            btnMultiply.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btnMultiply.Location = new Point(488, 513);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(100, 100);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(114, 110, 127);
            btnClear.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btnClear.Location = new Point(45, 653);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 100);
            btnClear.TabIndex = 13;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(114, 110, 127);
            btn0.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btn0.Location = new Point(186, 653);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 100);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(114, 110, 127);
            btnEquals.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btnEquals.Location = new Point(339, 653);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(100, 100);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(114, 110, 127);
            btnDivide.Font = new Font("Microsoft Sans Serif", 50f, FontStyle.Regular, GraphicsUnit.Pixel);
            btnDivide.Location = new Point(488, 653);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(100, 100);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8f, 20f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(654, 785);
            Controls.Add(btnDivide);
            Controls.Add(btnEquals);
            Controls.Add(btn0);
            Controls.Add(btnClear);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnSubtract);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            Load += new EventHandler(Form1_Load);
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            ResumeLayout(false);
            PerformLayout();
        }

        internal TextBox txtDisplay;
        internal Button btn1;
        internal Button btn2;
        internal Button btn3;
        internal Button btnAdd;
        internal Button btn4;
        internal Button btn5;
        internal Button btn6;
        internal Button btnSubtract;
        internal Button btn7;
        internal Button btn8;
        internal Button btn9;
        internal Button btnMultiply;
        internal Button btnClear;
        internal Button btn0;
        internal Button btnEquals;
        internal Button btnDivide;

    }
}