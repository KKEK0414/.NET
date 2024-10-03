using System;
using System.Windows.Forms;

namespace exp9
{
    public partial class Form1 : Form
    {
        int m1, m3, m5, m7, m9, x;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateText("1");
        }

        private void updateText(String v)
        {
            if(v == "+")
            {
                m1 = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                x = 1;
                return;
            }
            if (v == "-")
            {
                m3 = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                x = 2;
                return;
            }
            if (v == "*")
            {   m5 = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                x = 3;
                return;
            }
            if (v == "/")
            {
                m7 = Convert.ToInt32(textBox1.Text);
                textBox1.Clear();
                x = 4;
                return;
            }
            if (v == "=")
            {
                if (x == 1)
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) + m1).ToString();
                }
                if (x == 2) 
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) - m3).ToString();
                }
                if(x == 3)
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) * m5).ToString();
                }
                if(x == 4)
                {
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) / m7).ToString();
                }
                x = 0;
                return;
            }
            textBox1.Text += v.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateText("2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateText("3");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateText("5");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateText("6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            updateText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateText("8");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            updateText("9");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            updateText("/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            updateText("0");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            updateText("+");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            updateText("-");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            updateText("*");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            updateText("=");
        }

        
    }
}
