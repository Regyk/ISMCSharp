using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
     
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            
            dataGridViewMas.Columns.Clear();
            if(!int.TryParse(textBoxSizeM.Text,out int size))
            {
                MessageBox.Show("Значення введено не коректно");
            }
            else
            {
                dataGridViewMas.ColumnCount=size;
                dataGridViewMas.Rows.Add();
            }
            buttonRandGen.Visible = true;
            
        }

        private void buttonRandGen_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            if (!int.TryParse(textBoxSizeM.Text, out int size))
            {
                MessageBox.Show("Значення введено не коректно");
            }
            else
            {
                double[] mas = new double[size];
                for (int i = 0; i < mas.Length; i++)
                {
                    var column1 = new DataGridViewColumn();
                    
                            mas[i] =Convert.ToDouble(rnd.Next(-1000, 1010)/10.0);
                    dataGridViewMas[i, 0].Value = mas[i];
                    }
                
            }
           
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxSizeM.Text, out int size))
            {
                MessageBox.Show("Значення введено не коректно");
            }
            else
            {
                try
                {
                    double[] mas = new double[size];
                    for (int i = 0; i < size; i++)
                    {
                        mas[i] = Convert.ToDouble(dataGridViewMas[i, 0].Value);
                    }
                    double max = mas[0], SNeg = 0, IndM = 0, maxABS = Math.Abs(mas[0]), SumIndPositive = 0, IntDigit = 0;
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (mas[i] < 0)
                        {
                            SNeg += mas[i];
                        }

                        if (max < mas[i])
                        {
                            max = mas[i];
                        }
                        if (mas[i] == max)
                        {
                            IndM = i;
                        }
                        if (maxABS < Math.Abs(mas[i]))
                        {
                            maxABS = Math.Abs(mas[i]);
                        }
                        if (mas[i] > 0)
                        {
                            SumIndPositive += i;
                        }
                        if (mas[i] % 1 == 0)
                        {
                            IntDigit++;
                        }

                    }
                    textBoxSumNeg.Text = SNeg.ToString();
                    textBoxMax.Text = max.ToString();
                    textBoxMaxIndex.Text = IndM.ToString();
                    textBoxMaxM.Text = maxABS.ToString();
                    textBoxSumIndPositive.Text = SumIndPositive.ToString();
                    textBoxIntDigit.Text = IntDigit.ToString();
                }
                catch
                {
                    MessageBox.Show("Помилка!!!");
                }
            }
        }
    }
}
