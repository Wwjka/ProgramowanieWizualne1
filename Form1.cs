using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double result = a + b;
            labelResult.Text = result.ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double result = a - b;
            labelResult.Text = result.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double result = a * b;
            labelResult.Text = result.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double result = a / b;
            labelResult.Text = result.ToString();
        }
    }
}