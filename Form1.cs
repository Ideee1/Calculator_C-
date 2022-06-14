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
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "9";
            display.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "8";
            display.Text += userInput;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void clearentry_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            display.Text = "0";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "4";
            display.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "5";
            display.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "6";
            display.Text += userInput;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            display.Text = "0";
            
        }

        private void num1_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "1";
            display.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "2";
            display.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "3";
            display.Text += userInput;
        }

        private void minuss_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //plus
            if(function == '+')
            {
                result = firstNum + secondNum;
                display.Text = result.ToString();
            }
            //minuss
            else if (function == '-')
            {
                result = firstNum - secondNum;
                display.Text = result.ToString();
            }
                //divide
            else if (function == '/')
            {
                if(secondNum == 0)
                {
                    display.Text = "ohh noo!";
                }
                else
                {
                    result = firstNum / secondNum;
                    display.Text = result.ToString();
                }
                
            }
            //multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                display.Text = result.ToString();
            }

        }

        private void num0_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "0";
            display.Text += userInput;
        }

        private void point_Click(object sender, EventArgs e)
        {
            display.Text += ".";
            first = userInput;
            userInput = "";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            display.Text = "";
            userInput += "7";
            display.Text += userInput;
        }

        private void display_Click(object sender, EventArgs e)
        {

        }
    }
}
