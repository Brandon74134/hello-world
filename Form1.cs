using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        //List of operations
        //List of operand
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        int decimalCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += "9";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (decimalCounter == 0)
            {
                txtDisplay.Text += ".";
                decimalCounter += 1;
            }
            else
            {
            }
        }

        private double GetUserNumber()
        {
            double result = double.Parse(txtDisplay.Text);
            return result;//return double.Parse(txtDisplay.Text);
        }

        private double GetUserNumber1()
        {
            double result = double.Parse(operand1);
            return result;//return double.Parse(txtDisplay.Text);
        }

        private double GetUserNumber2()
        {
            double result2 = double.Parse(operand2);
            return result2;//return double.Parse(txtDisplay.Text);
        }

        private void DisplayResult(double result)
        {
            txtDisplay.Text = result.ToString();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            operand1 = txtDisplay.Text;
            operation = '+';
            txtDisplay.Text = string.Empty;
            decimalCounter = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            operand2 = txtDisplay.Text;
            var num1 = GetUserNumber1();
            var num2 = GetUserNumber2();

            if (operation == '+')
            {
                result = num1 + num2;
                txtDisplay.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtDisplay.Text = result.ToString();
            }
            else if (operation == 'X')
            {
                result = num1 * num2;
                txtDisplay.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    txtDisplay.Text = result.ToString();
                }
                else
                {
                    txtDisplay.Text = "Can't Divide by Zero";
                }
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            operand1 = txtDisplay.Text;
            operation = '/';
            txtDisplay.Text = string.Empty;
            decimalCounter = 0;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = txtDisplay.Text;
            operation = 'X';
            txtDisplay.Text = string.Empty;
            decimalCounter = 0;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            operand1 = txtDisplay.Text;
            operation = '-';
            txtDisplay.Text = string.Empty;
            decimalCounter = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            decimalCounter = 0;
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                var number = GetUserNumber() * -1;
                txtDisplay.Text = number.ToString();
            }
            else
            {
                txtDisplay.Text = "-";
            }

        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "")
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            
        }

        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            decimalCounter = 0;
        }
    }
}
