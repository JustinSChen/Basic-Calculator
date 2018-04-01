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
        Double result_val = 0;
        String op = "";
        bool opUsed = false;
           
        public Form1()
        {
            InitializeComponent();
        }

        private void clearentry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            result_val = 0;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case "+":
                    result.Text = (result_val + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (result_val - Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (result_val / Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (result_val * Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
                   
        private void button_click(object sender, EventArgs e)
        {
            if(result.Text == "0" || opUsed)
            {
                result.Clear();
            }
            opUsed = false;
            Button button = (Button)sender;

            if(button.Text == ".")
            {
                if (!result.Text.Contains("."))
                {
                    result.Text = result.Text + button.Text;     
                }
            } else
            {
                result.Text = result.Text + button.Text;
            }
        }

        private void op_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            op = button.Text;
            result_val = Double.Parse(result.Text);
            opUsed = true;
        }
    }
}
