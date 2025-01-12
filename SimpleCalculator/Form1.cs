using System;
using System.Data;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1
    {
        private double result;
        private string input = "";
        private bool operatorPressed;

        public Form1()
        {
            InitializeComponent();
        }

        // Form Load event
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Simple Calculator";
            // Enable form to capture key presses
            this.KeyPreview = true;
        }

        // Form KeyDown event to handle keyboard input
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    {
                        this.btnNumber_Click(this.btn0, (EventArgs)null);
                        break;
                    }
                case Keys.D1:
                case Keys.NumPad1:
                    {
                        this.btnNumber_Click(this.btn1, (EventArgs)null);
                        break;
                    }
                case Keys.D2:
                case Keys.NumPad2:
                    {
                        this.btnNumber_Click(this.btn2, (EventArgs)null);
                        break;
                    }
                case Keys.D3:
                case Keys.NumPad3:
                    {
                        this.btnNumber_Click(this.btn3, (EventArgs)null);
                        break;
                    }
                case Keys.D4:
                case Keys.NumPad4:
                    {
                        this.btnNumber_Click(this.btn4, (EventArgs)null);
                        break;
                    }
                case Keys.D5:
                case Keys.NumPad5:
                    {
                        this.btnNumber_Click(this.btn5, (EventArgs)null);
                        break;
                    }
                case Keys.D6:
                case Keys.NumPad6:
                    {
                        this.btnNumber_Click(this.btn6, (EventArgs)null);
                        break;
                    }
                case Keys.D7:
                case Keys.NumPad7:
                    {
                        this.btnNumber_Click(this.btn7, (EventArgs)null);
                        break;
                    }
                case Keys.D8:
                case Keys.NumPad8:
                    {
                        this.btnNumber_Click(this.btn8, (EventArgs)null);
                        break;
                    }
                case Keys.D9:
                case Keys.NumPad9:
                    {
                        this.btnNumber_Click(this.btn9, (EventArgs)null);
                        break;
                    }
                case Keys.Add:
                case Keys.Oemplus:
                    {
                        this.btnOperation_Click(this.btnAdd, (EventArgs)null);
                        break;
                    }
                case Keys.Subtract:
                case Keys.OemMinus:
                    {
                        this.btnOperation_Click(this.btnSubtract, (EventArgs)null);
                        break;
                    }
                case Keys.Multiply:
                    {
                        this.btnOperation_Click(this.btnMultiply, (EventArgs)null);
                        break;
                    }
                case Keys.Divide:
                case Keys.OemQuestion:
                    {
                        this.btnOperation_Click(this.btnDivide, (EventArgs)null);
                        break;
                    }
                case Keys.Enter:
                    {
                        this.btnEquals_Click(this.btnEquals, (EventArgs)null);
                        break;
                    }
                case Keys.Delete:
                case Keys.Back:
                    {
                        this.btnClear_Click(this.btnClear, (EventArgs)null);
                        break;
                    }
            }
        }

        // Number button click event
        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (operatorPressed)
            {
                this.txtDisplay.Text += " " + ((Button)sender).Text;
            }
            else
            {
                this.txtDisplay.Text += ((Button)sender).Text;
            }
            input += ((Button)sender).Text;
            operatorPressed = false;
        }

        // Operation button click event
        private void btnOperation_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += " " + ((Button)sender).Text + " ";
            input += " " + ((Button)sender).Text + " ";
            operatorPressed = true;
        }

        // Equals button click event with division by zero check
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                if (input.Contains("/ 0"))
                {
                    this.txtDisplay.Text = "Error: Can't divide by Zero";
                    input = "";
                }
                else
                {
                    result = EvaluateExpression(input);
                    this.txtDisplay.Text = result.ToString();
                    input = result.ToString();
                }
            }
            catch (Exception ex)
            {
                this.txtDisplay.Text = "Error";
                input = "";
            }
            operatorPressed = false;
        }

        // Clear button click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Clear();
            input = "";
            result = 0d;
            operatorPressed = false;
        }

        // Evaluate the mathematical expression
        private double EvaluateExpression(string expression)
        {
            var table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, string.Empty));
        }
    }
}