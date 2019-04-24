using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void output()
        {
            double a, b, c, x1, x2, D;
          
            if(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Введите данные");

            }
            else
            {   a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox2.Text);
                c = Double.Parse(textBox3.Text);
                D = b * b - 4 * a * c;
                textBox4.Text = Convert.ToString(D);
                label5.Visible = true;
                textBox4.Visible = true;
            if (D > 0)
            {
                    label6.Visible = true;
                    textBox5.Visible = true;
                    label7.Visible = true;
                    textBox6.Visible = true;
                    label6.Text = "X1=";
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    textBox5.Text=Convert.ToString(x1);
                    textBox6.Text = Convert.ToString(x2);
                }
            else if (D == 0)
            {
                label6.Visible = true;
                textBox5.Visible = true;
                label7.Visible = false;
                textBox6.Visible = false;
                label6.Text = "X=";
                x1 = -b / (2 * a);
                textBox5.Text = Convert.ToString(x1);
            }
            else
            {
                    label7.Visible = false;
                    textBox6.Visible = false;
                    label6.Visible = false;
                    textBox5.Visible = false;
                    MessageBox.Show("Нету решения");
            }
            }
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            output();
        }
    }
}
