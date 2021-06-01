using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int op;
        double a, b, c;
        bool znak = true;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text += "0,";
                button11.Enabled = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + ",";
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button11.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = '+';
                textBox1.Text = "";
                button11.Enabled = true;
            }
            catch { }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = '-';
                textBox1.Text = "";
                button11.Enabled = true;
            }
            catch { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = '*';
                textBox1.Text = "";
                button11.Enabled = true;
            }
            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                op = '/';
                textBox1.Text = "";
                button11.Enabled = true;
            }
            catch { }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                a = 1 / a;
                textBox1.Text = Convert.ToString(a);
            }
            catch { }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                a = Math.Sqrt(a);
                textBox1.Text = Convert.ToString(a);
            }
            catch { }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(textBox1.Text);
                switch (op)
                {
                    case '+': c = a + b; break;
                    case '-': c = a - b; break;
                    case '*': c = a * b; break;
                    case '/':
                        if (b == 0) MessageBox.Show("Деление на 0 недопустимо");
                        else c = a / b;
                        break;
                    default: break;

                }
                textBox1.Text = Convert.ToString(c);
            }
            catch { }
        }
    }
}
