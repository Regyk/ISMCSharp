using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void output()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                double a = Double.Parse(textBox1.Text), b = Double.Parse(textBox2.Text), x = Double.Parse(textBox3.Text);
                double y = 2.4 * Math.Abs((Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);
                textBox4.Text = Convert.ToString(y);
            }
            else
                textBox4.Text = "Введите данные";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output();
        }
    }
}
