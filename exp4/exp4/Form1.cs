using System;

using System.Windows.Forms;

namespace exp4
{
    public partial class Form1 : Form
    {
        int a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
            textBox3.Text = (a+b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getData();
            textBox3.Text = (a-b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getData();
            textBox3.Text = (a*b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getData();
            textBox3.Text= (a/b).ToString();
        }

        private void getData()
        {
            a = Convert.ToInt32(textBox1.Text); 
            b = Convert.ToInt32(textBox2.Text);
        }
    }
}
